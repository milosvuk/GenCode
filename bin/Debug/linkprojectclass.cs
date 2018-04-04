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
 
public class linkprojectclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprojectclass()
{
 
  
 
}
 
public linkprojectclass (System.Int32 _idprojectclass,System.String _projectname,System.String _classname,System.Int32 _id_project,System.Int32 _id_objclasses )
{
idprojectclass=_idprojectclass;
projectname=_projectname;
classname=_classname;
id_project=_id_project;
id_objclasses=_id_objclasses;
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
 
private System.String projectname;
 
public System.String PROJECTNAME
{
get
{
return projectname;
}
set
{
projectname=value;
}
}
 
private System.String classname;
 
public System.String CLASSNAME
{
get
{
return classname;
}
set
{
classname=value;
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
 
 
public void New()
{
idprojectclass = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
