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
 
public class documentsb
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public documentsb()
{
 
  
 
}
 
public documentsb (System.Int32 _idrecdocument,System.Int32 _idproperty,System.String _description,System.String _typeofdoc,System.Byte[] _docinbinformat,System.String _keyword1,System.String _keyword2,System.String _keyword3,System.Int32 _idcompany )
{
idrecdocument=_idrecdocument;
idproperty=_idproperty;
description=_description;
typeofdoc=_typeofdoc;
docinbinformat=_docinbinformat;
keyword1=_keyword1;
keyword2=_keyword2;
keyword3=_keyword3;
idcompany=_idcompany;
}
 
 
private System.Int32 idrecdocument;
 
public System.Int32 IDRECDOCUMENT
{
get
{
return idrecdocument;
}
set
{
idrecdocument=value;
}
}
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
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
 
private System.String typeofdoc;
 
public System.String TYPEOFDOC
{
get
{
return typeofdoc;
}
set
{
typeofdoc=value;
}
}
 
private System.Byte[] docinbinformat;
 
public System.Byte[] DOCINBINFORMAT
{
get
{
return docinbinformat;
}
set
{
docinbinformat=value;
}
}
 
private System.String keyword1;
 
public System.String KEYWORD1
{
get
{
return keyword1;
}
set
{
keyword1=value;
}
}
 
private System.String keyword2;
 
public System.String KEYWORD2
{
get
{
return keyword2;
}
set
{
keyword2=value;
}
}
 
private System.String keyword3;
 
public System.String KEYWORD3
{
get
{
return keyword3;
}
set
{
keyword3=value;
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
idrecdocument = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
