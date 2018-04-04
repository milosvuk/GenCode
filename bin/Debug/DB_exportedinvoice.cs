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
 
public class DB_exportedinvoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_exportedinvoice()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(exportedinvoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(exportedinvoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO exportedinvoice (idinvoice,typeofac,accountreference,nominalacref,department,dateofinv,referencecode,details,netamount,taxcode,taxamount,exchangerate,extrareference,username,projectrefn,costocderefn) VALUES (@idinvoice,@typeofac,@accountreference,@nominalacref,@department,@dateofinv,@referencecode,@details,@netamount,@taxcode,@taxamount,@exchangerate,@extrareference,@username,@projectrefn,@costocderefn) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idinvoice", _tmpObject.IDINVOICE));
command.Parameters.Add(new SqlParameter("@typeofac", _tmpObject.TYPEOFAC));
command.Parameters.Add(new SqlParameter("@accountreference", _tmpObject.ACCOUNTREFERENCE));
command.Parameters.Add(new SqlParameter("@nominalacref", _tmpObject.NOMINALACREF));
command.Parameters.Add(new SqlParameter("@department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@dateofinv", _tmpObject.DATEOFINV));
command.Parameters.Add(new SqlParameter("@referencecode", _tmpObject.REFERENCECODE));
command.Parameters.Add(new SqlParameter("@details", _tmpObject.DETAILS));
command.Parameters.Add(new SqlParameter("@netamount", _tmpObject.NETAMOUNT));
command.Parameters.Add(new SqlParameter("@taxcode", _tmpObject.TAXCODE));
command.Parameters.Add(new SqlParameter("@taxamount", _tmpObject.TAXAMOUNT));
command.Parameters.Add(new SqlParameter("@exchangerate", _tmpObject.EXCHANGERATE));
command.Parameters.Add(new SqlParameter("@extrareference", _tmpObject.EXTRAREFERENCE));
command.Parameters.Add(new SqlParameter("@username", _tmpObject.USERNAME));
command.Parameters.Add(new SqlParameter("@projectrefn", _tmpObject.PROJECTREFN));
command.Parameters.Add(new SqlParameter("@costocderefn", _tmpObject.COSTOCDEREFN));
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
 
public int Update(exportedinvoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(exportedinvoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE exportedinvoice SET idinvoice=@idinvoice,typeofac=@typeofac,accountreference=@accountreference,nominalacref=@nominalacref,department=@department,dateofinv=@dateofinv,referencecode=@referencecode,details=@details,netamount=@netamount,taxcode=@taxcode,taxamount=@taxamount,exchangerate=@exchangerate,extrareference=@extrareference,username=@username,projectrefn=@projectrefn,costocderefn=@costocderefn  WHERE idexportedinvoice=@idexportedinvoice", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idinvoice", _tmpObject.IDINVOICE));
command.Parameters.Add(new SqlParameter("@typeofac", _tmpObject.TYPEOFAC));
command.Parameters.Add(new SqlParameter("@accountreference", _tmpObject.ACCOUNTREFERENCE));
command.Parameters.Add(new SqlParameter("@nominalacref", _tmpObject.NOMINALACREF));
command.Parameters.Add(new SqlParameter("@department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@dateofinv", _tmpObject.DATEOFINV));
command.Parameters.Add(new SqlParameter("@referencecode", _tmpObject.REFERENCECODE));
command.Parameters.Add(new SqlParameter("@details", _tmpObject.DETAILS));
command.Parameters.Add(new SqlParameter("@netamount", _tmpObject.NETAMOUNT));
command.Parameters.Add(new SqlParameter("@taxcode", _tmpObject.TAXCODE));
command.Parameters.Add(new SqlParameter("@taxamount", _tmpObject.TAXAMOUNT));
command.Parameters.Add(new SqlParameter("@exchangerate", _tmpObject.EXCHANGERATE));
command.Parameters.Add(new SqlParameter("@extrareference", _tmpObject.EXTRAREFERENCE));
command.Parameters.Add(new SqlParameter("@username", _tmpObject.USERNAME));
command.Parameters.Add(new SqlParameter("@projectrefn", _tmpObject.PROJECTREFN));
command.Parameters.Add(new SqlParameter("@costocderefn", _tmpObject.COSTOCDEREFN));
command.Parameters.Add(new SqlParameter("@idexportedinvoice", _tmpObject.IDEXPORTEDINVOICE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(exportedinvoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(exportedinvoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM exportedinvoice  WHERE idexportedinvoice=@idexportedinvoice", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idexportedinvoice", _tmpObject.IDEXPORTEDINVOICE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public exportedinvoice GetById(int _id)
{
exportedinvoice tmpObject = new exportedinvoice();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From exportedinvoice WHERE idexportedinvoice=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDEXPORTEDINVOICE = (System.Int32)dr["idexportedinvoice"];
tmpObject.IDINVOICE = (System.Int32)dr["idinvoice"];
tmpObject.TYPEOFAC = (System.String)dr["typeofac"];
tmpObject.ACCOUNTREFERENCE = (System.String)dr["accountreference"];
tmpObject.NOMINALACREF = (System.String)dr["nominalacref"];
tmpObject.DEPARTMENT = (System.String)dr["department"];
tmpObject.DATEOFINV = (System.String)dr["dateofinv"];
tmpObject.REFERENCECODE = (System.String)dr["referencecode"];
tmpObject.DETAILS = (System.String)dr["details"];
tmpObject.NETAMOUNT = (System.String)dr["netamount"];
tmpObject.TAXCODE = (System.String)dr["taxcode"];
tmpObject.TAXAMOUNT = (System.String)dr["taxamount"];
tmpObject.EXCHANGERATE = (System.String)dr["exchangerate"];
tmpObject.EXTRAREFERENCE = (System.String)dr["extrareference"];
tmpObject.USERNAME = (System.String)dr["username"];
tmpObject.PROJECTREFN = (System.String)dr["projectrefn"];
tmpObject.COSTOCDEREFN = (System.String)dr["costocderefn"];
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
public List<exportedinvoice> GetAll()
{
List<exportedinvoice> tmpList = new List<exportedinvoice>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From exportedinvoice", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
exportedinvoice tmpObject = new exportedinvoice();
msgRecField="-";
msgRecField=msgRecField + "idexportedinvoice=";
msgRecField=msgRecField + dr["idexportedinvoice"].ToString() +"=";
tmpObject.IDEXPORTEDINVOICE = (System.Int32)dr["idexportedinvoice"];
msgRecField=msgRecField + "idinvoice=";
msgRecField=msgRecField + dr["idinvoice"].ToString() +"=";
tmpObject.IDINVOICE = (System.Int32)dr["idinvoice"];
msgRecField=msgRecField + "typeofac=";
msgRecField=msgRecField + dr["typeofac"].ToString() +"=";
tmpObject.TYPEOFAC = (System.String)dr["typeofac"];
msgRecField=msgRecField + "accountreference=";
msgRecField=msgRecField + dr["accountreference"].ToString() +"=";
tmpObject.ACCOUNTREFERENCE = (System.String)dr["accountreference"];
msgRecField=msgRecField + "nominalacref=";
msgRecField=msgRecField + dr["nominalacref"].ToString() +"=";
tmpObject.NOMINALACREF = (System.String)dr["nominalacref"];
msgRecField=msgRecField + "department=";
msgRecField=msgRecField + dr["department"].ToString() +"=";
tmpObject.DEPARTMENT = (System.String)dr["department"];
msgRecField=msgRecField + "dateofinv=";
msgRecField=msgRecField + dr["dateofinv"].ToString() +"=";
tmpObject.DATEOFINV = (System.String)dr["dateofinv"];
msgRecField=msgRecField + "referencecode=";
msgRecField=msgRecField + dr["referencecode"].ToString() +"=";
tmpObject.REFERENCECODE = (System.String)dr["referencecode"];
msgRecField=msgRecField + "details=";
msgRecField=msgRecField + dr["details"].ToString() +"=";
tmpObject.DETAILS = (System.String)dr["details"];
msgRecField=msgRecField + "netamount=";
msgRecField=msgRecField + dr["netamount"].ToString() +"=";
tmpObject.NETAMOUNT = (System.String)dr["netamount"];
msgRecField=msgRecField + "taxcode=";
msgRecField=msgRecField + dr["taxcode"].ToString() +"=";
tmpObject.TAXCODE = (System.String)dr["taxcode"];
msgRecField=msgRecField + "taxamount=";
msgRecField=msgRecField + dr["taxamount"].ToString() +"=";
tmpObject.TAXAMOUNT = (System.String)dr["taxamount"];
msgRecField=msgRecField + "exchangerate=";
msgRecField=msgRecField + dr["exchangerate"].ToString() +"=";
tmpObject.EXCHANGERATE = (System.String)dr["exchangerate"];
msgRecField=msgRecField + "extrareference=";
msgRecField=msgRecField + dr["extrareference"].ToString() +"=";
tmpObject.EXTRAREFERENCE = (System.String)dr["extrareference"];
msgRecField=msgRecField + "username=";
msgRecField=msgRecField + dr["username"].ToString() +"=";
tmpObject.USERNAME = (System.String)dr["username"];
msgRecField=msgRecField + "projectrefn=";
msgRecField=msgRecField + dr["projectrefn"].ToString() +"=";
tmpObject.PROJECTREFN = (System.String)dr["projectrefn"];
msgRecField=msgRecField + "costocderefn=";
msgRecField=msgRecField + dr["costocderefn"].ToString() +"=";
tmpObject.COSTOCDEREFN = (System.String)dr["costocderefn"];
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
public List<exportedinvoice> GetAllByCond(string cond)
{
List<exportedinvoice> tmpList = new List<exportedinvoice>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From exportedinvoice Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
exportedinvoice tmpObject = new exportedinvoice();
msgRecField="-";
msgRecField=msgRecField + "idexportedinvoice=";
msgRecField=msgRecField + dr["idexportedinvoice"].ToString() +"=";
tmpObject.IDEXPORTEDINVOICE = (System.Int32)dr["idexportedinvoice"];
msgRecField=msgRecField + "idinvoice=";
msgRecField=msgRecField + dr["idinvoice"].ToString() +"=";
tmpObject.IDINVOICE = (System.Int32)dr["idinvoice"];
msgRecField=msgRecField + "typeofac=";
msgRecField=msgRecField + dr["typeofac"].ToString() +"=";
tmpObject.TYPEOFAC = (System.String)dr["typeofac"];
msgRecField=msgRecField + "accountreference=";
msgRecField=msgRecField + dr["accountreference"].ToString() +"=";
tmpObject.ACCOUNTREFERENCE = (System.String)dr["accountreference"];
msgRecField=msgRecField + "nominalacref=";
msgRecField=msgRecField + dr["nominalacref"].ToString() +"=";
tmpObject.NOMINALACREF = (System.String)dr["nominalacref"];
msgRecField=msgRecField + "department=";
msgRecField=msgRecField + dr["department"].ToString() +"=";
tmpObject.DEPARTMENT = (System.String)dr["department"];
msgRecField=msgRecField + "dateofinv=";
msgRecField=msgRecField + dr["dateofinv"].ToString() +"=";
tmpObject.DATEOFINV = (System.String)dr["dateofinv"];
msgRecField=msgRecField + "referencecode=";
msgRecField=msgRecField + dr["referencecode"].ToString() +"=";
tmpObject.REFERENCECODE = (System.String)dr["referencecode"];
msgRecField=msgRecField + "details=";
msgRecField=msgRecField + dr["details"].ToString() +"=";
tmpObject.DETAILS = (System.String)dr["details"];
msgRecField=msgRecField + "netamount=";
msgRecField=msgRecField + dr["netamount"].ToString() +"=";
tmpObject.NETAMOUNT = (System.String)dr["netamount"];
msgRecField=msgRecField + "taxcode=";
msgRecField=msgRecField + dr["taxcode"].ToString() +"=";
tmpObject.TAXCODE = (System.String)dr["taxcode"];
msgRecField=msgRecField + "taxamount=";
msgRecField=msgRecField + dr["taxamount"].ToString() +"=";
tmpObject.TAXAMOUNT = (System.String)dr["taxamount"];
msgRecField=msgRecField + "exchangerate=";
msgRecField=msgRecField + dr["exchangerate"].ToString() +"=";
tmpObject.EXCHANGERATE = (System.String)dr["exchangerate"];
msgRecField=msgRecField + "extrareference=";
msgRecField=msgRecField + dr["extrareference"].ToString() +"=";
tmpObject.EXTRAREFERENCE = (System.String)dr["extrareference"];
msgRecField=msgRecField + "username=";
msgRecField=msgRecField + dr["username"].ToString() +"=";
tmpObject.USERNAME = (System.String)dr["username"];
msgRecField=msgRecField + "projectrefn=";
msgRecField=msgRecField + dr["projectrefn"].ToString() +"=";
tmpObject.PROJECTREFN = (System.String)dr["projectrefn"];
msgRecField=msgRecField + "costocderefn=";
msgRecField=msgRecField + dr["costocderefn"].ToString() +"=";
tmpObject.COSTOCDEREFN = (System.String)dr["costocderefn"];
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
 
