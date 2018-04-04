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
 
public class propertycustomerdetails
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomerdetails()
{
 
  
 
}
 
public propertycustomerdetails (System.Int32 _idpropertcustomerdetails,System.Int32 _id_propertycustomer,System.DateTime _datefrom,System.DateTime _dateto,System.Int32 _numberofdaystocreateinvoice,System.Decimal _amountforthatperiod,System.Decimal _amountpereachinvoice,System.String _description,System.Int32 _numberofinvoicestogenerate,System.String _generatedinvoicesfromthis,System.Int32 _active )
{
idpropertcustomerdetails=_idpropertcustomerdetails;
id_propertycustomer=_id_propertycustomer;
datefrom=_datefrom;
dateto=_dateto;
numberofdaystocreateinvoice=_numberofdaystocreateinvoice;
amountforthatperiod=_amountforthatperiod;
amountpereachinvoice=_amountpereachinvoice;
description=_description;
numberofinvoicestogenerate=_numberofinvoicestogenerate;
generatedinvoicesfromthis=_generatedinvoicesfromthis;
active=_active;
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
 
private System.Int32 id_propertycustomer;
 
public System.Int32 ID_PROPERTYCUSTOMER
{
get
{
return id_propertycustomer;
}
set
{
id_propertycustomer=value;
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
 
 
public void New()
{
idpropertcustomerdetails = 0;
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
// INSERT INTO propertycustomerdetails(idpropertcustomerdetails,id_propertycustomer,datefrom,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,active ) VALUES(idpropertcustomerdetails,id_propertycustomer,datefrom,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO propertycustomerdetails(id_propertycustomer,datefrom,dateto,numberofdaystocreateinvoice,amountforthatperiod,amountpereachinvoice,description,numberofinvoicestogenerate,generatedinvoicesfromthis,active ) VALUES("+id_propertycustomer.ToString()+(char)44+(char)39+datefrom.ToString()+(char)39+(char)44+(char)39+dateto.ToString()+(char)39+(char)44+numberofdaystocreateinvoice.ToString()+(char)44+amountforthatperiod.ToString()+(char)44+amountpereachinvoice.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+numberofinvoicestogenerate.ToString()+(char)44+(char)39+generatedinvoicesfromthis.ToString()+(char)39+(char)44+active.ToString()+(char)41;
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
public bool Save(propertycustomerdetails _propertycustomerdetails)
{
bool tmp = false;
int res = -1;
_propertycustomerdetails.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_propertycustomerdetails db_propertycustomerdetails = new DB_propertycustomerdetails();
if (_propertycustomerdetails.IDPROPERTYCUSTOMERDETAILS == 0)
{
res = db_propertycustomerdetails.Add(_propertycustomerdetails, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_propertycustomerdetails.Update(_propertycustomerdetails, conn, tran);
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
string mupdate = "UPDATE propertycustomerdetails SET "+"id_propertycustomer="+id_propertycustomer.ToString()+(char)44+"datefrom="+(char)39+datefrom.ToString()+(char)39+(char)44+"dateto="+(char)39+dateto.ToString()+(char)39+(char)44+"numberofdaystocreateinvoice="+numberofdaystocreateinvoice.ToString()+(char)44+"amountforthatperiod="+amountforthatperiod.ToString()+(char)44+"amountpereachinvoice="+amountpereachinvoice.ToString()+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"numberofinvoicestogenerate="+numberofinvoicestogenerate.ToString()+(char)44+"generatedinvoicesfromthis="+(char)39+generatedinvoicesfromthis.ToString()+(char)39+(char)44+"active="+active.ToString()+" WHERE idpropertcustomerdetails="+idpropertcustomerdetails.ToString();
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
string del = "DELETE FROM propertycustomerdetails WHERE idpropertcustomerdetails="+idpropertcustomerdetails.ToString();
 // idpropertcustomerdetails=OldData[i].ToString() AND
 // id_propertycustomer=OldData[i].ToString() AND
 // datefrom=OldData[i].ToString() AND
 // dateto=OldData[i].ToString() AND
 // numberofdaystocreateinvoice=OldData[i].ToString() AND
 // amountforthatperiod=OldData[i].ToString() AND
 // amountpereachinvoice=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // numberofinvoicestogenerate=OldData[i].ToString() AND
 // generatedinvoicesfromthis=OldData[i].ToString() AND
 // active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM propertycustomerdetails " +SearchExp;
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
string alistsearch = "SELECT * FROM propertycustomerdetails";
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
string dtsearch = "SELECT * FROM propertycustomerdetails " +SearchExp;
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
string dtsearch = "SELECT * FROM propertycustomerdetails";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
