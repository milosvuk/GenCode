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
 
public class usershs
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public usershs()
{
 
  
 
}
 
public usershs (System.Int32 _iduser,System.Int32 _id_usergroup,System.String _username,System.String _password,System.String _useremail,System.Int32 _active,System.Int32 _id_company )
{
iduser=_iduser;
id_usergroup=_id_usergroup;
username=_username;
password=_password;
useremail=_useremail;
active=_active;
id_company=_id_company;
}
 
 
private System.Int32 iduser;
 
public System.Int32 IDUSER
{
get
{
return iduser;
}
set
{
iduser=value;
}
}
 
private System.Int32 id_usergroup;
 
public System.Int32 ID_USERGROUP
{
get
{
return id_usergroup;
}
set
{
id_usergroup=value;
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
 
private System.String useremail;
 
public System.String USEREMAIL
{
get
{
return useremail;
}
set
{
useremail=value;
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
 
private System.Int32 id_company;
 
public System.Int32 ID_COMPANY
{
get
{
return id_company;
}
set
{
id_company=value;
}
}
 
 
public void New()
{
iduser = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
