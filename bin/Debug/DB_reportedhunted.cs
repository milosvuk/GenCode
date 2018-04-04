using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_reportedhunted
 
{
public string connString;
public string connectionString;
public DB_reportedhunted()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(reportedhunted _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(reportedhunted _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO reportedhunted (idRecHunter,LicencedMobileNumber,DateOfReport,idRecSpecies,SpeciesQty,TypeOfGame,idRecLocation,Active) VALUES (@idRecHunter,@LicencedMobileNumber,@DateOfReport,@idRecSpecies,@SpeciesQty,@TypeOfGame,@idRecLocation,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecHunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@LicencedMobileNumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@DateOfReport", _tmpObject.DATEOFREPORT));
command.Parameters.Add(new SqlParameter("@idRecSpecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@SpeciesQty", _tmpObject.SPECIESQTY));
command.Parameters.Add(new SqlParameter("@TypeOfGame", _tmpObject.TYPEOFGAME));
command.Parameters.Add(new SqlParameter("@idRecLocation", _tmpObject.IDRECLOCATION));
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
 
public int Update(reportedhunted _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(reportedhunted _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE reportedhunted SET idRecHunter=@idrechunter,LicencedMobileNumber=@licencedmobilenumber,DateOfReport=@dateofreport,idRecSpecies=@idrecspecies,SpeciesQty=@speciesqty,TypeOfGame=@typeofgame,idRecLocation=@idreclocation,Active=@active  WHERE idRecReportedHunted=@idrecreportedhunted", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@licencedmobilenumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@dateofreport", _tmpObject.DATEOFREPORT));
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@speciesqty", _tmpObject.SPECIESQTY));
command.Parameters.Add(new SqlParameter("@typeofgame", _tmpObject.TYPEOFGAME));
command.Parameters.Add(new SqlParameter("@idreclocation", _tmpObject.IDRECLOCATION));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idrecreportedhunted", _tmpObject.IDRECREPORTEDHUNTED));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(reportedhunted _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(reportedhunted _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE reportedhunted  WHERE idRecReportedHunted=@idrecreportedhunted", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecreportedhunted", _tmpObject.IDRECREPORTEDHUNTED));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public reportedhunted GetById(int _id)
{
reportedhunted tmpObject = new reportedhunted();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From reportedhunted WHERE idRecReportedHunted=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECREPORTEDHUNTED = (System.Int32)dr["idRecReportedHunted"];
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
tmpObject.DATEOFREPORT = (System.DateTime)dr["DateOfReport"];
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
tmpObject.SPECIESQTY = (System.Int32)dr["SpeciesQty"];
tmpObject.TYPEOFGAME = (System.Int32)dr["TypeOfGame"];
tmpObject.IDRECLOCATION = (System.Int32)dr["idRecLocation"];
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
