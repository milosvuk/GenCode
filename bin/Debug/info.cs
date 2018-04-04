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
 
public class info
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public info()
{
 
  
 
}
 
public info (System.Int32 _idinfo,System.String _name,System.String _description,System.Int32 _active,System.Int32 _id_company )
{
idinfo=_idinfo;
name=_name;
description=_description;
active=_active;
id_company=_id_company;
}
 
 
private System.Int32 idinfo;
 
public System.Int32 IDINFO
{
get
{
return idinfo;
}
set
{
idinfo=value;
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
 
private System.Int32 id_company;
 
public System.Int32 ID_COMPANY
{
get
{
return id_company;
}
set
{
id_company=value;
}
}
 
 
public void New()
{
idinfo = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
