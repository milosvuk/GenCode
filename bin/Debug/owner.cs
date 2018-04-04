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
 
public class owner
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public owner()
{
 
  
 
}
 
public owner (System.Int32 _idowner,System.String _ownercode,System.String _ownerfullname,System.String _address,System.String _contact,System.String _comment,System.Int32 _active )
{
idowner=_idowner;
ownercode=_ownercode;
ownerfullname=_ownerfullname;
address=_address;
contact=_contact;
comment=_comment;
active=_active;
}
 
 
private System.Int32 idowner;
 
public System.Int32 IDOWNER
{
get
{
return idowner;
}
set
{
idowner=value;
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
 
private System.String address;
 
public System.String ADDRESS
{
get
{
return address;
}
set
{
address=value;
}
}
 
private System.String contact;
 
public System.String CONTACT
{
get
{
return contact;
}
set
{
contact=value;
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
idowner = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
