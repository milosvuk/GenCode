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
 
public class loguser
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public loguser()
{
 
  
 
}
 
public loguser (System.Int32 _iduserlog,System.String _username,System.DateTime _logdate,System.DateTime _logdatetime,System.String _ipaddress,System.String _details,System.Int32 _id_company )
{
iduserlog=_iduserlog;
username=_username;
logdate=_logdate;
logdatetime=_logdatetime;
ipaddress=_ipaddress;
details=_details;
id_company=_id_company;
}
 
 
private System.Int32 iduserlog;
 
public System.Int32 IDUSERLOG
{
get
{
return iduserlog;
}
set
{
iduserlog=value;
}
}
 
private System.String username;
 
public System.String USERNAME
{
get
{
return username;
}
set
{
username=value;
}
}
 
private System.DateTime logdate;
 
public System.DateTime LOGDATE
{
get
{
return logdate;
}
set
{
logdate=value;
}
}
 
private System.DateTime logdatetime;
 
public System.DateTime LOGDATETIME
{
get
{
return logdatetime;
}
set
{
logdatetime=value;
}
}
 
private System.String ipaddress;
 
public System.String IPADDRESS
{
get
{
return ipaddress;
}
set
{
ipaddress=value;
}
}
 
private System.String details;
 
public System.String DETAILS
{
get
{
return details;
}
set
{
details=value;
}
}
 
private System.Int32 id_company;
 
public System.Int32 ID_COMPANY
{
get
{
return id_company;
}
set
{
id_company=value;
}
}
 
 
public void New()
{
iduserlog = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
