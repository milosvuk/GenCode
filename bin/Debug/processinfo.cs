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
 
public class processinfo
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public processinfo()
{
 
  
 
}
 
public processinfo (System.Int32 _idprojectprocessinfo,System.Int32 _id_info,System.Int32 _id_process,System.Int32 _id_company,System.Int32 _active )
{
idprojectprocessinfo=_idprojectprocessinfo;
id_info=_id_info;
id_process=_id_process;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idprojectprocessinfo;
 
public System.Int32 IDPROJECTPROCESSINFO
{
get
{
return idprojectprocessinfo;
}
set
{
idprojectprocessinfo=value;
}
}
 
private System.Int32 id_info;
 
public System.Int32 ID_INFO
{
get
{
return id_info;
}
set
{
id_info=value;
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
idprojectprocessinfo = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
