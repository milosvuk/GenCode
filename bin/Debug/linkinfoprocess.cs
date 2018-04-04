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
 
public class linkinfoprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkinfoprocess()
{
 
  
 
}
 
public linkinfoprocess (System.Int32 _idprojectprocessinfo,System.String _nameofinformation,System.String _nameofprocess,System.Int32 _id_info,System.Int32 _id_process )
{
idprojectprocessinfo=_idprojectprocessinfo;
nameofinformation=_nameofinformation;
nameofprocess=_nameofprocess;
id_info=_id_info;
id_process=_id_process;
}
 
 
private System.Int32 idprojectprocessinfo;
 
public System.Int32 IDPROJECTPROCESSINFO
{
get
{
return idprojectprocessinfo;
}
set
{
idprojectprocessinfo=value;
}
}
 
private System.String nameofinformation;
 
public System.String NAMEOFINFORMATION
{
get
{
return nameofinformation;
}
set
{
nameofinformation=value;
}
}
 
private System.String nameofprocess;
 
public System.String NAMEOFPROCESS
{
get
{
return nameofprocess;
}
set
{
nameofprocess=value;
}
}
 
private System.Int32 id_info;
 
public System.Int32 ID_INFO
{
get
{
return id_info;
}
set
{
id_info=value;
}
}
 
private System.Int32 id_process;
 
public System.Int32 ID_PROCESS
{
get
{
return id_process;
}
set
{
id_process=value;
}
}
 
 
public void New()
{
idprojectprocessinfo = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
