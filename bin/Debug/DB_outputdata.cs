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
 
public class DB_outputdata
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_outputdata()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(outputdata _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(outputdata _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO outputdata (id_objclasses,typeandname,ruleswithaction,idcompany,active) VALUES (@id_objclasses,@typeandname,@ruleswithaction,@idcompany,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@typeandname", _tmpObject.TYPEANDNAME));
command.Parameters.Add(new SqlParameter("@ruleswithaction", _tmpObject.RULESWITHACTION));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
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
 
public int Update(outputdata _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(outputdata _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE outputdata SET id_objclasses=@id_objclasses,typeandname=@typeandname,ruleswithaction=@ruleswithaction,idcompany=@idcompany,active=@active  WHERE idoutput=@idoutput", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_objclasses", _tmpObject.ID_OBJCLASSES));
command.Parameters.Add(new SqlParameter("@typeandname", _tmpObject.TYPEANDNAME));
command.Parameters.Add(new SqlParameter("@ruleswithaction", _tmpObject.RULESWITHACTION));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idoutput", _tmpObject.IDOUTPUT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(outputdata _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(outputdata _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE outputdata  WHERE idoutput=@idoutput", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idoutput", _tmpObject.IDOUTPUT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public outputdata GetById(int _id)
{
outputdata tmpObject = new outputdata();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From outputdata WHERE idoutput=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDOUTPUT = (System.Int32)dr["idoutput"];
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
tmpObject.TYPEANDNAME = (System.String)dr["typeandname"];
tmpObject.RULESWITHACTION = (System.String)dr["ruleswithaction"];
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
public List<outputdata> GetAll()
{
List<outputdata> tmpList = new List<outputdata>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From outputdata", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
outputdata tmpObject = new outputdata();
msgRecField="-";
msgRecField=msgRecField + "idoutput=";
msgRecField=msgRecField + dr["idoutput"].ToString() +"=";
tmpObject.IDOUTPUT = (System.Int32)dr["idoutput"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "typeandname=";
msgRecField=msgRecField + dr["typeandname"].ToString() +"=";
tmpObject.TYPEANDNAME = (System.String)dr["typeandname"];
msgRecField=msgRecField + "ruleswithaction=";
msgRecField=msgRecField + dr["ruleswithaction"].ToString() +"=";
tmpObject.RULESWITHACTION = (System.String)dr["ruleswithaction"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
msgRecField=msgRecField + "active=";
msgRecField=msgRecField + dr["active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
public List<outputdata> GetAllByCond(string cond)
{
List<outputdata> tmpList = new List<outputdata>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From outputdata Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
outputdata tmpObject = new outputdata();
msgRecField="-";
msgRecField=msgRecField + "idoutput=";
msgRecField=msgRecField + dr["idoutput"].ToString() +"=";
tmpObject.IDOUTPUT = (System.Int32)dr["idoutput"];
msgRecField=msgRecField + "id_objclasses=";
msgRecField=msgRecField + dr["id_objclasses"].ToString() +"=";
tmpObject.ID_OBJCLASSES = (System.Int32)dr["id_objclasses"];
msgRecField=msgRecField + "typeandname=";
msgRecField=msgRecField + dr["typeandname"].ToString() +"=";
tmpObject.TYPEANDNAME = (System.String)dr["typeandname"];
msgRecField=msgRecField + "ruleswithaction=";
msgRecField=msgRecField + dr["ruleswithaction"].ToString() +"=";
tmpObject.RULESWITHACTION = (System.String)dr["ruleswithaction"];
msgRecField=msgRecField + "idcompany=";
msgRecField=msgRecField + dr["idcompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idcompany"];
msgRecField=msgRecField + "active=";
msgRecField=msgRecField + dr["active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["active"];
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
 
