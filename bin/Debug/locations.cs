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
 
public class locations
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public locations()
{
 
  
 
}
 
public locations (System.Int32 _idreclocation,System.Int32 _idregion,System.String _locationcode,System.String _locationname,System.Int32 _idcompany )
{
idreclocation=_idreclocation;
idregion=_idregion;
locationcode=_locationcode;
locationname=_locationname;
idcompany=_idcompany;
}
 
 
private System.Int32 idreclocation;
 
public System.Int32 IDRECLOCATION
{
get
{
return idreclocation;
}
set
{
idreclocation=value;
}
}
 
private System.Int32 idregion;
 
public System.Int32 IDREGION
{
get
{
return idregion;
}
set
{
idregion=value;
}
}
 
private System.String locationcode;
 
public System.String LOCATIONCODE
{
get
{
return locationcode;
}
set
{
locationcode=value;
}
}
 
private System.String locationname;
 
public System.String LOCATIONNAME
{
get
{
return locationname;
}
set
{
locationname=value;
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
idreclocation = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
