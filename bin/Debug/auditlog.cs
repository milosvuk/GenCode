using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class auditlog
 
{
public string connString;
public string connectionString;
public auditlog()
{
  
 
 
}
 
public auditlog (System.Int32 _idrecauditlog,System.DateTime _datetimeevent,System.String _datetimeeventfull,System.String _desctiption,System.String _tablename,System.String _recorddetails,System.Int32 _userid )
{
idrecauditlog=_idrecauditlog;
datetimeevent=_datetimeevent;
datetimeeventfull=_datetimeeventfull;
desctiption=_desctiption;
tablename=_tablename;
recorddetails=_recorddetails;
userid=_userid;
}
 
 
private System.Int32 idrecauditlog;
 
public System.Int32 IDRECAUDITLOG
{
get
{
return idrecauditlog;
}
set
{
idrecauditlog=value;
}
}
 
private System.DateTime datetimeevent;
 
public System.DateTime DATETIMEEVENT
{
get
{
return datetimeevent;
}
set
{
datetimeevent=value;
}
}
 
private System.String datetimeeventfull;
 
public System.String DATETIMEEVENTFULL
{
get
{
return datetimeeventfull;
}
set
{
datetimeeventfull=value;
}
}
 
private System.String desctiption;
 
public System.String DESCTIPTION
{
get
{
return desctiption;
}
set
{
desctiption=value;
}
}
 
private System.String tablename;
 
public System.String TABLENAME
{
get
{
return tablename;
}
set
{
tablename=value;
}
}
 
private System.String recorddetails;
 
public System.String RECORDDETAILS
{
get
{
return recorddetails;
}
set
{
recorddetails=value;
}
}
 
private System.Int32 userid;
 
public System.Int32 USERID
{
get
{
return userid;
}
set
{
userid=value;
}
}
 
 
public void New()
{
idrecauditlog = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
