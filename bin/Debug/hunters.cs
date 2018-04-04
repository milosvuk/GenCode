using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class hunters
 
{
public string connString;
public string connectionString;
public hunters()
{
  
 
 
}
 
public hunters (System.Int32 _idrechunter,System.String _idcardnumber,System.String _surname,System.String _name,System.String _address1,System.String _address2,System.String _locality,System.String _maltaorgozo,System.String _licencedmobilenumber,System.String _homephonenumber,System.String _desc1,System.String _desc2,System.Int32 _licenceactive,System.Int32 _active )
{
idrechunter=_idrechunter;
idcardnumber=_idcardnumber;
surname=_surname;
name=_name;
address1=_address1;
address2=_address2;
locality=_locality;
maltaorgozo=_maltaorgozo;
licencedmobilenumber=_licencedmobilenumber;
homephonenumber=_homephonenumber;
desc1=_desc1;
desc2=_desc2;
licenceactive=_licenceactive;
active=_active;
}
 
 
private System.Int32 idrechunter;
 
public System.Int32 IDRECHUNTER
{
get
{
return idrechunter;
}
set
{
idrechunter=value;
}
}
 
private System.String idcardnumber;
 
public System.String IDCARDNUMBER
{
get
{
return idcardnumber;
}
set
{
idcardnumber=value;
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
 
private System.String locality;
 
public System.String LOCALITY
{
get
{
return locality;
}
set
{
locality=value;
}
}
 
private System.String maltaorgozo;
 
public System.String MALTAORGOZO
{
get
{
return maltaorgozo;
}
set
{
maltaorgozo=value;
}
}
 
private System.String licencedmobilenumber;
 
public System.String LICENCEDMOBILENUMBER
{
get
{
return licencedmobilenumber;
}
set
{
licencedmobilenumber=value;
}
}
 
private System.String homephonenumber;
 
public System.String HOMEPHONENUMBER
{
get
{
return homephonenumber;
}
set
{
homephonenumber=value;
}
}
 
private System.String desc1;
 
public System.String DESC1
{
get
{
return desc1;
}
set
{
desc1=value;
}
}
 
private System.String desc2;
 
public System.String DESC2
{
get
{
return desc2;
}
set
{
desc2=value;
}
}
 
private System.Int32 licenceactive;
 
public System.Int32 LICENCEACTIVE
{
get
{
return licenceactive;
}
set
{
licenceactive=value;
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
idrechunter = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
