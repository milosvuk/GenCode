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
 
public class invoices
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public invoices()
{
 
  
 
}
 
public invoices (System.Int32 _idinvoice,System.Int32 _id_customer,System.DateTime _dateofinvoice,System.DateTime _datetimeofinvoice,System.Int32 _numofinvoice,System.Int32 _typeofinvoice,System.Int32 _id_pos_ws,System.Int32 _id_store,System.Decimal _amountoftax,System.Decimal _amountofdisc,System.Decimal _amountofinvoice,System.Int32 _id_user,System.String _notes1,System.String _notes2,System.String _notes3,System.Int32 _finalized,System.Int32 _id_company )
{
idinvoice=_idinvoice;
id_customer=_id_customer;
dateofinvoice=_dateofinvoice;
datetimeofinvoice=_datetimeofinvoice;
numofinvoice=_numofinvoice;
typeofinvoice=_typeofinvoice;
id_pos_ws=_id_pos_ws;
id_store=_id_store;
amountoftax=_amountoftax;
amountofdisc=_amountofdisc;
amountofinvoice=_amountofinvoice;
id_user=_id_user;
notes1=_notes1;
notes2=_notes2;
notes3=_notes3;
finalized=_finalized;
id_company=_id_company;
}
 
 
private System.Int32 idinvoice;
 
public System.Int32 IDINVOICE
{
get
{
return idinvoice;
}
set
{
idinvoice=value;
}
}
 
private System.Int32 id_customer;
 
public System.Int32 ID_CUSTOMER
{
get
{
return id_customer;
}
set
{
id_customer=value;
}
}
 
private System.DateTime dateofinvoice;
 
public System.DateTime DATEOFINVOICE
{
get
{
return dateofinvoice;
}
set
{
dateofinvoice=value;
}
}
 
private System.DateTime datetimeofinvoice;
 
public System.DateTime DATETIMEOFINVOICE
{
get
{
return datetimeofinvoice;
}
set
{
datetimeofinvoice=value;
}
}
 
private System.Int32 numofinvoice;
 
public System.Int32 NUMOFINVOICE
{
get
{
return numofinvoice;
}
set
{
numofinvoice=value;
}
}
 
private System.Int32 typeofinvoice;
 
public System.Int32 TYPEOFINVOICE
{
get
{
return typeofinvoice;
}
set
{
typeofinvoice=value;
}
}
 
private System.Int32 id_pos_ws;
 
public System.Int32 ID_POS_WS
{
get
{
return id_pos_ws;
}
set
{
id_pos_ws=value;
}
}
 
private System.Int32 id_store;
 
public System.Int32 ID_STORE
{
get
{
return id_store;
}
set
{
id_store=value;
}
}
 
private System.Decimal amountoftax;
 
public System.Decimal AMOUNTOFTAX
{
get
{
return amountoftax;
}
set
{
amountoftax=value;
}
}
 
private System.Decimal amountofdisc;
 
public System.Decimal AMOUNTOFDISC
{
get
{
return amountofdisc;
}
set
{
amountofdisc=value;
}
}
 
private System.Decimal amountofinvoice;
 
public System.Decimal AMOUNTOFINVOICE
{
get
{
return amountofinvoice;
}
set
{
amountofinvoice=value;
}
}
 
private System.Int32 id_user;
 
public System.Int32 ID_USER
{
get
{
return id_user;
}
set
{
id_user=value;
}
}
 
private System.String notes1;
 
public System.String NOTES1
{
get
{
return notes1;
}
set
{
notes1=value;
}
}
 
private System.String notes2;
 
public System.String NOTES2
{
get
{
return notes2;
}
set
{
notes2=value;
}
}
 
private System.String notes3;
 
public System.String NOTES3
{
get
{
return notes3;
}
set
{
notes3=value;
}
}
 
private System.Int32 finalized;
 
public System.Int32 FINALIZED
{
get
{
return finalized;
}
set
{
finalized=value;
}
}
 
private System.Int32 id_company;
 
