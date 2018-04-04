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
 
public class suser
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public suser()
{
 
  
 
}
 
public suser (System.Int32 _iduser,System.String _username,System.String _passw,System.Int32 _userlevel,System.Int32 _id_company )
{
iduser=_iduser;
username=_username;
passw=_passw;
userlevel=_userlevel;
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
 
private System.String passw;
 
public System.String PASSW
{
get
{
return passw;
}
set
{
passw=value;
}
}
 
private System.Int32 userlevel;
 
public System.Int32 USERLEVEL
{
get
{
return userlevel;
}
set
{
userlevel=value;
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
