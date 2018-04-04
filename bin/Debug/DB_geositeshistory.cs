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
 
public class DB_geositeshistory
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_geositeshistory()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(geositeshistory _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(geositeshistory _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO geositeshistory (idsitename,geocoordinates,protectedsite,dateofchange,description,active) VALUES (@idsitename,@geocoordinates,@protectedsite,@dateofchange,@description,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idsitename", _tmpObject.IDSITENAME));
command.Parameters.Add(new SqlParameter("@geocoordinates", _tmpObject.GEOCOORDINATES));
command.Parameters.Add(new SqlParameter("@protectedsite", _tmpObject.PROTECTEDSITE));
command.Parameters.Add(new SqlParameter("@dateofchange", _tmpObject.DATEOFCHANGE));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
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
 
public int Update(geositeshistory _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(geositeshistory _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE geositeshistory SET idsitename=@idsitename,geocoordinates=@geocoordinates,protectedsite=@protectedsite,dateofchange=@dateofchange,description=@description,active=@active  WHERE idgeosite=@idgeosite", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idsitename", _tmpObject.IDSITENAME));
command.Parameters.Add(new SqlParameter("@geocoordinates", _tmpObject.GEOCOORDINATES));
command.Parameters.Add(new SqlParameter("@protectedsite", _tmpObject.PROTECTEDSITE));
command.Parameters.Add(new SqlParameter("@dateofchange", _tmpObject.DATEOFCHANGE));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idgeosite", _tmpObject.IDGEOSITE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(geositeshistory _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(geositeshistory _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE geositeshistory  WHERE idgeosite=@idgeosite", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idgeosite", _tmpObject.IDGEOSITE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public geositeshistory GetById(int _id)
{
geositeshistory tmpObject = new geositeshistory();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From geositeshistory WHERE idgeosite=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDGEOSITE = (System.Int32)dr["idgeosite"];
tmpObject.IDSITENAME = (System.String)dr["idsitename"];
tmpObject.GEOCOORDINATES = (System.String)dr["geocoordinates"];
tmpObject.PROTECTEDSITE = (System.Int32)dr["protectedsite"];
tmpObject.DATEOFCHANGE = (System.DateTime)dr["dateofchange"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
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
public List<geositeshistory> GetAll()
{
List<geositeshistory> tmpList = new List<geositeshistory>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From geositeshistory", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
geositeshistory tmpObject = new geositeshistory();
msgRecField="-";
msgRecField=msgRecField + "idgeosite=";
msgRecField=msgRecField + dr["idgeosite"].ToString() +"=";
tmpObject.IDGEOSITE = (System.Int32)dr["idgeosite"];
msgRecField=msgRecField + "idsitename=";
msgRecField=msgRecField + dr["idsitename"].ToString() +"=";
tmpObject.IDSITENAME = (System.String)dr["idsitename"];
msgRecField=msgRecField + "geocoordinates=";
msgRecField=msgRecField + dr["geocoordinates"].ToString() +"=";
tmpObject.GEOCOORDINATES = (System.String)dr["geocoordinates"];
msgRecField=msgRecField + "protectedsite=";
msgRecField=msgRecField + dr["protectedsite"].ToString() +"=";
tmpObject.PROTECTEDSITE = (System.Int32)dr["protectedsite"];
msgRecField=msgRecField + "dateofchange=";
msgRecField=msgRecField + dr["dateofchange"].ToString() +"=";
tmpObject.DATEOFCHANGE = (System.DateTime)dr["dateofchange"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
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
public List<geositeshistory> GetAllByCond(string cond)
{
List<geositeshistory> tmpList = new List<geositeshistory>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From geositeshistory Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
geositeshistory tmpObject = new geositeshistory();
msgRecField="-";
msgRecField=msgRecField + "idgeosite=";
msgRecField=msgRecField + dr["idgeosite"].ToString() +"=";
tmpObject.IDGEOSITE = (System.Int32)dr["idgeosite"];
msgRecField=msgRecField + "idsitename=";
msgRecField=msgRecField + dr["idsitename"].ToString() +"=";
tmpObject.IDSITENAME = (System.String)dr["idsitename"];
msgRecField=msgRecField + "geocoordinates=";
msgRecField=msgRecField + dr["geocoordinates"].ToString() +"=";
tmpObject.GEOCOORDINATES = (System.String)dr["geocoordinates"];
msgRecField=msgRecField + "protectedsite=";
msgRecField=msgRecField + dr["protectedsite"].ToString() +"=";
tmpObject.PROTECTEDSITE = (System.Int32)dr["protectedsite"];
msgRecField=msgRecField + "dateofchange=";
msgRecField=msgRecField + dr["dateofchange"].ToString() +"=";
tmpObject.DATEOFCHANGE = (System.DateTime)dr["dateofchange"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
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
 
