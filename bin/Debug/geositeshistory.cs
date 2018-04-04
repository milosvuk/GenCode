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
 
public class geositeshistory
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public geositeshistory()
{
 
  
 
}
 
public geositeshistory (System.Int32 _idgeosite,System.String _idsitename,System.String _geocoordinates,System.Int32 _protectedsite,System.DateTime _dateofchange,System.String _description,System.Int32 _active )
{
idgeosite=_idgeosite;
idsitename=_idsitename;
geocoordinates=_geocoordinates;
protectedsite=_protectedsite;
dateofchange=_dateofchange;
description=_description;
active=_active;
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
 
private System.String idsitename;
 
public System.String IDSITENAME
{
get
{
return idsitename;
}
set
{
idsitename=value;
}
}
 
private System.String geocoordinates;
 
public System.String GEOCOORDINATES
{
get
{
return geocoordinates;
}
set
{
geocoordinates=value;
}
}
 
private System.Int32 protectedsite;
 
public System.Int32 PROTECTEDSITE
{
get
{
return protectedsite;
}
set
{
protectedsite=value;
}
}
 
private System.DateTime dateofchange;
 
public System.DateTime DATEOFCHANGE
{
get
{
return dateofchange;
}
set
{
dateofchange=value;
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
idgeosite = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
