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
 
public class invoice_full_details_not_paid
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public invoice_full_details_not_paid()
{
 
  
 
}
 
public invoice_full_details_not_paid (System.Int32 _idrecinv,System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _dateofinv,System.Int32 _idexpense,System.Decimal _amount,System.Decimal _taxperc,System.Decimal _taxamount,System.Decimal _totalamount,System.Decimal _amountpaid,System.Int32 _finalized,System.String _description,System.Int32 _active,System.Int32 _idcompany,System.String _customerfullname,System.String _codeofproperty,System.String _propertyname,System.String _expensedesc )
{
idrecinv=_idrecinv;
idproperty=_idproperty;
idcustomer=_idcustomer;
dateofinv=_dateofinv;
idexpense=_idexpense;
amount=_amount;
taxperc=_taxperc;
taxamount=_taxamount;
totalamount=_totalamount;
amountpaid=_amountpaid;
finalized=_finalized;
description=_description;
active=_active;
idcompany=_idcompany;
customerfullname=_customerfullname;
codeofproperty=_codeofproperty;
propertyname=_propertyname;
expensedesc=_expensedesc;
}
 
 
private System.Int32 idrecinv;
 
public System.Int32 IDRECINV
{
get
{
return idrecinv;
}
set
{
idrecinv=value;
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
 
private System.DateTime dateofinv;
 
public System.DateTime DATEOFINV
{
get
{
return dateofinv;
}
set
{
dateofinv=value;
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
 
private System.Decimal taxperc;
 
public System.Decimal TAXPERC
{
get
{
return taxperc;
}
set
{
taxperc=value;
}
}
 
private System.Decimal taxamount;
 
public System.Decimal TAXAMOUNT
{
get
{
return taxamount;
}
set
{
taxamount=value;
}
}
 
private System.Decimal totalamount;
 
public System.Decimal TOTALAMOUNT
{
get
{
return totalamount;
}
set
{
totalamount=value;
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
 
private System.Int32 finalized;
 
public System.Int32 FINALIZED
{
get
{
return finalized;
}
set
{
finalized=value;
}
}
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
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
 
private System.String customerfullname;
 
public System.String CUSTOMERFULLNAME
{
get
{
return customerfullname;
}
set
{
customerfullname=value;
}
}
 
private System.String codeofproperty;
 
public System.String CODEOFPROPERTY
{
get
{
return codeofproperty;
}
set
{
codeofproperty=value;
}
}
 
private System.String propertyname;
 
public System.String PROPERTYNAME
{
get
{
return propertyname;
}
set
{
propertyname=value;
}
}
 
private System.String expensedesc;
 
public System.String EXPENSEDESC
{
get
{
return expensedesc;
}
set
{
expensedesc=value;
}
}
 
 
public void New()
{
idrecinv = 0;
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
// INSERT INTO invoice_full_details_not_paid(idRecInv,idProperty,idCustomer,DateOfInv,idExpense,Amount,TaxPerc,TaxAmount,TotalAmount,AmountPaid,Finalized,Description,Active,idCompany,CustomerFullName,CodeOfProperty,propertyname,expenseDesc ) VALUES(idrecinv,idproperty,idcustomer,dateofinv,idexpense,amount,taxperc,taxamount,totalamount,amountpaid,finalized,description,active,idcompany,customerfullname,codeofproperty,propertyname,expensedesc );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO invoice_full_details_not_paid(idProperty,idCustomer,DateOfInv,idExpense,Amount,TaxPerc,TaxAmount,TotalAmount,AmountPaid,Finalized,Description,Active,idCompany,CustomerFullName,CodeOfProperty,propertyname,expenseDesc ) VALUES("+idproperty.ToString()+(char)44+idcustomer.ToString()+(char)44+(char)39+dateofinv.ToString()+(char)39+(char)44+idexpense.ToString()+(char)44+amount.ToString()+(char)44+taxperc.ToString()+(char)44+taxamount.ToString()+(char)44+totalamount.ToString()+(char)44+amountpaid.ToString()+(char)44+finalized.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+active.ToString()+(char)44+idcompany.ToString()+(char)44+(char)39+customerfullname.ToString()+(char)39+(char)44+(char)39+codeofproperty.ToString()+(char)39+(char)44+(char)39+propertyname.ToString()+(char)39+(char)44+(char)39+expensedesc.ToString()+(char)39+(char)41;
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
public bool Save(invoice_full_details_not_paid _invoice_full_details_not_paid)
{
bool tmp = false;
int res = -1;
_invoice_full_details_not_paid.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_invoice_full_details_not_paid db_invoice_full_details_not_paid = new DB_invoice_full_details_not_paid();
if (_invoice_full_details_not_paid.IDINVOICE_FULL_DETAILS_NOT_PAID == 0)
{
res = db_invoice_full_details_not_paid.Add(_invoice_full_details_not_paid, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_invoice_full_details_not_paid.Update(_invoice_full_details_not_paid, conn, tran);
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
string mupdate = "UPDATE invoice_full_details_not_paid SET "+"idProperty="+idproperty.ToString()+(char)44+"idCustomer="+idcustomer.ToString()+(char)44+"DateOfInv="+(char)39+dateofinv.ToString()+(char)39+(char)44+"idExpense="+idexpense.ToString()+(char)44+"Amount="+amount.ToString()+(char)44+"TaxPerc="+taxperc.ToString()+(char)44+"TaxAmount="+taxamount.ToString()+(char)44+"TotalAmount="+totalamount.ToString()+(char)44+"AmountPaid="+amountpaid.ToString()+(char)44+"Finalized="+finalized.ToString()+(char)44+"Description="+(char)39+description.ToString()+(char)39+(char)44+"Active="+active.ToString()+(char)44+"idCompany="+idcompany.ToString()+(char)44+"CustomerFullName="+(char)39+customerfullname.ToString()+(char)39+(char)44+"CodeOfProperty="+(char)39+codeofproperty.ToString()+(char)39+(char)44+"propertyname="+(char)39+propertyname.ToString()+(char)39+(char)44+"expenseDesc="+(char)39+expensedesc.ToString()+(char)39+" WHERE idRecInv="+idrecinv.ToString();
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
string del = "DELETE FROM invoice_full_details_not_paid WHERE idRecInv="+idrecinv.ToString();
 // idRecInv=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // idCustomer=OldData[i].ToString() AND
 // DateOfInv=OldData[i].ToString() AND
 // idExpense=OldData[i].ToString() AND
 // Amount=OldData[i].ToString() AND
 // TaxPerc=OldData[i].ToString() AND
 // TaxAmount=OldData[i].ToString() AND
 // TotalAmount=OldData[i].ToString() AND
 // AmountPaid=OldData[i].ToString() AND
 // Finalized=OldData[i].ToString() AND
 // Description=OldData[i].ToString() AND
 // Active=OldData[i].ToString() AND
 // idCompany=OldData[i].ToString() AND
 // CustomerFullName=OldData[i].ToString() AND
 // CodeOfProperty=OldData[i].ToString() AND
 // propertyname=OldData[i].ToString() AND
 // expenseDesc=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM invoice_full_details_not_paid " +SearchExp;
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
string alistsearch = "SELECT * FROM invoice_full_details_not_paid";
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
string dtsearch = "SELECT * FROM invoice_full_details_not_paid " +SearchExp;
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
string dtsearch = "SELECT * FROM invoice_full_details_not_paid";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
