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
 
public class DB_seniorcitizen
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_seniorcitizen()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(seniorcitizen _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(seniorcitizen _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO seniorcitizen (Name,Surname,IDcard,Address1,Address2,Address3,City,LocCoordLat,LocCoordLong,Phone,Mobile,Email,Comment,active) VALUES (@Name,@Surname,@IDcard,@Address1,@Address2,@Address3,@City,@LocCoordLat,@LocCoordLong,@Phone,@Mobile,@Email,@Comment,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@Name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@Surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@IDcard", _tmpObject.IDCARD));
command.Parameters.Add(new SqlParameter("@Address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@Address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@Address3", _tmpObject.ADDRESS3));
command.Parameters.Add(new SqlParameter("@City", _tmpObject.CITY));
command.Parameters.Add(new SqlParameter("@LocCoordLat", _tmpObject.LOCCOORDLAT));
command.Parameters.Add(new SqlParameter("@LocCoordLong", _tmpObject.LOCCOORDLONG));
command.Parameters.Add(new SqlParameter("@Phone", _tmpObject.PHONE));
command.Parameters.Add(new SqlParameter("@Mobile", _tmpObject.MOBILE));
command.Parameters.Add(new SqlParameter("@Email", _tmpObject.EMAIL));
command.Parameters.Add(new SqlParameter("@Comment", _tmpObject.COMMENT));
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
 
public int Update(seniorcitizen _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(seniorcitizen _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE seniorcitizen SET Name=@name,Surname=@surname,IDcard=@idcard,Address1=@address1,Address2=@address2,Address3=@address3,City=@city,LocCoordLat=@loccoordlat,LocCoordLong=@loccoordlong,Phone=@phone,Mobile=@mobile,Email=@email,Comment=@comment,active=@active  WHERE idseniorcitizen=@idseniorcitizen", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@idcard", _tmpObject.IDCARD));
command.Parameters.Add(new SqlParameter("@address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@address3", _tmpObject.ADDRESS3));
command.Parameters.Add(new SqlParameter("@city", _tmpObject.CITY));
command.Parameters.Add(new SqlParameter("@loccoordlat", _tmpObject.LOCCOORDLAT));
command.Parameters.Add(new SqlParameter("@loccoordlong", _tmpObject.LOCCOORDLONG));
command.Parameters.Add(new SqlParameter("@phone", _tmpObject.PHONE));
command.Parameters.Add(new SqlParameter("@mobile", _tmpObject.MOBILE));
command.Parameters.Add(new SqlParameter("@email", _tmpObject.EMAIL));
command.Parameters.Add(new SqlParameter("@comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idseniorcitizen", _tmpObject.IDSENIORCITIZEN));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(seniorcitizen _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(seniorcitizen _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM seniorcitizen  WHERE idseniorcitizen=@idseniorcitizen", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idseniorcitizen", _tmpObject.IDSENIORCITIZEN));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public seniorcitizen GetById(int _id)
{
seniorcitizen tmpObject = new seniorcitizen();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From seniorcitizen WHERE idseniorcitizen=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDSENIORCITIZEN = (System.Int32)dr["idseniorcitizen"];
tmpObject.NAME = (System.String)dr["Name"];
tmpObject.SURNAME = (System.String)dr["Surname"];
tmpObject.IDCARD = (System.String)dr["IDcard"];
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
tmpObject.CITY = (System.String)dr["City"];
tmpObject.LOCCOORDLAT = (System.String)dr["LocCoordLat"];
tmpObject.LOCCOORDLONG = (System.String)dr["LocCoordLong"];
tmpObject.PHONE = (System.String)dr["Phone"];
tmpObject.MOBILE = (System.String)dr["Mobile"];
tmpObject.EMAIL = (System.String)dr["Email"];
tmpObject.COMMENT = (System.String)dr["Comment"];
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
public List<seniorcitizen> GetAll()
{
List<seniorcitizen> tmpList = new List<seniorcitizen>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From seniorcitizen", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
seniorcitizen tmpObject = new seniorcitizen();
msgRecField="-";
msgRecField=msgRecField + "idseniorcitizen=";
msgRecField=msgRecField + dr["idseniorcitizen"].ToString() +"=";
tmpObject.IDSENIORCITIZEN = (System.Int32)dr["idseniorcitizen"];
msgRecField=msgRecField + "Name=";
msgRecField=msgRecField + dr["Name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["Name"];
msgRecField=msgRecField + "Surname=";
msgRecField=msgRecField + dr["Surname"].ToString() +"=";
tmpObject.SURNAME = (System.String)dr["Surname"];
msgRecField=msgRecField + "IDcard=";
msgRecField=msgRecField + dr["IDcard"].ToString() +"=";
tmpObject.IDCARD = (System.String)dr["IDcard"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address3=";
msgRecField=msgRecField + dr["Address3"].ToString() +"=";
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
msgRecField=msgRecField + "City=";
msgRecField=msgRecField + dr["City"].ToString() +"=";
tmpObject.CITY = (System.String)dr["City"];
msgRecField=msgRecField + "LocCoordLat=";
msgRecField=msgRecField + dr["LocCoordLat"].ToString() +"=";
tmpObject.LOCCOORDLAT = (System.String)dr["LocCoordLat"];
msgRecField=msgRecField + "LocCoordLong=";
msgRecField=msgRecField + dr["LocCoordLong"].ToString() +"=";
tmpObject.LOCCOORDLONG = (System.String)dr["LocCoordLong"];
msgRecField=msgRecField + "Phone=";
msgRecField=msgRecField + dr["Phone"].ToString() +"=";
tmpObject.PHONE = (System.String)dr["Phone"];
msgRecField=msgRecField + "Mobile=";
msgRecField=msgRecField + dr["Mobile"].ToString() +"=";
tmpObject.MOBILE = (System.String)dr["Mobile"];
msgRecField=msgRecField + "Email=";
msgRecField=msgRecField + dr["Email"].ToString() +"=";
tmpObject.EMAIL = (System.String)dr["Email"];
msgRecField=msgRecField + "Comment=";
msgRecField=msgRecField + dr["Comment"].ToString() +"=";
tmpObject.COMMENT = (System.String)dr["Comment"];
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
public List<seniorcitizen> GetAllByCond(string cond)
{
List<seniorcitizen> tmpList = new List<seniorcitizen>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From seniorcitizen Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
seniorcitizen tmpObject = new seniorcitizen();
msgRecField="-";
msgRecField=msgRecField + "idseniorcitizen=";
msgRecField=msgRecField + dr["idseniorcitizen"].ToString() +"=";
tmpObject.IDSENIORCITIZEN = (System.Int32)dr["idseniorcitizen"];
msgRecField=msgRecField + "Name=";
msgRecField=msgRecField + dr["Name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["Name"];
msgRecField=msgRecField + "Surname=";
msgRecField=msgRecField + dr["Surname"].ToString() +"=";
tmpObject.SURNAME = (System.String)dr["Surname"];
msgRecField=msgRecField + "IDcard=";
msgRecField=msgRecField + dr["IDcard"].ToString() +"=";
tmpObject.IDCARD = (System.String)dr["IDcard"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address3=";
msgRecField=msgRecField + dr["Address3"].ToString() +"=";
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
msgRecField=msgRecField + "City=";
msgRecField=msgRecField + dr["City"].ToString() +"=";
tmpObject.CITY = (System.String)dr["City"];
msgRecField=msgRecField + "LocCoordLat=";
msgRecField=msgRecField + dr["LocCoordLat"].ToString() +"=";
tmpObject.LOCCOORDLAT = (System.String)dr["LocCoordLat"];
msgRecField=msgRecField + "LocCoordLong=";
msgRecField=msgRecField + dr["LocCoordLong"].ToString() +"=";
tmpObject.LOCCOORDLONG = (System.String)dr["LocCoordLong"];
msgRecField=msgRecField + "Phone=";
msgRecField=msgRecField + dr["Phone"].ToString() +"=";
tmpObject.PHONE = (System.String)dr["Phone"];
msgRecField=msgRecField + "Mobile=";
msgRecField=msgRecField + dr["Mobile"].ToString() +"=";
tmpObject.MOBILE = (System.String)dr["Mobile"];
msgRecField=msgRecField + "Email=";
msgRecField=msgRecField + dr["Email"].ToString() +"=";
tmpObject.EMAIL = (System.String)dr["Email"];
msgRecField=msgRecField + "Comment=";
msgRecField=msgRecField + dr["Comment"].ToString() +"=";
tmpObject.COMMENT = (System.String)dr["Comment"];
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
 
