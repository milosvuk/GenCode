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
 
public class linkmonitorproject
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkmonitorproject()
{
 
  
 
}
 
public linkmonitorproject (System.Int32 _idlinkmonitorproject,System.Int32 _id_project,System.Int32 _id_monitorpoints,System.Int32 _idcompamy )
{
idlinkmonitorproject=_idlinkmonitorproject;
id_project=_id_project;
id_monitorpoints=_id_monitorpoints;
idcompamy=_idcompamy;
}
 
 
private System.Int32 idlinkmonitorproject;
 
public System.Int32 IDLINKMONITORPROJECT
{
get
{
return idlinkmonitorproject;
}
set
{
idlinkmonitorproject=value;
}
}
 
private System.Int32 id_project;
 
public System.Int32 ID_PROJECT
{
get
{
return id_project;
}
set
{
id_project=value;
}
}
 
private System.Int32 id_monitorpoints;
 
public System.Int32 ID_MONITORPOINTS
{
get
{
return id_monitorpoints;
}
set
{
id_monitorpoints=value;
}
}
 
private System.Int32 idcompamy;
 
public System.Int32 IDCOMPAMY
{
get
{
return idcompamy;
}
set
{
idcompamy=value;
}
}
 
 
public void New()
{
idlinkmonitorproject = 0;
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
// INSERT INTO linkmonitorproject(idlinkmonitorproject,id_project,id_monitorpoints,idcompamy ) VALUES(idlinkmonitorproject,id_project,id_monitorpoints,idcompamy );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO linkmonitorproject(id_project,id_monitorpoints,idcompamy ) VALUES("+id_project.ToString()+(char)44+id_monitorpoints.ToString()+(char)44+idcompamy.ToString()+(char)41;
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
public bool Save(linkmonitorproject _linkmonitorproject)
{
bool tmp = false;
int res = -1;
_linkmonitorproject.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_linkmonitorproject db_linkmonitorproject = new DB_linkmonitorproject();
if (_linkmonitorproject.IDLINKMONITORPROJECT == 0)
{
res = db_linkmonitorproject.Add(_linkmonitorproject, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_linkmonitorproject.Update(_linkmonitorproject, conn, tran);
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
string mupdate = "UPDATE linkmonitorproject SET "+"id_project="+id_project.ToString()+(char)44+"id_monitorpoints="+id_monitorpoints.ToString()+(char)44+"idcompamy="+idcompamy.ToString()+" WHERE idlinkmonitorproject="+idlinkmonitorproject.ToString();
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
string del = "DELETE FROM linkmonitorproject WHERE idlinkmonitorproject="+idlinkmonitorproject.ToString();
 // idlinkmonitorproject=OldData[i].ToString() AND
 // id_project=OldData[i].ToString() AND
 // id_monitorpoints=OldData[i].ToString() AND
 // idcompamy=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM linkmonitorproject " +SearchExp;
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
string alistsearch = "SELECT * FROM linkmonitorproject";
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
string dtsearch = "SELECT * FROM linkmonitorproject " +SearchExp;
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
string dtsearch = "SELECT * FROM linkmonitorproject";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
