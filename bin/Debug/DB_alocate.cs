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
 
public class DB_alocate
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_alocate()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(alocate _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(alocate _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO alocate (idInvoice,idPayment,Amount,Active,idCompany) VALUES (@idInvoice,@idPayment,@Amount,@Active,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idInvoice", _tmpObject.IDINVOICE));
command.Parameters.Add(new SqlParameter("@idPayment", _tmpObject.IDPAYMENT));
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
 
public int Update(alocate _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(alocate _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE alocate SET idInvoice=@idinvoice,idPayment=@idpayment,Amount=@amount,Active=@active,idCompany=@idcompany  WHERE idRecAlocate=@idrecalocate", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idinvoice", _tmpObject.IDINVOICE));
command.Parameters.Add(new SqlParameter("@idpayment", _tmpObject.IDPAYMENT));
command.Parameters.Add(new SqlParameter("@amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
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
 
public int Delete(alocate _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(alocate _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE alocate  WHERE idRecAlocate=@idrecalocate", conn);
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
public alocate GetById(int _id)
{
alocate tmpObject = new alocate();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From alocate WHERE idRecAlocate=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECALOCATE = (System.Int32)dr["idRecAlocate"];
tmpObject.IDINVOICE = (System.Int32)dr["idInvoice"];
tmpObject.IDPAYMENT = (System.Int32)dr["idPayment"];
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
public List<alocate> GetAll()
{
List<alocate> tmpList = new List<alocate>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From alocate", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
alocate tmpObject = new alocate();
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
public List<alocate> GetAllByCond(string cond)
{
List<alocate> tmpList = new List<alocate>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From alocate Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
alocate tmpObject = new alocate();
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
 
