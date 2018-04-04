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
 
public class costofliving
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public costofliving()
{
 
  
 
}
 
public costofliving (System.Int32 _idreccostofliving,System.Decimal _increaseinperc,System.DateTime _startdate,System.Int32 _active,System.Int32 _idcompany )
{
idreccostofliving=_idreccostofliving;
increaseinperc=_increaseinperc;
startdate=_startdate;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idreccostofliving;
 
public System.Int32 IDRECCOSTOFLIVING
{
get
{
return idreccostofliving;
}
set
{
idreccostofliving=value;
}
}
 
private System.Decimal increaseinperc;
 
public System.Decimal INCREASEINPERC
{
get
{
return increaseinperc;
}
set
{
increaseinperc=value;
}
}
 
private System.DateTime startdate;
 
public System.DateTime STARTDATE
{
get
{
return startdate;
}
set
{
startdate=value;
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
idreccostofliving = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
