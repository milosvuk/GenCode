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
 
public class DB_sheduling
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_sheduling()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(sheduling _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(sheduling _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO sheduling (id_professional,id_seniorcitizen,id_services,dateofvisit,timeovisit,timeovisitdec,active) VALUES (@id_professional,@id_seniorcitizen,@id_services,@dateofvisit,@timeovisit,@timeovisitdec,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_professional", _tmpObject.ID_PROFESSIONAL));
command.Parameters.Add(new SqlParameter("@id_seniorcitizen", _tmpObject.ID_SENIORCITIZEN));
command.Parameters.Add(new SqlParameter("@id_services", _tmpObject.ID_SERVICES));
command.Parameters.Add(new SqlParameter("@dateofvisit", _tmpObject.DATEOFVISIT));
command.Parameters.Add(new SqlParameter("@timeovisit", _tmpObject.TIMEOVISIT));
command.Parameters.Add(new SqlParameter("@timeovisitdec", _tmpObject.TIMEOVISITDEC));
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
 
public int Update(sheduling _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(sheduling _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE sheduling SET id_professional=@id_professional,id_seniorcitizen=@id_seniorcitizen,id_services=@id_services,dateofvisit=@dateofvisit,timeovisit=@timeovisit,timeovisitdec=@timeovisitdec,active=@active  WHERE idsheduling=@idsheduling", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_professional", _tmpObject.ID_PROFESSIONAL));
command.Parameters.Add(new SqlParameter("@id_seniorcitizen", _tmpObject.ID_SENIORCITIZEN));
command.Parameters.Add(new SqlParameter("@id_services", _tmpObject.ID_SERVICES));
command.Parameters.Add(new SqlParameter("@dateofvisit", _tmpObject.DATEOFVISIT));
command.Parameters.Add(new SqlParameter("@timeovisit", _tmpObject.TIMEOVISIT));
command.Parameters.Add(new SqlParameter("@timeovisitdec", _tmpObject.TIMEOVISITDEC));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idsheduling", _tmpObject.IDSHEDULING));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(sheduling _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(sheduling _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM sheduling  WHERE idsheduling=@idsheduling", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idsheduling", _tmpObject.IDSHEDULING));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public sheduling GetById(int _id)
{
sheduling tmpObject = new sheduling();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From sheduling WHERE idsheduling=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDSHEDULING = (System.Int32)dr["idsheduling"];
tmpObject.ID_PROFESSIONAL = (System.Int32)dr["id_professional"];
tmpObject.ID_SENIORCITIZEN = (System.Int32)dr["id_seniorcitizen"];
tmpObject.ID_SERVICES = (System.Int32)dr["id_services"];
tmpObject.DATEOFVISIT = (System.DateTime)dr["dateofvisit"];
tmpObject.TIMEOVISIT = (System.Int32)dr["timeovisit"];
tmpObject.TIMEOVISITDEC = (System.Decimal)dr["timeovisitdec"];
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
public List<sheduling> GetAll()
{
List<sheduling> tmpList = new List<sheduling>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From sheduling", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
sheduling tmpObject = new sheduling();
msgRecField="-";
msgRecField=msgRecField + "idsheduling=";
msgRecField=msgRecField + dr["idsheduling"].ToString() +"=";
tmpObject.IDSHEDULING = (System.Int32)dr["idsheduling"];
msgRecField=msgRecField + "id_professional=";
msgRecField=msgRecField + dr["id_professional"].ToString() +"=";
tmpObject.ID_PROFESSIONAL = (System.Int32)dr["id_professional"];
msgRecField=msgRecField + "id_seniorcitizen=";
msgRecField=msgRecField + dr["id_seniorcitizen"].ToString() +"=";
tmpObject.ID_SENIORCITIZEN = (System.Int32)dr["id_seniorcitizen"];
msgRecField=msgRecField + "id_services=";
msgRecField=msgRecField + dr["id_services"].ToString() +"=";
tmpObject.ID_SERVICES = (System.Int32)dr["id_services"];
msgRecField=msgRecField + "dateofvisit=";
msgRecField=msgRecField + dr["dateofvisit"].ToString() +"=";
tmpObject.DATEOFVISIT = (System.DateTime)dr["dateofvisit"];
msgRecField=msgRecField + "timeovisit=";
msgRecField=msgRecField + dr["timeovisit"].ToString() +"=";
tmpObject.TIMEOVISIT = (System.Int32)dr["timeovisit"];
msgRecField=msgRecField + "timeovisitdec=";
msgRecField=msgRecField + dr["timeovisitdec"].ToString() +"=";
tmpObject.TIMEOVISITDEC = (System.Decimal)dr["timeovisitdec"];
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
public List<sheduling> GetAllByCond(string cond)
{
List<sheduling> tmpList = new List<sheduling>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From sheduling Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
sheduling tmpObject = new sheduling();
msgRecField="-";
msgRecField=msgRecField + "idsheduling=";
msgRecField=msgRecField + dr["idsheduling"].ToString() +"=";
tmpObject.IDSHEDULING = (System.Int32)dr["idsheduling"];
msgRecField=msgRecField + "id_professional=";
msgRecField=msgRecField + dr["id_professional"].ToString() +"=";
tmpObject.ID_PROFESSIONAL = (System.Int32)dr["id_professional"];
msgRecField=msgRecField + "id_seniorcitizen=";
msgRecField=msgRecField + dr["id_seniorcitizen"].ToString() +"=";
tmpObject.ID_SENIORCITIZEN = (System.Int32)dr["id_seniorcitizen"];
msgRecField=msgRecField + "id_services=";
msgRecField=msgRecField + dr["id_services"].ToString() +"=";
tmpObject.ID_SERVICES = (System.Int32)dr["id_services"];
msgRecField=msgRecField + "dateofvisit=";
msgRecField=msgRecField + dr["dateofvisit"].ToString() +"=";
tmpObject.DATEOFVISIT = (System.DateTime)dr["dateofvisit"];
msgRecField=msgRecField + "timeovisit=";
msgRecField=msgRecField + dr["timeovisit"].ToString() +"=";
tmpObject.TIMEOVISIT = (System.Int32)dr["timeovisit"];
msgRecField=msgRecField + "timeovisitdec=";
msgRecField=msgRecField + dr["timeovisitdec"].ToString() +"=";
tmpObject.TIMEOVISITDEC = (System.Decimal)dr["timeovisitdec"];
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
 
