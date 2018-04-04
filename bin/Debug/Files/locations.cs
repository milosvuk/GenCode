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
 
public class locations
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public locations()
{
 
  
 
}
 
public locations (System.Int32 _idreclocation,System.Int32 _idregion,System.String _locationcode,System.String _locationname,System.Int32 _idcompany )
{
idreclocation=_idreclocation;
idregion=_idregion;
locationcode=_locationcode;
locationname=_locationname;
idcompany=_idcompany;
}
 
 
private System.Int32 idreclocation;
 
public System.Int32 IDRECLOCATION
{
get
{
return idreclocation;
}
set
{
idreclocation=value;
}
}
 
private System.Int32 idregion;
 
public System.Int32 IDREGION
{
get
{
return idregion;
}
set
{
idregion=value;
}
}
 
private System.String locationcode;
 
public System.String LOCATIONCODE
{
get
{
return locationcode;
}
set
{
locationcode=value;
}
}
 
private System.String locationname;
 
public System.String LOCATIONNAME
{
get
{
return locationname;
}
set
{
locationname=value;
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
idreclocation = 0;
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
// INSERT INTO locations(idRecLocation,idRegion,locationcode,locationname,idCompany ) VALUES(idreclocation,idregion,locationcode,locationname,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO locations(idRegion,locationcode,locationname,idCompany ) VALUES("+idregion.ToString()+(char)44+(char)39+locationcode.ToString()+(char)39+(char)44+(char)39+locationname.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(locations _locations)
{
bool tmp = false;
int res = -1;
_locations.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_locations db_locations = new DB_locations();
if (_locations.IDLOCATIONS == 0)
{
res = db_locations.Add(_locations, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_locations.Update(_locations, conn, tran);
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
string mupdate = "UPDATE locations SET "+"idRegion="+idregion.ToString()+(char)44+"locationcode="+(char)39+locationcode.ToString()+(char)39+(char)44+"locationname="+(char)39+locationname.ToString()+(char)39+(char)44+"idCompany="+idcompany.ToString()+" WHERE idRecLocation="+idreclocation.ToString();
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
string del = "DELETE FROM locations WHERE idRecLocation="+idreclocation.ToString();
 // idRecLocation=OldData[i].ToString() AND
 // idRegion=OldData[i].ToString() AND
 // locationcode=OldData[i].ToString() AND
 // locationname=OldData[i].ToString() AND
 // idCompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM locations " +SearchExp;
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
string alistsearch = "SELECT * FROM locations";
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
string dtsearch = "SELECT * FROM locations " +SearchExp;
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
string dtsearch = "SELECT * FROM locations";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
