using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_SpacePerStore
 
{
public string connString;
public string connectionString;
public DB_SpacePerStore()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(SpacePerStore _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(SpacePerStore _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO SpacePerStore (Store_no,Vendor_code,Department,Class_,Year,CalendarWeek,Space_qm) VALUES (@Store_no,@Vendor_code,@Department,@Class_,@Year,@CalendarWeek,@Space_qm) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@Store_no", _tmpObject.STORE_NO));
command.Parameters.Add(new SqlParameter("@Vendor_code", _tmpObject.VENDOR_CODE));
command.Parameters.Add(new SqlParameter("@Department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@Class_", _tmpObject.CLASS_));
command.Parameters.Add(new SqlParameter("@Year", _tmpObject.YEAR));
command.Parameters.Add(new SqlParameter("@CalendarWeek", _tmpObject.CALENDARWEEK));
command.Parameters.Add(new SqlParameter("@Space_qm", _tmpObject.SPACE_QM));
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
 
public int Update(SpacePerStore _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(SpacePerStore _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE SpacePerStore SET Store_no=@store_no,Vendor_code=@vendor_code,Department=@department,Class_=@class_,Year=@year,CalendarWeek=@calendarweek,Space_qm=@space_qm  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@store_no", _tmpObject.STORE_NO));
command.Parameters.Add(new SqlParameter("@vendor_code", _tmpObject.VENDOR_CODE));
command.Parameters.Add(new SqlParameter("@department", _tmpObject.DEPARTMENT));
command.Parameters.Add(new SqlParameter("@class_", _tmpObject.CLASS_));
command.Parameters.Add(new SqlParameter("@year", _tmpObject.YEAR));
command.Parameters.Add(new SqlParameter("@calendarweek", _tmpObject.CALENDARWEEK));
command.Parameters.Add(new SqlParameter("@space_qm", _tmpObject.SPACE_QM));
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
 
public int Delete(SpacePerStore _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(SpacePerStore _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE SpacePerStore  WHERE id=@id", conn);
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
public SpacePerStore GetById(int _id)
{
SpacePerStore tmpObject = new SpacePerStore();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From SpacePerStore WHERE id=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID = (System.Int32)dr["id"];
tmpObject.STORE_NO = (System.Int32)dr["Store_no"];
tmpObject.VENDOR_CODE = (System.String)dr["Vendor_code"];
tmpObject.DEPARTMENT = (System.String)dr["Department"];
tmpObject.CLASS_ = (System.String)dr["Class_"];
tmpObject.YEAR = (System.Int32)dr["Year"];
tmpObject.CALENDARWEEK = (System.Int32)dr["CalendarWeek"];
tmpObject.SPACE_QM = (System.Decimal)dr["Space_qm"];
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
