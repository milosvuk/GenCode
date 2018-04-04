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
 
public class DB_measurement
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_measurement()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(measurement _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(measurement _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO measurement (codeoflocation,dateofmeasurement,codeofindicator,valueofmeasurement,description,weekm,monthm,yearm,idcustomer) VALUES (@codeoflocation,@dateofmeasurement,@codeofindicator,@valueofmeasurement,@description,@weekm,@monthm,@yearm,@idcustomer) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@codeoflocation", _tmpObject.CODEOFLOCATION));
command.Parameters.Add(new SqlParameter("@dateofmeasurement", _tmpObject.DATEOFMEASUREMENT));
command.Parameters.Add(new SqlParameter("@codeofindicator", _tmpObject.CODEOFINDICATOR));
command.Parameters.Add(new SqlParameter("@valueofmeasurement", _tmpObject.VALUEOFMEASUREMENT));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@weekm", _tmpObject.WEEKM));
command.Parameters.Add(new SqlParameter("@monthm", _tmpObject.MONTHM));
command.Parameters.Add(new SqlParameter("@yearm", _tmpObject.YEARM));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
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
 
public int Update(measurement _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(measurement _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE measurement SET codeoflocation=@codeoflocation,dateofmeasurement=@dateofmeasurement,codeofindicator=@codeofindicator,valueofmeasurement=@valueofmeasurement,description=@description,weekm=@weekm,monthm=@monthm,yearm=@yearm,idcustomer=@idcustomer  WHERE idmeasurement=@idmeasurement", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@codeoflocation", _tmpObject.CODEOFLOCATION));
command.Parameters.Add(new SqlParameter("@dateofmeasurement", _tmpObject.DATEOFMEASUREMENT));
command.Parameters.Add(new SqlParameter("@codeofindicator", _tmpObject.CODEOFINDICATOR));
command.Parameters.Add(new SqlParameter("@valueofmeasurement", _tmpObject.VALUEOFMEASUREMENT));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@weekm", _tmpObject.WEEKM));
command.Parameters.Add(new SqlParameter("@monthm", _tmpObject.MONTHM));
command.Parameters.Add(new SqlParameter("@yearm", _tmpObject.YEARM));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@idmeasurement", _tmpObject.IDMEASUREMENT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(measurement _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(measurement _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM measurement  WHERE idmeasurement=@idmeasurement", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idmeasurement", _tmpObject.IDMEASUREMENT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public measurement GetById(int _id)
{
measurement tmpObject = new measurement();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From measurement WHERE idmeasurement=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDMEASUREMENT = (System.Int32)dr["idmeasurement"];
tmpObject.CODEOFLOCATION = (System.String)dr["codeoflocation"];
tmpObject.DATEOFMEASUREMENT = (System.DateTime)dr["dateofmeasurement"];
tmpObject.CODEOFINDICATOR = (System.String)dr["codeofindicator"];
tmpObject.VALUEOFMEASUREMENT = (System.Decimal)dr["valueofmeasurement"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpObject.WEEKM = (System.Int32)dr["weekm"];
tmpObject.MONTHM = (System.Int32)dr["monthm"];
tmpObject.YEARM = (System.Int32)dr["yearm"];
tmpObject.IDCUSTOMER = (System.Int32)dr["idcustomer"];
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
public List<measurement> GetAll()
{
List<measurement> tmpList = new List<measurement>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From measurement", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
measurement tmpObject = new measurement();
msgRecField="-";
msgRecField=msgRecField + "idmeasurement=";
msgRecField=msgRecField + dr["idmeasurement"].ToString() +"=";
tmpObject.IDMEASUREMENT = (System.Int32)dr["idmeasurement"];
msgRecField=msgRecField + "codeoflocation=";
msgRecField=msgRecField + dr["codeoflocation"].ToString() +"=";
tmpObject.CODEOFLOCATION = (System.String)dr["codeoflocation"];
msgRecField=msgRecField + "dateofmeasurement=";
msgRecField=msgRecField + dr["dateofmeasurement"].ToString() +"=";
tmpObject.DATEOFMEASUREMENT = (System.DateTime)dr["dateofmeasurement"];
msgRecField=msgRecField + "codeofindicator=";
msgRecField=msgRecField + dr["codeofindicator"].ToString() +"=";
tmpObject.CODEOFINDICATOR = (System.String)dr["codeofindicator"];
msgRecField=msgRecField + "valueofmeasurement=";
msgRecField=msgRecField + dr["valueofmeasurement"].ToString() +"=";
tmpObject.VALUEOFMEASUREMENT = (System.Decimal)dr["valueofmeasurement"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "weekm=";
msgRecField=msgRecField + dr["weekm"].ToString() +"=";
tmpObject.WEEKM = (System.Int32)dr["weekm"];
msgRecField=msgRecField + "monthm=";
msgRecField=msgRecField + dr["monthm"].ToString() +"=";
tmpObject.MONTHM = (System.Int32)dr["monthm"];
msgRecField=msgRecField + "yearm=";
msgRecField=msgRecField + dr["yearm"].ToString() +"=";
tmpObject.YEARM = (System.Int32)dr["yearm"];
msgRecField=msgRecField + "idcustomer=";
msgRecField=msgRecField + dr["idcustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idcustomer"];
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
public List<measurement> GetAllByCond(string cond)
{
List<measurement> tmpList = new List<measurement>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From measurement Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
measurement tmpObject = new measurement();
msgRecField="-";
msgRecField=msgRecField + "idmeasurement=";
msgRecField=msgRecField + dr["idmeasurement"].ToString() +"=";
tmpObject.IDMEASUREMENT = (System.Int32)dr["idmeasurement"];
msgRecField=msgRecField + "codeoflocation=";
msgRecField=msgRecField + dr["codeoflocation"].ToString() +"=";
tmpObject.CODEOFLOCATION = (System.String)dr["codeoflocation"];
msgRecField=msgRecField + "dateofmeasurement=";
msgRecField=msgRecField + dr["dateofmeasurement"].ToString() +"=";
tmpObject.DATEOFMEASUREMENT = (System.DateTime)dr["dateofmeasurement"];
msgRecField=msgRecField + "codeofindicator=";
msgRecField=msgRecField + dr["codeofindicator"].ToString() +"=";
tmpObject.CODEOFINDICATOR = (System.String)dr["codeofindicator"];
msgRecField=msgRecField + "valueofmeasurement=";
msgRecField=msgRecField + dr["valueofmeasurement"].ToString() +"=";
tmpObject.VALUEOFMEASUREMENT = (System.Decimal)dr["valueofmeasurement"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "weekm=";
msgRecField=msgRecField + dr["weekm"].ToString() +"=";
tmpObject.WEEKM = (System.Int32)dr["weekm"];
msgRecField=msgRecField + "monthm=";
msgRecField=msgRecField + dr["monthm"].ToString() +"=";
tmpObject.MONTHM = (System.Int32)dr["monthm"];
msgRecField=msgRecField + "yearm=";
msgRecField=msgRecField + dr["yearm"].ToString() +"=";
tmpObject.YEARM = (System.Int32)dr["yearm"];
msgRecField=msgRecField + "idcustomer=";
msgRecField=msgRecField + dr["idcustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idcustomer"];
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
 
