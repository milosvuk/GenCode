using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Text;
 
public class DB_invoices
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_invoices()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(invoices _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(invoices _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO invoices (id_customer,dateOfInvoice,datetimeofInvoice,numOfInvoice,typeOfInvoice,id_pos_ws,id_store,amountOfTax,amountOfDisc,amountOfInvoice,id_user,notes1,notes2,notes3,finalized,id_company) VALUES (@id_customer,@dateOfInvoice,@datetimeofInvoice,@numOfInvoice,@typeOfInvoice,@id_pos_ws,@id_store,@amountOfTax,@amountOfDisc,@amountOfInvoice,@id_user,@notes1,@notes2,@notes3,@finalized,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_customer", _tmpObject.ID_CUSTOMER));
command.Parameters.Add(new SqlParameter("@dateOfInvoice", _tmpObject.DATEOFINVOICE));
command.Parameters.Add(new SqlParameter("@datetimeofInvoice", _tmpObject.DATETIMEOFINVOICE));
command.Parameters.Add(new SqlParameter("@numOfInvoice", _tmpObject.NUMOFINVOICE));
command.Parameters.Add(new SqlParameter("@typeOfInvoice", _tmpObject.TYPEOFINVOICE));
command.Parameters.Add(new SqlParameter("@id_pos_ws", _tmpObject.ID_POS_WS));
command.Parameters.Add(new SqlParameter("@id_store", _tmpObject.ID_STORE));
command.Parameters.Add(new SqlParameter("@amountOfTax", _tmpObject.AMOUNTOFTAX));
command.Parameters.Add(new SqlParameter("@amountOfDisc", _tmpObject.AMOUNTOFDISC));
command.Parameters.Add(new SqlParameter("@amountOfInvoice", _tmpObject.AMOUNTOFINVOICE));
command.Parameters.Add(new SqlParameter("@id_user", _tmpObject.ID_USER));
command.Parameters.Add(new SqlParameter("@notes1", _tmpObject.NOTES1));
command.Parameters.Add(new SqlParameter("@notes2", _tmpObject.NOTES2));
command.Parameters.Add(new SqlParameter("@notes3", _tmpObject.NOTES3));
command.Parameters.Add(new SqlParameter("@finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@tmpid", SqlDbType.Int));
command.Parameters["@tmpid"].Direction = ParameterDirection.Output;
command.ExecuteNonQuery();
res = (int)command.Parameters["@tmpid"].Value;
return res;
}
////==========================================================================
//END ADD WITH PARAMETERS
////==========================================================================
////==========================================================================
// UPDATE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Update(invoices _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(invoices _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE invoices SET id_customer=@id_customer,dateOfInvoice=@dateofinvoice,datetimeofInvoice=@datetimeofinvoice,numOfInvoice=@numofinvoice,typeOfInvoice=@typeofinvoice,id_pos_ws=@id_pos_ws,id_store=@id_store,amountOfTax=@amountoftax,amountOfDisc=@amountofdisc,amountOfInvoice=@amountofinvoice,id_user=@id_user,notes1=@notes1,notes2=@notes2,notes3=@notes3,finalized=@finalized,id_company=@id_company  WHERE idinvoice=@idinvoice", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_customer", _tmpObject.ID_CUSTOMER));
command.Parameters.Add(new SqlParameter("@dateofinvoice", _tmpObject.DATEOFINVOICE));
command.Parameters.Add(new SqlParameter("@datetimeofinvoice", _tmpObject.DATETIMEOFINVOICE));
command.Parameters.Add(new SqlParameter("@numofinvoice", _tmpObject.NUMOFINVOICE));
command.Parameters.Add(new SqlParameter("@typeofinvoice", _tmpObject.TYPEOFINVOICE));
command.Parameters.Add(new SqlParameter("@id_pos_ws", _tmpObject.ID_POS_WS));
command.Parameters.Add(new SqlParameter("@id_store", _tmpObject.ID_STORE));
command.Parameters.Add(new SqlParameter("@amountoftax", _tmpObject.AMOUNTOFTAX));
command.Parameters.Add(new SqlParameter("@amountofdisc", _tmpObject.AMOUNTOFDISC));
command.Parameters.Add(new SqlParameter("@amountofinvoice", _tmpObject.AMOUNTOFINVOICE));
command.Parameters.Add(new SqlParameter("@id_user", _tmpObject.ID_USER));
command.Parameters.Add(new SqlParameter("@notes1", _tmpObject.NOTES1));
command.Parameters.Add(new SqlParameter("@notes2", _tmpObject.NOTES2));
command.Parameters.Add(new SqlParameter("@notes3", _tmpObject.NOTES3));
command.Parameters.Add(new SqlParameter("@finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idinvoice", _tmpObject.IDINVOICE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(invoices _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(invoices _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE invoices  WHERE idinvoice=@idinvoice", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idinvoice", _tmpObject.IDINVOICE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public invoices GetById(int _id)
{
invoices tmpObject = new invoices();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From invoices WHERE idinvoice=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDINVOICE = (System.Int32)dr["idinvoice"];
tmpObject.ID_CUSTOMER = (System.Int32)dr["id_customer"];
tmpObject.DATEOFINVOICE = (System.DateTime)dr["dateOfInvoice"];
tmpObject.DATETIMEOFINVOICE = (System.DateTime)dr["datetimeofInvoice"];
tmpObject.NUMOFINVOICE = (System.Int32)dr["numOfInvoice"];
tmpObject.TYPEOFINVOICE = (System.Int32)dr["typeOfInvoice"];
tmpObject.ID_POS_WS = (System.Int32)dr["id_pos_ws"];
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
tmpObject.AMOUNTOFTAX = (System.Decimal)dr["amountOfTax"];
tmpObject.AMOUNTOFDISC = (System.Decimal)dr["amountOfDisc"];
tmpObject.AMOUNTOFINVOICE = (System.Decimal)dr["amountOfInvoice"];
tmpObject.ID_USER = (System.Int32)dr["id_user"];
tmpObject.NOTES1 = (System.String)dr["notes1"];
tmpObject.NOTES2 = (System.String)dr["notes2"];
tmpObject.NOTES3 = (System.String)dr["notes3"];
tmpObject.FINALIZED = (System.Int32)dr["finalized"];
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
////==========================================================================
//GET ALL ---------------------------------------------
////==========================================================================
public List<invoices> GetAll()
{
List<invoices> tmpList = new List<invoices>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From invoices", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
invoices tmpObject = new invoices();
msgRecField="-";
msgRecField=msgRecField + "idinvoice=";
msgRecField=msgRecField + dr["idinvoice"].ToString() +"=";
tmpObject.IDINVOICE = (System.Int32)dr["idinvoice"];
msgRecField=msgRecField + "id_customer=";
msgRecField=msgRecField + dr["id_customer"].ToString() +"=";
tmpObject.ID_CUSTOMER = (System.Int32)dr["id_customer"];
msgRecField=msgRecField + "dateOfInvoice=";
msgRecField=msgRecField + dr["dateOfInvoice"].ToString() +"=";
tmpObject.DATEOFINVOICE = (System.DateTime)dr["dateOfInvoice"];
msgRecField=msgRecField + "datetimeofInvoice=";
msgRecField=msgRecField + dr["datetimeofInvoice"].ToString() +"=";
tmpObject.DATETIMEOFINVOICE = (System.DateTime)dr["datetimeofInvoice"];
msgRecField=msgRecField + "numOfInvoice=";
msgRecField=msgRecField + dr["numOfInvoice"].ToString() +"=";
tmpObject.NUMOFINVOICE = (System.Int32)dr["numOfInvoice"];
msgRecField=msgRecField + "typeOfInvoice=";
msgRecField=msgRecField + dr["typeOfInvoice"].ToString() +"=";
tmpObject.TYPEOFINVOICE = (System.Int32)dr["typeOfInvoice"];
msgRecField=msgRecField + "id_pos_ws=";
msgRecField=msgRecField + dr["id_pos_ws"].ToString() +"=";
tmpObject.ID_POS_WS = (System.Int32)dr["id_pos_ws"];
msgRecField=msgRecField + "id_store=";
msgRecField=msgRecField + dr["id_store"].ToString() +"=";
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
msgRecField=msgRecField + "amountOfTax=";
msgRecField=msgRecField + dr["amountOfTax"].ToString() +"=";
tmpObject.AMOUNTOFTAX = (System.Decimal)dr["amountOfTax"];
msgRecField=msgRecField + "amountOfDisc=";
msgRecField=msgRecField + dr["amountOfDisc"].ToString() +"=";
tmpObject.AMOUNTOFDISC = (System.Decimal)dr["amountOfDisc"];
msgRecField=msgRecField + "amountOfInvoice=";
msgRecField=msgRecField + dr["amountOfInvoice"].ToString() +"=";
tmpObject.AMOUNTOFINVOICE = (System.Decimal)dr["amountOfInvoice"];
msgRecField=msgRecField + "id_user=";
msgRecField=msgRecField + dr["id_user"].ToString() +"=";
tmpObject.ID_USER = (System.Int32)dr["id_user"];
msgRecField=msgRecField + "notes1=";
msgRecField=msgRecField + dr["notes1"].ToString() +"=";
tmpObject.NOTES1 = (System.String)dr["notes1"];
msgRecField=msgRecField + "notes2=";
msgRecField=msgRecField + dr["notes2"].ToString() +"=";
tmpObject.NOTES2 = (System.String)dr["notes2"];
msgRecField=msgRecField + "notes3=";
msgRecField=msgRecField + dr["notes3"].ToString() +"=";
tmpObject.NOTES3 = (System.String)dr["notes3"];
msgRecField=msgRecField + "finalized=";
msgRecField=msgRecField + dr["finalized"].ToString() +"=";
tmpObject.FINALIZED = (System.Int32)dr["finalized"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
tmpList.Add(tmpObject);
}
 catch (Exception ex)
{
alErrors.Add(LogException(ex));
alErrors.Add(msgRecField);
msgRecField="-";
}
}
dr.Close();
conn.Close();
return tmpList;
}
////==========================================================================
//END OF GetALL ==============
////==========================================================================
////==========================================================================
//GET ALL by cond ---------------------------------------------
////==========================================================================
public List<invoices> GetAllByCond(string cond)
{
List<invoices> tmpList = new List<invoices>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From invoices Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
invoices tmpObject = new invoices();
msgRecField="-";
msgRecField=msgRecField + "idinvoice=";
msgRecField=msgRecField + dr["idinvoice"].ToString() +"=";
tmpObject.IDINVOICE = (System.Int32)dr["idinvoice"];
msgRecField=msgRecField + "id_customer=";
msgRecField=msgRecField + dr["id_customer"].ToString() +"=";
tmpObject.ID_CUSTOMER = (System.Int32)dr["id_customer"];
msgRecField=msgRecField + "dateOfInvoice=";
msgRecField=msgRecField + dr["dateOfInvoice"].ToString() +"=";
tmpObject.DATEOFINVOICE = (System.DateTime)dr["dateOfInvoice"];
msgRecField=msgRecField + "datetimeofInvoice=";
msgRecField=msgRecField + dr["datetimeofInvoice"].ToString() +"=";
tmpObject.DATETIMEOFINVOICE = (System.DateTime)dr["datetimeofInvoice"];
msgRecField=msgRecField + "numOfInvoice=";
msgRecField=msgRecField + dr["numOfInvoice"].ToString() +"=";
tmpObject.NUMOFINVOICE = (System.Int32)dr["numOfInvoice"];
msgRecField=msgRecField + "typeOfInvoice=";
msgRecField=msgRecField + dr["typeOfInvoice"].ToString() +"=";
tmpObject.TYPEOFINVOICE = (System.Int32)dr["typeOfInvoice"];
msgRecField=msgRecField + "id_pos_ws=";
msgRecField=msgRecField + dr["id_pos_ws"].ToString() +"=";
tmpObject.ID_POS_WS = (System.Int32)dr["id_pos_ws"];
msgRecField=msgRecField + "id_store=";
msgRecField=msgRecField + dr["id_store"].ToString() +"=";
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
msgRecField=msgRecField + "amountOfTax=";
msgRecField=msgRecField + dr["amountOfTax"].ToString() +"=";
tmpObject.AMOUNTOFTAX = (System.Decimal)dr["amountOfTax"];
msgRecField=msgRecField + "amountOfDisc=";
msgRecField=msgRecField + dr["amountOfDisc"].ToString() +"=";
tmpObject.AMOUNTOFDISC = (System.Decimal)dr["amountOfDisc"];
msgRecField=msgRecField + "amountOfInvoice=";
msgRecField=msgRecField + dr["amountOfInvoice"].ToString() +"=";
tmpObject.AMOUNTOFINVOICE = (System.Decimal)dr["amountOfInvoice"];
msgRecField=msgRecField + "id_user=";
msgRecField=msgRecField + dr["id_user"].ToString() +"=";
tmpObject.ID_USER = (System.Int32)dr["id_user"];
msgRecField=msgRecField + "notes1=";
msgRecField=msgRecField + dr["notes1"].ToString() +"=";
tmpObject.NOTES1 = (System.String)dr["notes1"];
msgRecField=msgRecField + "notes2=";
msgRecField=msgRecField + dr["notes2"].ToString() +"=";
tmpObject.NOTES2 = (System.String)dr["notes2"];
msgRecField=msgRecField + "notes3=";
msgRecField=msgRecField + dr["notes3"].ToString() +"=";
tmpObject.NOTES3 = (System.String)dr["notes3"];
msgRecField=msgRecField + "finalized=";
msgRecField=msgRecField + dr["finalized"].ToString() +"=";
tmpObject.FINALIZED = (System.Int32)dr["finalized"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
tmpList.Add(tmpObject);
}
 catch (Exception ex)
{
alErrors.Add(LogException(ex));
alErrors.Add(msgRecField);
msgRecField="-";
}
}
dr.Close();
conn.Close();
return tmpList;
}
////==========================================================================
//END OF GetALL ==============
////==========================================================================
////==========================================================================
 
public string CheckStringFromField(string StringToCheck, int typeOfReturn)
{
string res = StringToCheck;
if (typeOfReturn == 1 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="No Data";
return res;
}
if (typeOfReturn == 2 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="0";
return res;
}
if (typeOfReturn == 3 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="01/01/1800";
return res;
}
return res;
// using  like CheckStringFromTxtFile(fields[0],1);
}

    private string GetExceptionTypeStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionTypeStack(e.InnerException);
        message = message + "   " + e.GetType().ToString();
        return message;
      }
      else
      {
        return "   " + e.GetType().ToString();
      }
    }

    private string GetExceptionMessageStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionMessageStack(e.InnerException);
        message = message + "   " + e.Message;
        return message;
      }
      else
      {
        return "   " + e.Message;
      }
    }

    private string GetExceptionCallStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionCallStack(e.InnerException);
        message = message + "--- Next Call Stack: ";
        message =  message + e.StackTrace;
        return message;
      }
      else
      {
        return e.StackTrace;
      }
    }


   public string LogException(Exception exception)
    {
      string  error = "";

      error = "Exception classes:   ";
      error = error + GetExceptionTypeStack(exception);
      error = error + " ";
      error = error + " Exception messages: ";
      error = error +GetExceptionMessageStack(exception);

      error= error + " ";
      error= error +" Stack Traces: ";
      error= error +GetExceptionCallStack(exception);
     
      return error;
    }
}
 
