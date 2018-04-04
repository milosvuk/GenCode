using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_licence
 
{
public string connString;
public string connectionString;
public DB_licence()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(licence _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(licence _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO licence (idRecTypeLicence,LicenceDescription,LicenceYear,Active) VALUES (@idRecTypeLicence,@LicenceDescription,@LicenceYear,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecTypeLicence", _tmpObject.IDRECTYPELICENCE));
command.Parameters.Add(new SqlParameter("@LicenceDescription", _tmpObject.LICENCEDESCRIPTION));
command.Parameters.Add(new SqlParameter("@LicenceYear", _tmpObject.LICENCEYEAR));
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
 
public int Update(licence _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(licence _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE licence SET idRecTypeLicence=@idrectypelicence,LicenceDescription=@licencedescription,LicenceYear=@licenceyear,Active=@active  WHERE idRecGenLicence=@idrecgenlicence", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrectypelicence", _tmpObject.IDRECTYPELICENCE));
command.Parameters.Add(new SqlParameter("@licencedescription", _tmpObject.LICENCEDESCRIPTION));
command.Parameters.Add(new SqlParameter("@licenceyear", _tmpObject.LICENCEYEAR));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idrecgenlicence", _tmpObject.IDRECGENLICENCE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(licence _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(licence _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE licence  WHERE idRecGenLicence=@idrecgenlicence", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecgenlicence", _tmpObject.IDRECGENLICENCE));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public licence GetById(int _id)
{
licence tmpObject = new licence();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From licence WHERE idRecGenLicence=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECGENLICENCE = (System.Int32)dr["idRecGenLicence"];
tmpObject.IDRECTYPELICENCE = (System.Int32)dr["idRecTypeLicence"];
tmpObject.LICENCEDESCRIPTION = (System.String)dr["LicenceDescription"];
tmpObject.LICENCEYEAR = (System.Int32)dr["LicenceYear"];
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
