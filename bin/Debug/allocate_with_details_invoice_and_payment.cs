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
