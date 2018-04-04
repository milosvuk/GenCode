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
 
public class propertycustomerdetails_full_for_auto_invoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomerdetails_full_for_auto_invoice()
{
 
  
 
}
 
public propertycustomerdetails_full_for_auto_invoice (System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _leaseagdatefrom,System.DateTime _leaseagdateto,System.Int32 _idnotary,System.DateTime _dateofag,System.Int32 _active,System.DateTime _datefrom,System.Int32 _idpropertcustomerdetails,System.DateTime _dateto,System.Int32 _numberofdaystocreateinvoice,System.Decimal _amountforthatperiod,System.Decimal _amountpereachinvoice,System.String _description,System.Int32 _numberofinvoicestogenerate,System.String _generatedinvoicesfromthis,System.Int32 _idpropertycustomer,System.String _customerfullname,System.String _address1,System.String _address2,System.String _address3,System.String _contact,System.String _propertydescription,System.String _codeofproperty,System.String _groundrentaddressto,System.String _groudrentpaidto,System.DateTime _groundrentdueto )
{
idproperty=_idproperty;
idcustomer=_idcustomer;
leaseagdatefrom=_leaseagdatefrom;
leaseagdateto=_leaseagdateto;
idnotary=_idnotary;
dateofag=_dateofag;
active=_active;
datefrom=_datefrom;
idpropertcustomerdetails=_idpropertcustomerdetails;
dateto=_dateto;
numberofdaystocreateinvoice=_numberofdaystocreateinvoice;
amountforthatperiod=_amountforthatperiod;
amountpereachinvoice=_amountpereachinvoice;
description=_description;
numberofinvoicestogenerate=_numberofinvoicestogenerate;
generatedinvoicesfromthis=_generatedinvoicesfromthis;
idpropertycustomer=_idpropertycustomer;
customerfullname=_customerfullname;
address1=_address1;
address2=_address2;
address3=_address3;
contact=_contact;
propertydescription=_propertydescription;
codeofproperty=_codeofproperty;
groundrentaddressto=_groundrentaddressto;
groudrentpaidto=_groudrentpaidto;
groundrentdueto=_groundrentdueto;
}
 
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
}
}
 
private System.Int32 idcustomer;
 
public System.Int32 IDCUSTOMER
{
get
{
return idcustomer;
}
set
{
idcustomer=value;
}
}
 
private System.DateTime leaseagdatefrom;
 
public System.DateTime LEASEAGDATEFROM
{
get
{
return leaseagdatefrom;
}
set
{
leaseagdatefrom=value;
}
}
 
private System.DateTime leaseagdateto;
 
public System.DateTime LEASEAGDATETO
{
get
{
return leaseagdateto;
}
set
{
leaseagdateto=value;
}
}
 
private System.Int32 idnotary;
 
public System.Int32 IDNOTARY
{
get
{
return idnotary;
}
set
{
idnotary=value;
}
}
 
private System.DateTime dateofag;
 
public System.DateTime DATEOFAG
{
get
{
return dateofag;
}
set
{
dateofag=value;
}
}
 
private System.Int32 active;
 
public System.Int32 ACTIVE
{
get
{
return active;
}
set
{
active=value;
}
}
 
private System.DateTime datefrom;
 
public System.DateTime DATEFROM
{
get
{
return datefrom;
}
set
{
datefrom=value;
}
}
 
private System.Int32 idpropertcustomerdetails;
 
public System.Int32 IDPROPERTCUSTOMERDETAILS
{
get
{
return idpropertcustomerdetails;
}
set
{
idpropertcustomerdetails=value;
}
}
 
private System.DateTime dateto;
 
public System.DateTime DATETO
{
get
{
return dateto;
}
set
{
dateto=value;
}
}
 
private System.Int32 numberofdaystocreateinvoice;
 
public System.Int32 NUMBEROFDAYSTOCREATEINVOICE
{
get
{
return numberofdaystocreateinvoice;
}
set
{
numberofdaystocreateinvoice=value;
}
}
 
private System.Decimal amountforthatperiod;
 
