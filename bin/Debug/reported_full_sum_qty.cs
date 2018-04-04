using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class reported_full_sum_qty
 
{
public string connString;
public string connectionString;
public reported_full_sum_qty()
{
  
 
 
}
 
public reported_full_sum_qty (System.Int32 _idrechunter,System.Int32 _idrecspecies,System.Int32 _qty,System.String _idcardnumber,System.String _surname,System.String _name,System.String _licencedmobilenumber,System.String _speciesname )
{
idrechunter=_idrechunter;
idrecspecies=_idrecspecies;
qty=_qty;
idcardnumber=_idcardnumber;
surname=_surname;
name=_name;
licencedmobilenumber=_licencedmobilenumber;
speciesname=_speciesname;
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
 
private System.Int32 qty;
 
public System.Int32 QTY
{
get
{
return qty;
}
set
{
qty=value;
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
 
 
public void New()
{
idrechunter = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
 