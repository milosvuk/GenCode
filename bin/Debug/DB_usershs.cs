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
 
public class DB_usershs
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_usershs()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(usershs _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(usershs _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO usershs (id_usergroup,username,password,useremail,active,id_company) VALUES (@id_usergroup,@username,@password,@useremail,@active,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_usergroup", _tmpObject.ID_USERGROUP));
command.Parameters.Add(new SqlParameter("@username", _tmpObject.USERNAME));
command.Parameters.Add(new SqlParameter("@password", _tmpObject.PASSWORD));
command.Parameters.Add(new SqlParameter("@useremail", _tmpObject.USEREMAIL));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
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
 
public int Update(usershs _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(usershs _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE usershs SET id_usergroup=@id_usergroup,username=@username,password=@password,useremail=@useremail,active=@active,id_company=@id_company  WHERE iduser=@iduser", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_usergroup", _tmpObject.ID_USERGROUP));
command.Parameters.Add(new SqlParameter("@username", _tmpObject.USERNAME));
command.Parameters.Add(new SqlParameter("@password", _tmpObject.PASSWORD));
command.Parameters.Add(new SqlParameter("@useremail", _tmpObject.USEREMAIL));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@iduser", _tmpObject.IDUSER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(usershs _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(usershs _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM usershs  WHERE iduser=@iduser", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@iduser", _tmpObject.IDUSER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public usershs GetById(int _id)
{
usershs tmpObject = new usershs();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From usershs WHERE iduser=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDUSER = (System.Int32)dr["iduser"];
tmpObject.ID_USERGROUP = (System.Int32)dr["id_usergroup"];
tmpObject.USERNAME = (System.String)dr["username"];
tmpObject.PASSWORD = (System.String)dr["password"];
tmpObject.USEREMAIL = (System.String)dr["useremail"];
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
public List<usershs> GetAll()
{
List<usershs> tmpList = new List<usershs>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From usershs", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
usershs tmpObject = new usershs();
msgRecField="-";
msgRecField=msgRecField + "iduser=";
msgRecField=msgRecField + dr["iduser"].ToString() +"=";
tmpObject.IDUSER = (System.Int32)dr["iduser"];
msgRecField=msgRecField + "id_usergroup=";
msgRecField=msgRecField + dr["id_usergroup"].ToString() +"=";
tmpObject.ID_USERGROUP = (System.Int32)dr["id_usergroup"];
msgRecField=msgRecField + "username=";
msgRecField=msgRecField + dr["username"].ToString() +"=";
tmpObject.USERNAME = (System.String)dr["username"];
msgRecField=msgRecField + "password=";
msgRecField=msgRecField + dr["password"].ToString() +"=";
tmpObject.PASSWORD = (System.String)dr["password"];
msgRecField=msgRecField + "useremail=";
msgRecField=msgRecField + dr["useremail"].ToString() +"=";
tmpObject.USEREMAIL = (System.String)dr["useremail"];
msgRecField=msgRecField + "active=";
msgRecField=msgRecField + dr["active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
public List<usershs> GetAllByCond(string cond)
{
List<usershs> tmpList = new List<usershs>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From usershs Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
usershs tmpObject = new usershs();
msgRecField="-";
msgRecField=msgRecField + "iduser=";
msgRecField=msgRecField + dr["iduser"].ToString() +"=";
tmpObject.IDUSER = (System.Int32)dr["iduser"];
msgRecField=msgRecField + "id_usergroup=";
msgRecField=msgRecField + dr["id_usergroup"].ToString() +"=";
tmpObject.ID_USERGROUP = (System.Int32)dr["id_usergroup"];
msgRecField=msgRecField + "username=";
msgRecField=msgRecField + dr["username"].ToString() +"=";
tmpObject.USERNAME = (System.String)dr["username"];
msgRecField=msgRecField + "password=";
msgRecField=msgRecField + dr["password"].ToString() +"=";
tmpObject.PASSWORD = (System.String)dr["password"];
msgRecField=msgRecField + "useremail=";
msgRecField=msgRecField + dr["useremail"].ToString() +"=";
tmpObject.USEREMAIL = (System.String)dr["useremail"];
msgRecField=msgRecField + "active=";
msgRecField=msgRecField + dr["active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
 
