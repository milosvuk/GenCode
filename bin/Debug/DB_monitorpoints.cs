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
 
public class DB_monitorpoints
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_monitorpoints()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(monitorpoints _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(monitorpoints _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO monitorpoints (description,implication,resolution,status,idcompany) VALUES (@description,@implication,@resolution,@status,@idcompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@implication", _tmpObject.IMPLICATION));
command.Parameters.Add(new SqlParameter("@resolution", _tmpObject.RESOLUTION));
command.Parameters.Add(new SqlParameter("@status", _tmpObject.STATUS));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
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
 
public int Update(monitorpoints _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(monitorpoints _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE monitorpoints SET description=@description,implication=@implication,resolution=@resolution,status=@status,idcompany=@idcompany  WHERE idmonitorpoints=@idmonitorpoints", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@implication", _tmpObject.IMPLICATION));
command.Parameters.Add(new SqlParameter("@resolution", _tmpObject.RESOLUTION));
command.Parameters.Add(new SqlParameter("@status", _tmpObject.STATUS));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idmonitorpoints", _tmpObject.IDMONITORPOINTS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(monitorpoints _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(monitorpoints _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE monitorpoints  WHERE idmonitorpoints=@idmonitorpoints", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idmonitorpoints", _tmpObject.IDMONITORPOINTS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public monitorpoints GetById(int _id)
{
monitorpoints tmpObject = new monitorpoints();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From monitorpoints WHERE idmonitorpoints=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDMONITORPOINTS = (System.Int32)dr["idmonitorpoints"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpObject.IMPLICATION = (System.String)dr["implication"];
tmpObject.RESOLUTION = (System.String)dr["resolution"];
tmpObject.STATUS = (System.String)dr["status"];
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
public List<monitorpoints> GetAll()
{
List<monitorpoints> tmpList = new List<monitorpoints>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From monitorpoints", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
monitorpoints tmpObject = new monitorpoints();
msgRecField="-";
msgRecField=msgRecField + "idmonitorpoints=";
msgRecField=msgRecField + dr["idmonitorpoints"].ToString() +"=";
tmpObject.IDMONITORPOINTS = (System.Int32)dr["idmonitorpoints"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "implication=";
msgRecField=msgRecField + dr["implication"].ToString() +"=";
tmpObject.IMPLICATION = (System.String)dr["implication"];
msgRecField=msgRecField + "resolution=";
msgRecField=msgRecField + dr["resolution"].ToString() +"=";
tmpObject.RESOLUTION = (System.String)dr["resolution"];
msgRecField=msgRecField + "status=";
msgRecField=msgRecField + dr["status"].ToString() +"=";
tmpObject.STATUS = (System.String)dr["status"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
public List<monitorpoints> GetAllByCond(string cond)
{
List<monitorpoints> tmpList = new List<monitorpoints>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From monitorpoints Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
monitorpoints tmpObject = new monitorpoints();
msgRecField="-";
msgRecField=msgRecField + "idmonitorpoints=";
msgRecField=msgRecField + dr["idmonitorpoints"].ToString() +"=";
tmpObject.IDMONITORPOINTS = (System.Int32)dr["idmonitorpoints"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "implication=";
msgRecField=msgRecField + dr["implication"].ToString() +"=";
tmpObject.IMPLICATION = (System.String)dr["implication"];
msgRecField=msgRecField + "resolution=";
msgRecField=msgRecField + dr["resolution"].ToString() +"=";
tmpObject.RESOLUTION = (System.String)dr["resolution"];
msgRecField=msgRecField + "status=";
msgRecField=msgRecField + dr["status"].ToString() +"=";
tmpObject.STATUS = (System.String)dr["status"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
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
 
