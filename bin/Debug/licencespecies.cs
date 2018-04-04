using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class licencespecies
 
{
public string connString;
public string connectionString;
public licencespecies()
{
  
 
 
}
 
public licencespecies (System.Int32 _idreclicencespecies,System.Int32 _idrecgenlicence,System.Int32 _idrecspecies,System.Int32 _licspeyear,System.Int32 _active )
{
idreclicencespecies=_idreclicencespecies;
idrecgenlicence=_idrecgenlicence;
idrecspecies=_idrecspecies;
licspeyear=_licspeyear;
active=_active;
}
 
 
private System.Int32 idreclicencespecies;
 
public System.Int32 IDRECLICENCESPECIES
{
get
{
return idreclicencespecies;
}
set
{
idreclicencespecies=value;
}
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
 
private System.Int32 idrecspecies;
 
public System.Int32 IDRECSPECIES
{
get
{
return idrecspecies;
}
set
{
idrecspecies=value;
}
}
 
private System.Int32 licspeyear;
 
public System.Int32 LICSPEYEAR
{
get
{
return licspeyear;
}
set
{
licspeyear=value;
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
idreclicencespecies = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
 