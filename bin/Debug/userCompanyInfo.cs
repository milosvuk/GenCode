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
 
public class userCompanyInfo
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public userCompanyInfo()
{
 
  
 
}
 
public userCompanyInfo (System.String _username,System.String _password,System.Int32 _id_usergroup,System.Int32 _id_company,System.Int32 _active,System.Int32 _iduser,System.String _name )
{
username=_username;
password=_password;
id_usergroup=_id_usergroup;
id_company=_id_company;
active=_active;
iduser=_iduser;
name=_name;
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
 
 
public void New()
{
username = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
