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
 
public class propertycustomerincrease
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public propertycustomerincrease()
{
 
  
 
}
 
public propertycustomerincrease (System.Int32 _idpropertycustomerincrease,System.Int32 _idpropertycustomer,System.DateTime _datefrom,System.DateTime _dateto,System.Decimal _increaseperc,System.Decimal _increaseamount,System.Int32 _active,System.Int32 _idcompany )
{
idpropertycustomerincrease=_idpropertycustomerincrease;
idpropertycustomer=_idpropertycustomer;
datefrom=_datefrom;
dateto=_dateto;
increaseperc=_increaseperc;
increaseamount=_increaseamount;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idpropertycustomerincrease;
 
public System.Int32 IDPROPERTYCUSTOMERINCREASE
{
get
{
return idpropertycustomerincrease;
}
set
{
idpropertycustomerincrease=value;
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
 
private System.Decimal increaseperc;
 
public System.Decimal INCREASEPERC
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
idpropertycustomerincrease = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
