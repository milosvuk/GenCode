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
 
public class DB_receivingitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_receivingitem()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(receivingitem _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(receivingitem _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO receivingitem (id_receiving,id_item,qty_item,price_item,total_price_item,id_company) VALUES (@id_receiving,@id_item,@qty_item,@price_item,@total_price_item,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_receiving", _tmpObject.ID_RECEIVING));
command.Parameters.Add(new SqlParameter("@id_item", _tmpObject.ID_ITEM));
command.Parameters.Add(new SqlParameter("@qty_item", _tmpObject.QTY_ITEM));
command.Parameters.Add(new SqlParameter("@price_item", _tmpObject.PRICE_ITEM));
command.Parameters.Add(new SqlParameter("@total_price_item", _tmpObject.TOTAL_PRICE_ITEM));
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
 
public int Update(receivingitem _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(receivingitem _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE receivingitem SET id_receiving=@id_receiving,id_item=@id_item,qty_item=@qty_item,price_item=@price_item,total_price_item=@total_price_item,id_company=@id_company  WHERE idreceivingitem=@idreceivingitem", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_receiving", _tmpObject.ID_RECEIVING));
command.Parameters.Add(new SqlParameter("@id_item", _tmpObject.ID_ITEM));
command.Parameters.Add(new SqlParameter("@qty_item", _tmpObject.QTY_ITEM));
command.Parameters.Add(new SqlParameter("@price_item", _tmpObject.PRICE_ITEM));
command.Parameters.Add(new SqlParameter("@total_price_item", _tmpObject.TOTAL_PRICE_ITEM));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idreceivingitem", _tmpObject.IDRECEIVINGITEM));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(receivingitem _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(receivingitem _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE receivingitem  WHERE idreceivingitem=@idreceivingitem", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idreceivingitem", _tmpObject.IDRECEIVINGITEM));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public receivingitem GetById(int _id)
{
receivingitem tmpObject = new receivingitem();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From receivingitem WHERE idreceivingitem=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECEIVINGITEM = (System.Int32)dr["idreceivingitem"];
tmpObject.ID_RECEIVING = (System.Int32)dr["id_receiving"];
tmpObject.ID_ITEM = (System.Int32)dr["id_item"];
tmpObject.QTY_ITEM = (System.Decimal)dr["qty_item"];
tmpObject.PRICE_ITEM = (System.Decimal)dr["price_item"];
tmpObject.TOTAL_PRICE_ITEM = (System.Decimal)dr["total_price_item"];
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
public List<receivingitem> GetAll()
{
List<receivingitem> tmpList = new List<receivingitem>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From receivingitem", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
receivingitem tmpObject = new receivingitem();
msgRecField="-";
msgRecField=msgRecField + "idreceivingitem=";
msgRecField=msgRecField + dr["idreceivingitem"].ToString() +"=";
tmpObject.IDRECEIVINGITEM = (System.Int32)dr["idreceivingitem"];
msgRecField=msgRecField + "id_receiving=";
msgRecField=msgRecField + dr["id_receiving"].ToString() +"=";
tmpObject.ID_RECEIVING = (System.Int32)dr["id_receiving"];
msgRecField=msgRecField + "id_item=";
msgRecField=msgRecField + dr["id_item"].ToString() +"=";
tmpObject.ID_ITEM = (System.Int32)dr["id_item"];
msgRecField=msgRecField + "qty_item=";
msgRecField=msgRecField + dr["qty_item"].ToString() +"=";
tmpObject.QTY_ITEM = (System.Decimal)dr["qty_item"];
msgRecField=msgRecField + "price_item=";
msgRecField=msgRecField + dr["price_item"].ToString() +"=";
tmpObject.PRICE_ITEM = (System.Decimal)dr["price_item"];
msgRecField=msgRecField + "total_price_item=";
msgRecField=msgRecField + dr["total_price_item"].ToString() +"=";
tmpObject.TOTAL_PRICE_ITEM = (System.Decimal)dr["total_price_item"];
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
public List<receivingitem> GetAllByCond(string cond)
{
List<receivingitem> tmpList = new List<receivingitem>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From receivingitem Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
receivingitem tmpObject = new receivingitem();
msgRecField="-";
msgRecField=msgRecField + "idreceivingitem=";
msgRecField=msgRecField + dr["idreceivingitem"].ToString() +"=";
tmpObject.IDRECEIVINGITEM = (System.Int32)dr["idreceivingitem"];
msgRecField=msgRecField + "id_receiving=";
msgRecField=msgRecField + dr["id_receiving"].ToString() +"=";
tmpObject.ID_RECEIVING = (System.Int32)dr["id_receiving"];
msgRecField=msgRecField + "id_item=";
msgRecField=msgRecField + dr["id_item"].ToString() +"=";
tmpObject.ID_ITEM = (System.Int32)dr["id_item"];
msgRecField=msgRecField + "qty_item=";
msgRecField=msgRecField + dr["qty_item"].ToString() +"=";
tmpObject.QTY_ITEM = (System.Decimal)dr["qty_item"];
msgRecField=msgRecField + "price_item=";
msgRecField=msgRecField + dr["price_item"].ToString() +"=";
tmpObject.PRICE_ITEM = (System.Decimal)dr["price_item"];
msgRecField=msgRecField + "total_price_item=";
msgRecField=msgRecField + dr["total_price_item"].ToString() +"=";
tmpObject.TOTAL_PRICE_ITEM = (System.Decimal)dr["total_price_item"];
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
 
