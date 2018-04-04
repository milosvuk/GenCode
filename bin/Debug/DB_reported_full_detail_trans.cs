using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_reported_full_detail_trans
 
{
public string connString;
public string connectionString;
public DB_reported_full_detail_trans()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(reported_full_detail_trans _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(reported_full_detail_trans _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO reported_full_detail_trans (IdCardNumber,Surname,Name,LicencedMobileNumber,DateOfReport,idRecSpecies,SpeciesQty,Active,SpeciesName,NationalQty,PerYear,idRecSpeciesGroup) VALUES (@IdCardNumber,@Surname,@Name,@LicencedMobileNumber,@DateOfReport,@idRecSpecies,@SpeciesQty,@Active,@SpeciesName,@NationalQty,@PerYear,@idRecSpeciesGroup) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@IdCardNumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@Surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@Name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@LicencedMobileNumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@DateOfReport", _tmpObject.DATEOFREPORT));
command.Parameters.Add(new SqlParameter("@idRecSpecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@SpeciesQty", _tmpObject.SPECIESQTY));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@SpeciesName", _tmpObject.SPECIESNAME));
command.Parameters.Add(new SqlParameter("@NationalQty", _tmpObject.NATIONALQTY));
command.Parameters.Add(new SqlParameter("@PerYear", _tmpObject.PERYEAR));
command.Parameters.Add(new SqlParameter("@idRecSpeciesGroup", _tmpObject.IDRECSPECIESGROUP));
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
 
public int Update(reported_full_detail_trans _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(reported_full_detail_trans _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE reported_full_detail_trans SET IdCardNumber=@idcardnumber,Surname=@surname,Name=@name,LicencedMobileNumber=@licencedmobilenumber,DateOfReport=@dateofreport,idRecSpecies=@idrecspecies,SpeciesQty=@speciesqty,Active=@active,SpeciesName=@speciesname,NationalQty=@nationalqty,PerYear=@peryear,idRecSpeciesGroup=@idrecspeciesgroup  WHERE idRecHunter=@idrechunter", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idcardnumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@licencedmobilenumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@dateofreport", _tmpObject.DATEOFREPORT));
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@speciesqty", _tmpObject.SPECIESQTY));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@speciesname", _tmpObject.SPECIESNAME));
command.Parameters.Add(new SqlParameter("@nationalqty", _tmpObject.NATIONALQTY));
command.Parameters.Add(new SqlParameter("@peryear", _tmpObject.PERYEAR));
command.Parameters.Add(new SqlParameter("@idrecspeciesgroup", _tmpObject.IDRECSPECIESGROUP));
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
 
public int Delete(reported_full_detail_trans _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(reported_full_detail_trans _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE reported_full_detail_trans  WHERE idRecHunter=@idrechunter", conn);
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
public reported_full_detail_trans GetById(int _id)
{
reported_full_detail_trans tmpObject = new reported_full_detail_trans();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From reported_full_detail_trans WHERE idRecHunter=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
tmpObject.SURNAME = (System.String)dr["Surname"];
tmpObject.NAME = (System.String)dr["Name"];
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
tmpObject.DATEOFREPORT = (System.DateTime)dr["DateOfReport"];
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
tmpObject.SPECIESQTY = (System.Int32)dr["SpeciesQty"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
tmpObject.SPECIESNAME = (System.String)dr["SpeciesName"];
tmpObject.NATIONALQTY = (System.Int32)dr["NationalQty"];
tmpObject.PERYEAR = (System.Int32)dr["PerYear"];
tmpObject.IDRECSPECIESGROUP = (System.Int32)dr["idRecSpeciesGroup"];
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
