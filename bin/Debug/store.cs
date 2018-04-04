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
 
public class store
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public store()
{
 
  
 
}
 
public store (System.Int32 _idstore,System.Int32 _numofstore,System.String _codeofstore,System.String _nameofstore,System.Decimal _latstore,System.Decimal _longstore,System.Int32 _id_company )
{
idstore=_idstore;
numofstore=_numofstore;
codeofstore=_codeofstore;
nameofstore=_nameofstore;
latstore=_latstore;
longstore=_longstore;
id_company=_id_company;
}
 
 
private System.Int32 idstore;
 
public System.Int32 IDSTORE
{
get
{
return idstore;
}
set
{
idstore=value;
}
}
 
private System.Int32 numofstore;
 
public System.Int32 NUMOFSTORE
{
get
{
return numofstore;
}
set
{
numofstore=value;
}
}
 
private System.String codeofstore;
 
public System.String CODEOFSTORE
{
get
{
return codeofstore;
}
set
{
codeofstore=value;
}
}
 
private System.String nameofstore;
 
public System.String NAMEOFSTORE
{
get
{
return nameofstore;
}
set
{
nameofstore=value;
}
}
 
private System.Decimal latstore;
 
public System.Decimal LATSTORE
{
get
{
return latstore;
}
set
{
latstore=value;
}
}
 
private System.Decimal longstore;
 
public System.Decimal LONGSTORE
{
get
{
return longstore;
}
set
{
longstore=value;
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
idstore = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
