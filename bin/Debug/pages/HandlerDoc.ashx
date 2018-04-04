<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class Handler : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {


        //context.Request.QueryString["CaseId"] != null && context.Request.QueryString["tempimageid"] != "")
        {
            //				id = Convert.ToInt32(context.Request.QueryString["tempimageid"]);

            //int caseId = Session["Case"];


            string str_doc = context.Request.QueryString["DocForm"];
            int docform = int.Parse(str_doc);
             
            //cases _case = new cases();
            //DB_cases db_case = new DB_cases();

            documentsb df = new documentsb();
            DB_documentsb dfb = new DB_documentsb();

            df = dfb.GetById(docform);

            

            //        Excel 2007  application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
            //Word 2007 application/vnd.openxmlformats-officedocument.wordprocessingml.document

            //Word 2003 application/msword

            //Zipped archive  application/x-zip-compressed 

            //context.Response.AddHeader(df.FORMNAME, df.FORMNAME); 

             context.Response.AddHeader("content-disposition", "attachment;filename="+ df.TYPEOFDOC);
            //context.Response.AddHeader("content-disposition", "attachment;filename=" + _case.NAMEOFFILE);

            //context.Response.ContentType = "text/plain";

            context.Response.ContentType = "application/msword";


            context.Response.BinaryWrite(df.DOCINBINFORMAT);

            //context.Response.BinaryWrite(_case.AWARDFILE);
            context.Response.End();
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}