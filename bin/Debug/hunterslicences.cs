using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class hunterslicences
 
{
public string connString;
public string connectionString;
public hunterslicences()
{
  
 
 
}
 
public hunterslicences (System.Int32 _idrechunterslicenced,System.Int32 _idrechunter,System.Int32 _idreclicence,System.Int32 _licenceyear,System.Int32 _paid,System.Decimal _amount,System.String _comments,System.Int32 _active )
{
idrechunterslicenced=_idrechunterslicenced;
idrechunter=_idrechunter;
idreclicence=_idreclicence;
licenceyear=_licenceyear;
paid=_paid;
amount=_amount;
comments=_comments;
active=_active;
}
 
 
private System.Int32 idrechunterslicenced;
 
public System.Int32 IDRECHUNTERSLICENCED
{
get
{
return idrechunterslicenced;
}
set
{
idrechunterslicenced=value;
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
 
private System.Int32 idreclicence;
 
public System.Int32 IDRECLICENCE
{
get
{
return idreclicence;
}
set
{
idreclicence=value;
}
}
 
private System.Int32 licenceyear;
 
public System.Int32 LICENCEYEAR
{
get
{
return licenceyear;
}
set
{
licenceyear=value;
}
}
 
private System.Int32 paid;
 
public System.Int32 PAID
{
get
{
return paid;
}
set
{
paid=value;
}
}
 
private System.Decimal amount;
 
public System.Decimal AMOUNT
{
get
{
return amount;
}
set
{
amount=value;
}
}
 
private System.String comments;
 
public System.String COMMENTS
{
get
{
return comments;
}
set
{
comments=value;
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
idrechunterslicenced = 0;
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
// INSERT INTO hunterslicences(idRecHuntersLicenced,idRecHunter,idRecLicence,LicenceYear,Paid,Amount,Comments,Active ) VALUES(idrechunterslicenced,idrechunter,idreclicence,licenceyear,paid,amount,comments,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO hunterslicences(idRecHunter,idRecLicence,LicenceYear,Paid,Amount,Comments,Active ) VALUES("+idrechunter.ToString()+(char)44+idreclicence.ToString()+(char)44+licenceyear.ToString()+(char)44+paid.ToString()+(char)44+amount.ToString()+(char)44+(char)39+comments.ToString()+(char)39+(char)44+active.ToString()+(char)41;
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
public bool Save(hunterslicences _hunterslicences)
{
bool tmp = false;
int res = -1;
_hunterslicences.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_hunterslicences db_hunterslicences = new DB_hunterslicences();
if (_hunterslicences.IDHUNTERSLICENCES == 0)
{
res = db_hunterslicences.Add(_hunterslicences, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_hunterslicences.Update(_hunterslicences, conn, tran);
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
string mupdate = "UPDATE hunterslicences SET "+"idRecHunter="+idrechunter.ToString()+(char)44+"idRecLicence="+idreclicence.ToString()+(char)44+"LicenceYear="+licenceyear.ToString()+(char)44+"Paid="+paid.ToString()+(char)44+"Amount="+amount.ToString()+(char)44+"Comments="+(char)39+comments.ToString()+(char)39+(char)44+"Active="+active.ToString()+" WHERE idRecHuntersLicenced="+idrechunterslicenced.ToString();
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
string del = "DELETE FROM hunterslicences WHERE idRecHuntersLicenced="+idrechunterslicenced.ToString();
 // idRecHuntersLicenced=OldData[i].ToString() AND
 // idRecHunter=OldData[i].ToString() AND
 // idRecLicence=OldData[i].ToString() AND
 // LicenceYear=OldData[i].ToString() AND
 // Paid=OldData[i].ToString() AND
 // Amount=OldData[i].ToString() AND
 // Comments=OldData[i].ToString() AND
 // Active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM hunterslicences " +SearchExp;
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
string alistsearch = "SELECT * FROM hunterslicences";
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
string dtsearch = "SELECT * FROM hunterslicences " +SearchExp;
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
string dtsearch = "SELECT * FROM hunterslicences";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
