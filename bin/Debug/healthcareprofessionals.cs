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
 
public class healthcareprofessionals
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public healthcareprofessionals()
{
 
  
 
}
 
public healthcareprofessionals (System.Int32 _idprofessional,System.String _name,System.String _surname,System.String _mobile,System.String _email,System.String _username,System.String _password,System.Int32 _active )
{
idprofessional=_idprofessional;
name=_name;
surname=_surname;
mobile=_mobile;
email=_email;
username=_username;
password=_password;
active=_active;
}
 
 
private System.Int32 idprofessional;
 
public System.Int32 IDPROFESSIONAL
{
get
{
return idprofessional;
}
set
{
idprofessional=value;
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
 
private System.String surname;
 
public System.String SURNAME
{
get
{
return surname;
}
set
{
surname=value;
}
}
 
private System.String mobile;
 
public System.String MOBILE
{
get
{
return mobile;
}
set
{
mobile=value;
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
 
private System.String username;
 
public System.String USERNAME
{
get
{
return username;
}
set
{
username=value;
}
}
 
private System.String password;
 
public System.String PASSWORD
{
get
{
return password;
}
set
{
password=value;
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
idprofessional = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
