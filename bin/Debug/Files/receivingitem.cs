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
 
public class receivingitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public receivingitem()
{
 
  
 
}
 
public receivingitem (System.Int32 _idreceivingitem,System.Int32 _id_receiving,System.Int32 _id_item,System.Decimal _qty_item,System.Decimal _price_item,System.Decimal _total_price_item,System.Int32 _id_company )
{
idreceivingitem=_idreceivingitem;
id_receiving=_id_receiving;
id_item=_id_item;
qty_item=_qty_item;
price_item=_price_item;
total_price_item=_total_price_item;
id_company=_id_company;
}
 
 
private System.Int32 idreceivingitem;
 
public System.Int32 IDRECEIVINGITEM
{
get
{
return idreceivingitem;
}
set
{
idreceivingitem=value;
}
}
 
private System.Int32 id_receiving;
 
public System.Int32 ID_RECEIVING
{
get
{
return id_receiving;
}
set
{
id_receiving=value;
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
idreceivingitem = 0;
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
// INSERT INTO receivingitem(idreceivingitem,id_receiving,id_item,qty_item,price_item,total_price_item,id_company ) VALUES(idreceivingitem,id_receiving,id_item,qty_item,price_item,total_price_item,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO receivingitem(id_receiving,id_item,qty_item,price_item,total_price_item,id_company ) VALUES("+id_receiving.ToString()+(char)44+id_item.ToString()+(char)44+qty_item.ToString()+(char)44+price_item.ToString()+(char)44+total_price_item.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(receivingitem _receivingitem)
{
bool tmp = false;
int res = -1;
_receivingitem.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_receivingitem db_receivingitem = new DB_receivingitem();
if (_receivingitem.IDRECEIVINGITEM == 0)
{
res = db_receivingitem.Add(_receivingitem, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_receivingitem.Update(_receivingitem, conn, tran);
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
string mupdate = "UPDATE receivingitem SET "+"id_receiving="+id_receiving.ToString()+(char)44+"id_item="+id_item.ToString()+(char)44+"qty_item="+qty_item.ToString()+(char)44+"price_item="+price_item.ToString()+(char)44+"total_price_item="+total_price_item.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE idreceivingitem="+idreceivingitem.ToString();
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
string del = "DELETE FROM receivingitem WHERE idreceivingitem="+idreceivingitem.ToString();
 // idreceivingitem=OldData[i].ToString() AND
 // id_receiving=OldData[i].ToString() AND
 // id_item=OldData[i].ToString() AND
 // qty_item=OldData[i].ToString() AND
 // price_item=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM receivingitem " +SearchExp;
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
string alistsearch = "SELECT * FROM receivingitem";
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
string dtsearch = "SELECT * FROM receivingitem " +SearchExp;
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
string dtsearch = "SELECT * FROM receivingitem";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
