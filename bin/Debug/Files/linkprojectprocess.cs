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
 
public class linkprojectprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprojectprocess()
{
 
  
 
}
 
public linkprojectprocess (System.Int32 _idprojectprocess,System.String _projectname,System.String _processname,System.String _processdescription,System.Int32 _id_project,System.Int32 _id_process )
{
idprojectprocess=_idprojectprocess;
projectname=_projectname;
processname=_processname;
processdescription=_processdescription;
id_project=_id_project;
id_process=_id_process;
}
 
 
private System.Int32 idprojectprocess;
 
public System.Int32 IDPROJECTPROCESS
{
get
{
return idprojectprocess;
}
set
{
idprojectprocess=value;
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
 
private System.String processname;
 
public System.String PROCESSNAME
{
get
{
return processname;
}
set
{
processname=value;
}
}
 
private System.String processdescription;
 
public System.String PROCESSDESCRIPTION
{
get
{
return processdescription;
}
set
{
processdescription=value;
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
 
private System.Int32 id_process;
 
public System.Int32 ID_PROCESS
{
get
{
return id_process;
}
set
{
id_process=value;
}
}
 
 
public void New()
{
idprojectprocess = 0;
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
// INSERT INTO linkprojectprocess(idprojectprocess,ProjectName,ProcessName,ProcessDescription,id_project,id_process ) VALUES(idprojectprocess,projectname,processname,processdescription,id_project,id_process );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO linkprojectprocess(ProjectName,ProcessName,ProcessDescription,id_project,id_process ) VALUES("+(char)39+projectname.ToString()+(char)39+(char)44+(char)39+processname.ToString()+(char)39+(char)44+(char)39+processdescription.ToString()+(char)39+(char)44+id_project.ToString()+(char)44+id_process.ToString()+(char)41;
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
public bool Save(linkprojectprocess _linkprojectprocess)
{
bool tmp = false;
int res = -1;
_linkprojectprocess.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_linkprojectprocess db_linkprojectprocess = new DB_linkprojectprocess();
if (_linkprojectprocess.IDLINKPROJECTPROCESS == 0)
{
res = db_linkprojectprocess.Add(_linkprojectprocess, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_linkprojectprocess.Update(_linkprojectprocess, conn, tran);
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
string mupdate = "UPDATE linkprojectprocess SET "+"ProjectName="+(char)39+projectname.ToString()+(char)39+(char)44+"ProcessName="+(char)39+processname.ToString()+(char)39+(char)44+"ProcessDescription="+(char)39+processdescription.ToString()+(char)39+(char)44+"id_project="+id_project.ToString()+(char)44+"id_process="+id_process.ToString()+" WHERE idprojectprocess="+idprojectprocess.ToString();
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
string del = "DELETE FROM linkprojectprocess WHERE idprojectprocess="+idprojectprocess.ToString();
 // idprojectprocess=OldData[i].ToString() AND
 // ProjectName=OldData[i].ToString() AND
 // ProcessName=OldData[i].ToString() AND
 // ProcessDescription=OldData[i].ToString() AND
 // id_project=OldData[i].ToString() AND
 // id_process=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM linkprojectprocess " +SearchExp;
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
string alistsearch = "SELECT * FROM linkprojectprocess";
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
string dtsearch = "SELECT * FROM linkprojectprocess " +SearchExp;
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
string dtsearch = "SELECT * FROM linkprojectprocess";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
