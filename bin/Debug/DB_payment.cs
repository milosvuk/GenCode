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
 
public class DB_payment
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_payment()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(payment _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(payment _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO payment (idProperty,idCustomer,DateOfPayment,Description1,Description2,AmountPaid,AmountAlocated,Active,idCompany) VALUES (@idProperty,@idCustomer,@DateOfPayment,@Description1,@Description2,@AmountPaid,@AmountAlocated,@Active,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idCustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@DateOfPayment", _tmpObject.DATEOFPAYMENT));
command.Parameters.Add(new SqlParameter("@Description1", _tmpObject.DESCRIPTION1));
command.Parameters.Add(new SqlParameter("@Description2", _tmpObject.DESCRIPTION2));
command.Parameters.Add(new SqlParameter("@AmountPaid", _tmpObject.AMOUNTPAID));
command.Parameters.Add(new SqlParameter("@AmountAlocated", _tmpObject.AMOUNTALOCATED));
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
 
public int Update(payment _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(payment _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE payment SET idProperty=@idproperty,idCustomer=@idcustomer,DateOfPayment=@dateofpayment,Description1=@description1,Description2=@description2,AmountPaid=@amountpaid,AmountAlocated=@amountalocated,Active=@active,idCompany=@idcompany  WHERE idRecPayment=@idrecpayment", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@dateofpayment", _tmpObject.DATEOFPAYMENT));
command.Parameters.Add(new SqlParameter("@description1", _tmpObject.DESCRIPTION1));
command.Parameters.Add(new SqlParameter("@description2", _tmpObject.DESCRIPTION2));
command.Parameters.Add(new SqlParameter("@amountpaid", _tmpObject.AMOUNTPAID));
command.Parameters.Add(new SqlParameter("@amountalocated", _tmpObject.AMOUNTALOCATED));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idrecpayment", _tmpObject.IDRECPAYMENT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(payment _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(payment _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE payment  WHERE idRecPayment=@idrecpayment", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecpayment", _tmpObject.IDRECPAYMENT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public payment GetById(int _id)
{
payment tmpObject = new payment();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From payment WHERE idRecPayment=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECPAYMENT = (System.Int32)dr["idRecPayment"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
tmpObject.DATEOFPAYMENT = (System.DateTime)dr["DateOfPayment"];
tmpObject.DESCRIPTION1 = (System.String)dr["Description1"];
tmpObject.DESCRIPTION2 = (System.String)dr["Description2"];
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
tmpObject.AMOUNTALOCATED = (System.Decimal)dr["AmountAlocated"];
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
public List<payment> GetAll()
{
List<payment> tmpList = new List<payment>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From payment", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
payment tmpObject = new payment();
msgRecField="-";
msgRecField=msgRecField + "idRecPayment=";
msgRecField=msgRecField + dr["idRecPayment"].ToString() +"=";
tmpObject.IDRECPAYMENT = (System.Int32)dr["idRecPayment"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "DateOfPayment=";
msgRecField=msgRecField + dr["DateOfPayment"].ToString() +"=";
tmpObject.DATEOFPAYMENT = (System.DateTime)dr["DateOfPayment"];
msgRecField=msgRecField + "Description1=";
msgRecField=msgRecField + dr["Description1"].ToString() +"=";
tmpObject.DESCRIPTION1 = (System.String)dr["Description1"];
msgRecField=msgRecField + "Description2=";
msgRecField=msgRecField + dr["Description2"].ToString() +"=";
tmpObject.DESCRIPTION2 = (System.String)dr["Description2"];
msgRecField=msgRecField + "AmountPaid=";
msgRecField=msgRecField + dr["AmountPaid"].ToString() +"=";
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
msgRecField=msgRecField + "AmountAlocated=";
msgRecField=msgRecField + dr["AmountAlocated"].ToString() +"=";
tmpObject.AMOUNTALOCATED = (System.Decimal)dr["AmountAlocated"];
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
public List<payment> GetAllByCond(string cond)
{
List<payment> tmpList = new List<payment>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From payment Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
payment tmpObject = new payment();
msgRecField="-";
msgRecField=msgRecField + "idRecPayment=";
msgRecField=msgRecField + dr["idRecPayment"].ToString() +"=";
tmpObject.IDRECPAYMENT = (System.Int32)dr["idRecPayment"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "DateOfPayment=";
msgRecField=msgRecField + dr["DateOfPayment"].ToString() +"=";
tmpObject.DATEOFPAYMENT = (System.DateTime)dr["DateOfPayment"];
msgRecField=msgRecField + "Description1=";
msgRecField=msgRecField + dr["Description1"].ToString() +"=";
tmpObject.DESCRIPTION1 = (System.String)dr["Description1"];
msgRecField=msgRecField + "Description2=";
msgRecField=msgRecField + dr["Description2"].ToString() +"=";
tmpObject.DESCRIPTION2 = (System.String)dr["Description2"];
msgRecField=msgRecField + "AmountPaid=";
msgRecField=msgRecField + dr["AmountPaid"].ToString() +"=";
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
msgRecField=msgRecField + "AmountAlocated=";
msgRecField=msgRecField + dr["AmountAlocated"].ToString() +"=";
tmpObject.AMOUNTALOCATED = (System.Decimal)dr["AmountAlocated"];
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
 
