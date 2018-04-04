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
 
public class DB_aquisition
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_aquisition()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(aquisition _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(aquisition _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO aquisition (idProperty,FromOwner,ToOwner,idNotary,Dateofaquisition,Comment,idCompany) VALUES (@idProperty,@FromOwner,@ToOwner,@idNotary,@Dateofaquisition,@Comment,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@FromOwner", _tmpObject.FROMOWNER));
command.Parameters.Add(new SqlParameter("@ToOwner", _tmpObject.TOOWNER));
command.Parameters.Add(new SqlParameter("@idNotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@Dateofaquisition", _tmpObject.DATEOFAQUISITION));
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
 
public int Update(aquisition _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(aquisition _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE aquisition SET idProperty=@idproperty,FromOwner=@fromowner,ToOwner=@toowner,idNotary=@idnotary,Dateofaquisition=@dateofaquisition,Comment=@comment,idCompany=@idcompany  WHERE idRecAquisition=@idrecaquisition", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@fromowner", _tmpObject.FROMOWNER));
command.Parameters.Add(new SqlParameter("@toowner", _tmpObject.TOOWNER));
command.Parameters.Add(new SqlParameter("@idnotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@dateofaquisition", _tmpObject.DATEOFAQUISITION));
command.Parameters.Add(new SqlParameter("@comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idrecaquisition", _tmpObject.IDRECAQUISITION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(aquisition _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(aquisition _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE aquisition  WHERE idRecAquisition=@idrecaquisition", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecaquisition", _tmpObject.IDRECAQUISITION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public aquisition GetById(int _id)
{
aquisition tmpObject = new aquisition();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From aquisition WHERE idRecAquisition=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECAQUISITION = (System.Int32)dr["idRecAquisition"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.FROMOWNER = (System.Int32)dr["FromOwner"];
tmpObject.TOOWNER = (System.Int32)dr["ToOwner"];
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
tmpObject.DATEOFAQUISITION = (System.DateTime)dr["Dateofaquisition"];
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
public List<aquisition> GetAll()
{
List<aquisition> tmpList = new List<aquisition>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From aquisition", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
aquisition tmpObject = new aquisition();
msgRecField="-";
msgRecField=msgRecField + "idRecAquisition=";
msgRecField=msgRecField + dr["idRecAquisition"].ToString() +"=";
tmpObject.IDRECAQUISITION = (System.Int32)dr["idRecAquisition"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "FromOwner=";
msgRecField=msgRecField + dr["FromOwner"].ToString() +"=";
tmpObject.FROMOWNER = (System.Int32)dr["FromOwner"];
msgRecField=msgRecField + "ToOwner=";
msgRecField=msgRecField + dr["ToOwner"].ToString() +"=";
tmpObject.TOOWNER = (System.Int32)dr["ToOwner"];
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "Dateofaquisition=";
msgRecField=msgRecField + dr["Dateofaquisition"].ToString() +"=";
tmpObject.DATEOFAQUISITION = (System.DateTime)dr["Dateofaquisition"];
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
public List<aquisition> GetAllByCond(string cond)
{
List<aquisition> tmpList = new List<aquisition>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From aquisition Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
aquisition tmpObject = new aquisition();
msgRecField="-";
msgRecField=msgRecField + "idRecAquisition=";
msgRecField=msgRecField + dr["idRecAquisition"].ToString() +"=";
tmpObject.IDRECAQUISITION = (System.Int32)dr["idRecAquisition"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "FromOwner=";
msgRecField=msgRecField + dr["FromOwner"].ToString() +"=";
tmpObject.FROMOWNER = (System.Int32)dr["FromOwner"];
msgRecField=msgRecField + "ToOwner=";
msgRecField=msgRecField + dr["ToOwner"].ToString() +"=";
tmpObject.TOOWNER = (System.Int32)dr["ToOwner"];
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "Dateofaquisition=";
msgRecField=msgRecField + dr["Dateofaquisition"].ToString() +"=";
tmpObject.DATEOFAQUISITION = (System.DateTime)dr["Dateofaquisition"];
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
 
