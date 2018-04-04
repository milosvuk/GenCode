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
 
public class project
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public project()
{
 
  
 
}
 
public project (System.Int32 _idproject,System.String _name,System.String _description,System.Int32 _id_statussh,System.DateTime _firstdate,System.Int32 _active,System.Int32 _id_company )
{
idproject=_idproject;
name=_name;
description=_description;
id_statussh=_id_statussh;
firstdate=_firstdate;
active=_active;
id_company=_id_company;
}
 
 
private System.Int32 idproject;
 
public System.Int32 IDPROJECT
{
get
{
return idproject;
}
set
{
idproject=value;
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
 
private System.Int32 id_statussh;
 
public System.Int32 ID_STATUSSH
{
get
{
return id_statussh;
}
set
{
id_statussh=value;
}
}
 
private System.DateTime firstdate;
 
public System.DateTime FIRSTDATE
{
get
{
return firstdate;
}
set
{
firstdate=value;
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
idproject = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
