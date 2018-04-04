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
 
public class location
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public location()
{
 
  
 
}
 
public location (System.Int32 _idlocation,System.String _codeoflocation,System.String _nameoflocation,System.String _latit,System.String _longi,System.String _description,System.Int32 _idcompany )
{
idlocation=_idlocation;
codeoflocation=_codeoflocation;
nameoflocation=_nameoflocation;
latit=_latit;
longi=_longi;
description=_description;
idcompany=_idcompany;
}
 
 
private System.Int32 idlocation;
 
public System.Int32 IDLOCATION
{
get
{
return idlocation;
}
set
{
idlocation=value;
}
}
 
private System.String codeoflocation;
 
public System.String CODEOFLOCATION
{
get
{
return codeoflocation;
}
set
{
codeoflocation=value;
}
}
 
private System.String nameoflocation;
 
public System.String NAMEOFLOCATION
{
get
{
return nameoflocation;
}
set
{
nameoflocation=value;
}
}
 
private System.String latit;
 
public System.String LATIT
{
get
{
return latit;
}
set
{
latit=value;
}
}
 
private System.String longi;
 
public System.String LONGI
{
get
{
return longi;
}
set
{
longi=value;
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
idlocation = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