public System.Decimal AMOUNTFORTHATPERIOD
{
get
{
return amountforthatperiod;
}
set
{
amountforthatperiod=value;
}
}
 
private System.Decimal amountpereachinvoice;
 
public System.Decimal AMOUNTPEREACHINVOICE
{
get
{
return amountpereachinvoice;
}
set
{
amountpereachinvoice=value;
}
}
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
}
}
 
private System.Int32 numberofinvoicestogenerate;
 
public System.Int32 NUMBEROFINVOICESTOGENERATE
{
get
{
return numberofinvoicestogenerate;
}
set
{
numberofinvoicestogenerate=value;
}
}
 
private System.String generatedinvoicesfromthis;
 
public System.String GENERATEDINVOICESFROMTHIS
{
get
{
return generatedinvoicesfromthis;
}
set
{
generatedinvoicesfromthis=value;
}
}
 
private System.Int32 idpropertycustomer;
 
public System.Int32 IDPROPERTYCUSTOMER
{
get
{
return idpropertycustomer;
}
set
{
idpropertycustomer=value;
}
}
 
private System.String customerfullname;
 
public System.String CUSTOMERFULLNAME
{
get
{
return customerfullname;
}
set
{
customerfullname=value;
}
}
 
private System.String address1;
 
public System.String ADDRESS1
{
get
{
return address1;
}
set
{
address1=value;
}
}
 
private System.String address2;
 
public System.String ADDRESS2
{
get
{
return address2;
}
set
{
address2=value;
}
}
 
private System.String address3;
 
public System.String ADDRESS3
{
get
{
return address3;
}
set
{
address3=value;
}
}
 
private System.String contact;
 
public System.String CONTACT
{
get
{
return contact;
}
set
{
contact=value;
}
}
 
private System.String propertydescription;
 
public System.String PROPERTYDESCRIPTION
{
get
{
return propertydescription;
}
set
{
propertydescription=value;
}
}
 
private System.String codeofproperty;
 
public System.String CODEOFPROPERTY
{
get
{
return codeofproperty;
}
set
{
codeofproperty=value;
}
}
 
private System.String groundrentaddressto;
 
public System.String GROUNDRENTADDRESSTO
{
get
{
return groundrentaddressto;
}
set
{
groundrentaddressto=value;
}
}
 
private System.String groudrentpaidto;
 
public System.String GROUDRENTPAIDTO
{
get
{
return groudrentpaidto;
}
set
{
groudrentpaidto=value;
}
}
 
private System.DateTime groundrentdueto;
 
