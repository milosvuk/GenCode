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
 
public class DB_propertycustomerincrease
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_propertycustomerincrease()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(propertycustomerincrease _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(propertycustomerincrease _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO propertycustomerincrease (idPropertyCustomer,DateFrom,DateTo,IncreasePerc,IncreaseAmount,Active,idCompany) VALUES (@idPropertyCustomer,@DateFrom,@DateTo,@IncreasePerc,@IncreaseAmount,@Active,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idPropertyCustomer", _tmpObject.IDPROPERTYCUSTOMER));
command.Parameters.Add(new SqlParameter("@DateFrom", _tmpObject.DATEFROM));
command.Parameters.Add(new SqlParameter("@DateTo", _tmpObject.DATETO));
command.Parameters.Add(new SqlParameter("@IncreasePerc", _tmpObject.INCREASEPERC));
command.Parameters.Add(new SqlParameter("@IncreaseAmount", _tmpObject.INCREASEAMOUNT));
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
 
public int Update(propertycustomerincrease _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(propertycustomerincrease _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE propertycustomerincrease SET idPropertyCustomer=@idpropertycustomer,DateFrom=@datefrom,DateTo=@dateto,IncreasePerc=@increaseperc,IncreaseAmount=@increaseamount,Active=@active,idCompany=@idcompany  WHERE idPropertyCustomerincrease=@idpropertycustomerincrease", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idpropertycustomer", _tmpObject.IDPROPERTYCUSTOMER));
command.Parameters.Add(new SqlParameter("@datefrom", _tmpObject.DATEFROM));
command.Parameters.Add(new SqlParameter("@dateto", _tmpObject.DATETO));
command.Parameters.Add(new SqlParameter("@increaseperc", _tmpObject.INCREASEPERC));
command.Parameters.Add(new SqlParameter("@increaseamount", _tmpObject.INCREASEAMOUNT));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idpropertycustomerincrease", _tmpObject.IDPROPERTYCUSTOMERINCREASE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(propertycustomerincrease _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(propertycustomerincrease _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE propertycustomerincrease  WHERE idPropertyCustomerincrease=@idpropertycustomerincrease", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idpropertycustomerincrease", _tmpObject.IDPROPERTYCUSTOMERINCREASE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public propertycustomerincrease GetById(int _id)
{
propertycustomerincrease tmpObject = new propertycustomerincrease();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerincrease WHERE idPropertyCustomerincrease=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROPERTYCUSTOMERINCREASE = (System.Int32)dr["idPropertyCustomerincrease"];
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
tmpObject.DATEFROM = (System.DateTime)dr["DateFrom"];
tmpObject.DATETO = (System.DateTime)dr["DateTo"];
tmpObject.INCREASEPERC = (System.Decimal)dr["IncreasePerc"];
tmpObject.INCREASEAMOUNT = (System.Decimal)dr["IncreaseAmount"];
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
public List<propertycustomerincrease> GetAll()
{
List<propertycustomerincrease> tmpList = new List<propertycustomerincrease>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerincrease", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomerincrease tmpObject = new propertycustomerincrease();
msgRecField="-";
msgRecField=msgRecField + "idPropertyCustomerincrease=";
msgRecField=msgRecField + dr["idPropertyCustomerincrease"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMERINCREASE = (System.Int32)dr["idPropertyCustomerincrease"];
msgRecField=msgRecField + "idPropertyCustomer=";
msgRecField=msgRecField + dr["idPropertyCustomer"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
msgRecField=msgRecField + "DateFrom=";
msgRecField=msgRecField + dr["DateFrom"].ToString() +"=";
tmpObject.DATEFROM = (System.DateTime)dr["DateFrom"];
msgRecField=msgRecField + "DateTo=";
msgRecField=msgRecField + dr["DateTo"].ToString() +"=";
tmpObject.DATETO = (System.DateTime)dr["DateTo"];
msgRecField=msgRecField + "IncreasePerc=";
msgRecField=msgRecField + dr["IncreasePerc"].ToString() +"=";
tmpObject.INCREASEPERC = (System.Decimal)dr["IncreasePerc"];
msgRecField=msgRecField + "IncreaseAmount=";
msgRecField=msgRecField + dr["IncreaseAmount"].ToString() +"=";
tmpObject.INCREASEAMOUNT = (System.Decimal)dr["IncreaseAmount"];
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
public List<propertycustomerincrease> GetAllByCond(string cond)
{
List<propertycustomerincrease> tmpList = new List<propertycustomerincrease>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerincrease Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomerincrease tmpObject = new propertycustomerincrease();
msgRecField="-";
msgRecField=msgRecField + "idPropertyCustomerincrease=";
msgRecField=msgRecField + dr["idPropertyCustomerincrease"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMERINCREASE = (System.Int32)dr["idPropertyCustomerincrease"];
msgRecField=msgRecField + "idPropertyCustomer=";
msgRecField=msgRecField + dr["idPropertyCustomer"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
msgRecField=msgRecField + "DateFrom=";
msgRecField=msgRecField + dr["DateFrom"].ToString() +"=";
tmpObject.DATEFROM = (System.DateTime)dr["DateFrom"];
msgRecField=msgRecField + "DateTo=";
msgRecField=msgRecField + dr["DateTo"].ToString() +"=";
tmpObject.DATETO = (System.DateTime)dr["DateTo"];
msgRecField=msgRecField + "IncreasePerc=";
msgRecField=msgRecField + dr["IncreasePerc"].ToString() +"=";
tmpObject.INCREASEPERC = (System.Decimal)dr["IncreasePerc"];
msgRecField=msgRecField + "IncreaseAmount=";
msgRecField=msgRecField + dr["IncreaseAmount"].ToString() +"=";
tmpObject.INCREASEAMOUNT = (System.Decimal)dr["IncreaseAmount"];
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
 
