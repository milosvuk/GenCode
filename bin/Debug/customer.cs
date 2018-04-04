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
 
public class customer
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public customer()
{
 
  
 
}
 
public customer (System.Int32 _idcustomer,System.String _customerid,System.String _customersid,System.String _nameofcustomer,System.String _surnameofcustomer,System.String _addressofcustomer,System.String _cityofcustomer,System.String _countryofcustomer,System.Int32 _id_company )
{
idcustomer=_idcustomer;
customerid=_customerid;
customersid=_customersid;
nameofcustomer=_nameofcustomer;
surnameofcustomer=_surnameofcustomer;
addressofcustomer=_addressofcustomer;
cityofcustomer=_cityofcustomer;
countryofcustomer=_countryofcustomer;
id_company=_id_company;
}
 
 
private System.Int32 idcustomer;
 
public System.Int32 IDCUSTOMER
{
get
{
return idcustomer;
}
set
{
idcustomer=value;
}
}
 
private System.String customerid;
 
public System.String CUSTOMERID
{
get
{
return customerid;
}
set
{
customerid=value;
}
}
 
private System.String customersid;
 
public System.String CUSTOMERSID
{
get
{
return customersid;
}
set
{
customersid=value;
}
}
 
private System.String nameofcustomer;
 
public System.String NAMEOFCUSTOMER
{
get
{
return nameofcustomer;
}
set
{
nameofcustomer=value;
}
}
 
private System.String surnameofcustomer;
 
public System.String SURNAMEOFCUSTOMER
{
get
{
return surnameofcustomer;
}
set
{
surnameofcustomer=value;
}
}
 
private System.String addressofcustomer;
 
public System.String ADDRESSOFCUSTOMER
{
get
{
return addressofcustomer;
}
set
{
addressofcustomer=value;
}
}
 
private System.String cityofcustomer;
 
public System.String CITYOFCUSTOMER
{
get
{
return cityofcustomer;
}
set
{
cityofcustomer=value;
}
}
 
private System.String countryofcustomer;
 
public System.String COUNTRYOFCUSTOMER
{
get
{
return countryofcustomer;
}
set
{
countryofcustomer=value;
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
idcustomer = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
