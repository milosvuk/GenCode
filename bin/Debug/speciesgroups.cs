using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class speciesgroups
 
{
public string connString;
public string connectionString;
public speciesgroups()
{
  
 
 
}
 
public speciesgroups (System.Int32 _idrecspeciesgroup,System.String _description,System.Int32 _qtperperson,System.Int32 _peryear,System.Int32 _active )
{
idrecspeciesgroup=_idrecspeciesgroup;
description=_description;
qtperperson=_qtperperson;
peryear=_peryear;
active=_active;
}
 
 
private System.Int32 idrecspeciesgroup;
 
public System.Int32 IDRECSPECIESGROUP
{
get
{
return idrecspeciesgroup;
}
set
{
idrecspeciesgroup=value;
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
 
private System.Int32 qtperperson;
 
public System.Int32 QTPERPERSON
{
get
{
return qtperperson;
}
set
{
qtperperson=value;
}
}
 
private System.Int32 peryear;
 
public System.Int32 PERYEAR
{
get
{
return peryear;
}
set
{
peryear=value;
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
idrecspeciesgroup = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
