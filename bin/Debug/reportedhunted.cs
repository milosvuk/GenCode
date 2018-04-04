using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class reportedhunted
 
{
public string connString;
public string connectionString;
public reportedhunted()
{
  
 
 
}
 
public reportedhunted (System.Int32 _idrecreportedhunted,System.Int32 _idrechunter,System.String _licencedmobilenumber,System.DateTime _dateofreport,System.Int32 _idrecspecies,System.Int32 _speciesqty,System.Int32 _typeofgame,System.Int32 _idreclocation,System.Int32 _active )
{
idrecreportedhunted=_idrecreportedhunted;
idrechunter=_idrechunter;
licencedmobilenumber=_licencedmobilenumber;
dateofreport=_dateofreport;
idrecspecies=_idrecspecies;
speciesqty=_speciesqty;
typeofgame=_typeofgame;
idreclocation=_idreclocation;
active=_active;
}
 
 
private System.Int32 idrecreportedhunted;
 
public System.Int32 IDRECREPORTEDHUNTED
{
get
{
return idrecreportedhunted;
}
set
{
idrecreportedhunted=value;
}
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
 
private System.Int32 typeofgame;
 
public System.Int32 TYPEOFGAME
{
get
{
return typeofgame;
}
set
{
typeofgame=value;
}
}
 
private System.Int32 idreclocation;
 
public System.Int32 IDRECLOCATION
{
get
{
return idreclocation;
}
set
{
idreclocation=value;
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
idrecreportedhunted = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
 