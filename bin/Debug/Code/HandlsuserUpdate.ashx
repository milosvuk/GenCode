<%@ WebHandler Language="C#" Class="HandlsuserUpdate" %>
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft;
using Newtonsoft.Json;
using System.Data;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
public class HandlsuserUpdate : IHttpHandler {
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        var jsonString = String.Empty;
        context.Request.InputStream.Position = 0;
        using (var inputStream = new StreamReader(context.Request.InputStream))
        {
            jsonString = inputStream.ReadToEnd();
        }
        char s = '"';
        string apo = s.ToString();
        jsonString = jsonString.Replace(apo, "");
        List<suser> _list = JsonConvert.DeserializeObject<List<suser>>(jsonString);
        DB_suser _db = new DB_suser();
        suser _obj = new suser();
		_obj = (suser)_list[0];
         int res = _db.Update(_obj);
        context.Response.Clear();
        context.Response.Write(res);
        context.Response.Flush();
        context.Response.End();
    }
    public bool IsReusable {
        get {
            return false;
        }
    }
}
