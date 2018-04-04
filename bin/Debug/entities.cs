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
 
public class entities
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public entities()
{
 
  
 
}
 
public entities (System.Int32 _identities,System.String _name,System.String _description,System.Int32 _active,System.Int32 _id_comany )
{
identities=_identities;
name=_name;
description=_description;
active=_active;
id_comany=_id_comany;
}
 
 
private System.Int32 identities;
 
public System.Int32 IDENTITIES
{
get
{
return identities;
}
set
{
identities=value;
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
 
private System.Int32 id_comany;
 
public System.Int32 ID_COMANY
{
get
{
return id_comany;
}
set
{
id_comany=value;
}
}
 
 
public void New()
{
identities = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
