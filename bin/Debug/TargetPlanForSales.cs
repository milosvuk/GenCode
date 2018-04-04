using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class TargetPlanForSales
 
{
public string connString;
public string connectionString;
public TargetPlanForSales()
{
  
 
 
}
 
public TargetPlanForSales (System.Int32 _id,System.Int32 _store_no,System.String _vendor_code,System.String _department,System.String _classs_,System.Int32 _year,System.Int32 _calendarweek,System.Decimal _targetsales,System.Decimal _targetsalescumulative )
{
id=_id;
store_no=_store_no;
vendor_code=_vendor_code;
department=_department;
classs_=_classs_;
year=_year;
calendarweek=_calendarweek;
targetsales=_targetsales;
targetsalescumulative=_targetsalescumulative;
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
 
private System.String classs_;
 
public System.String CLASSS_
{
get
{
return classs_;
}
set
{
classs_=value;
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
 
private System.Decimal targetsales;
 
public System.Decimal TARGETSALES
{
get
{
return targetsales;
}
set
{
targetsales=value;
}
}
 
private System.Decimal targetsalescumulative;
 
public System.Decimal TARGETSALESCUMULATIVE
{
get
{
return targetsalescumulative;
}
set
{
targetsalescumulative=value;
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
