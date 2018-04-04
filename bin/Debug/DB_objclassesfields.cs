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
 
public class DB_objclassesfields
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_objclassesfields()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(objclassesfields _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(objclassesfields _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO objclassesfields (name,type,id_objclasses,idcompany,active) VALUES (@name,@type,@id_objclasses,@idcompany,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@type", _tmpObject.TYPE));
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
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
 
public int Update(objclassesfields _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(objclassesfields _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE objclassesfields SET name=@name,type=@type,id_objclasses=@id_objclasses,idcompany=@idcompany,active=@active  WHERE idobjclassesfields=@idobjclassesfields", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@type", _tmpObject.TYPE));
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idobjclassesfields", _tmpObject.IDOBJCLASSESFIELDS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(objclassesfields _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(objclassesfields _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE objclassesfields  WHERE idobjclassesfields=@idobjclassesfields", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idobjclassesfields", _tmpObject.IDOBJCLASSESFIELDS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public objclassesfields GetById(int _id)
{
objclassesfields tmpObject = new objclassesfields();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From objclassesfields WHERE idobjclassesfields=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDOBJCLASSESFIELDS = (System.Int32)dr["idobjclassesfields"];
tmpObject.NAME = (System.String)dr["name"];
tmpObject.TYPE = (System.String)dr["type"];
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
public List<objclassesfields> GetAll()
{
List<objclassesfields> tmpList = new List<objclassesfields>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From objclassesfields", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
objclassesfields tmpObject = new objclassesfields();
msgRecField="-";
msgRecField=msgRecField + "idobjclassesfields=";
msgRecField=msgRecField + dr["idobjclassesfields"].ToString() +"=";
tmpObject.IDOBJCLASSESFIELDS = (System.Int32)dr["idobjclassesfields"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "type=";
msgRecField=msgRecField + dr["type"].ToString() +"=";
tmpObject.TYPE = (System.String)dr["type"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
public List<objclassesfields> GetAllByCond(string cond)
{
List<objclassesfields> tmpList = new List<objclassesfields>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From objclassesfields Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
objclassesfields tmpObject = new objclassesfields();
msgRecField="-";
msgRecField=msgRecField + "idobjclassesfields=";
msgRecField=msgRecField + dr["idobjclassesfields"].ToString() +"=";
tmpObject.IDOBJCLASSESFIELDS = (System.Int32)dr["idobjclassesfields"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "type=";
msgRecField=msgRecField + dr["type"].ToString() +"=";
tmpObject.TYPE = (System.String)dr["type"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
 
