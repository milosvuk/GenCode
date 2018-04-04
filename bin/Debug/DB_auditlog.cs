using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_auditlog
 
{
public string connString;
public string connectionString;
public DB_auditlog()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(auditlog _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(auditlog _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO auditlog (DateTimeEvent,DateTimeEventFull,Desctiption,TableName,RecordDetails,UserId) VALUES (@DateTimeEvent,@DateTimeEventFull,@Desctiption,@TableName,@RecordDetails,@UserId) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@DateTimeEvent", _tmpObject.DATETIMEEVENT));
command.Parameters.Add(new SqlParameter("@DateTimeEventFull", _tmpObject.DATETIMEEVENTFULL));
command.Parameters.Add(new SqlParameter("@Desctiption", _tmpObject.DESCTIPTION));
command.Parameters.Add(new SqlParameter("@TableName", _tmpObject.TABLENAME));
command.Parameters.Add(new SqlParameter("@RecordDetails", _tmpObject.RECORDDETAILS));
command.Parameters.Add(new SqlParameter("@UserId", _tmpObject.USERID));
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
 
public int Update(auditlog _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(auditlog _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE auditlog SET DateTimeEvent=@datetimeevent,DateTimeEventFull=@datetimeeventfull,Desctiption=@desctiption,TableName=@tablename,RecordDetails=@recorddetails,UserId=@userid  WHERE idRecAuditLog=@idrecauditlog", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@datetimeevent", _tmpObject.DATETIMEEVENT));
command.Parameters.Add(new SqlParameter("@datetimeeventfull", _tmpObject.DATETIMEEVENTFULL));
command.Parameters.Add(new SqlParameter("@desctiption", _tmpObject.DESCTIPTION));
command.Parameters.Add(new SqlParameter("@tablename", _tmpObject.TABLENAME));
command.Parameters.Add(new SqlParameter("@recorddetails", _tmpObject.RECORDDETAILS));
command.Parameters.Add(new SqlParameter("@userid", _tmpObject.USERID));
command.Parameters.Add(new SqlParameter("@idrecauditlog", _tmpObject.IDRECAUDITLOG));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(auditlog _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(auditlog _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE auditlog  WHERE idRecAuditLog=@idrecauditlog", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecauditlog", _tmpObject.IDRECAUDITLOG));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public auditlog GetById(int _id)
{
auditlog tmpObject = new auditlog();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From auditlog WHERE idRecAuditLog=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECAUDITLOG = (System.Int32)dr["idRecAuditLog"];
tmpObject.DATETIMEEVENT = (System.DateTime)dr["DateTimeEvent"];
tmpObject.DATETIMEEVENTFULL = (System.String)dr["DateTimeEventFull"];
tmpObject.DESCTIPTION = (System.String)dr["Desctiption"];
tmpObject.TABLENAME = (System.String)dr["TableName"];
tmpObject.RECORDDETAILS = (System.String)dr["RecordDetails"];
tmpObject.USERID = (System.Int32)dr["UserId"];
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
