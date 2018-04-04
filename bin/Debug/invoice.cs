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
 
public class invoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public invoice()
{
 
  
 
}
 
public invoice (System.Int32 _idrecinv,System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _dateofinv,System.Int32 _idexpense,System.Decimal _amount,System.Decimal _taxperc,System.Decimal _taxamount,System.Decimal _totalamount,System.Decimal _amountpaid,System.Int32 _finalized,System.String _description,System.Int32 _id_propertycustomerdetails,System.Int32 _active,System.Int32 _idcompany )
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
id_propertycustomerdetails=_id_propertycustomerdetails;
active=_active;
idcompany=_idcompany;
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
 
private System.Int32 id_propertycustomerdetails;
 
public System.Int32 ID_PROPERTYCUSTOMERDETAILS
{
get
{
return id_propertycustomerdetails;
}
set
{
id_propertycustomerdetails=value;
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
idrecinv = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
