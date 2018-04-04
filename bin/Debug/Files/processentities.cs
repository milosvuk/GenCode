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
 
public class processentities
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public processentities()
{
 
  
 
}
 
public processentities (System.Int32 _idprojectprocessentities,System.Int32 _id_process,System.Int32 _id_identities,System.Int32 _id_company,System.Int32 _active )
{
idprojectprocessentities=_idprojectprocessentities;
id_process=_id_process;
id_identities=_id_identities;
id_company=_id_company;
active=_active;
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
// INSERT INTO processentities(idprojectprocessentities,id_process,id_identities,id_company,active ) VALUES(idprojectprocessentities,id_process,id_identities,id_company,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO processentities(id_process,id_identities,id_company,active ) VALUES("+id_process.ToString()+(char)44+id_identities.ToString()+(char)44+id_company.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(processentities _processentities)
{
bool tmp = false;
int res = -1;
_processentities.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_processentities db_processentities = new DB_processentities();
if (_processentities.IDPROCESSENTITIES == 0)
{
res = db_processentities.Add(_processentities, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_processentities.Update(_processentities, conn, tran);
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
string mupdate = "UPDATE processentities SET "+"id_process="+id_process.ToString()+(char)44+"id_identities="+id_identities.ToString()+(char)44+"id_company="+id_company.ToString()+(char)44+"active="+active.ToString()+" WHERE idprojectprocessentities="+idprojectprocessentities.ToString();
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
string del = "DELETE FROM processentities WHERE idprojectprocessentities="+idprojectprocessentities.ToString();
 // idprojectprocessentities=OldData[i].ToString() AND
 // id_process=OldData[i].ToString() AND
 // id_identities=OldData[i].ToString() AND
 // id_company=OldData[i].ToString() AND
 // active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM processentities " +SearchExp;
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
string alistsearch = "SELECT * FROM processentities";
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
string dtsearch = "SELECT * FROM processentities " +SearchExp;
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
string dtsearch = "SELECT * FROM processentities";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
