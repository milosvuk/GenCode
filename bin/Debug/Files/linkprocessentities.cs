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
 
public class linkprocessentities
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprocessentities()
{
 
  
 
}
 
public linkprocessentities (System.Int32 _idprojectprocessentities,System.String _processname,System.String _entityname,System.Int32 _id_process,System.Int32 _id_identities )
{
idprojectprocessentities=_idprojectprocessentities;
processname=_processname;
entityname=_entityname;
id_process=_id_process;
id_identities=_id_identities;
}
 
 
private System.Int32 idprojectprocessentities;
 
public System.Int32 IDPROJECTPROCESSENTITIES
{
get
{
return idprojectprocessentities;
}
set
{
idprojectprocessentities=value;
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
 
private System.String entityname;
 
public System.String ENTITYNAME
{
get
{
return entityname;
}
set
{
entityname=value;
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
 
private System.Int32 id_identities;
 
public System.Int32 ID_IDENTITIES
{
get
{
return id_identities;
}
set
{
id_identities=value;
}
}
 
 
public void New()
{
idprojectprocessentities = 0;
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
// INSERT INTO linkprocessentities(idprojectprocessentities,ProcessName,EntityName,id_process,id_identities ) VALUES(idprojectprocessentities,processname,entityname,id_process,id_identities );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO linkprocessentities(ProcessName,EntityName,id_process,id_identities ) VALUES("+(char)39+processname.ToString()+(char)39+(char)44+(char)39+entityname.ToString()+(char)39+(char)44+id_process.ToString()+(char)44+id_identities.ToString()+(char)41;
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
public bool Save(linkprocessentities _linkprocessentities)
{
bool tmp = false;
int res = -1;
_linkprocessentities.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_linkprocessentities db_linkprocessentities = new DB_linkprocessentities();
if (_linkprocessentities.IDLINKPROCESSENTITIES == 0)
{
res = db_linkprocessentities.Add(_linkprocessentities, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_linkprocessentities.Update(_linkprocessentities, conn, tran);
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
string mupdate = "UPDATE linkprocessentities SET "+"ProcessName="+(char)39+processname.ToString()+(char)39+(char)44+"EntityName="+(char)39+entityname.ToString()+(char)39+(char)44+"id_process="+id_process.ToString()+(char)44+"id_identities="+id_identities.ToString()+" WHERE idprojectprocessentities="+idprojectprocessentities.ToString();
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
string del = "DELETE FROM linkprocessentities WHERE idprojectprocessentities="+idprojectprocessentities.ToString();
 // idprojectprocessentities=OldData[i].ToString() AND
 // ProcessName=OldData[i].ToString() AND
 // EntityName=OldData[i].ToString() AND
 // id_process=OldData[i].ToString() AND
 // id_identities=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM linkprocessentities " +SearchExp;
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
string alistsearch = "SELECT * FROM linkprocessentities";
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
string dtsearch = "SELECT * FROM linkprocessentities " +SearchExp;
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
string dtsearch = "SELECT * FROM linkprocessentities";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
