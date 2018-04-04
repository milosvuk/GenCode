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
 
public class exportedinvoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public exportedinvoice()
{
 
  
 
}
 
public exportedinvoice (System.Int32 _idexportedinvoice,System.Int32 _idinvoice,System.String _typeofac,System.String _accountreference,System.String _nominalacref,System.String _department,System.String _dateofinv,System.String _referencecode,System.String _details,System.String _netamount,System.String _taxcode,System.String _taxamount,System.String _exchangerate,System.String _extrareference,System.String _username,System.String _projectrefn,System.String _costocderefn )
{
idexportedinvoice=_idexportedinvoice;
idinvoice=_idinvoice;
typeofac=_typeofac;
accountreference=_accountreference;
nominalacref=_nominalacref;
department=_department;
dateofinv=_dateofinv;
referencecode=_referencecode;
details=_details;
netamount=_netamount;
taxcode=_taxcode;
taxamount=_taxamount;
exchangerate=_exchangerate;
extrareference=_extrareference;
username=_username;
projectrefn=_projectrefn;
costocderefn=_costocderefn;
}
 
 
private System.Int32 idexportedinvoice;
 
public System.Int32 IDEXPORTEDINVOICE
{
get
{
return idexportedinvoice;
}
set
{
idexportedinvoice=value;
}
}
 
private System.Int32 idinvoice;
 
public System.Int32 IDINVOICE
{
get
{
return idinvoice;
}
set
{
idinvoice=value;
}
}
 
private System.String typeofac;
 
public System.String TYPEOFAC
{
get
{
return typeofac;
}
set
{
typeofac=value;
}
}
 
private System.String accountreference;
 
public System.String ACCOUNTREFERENCE
{
get
{
return accountreference;
}
set
{
accountreference=value;
}
}
 
private System.String nominalacref;
 
public System.String NOMINALACREF
{
get
{
return nominalacref;
}
set
{
nominalacref=value;
}
}
 
private System.String department;
 
public System.String DEPARTMENT
{
get
{
return department;
}
set
{
department=value;
}
}
 
private System.String dateofinv;
 
public System.String DATEOFINV
{
get
{
return dateofinv;
}
set
{
dateofinv=value;
}
}
 
private System.String referencecode;
 
public System.String REFERENCECODE
{
get
{
return referencecode;
}
set
{
referencecode=value;
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
 
private System.String netamount;
 
public System.String NETAMOUNT
{
get
{
return netamount;
}
set
{
netamount=value;
}
}
 
private System.String taxcode;
 
public System.String TAXCODE
{
get
{
return taxcode;
}
set
{
taxcode=value;
}
}
 
private System.String taxamount;
 
public System.String TAXAMOUNT
{
get
{
return taxamount;
}
set
{
taxamount=value;
}
}
 
private System.String exchangerate;
 
public System.String EXCHANGERATE
{
get
{
return exchangerate;
}
set
{
exchangerate=value;
}
}
 
private System.String extrareference;
 
public System.String EXTRAREFERENCE
{
get
{
return extrareference;
}
set
{
extrareference=value;
}
}
 
private System.String username;
 
public System.String USERNAME
{
get
{
return username;
}
set
{
username=value;
}
}
 
private System.String projectrefn;
 
public System.String PROJECTREFN
{
get
{
return projectrefn;
}
set
{
projectrefn=value;
}
}
 
private System.String costocderefn;
 
public System.String COSTOCDEREFN
{
get
{
return costocderefn;
}
set
{
costocderefn=value;
}
}
 
 
public void New()
{
idexportedinvoice = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
