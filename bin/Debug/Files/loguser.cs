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
 
public class loguser
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public loguser()
{
 
  
 
}
 
public loguser (System.Int32 _iduserlog,System.String _username,System.DateTime _logdate,System.DateTime _logdatetime,System.String _ipaddress,System.String _details,System.Int32 _id_company )
{
iduserlog=_iduserlog;
username=_username;
logdate=_logdate;
logdatetime=_logdatetime;
ipaddress=_ipaddress;
details=_details;
id_company=_id_company;
}
 
 
private System.Int32 iduserlog;
 
public System.Int32 IDUSERLOG
{
get
{
return iduserlog;
}
set
{
iduserlog=value;
}
}
 
private System.String username;
 
public System.String USERNAME
{
get
{
return username;
}
set
{
username=value;
}
}
 
private System.DateTime logdate;
 
public System.DateTime LOGDATE
{
get
{
return logdate;
}
set
{
logdate=value;
}
}
 
private System.DateTime logdatetime;
 
public System.DateTime LOGDATETIME
{
get
{
return logdatetime;
}
set
{
logdatetime=value;
}
}
 
private System.String ipaddress;
 
public System.String IPADDRESS
{
get
{
return ipaddress;
}
set
{
ipaddress=value;
}
}
 
private System.String details;
 
public System.String DETAILS
{
get
{
return details;
}
set
{
details=value;
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
iduserlog = 0;
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
// INSERT INTO loguser(idUserLog,username,logdate,logdatetime,ipaddress,details,id_company ) VALUES(iduserlog,username,logdate,logdatetime,ipaddress,details,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO loguser(username,logdate,logdatetime,ipaddress,details,id_company ) VALUES("+(char)39+username.ToString()+(char)39+(char)44+(char)39+logdate.ToString()+(char)39+(char)44+(char)39+logdatetime.ToString()+(char)39+(char)44+(char)39+ipaddress.ToString()+(char)39+(char)44+(char)39+details.ToString()+(char)39+(char)44+id_company.ToString()+(char)41;
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
public bool Save(loguser _loguser)
{
bool tmp = false;
int res = -1;
_loguser.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_loguser db_loguser = new DB_loguser();
if (_loguser.IDLOGUSER == 0)
{
res = db_loguser.Add(_loguser, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_loguser.Update(_loguser, conn, tran);
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
string mupdate = "UPDATE loguser SET "+"username="+(char)39+username.ToString()+(char)39+(char)44+"logdate="+(char)39+logdate.ToString()+(char)39+(char)44+"logdatetime="+(char)39+logdatetime.ToString()+(char)39+(char)44+"ipaddress="+(char)39+ipaddress.ToString()+(char)39+(char)44+"details="+(char)39+details.ToString()+(char)39+(char)44+"id_company="+id_company.ToString()+" WHERE idUserLog="+iduserlog.ToString();
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
string del = "DELETE FROM loguser WHERE idUserLog="+iduserlog.ToString();
 // idUserLog=OldData[i].ToString() AND
 // username=OldData[i].ToString() AND
 // logdate=OldData[i].ToString() AND
 // logdatetime=OldData[i].ToString() AND
 // ipaddress=OldData[i].ToString() AND
 // details=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM loguser " +SearchExp;
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
string alistsearch = "SELECT * FROM loguser";
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
string dtsearch = "SELECT * FROM loguser " +SearchExp;
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
string dtsearch = "SELECT * FROM loguser";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
