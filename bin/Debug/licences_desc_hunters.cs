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
 
public class licences_desc_hunters
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public licences_desc_hunters()
{
 
  
 
}
 
public licences_desc_hunters (System.Int32 _idrechunter,System.String _idcardnumber,System.String _surname,System.String _name,System.String _licencedmobilenumber,System.Int32 _idreclicence,System.Int32 _licenceyear,System.Int32 _paid,System.Decimal _amount,System.String _licencedescription,System.DateTime _startdate,System.DateTime _enddate,System.Int32 _activel,System.String _address2,System.String _address1,System.String _locality,System.String _maltaorgozo )
{
idrechunter=_idrechunter;
idcardnumber=_idcardnumber;
surname=_surname;
name=_name;
licencedmobilenumber=_licencedmobilenumber;
idreclicence=_idreclicence;
licenceyear=_licenceyear;
paid=_paid;
amount=_amount;
licencedescription=_licencedescription;
startdate=_startdate;
enddate=_enddate;
activel=_activel;
address2=_address2;
address1=_address1;
locality=_locality;
maltaorgozo=_maltaorgozo;
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
 
private System.Int32 idreclicence;
 
public System.Int32 IDRECLICENCE
{
get
{
return idreclicence;
}
set
{
idreclicence=value;
}
}
 
private System.Int32 licenceyear;
 
public System.Int32 LICENCEYEAR
{
get
{
return licenceyear;
}
set
{
licenceyear=value;
}
}
 
private System.Int32 paid;
 
public System.Int32 PAID
{
get
{
return paid;
}
set
{
paid=value;
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
 
private System.String licencedescription;
 
public System.String LICENCEDESCRIPTION
{
get
{
return licencedescription;
}
set
{
licencedescription=value;
}
}
 
private System.DateTime startdate;
 
public System.DateTime STARTDATE
{
get
{
return startdate;
}
set
{
startdate=value;
}
}
 
private System.DateTime enddate;
 
public System.DateTime ENDDATE
{
get
{
return enddate;
}
set
{
enddate=value;
}
}
 
private System.Int32 activel;
 
public System.Int32 ACTIVEL
{
get
{
return activel;
}
set
{
activel=value;
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
 
 
public void New()
{
idrechunter = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
