using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class shelves
 
{
public string connString;
public string connectionString;
public shelves()
{
  
 
 
}
 
public shelves (System.Int32 _idrec,System.String _shelves,System.String _description,System.DateTime _datetimecreated )
{
idrec=_idrec;
shelves=_shelves;
description=_description;
datetimecreated=_datetimecreated;
}
 
 
private System.Int32 idrec;
 
public System.Int32 IDREC
{
get
{
return idrec;
}
set
{
idrec=value;
}
}
 
private System.String shelves;
 
public System.String SHELVES
{
get
{
return shelves;
}
set
{
shelves=value;
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
 
private System.DateTime datetimecreated;
 
public System.DateTime DATETIMECREATED
{
get
{
return datetimecreated;
}
set
{
datetimecreated=value;
}
}
 
 
public void New()
{
idrec = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
