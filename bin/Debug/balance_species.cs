using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class balance_species
 
{
public string connString;
public string connectionString;
public balance_species()
{
  
 
 
}
 
public balance_species (System.String _speciesname,System.Int32 _nationalqty,System.Int32 _reportedqty,System.Int32 _balanceqty )
{
speciesname=_speciesname;
nationalqty=_nationalqty;
reportedqty=_reportedqty;
balanceqty=_balanceqty;
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
 
private System.Int32 reportedqty;
 
public System.Int32 REPORTEDQTY
{
get
{
return reportedqty;
}
set
{
reportedqty=value;
}
}
 
private System.Int32 balanceqty;
 
public System.Int32 BALANCEQTY
{
get
{
return balanceqty;
}
set
{
balanceqty=value;
}
}
 
 
public void New()
{
speciesname = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
 
