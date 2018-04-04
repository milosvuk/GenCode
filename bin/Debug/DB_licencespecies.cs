using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_licencespecies
 
{
public string connString;
public string connectionString;
public DB_licencespecies()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(licencespecies _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(licencespecies _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO licencespecies (idRecGenLicence,IdRecSpecies,LicSpeYear,Active) VALUES (@idRecGenLicence,@IdRecSpecies,@LicSpeYear,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecGenLicence", _tmpObject.IDRECGENLICENCE));
command.Parameters.Add(new SqlParameter("@IdRecSpecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@LicSpeYear", _tmpObject.LICSPEYEAR));
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
 
public int Update(licencespecies _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(licencespecies _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE licencespecies SET idRecGenLicence=@idrecgenlicence,IdRecSpecies=@idrecspecies,LicSpeYear=@licspeyear,Active=@active  WHERE idRecLicenceSpecies=@idreclicencespecies", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecgenlicence", _tmpObject.IDRECGENLICENCE));
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@licspeyear", _tmpObject.LICSPEYEAR));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idreclicencespecies", _tmpObject.IDRECLICENCESPECIES));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(licencespecies _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(licencespecies _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE licencespecies  WHERE idRecLicenceSpecies=@idreclicencespecies", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idreclicencespecies", _tmpObject.IDRECLICENCESPECIES));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public licencespecies GetById(int _id)
{
licencespecies tmpObject = new licencespecies();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From licencespecies WHERE idRecLicenceSpecies=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECLICENCESPECIES = (System.Int32)dr["idRecLicenceSpecies"];
tmpObject.IDRECGENLICENCE = (System.Int32)dr["idRecGenLicence"];
tmpObject.IDRECSPECIES = (System.Int32)dr["IdRecSpecies"];
tmpObject.LICSPEYEAR = (System.Int32)dr["LicSpeYear"];
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
