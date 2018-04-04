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
 
public class paymentwithpropertydetails
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public paymentwithpropertydetails()
{
 
  
 
}
 
public paymentwithpropertydetails (System.Int32 _idrecpayment,System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _dateofpayment,System.String _description1,System.String _description2,System.Decimal _amountpaid,System.Decimal _amountalocated,System.Int32 _active,System.Int32 _idcompany,System.String _codeofproperty,System.String _description,System.String _fdescription,System.String _address1,System.String _address2,System.String _address3 )
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
codeofproperty=_codeofproperty;
description=_description;
fdescription=_fdescription;
address1=_address1;
address2=_address2;
address3=_address3;
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
 
private System.String fdescription;
 
public System.String FDESCRIPTION
{
get
{
return fdescription;
}
set
{
fdescription=value;
}
}
 
private System.String address1;
 
public System.String ADDRESS1
{
get
{
return address1;
}
set
{
address1=value;
}
}
 
private System.String address2;
 
public System.String ADDRESS2
{
get
{
return address2;
}
set
{
address2=value;
}
}
 
private System.String address3;
 
public System.String ADDRESS3
{
get
{
return address3;
}
set
{
address3=value;
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
