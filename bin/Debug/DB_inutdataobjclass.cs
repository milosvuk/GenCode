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
 
public class DB_inutdataobjclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_inutdataobjclass()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(inutdataobjclass _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(inutdataobjclass _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO inutdataobjclass (id_objclasses,name,typeandname,ruleswithaction) VALUES (@id_objclasses,@name,@typeandname,@ruleswithaction) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@typeandname", _tmpObject.TYPEANDNAME));
command.Parameters.Add(new SqlParameter("@ruleswithaction", _tmpObject.RULESWITHACTION));
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
 
public int Update(inutdataobjclass _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(inutdataobjclass _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE inutdataobjclass SET id_objclasses=@id_objclasses,name=@name,typeandname=@typeandname,ruleswithaction=@ruleswithaction  WHERE idinput=@idinput", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@typeandname", _tmpObject.TYPEANDNAME));
command.Parameters.Add(new SqlParameter("@ruleswithaction", _tmpObject.RULESWITHACTION));
command.Parameters.Add(new SqlParameter("@idinput", _tmpObject.IDINPUT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(inutdataobjclass _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(inutdataobjclass _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE inutdataobjclass  WHERE idinput=@idinput", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idinput", _tmpObject.IDINPUT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public inutdataobjclass GetById(int _id)
{
inutdataobjclass tmpObject = new inutdataobjclass();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From inutdataobjclass WHERE idinput=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDINPUT = (System.Int32)dr["idinput"];
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
tmpObject.NAME = (System.String)dr["name"];
tmpObject.TYPEANDNAME = (System.String)dr["typeandname"];
tmpObject.RULESWITHACTION = (System.String)dr["ruleswithaction"];
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
public List<inutdataobjclass> GetAll()
{
List<inutdataobjclass> tmpList = new List<inutdataobjclass>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From inutdataobjclass", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
inutdataobjclass tmpObject = new inutdataobjclass();
msgRecField="-";
msgRecField=msgRecField + "idinput=";
msgRecField=msgRecField + dr["idinput"].ToString() +"=";
tmpObject.IDINPUT = (System.Int32)dr["idinput"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "typeandname=";
msgRecField=msgRecField + dr["typeandname"].ToString() +"=";
tmpObject.TYPEANDNAME = (System.String)dr["typeandname"];
msgRecField=msgRecField + "ruleswithaction=";
msgRecField=msgRecField + dr["ruleswithaction"].ToString() +"=";
tmpObject.RULESWITHACTION = (System.String)dr["ruleswithaction"];
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
public List<inutdataobjclass> GetAllByCond(string cond)
{
List<inutdataobjclass> tmpList = new List<inutdataobjclass>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From inutdataobjclass Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
inutdataobjclass tmpObject = new inutdataobjclass();
msgRecField="-";
msgRecField=msgRecField + "idinput=";
msgRecField=msgRecField + dr["idinput"].ToString() +"=";
tmpObject.IDINPUT = (System.Int32)dr["idinput"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "typeandname=";
msgRecField=msgRecField + dr["typeandname"].ToString() +"=";
tmpObject.TYPEANDNAME = (System.String)dr["typeandname"];
msgRecField=msgRecField + "ruleswithaction=";
msgRecField=msgRecField + dr["ruleswithaction"].ToString() +"=";
tmpObject.RULESWITHACTION = (System.String)dr["ruleswithaction"];
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
 
