using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class WeekSS
 
{
public string connString;
public string connectionString;
public WeekSS()
{
  
 
 
}
 
public WeekSS (System.Int32 _idofrecord,System.String _weeknumber,System.String _year_,System.String _storenumber,System.String _storename,System.String _divisionnumberdepartrpro,System.String _divisionnamedepartrpro,System.String _departmentnoclassrpro,System.String _departmentnameclassrpro,System.String _vendorcode,System.String _sales_qtysold_nodisc,System.String _sales_value_euro_nodisc,System.String _sales_value_pound_nodisc,System.String _salesmixpercenatage_nodisc,System.String _stockonhand_nodisc,System.String _stockonhand_valueeuro_nodisc,System.String _stockonhand_valuepound_nodisc,System.String _stockonhandmixpercenatage_nodisc,System.String _stockonhandbranchcover_nodisc,System.String _sales_qtysold_disc,System.String _sales_value_euro_disc,System.String _sales_value_pound_disc,System.String _salesmixpercenatage_disc,System.String _stockonhand_disc,System.String _stockonhand_valueeuro_disc,System.String _stockonhand_valuepound_disc,System.String _stockonhandmixpercenatage_disc,System.String _stockonhandbranchcover_disc,System.String _sales_qtysold_full,System.String _sales_value_euro_full,System.String _sales_value_pound_full,System.String _salesmixpercenatage_full,System.String _stockonhand_full,System.String _stockonhand_valueeuro_full,System.String _stockonhand_valuepound_full,System.String _stockonhandmixpercenatage_full,System.String _stockonhandbranchcover_full )
{
idofrecord=_idofrecord;
weeknumber=_weeknumber;
year_=_year_;
storenumber=_storenumber;
storename=_storename;
divisionnumberdepartrpro=_divisionnumberdepartrpro;
divisionnamedepartrpro=_divisionnamedepartrpro;
departmentnoclassrpro=_departmentnoclassrpro;
departmentnameclassrpro=_departmentnameclassrpro;
vendorcode=_vendorcode;
sales_qtysold_nodisc=_sales_qtysold_nodisc;
sales_value_euro_nodisc=_sales_value_euro_nodisc;
sales_value_pound_nodisc=_sales_value_pound_nodisc;
salesmixpercenatage_nodisc=_salesmixpercenatage_nodisc;
stockonhand_nodisc=_stockonhand_nodisc;
stockonhand_valueeuro_nodisc=_stockonhand_valueeuro_nodisc;
stockonhand_valuepound_nodisc=_stockonhand_valuepound_nodisc;
stockonhandmixpercenatage_nodisc=_stockonhandmixpercenatage_nodisc;
stockonhandbranchcover_nodisc=_stockonhandbranchcover_nodisc;
sales_qtysold_disc=_sales_qtysold_disc;
sales_value_euro_disc=_sales_value_euro_disc;
sales_value_pound_disc=_sales_value_pound_disc;
salesmixpercenatage_disc=_salesmixpercenatage_disc;
stockonhand_disc=_stockonhand_disc;
stockonhand_valueeuro_disc=_stockonhand_valueeuro_disc;
stockonhand_valuepound_disc=_stockonhand_valuepound_disc;
stockonhandmixpercenatage_disc=_stockonhandmixpercenatage_disc;
stockonhandbranchcover_disc=_stockonhandbranchcover_disc;
sales_qtysold_full=_sales_qtysold_full;
sales_value_euro_full=_sales_value_euro_full;
sales_value_pound_full=_sales_value_pound_full;
salesmixpercenatage_full=_salesmixpercenatage_full;
stockonhand_full=_stockonhand_full;
stockonhand_valueeuro_full=_stockonhand_valueeuro_full;
stockonhand_valuepound_full=_stockonhand_valuepound_full;
stockonhandmixpercenatage_full=_stockonhandmixpercenatage_full;
stockonhandbranchcover_full=_stockonhandbranchcover_full;
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
 
private System.String vendorcode;
 
public System.String VENDORCODE
{
get
{
return vendorcode;
}
set
{
vendorcode=value;
}
}
 
private System.String sales_qtysold_nodisc;
 
public System.String SALES_QTYSOLD_NODISC
{
get
{
return sales_qtysold_nodisc;
}
set
{
sales_qtysold_nodisc=value;
}
}
 
private System.String sales_value_euro_nodisc;
 
public System.String SALES_VALUE_EURO_NODISC
{
get
{
return sales_value_euro_nodisc;
}
set
{
sales_value_euro_nodisc=value;
}
}
 
private System.String sales_value_pound_nodisc;
 
public System.String SALES_VALUE_POUND_NODISC
{
get
{
return sales_value_pound_nodisc;
}
set
{
sales_value_pound_nodisc=value;
}
}
 
private System.String salesmixpercenatage_nodisc;
 
public System.String SALESMIXPERCENATAGE_NODISC
{
get
{
return salesmixpercenatage_nodisc;
}
set
{
salesmixpercenatage_nodisc=value;
}
}
 
private System.String stockonhand_nodisc;
 
public System.String STOCKONHAND_NODISC
{
get
{
return stockonhand_nodisc;
}
set
{
stockonhand_nodisc=value;
}
}
 
private System.String stockonhand_valueeuro_nodisc;
 
public System.String STOCKONHAND_VALUEEURO_NODISC
{
get
{
return stockonhand_valueeuro_nodisc;
}
set
{
stockonhand_valueeuro_nodisc=value;
}
}
 
private System.String stockonhand_valuepound_nodisc;
 
public System.String STOCKONHAND_VALUEPOUND_NODISC
{
get
{
return stockonhand_valuepound_nodisc;
}
set
{
stockonhand_valuepound_nodisc=value;
}
}
 
private System.String stockonhandmixpercenatage_nodisc;
 
public System.String STOCKONHANDMIXPERCENATAGE_NODISC
{
get
{
return stockonhandmixpercenatage_nodisc;
}
set
{
stockonhandmixpercenatage_nodisc=value;
}
}
 
private System.String stockonhandbranchcover_nodisc;
 
public System.String STOCKONHANDBRANCHCOVER_NODISC
{
get
{
return stockonhandbranchcover_nodisc;
}
set
{
stockonhandbranchcover_nodisc=value;
}
}
 
private System.String sales_qtysold_disc;
 
public System.String SALES_QTYSOLD_DISC
{
get
{
return sales_qtysold_disc;
}
set
{
sales_qtysold_disc=value;
}
}
 
private System.String sales_value_euro_disc;
 
public System.String SALES_VALUE_EURO_DISC
{
get
{
return sales_value_euro_disc;
}
set
{
sales_value_euro_disc=value;
}
}
 
private System.String sales_value_pound_disc;
 
public System.String SALES_VALUE_POUND_DISC
{
get
{
return sales_value_pound_disc;
}
set
{
sales_value_pound_disc=value;
}
}
 
private System.String salesmixpercenatage_disc;
 
public System.String SALESMIXPERCENATAGE_DISC
{
get
{
return salesmixpercenatage_disc;
}
set
{
salesmixpercenatage_disc=value;
}
}
 
private System.String stockonhand_disc;
 
public System.String STOCKONHAND_DISC
{
get
{
return stockonhand_disc;
}
set
{
stockonhand_disc=value;
}
}
 
private System.String stockonhand_valueeuro_disc;
 
public System.String STOCKONHAND_VALUEEURO_DISC
{
get
{
return stockonhand_valueeuro_disc;
}
set
{
stockonhand_valueeuro_disc=value;
}
}
 
private System.String stockonhand_valuepound_disc;
 
public System.String STOCKONHAND_VALUEPOUND_DISC
{
get
{
return stockonhand_valuepound_disc;
}
set
{
stockonhand_valuepound_disc=value;
}
}
 
private System.String stockonhandmixpercenatage_disc;
 
public System.String STOCKONHANDMIXPERCENATAGE_DISC
{
get
{
return stockonhandmixpercenatage_disc;
}
set
{
stockonhandmixpercenatage_disc=value;
}
}
 
private System.String stockonhandbranchcover_disc;
 
public System.String STOCKONHANDBRANCHCOVER_DISC
{
get
{
return stockonhandbranchcover_disc;
}
set
{
stockonhandbranchcover_disc=value;
}
}
 
private System.String sales_qtysold_full;
 
public System.String SALES_QTYSOLD_FULL
{
get
{
return sales_qtysold_full;
}
set
{
sales_qtysold_full=value;
}
}
 
private System.String sales_value_euro_full;
 
public System.String SALES_VALUE_EURO_FULL
{
get
{
return sales_value_euro_full;
}
set
{
sales_value_euro_full=value;
}
}
 
private System.String sales_value_pound_full;
 
public System.String SALES_VALUE_POUND_FULL
{
get
{
return sales_value_pound_full;
}
set
{
sales_value_pound_full=value;
}
}
 
private System.String salesmixpercenatage_full;
 
public System.String SALESMIXPERCENATAGE_FULL
{
get
{
return salesmixpercenatage_full;
}
set
{
salesmixpercenatage_full=value;
}
}
 
private System.String stockonhand_full;
 
public System.String STOCKONHAND_FULL
{
get
{
return stockonhand_full;
}
set
{
stockonhand_full=value;
}
}
 
private System.String stockonhand_valueeuro_full;
 
public System.String STOCKONHAND_VALUEEURO_FULL
{
get
{
return stockonhand_valueeuro_full;
}
set
{
stockonhand_valueeuro_full=value;
}
}
 
private System.String stockonhand_valuepound_full;
 
public System.String STOCKONHAND_VALUEPOUND_FULL
{
get
{
return stockonhand_valuepound_full;
}
set
{
stockonhand_valuepound_full=value;
}
}
 
private System.String stockonhandmixpercenatage_full;
 
public System.String STOCKONHANDMIXPERCENATAGE_FULL
{
get
{
return stockonhandmixpercenatage_full;
}
set
{
stockonhandmixpercenatage_full=value;
}
}
 
private System.String stockonhandbranchcover_full;
 
public System.String STOCKONHANDBRANCHCOVER_FULL
{
get
{
return stockonhandbranchcover_full;
}
set
{
stockonhandbranchcover_full=value;
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
