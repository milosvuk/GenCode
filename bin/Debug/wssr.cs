using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class wssr
 
{
public string connString;
public string connectionString;
public wssr()
{
  
 
 
}
 
public wssr (System.Int32 _idofrecord,System.String _weeknumber,System.String _year_,System.String _company,System.String _currrency,System.String _country,System.String _storenumber,System.String _storename,System.String _neworexistingdep,System.String _salestyoe,System.String _divisionnumberdepartrpro,System.String _divisionnamedepartrpro,System.String _departmentnoclassrpro,System.String _departmentnameclassrpro,System.String _salesvaluethisweekthisyear,System.String _salesvaluethisweeklastyear,System.String _cumulativesalesvaluethisweekthisyear,System.String _cumulativesalesvaluethisweeklastyear,System.String _unitsoldthisweekthisyear,System.String _unitssoldthisweeklastyear,System.String _salestargetforthisweekthisyear,System.String _cumulativesalesforthisweekthisyear,System.String _cashmarginthisweekthisyear,System.String _cashmarginthisweeklastyear,System.String _markdownspendthisyear,System.String _markdownspendlastiyear,System.String _branchstockvaluethisyear,System.String _branchstockvaluelastyear,System.String _branchstockunitsthsiweekthisyear,System.String _branchstockunitslastyear,System.String _terminalstockunitsthisyearsaleitems,System.String _terminalstockunitslastyearsaleitems,System.String _spacethisyear,System.String _spacelastyear )
{
idofrecord=_idofrecord;
weeknumber=_weeknumber;
year_=_year_;
company=_company;
currrency=_currrency;
country=_country;
storenumber=_storenumber;
storename=_storename;
neworexistingdep=_neworexistingdep;
salestyoe=_salestyoe;
divisionnumberdepartrpro=_divisionnumberdepartrpro;
divisionnamedepartrpro=_divisionnamedepartrpro;
departmentnoclassrpro=_departmentnoclassrpro;
departmentnameclassrpro=_departmentnameclassrpro;
salesvaluethisweekthisyear=_salesvaluethisweekthisyear;
salesvaluethisweeklastyear=_salesvaluethisweeklastyear;
cumulativesalesvaluethisweekthisyear=_cumulativesalesvaluethisweekthisyear;
cumulativesalesvaluethisweeklastyear=_cumulativesalesvaluethisweeklastyear;
unitsoldthisweekthisyear=_unitsoldthisweekthisyear;
unitssoldthisweeklastyear=_unitssoldthisweeklastyear;
salestargetforthisweekthisyear=_salestargetforthisweekthisyear;
cumulativesalesforthisweekthisyear=_cumulativesalesforthisweekthisyear;
cashmarginthisweekthisyear=_cashmarginthisweekthisyear;
cashmarginthisweeklastyear=_cashmarginthisweeklastyear;
markdownspendthisyear=_markdownspendthisyear;
markdownspendlastiyear=_markdownspendlastiyear;
branchstockvaluethisyear=_branchstockvaluethisyear;
branchstockvaluelastyear=_branchstockvaluelastyear;
branchstockunitsthsiweekthisyear=_branchstockunitsthsiweekthisyear;
branchstockunitslastyear=_branchstockunitslastyear;
terminalstockunitsthisyearsaleitems=_terminalstockunitsthisyearsaleitems;
terminalstockunitslastyearsaleitems=_terminalstockunitslastyearsaleitems;
spacethisyear=_spacethisyear;
spacelastyear=_spacelastyear;
}
 
 
private System.Int32 idofrecord;
 
public System.Int32 IDOFRECORD
{
get
{
return idofrecord;
}
set
{
idofrecord=value;
}
}
 
private System.String weeknumber;
 
public System.String WEEKNUMBER
{
get
{
return weeknumber;
}
set
{
weeknumber=value;
}
}
 
private System.String year_;
 
public System.String YEAR_
{
get
{
return year_;
}
set
{
year_=value;
}
}
 
private System.String company;
 
public System.String COMPANY
{
get
{
return company;
}
set
{
company=value;
}
}
 
private System.String currrency;
 
public System.String CURRRENCY
{
get
{
return currrency;
}
set
{
currrency=value;
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
 
private System.String storenumber;
 
public System.String STORENUMBER
{
get
{
return storenumber;
}
set
{
storenumber=value;
}
}
 
private System.String storename;
 
public System.String STORENAME
{
get
{
return storename;
}
set
{
storename=value;
}
}
 
private System.String neworexistingdep;
 
public System.String NEWOREXISTINGDEP
{
get
{
return neworexistingdep;
}
set
{
neworexistingdep=value;
}
}
 
private System.String salestyoe;
 
public System.String SALESTYOE
{
get
{
return salestyoe;
}
set
{
salestyoe=value;
}
}
 
private System.String divisionnumberdepartrpro;
 
public System.String DIVISIONNUMBERDEPARTRPRO
{
get
{
return divisionnumberdepartrpro;
}
set
{
divisionnumberdepartrpro=value;
}
}
 
private System.String divisionnamedepartrpro;
 
public System.String DIVISIONNAMEDEPARTRPRO
{
get
{
return divisionnamedepartrpro;
}
set
{
divisionnamedepartrpro=value;
}
}
 
private System.String departmentnoclassrpro;
 
public System.String DEPARTMENTNOCLASSRPRO
{
get
{
return departmentnoclassrpro;
}
set
{
departmentnoclassrpro=value;
}
}
 
private System.String departmentnameclassrpro;
 
public System.String DEPARTMENTNAMECLASSRPRO
{
get
{
return departmentnameclassrpro;
}
set
{
departmentnameclassrpro=value;
}
}
 
private System.String salesvaluethisweekthisyear;
 
public System.String SALESVALUETHISWEEKTHISYEAR
{
get
{
return salesvaluethisweekthisyear;
}
set
{
salesvaluethisweekthisyear=value;
}
}
 
private System.String salesvaluethisweeklastyear;
 
public System.String SALESVALUETHISWEEKLASTYEAR
{
get
{
return salesvaluethisweeklastyear;
}
set
{
salesvaluethisweeklastyear=value;
}
}
 
private System.String cumulativesalesvaluethisweekthisyear;
 
public System.String CUMULATIVESALESVALUETHISWEEKTHISYEAR
{
get
{
return cumulativesalesvaluethisweekthisyear;
}
set
{
cumulativesalesvaluethisweekthisyear=value;
}
}
 
private System.String cumulativesalesvaluethisweeklastyear;
 
public System.String CUMULATIVESALESVALUETHISWEEKLASTYEAR
{
get
{
return cumulativesalesvaluethisweeklastyear;
}
set
{
cumulativesalesvaluethisweeklastyear=value;
}
}
 
private System.String unitsoldthisweekthisyear;
 
public System.String UNITSOLDTHISWEEKTHISYEAR
{
get
{
return unitsoldthisweekthisyear;
}
set
{
unitsoldthisweekthisyear=value;
}
}
 
private System.String unitssoldthisweeklastyear;
 
public System.String UNITSSOLDTHISWEEKLASTYEAR
{
get
{
return unitssoldthisweeklastyear;
}
set
{
unitssoldthisweeklastyear=value;
}
}
 
private System.String salestargetforthisweekthisyear;
 
public System.String SALESTARGETFORTHISWEEKTHISYEAR
{
get
{
return salestargetforthisweekthisyear;
}
set
{
salestargetforthisweekthisyear=value;
}
}
 
private System.String cumulativesalesforthisweekthisyear;
 
public System.String CUMULATIVESALESFORTHISWEEKTHISYEAR
{
get
{
return cumulativesalesforthisweekthisyear;
}
set
{
cumulativesalesforthisweekthisyear=value;
}
}
 
private System.String cashmarginthisweekthisyear;
 
public System.String CASHMARGINTHISWEEKTHISYEAR
{
get
{
return cashmarginthisweekthisyear;
}
set
{
cashmarginthisweekthisyear=value;
}
}
 
private System.String cashmarginthisweeklastyear;
 
public System.String CASHMARGINTHISWEEKLASTYEAR
{
get
{
return cashmarginthisweeklastyear;
}
set
{
cashmarginthisweeklastyear=value;
}
}
 
private System.String markdownspendthisyear;
 
public System.String MARKDOWNSPENDTHISYEAR
{
get
{
return markdownspendthisyear;
}
set
{
markdownspendthisyear=value;
}
}
 
private System.String markdownspendlastiyear;
 
public System.String MARKDOWNSPENDLASTIYEAR
{
get
{
return markdownspendlastiyear;
}
set
{
markdownspendlastiyear=value;
}
}
 
private System.String branchstockvaluethisyear;
 
public System.String BRANCHSTOCKVALUETHISYEAR
{
get
{
return branchstockvaluethisyear;
}
set
{
branchstockvaluethisyear=value;
}
}
 
private System.String branchstockvaluelastyear;
 
public System.String BRANCHSTOCKVALUELASTYEAR
{
get
{
return branchstockvaluelastyear;
}
set
{
branchstockvaluelastyear=value;
}
}
 
private System.String branchstockunitsthsiweekthisyear;
 
public System.String BRANCHSTOCKUNITSTHSIWEEKTHISYEAR
{
get
{
return branchstockunitsthsiweekthisyear;
}
set
{
branchstockunitsthsiweekthisyear=value;
}
}
 
private System.String branchstockunitslastyear;
 
public System.String BRANCHSTOCKUNITSLASTYEAR
{
get
{
return branchstockunitslastyear;
}
set
{
branchstockunitslastyear=value;
}
}
 
private System.String terminalstockunitsthisyearsaleitems;
 
public System.String TERMINALSTOCKUNITSTHISYEARSALEITEMS
{
get
{
return terminalstockunitsthisyearsaleitems;
}
set
{
terminalstockunitsthisyearsaleitems=value;
}
}
 
private System.String terminalstockunitslastyearsaleitems;
 
public System.String TERMINALSTOCKUNITSLASTYEARSALEITEMS
{
get
{
return terminalstockunitslastyearsaleitems;
}
set
{
terminalstockunitslastyearsaleitems=value;
}
}
 
private System.String spacethisyear;
 
public System.String SPACETHISYEAR
{
get
{
return spacethisyear;
}
set
{
spacethisyear=value;
}
}
 
private System.String spacelastyear;
 
public System.String SPACELASTYEAR
{
get
{
return spacelastyear;
}
set
{
spacelastyear=value;
}
}
 
 
public void New()
{
idofrecord = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
