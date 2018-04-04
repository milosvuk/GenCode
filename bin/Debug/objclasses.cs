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
 
public class objclasses
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public objclasses()
{
 
  
 
}
 
public objclasses (System.Int32 _idobjclasses,System.String _name,System.Int32 _idcompany,System.Int32 _active )
{
idobjclasses=_idobjclasses;
name=_name;
idcompany=_idcompany;
active=_active;
}
 
 
private System.Int32 idobjclasses;
 
public System.Int32 IDOBJCLASSES
{
get
{
return idobjclasses;
}
set
{
idobjclasses=value;
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
idobjclasses = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
