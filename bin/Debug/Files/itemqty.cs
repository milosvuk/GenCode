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
 
public class itemqty
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public itemqty()
{
 
  
 
}
 
public itemqty (System.Int32 _idqtystore,System.Int32 _id_item,System.Int32 _id_store,System.Decimal _qty,System.Decimal _price,System.Int32 _id_company )
{
idqtystore=_idqtystore;
id_item=_id_item;
id_store=_id_store;
qty=_qty;
price=_price;
id_company=_id_company;
}
 
 
private System.Int32 idqtystore;
 
public System.Int32 IDQTYSTORE
{
get
{
return idqtystore;
}
set
{
idqtystore=value;
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
 
private System.Decimal qty;
 
public System.Decimal QTY
{
get
{
return qty;
}
set
{
qty=value;
}
}
 
private System.Decimal price;
 
public System.Decimal PRICE
{
get
{
return price;
}
set
{
price=value;
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
idqtystore = 0;
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
// INSERT INTO itemqty(idqtystore,id_item,id_store,qty,price,id_company ) VALUES(idqtystore,id_item,id_store,qty,price,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO itemqty(id_item,id_store,qty,price,id_company ) VALUES("+id_item.ToString()+(char)44+id_store.ToString()+(char)44+qty.ToString()+(char)44+price.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(itemqty _itemqty)
{
bool tmp = false;
int res = -1;
_itemqty.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_itemqty db_itemqty = new DB_itemqty();
if (_itemqty.IDITEMQTY == 0)
{
res = db_itemqty.Add(_itemqty, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_itemqty.Update(_itemqty, conn, tran);
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
string mupdate = "UPDATE itemqty SET "+"id_item="+id_item.ToString()+(char)44+"id_store="+id_store.ToString()+(char)44+"qty="+qty.ToString()+(char)44+"price="+price.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE idqtystore="+idqtystore.ToString();
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
string del = "DELETE FROM itemqty WHERE idqtystore="+idqtystore.ToString();
 // idqtystore=OldData[i].ToString() AND
 // id_item=OldData[i].ToString() AND
 // id_store=OldData[i].ToString() AND
 // qty=OldData[i].ToString() AND
 // price=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM itemqty " +SearchExp;
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
string alistsearch = "SELECT * FROM itemqty";
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
string dtsearch = "SELECT * FROM itemqty " +SearchExp;
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
string dtsearch = "SELECT * FROM itemqty";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
