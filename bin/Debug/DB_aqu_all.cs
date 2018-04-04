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
 
public class DB_aqu_all
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_aqu_all()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(aqu_all _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(aqu_all _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO aqu_all (FromOwner,ToOwner,idNotary,Dateofaquisition,Comment,OwnerCode,OwnerFullName,OwnerCodeTo,OwnerNameTo,NotaryName,idProperty,Description) VALUES (@FromOwner,@ToOwner,@idNotary,@Dateofaquisition,@Comment,@OwnerCode,@OwnerFullName,@OwnerCodeTo,@OwnerNameTo,@NotaryName,@idProperty,@Description) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@FromOwner", _tmpObject.FROMOWNER));
command.Parameters.Add(new SqlParameter("@ToOwner", _tmpObject.TOOWNER));
command.Parameters.Add(new SqlParameter("@idNotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@Dateofaquisition", _tmpObject.DATEOFAQUISITION));
command.Parameters.Add(new SqlParameter("@Comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@OwnerCode", _tmpObject.OWNERCODE));
command.Parameters.Add(new SqlParameter("@OwnerFullName", _tmpObject.OWNERFULLNAME));
command.Parameters.Add(new SqlParameter("@OwnerCodeTo", _tmpObject.OWNERCODETO));
command.Parameters.Add(new SqlParameter("@OwnerNameTo", _tmpObject.OWNERNAMETO));
command.Parameters.Add(new SqlParameter("@NotaryName", _tmpObject.NOTARYNAME));
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
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
 
public int Update(aqu_all _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(aqu_all _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE aqu_all SET FromOwner=@fromowner,ToOwner=@toowner,idNotary=@idnotary,Dateofaquisition=@dateofaquisition,Comment=@comment,OwnerCode=@ownercode,OwnerFullName=@ownerfullname,OwnerCodeTo=@ownercodeto,OwnerNameTo=@ownernameto,NotaryName=@notaryname,idProperty=@idproperty,Description=@description  WHERE idRecAquisition=@idrecaquisition", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@fromowner", _tmpObject.FROMOWNER));
command.Parameters.Add(new SqlParameter("@toowner", _tmpObject.TOOWNER));
command.Parameters.Add(new SqlParameter("@idnotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@dateofaquisition", _tmpObject.DATEOFAQUISITION));
command.Parameters.Add(new SqlParameter("@comment", _tmpObject.COMMENT));
command.Parameters.Add(new SqlParameter("@ownercode", _tmpObject.OWNERCODE));
command.Parameters.Add(new SqlParameter("@ownerfullname", _tmpObject.OWNERFULLNAME));
command.Parameters.Add(new SqlParameter("@ownercodeto", _tmpObject.OWNERCODETO));
command.Parameters.Add(new SqlParameter("@ownernameto", _tmpObject.OWNERNAMETO));
command.Parameters.Add(new SqlParameter("@notaryname", _tmpObject.NOTARYNAME));
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
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
 
public int Delete(aqu_all _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(aqu_all _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE aqu_all  WHERE idRecAquisition=@idrecaquisition", conn);
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
public aqu_all GetById(int _id)
{
aqu_all tmpObject = new aqu_all();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From aqu_all WHERE idRecAquisition=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECAQUISITION = (System.Int32)dr["idRecAquisition"];
tmpObject.FROMOWNER = (System.Int32)dr["FromOwner"];
tmpObject.TOOWNER = (System.Int32)dr["ToOwner"];
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
tmpObject.DATEOFAQUISITION = (System.DateTime)dr["Dateofaquisition"];
tmpObject.COMMENT = (System.String)dr["Comment"];
tmpObject.OWNERCODE = (System.String)dr["OwnerCode"];
tmpObject.OWNERFULLNAME = (System.String)dr["OwnerFullName"];
tmpObject.OWNERCODETO = (System.String)dr["OwnerCodeTo"];
tmpObject.OWNERNAMETO = (System.String)dr["OwnerNameTo"];
tmpObject.NOTARYNAME = (System.String)dr["NotaryName"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
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
public List<aqu_all> GetAll()
{
List<aqu_all> tmpList = new List<aqu_all>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From aqu_all", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
aqu_all tmpObject = new aqu_all();
msgRecField="-";
msgRecField=msgRecField + "idRecAquisition=";
msgRecField=msgRecField + dr["idRecAquisition"].ToString() +"=";
tmpObject.IDRECAQUISITION = (System.Int32)dr["idRecAquisition"];
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
msgRecField=msgRecField + "OwnerCode=";
msgRecField=msgRecField + dr["OwnerCode"].ToString() +"=";
tmpObject.OWNERCODE = (System.String)dr["OwnerCode"];
msgRecField=msgRecField + "OwnerFullName=";
msgRecField=msgRecField + dr["OwnerFullName"].ToString() +"=";
tmpObject.OWNERFULLNAME = (System.String)dr["OwnerFullName"];
msgRecField=msgRecField + "OwnerCodeTo=";
msgRecField=msgRecField + dr["OwnerCodeTo"].ToString() +"=";
tmpObject.OWNERCODETO = (System.String)dr["OwnerCodeTo"];
msgRecField=msgRecField + "OwnerNameTo=";
msgRecField=msgRecField + dr["OwnerNameTo"].ToString() +"=";
tmpObject.OWNERNAMETO = (System.String)dr["OwnerNameTo"];
msgRecField=msgRecField + "NotaryName=";
msgRecField=msgRecField + dr["NotaryName"].ToString() +"=";
tmpObject.NOTARYNAME = (System.String)dr["NotaryName"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
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
public List<aqu_all> GetAllByCond(string cond)
{
List<aqu_all> tmpList = new List<aqu_all>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From aqu_all Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
aqu_all tmpObject = new aqu_all();
msgRecField="-";
msgRecField=msgRecField + "idRecAquisition=";
msgRecField=msgRecField + dr["idRecAquisition"].ToString() +"=";
tmpObject.IDRECAQUISITION = (System.Int32)dr["idRecAquisition"];
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
msgRecField=msgRecField + "OwnerCode=";
msgRecField=msgRecField + dr["OwnerCode"].ToString() +"=";
tmpObject.OWNERCODE = (System.String)dr["OwnerCode"];
msgRecField=msgRecField + "OwnerFullName=";
msgRecField=msgRecField + dr["OwnerFullName"].ToString() +"=";
tmpObject.OWNERFULLNAME = (System.String)dr["OwnerFullName"];
msgRecField=msgRecField + "OwnerCodeTo=";
msgRecField=msgRecField + dr["OwnerCodeTo"].ToString() +"=";
tmpObject.OWNERCODETO = (System.String)dr["OwnerCodeTo"];
msgRecField=msgRecField + "OwnerNameTo=";
msgRecField=msgRecField + dr["OwnerNameTo"].ToString() +"=";
tmpObject.OWNERNAMETO = (System.String)dr["OwnerNameTo"];
msgRecField=msgRecField + "NotaryName=";
msgRecField=msgRecField + dr["NotaryName"].ToString() +"=";
tmpObject.NOTARYNAME = (System.String)dr["NotaryName"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
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
 
