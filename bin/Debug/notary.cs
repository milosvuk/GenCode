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
 
public class notary
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public notary()
{
 
  
 
}
 
public notary (System.Int32 _idnotary,System.String _fullname,System.String _address,System.String _phone,System.String _email,System.String _comment,System.Int32 _idcompany )
{
idnotary=_idnotary;
fullname=_fullname;
address=_address;
phone=_phone;
email=_email;
comment=_comment;
idcompany=_idcompany;
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
 
private System.String fullname;
 
public System.String FULLNAME
{
get
{
return fullname;
}
set
{
fullname=value;
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
 
private System.String phone;
 
public System.String PHONE
{
get
{
return phone;
}
set
{
phone=value;
}
}
 
private System.String email;
 
public System.String EMAIL
{
get
{
return email;
}
set
{
email=value;
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
idnotary = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
