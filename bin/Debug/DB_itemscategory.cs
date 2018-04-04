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
 
public class DB_itemscategory
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_itemscategory()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(itemscategory _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(itemscategory _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO itemscategory (dcs,deparmentcode,departmentname,classcode,classname,subclasscode,subclassname) VALUES (@dcs,@deparmentcode,@departmentname,@classcode,@classname,@subclasscode,@subclassname) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@dcs", _tmpObject.DCS));
command.Parameters.Add(new SqlParameter("@deparmentcode", _tmpObject.DEPARMENTCODE));
command.Parameters.Add(new SqlParameter("@departmentname", _tmpObject.DEPARTMENTNAME));
command.Parameters.Add(new SqlParameter("@classcode", _tmpObject.CLASSCODE));
command.Parameters.Add(new SqlParameter("@classname", _tmpObject.CLASSNAME));
command.Parameters.Add(new SqlParameter("@subclasscode", _tmpObject.SUBCLASSCODE));
command.Parameters.Add(new SqlParameter("@subclassname", _tmpObject.SUBCLASSNAME));
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
 
public int Update(itemscategory _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(itemscategory _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE itemscategory SET dcs=@dcs,deparmentcode=@deparmentcode,departmentname=@departmentname,classcode=@classcode,classname=@classname,subclasscode=@subclasscode,subclassname=@subclassname  WHERE iddcs=@iddcs", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@dcs", _tmpObject.DCS));
command.Parameters.Add(new SqlParameter("@deparmentcode", _tmpObject.DEPARMENTCODE));
command.Parameters.Add(new SqlParameter("@departmentname", _tmpObject.DEPARTMENTNAME));
command.Parameters.Add(new SqlParameter("@classcode", _tmpObject.CLASSCODE));
command.Parameters.Add(new SqlParameter("@classname", _tmpObject.CLASSNAME));
command.Parameters.Add(new SqlParameter("@subclasscode", _tmpObject.SUBCLASSCODE));
command.Parameters.Add(new SqlParameter("@subclassname", _tmpObject.SUBCLASSNAME));
command.Parameters.Add(new SqlParameter("@iddcs", _tmpObject.IDDCS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(itemscategory _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(itemscategory _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE itemscategory  WHERE iddcs=@iddcs", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@iddcs", _tmpObject.IDDCS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public itemscategory GetById(int _id)
{
itemscategory tmpObject = new itemscategory();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From itemscategory WHERE iddcs=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDDCS = (System.Int32)dr["iddcs"];
tmpObject.DCS = (System.String)dr["dcs"];
tmpObject.DEPARMENTCODE = (System.String)dr["deparmentcode"];
tmpObject.DEPARTMENTNAME = (System.String)dr["departmentname"];
tmpObject.CLASSCODE = (System.String)dr["classcode"];
tmpObject.CLASSNAME = (System.String)dr["classname"];
tmpObject.SUBCLASSCODE = (System.String)dr["subclasscode"];
tmpObject.SUBCLASSNAME = (System.String)dr["subclassname"];
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
public List<itemscategory> GetAll()
{
List<itemscategory> tmpList = new List<itemscategory>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From itemscategory", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
itemscategory tmpObject = new itemscategory();
msgRecField="-";
msgRecField=msgRecField + "iddcs=";
msgRecField=msgRecField + dr["iddcs"].ToString() +"=";
tmpObject.IDDCS = (System.Int32)dr["iddcs"];
msgRecField=msgRecField + "dcs=";
msgRecField=msgRecField + dr["dcs"].ToString() +"=";
tmpObject.DCS = (System.String)dr["dcs"];
msgRecField=msgRecField + "deparmentcode=";
msgRecField=msgRecField + dr["deparmentcode"].ToString() +"=";
tmpObject.DEPARMENTCODE = (System.String)dr["deparmentcode"];
msgRecField=msgRecField + "departmentname=";
msgRecField=msgRecField + dr["departmentname"].ToString() +"=";
tmpObject.DEPARTMENTNAME = (System.String)dr["departmentname"];
msgRecField=msgRecField + "classcode=";
msgRecField=msgRecField + dr["classcode"].ToString() +"=";
tmpObject.CLASSCODE = (System.String)dr["classcode"];
msgRecField=msgRecField + "classname=";
msgRecField=msgRecField + dr["classname"].ToString() +"=";
tmpObject.CLASSNAME = (System.String)dr["classname"];
msgRecField=msgRecField + "subclasscode=";
msgRecField=msgRecField + dr["subclasscode"].ToString() +"=";
tmpObject.SUBCLASSCODE = (System.String)dr["subclasscode"];
msgRecField=msgRecField + "subclassname=";
msgRecField=msgRecField + dr["subclassname"].ToString() +"=";
tmpObject.SUBCLASSNAME = (System.String)dr["subclassname"];
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
public List<itemscategory> GetAllByCond(string cond)
{
List<itemscategory> tmpList = new List<itemscategory>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From itemscategory Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
itemscategory tmpObject = new itemscategory();
msgRecField="-";
msgRecField=msgRecField + "iddcs=";
msgRecField=msgRecField + dr["iddcs"].ToString() +"=";
tmpObject.IDDCS = (System.Int32)dr["iddcs"];
msgRecField=msgRecField + "dcs=";
msgRecField=msgRecField + dr["dcs"].ToString() +"=";
tmpObject.DCS = (System.String)dr["dcs"];
msgRecField=msgRecField + "deparmentcode=";
msgRecField=msgRecField + dr["deparmentcode"].ToString() +"=";
tmpObject.DEPARMENTCODE = (System.String)dr["deparmentcode"];
msgRecField=msgRecField + "departmentname=";
msgRecField=msgRecField + dr["departmentname"].ToString() +"=";
tmpObject.DEPARTMENTNAME = (System.String)dr["departmentname"];
msgRecField=msgRecField + "classcode=";
msgRecField=msgRecField + dr["classcode"].ToString() +"=";
tmpObject.CLASSCODE = (System.String)dr["classcode"];
msgRecField=msgRecField + "classname=";
msgRecField=msgRecField + dr["classname"].ToString() +"=";
tmpObject.CLASSNAME = (System.String)dr["classname"];
msgRecField=msgRecField + "subclasscode=";
msgRecField=msgRecField + dr["subclasscode"].ToString() +"=";
tmpObject.SUBCLASSCODE = (System.String)dr["subclasscode"];
msgRecField=msgRecField + "subclassname=";
msgRecField=msgRecField + dr["subclassname"].ToString() +"=";
tmpObject.SUBCLASSNAME = (System.String)dr["subclassname"];
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
 
