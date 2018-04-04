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
 
public class propertycustomerincrease
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomerincrease()
{
 
  
 
}
 
public propertycustomerincrease (System.Int32 _idpropertycustomerincrease,System.Int32 _idpropertycustomer,System.DateTime _datefrom,System.DateTime _dateto,System.Decimal _increaseperc,System.Decimal _increaseamount,System.Int32 _active,System.Int32 _idcompany )
{
idpropertycustomerincrease=_idpropertycustomerincrease;
idpropertycustomer=_idpropertycustomer;
datefrom=_datefrom;
dateto=_dateto;
increaseperc=_increaseperc;
increaseamount=_increaseamount;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idpropertycustomerincrease;
 
public System.Int32 IDPROPERTYCUSTOMERINCREASE
{
get
{
return idpropertycustomerincrease;
}
set
{
idpropertycustomerincrease=value;
}
}
 
private System.Int32 idpropertycustomer;
 
public System.Int32 IDPROPERTYCUSTOMER
{
get
{
return idpropertycustomer;
}
set
{
idpropertycustomer=value;
}
}
 
private System.DateTime datefrom;
 
public System.DateTime DATEFROM
{
get
{
return datefrom;
}
set
{
datefrom=value;
}
}
 
private System.DateTime dateto;
 
public System.DateTime DATETO
{
get
{
return dateto;
}
set
{
dateto=value;
}
}
 
private System.Decimal increaseperc;
 
public System.Decimal INCREASEPERC
{
get
{
return increaseperc;
}
set
{
increaseperc=value;
}
}
 
private System.Decimal increaseamount;
 
public System.Decimal INCREASEAMOUNT
{
get
{
return increaseamount;
}
set
{
increaseamount=value;
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
idpropertycustomerincrease = 0;
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
// INSERT INTO propertycustomerincrease(idPropertyCustomerincrease,idPropertyCustomer,DateFrom,DateTo,IncreasePerc,IncreaseAmount,Active,idCompany ) VALUES(idpropertycustomerincrease,idpropertycustomer,datefrom,dateto,increaseperc,increaseamount,active,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO propertycustomerincrease(idPropertyCustomer,DateFrom,DateTo,IncreasePerc,IncreaseAmount,Active,idCompany ) VALUES("+idpropertycustomer.ToString()+(char)44+(char)39+datefrom.ToString()+(char)39+(char)44+(char)39+dateto.ToString()+(char)39+(char)44+increaseperc.ToString()+(char)44+increaseamount.ToString()+(char)44+active.ToString()+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(propertycustomerincrease _propertycustomerincrease)
{
bool tmp = false;
int res = -1;
_propertycustomerincrease.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_propertycustomerincrease db_propertycustomerincrease = new DB_propertycustomerincrease();
if (_propertycustomerincrease.IDPROPERTYCUSTOMERINCREASE == 0)
{
res = db_propertycustomerincrease.Add(_propertycustomerincrease, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_propertycustomerincrease.Update(_propertycustomerincrease, conn, tran);
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
string mupdate = "UPDATE propertycustomerincrease SET "+"idPropertyCustomer="+idpropertycustomer.ToString()+(char)44+"DateFrom="+(char)39+datefrom.ToString()+(char)39+(char)44+"DateTo="+(char)39+dateto.ToString()+(char)39+(char)44+"IncreasePerc="+increaseperc.ToString()+(char)44+"IncreaseAmount="+increaseamount.ToString()+(char)44+"Active="+active.ToString()+(char)44+"idCompany="+idcompany.ToString()+" WHERE idPropertyCustomerincrease="+idpropertycustomerincrease.ToString();
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
string del = "DELETE FROM propertycustomerincrease WHERE idPropertyCustomerincrease="+idpropertycustomerincrease.ToString();
 // idPropertyCustomerincrease=OldData[i].ToString() AND
 // idPropertyCustomer=OldData[i].ToString() AND
 // DateFrom=OldData[i].ToString() AND
 // DateTo=OldData[i].ToString() AND
 // IncreasePerc=OldData[i].ToString() AND
 // IncreaseAmount=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM propertycustomerincrease " +SearchExp;
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
string alistsearch = "SELECT * FROM propertycustomerincrease";
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
string dtsearch = "SELECT * FROM propertycustomerincrease " +SearchExp;
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
string dtsearch = "SELECT * FROM propertycustomerincrease";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
