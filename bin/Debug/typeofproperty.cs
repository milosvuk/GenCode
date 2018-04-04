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
 
public class typeofproperty
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public typeofproperty()
{
 
  
 
}
 
public typeofproperty (System.Int32 _idrectypeofproperty,System.String _description )
{
idrectypeofproperty=_idrectypeofproperty;
description=_description;
}
 
 
private System.Int32 idrectypeofproperty;
 
public System.Int32 IDRECTYPEOFPROPERTY
{
get
{
return idrectypeofproperty;
}
set
{
idrectypeofproperty=value;
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
idrectypeofproperty = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
