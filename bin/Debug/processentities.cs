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
 
public class processentities
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public processentities()
{
 
  
 
}
 
public processentities (System.Int32 _idprojectprocessentities,System.Int32 _id_process,System.Int32 _id_identities,System.Int32 _id_company,System.Int32 _active )
{
idprojectprocessentities=_idprojectprocessentities;
id_process=_id_process;
id_identities=_id_identities;
id_company=_id_company;
active=_active;
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
idprojectprocessentities = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
