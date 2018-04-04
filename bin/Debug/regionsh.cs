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
 
public class regionsh
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public regionsh()
{
 
  
 
}
 
public regionsh (System.Int32 _idregion,System.String _regionn )
{
idregion=_idregion;
regionn=_regionn;
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
 
private System.String regionn;
 
public System.String REGIONN
{
get
{
return regionn;
}
set
{
regionn=value;
}
}
 
 
public void New()
{
idregion = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
