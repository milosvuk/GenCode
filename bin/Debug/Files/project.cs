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
 
public class project
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public project()
{
 
  
 
}
 
public project (System.Int32 _idproject,System.String _name,System.String _description,System.Int32 _id_statussh,System.DateTime _firstdate,System.Int32 _active,System.Int32 _id_company )
{
idproject=_idproject;
name=_name;
description=_description;
id_statussh=_id_statussh;
firstdate=_firstdate;
active=_active;
id_company=_id_company;
}
 
 
private System.Int32 idproject;
 
public System.Int32 IDPROJECT
{
get
{
return idproject;
}
set
{
idproject=value;
}
}
 
private System.String name;
 
public System.String NAME
{
get
{
return name;
}
set
{
name=value;
}
}
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
}
}
 
private System.Int32 id_statussh;
 
public System.Int32 ID_STATUSSH
{
get
{
return id_statussh;
}
set
{
id_statussh=value;
}
}
 
private System.DateTime firstdate;
 
public System.DateTime FIRSTDATE
{
get
{
return firstdate;
}
set
{
firstdate=value;
}
}
 
private System.Int32 active;
 
public System.Int32 ACTIVE
{
get
{
return active;
}
set
{
active=value;
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
idproject = 0;
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
// INSERT INTO project(idproject,name,description,id_statussh,firstdate,active,id_company ) VALUES(idproject,name,description,id_statussh,firstdate,active,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO project(name,description,id_statussh,firstdate,active,id_company ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+description.ToString()+(char)39+(char)44+id_statussh.ToString()+(char)44+(char)39+firstdate.ToString()+(char)39+(char)44+active.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(project _project)
{
bool tmp = false;
int res = -1;
_project.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_project db_project = new DB_project();
if (_project.IDPROJECT == 0)
{
res = db_project.Add(_project, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_project.Update(_project, conn, tran);
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
string mupdate = "UPDATE project SET "+"name="+(char)39+name.ToString()+(char)39+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"id_statussh="+id_statussh.ToString()+(char)44+"firstdate="+(char)39+firstdate.ToString()+(char)39+(char)44+"active="+active.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE idproject="+idproject.ToString();
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
string del = "DELETE FROM project WHERE idproject="+idproject.ToString();
 // idproject=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // id_statussh=OldData[i].ToString() AND
 // firstdate=OldData[i].ToString() AND
 // active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM project " +SearchExp;
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
string alistsearch = "SELECT * FROM project";
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
string dtsearch = "SELECT * FROM project " +SearchExp;
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
string dtsearch = "SELECT * FROM project";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
