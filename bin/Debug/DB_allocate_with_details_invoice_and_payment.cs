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
 
public class DB_allocate_with_details_invoice_and_payment
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_allocate_with_details_invoice_and_payment()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(allocate_with_details_invoice_and_payment _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(allocate_with_details_invoice_and_payment _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO allocate_with_details_invoice_and_payment (idInvoice,idPayment,Amount,idRecInv,idProperty,idCustomer,DateOfInv,idExpense,TaxPerc,TaxAmount,TotalAmount,AmountPaid,Finalized,Description,DateOfPayment,Description1,Description2,PaymentAmount,AmountAlocated) VALUES (@idInvoice,@idPayment,@Amount,@idRecInv,@idProperty,@idCustomer,@DateOfInv,@idExpense,@TaxPerc,@TaxAmount,@TotalAmount,@AmountPaid,@Finalized,@Description,@DateOfPayment,@Description1,@Description2,@PaymentAmount,@AmountAlocated) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idInvoice", _tmpObject.IDINVOICE));
command.Parameters.Add(new SqlParameter("@idPayment", _tmpObject.IDPAYMENT));
command.Parameters.Add(new SqlParameter("@Amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@idRecInv", _tmpObject.IDRECINV));
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idCustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@DateOfInv", _tmpObject.DATEOFINV));
command.Parameters.Add(new SqlParameter("@idExpense", _tmpObject.IDEXPENSE));
command.Parameters.Add(new SqlParameter("@TaxPerc", _tmpObject.TAXPERC));
command.Parameters.Add(new SqlParameter("@TaxAmount", _tmpObject.TAXAMOUNT));
command.Parameters.Add(new SqlParameter("@TotalAmount", _tmpObject.TOTALAMOUNT));
command.Parameters.Add(new SqlParameter("@AmountPaid", _tmpObject.AMOUNTPAID));
command.Parameters.Add(new SqlParameter("@Finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@DateOfPayment", _tmpObject.DATEOFPAYMENT));
command.Parameters.Add(new SqlParameter("@Description1", _tmpObject.DESCRIPTION1));
command.Parameters.Add(new SqlParameter("@Description2", _tmpObject.DESCRIPTION2));
command.Parameters.Add(new SqlParameter("@PaymentAmount", _tmpObject.PAYMENTAMOUNT));
command.Parameters.Add(new SqlParameter("@AmountAlocated", _tmpObject.AMOUNTALOCATED));
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
 
public int Update(allocate_with_details_invoice_and_payment _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(allocate_with_details_invoice_and_payment _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE allocate_with_details_invoice_and_payment SET idInvoice=@idinvoice,idPayment=@idpayment,Amount=@amount,idRecInv=@idrecinv,idProperty=@idproperty,idCustomer=@idcustomer,DateOfInv=@dateofinv,idExpense=@idexpense,TaxPerc=@taxperc,TaxAmount=@taxamount,TotalAmount=@totalamount,AmountPaid=@amountpaid,Finalized=@finalized,Description=@description,DateOfPayment=@dateofpayment,Description1=@description1,Description2=@description2,PaymentAmount=@paymentamount,AmountAlocated=@amountalocated  WHERE idRecAlocate=@idrecalocate", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idinvoice", _tmpObject.IDINVOICE));
command.Parameters.Add(new SqlParameter("@idpayment", _tmpObject.IDPAYMENT));
command.Parameters.Add(new SqlParameter("@amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@idrecinv", _tmpObject.IDRECINV));
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@dateofinv", _tmpObject.DATEOFINV));
command.Parameters.Add(new SqlParameter("@idexpense", _tmpObject.IDEXPENSE));
command.Parameters.Add(new SqlParameter("@taxperc", _tmpObject.TAXPERC));
command.Parameters.Add(new SqlParameter("@taxamount", _tmpObject.TAXAMOUNT));
command.Parameters.Add(new SqlParameter("@totalamount", _tmpObject.TOTALAMOUNT));
command.Parameters.Add(new SqlParameter("@amountpaid", _tmpObject.AMOUNTPAID));
command.Parameters.Add(new SqlParameter("@finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@dateofpayment", _tmpObject.DATEOFPAYMENT));
command.Parameters.Add(new SqlParameter("@description1", _tmpObject.DESCRIPTION1));
command.Parameters.Add(new SqlParameter("@description2", _tmpObject.DESCRIPTION2));
command.Parameters.Add(new SqlParameter("@paymentamount", _tmpObject.PAYMENTAMOUNT));
command.Parameters.Add(new SqlParameter("@amountalocated", _tmpObject.AMOUNTALOCATED));
command.Parameters.Add(new SqlParameter("@idrecalocate", _tmpObject.IDRECALOCATE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(allocate_with_details_invoice_and_payment _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(allocate_with_details_invoice_and_payment _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE allocate_with_details_invoice_and_payment  WHERE idRecAlocate=@idrecalocate", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecalocate", _tmpObject.IDRECALOCATE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public allocate_with_details_invoice_and_payment GetById(int _id)
{
allocate_with_details_invoice_and_payment tmpObject = new allocate_with_details_invoice_and_payment();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From allocate_with_details_invoice_and_payment WHERE idRecAlocate=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECALOCATE = (System.Int32)dr["idRecAlocate"];
tmpObject.IDINVOICE = (System.Int32)dr["idInvoice"];
tmpObject.IDPAYMENT = (System.Int32)dr["idPayment"];
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
tmpObject.IDRECINV = (System.Int32)dr["idRecInv"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
tmpObject.DATEOFINV = (System.DateTime)dr["DateOfInv"];
tmpObject.IDEXPENSE = (System.Int32)dr["idExpense"];
tmpObject.TAXPERC = (System.Decimal)dr["TaxPerc"];
tmpObject.TAXAMOUNT = (System.Decimal)dr["TaxAmount"];
tmpObject.TOTALAMOUNT = (System.Decimal)dr["TotalAmount"];
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
tmpObject.FINALIZED = (System.Int32)dr["Finalized"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
tmpObject.DATEOFPAYMENT = (System.DateTime)dr["DateOfPayment"];
tmpObject.DESCRIPTION1 = (System.String)dr["Description1"];
tmpObject.DESCRIPTION2 = (System.String)dr["Description2"];
tmpObject.PAYMENTAMOUNT = (System.Decimal)dr["PaymentAmount"];
tmpObject.AMOUNTALOCATED = (System.Decimal)dr["AmountAlocated"];
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
public List<allocate_with_details_invoice_and_payment> GetAll()
{
List<allocate_with_details_invoice_and_payment> tmpList = new List<allocate_with_details_invoice_and_payment>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From allocate_with_details_invoice_and_payment", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
allocate_with_details_invoice_and_payment tmpObject = new allocate_with_details_invoice_and_payment();
msgRecField="-";
msgRecField=msgRecField + "idRecAlocate=";
msgRecField=msgRecField + dr["idRecAlocate"].ToString() +"=";
tmpObject.IDRECALOCATE = (System.Int32)dr["idRecAlocate"];
msgRecField=msgRecField + "idInvoice=";
msgRecField=msgRecField + dr["idInvoice"].ToString() +"=";
tmpObject.IDINVOICE = (System.Int32)dr["idInvoice"];
msgRecField=msgRecField + "idPayment=";
msgRecField=msgRecField + dr["idPayment"].ToString() +"=";
tmpObject.IDPAYMENT = (System.Int32)dr["idPayment"];
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
msgRecField=msgRecField + "idRecInv=";
msgRecField=msgRecField + dr["idRecInv"].ToString() +"=";
tmpObject.IDRECINV = (System.Int32)dr["idRecInv"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "DateOfInv=";
msgRecField=msgRecField + dr["DateOfInv"].ToString() +"=";
tmpObject.DATEOFINV = (System.DateTime)dr["DateOfInv"];
msgRecField=msgRecField + "idExpense=";
msgRecField=msgRecField + dr["idExpense"].ToString() +"=";
tmpObject.IDEXPENSE = (System.Int32)dr["idExpense"];
msgRecField=msgRecField + "TaxPerc=";
msgRecField=msgRecField + dr["TaxPerc"].ToString() +"=";
tmpObject.TAXPERC = (System.Decimal)dr["TaxPerc"];
msgRecField=msgRecField + "TaxAmount=";
msgRecField=msgRecField + dr["TaxAmount"].ToString() +"=";
tmpObject.TAXAMOUNT = (System.Decimal)dr["TaxAmount"];
msgRecField=msgRecField + "TotalAmount=";
msgRecField=msgRecField + dr["TotalAmount"].ToString() +"=";
tmpObject.TOTALAMOUNT = (System.Decimal)dr["TotalAmount"];
msgRecField=msgRecField + "AmountPaid=";
msgRecField=msgRecField + dr["AmountPaid"].ToString() +"=";
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
msgRecField=msgRecField + "Finalized=";
msgRecField=msgRecField + dr["Finalized"].ToString() +"=";
tmpObject.FINALIZED = (System.Int32)dr["Finalized"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "DateOfPayment=";
msgRecField=msgRecField + dr["DateOfPayment"].ToString() +"=";
tmpObject.DATEOFPAYMENT = (System.DateTime)dr["DateOfPayment"];
msgRecField=msgRecField + "Description1=";
msgRecField=msgRecField + dr["Description1"].ToString() +"=";
tmpObject.DESCRIPTION1 = (System.String)dr["Description1"];
msgRecField=msgRecField + "Description2=";
msgRecField=msgRecField + dr["Description2"].ToString() +"=";
tmpObject.DESCRIPTION2 = (System.String)dr["Description2"];
msgRecField=msgRecField + "PaymentAmount=";
msgRecField=msgRecField + dr["PaymentAmount"].ToString() +"=";
tmpObject.PAYMENTAMOUNT = (System.Decimal)dr["PaymentAmount"];
msgRecField=msgRecField + "AmountAlocated=";
msgRecField=msgRecField + dr["AmountAlocated"].ToString() +"=";
tmpObject.AMOUNTALOCATED = (System.Decimal)dr["AmountAlocated"];
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
public List<allocate_with_details_invoice_and_payment> GetAllByCond(string cond)
{
List<allocate_with_details_invoice_and_payment> tmpList = new List<allocate_with_details_invoice_and_payment>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From allocate_with_details_invoice_and_payment Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
allocate_with_details_invoice_and_payment tmpObject = new allocate_with_details_invoice_and_payment();
msgRecField="-";
msgRecField=msgRecField + "idRecAlocate=";
msgRecField=msgRecField + dr["idRecAlocate"].ToString() +"=";
tmpObject.IDRECALOCATE = (System.Int32)dr["idRecAlocate"];
msgRecField=msgRecField + "idInvoice=";
msgRecField=msgRecField + dr["idInvoice"].ToString() +"=";
tmpObject.IDINVOICE = (System.Int32)dr["idInvoice"];
msgRecField=msgRecField + "idPayment=";
msgRecField=msgRecField + dr["idPayment"].ToString() +"=";
tmpObject.IDPAYMENT = (System.Int32)dr["idPayment"];
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
msgRecField=msgRecField + "idRecInv=";
msgRecField=msgRecField + dr["idRecInv"].ToString() +"=";
tmpObject.IDRECINV = (System.Int32)dr["idRecInv"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "DateOfInv=";
msgRecField=msgRecField + dr["DateOfInv"].ToString() +"=";
tmpObject.DATEOFINV = (System.DateTime)dr["DateOfInv"];
msgRecField=msgRecField + "idExpense=";
msgRecField=msgRecField + dr["idExpense"].ToString() +"=";
tmpObject.IDEXPENSE = (System.Int32)dr["idExpense"];
msgRecField=msgRecField + "TaxPerc=";
msgRecField=msgRecField + dr["TaxPerc"].ToString() +"=";
tmpObject.TAXPERC = (System.Decimal)dr["TaxPerc"];
msgRecField=msgRecField + "TaxAmount=";
msgRecField=msgRecField + dr["TaxAmount"].ToString() +"=";
tmpObject.TAXAMOUNT = (System.Decimal)dr["TaxAmount"];
msgRecField=msgRecField + "TotalAmount=";
msgRecField=msgRecField + dr["TotalAmount"].ToString() +"=";
tmpObject.TOTALAMOUNT = (System.Decimal)dr["TotalAmount"];
msgRecField=msgRecField + "AmountPaid=";
msgRecField=msgRecField + dr["AmountPaid"].ToString() +"=";
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
msgRecField=msgRecField + "Finalized=";
msgRecField=msgRecField + dr["Finalized"].ToString() +"=";
tmpObject.FINALIZED = (System.Int32)dr["Finalized"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "DateOfPayment=";
msgRecField=msgRecField + dr["DateOfPayment"].ToString() +"=";
tmpObject.DATEOFPAYMENT = (System.DateTime)dr["DateOfPayment"];
msgRecField=msgRecField + "Description1=";
msgRecField=msgRecField + dr["Description1"].ToString() +"=";
tmpObject.DESCRIPTION1 = (System.String)dr["Description1"];
msgRecField=msgRecField + "Description2=";
msgRecField=msgRecField + dr["Description2"].ToString() +"=";
tmpObject.DESCRIPTION2 = (System.String)dr["Description2"];
msgRecField=msgRecField + "PaymentAmount=";
msgRecField=msgRecField + dr["PaymentAmount"].ToString() +"=";
tmpObject.PAYMENTAMOUNT = (System.Decimal)dr["PaymentAmount"];
msgRecField=msgRecField + "AmountAlocated=";
msgRecField=msgRecField + dr["AmountAlocated"].ToString() +"=";
tmpObject.AMOUNTALOCATED = (System.Decimal)dr["AmountAlocated"];
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
 
