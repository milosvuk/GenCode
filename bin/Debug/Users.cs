using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class Users
 
{
public string connString;
public string connectionString;
public Users()
{
  
 
 
}
 
public Users (System.Int32 _idrecuser,System.String _username,System.String _password,System.Int32 _idint,System.DateTime _datecreated )
{
idrecuser=_idrecuser;
username=_username;
password=_password;
idint=_idint;
datecreated=_datecreated;
}
 
 
private System.Int32 idrecuser;
 
public System.Int32 IDRECUSER
{
get
{
return idrecuser;
}
set
{
idrecuser=value;
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
 
private System.Int32 idint;
 
public System.Int32 IDINT
{
get
{
return idint;
}
set
{
idint=value;
}
}
 
private System.DateTime datecreated;
 
public System.DateTime DATECREATED
{
get
{
return datecreated;
}
set
{
datecreated=value;
}
}
 
 
public void New()
{
idrecuser = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
