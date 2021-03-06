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
 
public class DB_capitalexpand
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_capitalexpand()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(capitalexpand _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(capitalexpand _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO capitalexpand (idProperty,IdExpense,DateOfCap,Details,Amount,Active,idCompany) VALUES (@idProperty,@IdExpense,@DateOfCap,@Details,@Amount,@Active,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@IdExpense", _tmpObject.IDEXPENSE));
command.Parameters.Add(new SqlParameter("@DateOfCap", _tmpObject.DATEOFCAP));
command.Parameters.Add(new SqlParameter("@Details", _tmpObject.DETAILS));
command.Parameters.Add(new SqlParameter("@Amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
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
 
public int Update(capitalexpand _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(capitalexpand _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE capitalexpand SET idProperty=@idproperty,IdExpense=@idexpense,DateOfCap=@dateofcap,Details=@details,Amount=@amount,Active=@active,idCompany=@idcompany  WHERE idCapitalExp=@idcapitalexp", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idexpense", _tmpObject.IDEXPENSE));
command.Parameters.Add(new SqlParameter("@dateofcap", _tmpObject.DATEOFCAP));
command.Parameters.Add(new SqlParameter("@details", _tmpObject.DETAILS));
command.Parameters.Add(new SqlParameter("@amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idcapitalexp", _tmpObject.IDCAPITALEXP));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(capitalexpand _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(capitalexpand _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE capitalexpand  WHERE idCapitalExp=@idcapitalexp", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idcapitalexp", _tmpObject.IDCAPITALEXP));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public capitalexpand GetById(int _id)
{
capitalexpand tmpObject = new capitalexpand();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From capitalexpand WHERE idCapitalExp=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDCAPITALEXP = (System.Int32)dr["idCapitalExp"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.IDEXPENSE = (System.Int32)dr["IdExpense"];
tmpObject.DATEOFCAP = (System.DateTime)dr["DateOfCap"];
tmpObject.DETAILS = (System.String)dr["Details"];
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
public List<capitalexpand> GetAll()
{
List<capitalexpand> tmpList = new List<capitalexpand>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From capitalexpand", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
capitalexpand tmpObject = new capitalexpand();
msgRecField="-";
msgRecField=msgRecField + "idCapitalExp=";
msgRecField=msgRecField + dr["idCapitalExp"].ToString() +"=";
tmpObject.IDCAPITALEXP = (System.Int32)dr["idCapitalExp"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "IdExpense=";
msgRecField=msgRecField + dr["IdExpense"].ToString() +"=";
tmpObject.IDEXPENSE = (System.Int32)dr["IdExpense"];
msgRecField=msgRecField + "DateOfCap=";
msgRecField=msgRecField + dr["DateOfCap"].ToString() +"=";
tmpObject.DATEOFCAP = (System.DateTime)dr["DateOfCap"];
msgRecField=msgRecField + "Details=";
msgRecField=msgRecField + dr["Details"].ToString() +"=";
tmpObject.DETAILS = (System.String)dr["Details"];
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
public List<capitalexpand> GetAllByCond(string cond)
{
List<capitalexpand> tmpList = new List<capitalexpand>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From capitalexpand Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
capitalexpand tmpObject = new capitalexpand();
msgRecField="-";
msgRecField=msgRecField + "idCapitalExp=";
msgRecField=msgRecField + dr["idCapitalExp"].ToString() +"=";
tmpObject.IDCAPITALEXP = (System.Int32)dr["idCapitalExp"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "IdExpense=";
msgRecField=msgRecField + dr["IdExpense"].ToString() +"=";
tmpObject.IDEXPENSE = (System.Int32)dr["IdExpense"];
msgRecField=msgRecField + "DateOfCap=";
msgRecField=msgRecField + dr["DateOfCap"].ToString() +"=";
tmpObject.DATEOFCAP = (System.DateTime)dr["DateOfCap"];
msgRecField=msgRecField + "Details=";
msgRecField=msgRecField + dr["Details"].ToString() +"=";
tmpObject.DETAILS = (System.String)dr["Details"];
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
 
