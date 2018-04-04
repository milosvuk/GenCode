using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class species
 
{
public string connString;
public string connectionString;
public species()
{
  
 
 
}
 
public species (System.Int32 _idrecspecies,System.Int32 _idrecspeciesgroup,System.String _speciesname,System.Int32 _nationalqty,System.Int32 _peryear,System.Int32 _active )
{
idrecspecies=_idrecspecies;
idrecspeciesgroup=_idrecspeciesgroup;
speciesname=_speciesname;
nationalqty=_nationalqty;
peryear=_peryear;
active=_active;
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
idrecspecies = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
