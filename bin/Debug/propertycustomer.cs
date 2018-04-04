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
