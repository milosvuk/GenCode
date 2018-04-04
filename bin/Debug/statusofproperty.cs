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
 
public class statusofproperty
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public statusofproperty()
{
 
  
 
}
 
public statusofproperty (System.Int32 _idrectypeofpropery,System.String _description )
{
idrectypeofpropery=_idrectypeofpropery;
description=_description;
}
 
 
private System.Int32 idrectypeofpropery;
 
public System.Int32 IDRECTYPEOFPROPERY
{
get
{
return idrectypeofpropery;
}
set
{
idrectypeofpropery=value;
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
idrectypeofpropery = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
