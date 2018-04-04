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
 
public class DB_receiving
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_receiving()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(receiving _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(receiving _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO receiving (dateOfReceiving,datetimeOfReceving,numOfReceiving,id_store,id_user,id_vendor,amountOfReceiving,finalized,id_company) VALUES (@dateOfReceiving,@datetimeOfReceving,@numOfReceiving,@id_store,@id_user,@id_vendor,@amountOfReceiving,@finalized,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@dateOfReceiving", _tmpObject.DATEOFRECEIVING));
command.Parameters.Add(new SqlParameter("@datetimeOfReceving", _tmpObject.DATETIMEOFRECEVING));
command.Parameters.Add(new SqlParameter("@numOfReceiving", _tmpObject.NUMOFRECEIVING));
command.Parameters.Add(new SqlParameter("@id_store", _tmpObject.ID_STORE));
command.Parameters.Add(new SqlParameter("@id_user", _tmpObject.ID_USER));
command.Parameters.Add(new SqlParameter("@id_vendor", _tmpObject.ID_VENDOR));
command.Parameters.Add(new SqlParameter("@amountOfReceiving", _tmpObject.AMOUNTOFRECEIVING));
command.Parameters.Add(new SqlParameter("@finalized", _tmpObject.FINALIZED));
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
 
public int Update(receiving _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(receiving _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE receiving SET dateOfReceiving=@dateofreceiving,datetimeOfReceving=@datetimeofreceving,numOfReceiving=@numofreceiving,id_store=@id_store,id_user=@id_user,id_vendor=@id_vendor,amountOfReceiving=@amountofreceiving,finalized=@finalized,id_company=@id_company  WHERE idreceivedv=@idreceivedv", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@dateofreceiving", _tmpObject.DATEOFRECEIVING));
command.Parameters.Add(new SqlParameter("@datetimeofreceving", _tmpObject.DATETIMEOFRECEVING));
command.Parameters.Add(new SqlParameter("@numofreceiving", _tmpObject.NUMOFRECEIVING));
command.Parameters.Add(new SqlParameter("@id_store", _tmpObject.ID_STORE));
command.Parameters.Add(new SqlParameter("@id_user", _tmpObject.ID_USER));
command.Parameters.Add(new SqlParameter("@id_vendor", _tmpObject.ID_VENDOR));
command.Parameters.Add(new SqlParameter("@amountofreceiving", _tmpObject.AMOUNTOFRECEIVING));
command.Parameters.Add(new SqlParameter("@finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idreceivedv", _tmpObject.IDRECEIVEDV));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(receiving _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(receiving _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE receiving  WHERE idreceivedv=@idreceivedv", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idreceivedv", _tmpObject.IDRECEIVEDV));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public receiving GetById(int _id)
{
receiving tmpObject = new receiving();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From receiving WHERE idreceivedv=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECEIVEDV = (System.Int32)dr["idreceivedv"];
tmpObject.DATEOFRECEIVING = (System.DateTime)dr["dateOfReceiving"];
tmpObject.DATETIMEOFRECEVING = (System.DateTime)dr["datetimeOfReceving"];
tmpObject.NUMOFRECEIVING = (System.Int32)dr["numOfReceiving"];
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
tmpObject.ID_USER = (System.Int32)dr["id_user"];
tmpObject.ID_VENDOR = (System.Int32)dr["id_vendor"];
tmpObject.AMOUNTOFRECEIVING = (System.Decimal)dr["amountOfReceiving"];
tmpObject.FINALIZED = (System.Int32)dr["finalized"];
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
public List<receiving> GetAll()
{
List<receiving> tmpList = new List<receiving>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From receiving", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
receiving tmpObject = new receiving();
msgRecField="-";
msgRecField=msgRecField + "idreceivedv=";
msgRecField=msgRecField + dr["idreceivedv"].ToString() +"=";
tmpObject.IDRECEIVEDV = (System.Int32)dr["idreceivedv"];
msgRecField=msgRecField + "dateOfReceiving=";
msgRecField=msgRecField + dr["dateOfReceiving"].ToString() +"=";
tmpObject.DATEOFRECEIVING = (System.DateTime)dr["dateOfReceiving"];
msgRecField=msgRecField + "datetimeOfReceving=";
msgRecField=msgRecField + dr["datetimeOfReceving"].ToString() +"=";
tmpObject.DATETIMEOFRECEVING = (System.DateTime)dr["datetimeOfReceving"];
msgRecField=msgRecField + "numOfReceiving=";
msgRecField=msgRecField + dr["numOfReceiving"].ToString() +"=";
tmpObject.NUMOFRECEIVING = (System.Int32)dr["numOfReceiving"];
msgRecField=msgRecField + "id_store=";
msgRecField=msgRecField + dr["id_store"].ToString() +"=";
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
msgRecField=msgRecField + "id_user=";
msgRecField=msgRecField + dr["id_user"].ToString() +"=";
tmpObject.ID_USER = (System.Int32)dr["id_user"];
msgRecField=msgRecField + "id_vendor=";
msgRecField=msgRecField + dr["id_vendor"].ToString() +"=";
tmpObject.ID_VENDOR = (System.Int32)dr["id_vendor"];
msgRecField=msgRecField + "amountOfReceiving=";
msgRecField=msgRecField + dr["amountOfReceiving"].ToString() +"=";
tmpObject.AMOUNTOFRECEIVING = (System.Decimal)dr["amountOfReceiving"];
msgRecField=msgRecField + "finalized=";
msgRecField=msgRecField + dr["finalized"].ToString() +"=";
tmpObject.FINALIZED = (System.Int32)dr["finalized"];
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
public List<receiving> GetAllByCond(string cond)
{
List<receiving> tmpList = new List<receiving>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From receiving Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
receiving tmpObject = new receiving();
msgRecField="-";
msgRecField=msgRecField + "idreceivedv=";
msgRecField=msgRecField + dr["idreceivedv"].ToString() +"=";
tmpObject.IDRECEIVEDV = (System.Int32)dr["idreceivedv"];
msgRecField=msgRecField + "dateOfReceiving=";
msgRecField=msgRecField + dr["dateOfReceiving"].ToString() +"=";
tmpObject.DATEOFRECEIVING = (System.DateTime)dr["dateOfReceiving"];
msgRecField=msgRecField + "datetimeOfReceving=";
msgRecField=msgRecField + dr["datetimeOfReceving"].ToString() +"=";
tmpObject.DATETIMEOFRECEVING = (System.DateTime)dr["datetimeOfReceving"];
msgRecField=msgRecField + "numOfReceiving=";
msgRecField=msgRecField + dr["numOfReceiving"].ToString() +"=";
tmpObject.NUMOFRECEIVING = (System.Int32)dr["numOfReceiving"];
msgRecField=msgRecField + "id_store=";
msgRecField=msgRecField + dr["id_store"].ToString() +"=";
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
msgRecField=msgRecField + "id_user=";
msgRecField=msgRecField + dr["id_user"].ToString() +"=";
tmpObject.ID_USER = (System.Int32)dr["id_user"];
msgRecField=msgRecField + "id_vendor=";
msgRecField=msgRecField + dr["id_vendor"].ToString() +"=";
tmpObject.ID_VENDOR = (System.Int32)dr["id_vendor"];
msgRecField=msgRecField + "amountOfReceiving=";
msgRecField=msgRecField + dr["amountOfReceiving"].ToString() +"=";
tmpObject.AMOUNTOFRECEIVING = (System.Decimal)dr["amountOfReceiving"];
msgRecField=msgRecField + "finalized=";
msgRecField=msgRecField + dr["finalized"].ToString() +"=";
tmpObject.FINALIZED = (System.Int32)dr["finalized"];
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
 
