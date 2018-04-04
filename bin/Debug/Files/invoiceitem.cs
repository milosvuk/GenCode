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
 
public class invoiceitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public invoiceitem()
{
 
  
 
}
 
public invoiceitem (System.Int32 _id_invoice_item,System.Int32 _id_invoice,System.Int32 _id_item,System.Decimal _qty_item,System.Decimal _tax_item,System.Decimal _price_item,System.Decimal _disc_item,System.Decimal _total_tax_item,System.Decimal _total_disc_item,System.Decimal _total_price_item,System.Int32 _id_company )
{
id_invoice_item=_id_invoice_item;
id_invoice=_id_invoice;
id_item=_id_item;
qty_item=_qty_item;
tax_item=_tax_item;
price_item=_price_item;
disc_item=_disc_item;
total_tax_item=_total_tax_item;
total_disc_item=_total_disc_item;
total_price_item=_total_price_item;
id_company=_id_company;
}
 
 
private System.Int32 id_invoice_item;
 
public System.Int32 ID_INVOICE_ITEM
{
get
{
return id_invoice_item;
}
set
{
id_invoice_item=value;
}
}
 
private System.Int32 id_invoice;
 
public System.Int32 ID_INVOICE
{
get
{
return id_invoice;
}
set
{
id_invoice=value;
}
}
 
private System.Int32 id_item;
 
public System.Int32 ID_ITEM
{
get
{
return id_item;
}
set
{
id_item=value;
}
}
 
private System.Decimal qty_item;
 
public System.Decimal QTY_ITEM
{
get
{
return qty_item;
}
set
{
qty_item=value;
}
}
 
private System.Decimal tax_item;
 
public System.Decimal TAX_ITEM
{
get
{
return tax_item;
}
set
{
tax_item=value;
}
}
 
private System.Decimal price_item;
 
public System.Decimal PRICE_ITEM
{
get
{
return price_item;
}
set
{
price_item=value;
}
}
 
private System.Decimal disc_item;
 
public System.Decimal DISC_ITEM
{
get
{
return disc_item;
}
set
{
disc_item=value;
}
}
 
private System.Decimal total_tax_item;
 
public System.Decimal TOTAL_TAX_ITEM
{
get
{
return total_tax_item;
}
set
{
total_tax_item=value;
}
}
 
private System.Decimal total_disc_item;
 
public System.Decimal TOTAL_DISC_ITEM
{
get
{
return total_disc_item;
}
set
{
total_disc_item=value;
}
}
 
private System.Decimal total_price_item;
 
public System.Decimal TOTAL_PRICE_ITEM
{
get
{
return total_price_item;
}
set
{
total_price_item=value;
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
id_invoice_item = 0;
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
// INSERT INTO invoiceitem(id_invoice_item,id_invoice,id_item,qty_item,tax_item,price_item,disc_item,total_tax_item,total_disc_item,total_price_item,id_company ) VALUES(id_invoice_item,id_invoice,id_item,qty_item,tax_item,price_item,disc_item,total_tax_item,total_disc_item,total_price_item,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO invoiceitem(id_invoice,id_item,qty_item,tax_item,price_item,disc_item,total_tax_item,total_disc_item,total_price_item,id_company ) VALUES("+id_invoice.ToString()+(char)44+id_item.ToString()+(char)44+qty_item.ToString()+(char)44+tax_item.ToString()+(char)44+price_item.ToString()+(char)44+disc_item.ToString()+(char)44+total_tax_item.ToString()+(char)44+total_disc_item.ToString()+(char)44+total_price_item.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(invoiceitem _invoiceitem)
{
bool tmp = false;
int res = -1;
_invoiceitem.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_invoiceitem db_invoiceitem = new DB_invoiceitem();
if (_invoiceitem.IDINVOICEITEM == 0)
{
res = db_invoiceitem.Add(_invoiceitem, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_invoiceitem.Update(_invoiceitem, conn, tran);
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
string mupdate = "UPDATE invoiceitem SET "+"id_invoice="+id_invoice.ToString()+(char)44+"id_item="+id_item.ToString()+(char)44+"qty_item="+qty_item.ToString()+(char)44+"tax_item="+tax_item.ToString()+(char)44+"price_item="+price_item.ToString()+(char)44+"disc_item="+disc_item.ToString()+(char)44+"total_tax_item="+total_tax_item.ToString()+(char)44+"total_disc_item="+total_disc_item.ToString()+(char)44+"total_price_item="+total_price_item.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE id_invoice_item="+id_invoice_item.ToString();
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
string del = "DELETE FROM invoiceitem WHERE id_invoice_item="+id_invoice_item.ToString();
 // id_invoice_item=OldData[i].ToString() AND
 // id_invoice=OldData[i].ToString() AND
 // id_item=OldData[i].ToString() AND
 // qty_item=OldData[i].ToString() AND
 // tax_item=OldData[i].ToString() AND
 // price_item=OldData[i].ToString() AND
 // disc_item=OldData[i].ToString() AND
 // total_tax_item=OldData[i].ToString() AND
 // total_disc_item=OldData[i].ToString() AND
 // total_price_item=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM invoiceitem " +SearchExp;
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
string alistsearch = "SELECT * FROM invoiceitem";
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
string dtsearch = "SELECT * FROM invoiceitem " +SearchExp;
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
string dtsearch = "SELECT * FROM invoiceitem";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
