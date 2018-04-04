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
 
public class alltransactions
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public alltransactions()
{
 
  
 
}
 
public alltransactions (System.Int32 _idrec,System.Int32 _iddoc,System.String _dateofdoc,System.String _typeofdoc,System.String _description,System.Decimal _amountofdoc,System.Decimal _remainingamount )
{
idrec=_idrec;
iddoc=_iddoc;
dateofdoc=_dateofdoc;
typeofdoc=_typeofdoc;
description=_description;
amountofdoc=_amountofdoc;
remainingamount=_remainingamount;
}
 
 
private System.Int32 idrec;
 
public System.Int32 IDREC
{
get
{
return idrec;
}
set
{
idrec=value;
}
}
 
private System.Int32 iddoc;
 
public System.Int32 IDDOC
{
get
{
return iddoc;
}
set
{
iddoc=value;
}
}
 
private System.String dateofdoc;
 
public System.String DATEOFDOC
{
get
{
return dateofdoc;
}
set
{
dateofdoc=value;
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
 
private System.Decimal amountofdoc;
 
public System.Decimal AMOUNTOFDOC
{
get
{
return amountofdoc;
}
set
{
amountofdoc=value;
}
}
 
private System.Decimal remainingamount;
 
public System.Decimal REMAININGAMOUNT
{
get
{
return remainingamount;
}
set
{
remainingamount=value;
}
}
 
 
public void New()
{
idrec = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
