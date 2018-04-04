using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class key_to_group
 
{
public string connString;
public string connectionString;
public key_to_group()
{
  
 
 
}
 
public key_to_group (System.Int32 _id,System.Int32 _store_no,System.String _department,System.String _class_,System.String _vendor_code )
{
id=_id;
store_no=_store_no;
department=_department;
class_=_class_;
vendor_code=_vendor_code;
}
 
 
private System.Int32 id;
 
public System.Int32 ID
{
get
{
return id;
}
set
{
id=value;
}
}
 
private System.Int32 store_no;
 
public System.Int32 STORE_NO
{
get
{
return store_no;
}
set
{
store_no=value;
}
}
 
private System.String department;
 
public System.String DEPARTMENT
{
get
{
return department;
}
set
{
department=value;
}
}
 
private System.String class_;
 
public System.String CLASS_
{
get
{
return class_;
}
set
{
class_=value;
}
}
 
private System.String vendor_code;
 
public System.String VENDOR_CODE
{
get
{
return vendor_code;
}
set
{
vendor_code=value;
}
}
 
 
public void New()
{
id = 0;
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
// INSERT INTO KeyToGroup(id,Store_no,Department,Class_,Vendor_code ) VALUES(id,store_no,department,class_,vendor_code );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO KeyToGroup(Store_no,Department,Class_,Vendor_code ) VALUES("+store_no.ToString()+(char)44+(char)39+department.ToString()+(char)39+(char)44+(char)39+class_.ToString()+(char)39+(char)44+(char)39+vendor_code.ToString()+(char)39+(char)41;
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
public bool Save(key_to_group _key_to_group)
{
bool tmp = false;
int res = -1;
_key_to_group.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_key_to_group db_key_to_group = new DB_key_to_group();
if (_key_to_group.IDKEY_TO_GROUP == 0)
{
res = db_key_to_group.Add(_key_to_group, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_key_to_group.Update(_key_to_group, conn, tran);
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
string mupdate = "UPDATE KeyToGroup SET "+"Store_no="+store_no.ToString()+(char)44+"Department="+(char)39+department.ToString()+(char)39+(char)44+"Class_="+(char)39+class_.ToString()+(char)39+(char)44+"Vendor_code="+(char)39+vendor_code.ToString()+(char)39+" WHERE id="+id.ToString();
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
string del = "DELETE FROM KeyToGroup WHERE id="+id.ToString();
 // id=OldData[i].ToString() AND
 // Store_no=OldData[i].ToString() AND
 // Department=OldData[i].ToString() AND
 // Class_=OldData[i].ToString() AND
 // Vendor_code=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM KeyToGroup " +SearchExp;
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
string alistsearch = "SELECT * FROM KeyToGroup";
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
string dtsearch = "SELECT * FROM KeyToGroup " +SearchExp;
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
string dtsearch = "SELECT * FROM KeyToGroup";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
