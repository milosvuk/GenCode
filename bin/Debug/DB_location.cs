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
 
public class DB_location
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_location()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(location _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(location _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO location (codeoflocation,nameoflocation,latit,longi,description,idcompany) VALUES (@codeoflocation,@nameoflocation,@latit,@longi,@description,@idcompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@codeoflocation", _tmpObject.CODEOFLOCATION));
command.Parameters.Add(new SqlParameter("@nameoflocation", _tmpObject.NAMEOFLOCATION));
command.Parameters.Add(new SqlParameter("@latit", _tmpObject.LATIT));
command.Parameters.Add(new SqlParameter("@longi", _tmpObject.LONGI));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
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
 
public int Update(location _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(location _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE location SET codeoflocation=@codeoflocation,nameoflocation=@nameoflocation,latit=@latit,longi=@longi,description=@description,idcompany=@idcompany  WHERE idlocation=@idlocation", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@codeoflocation", _tmpObject.CODEOFLOCATION));
command.Parameters.Add(new SqlParameter("@nameoflocation", _tmpObject.NAMEOFLOCATION));
command.Parameters.Add(new SqlParameter("@latit", _tmpObject.LATIT));
command.Parameters.Add(new SqlParameter("@longi", _tmpObject.LONGI));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idlocation", _tmpObject.IDLOCATION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(location _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(location _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM location  WHERE idlocation=@idlocation", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idlocation", _tmpObject.IDLOCATION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public location GetById(int _id)
{
location tmpObject = new location();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From location WHERE idlocation=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDLOCATION = (System.Int32)dr["idlocation"];
tmpObject.CODEOFLOCATION = (System.String)dr["codeoflocation"];
tmpObject.NAMEOFLOCATION = (System.String)dr["nameoflocation"];
tmpObject.LATIT = (System.String)dr["latit"];
tmpObject.LONGI = (System.String)dr["longi"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
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
public List<location> GetAll()
{
List<location> tmpList = new List<location>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From location", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
location tmpObject = new location();
msgRecField="-";
msgRecField=msgRecField + "idlocation=";
msgRecField=msgRecField + dr["idlocation"].ToString() +"=";
tmpObject.IDLOCATION = (System.Int32)dr["idlocation"];
msgRecField=msgRecField + "codeoflocation=";
msgRecField=msgRecField + dr["codeoflocation"].ToString() +"=";
tmpObject.CODEOFLOCATION = (System.String)dr["codeoflocation"];
msgRecField=msgRecField + "nameoflocation=";
msgRecField=msgRecField + dr["nameoflocation"].ToString() +"=";
tmpObject.NAMEOFLOCATION = (System.String)dr["nameoflocation"];
msgRecField=msgRecField + "latit=";
msgRecField=msgRecField + dr["latit"].ToString() +"=";
tmpObject.LATIT = (System.String)dr["latit"];
msgRecField=msgRecField + "longi=";
msgRecField=msgRecField + dr["longi"].ToString() +"=";
tmpObject.LONGI = (System.String)dr["longi"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
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
public List<location> GetAllByCond(string cond)
{
List<location> tmpList = new List<location>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From location Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
location tmpObject = new location();
msgRecField="-";
msgRecField=msgRecField + "idlocation=";
msgRecField=msgRecField + dr["idlocation"].ToString() +"=";
tmpObject.IDLOCATION = (System.Int32)dr["idlocation"];
msgRecField=msgRecField + "codeoflocation=";
msgRecField=msgRecField + dr["codeoflocation"].ToString() +"=";
tmpObject.CODEOFLOCATION = (System.String)dr["codeoflocation"];
msgRecField=msgRecField + "nameoflocation=";
msgRecField=msgRecField + dr["nameoflocation"].ToString() +"=";
tmpObject.NAMEOFLOCATION = (System.String)dr["nameoflocation"];
msgRecField=msgRecField + "latit=";
msgRecField=msgRecField + dr["latit"].ToString() +"=";
tmpObject.LATIT = (System.String)dr["latit"];
msgRecField=msgRecField + "longi=";
msgRecField=msgRecField + dr["longi"].ToString() +"=";
tmpObject.LONGI = (System.String)dr["longi"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
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
 
