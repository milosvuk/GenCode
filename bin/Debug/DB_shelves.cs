using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_shelves
 
{
public string connString;
public string connectionString;
public DB_shelves()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(shelves _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(shelves _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO shelves (Shelves,Description,DateTimeCreated) VALUES (@Shelves,@Description,@DateTimeCreated) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@Shelves", _tmpObject.SHELVES));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@DateTimeCreated", _tmpObject.DATETIMECREATED));
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
 
public int Update(shelves _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(shelves _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE shelves SET Shelves=@shelves,Description=@description,DateTimeCreated=@datetimecreated  WHERE idRec=@idrec", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@shelves", _tmpObject.SHELVES));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@datetimecreated", _tmpObject.DATETIMECREATED));
command.Parameters.Add(new SqlParameter("@idrec", _tmpObject.IDREC));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(shelves _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(shelves _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE shelves  WHERE idRec=@idrec", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrec", _tmpObject.IDREC));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public shelves GetById(int _id)
{
shelves tmpObject = new shelves();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From shelves WHERE idRec=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDREC = (System.Int32)dr["idRec"];
tmpObject.SHELVES = (System.String)dr["Shelves"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
tmpObject.DATETIMECREATED = (System.DateTime)dr["DateTimeCreated"];
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
