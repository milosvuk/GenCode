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
 
public class DB_propertycustomerdetails
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_propertycustomerdetails()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(propertycustomerdetails _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(propertycustomerdetails _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO propertycustomerdetails (id_propertycustomer,datefrom,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,active) VALUES (@id_propertycustomer,@datefrom,@dateto,@numberofdaystocreateinvoice,@amountforthatperiod,@amountpereachinvoice,@description,@numberofinvoicestogenerate,@generatedinvoicesfromthis,@active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_propertycustomer", _tmpObject.ID_PROPERTYCUSTOMER));
command.Parameters.Add(new SqlParameter("@datefrom", _tmpObject.DATEFROM));
command.Parameters.Add(new SqlParameter("@dateto", _tmpObject.DATETO));
command.Parameters.Add(new SqlParameter("@numberofdaystocreateinvoice", _tmpObject.NUMBEROFDAYSTOCREATEINVOICE));
command.Parameters.Add(new SqlParameter("@amountforthatperiod", _tmpObject.AMOUNTFORTHATPERIOD));
command.Parameters.Add(new SqlParameter("@amountpereachinvoice", _tmpObject.AMOUNTPEREACHINVOICE));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@numberofinvoicestogenerate", _tmpObject.NUMBEROFINVOICESTOGENERATE));
command.Parameters.Add(new SqlParameter("@generatedinvoicesfromthis", _tmpObject.GENERATEDINVOICESFROMTHIS));
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
 
public int Update(propertycustomerdetails _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(propertycustomerdetails _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE propertycustomerdetails SET id_propertycustomer=@id_propertycustomer,datefrom=@datefrom,dateto=@dateto,numberofdaystocreateinvoice=@numberofdaystocreateinvoice,amountforthatperiod=@amountforthatperiod,amountpereachinvoice=@amountpereachinvoice,description=@description,numberofinvoicestogenerate=@numberofinvoicestogenerate,generatedinvoicesfromthis=@generatedinvoicesfromthis,active=@active  WHERE idpropertcustomerdetails=@idpropertcustomerdetails", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_propertycustomer", _tmpObject.ID_PROPERTYCUSTOMER));
command.Parameters.Add(new SqlParameter("@datefrom", _tmpObject.DATEFROM));
command.Parameters.Add(new SqlParameter("@dateto", _tmpObject.DATETO));
command.Parameters.Add(new SqlParameter("@numberofdaystocreateinvoice", _tmpObject.NUMBEROFDAYSTOCREATEINVOICE));
command.Parameters.Add(new SqlParameter("@amountforthatperiod", _tmpObject.AMOUNTFORTHATPERIOD));
command.Parameters.Add(new SqlParameter("@amountpereachinvoice", _tmpObject.AMOUNTPEREACHINVOICE));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@numberofinvoicestogenerate", _tmpObject.NUMBEROFINVOICESTOGENERATE));
command.Parameters.Add(new SqlParameter("@generatedinvoicesfromthis", _tmpObject.GENERATEDINVOICESFROMTHIS));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idpropertcustomerdetails", _tmpObject.IDPROPERTCUSTOMERDETAILS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(propertycustomerdetails _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(propertycustomerdetails _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE propertycustomerdetails  WHERE idpropertcustomerdetails=@idpropertcustomerdetails", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idpropertcustomerdetails", _tmpObject.IDPROPERTCUSTOMERDETAILS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public propertycustomerdetails GetById(int _id)
{
propertycustomerdetails tmpObject = new propertycustomerdetails();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerdetails WHERE idpropertcustomerdetails=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROPERTCUSTOMERDETAILS = (System.Int32)dr["idpropertcustomerdetails"];
tmpObject.ID_PROPERTYCUSTOMER = (System.Int32)dr["id_propertycustomer"];
tmpObject.DATEFROM = (System.DateTime)dr["datefrom"];
tmpObject.DATETO = (System.DateTime)dr["dateto"];
tmpObject.NUMBEROFDAYSTOCREATEINVOICE = (System.Int32)dr["numberofdaystocreateinvoice"];
tmpObject.AMOUNTFORTHATPERIOD = (System.Decimal)dr["amountforthatperiod"];
tmpObject.AMOUNTPEREACHINVOICE = (System.Decimal)dr["amountpereachinvoice"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpObject.NUMBEROFINVOICESTOGENERATE = (System.Int32)dr["numberofinvoicestogenerate"];
tmpObject.GENERATEDINVOICESFROMTHIS = (System.String)dr["generatedinvoicesfromthis"];
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
public List<propertycustomerdetails> GetAll()
{
List<propertycustomerdetails> tmpList = new List<propertycustomerdetails>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerdetails", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomerdetails tmpObject = new propertycustomerdetails();
msgRecField="-";
msgRecField=msgRecField + "idpropertcustomerdetails=";
msgRecField=msgRecField + dr["idpropertcustomerdetails"].ToString() +"=";
tmpObject.IDPROPERTCUSTOMERDETAILS = (System.Int32)dr["idpropertcustomerdetails"];
msgRecField=msgRecField + "id_propertycustomer=";
msgRecField=msgRecField + dr["id_propertycustomer"].ToString() +"=";
tmpObject.ID_PROPERTYCUSTOMER = (System.Int32)dr["id_propertycustomer"];
msgRecField=msgRecField + "datefrom=";
msgRecField=msgRecField + dr["datefrom"].ToString() +"=";
tmpObject.DATEFROM = (System.DateTime)dr["datefrom"];
msgRecField=msgRecField + "dateto=";
msgRecField=msgRecField + dr["dateto"].ToString() +"=";
tmpObject.DATETO = (System.DateTime)dr["dateto"];
msgRecField=msgRecField + "numberofdaystocreateinvoice=";
msgRecField=msgRecField + dr["numberofdaystocreateinvoice"].ToString() +"=";
tmpObject.NUMBEROFDAYSTOCREATEINVOICE = (System.Int32)dr["numberofdaystocreateinvoice"];
msgRecField=msgRecField + "amountforthatperiod=";
msgRecField=msgRecField + dr["amountforthatperiod"].ToString() +"=";
tmpObject.AMOUNTFORTHATPERIOD = (System.Decimal)dr["amountforthatperiod"];
msgRecField=msgRecField + "amountpereachinvoice=";
msgRecField=msgRecField + dr["amountpereachinvoice"].ToString() +"=";
tmpObject.AMOUNTPEREACHINVOICE = (System.Decimal)dr["amountpereachinvoice"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "numberofinvoicestogenerate=";
msgRecField=msgRecField + dr["numberofinvoicestogenerate"].ToString() +"=";
tmpObject.NUMBEROFINVOICESTOGENERATE = (System.Int32)dr["numberofinvoicestogenerate"];
msgRecField=msgRecField + "generatedinvoicesfromthis=";
msgRecField=msgRecField + dr["generatedinvoicesfromthis"].ToString() +"=";
tmpObject.GENERATEDINVOICESFROMTHIS = (System.String)dr["generatedinvoicesfromthis"];
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
public List<propertycustomerdetails> GetAllByCond(string cond)
{
List<propertycustomerdetails> tmpList = new List<propertycustomerdetails>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerdetails Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomerdetails tmpObject = new propertycustomerdetails();
msgRecField="-";
msgRecField=msgRecField + "idpropertcustomerdetails=";
msgRecField=msgRecField + dr["idpropertcustomerdetails"].ToString() +"=";
tmpObject.IDPROPERTCUSTOMERDETAILS = (System.Int32)dr["idpropertcustomerdetails"];
msgRecField=msgRecField + "id_propertycustomer=";
msgRecField=msgRecField + dr["id_propertycustomer"].ToString() +"=";
tmpObject.ID_PROPERTYCUSTOMER = (System.Int32)dr["id_propertycustomer"];
msgRecField=msgRecField + "datefrom=";
msgRecField=msgRecField + dr["datefrom"].ToString() +"=";
tmpObject.DATEFROM = (System.DateTime)dr["datefrom"];
msgRecField=msgRecField + "dateto=";
msgRecField=msgRecField + dr["dateto"].ToString() +"=";
tmpObject.DATETO = (System.DateTime)dr["dateto"];
msgRecField=msgRecField + "numberofdaystocreateinvoice=";
msgRecField=msgRecField + dr["numberofdaystocreateinvoice"].ToString() +"=";
tmpObject.NUMBEROFDAYSTOCREATEINVOICE = (System.Int32)dr["numberofdaystocreateinvoice"];
msgRecField=msgRecField + "amountforthatperiod=";
msgRecField=msgRecField + dr["amountforthatperiod"].ToString() +"=";
tmpObject.AMOUNTFORTHATPERIOD = (System.Decimal)dr["amountforthatperiod"];
msgRecField=msgRecField + "amountpereachinvoice=";
msgRecField=msgRecField + dr["amountpereachinvoice"].ToString() +"=";
tmpObject.AMOUNTPEREACHINVOICE = (System.Decimal)dr["amountpereachinvoice"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
msgRecField=msgRecField + "numberofinvoicestogenerate=";
msgRecField=msgRecField + dr["numberofinvoicestogenerate"].ToString() +"=";
tmpObject.NUMBEROFINVOICESTOGENERATE = (System.Int32)dr["numberofinvoicestogenerate"];
msgRecField=msgRecField + "generatedinvoicesfromthis=";
msgRecField=msgRecField + dr["generatedinvoicesfromthis"].ToString() +"=";
tmpObject.GENERATEDINVOICESFROMTHIS = (System.String)dr["generatedinvoicesfromthis"];
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
 
