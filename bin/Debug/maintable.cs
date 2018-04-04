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
 
public class maintable
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public maintable()
{
 
  
 
}
 
public maintable (System.Int32 _idmaintable,System.String _description )
{
idmaintable=_idmaintable;
description=_description;
}
 
 
private System.Int32 idmaintable;
 
public System.Int32 IDMAINTABLE
{
get
{
return idmaintable;
}
set
{
idmaintable=value;
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
 
 
public void New()
{
idmaintable = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
