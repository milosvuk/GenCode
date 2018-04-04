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
 
public class status
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public status()
{
 
  
 
}
 
public status (System.Int32 _idstatus,System.String _status,System.Int32 _id_company,System.Int32 _active )
{
idstatus=_idstatus;
status=_status;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idstatus;
 
public System.Int32 IDSTATUS
{
get
{
return idstatus;
}
set
{
idstatus=value;
}
}
 
private System.String status;
 
public System.String STATUS
{
get
{
return status;
}
set
{
status=value;
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
 
 
public void New()
{
idstatus = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