public System.Int32 ID_COMPANY
{
get
{
return id_company;
}
set
{
id_company=value;
}
}
 
 
public void New()
{
idinvoice = 0;
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
// INSERT INTO invoices(idinvoice,id_customer,dateOfInvoice,datetimeofInvoice,numOfInvoice,typeOfInvoice,id_pos_ws,id_store,amountOfTax,amountOfDisc,amountOfInvoice,id_user,notes1,notes2,notes3,finalized,id_company ) VALUES(idinvoice,id_customer,dateofinvoice,datetimeofinvoice,numofinvoice,typeofinvoice,id_pos_ws,id_store,amountoftax,amountofdisc,amountofinvoice,id_user,notes1,notes2,notes3,finalized,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO invoices(id_customer,dateOfInvoice,datetimeofInvoice,numOfInvoice,typeOfInvoice,id_pos_ws,id_store,amountOfTax,amountOfDisc,amountOfInvoice,id_user,notes1,notes2,notes3,finalized,id_company ) VALUES("+id_customer.ToString()+(char)44+(char)39+dateofinvoice.ToString()+(char)39+(char)44+(char)39+datetimeofinvoice.ToString()+(char)39+(char)44+numofinvoice.ToString()+(char)44+typeofinvoice.ToString()+(char)44+id_pos_ws.ToString()+(char)44+id_store.ToString()+(char)44+amountoftax.ToString()+(char)44+amountofdisc.ToString()+(char)44+amountofinvoice.ToString()+(char)44+id_user.ToString()+(char)44+(char)39+notes1.ToString()+(char)39+(char)44+(char)39+notes2.ToString()+(char)39+(char)44+(char)39+notes3.ToString()+(char)39+(char)44+finalized.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(invoices _invoices)
{
bool tmp = false;
int res = -1;
_invoices.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_invoices db_invoices = new DB_invoices();
if (_invoices.IDINVOICES == 0)
{
res = db_invoices.Add(_invoices, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_invoices.Update(_invoices, conn, tran);
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
string mupdate = "UPDATE invoices SET "+"id_customer="+id_customer.ToString()+(char)44+"dateOfInvoice="+(char)39+dateofinvoice.ToString()+(char)39+(char)44+"datetimeofInvoice="+(char)39+datetimeofinvoice.ToString()+(char)39+(char)44+"numOfInvoice="+numofinvoice.ToString()+(char)44+"typeOfInvoice="+typeofinvoice.ToString()+(char)44+"id_pos_ws="+id_pos_ws.ToString()+(char)44+"id_store="+id_store.ToString()+(char)44+"amountOfTax="+amountoftax.ToString()+(char)44+"amountOfDisc="+amountofdisc.ToString()+(char)44+"amountOfInvoice="+amountofinvoice.ToString()+(char)44+"id_user="+id_user.ToString()+(char)44+"notes1="+(char)39+notes1.ToString()+(char)39+(char)44+"notes2="+(char)39+notes2.ToString()+(char)39+(char)44+"notes3="+(char)39+notes3.ToString()+(char)39+(char)44+"finalized="+finalized.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE idinvoice="+idinvoice.ToString();
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
string del = "DELETE FROM invoices WHERE idinvoice="+idinvoice.ToString();
 // idinvoice=OldData[i].ToString() AND
 // id_customer=OldData[i].ToString() AND
 // dateOfInvoice=OldData[i].ToString() AND
 // datetimeofInvoice=OldData[i].ToString() AND
 // numOfInvoice=OldData[i].ToString() AND
 // typeOfInvoice=OldData[i].ToString() AND
 // id_pos_ws=OldData[i].ToString() AND
 // id_store=OldData[i].ToString() AND
 // amountOfTax=OldData[i].ToString() AND
 // amountOfDisc=OldData[i].ToString() AND
 // amountOfInvoice=OldData[i].ToString() AND
 // id_user=OldData[i].ToString() AND
 // notes1=OldData[i].ToString() AND
 // notes2=OldData[i].ToString() AND
 // notes3=OldData[i].ToString() AND
 // finalized=OldData[i].ToString() AND
 // id_company=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM invoices " +SearchExp;
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
string alistsearch = "SELECT * FROM invoices";
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
string dtsearch = "SELECT * FROM invoices " +SearchExp;
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
string dtsearch = "SELECT * FROM invoices";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
