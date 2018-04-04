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
 
public class linkprojectclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprojectclass()
{
 
  
 
}
 
public linkprojectclass (System.Int32 _idprojectclass,System.String _projectname,System.String _classname,System.Int32 _id_project,System.Int32 _id_objclasses )
{
idprojectclass=_idprojectclass;
projectname=_projectname;
classname=_classname;
id_project=_id_project;
id_objclasses=_id_objclasses;
}
 
 
private System.Int32 idprojectclass;
 
public System.Int32 IDPROJECTCLASS
{
get
{
return idprojectclass;
}
set
{
idprojectclass=value;
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
 
private System.Int32 id_objclasses;
 
public System.Int32 ID_OBJCLASSES
{
get
{
return id_objclasses;
}
set
{
id_objclasses=value;
}
}
 
 
public void New()
{
idprojectclass = 0;
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
// INSERT INTO linkprojectclass(idprojectclass,ProjectName,ClassName,id_project,id_objclasses ) VALUES(idprojectclass,projectname,classname,id_project,id_objclasses );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO linkprojectclass(ProjectName,ClassName,id_project,id_objclasses ) VALUES("+(char)39+projectname.ToString()+(char)39+(char)44+(char)39+classname.ToString()+(char)39+(char)44+id_project.ToString()+(char)44+id_objclasses.ToString()+(char)41;
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
public bool Save(linkprojectclass _linkprojectclass)
{
bool tmp = false;
int res = -1;
_linkprojectclass.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_linkprojectclass db_linkprojectclass = new DB_linkprojectclass();
if (_linkprojectclass.IDLINKPROJECTCLASS == 0)
{
res = db_linkprojectclass.Add(_linkprojectclass, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_linkprojectclass.Update(_linkprojectclass, conn, tran);
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
string mupdate = "UPDATE linkprojectclass SET "+"ProjectName="+(char)39+projectname.ToString()+(char)39+(char)44+"ClassName="+(char)39+classname.ToString()+(char)39+(char)44+"id_project="+id_project.ToString()+(char)44+"id_objclasses="+id_objclasses.ToString()+" WHERE idprojectclass="+idprojectclass.ToString();
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
string del = "DELETE FROM linkprojectclass WHERE idprojectclass="+idprojectclass.ToString();
 // idprojectclass=OldData[i].ToString() AND
 // ProjectName=OldData[i].ToString() AND
 // ClassName=OldData[i].ToString() AND
 // id_project=OldData[i].ToString() AND
 // id_objclasses=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM linkprojectclass " +SearchExp;
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
string alistsearch = "SELECT * FROM linkprojectclass";
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
string dtsearch = "SELECT * FROM linkprojectclass " +SearchExp;
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
string dtsearch = "SELECT * FROM linkprojectclass";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
