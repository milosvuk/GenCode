using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class rejectedcalls
 
{
public string connString;
public string connectionString;
public rejectedcalls()
{
  
 
 
}
 
public rejectedcalls (System.Int32 _idrecrejectedcall,System.String _mobilenumber,System.DateTime _datetime,System.String _description,System.Int32 _active )
{
idrecrejectedcall=_idrecrejectedcall;
mobilenumber=_mobilenumber;
datetime=_datetime;
description=_description;
active=_active;
}
 
 
private System.Int32 idrecrejectedcall;
 
public System.Int32 IDRECREJECTEDCALL
{
get
{
return idrecrejectedcall;
}
set
{
idrecrejectedcall=value;
}
}
 
private System.String mobilenumber;
 
public System.String MOBILENUMBER
{
get
{
return mobilenumber;
}
set
{
mobilenumber=value;
}
}
 
private System.DateTime datetime;
 
public System.DateTime DATETIME
{
get
{
return datetime;
}
set
{
datetime=value;
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
idrecrejectedcall = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
