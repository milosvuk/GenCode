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
 
public class entityitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public entityitem()
{
 
  
 
}
 
public entityitem (System.Int32 _idofentity,System.String _codeofentity,System.String _nameofentity,System.String _udf1,System.String _udf2,System.String _udf3,System.Int32 _idcompany )
{
idofentity=_idofentity;
codeofentity=_codeofentity;
nameofentity=_nameofentity;
udf1=_udf1;
udf2=_udf2;
udf3=_udf3;
idcompany=_idcompany;
}
 
 
private System.Int32 idofentity;
 
public System.Int32 IDOFENTITY
{
get
{
return idofentity;
}
set
{
idofentity=value;
}
}
 
private System.String codeofentity;
 
public System.String CODEOFENTITY
{
get
{
return codeofentity;
}
set
{
codeofentity=value;
}
}
 
private System.String nameofentity;
 
public System.String NAMEOFENTITY
{
get
{
return nameofentity;
}
set
{
nameofentity=value;
}
}
 
private System.String udf1;
 
public System.String UDF1
{
get
{
return udf1;
}
set
{
udf1=value;
}
}
 
private System.String udf2;
 
public System.String UDF2
{
get
{
return udf2;
}
set
{
udf2=value;
}
}
 
private System.String udf3;
 
public System.String UDF3
{
get
{
return udf3;
}
set
{
udf3=value;
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
idofentity = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
