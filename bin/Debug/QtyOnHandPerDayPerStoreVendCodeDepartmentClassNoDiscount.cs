using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount
 
{
public string connString;
public string connectionString;
public QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount()
{
  
 
 
}
 
public QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount (System.Int32 _id,System.Int32 _store_no,System.String _vendor_code,System.String _department,System.String _class_,System.DateTime _dateofsales,System.Int32 _calendarweek,System.Int32 _month,System.Int32 _year,System.Int32 _totalqtyonhand,System.Decimal _totalvalueqtyonhand,System.String _typeofsale )
{
id=_id;
store_no=_store_no;
vendor_code=_vendor_code;
department=_department;
class_=_class_;
dateofsales=_dateofsales;
calendarweek=_calendarweek;
month=_month;
year=_year;
totalqtyonhand=_totalqtyonhand;
totalvalueqtyonhand=_totalvalueqtyonhand;
typeofsale=_typeofsale;
}
 
 
private System.Int32 id;
 
public System.Int32 ID
{
get
{
return id;
}
set
{
id=value;
}
}
 
private System.Int32 store_no;
 
public System.Int32 STORE_NO
{
get
{
return store_no;
}
set
{
store_no=value;
}
}
 
private System.String vendor_code;
 
public System.String VENDOR_CODE
{
get
{
return vendor_code;
}
set
{
vendor_code=value;
}
}
 
private System.String department;
 
public System.String DEPARTMENT
{
get
{
return department;
}
set
{
department=value;
}
}
 
private System.String class_;
 
public System.String CLASS_
{
get
{
return class_;
}
set
{
class_=value;
}
}
 
private System.DateTime dateofsales;
 
public System.DateTime DATEOFSALES
{
get
{
return dateofsales;
}
set
{
dateofsales=value;
}
}
 
private System.Int32 calendarweek;
 
public System.Int32 CALENDARWEEK
{
get
{
return calendarweek;
}
set
{
calendarweek=value;
}
}
 
private System.Int32 month;
 
public System.Int32 MONTH
{
get
{
return month;
}
set
{
month=value;
}
}
 
private System.Int32 year;
 
public System.Int32 YEAR
{
get
{
return year;
}
set
{
year=value;
}
}
 
private System.Int32 totalqtyonhand;
 
public System.Int32 TOTALQTYONHAND
{
get
{
return totalqtyonhand;
}
set
{
totalqtyonhand=value;
}
}
 
private System.Decimal totalvalueqtyonhand;
 
public System.Decimal TOTALVALUEQTYONHAND
{
get
{
return totalvalueqtyonhand;
}
set
{
totalvalueqtyonhand=value;
}
}
 
private System.String typeofsale;
 
public System.String TYPEOFSALE
{
get
{
return typeofsale;
}
set
{
typeofsale=value;
}
}
 
 
public void New()
{
id = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
