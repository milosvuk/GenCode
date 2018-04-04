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
 
public class DB_customer
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_customer()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(customer _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(customer _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO customer (customerid,customersid,nameOfCustomer,surnameOfCustomer,addressOfCustomer,cityofCustomer,countryOfCustomer,id_company) VALUES (@customerid,@customersid,@nameOfCustomer,@surnameOfCustomer,@addressOfCustomer,@cityofCustomer,@countryOfCustomer,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@customerid", _tmpObject.CUSTOMERID));
command.Parameters.Add(new SqlParameter("@customersid", _tmpObject.CUSTOMERSID));
command.Parameters.Add(new SqlParameter("@nameOfCustomer", _tmpObject.NAMEOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@surnameOfCustomer", _tmpObject.SURNAMEOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@addressOfCustomer", _tmpObject.ADDRESSOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@cityofCustomer", _tmpObject.CITYOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@countryOfCustomer", _tmpObject.COUNTRYOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
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
 
public int Update(customer _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(customer _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE customer SET customerid=@customerid,customersid=@customersid,nameOfCustomer=@nameofcustomer,surnameOfCustomer=@surnameofcustomer,addressOfCustomer=@addressofcustomer,cityofCustomer=@cityofcustomer,countryOfCustomer=@countryofcustomer,id_company=@id_company  WHERE idcustomer=@idcustomer", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@customerid", _tmpObject.CUSTOMERID));
command.Parameters.Add(new SqlParameter("@customersid", _tmpObject.CUSTOMERSID));
command.Parameters.Add(new SqlParameter("@nameofcustomer", _tmpObject.NAMEOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@surnameofcustomer", _tmpObject.SURNAMEOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@addressofcustomer", _tmpObject.ADDRESSOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@cityofcustomer", _tmpObject.CITYOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@countryofcustomer", _tmpObject.COUNTRYOFCUSTOMER));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(customer _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(customer _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE customer  WHERE idcustomer=@idcustomer", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public customer GetById(int _id)
{
customer tmpObject = new customer();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From customer WHERE idcustomer=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDCUSTOMER = (System.Int32)dr["idcustomer"];
tmpObject.CUSTOMERID = (System.String)dr["customerid"];
tmpObject.CUSTOMERSID = (System.String)dr["customersid"];
tmpObject.NAMEOFCUSTOMER = (System.String)dr["nameOfCustomer"];
tmpObject.SURNAMEOFCUSTOMER = (System.String)dr["surnameOfCustomer"];
tmpObject.ADDRESSOFCUSTOMER = (System.String)dr["addressOfCustomer"];
tmpObject.CITYOFCUSTOMER = (System.String)dr["cityofCustomer"];
tmpObject.COUNTRYOFCUSTOMER = (System.String)dr["countryOfCustomer"];
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
public List<customer> GetAll()
{
List<customer> tmpList = new List<customer>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From customer", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
customer tmpObject = new customer();
msgRecField="-";
msgRecField=msgRecField + "idcustomer=";
msgRecField=msgRecField + dr["idcustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idcustomer"];
msgRecField=msgRecField + "customerid=";
msgRecField=msgRecField + dr["customerid"].ToString() +"=";
tmpObject.CUSTOMERID = (System.String)dr["customerid"];
msgRecField=msgRecField + "customersid=";
msgRecField=msgRecField + dr["customersid"].ToString() +"=";
tmpObject.CUSTOMERSID = (System.String)dr["customersid"];
msgRecField=msgRecField + "nameOfCustomer=";
msgRecField=msgRecField + dr["nameOfCustomer"].ToString() +"=";
tmpObject.NAMEOFCUSTOMER = (System.String)dr["nameOfCustomer"];
msgRecField=msgRecField + "surnameOfCustomer=";
msgRecField=msgRecField + dr["surnameOfCustomer"].ToString() +"=";
tmpObject.SURNAMEOFCUSTOMER = (System.String)dr["surnameOfCustomer"];
msgRecField=msgRecField + "addressOfCustomer=";
msgRecField=msgRecField + dr["addressOfCustomer"].ToString() +"=";
tmpObject.ADDRESSOFCUSTOMER = (System.String)dr["addressOfCustomer"];
msgRecField=msgRecField + "cityofCustomer=";
msgRecField=msgRecField + dr["cityofCustomer"].ToString() +"=";
tmpObject.CITYOFCUSTOMER = (System.String)dr["cityofCustomer"];
msgRecField=msgRecField + "countryOfCustomer=";
msgRecField=msgRecField + dr["countryOfCustomer"].ToString() +"=";
tmpObject.COUNTRYOFCUSTOMER = (System.String)dr["countryOfCustomer"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
public List<customer> GetAllByCond(string cond)
{
List<customer> tmpList = new List<customer>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From customer Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
customer tmpObject = new customer();
msgRecField="-";
msgRecField=msgRecField + "idcustomer=";
msgRecField=msgRecField + dr["idcustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idcustomer"];
msgRecField=msgRecField + "customerid=";
msgRecField=msgRecField + dr["customerid"].ToString() +"=";
tmpObject.CUSTOMERID = (System.String)dr["customerid"];
msgRecField=msgRecField + "customersid=";
msgRecField=msgRecField + dr["customersid"].ToString() +"=";
tmpObject.CUSTOMERSID = (System.String)dr["customersid"];
msgRecField=msgRecField + "nameOfCustomer=";
msgRecField=msgRecField + dr["nameOfCustomer"].ToString() +"=";
tmpObject.NAMEOFCUSTOMER = (System.String)dr["nameOfCustomer"];
msgRecField=msgRecField + "surnameOfCustomer=";
msgRecField=msgRecField + dr["surnameOfCustomer"].ToString() +"=";
tmpObject.SURNAMEOFCUSTOMER = (System.String)dr["surnameOfCustomer"];
msgRecField=msgRecField + "addressOfCustomer=";
msgRecField=msgRecField + dr["addressOfCustomer"].ToString() +"=";
tmpObject.ADDRESSOFCUSTOMER = (System.String)dr["addressOfCustomer"];
msgRecField=msgRecField + "cityofCustomer=";
msgRecField=msgRecField + dr["cityofCustomer"].ToString() +"=";
tmpObject.CITYOFCUSTOMER = (System.String)dr["cityofCustomer"];
msgRecField=msgRecField + "countryOfCustomer=";
msgRecField=msgRecField + dr["countryOfCustomer"].ToString() +"=";
tmpObject.COUNTRYOFCUSTOMER = (System.String)dr["countryOfCustomer"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
 
