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
 
public class geosites
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public geosites()
{
 
  
 
}
 
public geosites (System.Int32 _idgeosite,System.String _idsitename,System.String _geocoordinates,System.Int32 _protectedsite,System.Int32 _active )
{
idgeosite=_idgeosite;
idsitename=_idsitename;
geocoordinates=_geocoordinates;
protectedsite=_protectedsite;
active=_active;
}
 
 
private System.Int32 idgeosite;
 
public System.Int32 IDGEOSITE
{
get
{
return idgeosite;
}
set
{
idgeosite=value;
}
}
 
private System.String idsitename;
 
public System.String IDSITENAME
{
get
{
return idsitename;
}
set
{
idsitename=value;
}
}
 
private System.String geocoordinates;
 
public System.String GEOCOORDINATES
{
get
{
return geocoordinates;
}
set
{
geocoordinates=value;
}
}
 
private System.Int32 protectedsite;
 
public System.Int32 PROTECTEDSITE
{
get
{
return protectedsite;
}
set
{
protectedsite=value;
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
idgeosite = 0;
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
// INSERT INTO geosites(idgeosite,idsitename,geocoordinates,protectedsite,active ) VALUES(idgeosite,idsitename,geocoordinates,protectedsite,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO geosites(idsitename,geocoordinates,protectedsite,active ) VALUES("+(char)39+idsitename.ToString()+(char)39+(char)44+(char)39+geocoordinates.ToString()+(char)39+(char)44+protectedsite.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(geosites _geosites)
{
bool tmp = false;
int res = -1;
_geosites.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_geosites db_geosites = new DB_geosites();
if (_geosites.IDGEOSITES == 0)
{
res = db_geosites.Add(_geosites, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_geosites.Update(_geosites, conn, tran);
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
string mupdate = "UPDATE geosites SET "+"idsitename="+(char)39+idsitename.ToString()+(char)39+(char)44+"geocoordinates="+(char)39+geocoordinates.ToString()+(char)39+(char)44+"protectedsite="+protectedsite.ToString()+(char)44+"active="+active.ToString()+" WHERE idgeosite="+idgeosite.ToString();
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
string del = "DELETE FROM geosites WHERE idgeosite="+idgeosite.ToString();
 // idgeosite=OldData[i].ToString() AND
 // idsitename=OldData[i].ToString() AND
 // geocoordinates=OldData[i].ToString() AND
 // protectedsite=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM geosites " +SearchExp;
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
string alistsearch = "SELECT * FROM geosites";
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
string dtsearch = "SELECT * FROM geosites " +SearchExp;
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
string dtsearch = "SELECT * FROM geosites";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
