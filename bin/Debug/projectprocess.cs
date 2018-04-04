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
 
public class projectprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public projectprocess()
{
 
  
 
}
 
public projectprocess (System.Int32 _idprojectprocess,System.Int32 _id_project,System.Int32 _id_process,System.Int32 _id_company,System.Int32 _active )
{
idprojectprocess=_idprojectprocess;
id_project=_id_project;
id_process=_id_process;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idprojectprocess;
 
public System.Int32 IDPROJECTPROCESS
{
get
{
return idprojectprocess;
}
set
{
idprojectprocess=value;
}
}
 
private System.Int32 id_project;
 
public System.Int32 ID_PROJECT
{
get
{
return id_project;
}
set
{
id_project=value;
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
idprojectprocess = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
