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
 
public class payment
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public payment()
{
 
  
 
}
 
public payment (System.Int32 _idrecpayment,System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _dateofpayment,System.String _description1,System.String _description2,System.Decimal _amountpaid,System.Decimal _amountalocated,System.Int32 _active,System.Int32 _idcompany )
{
idrecpayment=_idrecpayment;
idproperty=_idproperty;
idcustomer=_idcustomer;
dateofpayment=_dateofpayment;
description1=_description1;
description2=_description2;
amountpaid=_amountpaid;
amountalocated=_amountalocated;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idrecpayment;
 
public System.Int32 IDRECPAYMENT
{
get
{
return idrecpayment;
}
set
{
idrecpayment=value;
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
 
private System.DateTime dateofpayment;
 
public System.DateTime DATEOFPAYMENT
{
get
{
return dateofpayment;
}
set
{
dateofpayment=value;
}
}
 
private System.String description1;
 
public System.String DESCRIPTION1
{
get
{
return description1;
}
set
{
description1=value;
}
}
 
private System.String description2;
 
public System.String DESCRIPTION2
{
get
{
return description2;
}
set
{
description2=value;
}
}
 
private System.Decimal amountpaid;
 
public System.Decimal AMOUNTPAID
{
get
{
return amountpaid;
}
set
{
amountpaid=value;
}
}
 
private System.Decimal amountalocated;
 
public System.Decimal AMOUNTALOCATED
{
get
{
return amountalocated;
}
set
{
amountalocated=value;
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
idrecpayment = 0;
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
// INSERT INTO payment(idRecPayment,idProperty,idCustomer,DateOfPayment,Description1,Description2,AmountPaid,AmountAlocated,Active,idCompany ) VALUES(idrecpayment,idproperty,idcustomer,dateofpayment,description1,description2,amountpaid,amountalocated,active,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO payment(idProperty,idCustomer,DateOfPayment,Description1,Description2,AmountPaid,AmountAlocated,Active,idCompany ) VALUES("+idproperty.ToString()+(char)44+idcustomer.ToString()+(char)44+(char)39+dateofpayment.ToString()+(char)39+(char)44+(char)39+description1.ToString()+(char)39+(char)44+(char)39+description2.ToString()+(char)39+(char)44+amountpaid.ToString()+(char)44+amountalocated.ToString()+(char)44+active.ToString()+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(payment _payment)
{
bool tmp = false;
int res = -1;
_payment.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_payment db_payment = new DB_payment();
if (_payment.IDPAYMENT == 0)
{
res = db_payment.Add(_payment, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_payment.Update(_payment, conn, tran);
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
string mupdate = "UPDATE payment SET "+"idProperty="+idproperty.ToString()+(char)44+"idCustomer="+idcustomer.ToString()+(char)44+"DateOfPayment="+(char)39+dateofpayment.ToString()+(char)39+(char)44+"Description1="+(char)39+description1.ToString()+(char)39+(char)44+"Description2="+(char)39+description2.ToString()+(char)39+(char)44+"AmountPaid="+amountpaid.ToString()+(char)44+"AmountAlocated="+amountalocated.ToString()+(char)44+"Active="+active.ToString()+(char)44+"idCompany="+idcompany.ToString()+" WHERE idRecPayment="+idrecpayment.ToString();
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
string del = "DELETE FROM payment WHERE idRecPayment="+idrecpayment.ToString();
 // idRecPayment=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // idCustomer=OldData[i].ToString() AND
 // DateOfPayment=OldData[i].ToString() AND
 // Description1=OldData[i].ToString() AND
 // Description2=OldData[i].ToString() AND
 // AmountPaid=OldData[i].ToString() AND
 // AmountAlocated=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM payment " +SearchExp;
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
string alistsearch = "SELECT * FROM payment";
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
string dtsearch = "SELECT * FROM payment " +SearchExp;
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
string dtsearch = "SELECT * FROM payment";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
