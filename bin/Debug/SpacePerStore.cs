using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class SpacePerStore
 
{
public string connString;
public string connectionString;
public SpacePerStore()
{
  
 
 
}
 
public SpacePerStore (System.Int32 _id,System.Int32 _store_no,System.String _vendor_code,System.String _department,System.String _class_,System.Int32 _year,System.Int32 _calendarweek,System.Decimal _space_qm )
{
id=_id;
store_no=_store_no;
vendor_code=_vendor_code;
department=_department;
class_=_class_;
year=_year;
calendarweek=_calendarweek;
space_qm=_space_qm;
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
 
private System.Int32 year;
 
public System.Int32 YEAR
{
get
{
return year;
}
set
{
year=value;
}
}
 
private System.Int32 calendarweek;
 
public System.Int32 CALENDARWEEK
{
get
{
return calendarweek;
}
set
{
calendarweek=value;
}
}
 
private System.Decimal space_qm;
 
public System.Decimal SPACE_QM
{
get
{
return space_qm;
}
set
{
space_qm=value;
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
// INSERT INTO SpacePerStore(id,Store_no,Vendor_code,Department,Class_,Year,CalendarWeek,Space_qm ) VALUES(id,store_no,vendor_code,department,class_,year,calendarweek,space_qm );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO SpacePerStore(Store_no,Vendor_code,Department,Class_,Year,CalendarWeek,Space_qm ) VALUES("+store_no.ToString()+(char)44+(char)39+vendor_code.ToString()+(char)39+(char)44+(char)39+department.ToString()+(char)39+(char)44+(char)39+class_.ToString()+(char)39+(char)44+year.ToString()+(char)44+calendarweek.ToString()+(char)44+space_qm.ToString()+(char)41;
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
public bool Save(SpacePerStore _SpacePerStore)
{
bool tmp = false;
int res = -1;
_SpacePerStore.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_SpacePerStore db_SpacePerStore = new DB_SpacePerStore();
if (_SpacePerStore.IDSPACEPERSTORE == 0)
{
res = db_SpacePerStore.Add(_SpacePerStore, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_SpacePerStore.Update(_SpacePerStore, conn, tran);
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
string mupdate = "UPDATE SpacePerStore SET "+"Store_no="+store_no.ToString()+(char)44+"Vendor_code="+(char)39+vendor_code.ToString()+(char)39+(char)44+"Department="+(char)39+department.ToString()+(char)39+(char)44+"Class_="+(char)39+class_.ToString()+(char)39+(char)44+"Year="+year.ToString()+(char)44+"CalendarWeek="+calendarweek.ToString()+(char)44+"Space_qm="+space_qm.ToString()+" WHERE id="+id.ToString();
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
string del = "DELETE FROM SpacePerStore WHERE id="+id.ToString();
 // id=OldData[i].ToString() AND
 // Store_no=OldData[i].ToString() AND
 // Vendor_code=OldData[i].ToString() AND
 // Department=OldData[i].ToString() AND
 // Class_=OldData[i].ToString() AND
 // Year=OldData[i].ToString() AND
 // CalendarWeek=OldData[i].ToString() AND
 // Space_qm=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM SpacePerStore " +SearchExp;
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
string alistsearch = "SELECT * FROM SpacePerStore";
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
string dtsearch = "SELECT * FROM SpacePerStore " +SearchExp;
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
string dtsearch = "SELECT * FROM SpacePerStore";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
