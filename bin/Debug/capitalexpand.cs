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
 
public class capitalexpand
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public capitalexpand()
{
 
  
 
}
 
public capitalexpand (System.Int32 _idcapitalexp,System.Int32 _idproperty,System.Int32 _idexpense,System.DateTime _dateofcap,System.String _details,System.Decimal _amount,System.Int32 _active,System.Int32 _idcompany )
{
idcapitalexp=_idcapitalexp;
idproperty=_idproperty;
idexpense=_idexpense;
dateofcap=_dateofcap;
details=_details;
amount=_amount;
active=_active;
idcompany=_idcompany;
}
 
 
private System.Int32 idcapitalexp;
 
public System.Int32 IDCAPITALEXP
{
get
{
return idcapitalexp;
}
set
{
idcapitalexp=value;
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
 
private System.Int32 idexpense;
 
public System.Int32 IDEXPENSE
{
get
{
return idexpense;
}
set
{
idexpense=value;
}
}
 
private System.DateTime dateofcap;
 
public System.DateTime DATEOFCAP
{
get
{
return dateofcap;
}
set
{
dateofcap=value;
}
}
 
private System.String details;
 
public System.String DETAILS
{
get
{
return details;
}
set
{
details=value;
}
}
 
private System.Decimal amount;
 
public System.Decimal AMOUNT
{
get
{
return amount;
}
set
{
amount=value;
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
idcapitalexp = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
