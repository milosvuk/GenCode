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
 
public class aqu_all
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public aqu_all()
{
 
  
 
}
 
public aqu_all (System.Int32 _idrecaquisition,System.Int32 _fromowner,System.Int32 _toowner,System.Int32 _idnotary,System.DateTime _dateofaquisition,System.String _comment,System.String _ownercode,System.String _ownerfullname,System.String _ownercodeto,System.String _ownernameto,System.String _notaryname,System.Int32 _idproperty,System.String _description )
{
idrecaquisition=_idrecaquisition;
fromowner=_fromowner;
toowner=_toowner;
idnotary=_idnotary;
dateofaquisition=_dateofaquisition;
comment=_comment;
ownercode=_ownercode;
ownerfullname=_ownerfullname;
ownercodeto=_ownercodeto;
ownernameto=_ownernameto;
notaryname=_notaryname;
idproperty=_idproperty;
description=_description;
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
 
private System.String ownercode;
 
public System.String OWNERCODE
{
get
{
return ownercode;
}
set
{
ownercode=value;
}
}
 
private System.String ownerfullname;
 
public System.String OWNERFULLNAME
{
get
{
return ownerfullname;
}
set
{
ownerfullname=value;
}
}
 
private System.String ownercodeto;
 
public System.String OWNERCODETO
{
get
{
return ownercodeto;
}
set
{
ownercodeto=value;
}
}
 
private System.String ownernameto;
 
public System.String OWNERNAMETO
{
get
{
return ownernameto;
}
set
{
ownernameto=value;
}
}
 
private System.String notaryname;
 
public System.String NOTARYNAME
{
get
{
return notaryname;
}
set
{
notaryname=value;
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
 
 
public void New()
{
idrecaquisition = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
