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
 
public class geositeslink
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public geositeslink()
{
 
  
 
}
 
public geositeslink (System.Int32 _idgeositeslink,System.Int32 _idrechunter,System.Int32 _idgeosite,System.String _name,System.String _idcard,System.String _phonenum,System.String _licfinch,System.String _licgoldenplower,System.Int32 _curyear,System.Int32 _active )
{
idgeositeslink=_idgeositeslink;
idrechunter=_idrechunter;
idgeosite=_idgeosite;
name=_name;
idcard=_idcard;
phonenum=_phonenum;
licfinch=_licfinch;
licgoldenplower=_licgoldenplower;
curyear=_curyear;
active=_active;
}
 
 
private System.Int32 idgeositeslink;
 
public System.Int32 IDGEOSITESLINK
{
get
{
return idgeositeslink;
}
set
{
idgeositeslink=value;
}
}
 
private System.Int32 idrechunter;
 
public System.Int32 IDRECHUNTER
{
get
{
return idrechunter;
}
set
{
idrechunter=value;
}
}
 
private System.Int32 idgeosite;
 
public System.Int32 IDGEOSITE
{
get
{
return idgeosite;
}
set
{
idgeosite=value;
}
}
 
private System.String name;
 
public System.String NAME
{
get
{
return name;
}
set
{
name=value;
}
}
 
private System.String idcard;
 
public System.String IDCARD
{
get
{
return idcard;
}
set
{
idcard=value;
}
}
 
private System.String phonenum;
 
public System.String PHONENUM
{
get
{
return phonenum;
}
set
{
phonenum=value;
}
}
 
private System.String licfinch;
 
public System.String LICFINCH
{
get
{
return licfinch;
}
set
{
licfinch=value;
}
}
 
private System.String licgoldenplower;
 
public System.String LICGOLDENPLOWER
{
get
{
return licgoldenplower;
}
set
{
licgoldenplower=value;
}
}
 
private System.Int32 curyear;
 
public System.Int32 CURYEAR
{
get
{
return curyear;
}
set
{
curyear=value;
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
idgeositeslink = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
