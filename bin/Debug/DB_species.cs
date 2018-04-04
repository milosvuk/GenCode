using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_species
 
{
public string connString;
public string connectionString;
public DB_species()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(species _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(species _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO species (idRecSpeciesGroup,SpeciesName,NationalQty,PerYear,Active) VALUES (@idRecSpeciesGroup,@SpeciesName,@NationalQty,@PerYear,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecSpeciesGroup", _tmpObject.IDRECSPECIESGROUP));
command.Parameters.Add(new SqlParameter("@SpeciesName", _tmpObject.SPECIESNAME));
command.Parameters.Add(new SqlParameter("@NationalQty", _tmpObject.NATIONALQTY));
command.Parameters.Add(new SqlParameter("@PerYear", _tmpObject.PERYEAR));
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
 
public int Update(species _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(species _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE species SET idRecSpeciesGroup=@idrecspeciesgroup,SpeciesName=@speciesname,NationalQty=@nationalqty,PerYear=@peryear,Active=@active  WHERE idRecSpecies=@idrecspecies", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecspeciesgroup", _tmpObject.IDRECSPECIESGROUP));
command.Parameters.Add(new SqlParameter("@speciesname", _tmpObject.SPECIESNAME));
command.Parameters.Add(new SqlParameter("@nationalqty", _tmpObject.NATIONALQTY));
command.Parameters.Add(new SqlParameter("@peryear", _tmpObject.PERYEAR));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(species _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(species _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE species  WHERE idRecSpecies=@idrecspecies", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public species GetById(int _id)
{
species tmpObject = new species();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From species WHERE idRecSpecies=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
tmpObject.IDRECSPECIESGROUP = (System.Int32)dr["idRecSpeciesGroup"];
tmpObject.SPECIESNAME = (System.String)dr["SpeciesName"];
tmpObject.NATIONALQTY = (System.Int32)dr["NationalQty"];
tmpObject.PERYEAR = (System.Int32)dr["PerYear"];
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
