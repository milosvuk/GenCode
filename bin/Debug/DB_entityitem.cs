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
 
public class DB_entityitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_entityitem()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(entityitem _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(entityitem _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO entityitem (codeofentity,nameofentity,udf1,udf2,udf3,idcompany) VALUES (@codeofentity,@nameofentity,@udf1,@udf2,@udf3,@idcompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@codeofentity", _tmpObject.CODEOFENTITY));
command.Parameters.Add(new SqlParameter("@nameofentity", _tmpObject.NAMEOFENTITY));
command.Parameters.Add(new SqlParameter("@udf1", _tmpObject.UDF1));
command.Parameters.Add(new SqlParameter("@udf2", _tmpObject.UDF2));
command.Parameters.Add(new SqlParameter("@udf3", _tmpObject.UDF3));
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
 
public int Update(entityitem _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(entityitem _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE entityitem SET codeofentity=@codeofentity,nameofentity=@nameofentity,udf1=@udf1,udf2=@udf2,udf3=@udf3,idcompany=@idcompany  WHERE idofentity=@idofentity", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@codeofentity", _tmpObject.CODEOFENTITY));
command.Parameters.Add(new SqlParameter("@nameofentity", _tmpObject.NAMEOFENTITY));
command.Parameters.Add(new SqlParameter("@udf1", _tmpObject.UDF1));
command.Parameters.Add(new SqlParameter("@udf2", _tmpObject.UDF2));
command.Parameters.Add(new SqlParameter("@udf3", _tmpObject.UDF3));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idofentity", _tmpObject.IDOFENTITY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(entityitem _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(entityitem _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM entityitem  WHERE idofentity=@idofentity", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idofentity", _tmpObject.IDOFENTITY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public entityitem GetById(int _id)
{
entityitem tmpObject = new entityitem();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From entityitem WHERE idofentity=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDOFENTITY = (System.Int32)dr["idofentity"];
tmpObject.CODEOFENTITY = (System.String)dr["codeofentity"];
tmpObject.NAMEOFENTITY = (System.String)dr["nameofentity"];
tmpObject.UDF1 = (System.String)dr["udf1"];
tmpObject.UDF2 = (System.String)dr["udf2"];
tmpObject.UDF3 = (System.String)dr["udf3"];
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
public List<entityitem> GetAll()
{
List<entityitem> tmpList = new List<entityitem>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From entityitem", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
entityitem tmpObject = new entityitem();
msgRecField="-";
msgRecField=msgRecField + "idofentity=";
msgRecField=msgRecField + dr["idofentity"].ToString() +"=";
tmpObject.IDOFENTITY = (System.Int32)dr["idofentity"];
msgRecField=msgRecField + "codeofentity=";
msgRecField=msgRecField + dr["codeofentity"].ToString() +"=";
tmpObject.CODEOFENTITY = (System.String)dr["codeofentity"];
msgRecField=msgRecField + "nameofentity=";
msgRecField=msgRecField + dr["nameofentity"].ToString() +"=";
tmpObject.NAMEOFENTITY = (System.String)dr["nameofentity"];
msgRecField=msgRecField + "udf1=";
msgRecField=msgRecField + dr["udf1"].ToString() +"=";
tmpObject.UDF1 = (System.String)dr["udf1"];
msgRecField=msgRecField + "udf2=";
msgRecField=msgRecField + dr["udf2"].ToString() +"=";
tmpObject.UDF2 = (System.String)dr["udf2"];
msgRecField=msgRecField + "udf3=";
msgRecField=msgRecField + dr["udf3"].ToString() +"=";
tmpObject.UDF3 = (System.String)dr["udf3"];
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
public List<entityitem> GetAllByCond(string cond)
{
List<entityitem> tmpList = new List<entityitem>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From entityitem Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
entityitem tmpObject = new entityitem();
msgRecField="-";
msgRecField=msgRecField + "idofentity=";
msgRecField=msgRecField + dr["idofentity"].ToString() +"=";
tmpObject.IDOFENTITY = (System.Int32)dr["idofentity"];
msgRecField=msgRecField + "codeofentity=";
msgRecField=msgRecField + dr["codeofentity"].ToString() +"=";
tmpObject.CODEOFENTITY = (System.String)dr["codeofentity"];
msgRecField=msgRecField + "nameofentity=";
msgRecField=msgRecField + dr["nameofentity"].ToString() +"=";
tmpObject.NAMEOFENTITY = (System.String)dr["nameofentity"];
msgRecField=msgRecField + "udf1=";
msgRecField=msgRecField + dr["udf1"].ToString() +"=";
tmpObject.UDF1 = (System.String)dr["udf1"];
msgRecField=msgRecField + "udf2=";
msgRecField=msgRecField + dr["udf2"].ToString() +"=";
tmpObject.UDF2 = (System.String)dr["udf2"];
msgRecField=msgRecField + "udf3=";
msgRecField=msgRecField + dr["udf3"].ToString() +"=";
tmpObject.UDF3 = (System.String)dr["udf3"];
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
 
