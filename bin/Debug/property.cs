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
 
public class property
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public property()
{
 
  
 
}
 
public property (System.Int32 _idproperty,System.String _name,System.String _description,System.Int32 _id_documents,System.Int32 _entitiesyesno,System.Int32 _id_company,System.Int32 _active )
{
idproperty=_idproperty;
name=_name;
description=_description;
id_documents=_id_documents;
entitiesyesno=_entitiesyesno;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
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
 
private System.Int32 id_documents;
 
public System.Int32 ID_DOCUMENTS
{
get
{
return id_documents;
}
set
{
id_documents=value;
}
}
 
private System.Int32 entitiesyesno;
 
public System.Int32 ENTITIESYESNO
{
get
{
return entitiesyesno;
}
set
{
entitiesyesno=value;
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
idproperty = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
