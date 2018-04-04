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
 
public class store
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public store()
{
 
  
 
}
 
public store (System.Int32 _idstore,System.Int32 _numofstore,System.String _codeofstore,System.String _nameofstore,System.Decimal _latstore,System.Decimal _longstore,System.Int32 _id_company )
{
idstore=_idstore;
numofstore=_numofstore;
codeofstore=_codeofstore;
nameofstore=_nameofstore;
latstore=_latstore;
longstore=_longstore;
id_company=_id_company;
}
 
 
private System.Int32 idstore;
 
public System.Int32 IDSTORE
{
get
{
return idstore;
}
set
{
idstore=value;
}
}
 
private System.Int32 numofstore;
 
public System.Int32 NUMOFSTORE
{
get
{
return numofstore;
}
set
{
numofstore=value;
}
}
 
private System.String codeofstore;
 
public System.String CODEOFSTORE
{
get
{
return codeofstore;
}
set
{
codeofstore=value;
}
}
 
private System.String nameofstore;
 
public System.String NAMEOFSTORE
{
get
{
return nameofstore;
}
set
{
nameofstore=value;
}
}
 
private System.Decimal latstore;
 
public System.Decimal LATSTORE
{
get
{
return latstore;
}
set
{
latstore=value;
}
}
 
private System.Decimal longstore;
 
public System.Decimal LONGSTORE
{
get
{
return longstore;
}
set
{
longstore=value;
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
idstore = 0;
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
// INSERT INTO store(idstore,numOfStore,codeOfStore,nameOfStore,latStore,longStore,id_company ) VALUES(idstore,numofstore,codeofstore,nameofstore,latstore,longstore,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO store(numOfStore,codeOfStore,nameOfStore,latStore,longStore,id_company ) VALUES("+numofstore.ToString()+(char)44+(char)39+codeofstore.ToString()+(char)39+(char)44+(char)39+nameofstore.ToString()+(char)39+(char)44+latstore.ToString()+(char)44+longstore.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(store _store)
{
bool tmp = false;
int res = -1;
_store.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_store db_store = new DB_store();
if (_store.IDSTORE == 0)
{
res = db_store.Add(_store, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_store.Update(_store, conn, tran);
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
string mupdate = "UPDATE store SET "+"numOfStore="+numofstore.ToString()+(char)44+"codeOfStore="+(char)39+codeofstore.ToString()+(char)39+(char)44+"nameOfStore="+(char)39+nameofstore.ToString()+(char)39+(char)44+"latStore="+latstore.ToString()+(char)44+"longStore="+longstore.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE idstore="+idstore.ToString();
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
string del = "DELETE FROM store WHERE idstore="+idstore.ToString();
 // idstore=OldData[i].ToString() AND
 // numOfStore=OldData[i].ToString() AND
 // codeOfStore=OldData[i].ToString() AND
 // nameOfStore=OldData[i].ToString() AND
 // latStore=OldData[i].ToString() AND
 // longStore=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM store " +SearchExp;
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
string alistsearch = "SELECT * FROM store";
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
string dtsearch = "SELECT * FROM store " +SearchExp;
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
string dtsearch = "SELECT * FROM store";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
