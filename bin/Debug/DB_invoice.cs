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
 
public class DB_invoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_invoice()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(invoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(invoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO invoice (idProperty,idCustomer,DateOfInv,idExpense,Amount,TaxPerc,TaxAmount,TotalAmount,AmountPaid,Finalized,Description,id_propertycustomerdetails,Active,idCompany) VALUES (@idProperty,@idCustomer,@DateOfInv,@idExpense,@Amount,@TaxPerc,@TaxAmount,@TotalAmount,@AmountPaid,@Finalized,@Description,@id_propertycustomerdetails,@Active,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idCustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@DateOfInv", _tmpObject.DATEOFINV));
command.Parameters.Add(new SqlParameter("@idExpense", _tmpObject.IDEXPENSE));
command.Parameters.Add(new SqlParameter("@Amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@TaxPerc", _tmpObject.TAXPERC));
command.Parameters.Add(new SqlParameter("@TaxAmount", _tmpObject.TAXAMOUNT));
command.Parameters.Add(new SqlParameter("@TotalAmount", _tmpObject.TOTALAMOUNT));
command.Parameters.Add(new SqlParameter("@AmountPaid", _tmpObject.AMOUNTPAID));
command.Parameters.Add(new SqlParameter("@Finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_propertycustomerdetails", _tmpObject.ID_PROPERTYCUSTOMERDETAILS));
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
 
public int Update(invoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(invoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE invoice SET idProperty=@idproperty,idCustomer=@idcustomer,DateOfInv=@dateofinv,idExpense=@idexpense,Amount=@amount,TaxPerc=@taxperc,TaxAmount=@taxamount,TotalAmount=@totalamount,AmountPaid=@amountpaid,Finalized=@finalized,Description=@description,id_propertycustomerdetails=@id_propertycustomerdetails,Active=@active,idCompany=@idcompany  WHERE idRecInv=@idrecinv", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@dateofinv", _tmpObject.DATEOFINV));
command.Parameters.Add(new SqlParameter("@idexpense", _tmpObject.IDEXPENSE));
command.Parameters.Add(new SqlParameter("@amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@taxperc", _tmpObject.TAXPERC));
command.Parameters.Add(new SqlParameter("@taxamount", _tmpObject.TAXAMOUNT));
command.Parameters.Add(new SqlParameter("@totalamount", _tmpObject.TOTALAMOUNT));
command.Parameters.Add(new SqlParameter("@amountpaid", _tmpObject.AMOUNTPAID));
command.Parameters.Add(new SqlParameter("@finalized", _tmpObject.FINALIZED));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_propertycustomerdetails", _tmpObject.ID_PROPERTYCUSTOMERDETAILS));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idrecinv", _tmpObject.IDRECINV));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(invoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(invoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE invoice  WHERE idRecInv=@idrecinv", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecinv", _tmpObject.IDRECINV));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public invoice GetById(int _id)
{
invoice tmpObject = new invoice();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From invoice WHERE idRecInv=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECINV = (System.Int32)dr["idRecInv"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
tmpObject.DATEOFINV = (System.DateTime)dr["DateOfInv"];
tmpObject.IDEXPENSE = (System.Int32)dr["idExpense"];
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
tmpObject.TAXPERC = (System.Decimal)dr["TaxPerc"];
tmpObject.TAXAMOUNT = (System.Decimal)dr["TaxAmount"];
tmpObject.TOTALAMOUNT = (System.Decimal)dr["TotalAmount"];
tmpObject.AMOUNTPAID = (System.Decimal)dr["AmountPaid"];
tmpObject.FINALIZED = (System.Int32)dr["Finalized"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
tmpObject.ID_PROPERTYCUSTOMERDETAILS = (System.Int32)dr["id_propertycustomerdetails"];
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
public List<invoice> GetAll()
{
List<invoice> tmpList = new List<invoice>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From invoice", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
invoice tmpObject = new invoice();
msgRecField="-";
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
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
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
msgRecField=msgRecField + "id_propertycustomerdetails=";
msgRecField=msgRecField + dr["id_propertycustomerdetails"].ToString() +"=";
tmpObject.ID_PROPERTYCUSTOMERDETAILS = (System.Int32)dr["id_propertycustomerdetails"];
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
public List<invoice> GetAllByCond(string cond)
{
List<invoice> tmpList = new List<invoice>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From invoice Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
invoice tmpObject = new invoice();
msgRecField="-";
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
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
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
msgRecField=msgRecField + "id_propertycustomerdetails=";
msgRecField=msgRecField + dr["id_propertycustomerdetails"].ToString() +"=";
tmpObject.ID_PROPERTYCUSTOMERDETAILS = (System.Int32)dr["id_propertycustomerdetails"];
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
 
