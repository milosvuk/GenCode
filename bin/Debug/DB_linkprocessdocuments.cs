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
 
public class DB_linkprocessdocuments
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_linkprocessdocuments()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(linkprocessdocuments _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(linkprocessdocuments _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO linkprocessdocuments (ProcessName,DocumentName,id_process,id_documents) VALUES (@ProcessName,@DocumentName,@id_process,@id_documents) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@ProcessName", _tmpObject.PROCESSNAME));
command.Parameters.Add(new SqlParameter("@DocumentName", _tmpObject.DOCUMENTNAME));
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
command.Parameters.Add(new SqlParameter("@id_documents", _tmpObject.ID_DOCUMENTS));
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
 
public int Update(linkprocessdocuments _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(linkprocessdocuments _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE linkprocessdocuments SET ProcessName=@processname,DocumentName=@documentname,id_process=@id_process,id_documents=@id_documents  WHERE idprojectprocessdocuments=@idprojectprocessdocuments", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@processname", _tmpObject.PROCESSNAME));
command.Parameters.Add(new SqlParameter("@documentname", _tmpObject.DOCUMENTNAME));
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
command.Parameters.Add(new SqlParameter("@id_documents", _tmpObject.ID_DOCUMENTS));
command.Parameters.Add(new SqlParameter("@idprojectprocessdocuments", _tmpObject.IDPROJECTPROCESSDOCUMENTS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(linkprocessdocuments _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(linkprocessdocuments _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE linkprocessdocuments  WHERE idprojectprocessdocuments=@idprojectprocessdocuments", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idprojectprocessdocuments", _tmpObject.IDPROJECTPROCESSDOCUMENTS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public linkprocessdocuments GetById(int _id)
{
linkprocessdocuments tmpObject = new linkprocessdocuments();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkprocessdocuments WHERE idprojectprocessdocuments=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROJECTPROCESSDOCUMENTS = (System.Int32)dr["idprojectprocessdocuments"];
tmpObject.PROCESSNAME = (System.String)dr["ProcessName"];
tmpObject.DOCUMENTNAME = (System.String)dr["DocumentName"];
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
tmpObject.ID_DOCUMENTS = (System.Int32)dr["id_documents"];
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
public List<linkprocessdocuments> GetAll()
{
List<linkprocessdocuments> tmpList = new List<linkprocessdocuments>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkprocessdocuments", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
linkprocessdocuments tmpObject = new linkprocessdocuments();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocessdocuments=";
msgRecField=msgRecField + dr["idprojectprocessdocuments"].ToString() +"=";
tmpObject.IDPROJECTPROCESSDOCUMENTS = (System.Int32)dr["idprojectprocessdocuments"];
msgRecField=msgRecField + "ProcessName=";
msgRecField=msgRecField + dr["ProcessName"].ToString() +"=";
tmpObject.PROCESSNAME = (System.String)dr["ProcessName"];
msgRecField=msgRecField + "DocumentName=";
msgRecField=msgRecField + dr["DocumentName"].ToString() +"=";
tmpObject.DOCUMENTNAME = (System.String)dr["DocumentName"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
msgRecField=msgRecField + "id_documents=";
msgRecField=msgRecField + dr["id_documents"].ToString() +"=";
tmpObject.ID_DOCUMENTS = (System.Int32)dr["id_documents"];
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
public List<linkprocessdocuments> GetAllByCond(string cond)
{
List<linkprocessdocuments> tmpList = new List<linkprocessdocuments>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkprocessdocuments Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
linkprocessdocuments tmpObject = new linkprocessdocuments();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocessdocuments=";
msgRecField=msgRecField + dr["idprojectprocessdocuments"].ToString() +"=";
tmpObject.IDPROJECTPROCESSDOCUMENTS = (System.Int32)dr["idprojectprocessdocuments"];
msgRecField=msgRecField + "ProcessName=";
msgRecField=msgRecField + dr["ProcessName"].ToString() +"=";
tmpObject.PROCESSNAME = (System.String)dr["ProcessName"];
msgRecField=msgRecField + "DocumentName=";
msgRecField=msgRecField + dr["DocumentName"].ToString() +"=";
tmpObject.DOCUMENTNAME = (System.String)dr["DocumentName"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
msgRecField=msgRecField + "id_documents=";
msgRecField=msgRecField + dr["id_documents"].ToString() +"=";
tmpObject.ID_DOCUMENTS = (System.Int32)dr["id_documents"];
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
 
