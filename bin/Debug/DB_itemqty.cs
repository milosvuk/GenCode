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
 
public class DB_itemqty
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_itemqty()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(itemqty _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(itemqty _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO itemqty (id_item,id_store,qty,price,id_company) VALUES (@id_item,@id_store,@qty,@price,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_item", _tmpObject.ID_ITEM));
command.Parameters.Add(new SqlParameter("@id_store", _tmpObject.ID_STORE));
command.Parameters.Add(new SqlParameter("@qty", _tmpObject.QTY));
command.Parameters.Add(new SqlParameter("@price", _tmpObject.PRICE));
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
 
public int Update(itemqty _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(itemqty _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE itemqty SET id_item=@id_item,id_store=@id_store,qty=@qty,price=@price,id_company=@id_company  WHERE idqtystore=@idqtystore", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_item", _tmpObject.ID_ITEM));
command.Parameters.Add(new SqlParameter("@id_store", _tmpObject.ID_STORE));
command.Parameters.Add(new SqlParameter("@qty", _tmpObject.QTY));
command.Parameters.Add(new SqlParameter("@price", _tmpObject.PRICE));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idqtystore", _tmpObject.IDQTYSTORE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(itemqty _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(itemqty _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE itemqty  WHERE idqtystore=@idqtystore", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idqtystore", _tmpObject.IDQTYSTORE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public itemqty GetById(int _id)
{
itemqty tmpObject = new itemqty();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From itemqty WHERE idqtystore=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDQTYSTORE = (System.Int32)dr["idqtystore"];
tmpObject.ID_ITEM = (System.Int32)dr["id_item"];
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
tmpObject.QTY = (System.Decimal)dr["qty"];
tmpObject.PRICE = (System.Decimal)dr["price"];
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
public List<itemqty> GetAll()
{
List<itemqty> tmpList = new List<itemqty>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From itemqty", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
itemqty tmpObject = new itemqty();
msgRecField="-";
msgRecField=msgRecField + "idqtystore=";
msgRecField=msgRecField + dr["idqtystore"].ToString() +"=";
tmpObject.IDQTYSTORE = (System.Int32)dr["idqtystore"];
msgRecField=msgRecField + "id_item=";
msgRecField=msgRecField + dr["id_item"].ToString() +"=";
tmpObject.ID_ITEM = (System.Int32)dr["id_item"];
msgRecField=msgRecField + "id_store=";
msgRecField=msgRecField + dr["id_store"].ToString() +"=";
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
msgRecField=msgRecField + "qty=";
msgRecField=msgRecField + dr["qty"].ToString() +"=";
tmpObject.QTY = (System.Decimal)dr["qty"];
msgRecField=msgRecField + "price=";
msgRecField=msgRecField + dr["price"].ToString() +"=";
tmpObject.PRICE = (System.Decimal)dr["price"];
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
public List<itemqty> GetAllByCond(string cond)
{
List<itemqty> tmpList = new List<itemqty>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From itemqty Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
itemqty tmpObject = new itemqty();
msgRecField="-";
msgRecField=msgRecField + "idqtystore=";
msgRecField=msgRecField + dr["idqtystore"].ToString() +"=";
tmpObject.IDQTYSTORE = (System.Int32)dr["idqtystore"];
msgRecField=msgRecField + "id_item=";
msgRecField=msgRecField + dr["id_item"].ToString() +"=";
tmpObject.ID_ITEM = (System.Int32)dr["id_item"];
msgRecField=msgRecField + "id_store=";
msgRecField=msgRecField + dr["id_store"].ToString() +"=";
tmpObject.ID_STORE = (System.Int32)dr["id_store"];
msgRecField=msgRecField + "qty=";
msgRecField=msgRecField + dr["qty"].ToString() +"=";
tmpObject.QTY = (System.Decimal)dr["qty"];
msgRecField=msgRecField + "price=";
msgRecField=msgRecField + dr["price"].ToString() +"=";
tmpObject.PRICE = (System.Decimal)dr["price"];
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
 
