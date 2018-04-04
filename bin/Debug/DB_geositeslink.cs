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
 
public class DB_geositeslink
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_geositeslink()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(geositeslink _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(geositeslink _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO geositeslink (idRecHunter,idgeosite,name,idcard,phonenum,licfinch,licgoldenplower,curyear,active) VALUES (@idRecHunter,@idgeosite,@name,@idcard,@phonenum,@licfinch,@licgoldenplower,@curyear,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecHunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@idgeosite", _tmpObject.IDGEOSITE));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@idcard", _tmpObject.IDCARD));
command.Parameters.Add(new SqlParameter("@phonenum", _tmpObject.PHONENUM));
command.Parameters.Add(new SqlParameter("@licfinch", _tmpObject.LICFINCH));
command.Parameters.Add(new SqlParameter("@licgoldenplower", _tmpObject.LICGOLDENPLOWER));
command.Parameters.Add(new SqlParameter("@curyear", _tmpObject.CURYEAR));
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
 
public int Update(geositeslink _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(geositeslink _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE geositeslink SET idRecHunter=@idrechunter,idgeosite=@idgeosite,name=@name,idcard=@idcard,phonenum=@phonenum,licfinch=@licfinch,licgoldenplower=@licgoldenplower,curyear=@curyear,active=@active  WHERE idgeositeslink=@idgeositeslink", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@idgeosite", _tmpObject.IDGEOSITE));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@idcard", _tmpObject.IDCARD));
command.Parameters.Add(new SqlParameter("@phonenum", _tmpObject.PHONENUM));
command.Parameters.Add(new SqlParameter("@licfinch", _tmpObject.LICFINCH));
command.Parameters.Add(new SqlParameter("@licgoldenplower", _tmpObject.LICGOLDENPLOWER));
command.Parameters.Add(new SqlParameter("@curyear", _tmpObject.CURYEAR));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idgeositeslink", _tmpObject.IDGEOSITESLINK));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(geositeslink _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(geositeslink _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE geositeslink  WHERE idgeositeslink=@idgeositeslink", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idgeositeslink", _tmpObject.IDGEOSITESLINK));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public geositeslink GetById(int _id)
{
geositeslink tmpObject = new geositeslink();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From geositeslink WHERE idgeositeslink=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDGEOSITESLINK = (System.Int32)dr["idgeositeslink"];
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDGEOSITE = (System.Int32)dr["idgeosite"];
tmpObject.NAME = (System.String)dr["name"];
tmpObject.IDCARD = (System.String)dr["idcard"];
tmpObject.PHONENUM = (System.String)dr["phonenum"];
tmpObject.LICFINCH = (System.String)dr["licfinch"];
tmpObject.LICGOLDENPLOWER = (System.String)dr["licgoldenplower"];
tmpObject.CURYEAR = (System.Int32)dr["curyear"];
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
public List<geositeslink> GetAll()
{
List<geositeslink> tmpList = new List<geositeslink>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From geositeslink", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
geositeslink tmpObject = new geositeslink();
msgRecField="-";
msgRecField=msgRecField + "idgeositeslink=";
msgRecField=msgRecField + dr["idgeositeslink"].ToString() +"=";
tmpObject.IDGEOSITESLINK = (System.Int32)dr["idgeositeslink"];
msgRecField=msgRecField + "idRecHunter=";
msgRecField=msgRecField + dr["idRecHunter"].ToString() +"=";
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
msgRecField=msgRecField + "idgeosite=";
msgRecField=msgRecField + dr["idgeosite"].ToString() +"=";
tmpObject.IDGEOSITE = (System.Int32)dr["idgeosite"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "idcard=";
msgRecField=msgRecField + dr["idcard"].ToString() +"=";
tmpObject.IDCARD = (System.String)dr["idcard"];
msgRecField=msgRecField + "phonenum=";
msgRecField=msgRecField + dr["phonenum"].ToString() +"=";
tmpObject.PHONENUM = (System.String)dr["phonenum"];
msgRecField=msgRecField + "licfinch=";
msgRecField=msgRecField + dr["licfinch"].ToString() +"=";
tmpObject.LICFINCH = (System.String)dr["licfinch"];
msgRecField=msgRecField + "licgoldenplower=";
msgRecField=msgRecField + dr["licgoldenplower"].ToString() +"=";
tmpObject.LICGOLDENPLOWER = (System.String)dr["licgoldenplower"];
msgRecField=msgRecField + "curyear=";
msgRecField=msgRecField + dr["curyear"].ToString() +"=";
tmpObject.CURYEAR = (System.Int32)dr["curyear"];
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
public List<geositeslink> GetAllByCond(string cond)
{
List<geositeslink> tmpList = new List<geositeslink>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From geositeslink Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
geositeslink tmpObject = new geositeslink();
msgRecField="-";
msgRecField=msgRecField + "idgeositeslink=";
msgRecField=msgRecField + dr["idgeositeslink"].ToString() +"=";
tmpObject.IDGEOSITESLINK = (System.Int32)dr["idgeositeslink"];
msgRecField=msgRecField + "idRecHunter=";
msgRecField=msgRecField + dr["idRecHunter"].ToString() +"=";
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
msgRecField=msgRecField + "idgeosite=";
msgRecField=msgRecField + dr["idgeosite"].ToString() +"=";
tmpObject.IDGEOSITE = (System.Int32)dr["idgeosite"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "idcard=";
msgRecField=msgRecField + dr["idcard"].ToString() +"=";
tmpObject.IDCARD = (System.String)dr["idcard"];
msgRecField=msgRecField + "phonenum=";
msgRecField=msgRecField + dr["phonenum"].ToString() +"=";
tmpObject.PHONENUM = (System.String)dr["phonenum"];
msgRecField=msgRecField + "licfinch=";
msgRecField=msgRecField + dr["licfinch"].ToString() +"=";
tmpObject.LICFINCH = (System.String)dr["licfinch"];
msgRecField=msgRecField + "licgoldenplower=";
msgRecField=msgRecField + dr["licgoldenplower"].ToString() +"=";
tmpObject.LICGOLDENPLOWER = (System.String)dr["licgoldenplower"];
msgRecField=msgRecField + "curyear=";
msgRecField=msgRecField + dr["curyear"].ToString() +"=";
tmpObject.CURYEAR = (System.Int32)dr["curyear"];
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
 
