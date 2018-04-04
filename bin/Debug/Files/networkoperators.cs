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
 
public class networkoperators
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public networkoperators()
{
 
  
 
}
 
public networkoperators (System.Int32 _id,System.String _country,System.String _network,System.String _mcc,System.String _mnc,System.String _countrycode )
{
id=_id;
country=_country;
network=_network;
mcc=_mcc;
mnc=_mnc;
countrycode=_countrycode;
}
 
 
private System.Int32 id;
 
public System.Int32 ID
{
get
{
return id;
}
set
{
id=value;
}
}
 
private System.String country;
 
public System.String COUNTRY
{
get
{
return country;
}
set
{
country=value;
}
}
 
private System.String network;
 
public System.String NETWORK
{
get
{
return network;
}
set
{
network=value;
}
}
 
private System.String mcc;
 
public System.String MCC
{
get
{
return mcc;
}
set
{
mcc=value;
}
}
 
private System.String mnc;
 
public System.String MNC
{
get
{
return mnc;
}
set
{
mnc=value;
}
}
 
private System.String countrycode;
 
public System.String COUNTRYCODE
{
get
{
return countrycode;
}
set
{
countrycode=value;
}
}
 
 
public void New()
{
id = 0;
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
// INSERT INTO networkoperators(id,country,network,mcc,mnc,countrycode ) VALUES(id,country,network,mcc,mnc,countrycode );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO networkoperators(country,network,mcc,mnc,countrycode ) VALUES("+(char)39+country.ToString()+(char)39+(char)44+(char)39+network.ToString()+(char)39+(char)44+(char)39+mcc.ToString()+(char)39+(char)44+(char)39+mnc.ToString()+(char)39+(char)44+(char)39+countrycode.ToString()+(char)39+(char)41;
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
public bool Save(networkoperators _networkoperators)
{
bool tmp = false;
int res = -1;
_networkoperators.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_networkoperators db_networkoperators = new DB_networkoperators();
if (_networkoperators.IDNETWORKOPERATORS == 0)
{
res = db_networkoperators.Add(_networkoperators, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_networkoperators.Update(_networkoperators, conn, tran);
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
string mupdate = "UPDATE networkoperators SET "+"country="+(char)39+country.ToString()+(char)39+(char)44+"network="+(char)39+network.ToString()+(char)39+(char)44+"mcc="+(char)39+mcc.ToString()+(char)39+(char)44+"mnc="+(char)39+mnc.ToString()+(char)39+(char)44+"countrycode="+(char)39+countrycode.ToString()+(char)39+" WHERE id="+id.ToString();
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
string del = "DELETE FROM networkoperators WHERE id="+id.ToString();
 // id=OldData[i].ToString() AND
 // country=OldData[i].ToString() AND
 // network=OldData[i].ToString() AND
 // mcc=OldData[i].ToString() AND
 // mnc=OldData[i].ToString() AND
 // countrycode=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM networkoperators " +SearchExp;
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
string alistsearch = "SELECT * FROM networkoperators";
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
string dtsearch = "SELECT * FROM networkoperators " +SearchExp;
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
string dtsearch = "SELECT * FROM networkoperators";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
