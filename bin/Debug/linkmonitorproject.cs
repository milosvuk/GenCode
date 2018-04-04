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
 
public class linkmonitorproject
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkmonitorproject()
{
 
  
 
}
 
public linkmonitorproject (System.Int32 _idlinkmonitorproject,System.Int32 _id_project,System.Int32 _id_monitorpoints,System.Int32 _idcompamy )
{
idlinkmonitorproject=_idlinkmonitorproject;
id_project=_id_project;
id_monitorpoints=_id_monitorpoints;
idcompamy=_idcompamy;
}
 
 
private System.Int32 idlinkmonitorproject;
 
public System.Int32 IDLINKMONITORPROJECT
{
get
{
return idlinkmonitorproject;
}
set
{
idlinkmonitorproject=value;
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
 
private System.Int32 id_monitorpoints;
 
public System.Int32 ID_MONITORPOINTS
{
get
{
return id_monitorpoints;
}
set
{
id_monitorpoints=value;
}
}
 
private System.Int32 idcompamy;
 
public System.Int32 IDCOMPAMY
{
get
{
return idcompamy;
}
set
{
idcompamy=value;
}
}
 
 
public void New()
{
idlinkmonitorproject = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
