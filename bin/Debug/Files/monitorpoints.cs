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
 
public class monitorpoints
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public monitorpoints()
{
 
  
 
}
 
public monitorpoints (System.Int32 _idmonitorpoints,System.String _description,System.String _implication,System.String _resolution,System.String _status,System.Int32 _idcompany )
{
idmonitorpoints=_idmonitorpoints;
description=_description;
implication=_implication;
resolution=_resolution;
status=_status;
idcompany=_idcompany;
}
 
 
private System.Int32 idmonitorpoints;
 
public System.Int32 IDMONITORPOINTS
{
get
{
return idmonitorpoints;
}
set
{
idmonitorpoints=value;
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
 
private System.Int32 idcompany;
 
public System.Int32 IDCOMPANY
{
get
{
return idcompany;
}
set
{
idcompany=value;
}
}
 
 
public void New()
{
idmonitorpoints = 0;
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
// INSERT INTO monitorpoints(idmonitorpoints,description,implication,resolution,status,idcompany ) VALUES(idmonitorpoints,description,implication,resolution,status,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO monitorpoints(description,implication,resolution,status,idcompany ) VALUES("+(char)39+description.ToString()+(char)39+(char)44+(char)39+implication.ToString()+(char)39+(char)44+(char)39+resolution.ToString()+(char)39+(char)44+(char)39+status.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(monitorpoints _monitorpoints)
{
bool tmp = false;
int res = -1;
_monitorpoints.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_monitorpoints db_monitorpoints = new DB_monitorpoints();
if (_monitorpoints.IDMONITORPOINTS == 0)
{
res = db_monitorpoints.Add(_monitorpoints, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_monitorpoints.Update(_monitorpoints, conn, tran);
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
string mupdate = "UPDATE monitorpoints SET "+"description="+(char)39+description.ToString()+(char)39+(char)44+"implication="+(char)39+implication.ToString()+(char)39+(char)44+"resolution="+(char)39+resolution.ToString()+(char)39+(char)44+"status="+(char)39+status.ToString()+(char)39+(char)44+"idcompany="+idcompany.ToString()+" WHERE idmonitorpoints="+idmonitorpoints.ToString();
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
string del = "DELETE FROM monitorpoints WHERE idmonitorpoints="+idmonitorpoints.ToString();
 // idmonitorpoints=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // implication=OldData[i].ToString() AND
 // resolution=OldData[i].ToString() AND
 // status=OldData[i].ToString() AND
 // idcompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM monitorpoints " +SearchExp;
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
string alistsearch = "SELECT * FROM monitorpoints";
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
string dtsearch = "SELECT * FROM monitorpoints " +SearchExp;
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
string dtsearch = "SELECT * FROM monitorpoints";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
