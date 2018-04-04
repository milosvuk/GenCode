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
 
public class location
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public location()
{
 
  
 
}
 
public location (System.Int32 _idlocation,System.String _codeoflocation,System.String _nameoflocation,System.String _latit,System.String _longi,System.String _description,System.Int32 _idcompany )
{
idlocation=_idlocation;
codeoflocation=_codeoflocation;
nameoflocation=_nameoflocation;
latit=_latit;
longi=_longi;
description=_description;
idcompany=_idcompany;
}
 
 
private System.Int32 idlocation;
 
public System.Int32 IDLOCATION
{
get
{
return idlocation;
}
set
{
idlocation=value;
}
}
 
private System.String codeoflocation;
 
public System.String CODEOFLOCATION
{
get
{
return codeoflocation;
}
set
{
codeoflocation=value;
}
}
 
private System.String nameoflocation;
 
public System.String NAMEOFLOCATION
{
get
{
return nameoflocation;
}
set
{
nameoflocation=value;
}
}
 
private System.String latit;
 
public System.String LATIT
{
get
{
return latit;
}
set
{
latit=value;
}
}
 
private System.String longi;
 
public System.String LONGI
{
get
{
return longi;
}
set
{
longi=value;
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
idlocation = 0;
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
// INSERT INTO location(idlocation,codeoflocation,nameoflocation,latit,longi,description,idcompany ) VALUES(idlocation,codeoflocation,nameoflocation,latit,longi,description,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO location(codeoflocation,nameoflocation,latit,longi,description,idcompany ) VALUES("+(char)39+codeoflocation.ToString()+(char)39+(char)44+(char)39+nameoflocation.ToString()+(char)39+(char)44+(char)39+latit.ToString()+(char)39+(char)44+(char)39+longi.ToString()+(char)39+(char)44+(char)39+description.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(location _location)
{
bool tmp = false;
int res = -1;
_location.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_location db_location = new DB_location();
if (_location.IDLOCATION == 0)
{
res = db_location.Add(_location, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_location.Update(_location, conn, tran);
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
string mupdate = "UPDATE location SET "+"codeoflocation="+(char)39+codeoflocation.ToString()+(char)39+(char)44+"nameoflocation="+(char)39+nameoflocation.ToString()+(char)39+(char)44+"latit="+(char)39+latit.ToString()+(char)39+(char)44+"longi="+(char)39+longi.ToString()+(char)39+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"idcompany="+idcompany.ToString()+" WHERE idlocation="+idlocation.ToString();
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
string del = "DELETE FROM location WHERE idlocation="+idlocation.ToString();
 // idlocation=OldData[i].ToString() AND
 // codeoflocation=OldData[i].ToString() AND
 // nameoflocation=OldData[i].ToString() AND
 // latit=OldData[i].ToString() AND
 // longi=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM location " +SearchExp;
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
string alistsearch = "SELECT * FROM location";
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
string dtsearch = "SELECT * FROM location " +SearchExp;
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
string dtsearch = "SELECT * FROM location";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
