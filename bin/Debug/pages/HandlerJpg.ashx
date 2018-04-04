<%@ WebHandler Language="C#" Class="HandlerJpg" %>

using System;
using System.Web;

public class HandlerJpg : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {

        string str_doc = context.Request.QueryString["idRecDoc"];
        int docform = int.Parse(str_doc);

        //cases _case = new cases();
        //DB_cases db_case = new DB_cases();

        documentsb df = new documentsb();
        DB_documentsb dfb = new DB_documentsb();

        df = dfb.GetById(docform);

        context.Response.AddHeader("content-disposition", "attachment;filename=" + df.TYPEOFDOC);
        //// IMPORTANT ///// context.Response.ContentType = "application/pdf";  // 

        //context.Response.ContentType = "text/plain";
        context.Response.ContentType = "application/jpeg";
        context.Response.BinaryWrite(df.DOCINBINFORMAT);
        //context.Response.Write("Hello World");

        context.Response.End();
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}