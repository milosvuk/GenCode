using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class openinghours
 
{
public string connString;
public string connectionString;
public openinghours()
{
  
 
 
}
 
public openinghours (System.Int32 _idrecopeningtimes,System.Decimal _openingtime,System.Decimal _closingtime,System.DateTime _dayofot,System.Int32 _active )
{
idrecopeningtimes=_idrecopeningtimes;
openingtime=_openingtime;
closingtime=_closingtime;
dayofot=_dayofot;
active=_active;
}
 
 
private System.Int32 idrecopeningtimes;
 
public System.Int32 IDRECOPENINGTIMES
{
get
{
return idrecopeningtimes;
}
set
{
idrecopeningtimes=value;
}
}
 
private System.Decimal openingtime;
 
public System.Decimal OPENINGTIME
{
get
{
return openingtime;
}
set
{
openingtime=value;
}
}
 
private System.Decimal closingtime;
 
public System.Decimal CLOSINGTIME
{
get
{
return closingtime;
}
set
{
closingtime=value;
}
}
 
private System.DateTime dayofot;
 
public System.DateTime DAYOFOT
{
get
{
return dayofot;
}
set
{
dayofot=value;
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
idrecopeningtimes = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
