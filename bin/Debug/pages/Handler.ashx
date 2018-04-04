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


            //// IMPORTANT /////string str_caseId = context.Request.QueryString["CaseId"];
            //// IMPORTANT /////  int caseId = int.Parse(str_caseId);

            //// IMPORTANT /////cases _case = new cases();
            //// IMPORTANT ///// DB_cases db_case = new DB_cases();

            //docforms df = new docforms();
            //DB_Docforms dfb = new DB_Docforms();

            //df = dfb.GetById(4);

            //// IMPORTANT /////_case = db_case.GetById(caseId);

            

            //        Excel 2007  application/vnd.openxmlformats-officedocument.spreadsheetml.sheet
            //Word 2007 application/vnd.openxmlformats-officedocument.wordprocessingml.document

            //Word 2003 application/msword

            //Zipped archive  application/x-zip-compressed 

            //context.Response.AddHeader(df.FORMNAME, df.FORMNAME); 

            //*****//  /********///   context.Response.AddHeader("content-disposition", "attachment;filename="+ df.FORMNAME);
         
            //// IMPORTANT /////context.Response.AddHeader("content-disposition", "attachment;filename=" + _case.NAMEOFFILE);

            //context.Response.ContentType = "text/plain";

            //*****//  /********/// context.Response.ContentType = "application/msword";


            //// IMPORTANT ///// context.Response.ContentType = "application/pdf";  // 


            //// IMPORTANT ///// context.Response.BinaryWrite(_case.AWARDFILE);
            //// IMPORTANT ///// context.Response.End();
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}