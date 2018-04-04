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
 
public class fulllinkmonitorproject
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public fulllinkmonitorproject()
{
 
  
 
}
 
public fulllinkmonitorproject (System.Int32 _idlinkmonitorproject,System.String _projectname,System.String _monitoringpoint,System.String _implication,System.String _resolution,System.String _status,System.Int32 _id_monitorpoints,System.Int32 _id_project )
{
idlinkmonitorproject=_idlinkmonitorproject;
projectname=_projectname;
monitoringpoint=_monitoringpoint;
implication=_implication;
resolution=_resolution;
status=_status;
id_monitorpoints=_id_monitorpoints;
id_project=_id_project;
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
 
private System.String projectname;
 
public System.String PROJECTNAME
{
get
{
return projectname;
}
set
{
projectname=value;
}
}
 
private System.String monitoringpoint;
 
public System.String MONITORINGPOINT
{
get
{
return monitoringpoint;
}
set
{
monitoringpoint=value;
}
}
 
private System.String implication;
 
public System.String IMPLICATION
{
get
{
return implication;
}
set
{
implication=value;
}
}
 
private System.String resolution;
 
public System.String RESOLUTION
{
get
{
return resolution;
}
set
{
resolution=value;
}
}
 
private System.String status;
 
public System.String STATUS
{
get
{
return status;
}
set
{
status=value;
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
 
 
public void New()
{
idlinkmonitorproject = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
