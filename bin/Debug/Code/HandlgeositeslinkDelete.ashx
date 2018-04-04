<%@ WebHandler Language="C#" Class="HandlgeositeslinkDelete" %>
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
public class HandlgeositeslinkDelete : IHttpHandler {
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
        List<geositeslink> _list = JsonConvert.DeserializeObject<List<geositeslink>>(jsonString);
        DB_geositeslink _db = new DB_geositeslink();
        geositeslink _obj = new geositeslink();
		_obj = (geositeslink)_list[0];
         int res = _db.Delete(_obj);
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
