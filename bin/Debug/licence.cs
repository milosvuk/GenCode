using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class licence
 
{
public string connString;
public string connectionString;
public licence()
{
  
 
 
}
 
public licence (System.Int32 _idrecgenlicence,System.Int32 _idrectypelicence,System.String _licencedescription,System.Int32 _licenceyear,System.Int32 _active )
{
idrecgenlicence=_idrecgenlicence;
idrectypelicence=_idrectypelicence;
licencedescription=_licencedescription;
licenceyear=_licenceyear;
active=_active;
}
 
 
private System.Int32 idrecgenlicence;
 
public System.Int32 IDRECGENLICENCE
{
get
{
return idrecgenlicence;
}
set
{
idrecgenlicence=value;
}
}
 
private System.Int32 idrectypelicence;
 
public System.Int32 IDRECTYPELICENCE
{
get
{
return idrectypelicence;
}
set
{
idrectypelicence=value;
}
}
 
private System.String licencedescription;
 
public System.String LICENCEDESCRIPTION
{
get
{
return licencedescription;
}
set
{
licencedescription=value;
}
}
 
private System.Int32 licenceyear;
 
public System.Int32 LICENCEYEAR
{
get
{
return licenceyear;
}
set
{
licenceyear=value;
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
idrecgenlicence = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
