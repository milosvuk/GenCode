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
 
public class childtable
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public childtable()
{
 
  
 
}
 
public childtable (System.Int32 _idchildtable,System.Int32 _id_maintable,System.String _description )
{
idchildtable=_idchildtable;
id_maintable=_id_maintable;
description=_description;
}
 
 
private System.Int32 idchildtable;
 
public System.Int32 IDCHILDTABLE
{
get
{
return idchildtable;
}
set
{
idchildtable=value;
}
}
 
private System.Int32 id_maintable;
 
public System.Int32 ID_MAINTABLE
{
get
{
return id_maintable;
}
set
{
id_maintable=value;
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
idchildtable = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
