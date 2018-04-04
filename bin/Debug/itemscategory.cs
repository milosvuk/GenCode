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
 
public class itemscategory
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public itemscategory()
{
 
  
 
}
 
public itemscategory (System.Int32 _iddcs,System.String _dcs,System.String _deparmentcode,System.String _departmentname,System.String _classcode,System.String _classname,System.String _subclasscode,System.String _subclassname )
{
iddcs=_iddcs;
dcs=_dcs;
deparmentcode=_deparmentcode;
departmentname=_departmentname;
classcode=_classcode;
classname=_classname;
subclasscode=_subclasscode;
subclassname=_subclassname;
}
 
 
private System.Int32 iddcs;
 
public System.Int32 IDDCS
{
get
{
return iddcs;
}
set
{
iddcs=value;
}
}
 
private System.String dcs;
 
public System.String DCS
{
get
{
return dcs;
}
set
{
dcs=value;
}
}
 
private System.String deparmentcode;
 
public System.String DEPARMENTCODE
{
get
{
return deparmentcode;
}
set
{
deparmentcode=value;
}
}
 
private System.String departmentname;
 
public System.String DEPARTMENTNAME
{
get
{
return departmentname;
}
set
{
departmentname=value;
}
}
 
private System.String classcode;
 
public System.String CLASSCODE
{
get
{
return classcode;
}
set
{
classcode=value;
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
 
private System.String subclasscode;
 
public System.String SUBCLASSCODE
{
get
{
return subclasscode;
}
set
{
subclasscode=value;
}
}
 
private System.String subclassname;
 
public System.String SUBCLASSNAME
{
get
{
return subclassname;
}
set
{
subclassname=value;
}
}
 
 
public void New()
{
iddcs = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
