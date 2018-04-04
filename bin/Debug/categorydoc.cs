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
 
public class categorydoc
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public categorydoc()
{
 
  
 
}
 
public categorydoc (System.Int32 _idcategory,System.String _description,System.Int32 _active )
{
idcategory=_idcategory;
description=_description;
active=_active;
}
 
 
private System.Int32 idcategory;
 
public System.Int32 IDCATEGORY
{
get
{
return idcategory;
}
set
{
idcategory=value;
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
idcategory = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
