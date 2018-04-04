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
 
public class linkprojectprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprojectprocess()
{
 
  
 
}
 
public linkprojectprocess (System.Int32 _idprojectprocess,System.String _projectname,System.String _processname,System.String _processdescription,System.Int32 _id_project,System.Int32 _id_process )
{
idprojectprocess=_idprojectprocess;
projectname=_projectname;
processname=_processname;
processdescription=_processdescription;
id_project=_id_project;
id_process=_id_process;
}
 
 
private System.Int32 idprojectprocess;
 
public System.Int32 IDPROJECTPROCESS
{
get
{
return idprojectprocess;
}
set
{
idprojectprocess=value;
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
 
private System.String processname;
 
public System.String PROCESSNAME
{
get
{
return processname;
}
set
{
processname=value;
}
}
 
private System.String processdescription;
 
public System.String PROCESSDESCRIPTION
{
get
{
return processdescription;
}
set
{
processdescription=value;
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
idprojectprocess = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
