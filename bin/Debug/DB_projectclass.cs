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
 
public class DB_projectclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_projectclass()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(projectclass _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(projectclass _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO projectclass (id_project,id_objclasses,idcompany) VALUES (@id_project,@id_objclasses,@idcompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_project", _tmpObject.ID_PROJECT));
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
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
 
public int Update(projectclass _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(projectclass _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE projectclass SET id_project=@id_project,id_objclasses=@id_objclasses,idcompany=@idcompany  WHERE idprojectclass=@idprojectclass", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_project", _tmpObject.ID_PROJECT));
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idprojectclass", _tmpObject.IDPROJECTCLASS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(projectclass _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(projectclass _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE projectclass  WHERE idprojectclass=@idprojectclass", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idprojectclass", _tmpObject.IDPROJECTCLASS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public projectclass GetById(int _id)
{
projectclass tmpObject = new projectclass();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From projectclass WHERE idprojectclass=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROJECTCLASS = (System.Int32)dr["idprojectclass"];
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
public List<projectclass> GetAll()
{
List<projectclass> tmpList = new List<projectclass>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From projectclass", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
projectclass tmpObject = new projectclass();
msgRecField="-";
msgRecField=msgRecField + "idprojectclass=";
msgRecField=msgRecField + dr["idprojectclass"].ToString() +"=";
tmpObject.IDPROJECTCLASS = (System.Int32)dr["idprojectclass"];
msgRecField=msgRecField + "id_project=";
msgRecField=msgRecField + dr["id_project"].ToString() +"=";
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
public List<projectclass> GetAllByCond(string cond)
{
List<projectclass> tmpList = new List<projectclass>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From projectclass Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
projectclass tmpObject = new projectclass();
msgRecField="-";
msgRecField=msgRecField + "idprojectclass=";
msgRecField=msgRecField + dr["idprojectclass"].ToString() +"=";
tmpObject.IDPROJECTCLASS = (System.Int32)dr["idprojectclass"];
msgRecField=msgRecField + "id_project=";
msgRecField=msgRecField + dr["id_project"].ToString() +"=";
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
 
