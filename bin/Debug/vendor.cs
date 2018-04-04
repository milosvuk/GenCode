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
 
public class vendor
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public vendor()
{
 
  
 
}
 
public vendor (System.Int32 _idvendor,System.String _vendorcode,System.String _nameofvendor,System.Int32 _id_company )
{
idvendor=_idvendor;
vendorcode=_vendorcode;
nameofvendor=_nameofvendor;
id_company=_id_company;
}
 
 
private System.Int32 idvendor;
 
public System.Int32 IDVENDOR
{
get
{
return idvendor;
}
set
{
idvendor=value;
}
}
 
private System.String vendorcode;
 
public System.String VENDORCODE
{
get
{
return vendorcode;
}
set
{
vendorcode=value;
}
}
 
private System.String nameofvendor;
 
public System.String NAMEOFVENDOR
{
get
{
return nameofvendor;
}
set
{
nameofvendor=value;
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
idvendor = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
