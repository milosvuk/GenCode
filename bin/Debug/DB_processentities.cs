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
 
public class DB_processentities
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_processentities()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(processentities _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(processentities _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO processentities (id_process,id_identities,id_company,active) VALUES (@id_process,@id_identities,@id_company,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
command.Parameters.Add(new SqlParameter("@id_identities", _tmpObject.ID_IDENTITIES));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
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
 
public int Update(processentities _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(processentities _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE processentities SET id_process=@id_process,id_identities=@id_identities,id_company=@id_company,active=@active  WHERE idprojectprocessentities=@idprojectprocessentities", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
command.Parameters.Add(new SqlParameter("@id_identities", _tmpObject.ID_IDENTITIES));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idprojectprocessentities", _tmpObject.IDPROJECTPROCESSENTITIES));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(processentities _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(processentities _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE processentities  WHERE idprojectprocessentities=@idprojectprocessentities", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idprojectprocessentities", _tmpObject.IDPROJECTPROCESSENTITIES));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public processentities GetById(int _id)
{
processentities tmpObject = new processentities();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From processentities WHERE idprojectprocessentities=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROJECTPROCESSENTITIES = (System.Int32)dr["idprojectprocessentities"];
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
tmpObject.ID_IDENTITIES = (System.Int32)dr["id_identities"];
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
public List<processentities> GetAll()
{
List<processentities> tmpList = new List<processentities>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From processentities", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
processentities tmpObject = new processentities();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocessentities=";
msgRecField=msgRecField + dr["idprojectprocessentities"].ToString() +"=";
tmpObject.IDPROJECTPROCESSENTITIES = (System.Int32)dr["idprojectprocessentities"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
msgRecField=msgRecField + "id_identities=";
msgRecField=msgRecField + dr["id_identities"].ToString() +"=";
tmpObject.ID_IDENTITIES = (System.Int32)dr["id_identities"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
msgRecField=msgRecField + "active=";
msgRecField=msgRecField + dr["active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
public List<processentities> GetAllByCond(string cond)
{
List<processentities> tmpList = new List<processentities>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From processentities Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
processentities tmpObject = new processentities();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocessentities=";
msgRecField=msgRecField + dr["idprojectprocessentities"].ToString() +"=";
tmpObject.IDPROJECTPROCESSENTITIES = (System.Int32)dr["idprojectprocessentities"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
msgRecField=msgRecField + "id_identities=";
msgRecField=msgRecField + dr["id_identities"].ToString() +"=";
tmpObject.ID_IDENTITIES = (System.Int32)dr["id_identities"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
msgRecField=msgRecField + "active=";
msgRecField=msgRecField + dr["active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
 