public System.DateTime GROUNDRENTDUETO
{
get
{
return groundrentdueto;
}
set
{
groundrentdueto=value;
}
}
 
 
public void New()
{
idproperty = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
 
public int InsertCommand()
{
// Use this InsertCommand with PrimaryKey Field which is not AutoIncement;
int numberinsert=0;
// INSERT INTO propertycustomerdetails_full_for_auto_invoice(idProperty,idCustomer,LeaseAgDateFrom,LeaseAgDateTo,idNotary,DateOfAg,Active,datefrom,idpropertcustomerdetails,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,idPropertyCustomer,CustomerFullName,Address1,Address2,Address3,Contact,PropertyDescription,CodeOfProperty,GroundRentAddressTo,GroudRentPaidTo,GroundRentDueTo ) VALUES(idproperty,idcustomer,leaseagdatefrom,leaseagdateto,idnotary,dateofag,active,datefrom,idpropertcustomerdetails,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,idpropertycustomer,customerfullname,address1,address2,address3,contact,propertydescription,codeofproperty,groundrentaddressto,groudrentpaidto,groundrentdueto );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO propertycustomerdetails_full_for_auto_invoice(idCustomer,LeaseAgDateFrom,LeaseAgDateTo,idNotary,DateOfAg,Active,datefrom,idpropertcustomerdetails,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,idPropertyCustomer,CustomerFullName,Address1,Address2,Address3,Contact,PropertyDescription,CodeOfProperty,GroundRentAddressTo,GroudRentPaidTo,GroundRentDueTo ) VALUES("+idcustomer.ToString()+(char)44+(char)39+leaseagdatefrom.ToString()+(char)39+(char)44+(char)39+leaseagdateto.ToString()+(char)39+(char)44+idnotary.ToString()+(char)44+(char)39+dateofag.ToString()+(char)39+(char)44+active.ToString()+(char)44+(char)39+datefrom.ToString()+(char)39+(char)44+idpropertcustomerdetails.ToString()+(char)44+(char)39+dateto.ToString()+(char)39+(char)44+numberofdaystocreateinvoice.ToString()+(char)44+amountforthatperiod.ToString()+(char)44+amountpereachinvoice.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+numberofinvoicestogenerate.ToString()+(char)44+(char)39+generatedinvoicesfromthis.ToString()+(char)39+(char)44+idpropertycustomer.ToString()+(char)44+(char)39+customerfullname.ToString()+(char)39+(char)44+(char)39+address1.ToString()+(char)39+(char)44+(char)39+address2.ToString()+(char)39+(char)44+(char)39+address3.ToString()+(char)39+(char)44+(char)39+contact.ToString()+(char)39+(char)44+(char)39+propertydescription.ToString()+(char)39+(char)44+(char)39+codeofproperty.ToString()+(char)39+(char)44+(char)39+groundrentaddressto.ToString()+(char)39+(char)44+(char)39+groudrentpaidto.ToString()+(char)39+(char)44+(char)39+groundrentdueto.ToString()+(char)39+(char)41;
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
ptl.DbaseSQLServer sqinsert = new ptl.DbaseSQLServer();
sqinsert.DbaseConnection = Con;
sqinsert.SqlText = minsert;
numberinsert = sqinsert.RunUpdateSQL();
sqinsert = null;
return numberinsert;
}
////==========================================================================
//START SAVE METHOD OF dm_arbiter ==============
////==========================================================================
public bool Save(propertycustomerdetails_full_for_auto_invoice _propertycustomerdetails_full_for_auto_invoice)
{
bool tmp = false;
int res = -1;
_propertycustomerdetails_full_for_auto_invoice.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_propertycustomerdetails_full_for_auto_invoice db_propertycustomerdetails_full_for_auto_invoice = new DB_propertycustomerdetails_full_for_auto_invoice();
if (_propertycustomerdetails_full_for_auto_invoice.IDPROPERTYCUSTOMERDETAILS_FULL_FOR_AUTO_INVOICE == 0)
{
res = db_propertycustomerdetails_full_for_auto_invoice.Add(_propertycustomerdetails_full_for_auto_invoice, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_propertycustomerdetails_full_for_auto_invoice.Update(_propertycustomerdetails_full_for_auto_invoice, conn, tran);
tran.Commit();
tmp = true;
}
}
catch
{
tran.Rollback();
tmp = false;
}
finally
{
conn.Close();
}
return tmp;
}
////==========================================================================
//END OF SAVE DM_ ==============
////==========================================================================
 
public int UpdateEditComand(string Con)
{
int numberedit=0;
string mupdate = "UPDATE propertycustomerdetails_full_for_auto_invoice SET "+"idCustomer="+idcustomer.ToString()+(char)44+"LeaseAgDateFrom="+(char)39+leaseagdatefrom.ToString()+(char)39+(char)44+"LeaseAgDateTo="+(char)39+leaseagdateto.ToString()+(char)39+(char)44+"idNotary="+idnotary.ToString()+(char)44+"DateOfAg="+(char)39+dateofag.ToString()+(char)39+(char)44+"Active="+active.ToString()+(char)44+"datefrom="+(char)39+datefrom.ToString()+(char)39+(char)44+"idpropertcustomerdetails="+idpropertcustomerdetails.ToString()+(char)44+"dateto="+(char)39+dateto.ToString()+(char)39+(char)44+"numberofdaystocreateinvoice="+numberofdaystocreateinvoice.ToString()+(char)44+"amountforthatperiod="+amountforthatperiod.ToString()+(char)44+"amountpereachinvoice="+amountpereachinvoice.ToString()+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"numberofinvoicestogenerate="+numberofinvoicestogenerate.ToString()+(char)44+"generatedinvoicesfromthis="+(char)39+generatedinvoicesfromthis.ToString()+(char)39+(char)44+"idPropertyCustomer="+idpropertycustomer.ToString()+(char)44+"CustomerFullName="+(char)39+customerfullname.ToString()+(char)39+(char)44+"Address1="+(char)39+address1.ToString()+(char)39+(char)44+"Address2="+(char)39+address2.ToString()+(char)39+(char)44+"Address3="+(char)39+address3.ToString()+(char)39+(char)44+"Contact="+(char)39+contact.ToString()+(char)39+(char)44+"PropertyDescription="+(char)39+propertydescription.ToString()+(char)39+(char)44+"CodeOfProperty="+(char)39+codeofproperty.ToString()+(char)39+(char)44+"GroundRentAddressTo="+(char)39+groundrentaddressto.ToString()+(char)39+(char)44+"GroudRentPaidTo="+(char)39+groudrentpaidto.ToString()+(char)39+(char)44+"GroundRentDueTo="+(char)39+groundrentdueto.ToString()+(char)39+" WHERE idProperty="+idproperty.ToString();
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = mupdate;
numberedit = sq.RunUpdateSQL();
sq = null;
return numberedit;
}
 
 
public int DeleteComand(string Con)
{
int numberdelete=0;
string del = "DELETE FROM propertycustomerdetails_full_for_auto_invoice WHERE idProperty="+idproperty.ToString();
 // idProperty=OldData[i].ToString() AND
 // idCustomer=OldData[i].ToString() AND
 // LeaseAgDateFrom=OldData[i].ToString() AND
 // LeaseAgDateTo=OldData[i].ToString() AND
 // idNotary=OldData[i].ToString() AND
 // DateOfAg=OldData[i].ToString() AND
 // Active=OldData[i].ToString() AND
 // datefrom=OldData[i].ToString() AND
 // idpropertcustomerdetails=OldData[i].ToString() AND
 // dateto=OldData[i].ToString() AND
 // numberofdaystocreateinvoice=OldData[i].ToString() AND
 // amountforthatperiod=OldData[i].ToString() AND
 // amountpereachinvoice=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // numberofinvoicestogenerate=OldData[i].ToString() AND
 // generatedinvoicesfromthis=OldData[i].ToString() AND
 // idPropertyCustomer=OldData[i].ToString() AND
 // CustomerFullName=OldData[i].ToString() AND
 // Address1=OldData[i].ToString() AND
 // Address2=OldData[i].ToString() AND
 // Address3=OldData[i].ToString() AND
 // Contact=OldData[i].ToString() AND
 // PropertyDescription=OldData[i].ToString() AND
 // CodeOfProperty=OldData[i].ToString() AND
 // GroundRentAddressTo=OldData[i].ToString() AND
 // GroudRentPaidTo=OldData[i].ToString() AND
 // GroundRentDueTo=OldData[i].ToString() AND
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = del;
numberdelete = sq.RunUpdateSQL();
sq = null;
return numberdelete;
}
 
 
public ArrayList SearchResultAsArrayList(string SearchExp, string Con)
{
ArrayList alsearch = new ArrayList();
string alistsearch = "SELECT * FROM propertycustomerdetails_full_for_auto_invoice " +SearchExp;
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = alistsearch;
alsearch = sq.RunViewSQL("|");
sq = null;
return alsearch;
}
 
 
public ArrayList GetAllDataAsArrayList(string Con)
{
ArrayList alsearch = new ArrayList();
string alistsearch = "SELECT * FROM propertycustomerdetails_full_for_auto_invoice";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = alistsearch;
alsearch = sq.RunViewSQL("|");
sq = null;
return alsearch;
}
 
 
public DataTable SearchResultAsTable(string SearchExp, string Con)
{
DataTable dt = new DataTable();
string dtsearch = "SELECT * FROM propertycustomerdetails_full_for_auto_invoice " +SearchExp;
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
 
public DataTable GetAllDataAsTable(string Con)
{
DataTable dt = new DataTable();
string dtsearch = "SELECT * FROM propertycustomerdetails_full_for_auto_invoice";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
