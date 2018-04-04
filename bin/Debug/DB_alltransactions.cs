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
 
public class DB_alltransactions
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_alltransactions()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(alltransactions _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(alltransactions _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO alltransactions (idDoc,DateOfDoc,TypeOfDoc,Description,AmountOfDoc,RemainingAmount) VALUES (@idDoc,@DateOfDoc,@TypeOfDoc,@Description,@AmountOfDoc,@RemainingAmount) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idDoc", _tmpObject.IDDOC));
command.Parameters.Add(new SqlParameter("@DateOfDoc", _tmpObject.DATEOFDOC));
command.Parameters.Add(new SqlParameter("@TypeOfDoc", _tmpObject.TYPEOFDOC));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@AmountOfDoc", _tmpObject.AMOUNTOFDOC));
command.Parameters.Add(new SqlParameter("@RemainingAmount", _tmpObject.REMAININGAMOUNT));
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
 
public int Update(alltransactions _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(alltransactions _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE alltransactions SET idDoc=@iddoc,DateOfDoc=@dateofdoc,TypeOfDoc=@typeofdoc,Description=@description,AmountOfDoc=@amountofdoc,RemainingAmount=@remainingamount  WHERE idRec=@idrec", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@iddoc", _tmpObject.IDDOC));
command.Parameters.Add(new SqlParameter("@dateofdoc", _tmpObject.DATEOFDOC));
command.Parameters.Add(new SqlParameter("@typeofdoc", _tmpObject.TYPEOFDOC));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@amountofdoc", _tmpObject.AMOUNTOFDOC));
command.Parameters.Add(new SqlParameter("@remainingamount", _tmpObject.REMAININGAMOUNT));
command.Parameters.Add(new SqlParameter("@idrec", _tmpObject.IDREC));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(alltransactions _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(alltransactions _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE alltransactions  WHERE idRec=@idrec", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrec", _tmpObject.IDREC));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public alltransactions GetById(int _id)
{
alltransactions tmpObject = new alltransactions();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From alltransactions WHERE idRec=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDREC = (System.Int32)dr["idRec"];
tmpObject.IDDOC = (System.Int32)dr["idDoc"];
tmpObject.DATEOFDOC = (System.String)dr["DateOfDoc"];
tmpObject.TYPEOFDOC = (System.String)dr["TypeOfDoc"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
tmpObject.AMOUNTOFDOC = (System.Decimal)dr["AmountOfDoc"];
tmpObject.REMAININGAMOUNT = (System.Decimal)dr["RemainingAmount"];
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
public List<alltransactions> GetAll()
{
List<alltransactions> tmpList = new List<alltransactions>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From alltransactions", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
alltransactions tmpObject = new alltransactions();
msgRecField="-";
msgRecField=msgRecField + "idRec=";
msgRecField=msgRecField + dr["idRec"].ToString() +"=";
tmpObject.IDREC = (System.Int32)dr["idRec"];
msgRecField=msgRecField + "idDoc=";
msgRecField=msgRecField + dr["idDoc"].ToString() +"=";
tmpObject.IDDOC = (System.Int32)dr["idDoc"];
msgRecField=msgRecField + "DateOfDoc=";
msgRecField=msgRecField + dr["DateOfDoc"].ToString() +"=";
tmpObject.DATEOFDOC = (System.String)dr["DateOfDoc"];
msgRecField=msgRecField + "TypeOfDoc=";
msgRecField=msgRecField + dr["TypeOfDoc"].ToString() +"=";
tmpObject.TYPEOFDOC = (System.String)dr["TypeOfDoc"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "AmountOfDoc=";
msgRecField=msgRecField + dr["AmountOfDoc"].ToString() +"=";
tmpObject.AMOUNTOFDOC = (System.Decimal)dr["AmountOfDoc"];
msgRecField=msgRecField + "RemainingAmount=";
msgRecField=msgRecField + dr["RemainingAmount"].ToString() +"=";
tmpObject.REMAININGAMOUNT = (System.Decimal)dr["RemainingAmount"];
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
public List<alltransactions> GetAllByCond(string cond)
{
List<alltransactions> tmpList = new List<alltransactions>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From alltransactions Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
alltransactions tmpObject = new alltransactions();
msgRecField="-";
msgRecField=msgRecField + "idRec=";
msgRecField=msgRecField + dr["idRec"].ToString() +"=";
tmpObject.IDREC = (System.Int32)dr["idRec"];
msgRecField=msgRecField + "idDoc=";
msgRecField=msgRecField + dr["idDoc"].ToString() +"=";
tmpObject.IDDOC = (System.Int32)dr["idDoc"];
msgRecField=msgRecField + "DateOfDoc=";
msgRecField=msgRecField + dr["DateOfDoc"].ToString() +"=";
tmpObject.DATEOFDOC = (System.String)dr["DateOfDoc"];
msgRecField=msgRecField + "TypeOfDoc=";
msgRecField=msgRecField + dr["TypeOfDoc"].ToString() +"=";
tmpObject.TYPEOFDOC = (System.String)dr["TypeOfDoc"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "AmountOfDoc=";
msgRecField=msgRecField + dr["AmountOfDoc"].ToString() +"=";
tmpObject.AMOUNTOFDOC = (System.Decimal)dr["AmountOfDoc"];
msgRecField=msgRecField + "RemainingAmount=";
msgRecField=msgRecField + dr["RemainingAmount"].ToString() +"=";
tmpObject.REMAININGAMOUNT = (System.Decimal)dr["RemainingAmount"];
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
 
