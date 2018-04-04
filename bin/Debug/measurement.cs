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
 
public class measurement
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public measurement()
{
 
  
 
}
 
public measurement (System.Int32 _idmeasurement,System.String _codeoflocation,System.DateTime _dateofmeasurement,System.String _codeofindicator,System.Decimal _valueofmeasurement,System.String _description,System.Int32 _weekm,System.Int32 _monthm,System.Int32 _yearm,System.Int32 _idcustomer )
{
idmeasurement=_idmeasurement;
codeoflocation=_codeoflocation;
dateofmeasurement=_dateofmeasurement;
codeofindicator=_codeofindicator;
valueofmeasurement=_valueofmeasurement;
description=_description;
weekm=_weekm;
monthm=_monthm;
yearm=_yearm;
idcustomer=_idcustomer;
}
 
 
private System.Int32 idmeasurement;
 
public System.Int32 IDMEASUREMENT
{
get
{
return idmeasurement;
}
set
{
idmeasurement=value;
}
}
 
private System.String codeoflocation;
 
public System.String CODEOFLOCATION
{
get
{
return codeoflocation;
}
set
{
codeoflocation=value;
}
}
 
private System.DateTime dateofmeasurement;
 
public System.DateTime DATEOFMEASUREMENT
{
get
{
return dateofmeasurement;
}
set
{
dateofmeasurement=value;
}
}
 
private System.String codeofindicator;
 
public System.String CODEOFINDICATOR
{
get
{
return codeofindicator;
}
set
{
codeofindicator=value;
}
}
 
private System.Decimal valueofmeasurement;
 
public System.Decimal VALUEOFMEASUREMENT
{
get
{
return valueofmeasurement;
}
set
{
valueofmeasurement=value;
}
}
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
}
}
 
private System.Int32 weekm;
 
public System.Int32 WEEKM
{
get
{
return weekm;
}
set
{
weekm=value;
}
}
 
private System.Int32 monthm;
 
public System.Int32 MONTHM
{
get
{
return monthm;
}
set
{
monthm=value;
}
}
 
private System.Int32 yearm;
 
public System.Int32 YEARM
{
get
{
return yearm;
}
set
{
yearm=value;
}
}
 
private System.Int32 idcustomer;
 
public System.Int32 IDCUSTOMER
{
get
{
return idcustomer;
}
set
{
idcustomer=value;
}
}
 
 
public void New()
{
idmeasurement = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
