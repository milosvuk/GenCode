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
 
public class count_hunters_per_species_include_cond
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public count_hunters_per_species_include_cond()
{
 
  
 
}
 
public count_hunters_per_species_include_cond (System.Int32 _numberofhunters,System.Int32 _idrechunter,System.Int32 _idrecspecies )
{
numberofhunters=_numberofhunters;
idrechunter=_idrechunter;
idrecspecies=_idrecspecies;
}
 
 
private System.Int32 numberofhunters;
 
public System.Int32 NUMBEROFHUNTERS
{
get
{
return numberofhunters;
}
set
{
numberofhunters=value;
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
 
 
public void New()
{
numberofhunters = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
