using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_balance_species
 
{
public string connString;
public string connectionString;
public DB_balance_species()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(balance_species _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(balance_species _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO balance_species (NationalQty,ReportedQty,BalanceQty) VALUES (@NationalQty,@ReportedQty,@BalanceQty) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@NationalQty", _tmpObject.NATIONALQTY));
command.Parameters.Add(new SqlParameter("@ReportedQty", _tmpObject.REPORTEDQTY));
command.Parameters.Add(new SqlParameter("@BalanceQty", _tmpObject.BALANCEQTY));
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
 
public int Update(balance_species _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(balance_species _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE balance_species SET NationalQty=@nationalqty,ReportedQty=@reportedqty,BalanceQty=@balanceqty  WHERE SpeciesName=@speciesname", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@nationalqty", _tmpObject.NATIONALQTY));
command.Parameters.Add(new SqlParameter("@reportedqty", _tmpObject.REPORTEDQTY));
command.Parameters.Add(new SqlParameter("@balanceqty", _tmpObject.BALANCEQTY));
command.Parameters.Add(new SqlParameter("@speciesname", _tmpObject.SPECIESNAME));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(balance_species _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(balance_species _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE balance_species  WHERE SpeciesName=@speciesname", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@speciesname", _tmpObject.SPECIESNAME));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public balance_species GetById(int _id)
{
balance_species tmpObject = new balance_species();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From balance_species WHERE SpeciesName=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.SPECIESNAME = (System.String)dr["SpeciesName"];
tmpObject.NATIONALQTY = (System.Int32)dr["NationalQty"];
tmpObject.REPORTEDQTY = (System.Int32)dr["ReportedQty"];
tmpObject.BALANCEQTY = (System.Int32)dr["BalanceQty"];
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
