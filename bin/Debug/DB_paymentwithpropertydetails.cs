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
 
public class DB_paymentwithpropertydetails
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_paymentwithpropertydetails()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(paymentwithpropertydetails _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(paymentwithpropertydetails _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO paymentwithpropertydetails (idProperty,idCustomer,DateOfPayment,Description1,Description2,AmountPaid,AmountAlocated,Active,idCompany,CodeOfProperty,Description,FDescription,Address1,Address2,Address3) VALUES (@idProperty,@idCustomer,@DateOfPayment,@Description1,@Description2,@AmountPaid,@AmountAlocated,@Active,@idCompany,@CodeOfProperty,@Description,@FDescription,@Address1,@Address2,@Address3) SET @tmpid = SCOPE_IDENTITY()", conn);
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
command.Parameters.Add(new SqlParameter("@CodeOfProperty", _tmpObject.CODEOFPROPERTY));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@FDescription", _tmpObject.FDESCRIPTION));
command.Parameters.Add(new SqlParameter("@Address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@Address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@Address3", _tmpObject.ADDRESS3));
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
 
public int Update(paymentwithpropertydetails _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(paymentwithpropertydetails _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE paymentwithpropertydetails SET idProperty=@idproperty,idCustomer=@idcustomer,DateOfPayment=@dateofpayment,Description1=@description1,Description2=@description2,AmountPaid=@amountpaid,AmountAlocated=@amountalocated,Active=@active,idCompany=@idcompany,CodeOfProperty=@codeofproperty,Description=@description,FDescription=@fdescription,Address1=@address1,Address2=@address2,Address3=@address3  WHERE idRecPayment=@idrecpayment", conn);
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
command.Parameters.Add(new SqlParameter("@codeofproperty", _tmpObject.CODEOFPROPERTY));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@fdescription", _tmpObject.FDESCRIPTION));
command.Parameters.Add(new SqlParameter("@address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@address3", _tmpObject.ADDRESS3));
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
 
public int Delete(paymentwithpropertydetails _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(paymentwithpropertydetails _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM paymentwithpropertydetails  WHERE idRecPayment=@idrecpayment", conn);
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
public paymentwithpropertydetails GetById(int _id)
{
paymentwithpropertydetails tmpObject = new paymentwithpropertydetails();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From paymentwithpropertydetails WHERE idRecPayment=" + _id.ToString(), conn);
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
tmpObject.CODEOFPROPERTY = (System.String)dr["CodeOfProperty"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
tmpObject.FDESCRIPTION = (System.String)dr["FDescription"];
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
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
public List<paymentwithpropertydetails> GetAll()
{
List<paymentwithpropertydetails> tmpList = new List<paymentwithpropertydetails>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From paymentwithpropertydetails", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
paymentwithpropertydetails tmpObject = new paymentwithpropertydetails();
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
msgRecField=msgRecField + "CodeOfProperty=";
msgRecField=msgRecField + dr["CodeOfProperty"].ToString() +"=";
tmpObject.CODEOFPROPERTY = (System.String)dr["CodeOfProperty"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "FDescription=";
msgRecField=msgRecField + dr["FDescription"].ToString() +"=";
tmpObject.FDESCRIPTION = (System.String)dr["FDescription"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address3=";
msgRecField=msgRecField + dr["Address3"].ToString() +"=";
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
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
public List<paymentwithpropertydetails> GetAllByCond(string cond)
{
List<paymentwithpropertydetails> tmpList = new List<paymentwithpropertydetails>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From paymentwithpropertydetails Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
paymentwithpropertydetails tmpObject = new paymentwithpropertydetails();
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
msgRecField=msgRecField + "CodeOfProperty=";
msgRecField=msgRecField + dr["CodeOfProperty"].ToString() +"=";
tmpObject.CODEOFPROPERTY = (System.String)dr["CodeOfProperty"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "FDescription=";
msgRecField=msgRecField + dr["FDescription"].ToString() +"=";
tmpObject.FDESCRIPTION = (System.String)dr["FDescription"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address3=";
msgRecField=msgRecField + dr["Address3"].ToString() +"=";
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
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
 
