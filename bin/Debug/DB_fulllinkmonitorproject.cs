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
 
public class DB_fulllinkmonitorproject
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_fulllinkmonitorproject()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(fulllinkmonitorproject _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(fulllinkmonitorproject _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO fulllinkmonitorproject (ProjectName,MonitoringPoint,implication,resolution,status,id_monitorpoints,id_project) VALUES (@ProjectName,@MonitoringPoint,@implication,@resolution,@status,@id_monitorpoints,@id_project) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@ProjectName", _tmpObject.PROJECTNAME));
command.Parameters.Add(new SqlParameter("@MonitoringPoint", _tmpObject.MONITORINGPOINT));
command.Parameters.Add(new SqlParameter("@implication", _tmpObject.IMPLICATION));
command.Parameters.Add(new SqlParameter("@resolution", _tmpObject.RESOLUTION));
command.Parameters.Add(new SqlParameter("@status", _tmpObject.STATUS));
command.Parameters.Add(new SqlParameter("@id_monitorpoints", _tmpObject.ID_MONITORPOINTS));
command.Parameters.Add(new SqlParameter("@id_project", _tmpObject.ID_PROJECT));
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
 
public int Update(fulllinkmonitorproject _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(fulllinkmonitorproject _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE fulllinkmonitorproject SET ProjectName=@projectname,MonitoringPoint=@monitoringpoint,implication=@implication,resolution=@resolution,status=@status,id_monitorpoints=@id_monitorpoints,id_project=@id_project  WHERE idlinkmonitorproject=@idlinkmonitorproject", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@projectname", _tmpObject.PROJECTNAME));
command.Parameters.Add(new SqlParameter("@monitoringpoint", _tmpObject.MONITORINGPOINT));
command.Parameters.Add(new SqlParameter("@implication", _tmpObject.IMPLICATION));
command.Parameters.Add(new SqlParameter("@resolution", _tmpObject.RESOLUTION));
command.Parameters.Add(new SqlParameter("@status", _tmpObject.STATUS));
command.Parameters.Add(new SqlParameter("@id_monitorpoints", _tmpObject.ID_MONITORPOINTS));
command.Parameters.Add(new SqlParameter("@id_project", _tmpObject.ID_PROJECT));
command.Parameters.Add(new SqlParameter("@idlinkmonitorproject", _tmpObject.IDLINKMONITORPROJECT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(fulllinkmonitorproject _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(fulllinkmonitorproject _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE fulllinkmonitorproject  WHERE idlinkmonitorproject=@idlinkmonitorproject", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idlinkmonitorproject", _tmpObject.IDLINKMONITORPROJECT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public fulllinkmonitorproject GetById(int _id)
{
fulllinkmonitorproject tmpObject = new fulllinkmonitorproject();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From fulllinkmonitorproject WHERE idlinkmonitorproject=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDLINKMONITORPROJECT = (System.Int32)dr["idlinkmonitorproject"];
tmpObject.PROJECTNAME = (System.String)dr["ProjectName"];
tmpObject.MONITORINGPOINT = (System.String)dr["MonitoringPoint"];
tmpObject.IMPLICATION = (System.String)dr["implication"];
tmpObject.RESOLUTION = (System.String)dr["resolution"];
tmpObject.STATUS = (System.String)dr["status"];
tmpObject.ID_MONITORPOINTS = (System.Int32)dr["id_monitorpoints"];
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
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
public List<fulllinkmonitorproject> GetAll()
{
List<fulllinkmonitorproject> tmpList = new List<fulllinkmonitorproject>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From fulllinkmonitorproject", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
fulllinkmonitorproject tmpObject = new fulllinkmonitorproject();
msgRecField="-";
msgRecField=msgRecField + "idlinkmonitorproject=";
msgRecField=msgRecField + dr["idlinkmonitorproject"].ToString() +"=";
tmpObject.IDLINKMONITORPROJECT = (System.Int32)dr["idlinkmonitorproject"];
msgRecField=msgRecField + "ProjectName=";
msgRecField=msgRecField + dr["ProjectName"].ToString() +"=";
tmpObject.PROJECTNAME = (System.String)dr["ProjectName"];
msgRecField=msgRecField + "MonitoringPoint=";
msgRecField=msgRecField + dr["MonitoringPoint"].ToString() +"=";
tmpObject.MONITORINGPOINT = (System.String)dr["MonitoringPoint"];
msgRecField=msgRecField + "implication=";
msgRecField=msgRecField + dr["implication"].ToString() +"=";
tmpObject.IMPLICATION = (System.String)dr["implication"];
msgRecField=msgRecField + "resolution=";
msgRecField=msgRecField + dr["resolution"].ToString() +"=";
tmpObject.RESOLUTION = (System.String)dr["resolution"];
msgRecField=msgRecField + "status=";
msgRecField=msgRecField + dr["status"].ToString() +"=";
tmpObject.STATUS = (System.String)dr["status"];
msgRecField=msgRecField + "id_monitorpoints=";
msgRecField=msgRecField + dr["id_monitorpoints"].ToString() +"=";
tmpObject.ID_MONITORPOINTS = (System.Int32)dr["id_monitorpoints"];
msgRecField=msgRecField + "id_project=";
msgRecField=msgRecField + dr["id_project"].ToString() +"=";
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
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
public List<fulllinkmonitorproject> GetAllByCond(string cond)
{
List<fulllinkmonitorproject> tmpList = new List<fulllinkmonitorproject>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From fulllinkmonitorproject Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
fulllinkmonitorproject tmpObject = new fulllinkmonitorproject();
msgRecField="-";
msgRecField=msgRecField + "idlinkmonitorproject=";
msgRecField=msgRecField + dr["idlinkmonitorproject"].ToString() +"=";
tmpObject.IDLINKMONITORPROJECT = (System.Int32)dr["idlinkmonitorproject"];
msgRecField=msgRecField + "ProjectName=";
msgRecField=msgRecField + dr["ProjectName"].ToString() +"=";
tmpObject.PROJECTNAME = (System.String)dr["ProjectName"];
msgRecField=msgRecField + "MonitoringPoint=";
msgRecField=msgRecField + dr["MonitoringPoint"].ToString() +"=";
tmpObject.MONITORINGPOINT = (System.String)dr["MonitoringPoint"];
msgRecField=msgRecField + "implication=";
msgRecField=msgRecField + dr["implication"].ToString() +"=";
tmpObject.IMPLICATION = (System.String)dr["implication"];
msgRecField=msgRecField + "resolution=";
msgRecField=msgRecField + dr["resolution"].ToString() +"=";
tmpObject.RESOLUTION = (System.String)dr["resolution"];
msgRecField=msgRecField + "status=";
msgRecField=msgRecField + dr["status"].ToString() +"=";
tmpObject.STATUS = (System.String)dr["status"];
msgRecField=msgRecField + "id_monitorpoints=";
msgRecField=msgRecField + dr["id_monitorpoints"].ToString() +"=";
tmpObject.ID_MONITORPOINTS = (System.Int32)dr["id_monitorpoints"];
msgRecField=msgRecField + "id_project=";
msgRecField=msgRecField + dr["id_project"].ToString() +"=";
tmpObject.ID_PROJECT = (System.Int32)dr["id_project"];
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
 
