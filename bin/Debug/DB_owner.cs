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
 
public class DB_owner
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_owner()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(owner _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(owner _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO owner (OwnerCode,OwnerFullName,Address,Contact,Comment,Active) VALUES (@OwnerCode,@OwnerFullName,@Address,@Contact,@Comment,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@OwnerCode", _tmpObject.OWNERCODE));
command.Parameters.Add(new SqlParameter("@OwnerFullName", _tmpObject.OWNERFULLNAME));
command.Parameters.Add(new SqlParameter("@Address", _tmpObject.ADDRESS));
command.Parameters.Add(new SqlParameter("@Contact", _tmpObject.CONTACT));
command.Parameters.Add(new SqlParameter("@Comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
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
 
public int Update(owner _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(owner _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE owner SET OwnerCode=@ownercode,OwnerFullName=@ownerfullname,Address=@address,Contact=@contact,Comment=@comment,Active=@active  WHERE idOwner=@idowner", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@ownercode", _tmpObject.OWNERCODE));
command.Parameters.Add(new SqlParameter("@ownerfullname", _tmpObject.OWNERFULLNAME));
command.Parameters.Add(new SqlParameter("@address", _tmpObject.ADDRESS));
command.Parameters.Add(new SqlParameter("@contact", _tmpObject.CONTACT));
command.Parameters.Add(new SqlParameter("@comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idowner", _tmpObject.IDOWNER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(owner _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(owner _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE owner  WHERE idOwner=@idowner", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idowner", _tmpObject.IDOWNER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public owner GetById(int _id)
{
owner tmpObject = new owner();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From owner WHERE idOwner=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDOWNER = (System.Int32)dr["idOwner"];
tmpObject.OWNERCODE = (System.String)dr["OwnerCode"];
tmpObject.OWNERFULLNAME = (System.String)dr["OwnerFullName"];
tmpObject.ADDRESS = (System.String)dr["Address"];
tmpObject.CONTACT = (System.String)dr["Contact"];
tmpObject.COMMENT = (System.String)dr["Comment"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
public List<owner> GetAll()
{
List<owner> tmpList = new List<owner>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From owner", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
owner tmpObject = new owner();
msgRecField="-";
msgRecField=msgRecField + "idOwner=";
msgRecField=msgRecField + dr["idOwner"].ToString() +"=";
tmpObject.IDOWNER = (System.Int32)dr["idOwner"];
msgRecField=msgRecField + "OwnerCode=";
msgRecField=msgRecField + dr["OwnerCode"].ToString() +"=";
tmpObject.OWNERCODE = (System.String)dr["OwnerCode"];
msgRecField=msgRecField + "OwnerFullName=";
msgRecField=msgRecField + dr["OwnerFullName"].ToString() +"=";
tmpObject.OWNERFULLNAME = (System.String)dr["OwnerFullName"];
msgRecField=msgRecField + "Address=";
msgRecField=msgRecField + dr["Address"].ToString() +"=";
tmpObject.ADDRESS = (System.String)dr["Address"];
msgRecField=msgRecField + "Contact=";
msgRecField=msgRecField + dr["Contact"].ToString() +"=";
tmpObject.CONTACT = (System.String)dr["Contact"];
msgRecField=msgRecField + "Comment=";
msgRecField=msgRecField + dr["Comment"].ToString() +"=";
tmpObject.COMMENT = (System.String)dr["Comment"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
public List<owner> GetAllByCond(string cond)
{
List<owner> tmpList = new List<owner>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From owner Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
owner tmpObject = new owner();
msgRecField="-";
msgRecField=msgRecField + "idOwner=";
msgRecField=msgRecField + dr["idOwner"].ToString() +"=";
tmpObject.IDOWNER = (System.Int32)dr["idOwner"];
msgRecField=msgRecField + "OwnerCode=";
msgRecField=msgRecField + dr["OwnerCode"].ToString() +"=";
tmpObject.OWNERCODE = (System.String)dr["OwnerCode"];
msgRecField=msgRecField + "OwnerFullName=";
msgRecField=msgRecField + dr["OwnerFullName"].ToString() +"=";
tmpObject.OWNERFULLNAME = (System.String)dr["OwnerFullName"];
msgRecField=msgRecField + "Address=";
msgRecField=msgRecField + dr["Address"].ToString() +"=";
tmpObject.ADDRESS = (System.String)dr["Address"];
msgRecField=msgRecField + "Contact=";
msgRecField=msgRecField + dr["Contact"].ToString() +"=";
tmpObject.CONTACT = (System.String)dr["Contact"];
msgRecField=msgRecField + "Comment=";
msgRecField=msgRecField + dr["Comment"].ToString() +"=";
tmpObject.COMMENT = (System.String)dr["Comment"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
 
