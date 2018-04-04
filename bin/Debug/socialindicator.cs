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
 
public class socialindicator
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public socialindicator()
{
 
  
 
}
 
public socialindicator (System.Int32 _idindicator,System.String _code,System.String _name,System.Decimal _lowvaluerange,System.Decimal _highvaluerange,System.String _description,System.Int32 _idcompany )
{
idindicator=_idindicator;
code=_code;
name=_name;
lowvaluerange=_lowvaluerange;
highvaluerange=_highvaluerange;
description=_description;
idcompany=_idcompany;
}
 
 
private System.Int32 idindicator;
 
public System.Int32 IDINDICATOR
{
get
{
return idindicator;
}
set
{
idindicator=value;
}
}
 
private System.String code;
 
public System.String CODE
{
get
{
return code;
}
set
{
code=value;
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
 
private System.Decimal lowvaluerange;
 
public System.Decimal LOWVALUERANGE
{
get
{
return lowvaluerange;
}
set
{
lowvaluerange=value;
}
}
 
private System.Decimal highvaluerange;
 
public System.Decimal HIGHVALUERANGE
{
get
{
return highvaluerange;
}
set
{
highvaluerange=value;
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
idindicator = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
