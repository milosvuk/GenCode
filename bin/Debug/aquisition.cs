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
 
public class aquisition
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public aquisition()
{
 
  
 
}
 
public aquisition (System.Int32 _idrecaquisition,System.Int32 _idproperty,System.Int32 _fromowner,System.Int32 _toowner,System.Int32 _idnotary,System.DateTime _dateofaquisition,System.String _comment,System.Int32 _idcompany )
{
idrecaquisition=_idrecaquisition;
idproperty=_idproperty;
fromowner=_fromowner;
toowner=_toowner;
idnotary=_idnotary;
dateofaquisition=_dateofaquisition;
comment=_comment;
idcompany=_idcompany;
}
 
 
private System.Int32 idrecaquisition;
 
public System.Int32 IDRECAQUISITION
{
get
{
return idrecaquisition;
}
set
{
idrecaquisition=value;
}
}
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
}
}
 
private System.Int32 fromowner;
 
public System.Int32 FROMOWNER
{
get
{
return fromowner;
}
set
{
fromowner=value;
}
}
 
private System.Int32 toowner;
 
public System.Int32 TOOWNER
{
get
{
return toowner;
}
set
{
toowner=value;
}
}
 
private System.Int32 idnotary;
 
public System.Int32 IDNOTARY
{
get
{
return idnotary;
}
set
{
idnotary=value;
}
}
 
private System.DateTime dateofaquisition;
 
public System.DateTime DATEOFAQUISITION
{
get
{
return dateofaquisition;
}
set
{
dateofaquisition=value;
}
}
 
private System.String comment;
 
public System.String COMMENT
{
get
{
return comment;
}
set
{
comment=value;
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
idrecaquisition = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
