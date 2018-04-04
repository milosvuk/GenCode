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
 
public class DB_linkprojectprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_linkprojectprocess()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(linkprojectprocess _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(linkprojectprocess _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO linkprojectprocess (ProjectName,ProcessName,ProcessDescription,id_project,id_process) VALUES (@ProjectName,@ProcessName,@ProcessDescription,@id_project,@id_process) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@ProjectName", _tmpObject.PROJECTNAME));
command.Parameters.Add(new SqlParameter("@ProcessName", _tmpObject.PROCESSNAME));
command.Parameters.Add(new SqlParameter("@ProcessDescription", _tmpObject.PROCESSDESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_project", _tmpObject.ID_PROJECT));
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
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
 
public int Update(linkprojectprocess _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(linkprojectprocess _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE linkprojectprocess SET ProjectName=@projectname,ProcessName=@processname,ProcessDescription=@processdescription,id_project=@id_project,id_process=@id_process  WHERE idprojectprocess=@idprojectprocess", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@projectname", _tmpObject.PROJECTNAME));
command.Parameters.Add(new SqlParameter("@processname", _tmpObject.PROCESSNAME));
command.Parameters.Add(new SqlParameter("@processdescription", _tmpObject.PROCESSDESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_project", _tmpObject.ID_PROJECT));
command.Parameters.Add(new SqlParameter("@id_process", _tmpObject.ID_PROCESS));
command.Parameters.Add(new SqlParameter("@idprojectprocess", _tmpObject.IDPROJECTPROCESS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(linkprojectprocess _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(linkprojectprocess _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE linkprojectprocess  WHERE idprojectprocess=@idprojectprocess", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idprojectprocess", _tmpObject.IDPROJECTPROCESS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public linkprojectprocess GetById(int _id)
{
linkprojectprocess tmpObject = new linkprojectprocess();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkprojectprocess WHERE idprojectprocess=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROJECTPROCESS = (System.Int32)dr["idprojectprocess"];
tmpObject.PROJECTNAME = (System.String)dr["ProjectName"];
tmpObject.PROCESSNAME = (System.String)dr["ProcessName"];
tmpObject.PROCESSDESCRIPTION = (System.String)dr["ProcessDescription"];
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
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
public List<linkprojectprocess> GetAll()
{
List<linkprojectprocess> tmpList = new List<linkprojectprocess>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkprojectprocess", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
linkprojectprocess tmpObject = new linkprojectprocess();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocess=";
msgRecField=msgRecField + dr["idprojectprocess"].ToString() +"=";
tmpObject.IDPROJECTPROCESS = (System.Int32)dr["idprojectprocess"];
msgRecField=msgRecField + "ProjectName=";
msgRecField=msgRecField + dr["ProjectName"].ToString() +"=";
tmpObject.PROJECTNAME = (System.String)dr["ProjectName"];
msgRecField=msgRecField + "ProcessName=";
msgRecField=msgRecField + dr["ProcessName"].ToString() +"=";
tmpObject.PROCESSNAME = (System.String)dr["ProcessName"];
msgRecField=msgRecField + "ProcessDescription=";
msgRecField=msgRecField + dr["ProcessDescription"].ToString() +"=";
tmpObject.PROCESSDESCRIPTION = (System.String)dr["ProcessDescription"];
msgRecField=msgRecField + "id_project=";
msgRecField=msgRecField + dr["id_project"].ToString() +"=";
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
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
public List<linkprojectprocess> GetAllByCond(string cond)
{
List<linkprojectprocess> tmpList = new List<linkprojectprocess>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From linkprojectprocess Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
linkprojectprocess tmpObject = new linkprojectprocess();
msgRecField="-";
msgRecField=msgRecField + "idprojectprocess=";
msgRecField=msgRecField + dr["idprojectprocess"].ToString() +"=";
tmpObject.IDPROJECTPROCESS = (System.Int32)dr["idprojectprocess"];
msgRecField=msgRecField + "ProjectName=";
msgRecField=msgRecField + dr["ProjectName"].ToString() +"=";
tmpObject.PROJECTNAME = (System.String)dr["ProjectName"];
msgRecField=msgRecField + "ProcessName=";
msgRecField=msgRecField + dr["ProcessName"].ToString() +"=";
tmpObject.PROCESSNAME = (System.String)dr["ProcessName"];
msgRecField=msgRecField + "ProcessDescription=";
msgRecField=msgRecField + dr["ProcessDescription"].ToString() +"=";
tmpObject.PROCESSDESCRIPTION = (System.String)dr["ProcessDescription"];
msgRecField=msgRecField + "id_project=";
msgRecField=msgRecField + dr["id_project"].ToString() +"=";
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
msgRecField=msgRecField + "id_process=";
msgRecField=msgRecField + dr["id_process"].ToString() +"=";
tmpObject.ID_PROCESS = (System.Int32)dr["id_process"];
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
 
