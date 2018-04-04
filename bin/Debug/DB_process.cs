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
 
public class DB_process
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_process()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(process _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(process _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO process (typeofprocess,id_location,id_entity,qty,valueperunit,totalvalue,dateofprocess,timeofprocess,weekofprocess,monthofprocess,yearofprocess,id_document,documentssource,filesource,description1,description2,id_relatedentity,id_company) VALUES (@typeofprocess,@id_location,@id_entity,@qty,@valueperunit,@totalvalue,@dateofprocess,@timeofprocess,@weekofprocess,@monthofprocess,@yearofprocess,@id_document,@documentssource,@filesource,@description1,@description2,@id_relatedentity,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@typeofprocess", _tmpObject.TYPEOFPROCESS));
command.Parameters.Add(new SqlParameter("@id_location", _tmpObject.ID_LOCATION));
command.Parameters.Add(new SqlParameter("@id_entity", _tmpObject.ID_ENTITY));
command.Parameters.Add(new SqlParameter("@qty", _tmpObject.QTY));
command.Parameters.Add(new SqlParameter("@valueperunit", _tmpObject.VALUEPERUNIT));
command.Parameters.Add(new SqlParameter("@totalvalue", _tmpObject.TOTALVALUE));
command.Parameters.Add(new SqlParameter("@dateofprocess", _tmpObject.DATEOFPROCESS));
command.Parameters.Add(new SqlParameter("@timeofprocess", _tmpObject.TIMEOFPROCESS));
command.Parameters.Add(new SqlParameter("@weekofprocess", _tmpObject.WEEKOFPROCESS));
command.Parameters.Add(new SqlParameter("@monthofprocess", _tmpObject.MONTHOFPROCESS));
command.Parameters.Add(new SqlParameter("@yearofprocess", _tmpObject.YEAROFPROCESS));
command.Parameters.Add(new SqlParameter("@id_document", _tmpObject.ID_DOCUMENT));
command.Parameters.Add(new SqlParameter("@documentssource", _tmpObject.DOCUMENTSSOURCE));
command.Parameters.Add(new SqlParameter("@filesource", _tmpObject.FILESOURCE));
command.Parameters.Add(new SqlParameter("@description1", _tmpObject.DESCRIPTION1));
command.Parameters.Add(new SqlParameter("@description2", _tmpObject.DESCRIPTION2));
command.Parameters.Add(new SqlParameter("@id_relatedentity", _tmpObject.ID_RELATEDENTITY));
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
 
public int Update(process _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(process _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE process SET typeofprocess=@typeofprocess,id_location=@id_location,id_entity=@id_entity,qty=@qty,valueperunit=@valueperunit,totalvalue=@totalvalue,dateofprocess=@dateofprocess,timeofprocess=@timeofprocess,weekofprocess=@weekofprocess,monthofprocess=@monthofprocess,yearofprocess=@yearofprocess,id_document=@id_document,documentssource=@documentssource,filesource=@filesource,description1=@description1,description2=@description2,id_relatedentity=@id_relatedentity,id_company=@id_company  WHERE idprocess=@idprocess", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@typeofprocess", _tmpObject.TYPEOFPROCESS));
command.Parameters.Add(new SqlParameter("@id_location", _tmpObject.ID_LOCATION));
command.Parameters.Add(new SqlParameter("@id_entity", _tmpObject.ID_ENTITY));
command.Parameters.Add(new SqlParameter("@qty", _tmpObject.QTY));
command.Parameters.Add(new SqlParameter("@valueperunit", _tmpObject.VALUEPERUNIT));
command.Parameters.Add(new SqlParameter("@totalvalue", _tmpObject.TOTALVALUE));
command.Parameters.Add(new SqlParameter("@dateofprocess", _tmpObject.DATEOFPROCESS));
command.Parameters.Add(new SqlParameter("@timeofprocess", _tmpObject.TIMEOFPROCESS));
command.Parameters.Add(new SqlParameter("@weekofprocess", _tmpObject.WEEKOFPROCESS));
command.Parameters.Add(new SqlParameter("@monthofprocess", _tmpObject.MONTHOFPROCESS));
command.Parameters.Add(new SqlParameter("@yearofprocess", _tmpObject.YEAROFPROCESS));
command.Parameters.Add(new SqlParameter("@id_document", _tmpObject.ID_DOCUMENT));
command.Parameters.Add(new SqlParameter("@documentssource", _tmpObject.DOCUMENTSSOURCE));
command.Parameters.Add(new SqlParameter("@filesource", _tmpObject.FILESOURCE));
command.Parameters.Add(new SqlParameter("@description1", _tmpObject.DESCRIPTION1));
command.Parameters.Add(new SqlParameter("@description2", _tmpObject.DESCRIPTION2));
command.Parameters.Add(new SqlParameter("@id_relatedentity", _tmpObject.ID_RELATEDENTITY));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@idprocess", _tmpObject.IDPROCESS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(process _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(process _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM process  WHERE idprocess=@idprocess", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idprocess", _tmpObject.IDPROCESS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public process GetById(int _id)
{
process tmpObject = new process();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From process WHERE idprocess=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROCESS = (System.Int32)dr["idprocess"];
tmpObject.TYPEOFPROCESS = (System.Int32)dr["typeofprocess"];
tmpObject.ID_LOCATION = (System.String)dr["id_location"];
tmpObject.ID_ENTITY = (System.String)dr["id_entity"];
tmpObject.QTY = (System.Decimal)dr["qty"];
tmpObject.VALUEPERUNIT = (System.Decimal)dr["valueperunit"];
tmpObject.TOTALVALUE = (System.Decimal)dr["totalvalue"];
tmpObject.DATEOFPROCESS = (System.DateTime)dr["dateofprocess"];
tmpObject.TIMEOFPROCESS = (System.TimeSpan)dr["timeofprocess"];
tmpObject.WEEKOFPROCESS = (System.Int32)dr["weekofprocess"];
tmpObject.MONTHOFPROCESS = (System.Int32)dr["monthofprocess"];
tmpObject.YEAROFPROCESS = (System.Int32)dr["yearofprocess"];
tmpObject.ID_DOCUMENT = (System.String)dr["id_document"];
tmpObject.DOCUMENTSSOURCE = (System.String)dr["documentssource"];
tmpObject.FILESOURCE = (System.String)dr["filesource"];
tmpObject.DESCRIPTION1 = (System.String)dr["description1"];
tmpObject.DESCRIPTION2 = (System.String)dr["description2"];
tmpObject.ID_RELATEDENTITY = (System.String)dr["id_relatedentity"];
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
public List<process> GetAll()
{
List<process> tmpList = new List<process>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From process", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
process tmpObject = new process();
msgRecField="-";
msgRecField=msgRecField + "idprocess=";
msgRecField=msgRecField + dr["idprocess"].ToString() +"=";
tmpObject.IDPROCESS = (System.Int32)dr["idprocess"];
msgRecField=msgRecField + "typeofprocess=";
msgRecField=msgRecField + dr["typeofprocess"].ToString() +"=";
tmpObject.TYPEOFPROCESS = (System.Int32)dr["typeofprocess"];
msgRecField=msgRecField + "id_location=";
msgRecField=msgRecField + dr["id_location"].ToString() +"=";
tmpObject.ID_LOCATION = (System.String)dr["id_location"];
msgRecField=msgRecField + "id_entity=";
msgRecField=msgRecField + dr["id_entity"].ToString() +"=";
tmpObject.ID_ENTITY = (System.String)dr["id_entity"];
msgRecField=msgRecField + "qty=";
msgRecField=msgRecField + dr["qty"].ToString() +"=";
tmpObject.QTY = (System.Decimal)dr["qty"];
msgRecField=msgRecField + "valueperunit=";
msgRecField=msgRecField + dr["valueperunit"].ToString() +"=";
tmpObject.VALUEPERUNIT = (System.Decimal)dr["valueperunit"];
msgRecField=msgRecField + "totalvalue=";
msgRecField=msgRecField + dr["totalvalue"].ToString() +"=";
tmpObject.TOTALVALUE = (System.Decimal)dr["totalvalue"];
msgRecField=msgRecField + "dateofprocess=";
msgRecField=msgRecField + dr["dateofprocess"].ToString() +"=";
tmpObject.DATEOFPROCESS = (System.DateTime)dr["dateofprocess"];
msgRecField=msgRecField + "timeofprocess=";
msgRecField=msgRecField + dr["timeofprocess"].ToString() +"=";
tmpObject.TIMEOFPROCESS = (System.TimeSpan)dr["timeofprocess"];
msgRecField=msgRecField + "weekofprocess=";
msgRecField=msgRecField + dr["weekofprocess"].ToString() +"=";
tmpObject.WEEKOFPROCESS = (System.Int32)dr["weekofprocess"];
msgRecField=msgRecField + "monthofprocess=";
msgRecField=msgRecField + dr["monthofprocess"].ToString() +"=";
tmpObject.MONTHOFPROCESS = (System.Int32)dr["monthofprocess"];
msgRecField=msgRecField + "yearofprocess=";
msgRecField=msgRecField + dr["yearofprocess"].ToString() +"=";
tmpObject.YEAROFPROCESS = (System.Int32)dr["yearofprocess"];
msgRecField=msgRecField + "id_document=";
msgRecField=msgRecField + dr["id_document"].ToString() +"=";
tmpObject.ID_DOCUMENT = (System.String)dr["id_document"];
msgRecField=msgRecField + "documentssource=";
msgRecField=msgRecField + dr["documentssource"].ToString() +"=";
tmpObject.DOCUMENTSSOURCE = (System.String)dr["documentssource"];
msgRecField=msgRecField + "filesource=";
msgRecField=msgRecField + dr["filesource"].ToString() +"=";
tmpObject.FILESOURCE = (System.String)dr["filesource"];
msgRecField=msgRecField + "description1=";
msgRecField=msgRecField + dr["description1"].ToString() +"=";
tmpObject.DESCRIPTION1 = (System.String)dr["description1"];
msgRecField=msgRecField + "description2=";
msgRecField=msgRecField + dr["description2"].ToString() +"=";
tmpObject.DESCRIPTION2 = (System.String)dr["description2"];
msgRecField=msgRecField + "id_relatedentity=";
msgRecField=msgRecField + dr["id_relatedentity"].ToString() +"=";
tmpObject.ID_RELATEDENTITY = (System.String)dr["id_relatedentity"];
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
public List<process> GetAllByCond(string cond)
{
List<process> tmpList = new List<process>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From process Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
process tmpObject = new process();
msgRecField="-";
msgRecField=msgRecField + "idprocess=";
msgRecField=msgRecField + dr["idprocess"].ToString() +"=";
tmpObject.IDPROCESS = (System.Int32)dr["idprocess"];
msgRecField=msgRecField + "typeofprocess=";
msgRecField=msgRecField + dr["typeofprocess"].ToString() +"=";
tmpObject.TYPEOFPROCESS = (System.Int32)dr["typeofprocess"];
msgRecField=msgRecField + "id_location=";
msgRecField=msgRecField + dr["id_location"].ToString() +"=";
tmpObject.ID_LOCATION = (System.String)dr["id_location"];
msgRecField=msgRecField + "id_entity=";
msgRecField=msgRecField + dr["id_entity"].ToString() +"=";
tmpObject.ID_ENTITY = (System.String)dr["id_entity"];
msgRecField=msgRecField + "qty=";
msgRecField=msgRecField + dr["qty"].ToString() +"=";
tmpObject.QTY = (System.Decimal)dr["qty"];
msgRecField=msgRecField + "valueperunit=";
msgRecField=msgRecField + dr["valueperunit"].ToString() +"=";
tmpObject.VALUEPERUNIT = (System.Decimal)dr["valueperunit"];
msgRecField=msgRecField + "totalvalue=";
msgRecField=msgRecField + dr["totalvalue"].ToString() +"=";
tmpObject.TOTALVALUE = (System.Decimal)dr["totalvalue"];
msgRecField=msgRecField + "dateofprocess=";
msgRecField=msgRecField + dr["dateofprocess"].ToString() +"=";
tmpObject.DATEOFPROCESS = (System.DateTime)dr["dateofprocess"];
msgRecField=msgRecField + "timeofprocess=";
msgRecField=msgRecField + dr["timeofprocess"].ToString() +"=";
tmpObject.TIMEOFPROCESS = (System.TimeSpan)dr["timeofprocess"];
msgRecField=msgRecField + "weekofprocess=";
msgRecField=msgRecField + dr["weekofprocess"].ToString() +"=";
tmpObject.WEEKOFPROCESS = (System.Int32)dr["weekofprocess"];
msgRecField=msgRecField + "monthofprocess=";
msgRecField=msgRecField + dr["monthofprocess"].ToString() +"=";
tmpObject.MONTHOFPROCESS = (System.Int32)dr["monthofprocess"];
msgRecField=msgRecField + "yearofprocess=";
msgRecField=msgRecField + dr["yearofprocess"].ToString() +"=";
tmpObject.YEAROFPROCESS = (System.Int32)dr["yearofprocess"];
msgRecField=msgRecField + "id_document=";
msgRecField=msgRecField + dr["id_document"].ToString() +"=";
tmpObject.ID_DOCUMENT = (System.String)dr["id_document"];
msgRecField=msgRecField + "documentssource=";
msgRecField=msgRecField + dr["documentssource"].ToString() +"=";
tmpObject.DOCUMENTSSOURCE = (System.String)dr["documentssource"];
msgRecField=msgRecField + "filesource=";
msgRecField=msgRecField + dr["filesource"].ToString() +"=";
tmpObject.FILESOURCE = (System.String)dr["filesource"];
msgRecField=msgRecField + "description1=";
msgRecField=msgRecField + dr["description1"].ToString() +"=";
tmpObject.DESCRIPTION1 = (System.String)dr["description1"];
msgRecField=msgRecField + "description2=";
msgRecField=msgRecField + dr["description2"].ToString() +"=";
tmpObject.DESCRIPTION2 = (System.String)dr["description2"];
msgRecField=msgRecField + "id_relatedentity=";
msgRecField=msgRecField + dr["id_relatedentity"].ToString() +"=";
tmpObject.ID_RELATEDENTITY = (System.String)dr["id_relatedentity"];
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
 
