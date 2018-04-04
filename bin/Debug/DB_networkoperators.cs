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
 
public class DB_networkoperators
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_networkoperators()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(networkoperators _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(networkoperators _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO networkoperators (country,network,mcc,mnc,countrycode) VALUES (@country,@network,@mcc,@mnc,@countrycode) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@country", _tmpObject.COUNTRY));
command.Parameters.Add(new SqlParameter("@network", _tmpObject.NETWORK));
command.Parameters.Add(new SqlParameter("@mcc", _tmpObject.MCC));
command.Parameters.Add(new SqlParameter("@mnc", _tmpObject.MNC));
command.Parameters.Add(new SqlParameter("@countrycode", _tmpObject.COUNTRYCODE));
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
 
public int Update(networkoperators _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(networkoperators _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE networkoperators SET country=@country,network=@network,mcc=@mcc,mnc=@mnc,countrycode=@countrycode  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@country", _tmpObject.COUNTRY));
command.Parameters.Add(new SqlParameter("@network", _tmpObject.NETWORK));
command.Parameters.Add(new SqlParameter("@mcc", _tmpObject.MCC));
command.Parameters.Add(new SqlParameter("@mnc", _tmpObject.MNC));
command.Parameters.Add(new SqlParameter("@countrycode", _tmpObject.COUNTRYCODE));
command.Parameters.Add(new SqlParameter("@id", _tmpObject.ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(networkoperators _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(networkoperators _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM networkoperators  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id", _tmpObject.ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public networkoperators GetById(int _id)
{
networkoperators tmpObject = new networkoperators();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From networkoperators WHERE id=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID = (System.Int32)dr["id"];
tmpObject.COUNTRY = (System.String)dr["country"];
tmpObject.NETWORK = (System.String)dr["network"];
tmpObject.MCC = (System.String)dr["mcc"];
tmpObject.MNC = (System.String)dr["mnc"];
tmpObject.COUNTRYCODE = (System.String)dr["countrycode"];
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
public List<networkoperators> GetAll()
{
List<networkoperators> tmpList = new List<networkoperators>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From networkoperators", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
networkoperators tmpObject = new networkoperators();
msgRecField="-";
msgRecField=msgRecField + "id=";
msgRecField=msgRecField + dr["id"].ToString() +"=";
tmpObject.ID = (System.Int32)dr["id"];
msgRecField=msgRecField + "country=";
msgRecField=msgRecField + dr["country"].ToString() +"=";
tmpObject.COUNTRY = (System.String)dr["country"];
msgRecField=msgRecField + "network=";
msgRecField=msgRecField + dr["network"].ToString() +"=";
tmpObject.NETWORK = (System.String)dr["network"];
msgRecField=msgRecField + "mcc=";
msgRecField=msgRecField + dr["mcc"].ToString() +"=";
tmpObject.MCC = (System.String)dr["mcc"];
msgRecField=msgRecField + "mnc=";
msgRecField=msgRecField + dr["mnc"].ToString() +"=";
tmpObject.MNC = (System.String)dr["mnc"];
msgRecField=msgRecField + "countrycode=";
msgRecField=msgRecField + dr["countrycode"].ToString() +"=";
tmpObject.COUNTRYCODE = (System.String)dr["countrycode"];
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
public List<networkoperators> GetAllByCond(string cond)
{
List<networkoperators> tmpList = new List<networkoperators>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From networkoperators Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
networkoperators tmpObject = new networkoperators();
msgRecField="-";
msgRecField=msgRecField + "id=";
msgRecField=msgRecField + dr["id"].ToString() +"=";
tmpObject.ID = (System.Int32)dr["id"];
msgRecField=msgRecField + "country=";
msgRecField=msgRecField + dr["country"].ToString() +"=";
tmpObject.COUNTRY = (System.String)dr["country"];
msgRecField=msgRecField + "network=";
msgRecField=msgRecField + dr["network"].ToString() +"=";
tmpObject.NETWORK = (System.String)dr["network"];
msgRecField=msgRecField + "mcc=";
msgRecField=msgRecField + dr["mcc"].ToString() +"=";
tmpObject.MCC = (System.String)dr["mcc"];
msgRecField=msgRecField + "mnc=";
msgRecField=msgRecField + dr["mnc"].ToString() +"=";
tmpObject.MNC = (System.String)dr["mnc"];
msgRecField=msgRecField + "countrycode=";
msgRecField=msgRecField + dr["countrycode"].ToString() +"=";
tmpObject.COUNTRYCODE = (System.String)dr["countrycode"];
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
 
