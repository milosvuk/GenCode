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
 
public class DB_locations
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_locations()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(locations _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(locations _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO locations (idRegion,locationcode,locationname,idCompany) VALUES (@idRegion,@locationcode,@locationname,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRegion", _tmpObject.IDREGION));
command.Parameters.Add(new SqlParameter("@locationcode", _tmpObject.LOCATIONCODE));
command.Parameters.Add(new SqlParameter("@locationname", _tmpObject.LOCATIONNAME));
command.Parameters.Add(new SqlParameter("@idCompany", _tmpObject.IDCOMPANY));
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
 
public int Update(locations _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(locations _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE locations SET idRegion=@idregion,locationcode=@locationcode,locationname=@locationname,idCompany=@idcompany  WHERE idRecLocation=@idreclocation", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idregion", _tmpObject.IDREGION));
command.Parameters.Add(new SqlParameter("@locationcode", _tmpObject.LOCATIONCODE));
command.Parameters.Add(new SqlParameter("@locationname", _tmpObject.LOCATIONNAME));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idreclocation", _tmpObject.IDRECLOCATION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(locations _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(locations _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE locations  WHERE idRecLocation=@idreclocation", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idreclocation", _tmpObject.IDRECLOCATION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public locations GetById(int _id)
{
locations tmpObject = new locations();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From locations WHERE idRecLocation=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECLOCATION = (System.Int32)dr["idRecLocation"];
tmpObject.IDREGION = (System.Int32)dr["idRegion"];
tmpObject.LOCATIONCODE = (System.String)dr["locationcode"];
tmpObject.LOCATIONNAME = (System.String)dr["locationname"];
tmpObject.IDCOMPANY = (System.Int32)dr["idCompany"];
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
public List<locations> GetAll()
{
List<locations> tmpList = new List<locations>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From locations", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
locations tmpObject = new locations();
msgRecField="-";
msgRecField=msgRecField + "idRecLocation=";
msgRecField=msgRecField + dr["idRecLocation"].ToString() +"=";
tmpObject.IDRECLOCATION = (System.Int32)dr["idRecLocation"];
msgRecField=msgRecField + "idRegion=";
msgRecField=msgRecField + dr["idRegion"].ToString() +"=";
tmpObject.IDREGION = (System.Int32)dr["idRegion"];
msgRecField=msgRecField + "locationcode=";
msgRecField=msgRecField + dr["locationcode"].ToString() +"=";
tmpObject.LOCATIONCODE = (System.String)dr["locationcode"];
msgRecField=msgRecField + "locationname=";
msgRecField=msgRecField + dr["locationname"].ToString() +"=";
tmpObject.LOCATIONNAME = (System.String)dr["locationname"];
msgRecField=msgRecField + "idCompany=";
msgRecField=msgRecField + dr["idCompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idCompany"];
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
public List<locations> GetAllByCond(string cond)
{
List<locations> tmpList = new List<locations>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From locations Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
locations tmpObject = new locations();
msgRecField="-";
msgRecField=msgRecField + "idRecLocation=";
msgRecField=msgRecField + dr["idRecLocation"].ToString() +"=";
tmpObject.IDRECLOCATION = (System.Int32)dr["idRecLocation"];
msgRecField=msgRecField + "idRegion=";
msgRecField=msgRecField + dr["idRegion"].ToString() +"=";
tmpObject.IDREGION = (System.Int32)dr["idRegion"];
msgRecField=msgRecField + "locationcode=";
msgRecField=msgRecField + dr["locationcode"].ToString() +"=";
tmpObject.LOCATIONCODE = (System.String)dr["locationcode"];
msgRecField=msgRecField + "locationname=";
msgRecField=msgRecField + dr["locationname"].ToString() +"=";
tmpObject.LOCATIONNAME = (System.String)dr["locationname"];
msgRecField=msgRecField + "idCompany=";
msgRecField=msgRecField + dr["idCompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idCompany"];
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
 
