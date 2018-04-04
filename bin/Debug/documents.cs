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
 
public class documents
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public documents()
{
 
  
 
}
 
public documents (System.Int32 _iddocuments,System.String _name,System.String _description,System.Int32 _id_company,System.Int32 _active )
{
iddocuments=_iddocuments;
name=_name;
description=_description;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 iddocuments;
 
public System.Int32 IDDOCUMENTS
{
get
{
return iddocuments;
}
set
{
iddocuments=value;
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
iddocuments = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
