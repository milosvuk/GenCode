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
 
public class allocate_with_details_invoice_and_payment
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public allocate_with_details_invoice_and_payment()
{
 
  
 
}
 
public allocate_with_details_invoice_and_payment (System.Int32 _idrecalocate,System.Int32 _idinvoice,System.Int32 _idpayment,System.Decimal _amount,System.Int32 _idrecinv,System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _dateofinv,System.Int32 _idexpense,System.Decimal _taxperc,System.Decimal _taxamount,System.Decimal _totalamount,System.Decimal _amountpaid,System.Int32 _finalized,System.String _description,System.DateTime _dateofpayment,System.String _description1,System.String _description2,System.Decimal _paymentamount,System.Decimal _amountalocated )
{
idrecalocate=_idrecalocate;
idinvoice=_idinvoice;
idpayment=_idpayment;
amount=_amount;
idrecinv=_idrecinv;
idproperty=_idproperty;
idcustomer=_idcustomer;
dateofinv=_dateofinv;
idexpense=_idexpense;
taxperc=_taxperc;
taxamount=_taxamount;
totalamount=_totalamount;
amountpaid=_amountpaid;
finalized=_finalized;
description=_description;
dateofpayment=_dateofpayment;
description1=_description1;
description2=_description2;
paymentamount=_paymentamount;
amountalocated=_amountalocated;
}
 
 
private System.Int32 idrecalocate;
 
public System.Int32 IDRECALOCATE
{
get
{
return idrecalocate;
}
set
{
idrecalocate=value;
}
}
 
private System.Int32 idinvoice;
 
public System.Int32 IDINVOICE
{
get
{
return idinvoice;
}
set
{
idinvoice=value;
}
}
 
private System.Int32 idpayment;
 
public System.Int32 IDPAYMENT
{
get
{
return idpayment;
}
set
{
idpayment=value;
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
 
private System.Decimal paymentamount;
 
public System.Decimal PAYMENTAMOUNT
{
get
{
return paymentamount;
}
set
{
paymentamount=value;
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
 
 
public void New()
{
idrecalocate = 0;
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
// INSERT INTO allocate_with_details_invoice_and_payment(idRecAlocate,idInvoice,idPayment,Amount,idRecInv,idProperty,idCustomer,DateOfInv,idExpense,TaxPerc,TaxAmount,TotalAmount,AmountPaid,Finalized,Description,DateOfPayment,Description1,Description2,PaymentAmount,AmountAlocated ) VALUES(idrecalocate,idinvoice,idpayment,amount,idrecinv,idproperty,idcustomer,dateofinv,idexpense,taxperc,taxamount,totalamount,amountpaid,finalized,description,dateofpayment,description1,description2,paymentamount,amountalocated );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO allocate_with_details_invoice_and_payment(idInvoice,idPayment,Amount,idRecInv,idProperty,idCustomer,DateOfInv,idExpense,TaxPerc,TaxAmount,TotalAmount,AmountPaid,Finalized,Description,DateOfPayment,Description1,Description2,PaymentAmount,AmountAlocated ) VALUES("+idinvoice.ToString()+(char)44+idpayment.ToString()+(char)44+amount.ToString()+(char)44+idrecinv.ToString()+(char)44+idproperty.ToString()+(char)44+idcustomer.ToString()+(char)44+(char)39+dateofinv.ToString()+(char)39+(char)44+idexpense.ToString()+(char)44+taxperc.ToString()+(char)44+taxamount.ToString()+(char)44+totalamount.ToString()+(char)44+amountpaid.ToString()+(char)44+finalized.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+(char)39+dateofpayment.ToString()+(char)39+(char)44+(char)39+description1.ToString()+(char)39+(char)44+(char)39+description2.ToString()+(char)39+(char)44+paymentamount.ToString()+(char)44+amountalocated.ToString()+(char)41;
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
public bool Save(allocate_with_details_invoice_and_payment _allocate_with_details_invoice_and_payment)
{
bool tmp = false;
int res = -1;
_allocate_with_details_invoice_and_payment.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_allocate_with_details_invoice_and_payment db_allocate_with_details_invoice_and_payment = new DB_allocate_with_details_invoice_and_payment();
if (_allocate_with_details_invoice_and_payment.IDALLOCATE_WITH_DETAILS_INVOICE_AND_PAYMENT == 0)
{
res = db_allocate_with_details_invoice_and_payment.Add(_allocate_with_details_invoice_and_payment, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_allocate_with_details_invoice_and_payment.Update(_allocate_with_details_invoice_and_payment, conn, tran);
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
string mupdate = "UPDATE allocate_with_details_invoice_and_payment SET "+"idInvoice="+idinvoice.ToString()+(char)44+"idPayment="+idpayment.ToString()+(char)44+"Amount="+amount.ToString()+(char)44+"idRecInv="+idrecinv.ToString()+(char)44+"idProperty="+idproperty.ToString()+(char)44+"idCustomer="+idcustomer.ToString()+(char)44+"DateOfInv="+(char)39+dateofinv.ToString()+(char)39+(char)44+"idExpense="+idexpense.ToString()+(char)44+"TaxPerc="+taxperc.ToString()+(char)44+"TaxAmount="+taxamount.ToString()+(char)44+"TotalAmount="+totalamount.ToString()+(char)44+"AmountPaid="+amountpaid.ToString()+(char)44+"Finalized="+finalized.ToString()+(char)44+"Description="+(char)39+description.ToString()+(char)39+(char)44+"DateOfPayment="+(char)39+dateofpayment.ToString()+(char)39+(char)44+"Description1="+(char)39+description1.ToString()+(char)39+(char)44+"Description2="+(char)39+description2.ToString()+(char)39+(char)44+"PaymentAmount="+paymentamount.ToString()+(char)44+"AmountAlocated="+amountalocated.ToString()+" WHERE idRecAlocate="+idrecalocate.ToString();
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
string del = "DELETE FROM allocate_with_details_invoice_and_payment WHERE idRecAlocate="+idrecalocate.ToString();
 // idRecAlocate=OldData[i].ToString() AND
 // idInvoice=OldData[i].ToString() AND
 // idPayment=OldData[i].ToString() AND
 // Amount=OldData[i].ToString() AND
 // idRecInv=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // idCustomer=OldData[i].ToString() AND
 // DateOfInv=OldData[i].ToString() AND
 // idExpense=OldData[i].ToString() AND
 // TaxPerc=OldData[i].ToString() AND
 // TaxAmount=OldData[i].ToString() AND
 // TotalAmount=OldData[i].ToString() AND
 // AmountPaid=OldData[i].ToString() AND
 // Finalized=OldData[i].ToString() AND
 // Description=OldData[i].ToString() AND
 // DateOfPayment=OldData[i].ToString() AND
 // Description1=OldData[i].ToString() AND
 // Description2=OldData[i].ToString() AND
 // PaymentAmount=OldData[i].ToString() AND
 // AmountAlocated=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM allocate_with_details_invoice_and_payment " +SearchExp;
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
string alistsearch = "SELECT * FROM allocate_with_details_invoice_and_payment";
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
string dtsearch = "SELECT * FROM allocate_with_details_invoice_and_payment " +SearchExp;
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
string dtsearch = "SELECT * FROM allocate_with_details_invoice_and_payment";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
