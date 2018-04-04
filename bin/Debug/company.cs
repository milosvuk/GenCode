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
 
public class company
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public company()
{
 
  
 
}
 
public company (System.Int32 _idcompany,System.String _name,System.String _code,System.String _details,System.Int32 _active )
{
idcompany=_idcompany;
name=_name;
code=_code;
details=_details;
active=_active;
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
 
private System.String details;
 
public System.String DETAILS
{
get
{
return details;
}
set
{
details=value;
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
idcompany = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
