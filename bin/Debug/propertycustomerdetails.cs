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
 
public class propertycustomerdetails
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomerdetails()
{
 
  
 
}
 
public propertycustomerdetails (System.Int32 _idpropertcustomerdetails,System.Int32 _id_propertycustomer,System.DateTime _datefrom,System.DateTime _dateto,System.Int32 _numberofdaystocreateinvoice,System.Decimal _amountforthatperiod,System.Decimal _amountpereachinvoice,System.String _description,System.Int32 _numberofinvoicestogenerate,System.String _generatedinvoicesfromthis,System.Int32 _active )
{
idpropertcustomerdetails=_idpropertcustomerdetails;
id_propertycustomer=_id_propertycustomer;
datefrom=_datefrom;
dateto=_dateto;
numberofdaystocreateinvoice=_numberofdaystocreateinvoice;
amountforthatperiod=_amountforthatperiod;
amountpereachinvoice=_amountpereachinvoice;
description=_description;
numberofinvoicestogenerate=_numberofinvoicestogenerate;
generatedinvoicesfromthis=_generatedinvoicesfromthis;
active=_active;
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
 
private System.Int32 id_propertycustomer;
 
public System.Int32 ID_PROPERTYCUSTOMER
{
get
{
return id_propertycustomer;
}
set
{
id_propertycustomer=value;
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
 
 
public void New()
{
idpropertcustomerdetails = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
