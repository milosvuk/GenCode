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
 
public class geositeslinksperson
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public geositeslinksperson()
{
 
  
 
}
 
public geositeslinksperson (System.Int32 _idgeosite,System.String _idsitename,System.String _geocoordinates,System.Int32 _protectedsite,System.Int32 _idgeositeslink,System.Int32 _idrechunter,System.String _name,System.String _idcard,System.String _phonenum,System.String _licfinch,System.String _licgoldenplower,System.Int32 _curyear,System.Int32 _active )
{
idgeosite=_idgeosite;
idsitename=_idsitename;
geocoordinates=_geocoordinates;
protectedsite=_protectedsite;
idgeositeslink=_idgeositeslink;
idrechunter=_idrechunter;
name=_name;
idcard=_idcard;
phonenum=_phonenum;
licfinch=_licfinch;
licgoldenplower=_licgoldenplower;
curyear=_curyear;
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
 
private System.Int32 idgeositeslink;
 
public System.Int32 IDGEOSITESLINK
{
get
{
return idgeositeslink;
}
set
{
idgeositeslink=value;
}
}
 
private System.Int32 idrechunter;
 
public System.Int32 IDRECHUNTER
{
get
{
return idrechunter;
}
set
{
idrechunter=value;
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
 
private System.String idcard;
 
public System.String IDCARD
{
get
{
return idcard;
}
set
{
idcard=value;
}
}
 
private System.String phonenum;
 
public System.String PHONENUM
{
get
{
return phonenum;
}
set
{
phonenum=value;
}
}
 
private System.String licfinch;
 
public System.String LICFINCH
{
get
{
return licfinch;
}
set
{
licfinch=value;
}
}
 
private System.String licgoldenplower;
 
public System.String LICGOLDENPLOWER
{
get
{
return licgoldenplower;
}
set
{
licgoldenplower=value;
}
}
 
private System.Int32 curyear;
 
public System.Int32 CURYEAR
{
get
{
return curyear;
}
set
{
curyear=value;
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
// INSERT INTO geositeslinksperson(idgeosite,idsitename,geocoordinates,protectedsite,idgeositeslink,idRecHunter,name,idcard,phonenum,licfinch,licgoldenplower,curyear,active ) VALUES(idgeosite,idsitename,geocoordinates,protectedsite,idgeositeslink,idrechunter,name,idcard,phonenum,licfinch,licgoldenplower,curyear,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO geositeslinksperson(idsitename,geocoordinates,protectedsite,idgeositeslink,idRecHunter,name,idcard,phonenum,licfinch,licgoldenplower,curyear,active ) VALUES("+(char)39+idsitename.ToString()+(char)39+(char)44+(char)39+geocoordinates.ToString()+(char)39+(char)44+protectedsite.ToString()+(char)44+idgeositeslink.ToString()+(char)44+idrechunter.ToString()+(char)44+(char)39+name.ToString()+(char)39+(char)44+(char)39+idcard.ToString()+(char)39+(char)44+(char)39+phonenum.ToString()+(char)39+(char)44+(char)39+licfinch.ToString()+(char)39+(char)44+(char)39+licgoldenplower.ToString()+(char)39+(char)44+curyear.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(geositeslinksperson _geositeslinksperson)
{
bool tmp = false;
int res = -1;
_geositeslinksperson.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_geositeslinksperson db_geositeslinksperson = new DB_geositeslinksperson();
if (_geositeslinksperson.IDGEOSITESLINKSPERSON == 0)
{
res = db_geositeslinksperson.Add(_geositeslinksperson, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_geositeslinksperson.Update(_geositeslinksperson, conn, tran);
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
string mupdate = "UPDATE geositeslinksperson SET "+"idsitename="+(char)39+idsitename.ToString()+(char)39+(char)44+"geocoordinates="+(char)39+geocoordinates.ToString()+(char)39+(char)44+"protectedsite="+protectedsite.ToString()+(char)44+"idgeositeslink="+idgeositeslink.ToString()+(char)44+"idRecHunter="+idrechunter.ToString()+(char)44+"name="+(char)39+name.ToString()+(char)39+(char)44+"idcard="+(char)39+idcard.ToString()+(char)39+(char)44+"phonenum="+(char)39+phonenum.ToString()+(char)39+(char)44+"licfinch="+(char)39+licfinch.ToString()+(char)39+(char)44+"licgoldenplower="+(char)39+licgoldenplower.ToString()+(char)39+(char)44+"curyear="+curyear.ToString()+(char)44+"active="+active.ToString()+" WHERE idgeosite="+idgeosite.ToString();
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
string del = "DELETE FROM geositeslinksperson WHERE idgeosite="+idgeosite.ToString();
 // idgeosite=OldData[i].ToString() AND
 // idsitename=OldData[i].ToString() AND
 // geocoordinates=OldData[i].ToString() AND
 // protectedsite=OldData[i].ToString() AND
 // idgeositeslink=OldData[i].ToString() AND
 // idRecHunter=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // idcard=OldData[i].ToString() AND
 // phonenum=OldData[i].ToString() AND
 // licfinch=OldData[i].ToString() AND
 // licgoldenplower=OldData[i].ToString() AND
 // curyear=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM geositeslinksperson " +SearchExp;
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
string alistsearch = "SELECT * FROM geositeslinksperson";
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
string dtsearch = "SELECT * FROM geositeslinksperson " +SearchExp;
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
string dtsearch = "SELECT * FROM geositeslinksperson";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
