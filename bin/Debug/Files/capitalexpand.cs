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
 
public class capitalexpand
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public capitalexpand()
{
 
  
 
}
 
public capitalexpand (System.Int32 _idcapitalexp,System.Int32 _idproperty,System.Int32 _idexpense,System.DateTime _dateofcap,System.String _details,System.Decimal _amount,System.Int32 _active,System.Int32 _idcompany )
{
idcapitalexp=_idcapitalexp;
idproperty=_idproperty;
idexpense=_idexpense;
dateofcap=_dateofcap;
details=_details;
amount=_amount;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idcapitalexp;
 
public System.Int32 IDCAPITALEXP
{
get
{
return idcapitalexp;
}
set
{
idcapitalexp=value;
}
}
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
}
}
 
private System.Int32 idexpense;
 
public System.Int32 IDEXPENSE
{
get
{
return idexpense;
}
set
{
idexpense=value;
}
}
 
private System.DateTime dateofcap;
 
public System.DateTime DATEOFCAP
{
get
{
return dateofcap;
}
set
{
dateofcap=value;
}
}
 
private System.String details;
 
public System.String DETAILS
{
get
{
return details;
}
set
{
details=value;
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
idcapitalexp = 0;
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
// INSERT INTO capitalexpand(idCapitalExp,idProperty,IdExpense,DateOfCap,Details,Amount,Active,idCompany ) VALUES(idcapitalexp,idproperty,idexpense,dateofcap,details,amount,active,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO capitalexpand(idProperty,IdExpense,DateOfCap,Details,Amount,Active,idCompany ) VALUES("+idproperty.ToString()+(char)44+idexpense.ToString()+(char)44+(char)39+dateofcap.ToString()+(char)39+(char)44+(char)39+details.ToString()+(char)39+(char)44+amount.ToString()+(char)44+active.ToString()+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(capitalexpand _capitalexpand)
{
bool tmp = false;
int res = -1;
_capitalexpand.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_capitalexpand db_capitalexpand = new DB_capitalexpand();
if (_capitalexpand.IDCAPITALEXPAND == 0)
{
res = db_capitalexpand.Add(_capitalexpand, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_capitalexpand.Update(_capitalexpand, conn, tran);
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
string mupdate = "UPDATE capitalexpand SET "+"idProperty="+idproperty.ToString()+(char)44+"IdExpense="+idexpense.ToString()+(char)44+"DateOfCap="+(char)39+dateofcap.ToString()+(char)39+(char)44+"Details="+(char)39+details.ToString()+(char)39+(char)44+"Amount="+amount.ToString()+(char)44+"Active="+active.ToString()+(char)44+"idCompany="+idcompany.ToString()+" WHERE idCapitalExp="+idcapitalexp.ToString();
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
string del = "DELETE FROM capitalexpand WHERE idCapitalExp="+idcapitalexp.ToString();
 // idCapitalExp=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // IdExpense=OldData[i].ToString() AND
 // DateOfCap=OldData[i].ToString() AND
 // Details=OldData[i].ToString() AND
 // Amount=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM capitalexpand " +SearchExp;
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
string alistsearch = "SELECT * FROM capitalexpand";
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
string dtsearch = "SELECT * FROM capitalexpand " +SearchExp;
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
string dtsearch = "SELECT * FROM capitalexpand";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
