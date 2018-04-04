using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_TargetPlanForSales
 
{
public string connString;
public string connectionString;
public DB_TargetPlanForSales()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(TargetPlanForSales _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(TargetPlanForSales _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO TargetPlanForSales (Store_No,Vendor_code,Department,Classs_,Year,CalendarWeek,TargetSales,TargetSalesCumulative) VALUES (@Store_No,@Vendor_code,@Department,@Classs_,@Year,@CalendarWeek,@TargetSales,@TargetSalesCumulative) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@Store_No", _tmpObject.STORE_NO));
command.Parameters.Add(new SqlParameter("@Vendor_code", _tmpObject.VENDOR_CODE));
command.Parameters.Add(new SqlParameter("@Department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@Classs_", _tmpObject.CLASSS_));
command.Parameters.Add(new SqlParameter("@Year", _tmpObject.YEAR));
command.Parameters.Add(new SqlParameter("@CalendarWeek", _tmpObject.CALENDARWEEK));
command.Parameters.Add(new SqlParameter("@TargetSales", _tmpObject.TARGETSALES));
command.Parameters.Add(new SqlParameter("@TargetSalesCumulative", _tmpObject.TARGETSALESCUMULATIVE));
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
 
public int Update(TargetPlanForSales _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(TargetPlanForSales _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE TargetPlanForSales SET Store_No=@store_no,Vendor_code=@vendor_code,Department=@department,Classs_=@classs_,Year=@year,CalendarWeek=@calendarweek,TargetSales=@targetsales,TargetSalesCumulative=@targetsalescumulative  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@store_no", _tmpObject.STORE_NO));
command.Parameters.Add(new SqlParameter("@vendor_code", _tmpObject.VENDOR_CODE));
command.Parameters.Add(new SqlParameter("@department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@classs_", _tmpObject.CLASSS_));
command.Parameters.Add(new SqlParameter("@year", _tmpObject.YEAR));
command.Parameters.Add(new SqlParameter("@calendarweek", _tmpObject.CALENDARWEEK));
command.Parameters.Add(new SqlParameter("@targetsales", _tmpObject.TARGETSALES));
command.Parameters.Add(new SqlParameter("@targetsalescumulative", _tmpObject.TARGETSALESCUMULATIVE));
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
 
public int Delete(TargetPlanForSales _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(TargetPlanForSales _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE TargetPlanForSales  WHERE id=@id", conn);
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
public TargetPlanForSales GetById(int _id)
{
TargetPlanForSales tmpObject = new TargetPlanForSales();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From TargetPlanForSales WHERE id=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID = (System.Int32)dr["id"];
tmpObject.STORE_NO = (System.Int32)dr["Store_No"];
tmpObject.VENDOR_CODE = (System.String)dr["Vendor_code"];
tmpObject.DEPARTMENT = (System.String)dr["Department"];
tmpObject.CLASSS_ = (System.String)dr["Classs_"];
tmpObject.YEAR = (System.Int32)dr["Year"];
tmpObject.CALENDARWEEK = (System.Int32)dr["CalendarWeek"];
tmpObject.TARGETSALES = (System.Decimal)dr["TargetSales"];
tmpObject.TARGETSALESCUMULATIVE = (System.Decimal)dr["TargetSalesCumulative"];
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
