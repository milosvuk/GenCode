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
 
public class expense
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public expense()
{
 
  
 
}
 
public expense (System.Int32 _idrecexpense,System.String _description,System.Int32 _idcompany )
{
idrecexpense=_idrecexpense;
description=_description;
idcompany=_idcompany;
}
 
 
private System.Int32 idrecexpense;
 
public System.Int32 IDRECEXPENSE
{
get
{
return idrecexpense;
}
set
{
idrecexpense=value;
}
}
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
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
idrecexpense = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
