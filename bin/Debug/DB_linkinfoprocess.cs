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
 
public class DB_linkinfoprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_linkinfoprocess()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(linkinfoprocess _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(linkinfoprocess _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO linkinfoprocess (NameOfInformation,NameOfProcess,id_info,id_process) VALUES (@NameOfInformation,@NameOfProcess,@id_info,@id_process) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@NameOfInformation", _tmpObject.NAMEOFINFORMATION));
command.Parameters.Add(new SqlParameter("@NameOfProcess", _tmpObject.NAMEOFPROCESS));
command.Parameters.Add(new SqlParameter("@id_info", _tmpObject.ID_INFO));
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
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
 
public int Update(linkinfoprocess _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(linkinfoprocess _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE linkinfoprocess SET NameOfInformation=@nameofinformation,NameOfProcess=@nameofprocess,id_info=@id_info,id_process=@id_process  WHERE idprojectprocessinfo=@idprojectprocessinfo", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@nameofinformation", _tmpObject.NAMEOFINFORMATION));
command.Parameters.Add(new SqlParameter("@nameofprocess", _tmpObject.NAMEOFPROCESS));
command.Parameters.Add(new SqlParameter("@id_info", _tmpObject.ID_INFO));
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
command.Parameters.Add(new SqlParameter("@idprojectprocessinfo", _tmpObject.IDPROJECTPROCESSINFO));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(linkinfoprocess _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(linkinfoprocess _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE linkinfoprocess  WHERE idprojectprocessinfo=@idprojectprocessinfo", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idprojectprocessinfo", _tmpObject.IDPROJECTPROCESSINFO));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public linkinfoprocess GetById(int _id)
{
linkinfoprocess tmpObject = new linkinfoprocess();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkinfoprocess WHERE idprojectprocessinfo=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROJECTPROCESSINFO = (System.Int32)dr["idprojectprocessinfo"];
tmpObject.NAMEOFINFORMATION = (System.String)dr["NameOfInformation"];
tmpObject.NAMEOFPROCESS = (System.String)dr["NameOfProcess"];
tmpObject.ID_INFO = (System.Int32)dr["id_info"];
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
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
public List<linkinfoprocess> GetAll()
{
List<linkinfoprocess> tmpList = new List<linkinfoprocess>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkinfoprocess", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
linkinfoprocess tmpObject = new linkinfoprocess();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocessinfo=";
msgRecField=msgRecField + dr["idprojectprocessinfo"].ToString() +"=";
tmpObject.IDPROJECTPROCESSINFO = (System.Int32)dr["idprojectprocessinfo"];
msgRecField=msgRecField + "NameOfInformation=";
msgRecField=msgRecField + dr["NameOfInformation"].ToString() +"=";
tmpObject.NAMEOFINFORMATION = (System.String)dr["NameOfInformation"];
msgRecField=msgRecField + "NameOfProcess=";
msgRecField=msgRecField + dr["NameOfProcess"].ToString() +"=";
tmpObject.NAMEOFPROCESS = (System.String)dr["NameOfProcess"];
msgRecField=msgRecField + "id_info=";
msgRecField=msgRecField + dr["id_info"].ToString() +"=";
tmpObject.ID_INFO = (System.Int32)dr["id_info"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
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
public List<linkinfoprocess> GetAllByCond(string cond)
{
List<linkinfoprocess> tmpList = new List<linkinfoprocess>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkinfoprocess Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
linkinfoprocess tmpObject = new linkinfoprocess();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocessinfo=";
msgRecField=msgRecField + dr["idprojectprocessinfo"].ToString() +"=";
tmpObject.IDPROJECTPROCESSINFO = (System.Int32)dr["idprojectprocessinfo"];
msgRecField=msgRecField + "NameOfInformation=";
msgRecField=msgRecField + dr["NameOfInformation"].ToString() +"=";
tmpObject.NAMEOFINFORMATION = (System.String)dr["NameOfInformation"];
msgRecField=msgRecField + "NameOfProcess=";
msgRecField=msgRecField + dr["NameOfProcess"].ToString() +"=";
tmpObject.NAMEOFPROCESS = (System.String)dr["NameOfProcess"];
msgRecField=msgRecField + "id_info=";
msgRecField=msgRecField + dr["id_info"].ToString() +"=";
tmpObject.ID_INFO = (System.Int32)dr["id_info"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
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
 
