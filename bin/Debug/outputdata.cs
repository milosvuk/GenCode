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
 
public class outputdata
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public outputdata()
{
 
  
 
}
 
public outputdata (System.Int32 _idoutput,System.Int32 _id_objclasses,System.String _typeandname,System.String _ruleswithaction,System.Int32 _idcompany,System.Int32 _active )
{
idoutput=_idoutput;
id_objclasses=_id_objclasses;
typeandname=_typeandname;
ruleswithaction=_ruleswithaction;
idcompany=_idcompany;
active=_active;
}
 
 
private System.Int32 idoutput;
 
public System.Int32 IDOUTPUT
{
get
{
return idoutput;
}
set
{
idoutput=value;
}
}
 
private System.Int32 id_objclasses;
 
public System.Int32 ID_OBJCLASSES
{
get
{
return id_objclasses;
}
set
{
id_objclasses=value;
}
}
 
private System.String typeandname;
 
public System.String TYPEANDNAME
{
get
{
return typeandname;
}
set
{
typeandname=value;
}
}
 
private System.String ruleswithaction;
 
public System.String RULESWITHACTION
{
get
{
return ruleswithaction;
}
set
{
ruleswithaction=value;
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
idoutput = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
