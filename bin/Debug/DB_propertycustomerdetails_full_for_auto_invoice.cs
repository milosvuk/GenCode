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
 
public class DB_propertycustomerdetails_full_for_auto_invoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_propertycustomerdetails_full_for_auto_invoice()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(propertycustomerdetails_full_for_auto_invoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(propertycustomerdetails_full_for_auto_invoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO propertycustomerdetails_full_for_auto_invoice (idCustomer,LeaseAgDateFrom,LeaseAgDateTo,idNotary,DateOfAg,Active,datefrom,idpropertcustomerdetails,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,idPropertyCustomer,CustomerFullName,Address1,Address2,Address3,Contact,PropertyDescription,CodeOfProperty,GroundRentAddressTo,GroudRentPaidTo,GroundRentDueTo) VALUES (@idCustomer,@LeaseAgDateFrom,@LeaseAgDateTo,@idNotary,@DateOfAg,@Active,@datefrom,@idpropertcustomerdetails,@dateto,@numberofdaystocreateinvoice,@amountforthatperiod,@amountpereachinvoice,@description,@numberofinvoicestogenerate,@generatedinvoicesfromthis,@idPropertyCustomer,@CustomerFullName,@Address1,@Address2,@Address3,@Contact,@PropertyDescription,@CodeOfProperty,@GroundRentAddressTo,@GroudRentPaidTo,@GroundRentDueTo) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idCustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@LeaseAgDateFrom", _tmpObject.LEASEAGDATEFROM));
command.Parameters.Add(new SqlParameter("@LeaseAgDateTo", _tmpObject.LEASEAGDATETO));
command.Parameters.Add(new SqlParameter("@idNotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@DateOfAg", _tmpObject.DATEOFAG));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@datefrom", _tmpObject.DATEFROM));
command.Parameters.Add(new SqlParameter("@idpropertcustomerdetails", _tmpObject.IDPROPERTCUSTOMERDETAILS));
command.Parameters.Add(new SqlParameter("@dateto", _tmpObject.DATETO));
command.Parameters.Add(new SqlParameter("@numberofdaystocreateinvoice", _tmpObject.NUMBEROFDAYSTOCREATEINVOICE));
command.Parameters.Add(new SqlParameter("@amountforthatperiod", _tmpObject.AMOUNTFORTHATPERIOD));
command.Parameters.Add(new SqlParameter("@amountpereachinvoice", _tmpObject.AMOUNTPEREACHINVOICE));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@numberofinvoicestogenerate", _tmpObject.NUMBEROFINVOICESTOGENERATE));
command.Parameters.Add(new SqlParameter("@generatedinvoicesfromthis", _tmpObject.GENERATEDINVOICESFROMTHIS));
command.Parameters.Add(new SqlParameter("@idPropertyCustomer", _tmpObject.IDPROPERTYCUSTOMER));
command.Parameters.Add(new SqlParameter("@CustomerFullName", _tmpObject.CUSTOMERFULLNAME));
command.Parameters.Add(new SqlParameter("@Address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@Address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@Address3", _tmpObject.ADDRESS3));
command.Parameters.Add(new SqlParameter("@Contact", _tmpObject.CONTACT));
command.Parameters.Add(new SqlParameter("@PropertyDescription", _tmpObject.PROPERTYDESCRIPTION));
command.Parameters.Add(new SqlParameter("@CodeOfProperty", _tmpObject.CODEOFPROPERTY));
command.Parameters.Add(new SqlParameter("@GroundRentAddressTo", _tmpObject.GROUNDRENTADDRESSTO));
command.Parameters.Add(new SqlParameter("@GroudRentPaidTo", _tmpObject.GROUDRENTPAIDTO));
command.Parameters.Add(new SqlParameter("@GroundRentDueTo", _tmpObject.GROUNDRENTDUETO));
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
 
public int Update(propertycustomerdetails_full_for_auto_invoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(propertycustomerdetails_full_for_auto_invoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE propertycustomerdetails_full_for_auto_invoice SET idCustomer=@idcustomer,LeaseAgDateFrom=@leaseagdatefrom,LeaseAgDateTo=@leaseagdateto,idNotary=@idnotary,DateOfAg=@dateofag,Active=@active,datefrom=@datefrom,idpropertcustomerdetails=@idpropertcustomerdetails,dateto=@dateto,numberofdaystocreateinvoice=@numberofdaystocreateinvoice,amountforthatperiod=@amountforthatperiod,amountpereachinvoice=@amountpereachinvoice,description=@description,numberofinvoicestogenerate=@numberofinvoicestogenerate,generatedinvoicesfromthis=@generatedinvoicesfromthis,idPropertyCustomer=@idpropertycustomer,CustomerFullName=@customerfullname,Address1=@address1,Address2=@address2,Address3=@address3,Contact=@contact,PropertyDescription=@propertydescription,CodeOfProperty=@codeofproperty,GroundRentAddressTo=@groundrentaddressto,GroudRentPaidTo=@groudrentpaidto,GroundRentDueTo=@groundrentdueto  WHERE idProperty=@idproperty", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@leaseagdatefrom", _tmpObject.LEASEAGDATEFROM));
command.Parameters.Add(new SqlParameter("@leaseagdateto", _tmpObject.LEASEAGDATETO));
command.Parameters.Add(new SqlParameter("@idnotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@dateofag", _tmpObject.DATEOFAG));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@datefrom", _tmpObject.DATEFROM));
command.Parameters.Add(new SqlParameter("@idpropertcustomerdetails", _tmpObject.IDPROPERTCUSTOMERDETAILS));
command.Parameters.Add(new SqlParameter("@dateto", _tmpObject.DATETO));
command.Parameters.Add(new SqlParameter("@numberofdaystocreateinvoice", _tmpObject.NUMBEROFDAYSTOCREATEINVOICE));
command.Parameters.Add(new SqlParameter("@amountforthatperiod", _tmpObject.AMOUNTFORTHATPERIOD));
command.Parameters.Add(new SqlParameter("@amountpereachinvoice", _tmpObject.AMOUNTPEREACHINVOICE));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@numberofinvoicestogenerate", _tmpObject.NUMBEROFINVOICESTOGENERATE));
command.Parameters.Add(new SqlParameter("@generatedinvoicesfromthis", _tmpObject.GENERATEDINVOICESFROMTHIS));
command.Parameters.Add(new SqlParameter("@idpropertycustomer", _tmpObject.IDPROPERTYCUSTOMER));
command.Parameters.Add(new SqlParameter("@customerfullname", _tmpObject.CUSTOMERFULLNAME));
command.Parameters.Add(new SqlParameter("@address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@address3", _tmpObject.ADDRESS3));
command.Parameters.Add(new SqlParameter("@contact", _tmpObject.CONTACT));
command.Parameters.Add(new SqlParameter("@propertydescription", _tmpObject.PROPERTYDESCRIPTION));
command.Parameters.Add(new SqlParameter("@codeofproperty", _tmpObject.CODEOFPROPERTY));
command.Parameters.Add(new SqlParameter("@groundrentaddressto", _tmpObject.GROUNDRENTADDRESSTO));
command.Parameters.Add(new SqlParameter("@groudrentpaidto", _tmpObject.GROUDRENTPAIDTO));
command.Parameters.Add(new SqlParameter("@groundrentdueto", _tmpObject.GROUNDRENTDUETO));
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(propertycustomerdetails_full_for_auto_invoice _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(propertycustomerdetails_full_for_auto_invoice _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE propertycustomerdetails_full_for_auto_invoice  WHERE idProperty=@idproperty", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public propertycustomerdetails_full_for_auto_invoice GetById(int _id)
{
propertycustomerdetails_full_for_auto_invoice tmpObject = new propertycustomerdetails_full_for_auto_invoice();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerdetails_full_for_auto_invoice WHERE idProperty=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
tmpObject.LEASEAGDATEFROM = (System.DateTime)dr["LeaseAgDateFrom"];
tmpObject.LEASEAGDATETO = (System.DateTime)dr["LeaseAgDateTo"];
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
tmpObject.DATEOFAG = (System.DateTime)dr["DateOfAg"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
tmpObject.DATEFROM = (System.DateTime)dr["datefrom"];
tmpObject.IDPROPERTCUSTOMERDETAILS = (System.Int32)dr["idpropertcustomerdetails"];
tmpObject.DATETO = (System.DateTime)dr["dateto"];
tmpObject.NUMBEROFDAYSTOCREATEINVOICE = (System.Int32)dr["numberofdaystocreateinvoice"];
tmpObject.AMOUNTFORTHATPERIOD = (System.Decimal)dr["amountforthatperiod"];
tmpObject.AMOUNTPEREACHINVOICE = (System.Decimal)dr["amountpereachinvoice"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpObject.NUMBEROFINVOICESTOGENERATE = (System.Int32)dr["numberofinvoicestogenerate"];
tmpObject.GENERATEDINVOICESFROMTHIS = (System.String)dr["generatedinvoicesfromthis"];
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
tmpObject.CUSTOMERFULLNAME = (System.String)dr["CustomerFullName"];
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
tmpObject.CONTACT = (System.String)dr["Contact"];
tmpObject.PROPERTYDESCRIPTION = (System.String)dr["PropertyDescription"];
tmpObject.CODEOFPROPERTY = (System.String)dr["CodeOfProperty"];
tmpObject.GROUNDRENTADDRESSTO = (System.String)dr["GroundRentAddressTo"];
tmpObject.GROUDRENTPAIDTO = (System.String)dr["GroudRentPaidTo"];
tmpObject.GROUNDRENTDUETO = (System.DateTime)dr["GroundRentDueTo"];
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
public List<propertycustomerdetails_full_for_auto_invoice> GetAll()
{
List<propertycustomerdetails_full_for_auto_invoice> tmpList = new List<propertycustomerdetails_full_for_auto_invoice>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerdetails_full_for_auto_invoice", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomerdetails_full_for_auto_invoice tmpObject = new propertycustomerdetails_full_for_auto_invoice();
msgRecField="-";
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "LeaseAgDateFrom=";
msgRecField=msgRecField + dr["LeaseAgDateFrom"].ToString() +"=";
tmpObject.LEASEAGDATEFROM = (System.DateTime)dr["LeaseAgDateFrom"];
msgRecField=msgRecField + "LeaseAgDateTo=";
msgRecField=msgRecField + dr["LeaseAgDateTo"].ToString() +"=";
tmpObject.LEASEAGDATETO = (System.DateTime)dr["LeaseAgDateTo"];
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "DateOfAg=";
msgRecField=msgRecField + dr["DateOfAg"].ToString() +"=";
tmpObject.DATEOFAG = (System.DateTime)dr["DateOfAg"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
msgRecField=msgRecField + "datefrom=";
msgRecField=msgRecField + dr["datefrom"].ToString() +"=";
tmpObject.DATEFROM = (System.DateTime)dr["datefrom"];
msgRecField=msgRecField + "idpropertcustomerdetails=";
msgRecField=msgRecField + dr["idpropertcustomerdetails"].ToString() +"=";
tmpObject.IDPROPERTCUSTOMERDETAILS = (System.Int32)dr["idpropertcustomerdetails"];
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
msgRecField=msgRecField + "idPropertyCustomer=";
msgRecField=msgRecField + dr["idPropertyCustomer"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
msgRecField=msgRecField + "CustomerFullName=";
msgRecField=msgRecField + dr["CustomerFullName"].ToString() +"=";
tmpObject.CUSTOMERFULLNAME = (System.String)dr["CustomerFullName"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address3=";
msgRecField=msgRecField + dr["Address3"].ToString() +"=";
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
msgRecField=msgRecField + "Contact=";
msgRecField=msgRecField + dr["Contact"].ToString() +"=";
tmpObject.CONTACT = (System.String)dr["Contact"];
msgRecField=msgRecField + "PropertyDescription=";
msgRecField=msgRecField + dr["PropertyDescription"].ToString() +"=";
tmpObject.PROPERTYDESCRIPTION = (System.String)dr["PropertyDescription"];
msgRecField=msgRecField + "CodeOfProperty=";
msgRecField=msgRecField + dr["CodeOfProperty"].ToString() +"=";
tmpObject.CODEOFPROPERTY = (System.String)dr["CodeOfProperty"];
msgRecField=msgRecField + "GroundRentAddressTo=";
msgRecField=msgRecField + dr["GroundRentAddressTo"].ToString() +"=";
tmpObject.GROUNDRENTADDRESSTO = (System.String)dr["GroundRentAddressTo"];
msgRecField=msgRecField + "GroudRentPaidTo=";
msgRecField=msgRecField + dr["GroudRentPaidTo"].ToString() +"=";
tmpObject.GROUDRENTPAIDTO = (System.String)dr["GroudRentPaidTo"];
msgRecField=msgRecField + "GroundRentDueTo=";
msgRecField=msgRecField + dr["GroundRentDueTo"].ToString() +"=";
tmpObject.GROUNDRENTDUETO = (System.DateTime)dr["GroundRentDueTo"];
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
public List<propertycustomerdetails_full_for_auto_invoice> GetAllByCond(string cond)
{
List<propertycustomerdetails_full_for_auto_invoice> tmpList = new List<propertycustomerdetails_full_for_auto_invoice>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomerdetails_full_for_auto_invoice Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomerdetails_full_for_auto_invoice tmpObject = new propertycustomerdetails_full_for_auto_invoice();
msgRecField="-";
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "LeaseAgDateFrom=";
msgRecField=msgRecField + dr["LeaseAgDateFrom"].ToString() +"=";
tmpObject.LEASEAGDATEFROM = (System.DateTime)dr["LeaseAgDateFrom"];
msgRecField=msgRecField + "LeaseAgDateTo=";
msgRecField=msgRecField + dr["LeaseAgDateTo"].ToString() +"=";
tmpObject.LEASEAGDATETO = (System.DateTime)dr["LeaseAgDateTo"];
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "DateOfAg=";
msgRecField=msgRecField + dr["DateOfAg"].ToString() +"=";
tmpObject.DATEOFAG = (System.DateTime)dr["DateOfAg"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
msgRecField=msgRecField + "datefrom=";
msgRecField=msgRecField + dr["datefrom"].ToString() +"=";
tmpObject.DATEFROM = (System.DateTime)dr["datefrom"];
msgRecField=msgRecField + "idpropertcustomerdetails=";
msgRecField=msgRecField + dr["idpropertcustomerdetails"].ToString() +"=";
tmpObject.IDPROPERTCUSTOMERDETAILS = (System.Int32)dr["idpropertcustomerdetails"];
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
msgRecField=msgRecField + "idPropertyCustomer=";
msgRecField=msgRecField + dr["idPropertyCustomer"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
msgRecField=msgRecField + "CustomerFullName=";
msgRecField=msgRecField + dr["CustomerFullName"].ToString() +"=";
tmpObject.CUSTOMERFULLNAME = (System.String)dr["CustomerFullName"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address3=";
msgRecField=msgRecField + dr["Address3"].ToString() +"=";
tmpObject.ADDRESS3 = (System.String)dr["Address3"];
msgRecField=msgRecField + "Contact=";
msgRecField=msgRecField + dr["Contact"].ToString() +"=";
tmpObject.CONTACT = (System.String)dr["Contact"];
msgRecField=msgRecField + "PropertyDescription=";
msgRecField=msgRecField + dr["PropertyDescription"].ToString() +"=";
tmpObject.PROPERTYDESCRIPTION = (System.String)dr["PropertyDescription"];
msgRecField=msgRecField + "CodeOfProperty=";
msgRecField=msgRecField + dr["CodeOfProperty"].ToString() +"=";
tmpObject.CODEOFPROPERTY = (System.String)dr["CodeOfProperty"];
msgRecField=msgRecField + "GroundRentAddressTo=";
msgRecField=msgRecField + dr["GroundRentAddressTo"].ToString() +"=";
tmpObject.GROUNDRENTADDRESSTO = (System.String)dr["GroundRentAddressTo"];
msgRecField=msgRecField + "GroudRentPaidTo=";
msgRecField=msgRecField + dr["GroudRentPaidTo"].ToString() +"=";
tmpObject.GROUDRENTPAIDTO = (System.String)dr["GroudRentPaidTo"];
msgRecField=msgRecField + "GroundRentDueTo=";
msgRecField=msgRecField + dr["GroundRentDueTo"].ToString() +"=";
tmpObject.GROUNDRENTDUETO = (System.DateTime)dr["GroundRentDueTo"];
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
 
