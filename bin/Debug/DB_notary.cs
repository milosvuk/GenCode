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
 
public class DB_notary
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_notary()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(notary _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(notary _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO notary (FullName,Address,Phone,Email,Comment,idCompany) VALUES (@FullName,@Address,@Phone,@Email,@Comment,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@FullName", _tmpObject.FULLNAME));
command.Parameters.Add(new SqlParameter("@Address", _tmpObject.ADDRESS));
command.Parameters.Add(new SqlParameter("@Phone", _tmpObject.PHONE));
command.Parameters.Add(new SqlParameter("@Email", _tmpObject.EMAIL));
command.Parameters.Add(new SqlParameter("@Comment", _tmpObject.COMMENT));
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
 
public int Update(notary _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(notary _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE notary SET FullName=@fullname,Address=@address,Phone=@phone,Email=@email,Comment=@comment,idCompany=@idcompany  WHERE idNotary=@idnotary", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@fullname", _tmpObject.FULLNAME));
command.Parameters.Add(new SqlParameter("@address", _tmpObject.ADDRESS));
command.Parameters.Add(new SqlParameter("@phone", _tmpObject.PHONE));
command.Parameters.Add(new SqlParameter("@email", _tmpObject.EMAIL));
command.Parameters.Add(new SqlParameter("@comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idnotary", _tmpObject.IDNOTARY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(notary _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(notary _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE notary  WHERE idNotary=@idnotary", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idnotary", _tmpObject.IDNOTARY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public notary GetById(int _id)
{
notary tmpObject = new notary();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From notary WHERE idNotary=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
tmpObject.FULLNAME = (System.String)dr["FullName"];
tmpObject.ADDRESS = (System.String)dr["Address"];
tmpObject.PHONE = (System.String)dr["Phone"];
tmpObject.EMAIL = (System.String)dr["Email"];
tmpObject.COMMENT = (System.String)dr["Comment"];
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
public List<notary> GetAll()
{
List<notary> tmpList = new List<notary>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From notary", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
notary tmpObject = new notary();
msgRecField="-";
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "FullName=";
msgRecField=msgRecField + dr["FullName"].ToString() +"=";
tmpObject.FULLNAME = (System.String)dr["FullName"];
msgRecField=msgRecField + "Address=";
msgRecField=msgRecField + dr["Address"].ToString() +"=";
tmpObject.ADDRESS = (System.String)dr["Address"];
msgRecField=msgRecField + "Phone=";
msgRecField=msgRecField + dr["Phone"].ToString() +"=";
tmpObject.PHONE = (System.String)dr["Phone"];
msgRecField=msgRecField + "Email=";
msgRecField=msgRecField + dr["Email"].ToString() +"=";
tmpObject.EMAIL = (System.String)dr["Email"];
msgRecField=msgRecField + "Comment=";
msgRecField=msgRecField + dr["Comment"].ToString() +"=";
tmpObject.COMMENT = (System.String)dr["Comment"];
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
public List<notary> GetAllByCond(string cond)
{
List<notary> tmpList = new List<notary>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From notary Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
notary tmpObject = new notary();
msgRecField="-";
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "FullName=";
msgRecField=msgRecField + dr["FullName"].ToString() +"=";
tmpObject.FULLNAME = (System.String)dr["FullName"];
msgRecField=msgRecField + "Address=";
msgRecField=msgRecField + dr["Address"].ToString() +"=";
tmpObject.ADDRESS = (System.String)dr["Address"];
msgRecField=msgRecField + "Phone=";
msgRecField=msgRecField + dr["Phone"].ToString() +"=";
tmpObject.PHONE = (System.String)dr["Phone"];
msgRecField=msgRecField + "Email=";
msgRecField=msgRecField + dr["Email"].ToString() +"=";
tmpObject.EMAIL = (System.String)dr["Email"];
msgRecField=msgRecField + "Comment=";
msgRecField=msgRecField + dr["Comment"].ToString() +"=";
tmpObject.COMMENT = (System.String)dr["Comment"];
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
 
