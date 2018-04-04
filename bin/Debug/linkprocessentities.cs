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
 
public class linkprocessentities
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprocessentities()
{
 
  
 
}
 
public linkprocessentities (System.Int32 _idprojectprocessentities,System.String _processname,System.String _entityname,System.Int32 _id_process,System.Int32 _id_identities )
{
idprojectprocessentities=_idprojectprocessentities;
processname=_processname;
entityname=_entityname;
id_process=_id_process;
id_identities=_id_identities;
}
 
 
private System.Int32 idprojectprocessentities;
 
public System.Int32 IDPROJECTPROCESSENTITIES
{
get
{
return idprojectprocessentities;
}
set
{
idprojectprocessentities=value;
}
}
 
private System.String processname;
 
public System.String PROCESSNAME
{
get
{
return processname;
}
set
{
processname=value;
}
}
 
private System.String entityname;
 
public System.String ENTITYNAME
{
get
{
return entityname;
}
set
{
entityname=value;
}
}
 
private System.Int32 id_process;
 
public System.Int32 ID_PROCESS
{
get
{
return id_process;
}
set
{
id_process=value;
}
}
 
private System.Int32 id_identities;
 
public System.Int32 ID_IDENTITIES
{
get
{
return id_identities;
}
set
{
id_identities=value;
}
}
 
 
public void New()
{
idprojectprocessentities = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
