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
 
public class networkoperators
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public networkoperators()
{
 
  
 
}
 
public networkoperators (System.Int32 _id,System.String _country,System.String _network,System.String _mcc,System.String _mnc,System.String _countrycode )
{
id=_id;
country=_country;
network=_network;
mcc=_mcc;
mnc=_mnc;
countrycode=_countrycode;
}
 
 
private System.Int32 id;
 
public System.Int32 ID
{
get
{
return id;
}
set
{
id=value;
}
}
 
private System.String country;
 
public System.String COUNTRY
{
get
{
return country;
}
set
{
country=value;
}
}
 
private System.String network;
 
public System.String NETWORK
{
get
{
return network;
}
set
{
network=value;
}
}
 
private System.String mcc;
 
public System.String MCC
{
get
{
return mcc;
}
set
{
mcc=value;
}
}
 
private System.String mnc;
 
public System.String MNC
{
get
{
return mnc;
}
set
{
mnc=value;
}
}
 
private System.String countrycode;
 
public System.String COUNTRYCODE
{
get
{
return countrycode;
}
set
{
countrycode=value;
}
}
 
 
public void New()
{
id = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
