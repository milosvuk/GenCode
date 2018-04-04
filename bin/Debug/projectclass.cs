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
 
public class projectclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public projectclass()
{
 
  
 
}
 
public projectclass (System.Int32 _idprojectclass,System.Int32 _id_project,System.Int32 _id_objclasses,System.Int32 _idcompany )
{
idprojectclass=_idprojectclass;
id_project=_id_project;
id_objclasses=_id_objclasses;
idcompany=_idcompany;
}
 
 
private System.Int32 idprojectclass;
 
public System.Int32 IDPROJECTCLASS
{
get
{
return idprojectclass;
}
set
{
idprojectclass=value;
}
}
 
private System.Int32 id_project;
 
public System.Int32 ID_PROJECT
{
get
{
return id_project;
}
set
{
id_project=value;
}
}
 
private System.Int32 id_objclasses;
 
public System.Int32 ID_OBJCLASSES
{
get
{
return id_objclasses;
}
set
{
id_objclasses=value;
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
idprojectclass = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
