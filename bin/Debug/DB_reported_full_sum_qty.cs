using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_reported_full_sum_qty
 
{
public string connString;
public string connectionString;
public DB_reported_full_sum_qty()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(reported_full_sum_qty _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(reported_full_sum_qty _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO reported_full_sum_qty (idRecSpecies,qty,IdCardNumber,Surname,Name,LicencedMobileNumber,SpeciesName) VALUES (@idRecSpecies,@qty,@IdCardNumber,@Surname,@Name,@LicencedMobileNumber,@SpeciesName) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecSpecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@qty", _tmpObject.QTY));
command.Parameters.Add(new SqlParameter("@IdCardNumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@Surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@Name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@LicencedMobileNumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@SpeciesName", _tmpObject.SPECIESNAME));
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
 
public int Update(reported_full_sum_qty _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(reported_full_sum_qty _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE reported_full_sum_qty SET idRecSpecies=@idrecspecies,qty=@qty,IdCardNumber=@idcardnumber,Surname=@surname,Name=@name,LicencedMobileNumber=@licencedmobilenumber,SpeciesName=@speciesname  WHERE idRecHunter=@idrechunter", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@qty", _tmpObject.QTY));
command.Parameters.Add(new SqlParameter("@idcardnumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@licencedmobilenumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@speciesname", _tmpObject.SPECIESNAME));
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(reported_full_sum_qty _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(reported_full_sum_qty _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE reported_full_sum_qty  WHERE idRecHunter=@idrechunter", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public reported_full_sum_qty GetById(int _id)
{
reported_full_sum_qty tmpObject = new reported_full_sum_qty();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From reported_full_sum_qty WHERE idRecHunter=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
tmpObject.QTY = (System.Int32)dr["qty"];
tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
tmpObject.SURNAME = (System.String)dr["Surname"];
tmpObject.NAME = (System.String)dr["Name"];
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
tmpObject.SPECIESNAME = (System.String)dr["SpeciesName"];
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
