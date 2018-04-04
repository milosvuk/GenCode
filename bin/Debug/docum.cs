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
 
public class docum
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public docum()
{
 
  
 
}
 
public docum (System.Int32 _iddocument,System.String _codeofdocument,System.String _nameofdocuments,System.Int32 _idcompany )
{
iddocument=_iddocument;
codeofdocument=_codeofdocument;
nameofdocuments=_nameofdocuments;
idcompany=_idcompany;
}
 
 
private System.Int32 iddocument;
 
public System.Int32 IDDOCUMENT
{
get
{
return iddocument;
}
set
{
iddocument=value;
}
}
 
private System.String codeofdocument;
 
public System.String CODEOFDOCUMENT
{
get
{
return codeofdocument;
}
set
{
codeofdocument=value;
}
}
 
private System.String nameofdocuments;
 
public System.String NAMEOFDOCUMENTS
{
get
{
return nameofdocuments;
}
set
{
nameofdocuments=value;
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
iddocument = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
