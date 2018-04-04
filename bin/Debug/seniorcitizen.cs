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
 
public class seniorcitizen
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public seniorcitizen()
{
 
  
 
}
 
public seniorcitizen (System.Int32 _idseniorcitizen,System.String _name,System.String _surname,System.String _idcard,System.String _address1,System.String _address2,System.String _address3,System.String _city,System.String _loccoordlat,System.String _loccoordlong,System.String _phone,System.String _mobile,System.String _email,System.String _comment,System.Int32 _active )
{
idseniorcitizen=_idseniorcitizen;
name=_name;
surname=_surname;
idcard=_idcard;
address1=_address1;
address2=_address2;
address3=_address3;
city=_city;
loccoordlat=_loccoordlat;
loccoordlong=_loccoordlong;
phone=_phone;
mobile=_mobile;
email=_email;
comment=_comment;
active=_active;
}
 
 
private System.Int32 idseniorcitizen;
 
public System.Int32 IDSENIORCITIZEN
{
get
{
return idseniorcitizen;
}
set
{
idseniorcitizen=value;
}
}
 
private System.String name;
 
public System.String NAME
{
get
{
return name;
}
set
{
name=value;
}
}
 
private System.String surname;
 
public System.String SURNAME
{
get
{
return surname;
}
set
{
surname=value;
}
}
 
private System.String idcard;
 
public System.String IDCARD
{
get
{
return idcard;
}
set
{
idcard=value;
}
}
 
private System.String address1;
 
public System.String ADDRESS1
{
get
{
return address1;
}
set
{
address1=value;
}
}
 
private System.String address2;
 
public System.String ADDRESS2
{
get
{
return address2;
}
set
{
address2=value;
}
}
 
private System.String address3;
 
public System.String ADDRESS3
{
get
{
return address3;
}
set
{
address3=value;
}
}
 
private System.String city;
 
public System.String CITY
{
get
{
return city;
}
set
{
city=value;
}
}
 
private System.String loccoordlat;
 
public System.String LOCCOORDLAT
{
get
{
return loccoordlat;
}
set
{
loccoordlat=value;
}
}
 
private System.String loccoordlong;
 
public System.String LOCCOORDLONG
{
get
{
return loccoordlong;
}
set
{
loccoordlong=value;
}
}
 
private System.String phone;
 
public System.String PHONE
{
get
{
return phone;
}
set
{
phone=value;
}
}
 
private System.String mobile;
 
public System.String MOBILE
{
get
{
return mobile;
}
set
{
mobile=value;
}
}
 
private System.String email;
 
public System.String EMAIL
{
get
{
return email;
}
set
{
email=value;
}
}
 
private System.String comment;
 
public System.String COMMENT
{
get
{
return comment;
}
set
{
comment=value;
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
 
 
public void New()
{
idseniorcitizen = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
