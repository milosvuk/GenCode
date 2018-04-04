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
 
public class DB_store
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_store()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(store _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(store _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO store (numOfStore,codeOfStore,nameOfStore,latStore,longStore,id_company) VALUES (@numOfStore,@codeOfStore,@nameOfStore,@latStore,@longStore,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@numOfStore", _tmpObject.NUMOFSTORE));
command.Parameters.Add(new SqlParameter("@codeOfStore", _tmpObject.CODEOFSTORE));
command.Parameters.Add(new SqlParameter("@nameOfStore", _tmpObject.NAMEOFSTORE));
command.Parameters.Add(new SqlParameter("@latStore", _tmpObject.LATSTORE));
command.Parameters.Add(new SqlParameter("@longStore", _tmpObject.LONGSTORE));
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
 
public int Update(store _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(store _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE store SET numOfStore=@numofstore,codeOfStore=@codeofstore,nameOfStore=@nameofstore,latStore=@latstore,longStore=@longstore,id_company=@id_company  WHERE idstore=@idstore", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@numofstore", _tmpObject.NUMOFSTORE));
command.Parameters.Add(new SqlParameter("@codeofstore", _tmpObject.CODEOFSTORE));
command.Parameters.Add(new SqlParameter("@nameofstore", _tmpObject.NAMEOFSTORE));
command.Parameters.Add(new SqlParameter("@latstore", _tmpObject.LATSTORE));
command.Parameters.Add(new SqlParameter("@longstore", _tmpObject.LONGSTORE));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idstore", _tmpObject.IDSTORE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(store _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(store _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE store  WHERE idstore=@idstore", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idstore", _tmpObject.IDSTORE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public store GetById(int _id)
{
store tmpObject = new store();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From store WHERE idstore=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDSTORE = (System.Int32)dr["idstore"];
tmpObject.NUMOFSTORE = (System.Int32)dr["numOfStore"];
tmpObject.CODEOFSTORE = (System.String)dr["codeOfStore"];
tmpObject.NAMEOFSTORE = (System.String)dr["nameOfStore"];
tmpObject.LATSTORE = (System.Decimal)dr["latStore"];
tmpObject.LONGSTORE = (System.Decimal)dr["longStore"];
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
public List<store> GetAll()
{
List<store> tmpList = new List<store>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From store", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
store tmpObject = new store();
msgRecField="-";
msgRecField=msgRecField + "idstore=";
msgRecField=msgRecField + dr["idstore"].ToString() +"=";
tmpObject.IDSTORE = (System.Int32)dr["idstore"];
msgRecField=msgRecField + "numOfStore=";
msgRecField=msgRecField + dr["numOfStore"].ToString() +"=";
tmpObject.NUMOFSTORE = (System.Int32)dr["numOfStore"];
msgRecField=msgRecField + "codeOfStore=";
msgRecField=msgRecField + dr["codeOfStore"].ToString() +"=";
tmpObject.CODEOFSTORE = (System.String)dr["codeOfStore"];
msgRecField=msgRecField + "nameOfStore=";
msgRecField=msgRecField + dr["nameOfStore"].ToString() +"=";
tmpObject.NAMEOFSTORE = (System.String)dr["nameOfStore"];
msgRecField=msgRecField + "latStore=";
msgRecField=msgRecField + dr["latStore"].ToString() +"=";
tmpObject.LATSTORE = (System.Decimal)dr["latStore"];
msgRecField=msgRecField + "longStore=";
msgRecField=msgRecField + dr["longStore"].ToString() +"=";
tmpObject.LONGSTORE = (System.Decimal)dr["longStore"];
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
public List<store> GetAllByCond(string cond)
{
List<store> tmpList = new List<store>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From store Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
store tmpObject = new store();
msgRecField="-";
msgRecField=msgRecField + "idstore=";
msgRecField=msgRecField + dr["idstore"].ToString() +"=";
tmpObject.IDSTORE = (System.Int32)dr["idstore"];
msgRecField=msgRecField + "numOfStore=";
msgRecField=msgRecField + dr["numOfStore"].ToString() +"=";
tmpObject.NUMOFSTORE = (System.Int32)dr["numOfStore"];
msgRecField=msgRecField + "codeOfStore=";
msgRecField=msgRecField + dr["codeOfStore"].ToString() +"=";
tmpObject.CODEOFSTORE = (System.String)dr["codeOfStore"];
msgRecField=msgRecField + "nameOfStore=";
msgRecField=msgRecField + dr["nameOfStore"].ToString() +"=";
tmpObject.NAMEOFSTORE = (System.String)dr["nameOfStore"];
msgRecField=msgRecField + "latStore=";
msgRecField=msgRecField + dr["latStore"].ToString() +"=";
tmpObject.LATSTORE = (System.Decimal)dr["latStore"];
msgRecField=msgRecField + "longStore=";
msgRecField=msgRecField + dr["longStore"].ToString() +"=";
tmpObject.LONGSTORE = (System.Decimal)dr["longStore"];
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
 
