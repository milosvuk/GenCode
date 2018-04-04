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
 
public class fulllinkmonitorproject
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public fulllinkmonitorproject()
{
 
  
 
}
 
public fulllinkmonitorproject (System.Int32 _idlinkmonitorproject,System.String _projectname,System.String _monitoringpoint,System.String _implication,System.String _resolution,System.String _status,System.Int32 _id_monitorpoints,System.Int32 _id_project )
{
idlinkmonitorproject=_idlinkmonitorproject;
projectname=_projectname;
monitoringpoint=_monitoringpoint;
implication=_implication;
resolution=_resolution;
status=_status;
id_monitorpoints=_id_monitorpoints;
id_project=_id_project;
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
 
private System.String projectname;
 
public System.String PROJECTNAME
{
get
{
return projectname;
}
set
{
projectname=value;
}
}
 
private System.String monitoringpoint;
 
public System.String MONITORINGPOINT
{
get
{
return monitoringpoint;
}
set
{
monitoringpoint=value;
}
}
 
private System.String implication;
 
public System.String IMPLICATION
{
get
{
return implication;
}
set
{
implication=value;
}
}
 
private System.String resolution;
 
public System.String RESOLUTION
{
get
{
return resolution;
}
set
{
resolution=value;
}
}
 
private System.String status;
 
public System.String STATUS
{
get
{
return status;
}
set
{
status=value;
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
// INSERT INTO fulllinkmonitorproject(idlinkmonitorproject,ProjectName,MonitoringPoint,implication,resolution,status,id_monitorpoints,id_project ) VALUES(idlinkmonitorproject,projectname,monitoringpoint,implication,resolution,status,id_monitorpoints,id_project );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO fulllinkmonitorproject(ProjectName,MonitoringPoint,implication,resolution,status,id_monitorpoints,id_project ) VALUES("+(char)39+projectname.ToString()+(char)39+(char)44+(char)39+monitoringpoint.ToString()+(char)39+(char)44+(char)39+implication.ToString()+(char)39+(char)44+(char)39+resolution.ToString()+(char)39+(char)44+(char)39+status.ToString()+(char)39+(char)44+id_monitorpoints.ToString()+(char)44+id_project.ToString()+(char)41;
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
public bool Save(fulllinkmonitorproject _fulllinkmonitorproject)
{
bool tmp = false;
int res = -1;
_fulllinkmonitorproject.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_fulllinkmonitorproject db_fulllinkmonitorproject = new DB_fulllinkmonitorproject();
if (_fulllinkmonitorproject.IDFULLLINKMONITORPROJECT == 0)
{
res = db_fulllinkmonitorproject.Add(_fulllinkmonitorproject, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_fulllinkmonitorproject.Update(_fulllinkmonitorproject, conn, tran);
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
string mupdate = "UPDATE fulllinkmonitorproject SET "+"ProjectName="+(char)39+projectname.ToString()+(char)39+(char)44+"MonitoringPoint="+(char)39+monitoringpoint.ToString()+(char)39+(char)44+"implication="+(char)39+implication.ToString()+(char)39+(char)44+"resolution="+(char)39+resolution.ToString()+(char)39+(char)44+"status="+(char)39+status.ToString()+(char)39+(char)44+"id_monitorpoints="+id_monitorpoints.ToString()+(char)44+"id_project="+id_project.ToString()+" WHERE idlinkmonitorproject="+idlinkmonitorproject.ToString();
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
string del = "DELETE FROM fulllinkmonitorproject WHERE idlinkmonitorproject="+idlinkmonitorproject.ToString();
 // idlinkmonitorproject=OldData[i].ToString() AND
 // ProjectName=OldData[i].ToString() AND
 // MonitoringPoint=OldData[i].ToString() AND
 // implication=OldData[i].ToString() AND
 // resolution=OldData[i].ToString() AND
 // status=OldData[i].ToString() AND
 // id_monitorpoints=OldData[i].ToString() AND
 // id_project=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM fulllinkmonitorproject " +SearchExp;
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
string alistsearch = "SELECT * FROM fulllinkmonitorproject";
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
string dtsearch = "SELECT * FROM fulllinkmonitorproject " +SearchExp;
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
string dtsearch = "SELECT * FROM fulllinkmonitorproject";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
