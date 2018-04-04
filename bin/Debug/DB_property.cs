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
 
public class DB_property
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_property()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(property _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(property _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO property (name,description,id_documents,entitiesyesno,id_company,active) VALUES (@name,@description,@id_documents,@entitiesyesno,@id_company,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_documents", _tmpObject.ID_DOCUMENTS));
command.Parameters.Add(new SqlParameter("@entitiesyesno", _tmpObject.ENTITIESYESNO));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
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
 
public int Update(property _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(property _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE property SET name=@name,description=@description,id_documents=@id_documents,entitiesyesno=@entitiesyesno,id_company=@id_company,active=@active  WHERE idproperty=@idproperty", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_documents", _tmpObject.ID_DOCUMENTS));
command.Parameters.Add(new SqlParameter("@entitiesyesno", _tmpObject.ENTITIESYESNO));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(property _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(property _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE property  WHERE idproperty=@idproperty", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public property GetById(int _id)
{
property tmpObject = new property();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From property WHERE idproperty=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROPERTY = (System.Int32)dr["idproperty"];
tmpObject.NAME = (System.String)dr["name"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpObject.ID_DOCUMENTS = (System.Int32)dr["id_documents"];
tmpObject.ENTITIESYESNO = (System.Int32)dr["entitiesyesno"];
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
public List<property> GetAll()
{
List<property> tmpList = new List<property>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From property", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
property tmpObject = new property();
msgRecField="-";
msgRecField=msgRecField + "idproperty=";
msgRecField=msgRecField + dr["idproperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idproperty"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "id_documents=";
msgRecField=msgRecField + dr["id_documents"].ToString() +"=";
tmpObject.ID_DOCUMENTS = (System.Int32)dr["id_documents"];
msgRecField=msgRecField + "entitiesyesno=";
msgRecField=msgRecField + dr["entitiesyesno"].ToString() +"=";
tmpObject.ENTITIESYESNO = (System.Int32)dr["entitiesyesno"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
public List<property> GetAllByCond(string cond)
{
List<property> tmpList = new List<property>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From property Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
property tmpObject = new property();
msgRecField="-";
msgRecField=msgRecField + "idproperty=";
msgRecField=msgRecField + dr["idproperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idproperty"];
msgRecField=msgRecField + "name=";
msgRecField=msgRecField + dr["name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["name"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "id_documents=";
msgRecField=msgRecField + dr["id_documents"].ToString() +"=";
tmpObject.ID_DOCUMENTS = (System.Int32)dr["id_documents"];
msgRecField=msgRecField + "entitiesyesno=";
msgRecField=msgRecField + dr["entitiesyesno"].ToString() +"=";
tmpObject.ENTITIESYESNO = (System.Int32)dr["entitiesyesno"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
 
