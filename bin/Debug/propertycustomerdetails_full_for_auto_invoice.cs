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
 
public class propertycustomerdetails_full_for_auto_invoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomerdetails_full_for_auto_invoice()
{
 
  
 
}
 
public propertycustomerdetails_full_for_auto_invoice (System.Int32 _idproperty,System.Int32 _idcustomer,System.DateTime _leaseagdatefrom,System.DateTime _leaseagdateto,System.Int32 _idnotary,System.DateTime _dateofag,System.Int32 _active,System.DateTime _datefrom,System.Int32 _idpropertcustomerdetails,System.DateTime _dateto,System.Int32 _numberofdaystocreateinvoice,System.Decimal _amountforthatperiod,System.Decimal _amountpereachinvoice,System.String _description,System.Int32 _numberofinvoicestogenerate,System.String _generatedinvoicesfromthis,System.Int32 _idpropertycustomer,System.String _customerfullname,System.String _address1,System.String _address2,System.String _address3,System.String _contact,System.String _propertydescription,System.String _codeofproperty,System.String _groundrentaddressto,System.String _groudrentpaidto,System.DateTime _groundrentdueto )
{
idproperty=_idproperty;
idcustomer=_idcustomer;
leaseagdatefrom=_leaseagdatefrom;
leaseagdateto=_leaseagdateto;
idnotary=_idnotary;
dateofag=_dateofag;
active=_active;
datefrom=_datefrom;
idpropertcustomerdetails=_idpropertcustomerdetails;
dateto=_dateto;
numberofdaystocreateinvoice=_numberofdaystocreateinvoice;
amountforthatperiod=_amountforthatperiod;
amountpereachinvoice=_amountpereachinvoice;
description=_description;
numberofinvoicestogenerate=_numberofinvoicestogenerate;
generatedinvoicesfromthis=_generatedinvoicesfromthis;
idpropertycustomer=_idpropertycustomer;
customerfullname=_customerfullname;
address1=_address1;
address2=_address2;
address3=_address3;
contact=_contact;
propertydescription=_propertydescription;
codeofproperty=_codeofproperty;
groundrentaddressto=_groundrentaddressto;
groudrentpaidto=_groudrentpaidto;
groundrentdueto=_groundrentdueto;
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
 
private System.Int32 idpropertcustomerdetails;
 
public System.Int32 IDPROPERTCUSTOMERDETAILS
{
get
{
return idpropertcustomerdetails;
}
set
{
idpropertcustomerdetails=value;
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
 
private System.Int32 numberofdaystocreateinvoice;
 
public System.Int32 NUMBEROFDAYSTOCREATEINVOICE
{
get
{
return numberofdaystocreateinvoice;
}
set
{
numberofdaystocreateinvoice=value;
}
}
 
private System.Decimal amountforthatperiod;
 
public System.Decimal AMOUNTFORTHATPERIOD
{
get
{
return amountforthatperiod;
}
set
{
amountforthatperiod=value;
}
}
 
private System.Decimal amountpereachinvoice;
 
public System.Decimal AMOUNTPEREACHINVOICE
{
get
{
return amountpereachinvoice;
}
set
{
amountpereachinvoice=value;
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
 
private System.Int32 numberofinvoicestogenerate;
 
public System.Int32 NUMBEROFINVOICESTOGENERATE
{
get
{
return numberofinvoicestogenerate;
}
set
{
numberofinvoicestogenerate=value;
}
}
 
private System.String generatedinvoicesfromthis;
 
public System.String GENERATEDINVOICESFROMTHIS
{
get
{
return generatedinvoicesfromthis;
}
set
{
generatedinvoicesfromthis=value;
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
 
private System.String contact;
 
public System.String CONTACT
{
get
{
return contact;
}
set
{
contact=value;
}
}
 
private System.String propertydescription;
 
public System.String PROPERTYDESCRIPTION
{
get
{
return propertydescription;
}
set
{
propertydescription=value;
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
 
private System.String groundrentaddressto;
 
public System.String GROUNDRENTADDRESSTO
{
get
{
return groundrentaddressto;
}
set
{
groundrentaddressto=value;
}
}
 
private System.String groudrentpaidto;
 
public System.String GROUDRENTPAIDTO
{
get
{
return groudrentpaidto;
}
set
{
groudrentpaidto=value;
}
}
 
private System.DateTime groundrentdueto;
 
public System.DateTime GROUNDRENTDUETO
{
get
{
return groundrentdueto;
}
set
{
groundrentdueto=value;
}
}
 
 
public void New()
{
idproperty = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
