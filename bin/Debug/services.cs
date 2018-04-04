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
 
public class services
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public services()
{
 
  
 
}
 
public services (System.Int32 _idservices,System.String _name,System.String _description,System.Int32 _active,System.Int32 _id_company )
{
idservices=_idservices;
name=_name;
description=_description;
active=_active;
id_company=_id_company;
}
 
 
private System.Int32 idservices;
 
public System.Int32 IDSERVICES
{
get
{
return idservices;
}
set
{
idservices=value;
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
idservices = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
