<%@ WebHandler Language="C#" Class="Handllicences_desc_huntersGet" %>
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
public class Handllicences_desc_huntersGet : IHttpHandler {
    public void ProcessRequest (HttpContext context) {
        // .ashx
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
        List<Filter> list = JsonConvert.DeserializeObject<List<Filter>>(jsonString);
        //callgetMethod
        DB_licences_desc_hunters _db = new DB_licences_desc_hunters();
        List<licences_desc_hunters> listitems = new List<licences_desc_hunters>();
        //string cond = " id_store=" + list[0].parametrs;
        string cond = list[0].parametrs;
        listitems = _db.GetAllByCond(cond);
        context.Response.Clear();
        context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(listitems.ToArray()));
        context.Response.Flush();
        context.Response.End();
    }
    public bool IsReusable {
        get {
            return false;
        }
    }
    public class Filter
    {
        public string parametrs { get; set; }
    }
    // getMethod
}
