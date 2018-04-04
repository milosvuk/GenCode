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
 
public class monitorpoints
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public monitorpoints()
{
 
  
 
}
 
public monitorpoints (System.Int32 _idmonitorpoints,System.String _description,System.String _implication,System.String _resolution,System.String _status,System.Int32 _idcompany )
{
idmonitorpoints=_idmonitorpoints;
description=_description;
implication=_implication;
resolution=_resolution;
status=_status;
idcompany=_idcompany;
}
 
 
private System.Int32 idmonitorpoints;
 
public System.Int32 IDMONITORPOINTS
{
get
{
return idmonitorpoints;
}
set
{
idmonitorpoints=value;
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
 
 
public void New()
{
idmonitorpoints = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
