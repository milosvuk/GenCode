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
 
public class objclassesfields
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public objclassesfields()
{
 
  
 
}
 
public objclassesfields (System.Int32 _idobjclassesfields,System.String _name,System.String _type,System.Int32 _id_objclasses,System.Int32 _idcompany,System.Int32 _active )
{
idobjclassesfields=_idobjclassesfields;
name=_name;
type=_type;
id_objclasses=_id_objclasses;
idcompany=_idcompany;
active=_active;
}
 
 
private System.Int32 idobjclassesfields;
 
public System.Int32 IDOBJCLASSESFIELDS
{
get
{
return idobjclassesfields;
}
set
{
idobjclassesfields=value;
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
 
private System.String type;
 
public System.String TYPE
{
get
{
return type;
}
set
{
type=value;
}
}
 
private System.Int32 id_objclasses;
 
public System.Int32 ID_OBJCLASSES
{
get
{
return id_objclasses;
}
set
{
id_objclasses=value;
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
idobjclassesfields = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
