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
 
public class propertycustomer
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomer()
{
 
  
 
}
 
public propertycustomer (System.Int32 _idpropertycustomer,System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _leaseagdatefrom,System.DateTime _leaseagdateto,System.Int32 _idnotary,System.DateTime _dateofag,System.Int32 _frenqofpayment,System.Decimal _amountofcontract,System.Int32 _increaseperc,System.Decimal _increaseamount,System.Int32 _increasecostofliving,System.Int32 _freqindaystoapplyincrease,System.DateTime _dateoflastinvoice,System.Decimal _amtoflastinvoice,System.Int32 _active,System.Int32 _idcompany )
{
idpropertycustomer=_idpropertycustomer;
idproperty=_idproperty;
idcustomer=_idcustomer;
leaseagdatefrom=_leaseagdatefrom;
leaseagdateto=_leaseagdateto;
idnotary=_idnotary;
dateofag=_dateofag;
frenqofpayment=_frenqofpayment;
amountofcontract=_amountofcontract;
increaseperc=_increaseperc;
increaseamount=_increaseamount;
increasecostofliving=_increasecostofliving;
freqindaystoapplyincrease=_freqindaystoapplyincrease;
dateoflastinvoice=_dateoflastinvoice;
amtoflastinvoice=_amtoflastinvoice;
active=_active;
idcompany=_idcompany;
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
 
private System.Int32 idcustomer;
 
public System.Int32 IDCUSTOMER
{
get
{
return idcustomer;
}
set
{
idcustomer=value;
}
}
 
private System.DateTime leaseagdatefrom;
 
public System.DateTime LEASEAGDATEFROM
{
get
{
return leaseagdatefrom;
}
set
{
leaseagdatefrom=value;
}
}
 
private System.DateTime leaseagdateto;
 
public System.DateTime LEASEAGDATETO
{
get
{
return leaseagdateto;
}
set
{
leaseagdateto=value;
}
}
 
private System.Int32 idnotary;
 
public System.Int32 IDNOTARY
{
get
{
return idnotary;
}
set
{
idnotary=value;
}
}
 
private System.DateTime dateofag;
 
public System.DateTime DATEOFAG
{
get
{
return dateofag;
}
set
{
dateofag=value;
}
}
 
private System.Int32 frenqofpayment;
 
public System.Int32 FRENQOFPAYMENT
{
get
{
return frenqofpayment;
}
set
{
frenqofpayment=value;
}
}
 
private System.Decimal amountofcontract;
 
public System.Decimal AMOUNTOFCONTRACT
{
get
{
return amountofcontract;
}
set
{
amountofcontract=value;
}
}
 
private System.Int32 increaseperc;
 
public System.Int32 INCREASEPERC
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
 
private System.Int32 increasecostofliving;
 
public System.Int32 INCREASECOSTOFLIVING
{
get
{
return increasecostofliving;
}
set
{
increasecostofliving=value;
}
}
 
private System.Int32 freqindaystoapplyincrease;
 
public System.Int32 FREQINDAYSTOAPPLYINCREASE
{
get
{
return freqindaystoapplyincrease;
}
set
{
freqindaystoapplyincrease=value;
}
}
 
private System.DateTime dateoflastinvoice;
 
public System.DateTime DATEOFLASTINVOICE
{
get
{
return dateoflastinvoice;
}
set
{
dateoflastinvoice=value;
}
}
 
private System.Decimal amtoflastinvoice;
 
public System.Decimal AMTOFLASTINVOICE
{
get
{
return amtoflastinvoice;
}
set
{
amtoflastinvoice=value;
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
idpropertycustomer = 0;
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
// INSERT INTO propertycustomer(idPropertyCustomer,idProperty,idCustomer,LeaseAgDateFrom,LeaseAgDateTo,idNotary,DateOfAg,FrenqOfPayment,AmountOfContract,IncreasePerc,IncreaseAmount,IncreaseCostOfLiving,FreqInDaysToApplyIncrease,DateofLastinvoice,AmtOfLastInvoice,Active,idCompany ) VALUES(idpropertycustomer,idproperty,idcustomer,leaseagdatefrom,leaseagdateto,idnotary,dateofag,frenqofpayment,amountofcontract,increaseperc,increaseamount,increasecostofliving,freqindaystoapplyincrease,dateoflastinvoice,amtoflastinvoice,active,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO propertycustomer(idProperty,idCustomer,LeaseAgDateFrom,LeaseAgDateTo,idNotary,DateOfAg,FrenqOfPayment,AmountOfContract,IncreasePerc,IncreaseAmount,IncreaseCostOfLiving,FreqInDaysToApplyIncrease,DateofLastinvoice,AmtOfLastInvoice,Active,idCompany ) VALUES("+idproperty.ToString()+(char)44+idcustomer.ToString()+(char)44+(char)39+leaseagdatefrom.ToString()+(char)39+(char)44+(char)39+leaseagdateto.ToString()+(char)39+(char)44+idnotary.ToString()+(char)44+(char)39+dateofag.ToString()+(char)39+(char)44+frenqofpayment.ToString()+(char)44+amountofcontract.ToString()+(char)44+increaseperc.ToString()+(char)44+increaseamount.ToString()+(char)44+increasecostofliving.ToString()+(char)44+freqindaystoapplyincrease.ToString()+(char)44+(char)39+dateoflastinvoice.ToString()+(char)39+(char)44+amtoflastinvoice.ToString()+(char)44+active.ToString()+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(propertycustomer _propertycustomer)
{
bool tmp = false;
int res = -1;
_propertycustomer.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_propertycustomer db_propertycustomer = new DB_propertycustomer();
if (_propertycustomer.IDPROPERTYCUSTOMER == 0)
{
res = db_propertycustomer.Add(_propertycustomer, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_propertycustomer.Update(_propertycustomer, conn, tran);
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
string mupdate = "UPDATE propertycustomer SET "+"idProperty="+idproperty.ToString()+(char)44+"idCustomer="+idcustomer.ToString()+(char)44+"LeaseAgDateFrom="+(char)39+leaseagdatefrom.ToString()+(char)39+(char)44+"LeaseAgDateTo="+(char)39+leaseagdateto.ToString()+(char)39+(char)44+"idNotary="+idnotary.ToString()+(char)44+"DateOfAg="+(char)39+dateofag.ToString()+(char)39+(char)44+"FrenqOfPayment="+frenqofpayment.ToString()+(char)44+"AmountOfContract="+amountofcontract.ToString()+(char)44+"IncreasePerc="+increaseperc.ToString()+(char)44+"IncreaseAmount="+increaseamount.ToString()+(char)44+"IncreaseCostOfLiving="+increasecostofliving.ToString()+(char)44+"FreqInDaysToApplyIncrease="+freqindaystoapplyincrease.ToString()+(char)44+"DateofLastinvoice="+(char)39+dateoflastinvoice.ToString()+(char)39+(char)44+"AmtOfLastInvoice="+amtoflastinvoice.ToString()+(char)44+"Active="+active.ToString()+(char)44+"idCompany="+idcompany.ToString()+" WHERE idPropertyCustomer="+idpropertycustomer.ToString();
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
string del = "DELETE FROM propertycustomer WHERE idPropertyCustomer="+idpropertycustomer.ToString();
 // idPropertyCustomer=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // idCustomer=OldData[i].ToString() AND
 // LeaseAgDateFrom=OldData[i].ToString() AND
 // LeaseAgDateTo=OldData[i].ToString() AND
 // idNotary=OldData[i].ToString() AND
 // DateOfAg=OldData[i].ToString() AND
 // FrenqOfPayment=OldData[i].ToString() AND
 // AmountOfContract=OldData[i].ToString() AND
 // IncreasePerc=OldData[i].ToString() AND
 // IncreaseAmount=OldData[i].ToString() AND
 // IncreaseCostOfLiving=OldData[i].ToString() AND
 // FreqInDaysToApplyIncrease=OldData[i].ToString() AND
 // DateofLastinvoice=OldData[i].ToString() AND
 // AmtOfLastInvoice=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM propertycustomer " +SearchExp;
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
string alistsearch = "SELECT * FROM propertycustomer";
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
string dtsearch = "SELECT * FROM propertycustomer " +SearchExp;
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
string dtsearch = "SELECT * FROM propertycustomer";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
