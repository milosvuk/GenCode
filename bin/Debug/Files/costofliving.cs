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
 
public class costofliving
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public costofliving()
{
 
  
 
}
 
public costofliving (System.Int32 _idreccostofliving,System.Decimal _increaseinperc,System.DateTime _startdate,System.Int32 _active,System.Int32 _idcompany )
{
idreccostofliving=_idreccostofliving;
increaseinperc=_increaseinperc;
startdate=_startdate;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idreccostofliving;
 
public System.Int32 IDRECCOSTOFLIVING
{
get
{
return idreccostofliving;
}
set
{
idreccostofliving=value;
}
}
 
private System.Decimal increaseinperc;
 
public System.Decimal INCREASEINPERC
{
get
{
return increaseinperc;
}
set
{
increaseinperc=value;
}
}
 
private System.DateTime startdate;
 
public System.DateTime STARTDATE
{
get
{
return startdate;
}
set
{
startdate=value;
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
idreccostofliving = 0;
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
// INSERT INTO costofliving(idRecCostOfLiving,IncreaseInPerc,StartDate,Active,idCompany ) VALUES(idreccostofliving,increaseinperc,startdate,active,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO costofliving(IncreaseInPerc,StartDate,Active,idCompany ) VALUES("+increaseinperc.ToString()+(char)44+(char)39+startdate.ToString()+(char)39+(char)44+active.ToString()+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(costofliving _costofliving)
{
bool tmp = false;
int res = -1;
_costofliving.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_costofliving db_costofliving = new DB_costofliving();
if (_costofliving.IDCOSTOFLIVING == 0)
{
res = db_costofliving.Add(_costofliving, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_costofliving.Update(_costofliving, conn, tran);
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
string mupdate = "UPDATE costofliving SET "+"IncreaseInPerc="+increaseinperc.ToString()+(char)44+"StartDate="+(char)39+startdate.ToString()+(char)39+(char)44+"Active="+active.ToString()+(char)44+"idCompany="+idcompany.ToString()+" WHERE idRecCostOfLiving="+idreccostofliving.ToString();
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
string del = "DELETE FROM costofliving WHERE idRecCostOfLiving="+idreccostofliving.ToString();
 // idRecCostOfLiving=OldData[i].ToString() AND
 // IncreaseInPerc=OldData[i].ToString() AND
 // StartDate=OldData[i].ToString() AND
 // Active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM costofliving " +SearchExp;
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
string alistsearch = "SELECT * FROM costofliving";
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
string dtsearch = "SELECT * FROM costofliving " +SearchExp;
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
string dtsearch = "SELECT * FROM costofliving";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
