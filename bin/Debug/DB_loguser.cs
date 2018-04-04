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
 
public class DB_loguser
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_loguser()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(loguser _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(loguser _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO loguser (username,logdate,logdatetime,ipaddress,details,id_company) VALUES (@username,@logdate,@logdatetime,@ipaddress,@details,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@username", _tmpObject.USERNAME));
command.Parameters.Add(new SqlParameter("@logdate", _tmpObject.LOGDATE));
command.Parameters.Add(new SqlParameter("@logdatetime", _tmpObject.LOGDATETIME));
command.Parameters.Add(new SqlParameter("@ipaddress", _tmpObject.IPADDRESS));
command.Parameters.Add(new SqlParameter("@details", _tmpObject.DETAILS));
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
 
public int Update(loguser _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(loguser _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE loguser SET username=@username,logdate=@logdate,logdatetime=@logdatetime,ipaddress=@ipaddress,details=@details,id_company=@id_company  WHERE idUserLog=@iduserlog", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@username", _tmpObject.USERNAME));
command.Parameters.Add(new SqlParameter("@logdate", _tmpObject.LOGDATE));
command.Parameters.Add(new SqlParameter("@logdatetime", _tmpObject.LOGDATETIME));
command.Parameters.Add(new SqlParameter("@ipaddress", _tmpObject.IPADDRESS));
command.Parameters.Add(new SqlParameter("@details", _tmpObject.DETAILS));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@iduserlog", _tmpObject.IDUSERLOG));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(loguser _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(loguser _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM loguser  WHERE idUserLog=@iduserlog", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@iduserlog", _tmpObject.IDUSERLOG));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public loguser GetById(int _id)
{
loguser tmpObject = new loguser();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From loguser WHERE idUserLog=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDUSERLOG = (System.Int32)dr["idUserLog"];
tmpObject.USERNAME = (System.String)dr["username"];
tmpObject.LOGDATE = (System.DateTime)dr["logdate"];
tmpObject.LOGDATETIME = (System.DateTime)dr["logdatetime"];
tmpObject.IPADDRESS = (System.String)dr["ipaddress"];
tmpObject.DETAILS = (System.String)dr["details"];
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
public List<loguser> GetAll()
{
List<loguser> tmpList = new List<loguser>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From loguser", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
loguser tmpObject = new loguser();
msgRecField="-";
msgRecField=msgRecField + "idUserLog=";
msgRecField=msgRecField + dr["idUserLog"].ToString() +"=";
tmpObject.IDUSERLOG = (System.Int32)dr["idUserLog"];
msgRecField=msgRecField + "username=";
msgRecField=msgRecField + dr["username"].ToString() +"=";
tmpObject.USERNAME = (System.String)dr["username"];
msgRecField=msgRecField + "logdate=";
msgRecField=msgRecField + dr["logdate"].ToString() +"=";
tmpObject.LOGDATE = (System.DateTime)dr["logdate"];
msgRecField=msgRecField + "logdatetime=";
msgRecField=msgRecField + dr["logdatetime"].ToString() +"=";
tmpObject.LOGDATETIME = (System.DateTime)dr["logdatetime"];
msgRecField=msgRecField + "ipaddress=";
msgRecField=msgRecField + dr["ipaddress"].ToString() +"=";
tmpObject.IPADDRESS = (System.String)dr["ipaddress"];
msgRecField=msgRecField + "details=";
msgRecField=msgRecField + dr["details"].ToString() +"=";
tmpObject.DETAILS = (System.String)dr["details"];
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
public List<loguser> GetAllByCond(string cond)
{
List<loguser> tmpList = new List<loguser>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From loguser Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
loguser tmpObject = new loguser();
msgRecField="-";
msgRecField=msgRecField + "idUserLog=";
msgRecField=msgRecField + dr["idUserLog"].ToString() +"=";
tmpObject.IDUSERLOG = (System.Int32)dr["idUserLog"];
msgRecField=msgRecField + "username=";
msgRecField=msgRecField + dr["username"].ToString() +"=";
tmpObject.USERNAME = (System.String)dr["username"];
msgRecField=msgRecField + "logdate=";
msgRecField=msgRecField + dr["logdate"].ToString() +"=";
tmpObject.LOGDATE = (System.DateTime)dr["logdate"];
msgRecField=msgRecField + "logdatetime=";
msgRecField=msgRecField + dr["logdatetime"].ToString() +"=";
tmpObject.LOGDATETIME = (System.DateTime)dr["logdatetime"];
msgRecField=msgRecField + "ipaddress=";
msgRecField=msgRecField + dr["ipaddress"].ToString() +"=";
tmpObject.IPADDRESS = (System.String)dr["ipaddress"];
msgRecField=msgRecField + "details=";
msgRecField=msgRecField + dr["details"].ToString() +"=";
tmpObject.DETAILS = (System.String)dr["details"];
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
 
