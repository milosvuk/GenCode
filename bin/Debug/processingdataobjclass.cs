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
 
public class processingdataobjclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public processingdataobjclass()
{
 
  
 
}
 
public processingdataobjclass (System.Int32 _idprocessing,System.Int32 _id_objclasses,System.String _name,System.String _typeandname,System.String _ruleswithaction )
{
idprocessing=_idprocessing;
id_objclasses=_id_objclasses;
name=_name;
typeandname=_typeandname;
ruleswithaction=_ruleswithaction;
}
 
 
private System.Int32 idprocessing;
 
public System.Int32 IDPROCESSING
{
get
{
return idprocessing;
}
set
{
idprocessing=value;
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
 
private System.String name;
 
public System.String NAME
{
get
{
return name;
}
set
{
name=value;
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
 
 
public void New()
{
idprocessing = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
