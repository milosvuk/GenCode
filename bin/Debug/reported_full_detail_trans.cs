using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class reported_full_detail_trans
 
{
public string connString;
public string connectionString;
public reported_full_detail_trans()
{
  
 
 
}
 
public reported_full_detail_trans (System.Int32 _idrechunter,System.String _idcardnumber,System.String _surname,System.String _name,System.String _licencedmobilenumber,System.DateTime _dateofreport,System.Int32 _idrecspecies,System.Int32 _speciesqty,System.Int32 _active,System.String _speciesname,System.Int32 _nationalqty,System.Int32 _peryear,System.Int32 _idrecspeciesgroup )
{
idrechunter=_idrechunter;
idcardnumber=_idcardnumber;
surname=_surname;
name=_name;
licencedmobilenumber=_licencedmobilenumber;
dateofreport=_dateofreport;
idrecspecies=_idrecspecies;
speciesqty=_speciesqty;
active=_active;
speciesname=_speciesname;
nationalqty=_nationalqty;
peryear=_peryear;
idrecspeciesgroup=_idrecspeciesgroup;
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
 
private System.DateTime dateofreport;
 
public System.DateTime DATEOFREPORT
{
get
{
return dateofreport;
}
set
{
dateofreport=value;
}
}
 
private System.Int32 idrecspecies;
 
public System.Int32 IDRECSPECIES
{
get
{
return idrecspecies;
}
set
{
idrecspecies=value;
}
}
 
private System.Int32 speciesqty;
 
public System.Int32 SPECIESQTY
{
get
{
return speciesqty;
}
set
{
speciesqty=value;
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
 
private System.String speciesname;
 
public System.String SPECIESNAME
{
get
{
return speciesname;
}
set
{
speciesname=value;
}
}
 
private System.Int32 nationalqty;
 
public System.Int32 NATIONALQTY
{
get
{
return nationalqty;
}
set
{
nationalqty=value;
}
}
 
private System.Int32 peryear;
 
public System.Int32 PERYEAR
{
get
{
return peryear;
}
set
{
peryear=value;
}
}
 
private System.Int32 idrecspeciesgroup;
 
public System.Int32 IDRECSPECIESGROUP
{
get
{
return idrecspeciesgroup;
}
set
{
idrecspeciesgroup=value;
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
 