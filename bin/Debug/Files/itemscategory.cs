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
 
public class itemscategory
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public itemscategory()
{
 
  
 
}
 
public itemscategory (System.Int32 _iddcs,System.String _dcs,System.String _deparmentcode,System.String _departmentname,System.String _classcode,System.String _classname,System.String _subclasscode,System.String _subclassname )
{
iddcs=_iddcs;
dcs=_dcs;
deparmentcode=_deparmentcode;
departmentname=_departmentname;
classcode=_classcode;
classname=_classname;
subclasscode=_subclasscode;
subclassname=_subclassname;
}
 
 
private System.Int32 iddcs;
 
public System.Int32 IDDCS
{
get
{
return iddcs;
}
set
{
iddcs=value;
}
}
 
private System.String dcs;
 
public System.String DCS
{
get
{
return dcs;
}
set
{
dcs=value;
}
}
 
private System.String deparmentcode;
 
public System.String DEPARMENTCODE
{
get
{
return deparmentcode;
}
set
{
deparmentcode=value;
}
}
 
private System.String departmentname;
 
public System.String DEPARTMENTNAME
{
get
{
return departmentname;
}
set
{
departmentname=value;
}
}
 
private System.String classcode;
 
public System.String CLASSCODE
{
get
{
return classcode;
}
set
{
classcode=value;
}
}
 
private System.String classname;
 
public System.String CLASSNAME
{
get
{
return classname;
}
set
{
classname=value;
}
}
 
private System.String subclasscode;
 
public System.String SUBCLASSCODE
{
get
{
return subclasscode;
}
set
{
subclasscode=value;
}
}
 
private System.String subclassname;
 
public System.String SUBCLASSNAME
{
get
{
return subclassname;
}
set
{
subclassname=value;
}
}
 
 
public void New()
{
iddcs = 0;
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
// INSERT INTO itemscategory(iddcs,dcs,deparmentcode,departmentname,classcode,classname,subclasscode,subclassname ) VALUES(iddcs,dcs,deparmentcode,departmentname,classcode,classname,subclasscode,subclassname );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO itemscategory(dcs,deparmentcode,departmentname,classcode,classname,subclasscode,subclassname ) VALUES("+(char)39+dcs.ToString()+(char)39+(char)44+(char)39+deparmentcode.ToString()+(char)39+(char)44+(char)39+departmentname.ToString()+(char)39+(char)44+(char)39+classcode.ToString()+(char)39+(char)44+(char)39+classname.ToString()+(char)39+(char)44+(char)39+subclasscode.ToString()+(char)39+(char)44+(char)39+subclassname.ToString()+(char)39+(char)41;
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
public bool Save(itemscategory _itemscategory)
{
bool tmp = false;
int res = -1;
_itemscategory.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_itemscategory db_itemscategory = new DB_itemscategory();
if (_itemscategory.IDITEMSCATEGORY == 0)
{
res = db_itemscategory.Add(_itemscategory, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_itemscategory.Update(_itemscategory, conn, tran);
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
string mupdate = "UPDATE itemscategory SET "+"dcs="+(char)39+dcs.ToString()+(char)39+(char)44+"deparmentcode="+(char)39+deparmentcode.ToString()+(char)39+(char)44+"departmentname="+(char)39+departmentname.ToString()+(char)39+(char)44+"classcode="+(char)39+classcode.ToString()+(char)39+(char)44+"classname="+(char)39+classname.ToString()+(char)39+(char)44+"subclasscode="+(char)39+subclasscode.ToString()+(char)39+(char)44+"subclassname="+(char)39+subclassname.ToString()+(char)39+" WHERE iddcs="+iddcs.ToString();
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
string del = "DELETE FROM itemscategory WHERE iddcs="+iddcs.ToString();
 // iddcs=OldData[i].ToString() AND
 // dcs=OldData[i].ToString() AND
 // deparmentcode=OldData[i].ToString() AND
 // departmentname=OldData[i].ToString() AND
 // classcode=OldData[i].ToString() AND
 // classname=OldData[i].ToString() AND
 // subclasscode=OldData[i].ToString() AND
 // subclassname=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM itemscategory " +SearchExp;
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
string alistsearch = "SELECT * FROM itemscategory";
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
string dtsearch = "SELECT * FROM itemscategory " +SearchExp;
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
string dtsearch = "SELECT * FROM itemscategory";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
