using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount
 
{
public string connString;
public string connectionString;
public DB_QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount (Store_no,Vendor_code,Department,Class_,DateOfSales,CalendarWeek,Month,Year,TotalQtyOnHand,TotalValueQtyOnHand,TypeOfSale) VALUES (@Store_no,@Vendor_code,@Department,@Class_,@DateOfSales,@CalendarWeek,@Month,@Year,@TotalQtyOnHand,@TotalValueQtyOnHand,@TypeOfSale) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@Store_no", _tmpObject.STORE_NO));
command.Parameters.Add(new SqlParameter("@Vendor_code", _tmpObject.VENDOR_CODE));
command.Parameters.Add(new SqlParameter("@Department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@Class_", _tmpObject.CLASS_));
command.Parameters.Add(new SqlParameter("@DateOfSales", _tmpObject.DATEOFSALES));
command.Parameters.Add(new SqlParameter("@CalendarWeek", _tmpObject.CALENDARWEEK));
command.Parameters.Add(new SqlParameter("@Month", _tmpObject.MONTH));
command.Parameters.Add(new SqlParameter("@Year", _tmpObject.YEAR));
command.Parameters.Add(new SqlParameter("@TotalQtyOnHand", _tmpObject.TOTALQTYONHAND));
command.Parameters.Add(new SqlParameter("@TotalValueQtyOnHand", _tmpObject.TOTALVALUEQTYONHAND));
command.Parameters.Add(new SqlParameter("@TypeOfSale", _tmpObject.TYPEOFSALE));
command.Parameters.Add(new SqlParameter("@tmpid", SqlDbType.Int));
command.Parameters["@tmpid"].Direction = ParameterDirection.Output;
command.ExecuteNonQuery();
res = (int)command.Parameters["@tmpid"].Value;
return res;
}
////==========================================================================
//END ADD WITH PARAMETERS
////==========================================================================
////==========================================================================
// UPDATE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Update(QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount SET Store_no=@store_no,Vendor_code=@vendor_code,Department=@department,Class_=@class_,DateOfSales=@dateofsales,CalendarWeek=@calendarweek,Month=@month,Year=@year,TotalQtyOnHand=@totalqtyonhand,TotalValueQtyOnHand=@totalvalueqtyonhand,TypeOfSale=@typeofsale  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@store_no", _tmpObject.STORE_NO));
command.Parameters.Add(new SqlParameter("@vendor_code", _tmpObject.VENDOR_CODE));
command.Parameters.Add(new SqlParameter("@department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@class_", _tmpObject.CLASS_));
command.Parameters.Add(new SqlParameter("@dateofsales", _tmpObject.DATEOFSALES));
command.Parameters.Add(new SqlParameter("@calendarweek", _tmpObject.CALENDARWEEK));
command.Parameters.Add(new SqlParameter("@month", _tmpObject.MONTH));
command.Parameters.Add(new SqlParameter("@year", _tmpObject.YEAR));
command.Parameters.Add(new SqlParameter("@totalqtyonhand", _tmpObject.TOTALQTYONHAND));
command.Parameters.Add(new SqlParameter("@totalvalueqtyonhand", _tmpObject.TOTALVALUEQTYONHAND));
command.Parameters.Add(new SqlParameter("@typeofsale", _tmpObject.TYPEOFSALE));
command.Parameters.Add(new SqlParameter("@id", _tmpObject.ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id", _tmpObject.ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount GetById(int _id)
{
QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount tmpObject = new QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From QtyOnHandPerDayPerStoreVendCodeDepartmentClassNoDiscount WHERE id=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID = (System.Int32)dr["id"];
tmpObject.STORE_NO = (System.Int32)dr["Store_no"];
tmpObject.VENDOR_CODE = (System.String)dr["Vendor_code"];
tmpObject.DEPARTMENT = (System.String)dr["Department"];
tmpObject.CLASS_ = (System.String)dr["Class_"];
tmpObject.DATEOFSALES = (System.DateTime)dr["DateOfSales"];
tmpObject.CALENDARWEEK = (System.Int32)dr["CalendarWeek"];
tmpObject.MONTH = (System.Int32)dr["Month"];
tmpObject.YEAR = (System.Int32)dr["Year"];
tmpObject.TOTALQTYONHAND = (System.Int32)dr["TotalQtyOnHand"];
tmpObject.TOTALVALUEQTYONHAND = (System.Decimal)dr["TotalValueQtyOnHand"];
tmpObject.TYPEOFSALE = (System.String)dr["TypeOfSale"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
////==========================================================================
 
}
