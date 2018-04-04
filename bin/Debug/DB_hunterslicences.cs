using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_hunterslicences
 
{
public string connString;
public string connectionString;
public DB_hunterslicences()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(hunterslicences _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(hunterslicences _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO hunterslicences (idRecHunter,idRecLicence,LicenceYear,Paid,Amount,Comments,Active) VALUES (@idRecHunter,@idRecLicence,@LicenceYear,@Paid,@Amount,@Comments,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecHunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@idRecLicence", _tmpObject.IDRECLICENCE));
command.Parameters.Add(new SqlParameter("@LicenceYear", _tmpObject.LICENCEYEAR));
command.Parameters.Add(new SqlParameter("@Paid", _tmpObject.PAID));
command.Parameters.Add(new SqlParameter("@Amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@Comments", _tmpObject.COMMENTS));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
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
 
public int Update(hunterslicences _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(hunterslicences _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE hunterslicences SET idRecHunter=@idrechunter,idRecLicence=@idreclicence,LicenceYear=@licenceyear,Paid=@paid,Amount=@amount,Comments=@comments,Active=@active  WHERE idRecHuntersLicenced=@idrechunterslicenced", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@idreclicence", _tmpObject.IDRECLICENCE));
command.Parameters.Add(new SqlParameter("@licenceyear", _tmpObject.LICENCEYEAR));
command.Parameters.Add(new SqlParameter("@paid", _tmpObject.PAID));
command.Parameters.Add(new SqlParameter("@amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@comments", _tmpObject.COMMENTS));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idrechunterslicenced", _tmpObject.IDRECHUNTERSLICENCED));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(hunterslicences _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(hunterslicences _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE hunterslicences  WHERE idRecHuntersLicenced=@idrechunterslicenced", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunterslicenced", _tmpObject.IDRECHUNTERSLICENCED));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public hunterslicences GetById(int _id)
{
hunterslicences tmpObject = new hunterslicences();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From hunterslicences WHERE idRecHuntersLicenced=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECHUNTERSLICENCED = (System.Int32)dr["idRecHuntersLicenced"];
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDRECLICENCE = (System.Int32)dr["idRecLicence"];
tmpObject.LICENCEYEAR = (System.Int32)dr["LicenceYear"];
tmpObject.PAID = (System.Int32)dr["Paid"];
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
tmpObject.COMMENTS = (System.String)dr["Comments"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
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
