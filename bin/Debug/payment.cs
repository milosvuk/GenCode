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
