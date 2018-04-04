using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_wssr
 
{
public string connString;
public string connectionString;
public DB_wssr()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(wssr _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(wssr _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO WSSR1 (weeknumber,year_,company,currrency,country,storenumber,storename,neworexistingdep,salestyoe,divisionnumberdepartrpro,divisionnamedepartrpro,departmentnoclassrpro,departmentnameclassrpro,salesvaluethisweekthisyear,salesvaluethisweeklastyear,cumulativesalesvaluethisweekthisyear,cumulativesalesvaluethisweeklastyear,unitsoldthisweekthisyear,unitssoldthisweeklastyear,salestargetforthisweekthisyear,cumulativesalesforthisweekthisyear,cashmarginthisweekthisyear,cashmarginthisweeklastyear,markdownspendthisyear,markdownspendlastiyear,branchstockvaluethisyear,branchstockvaluelastyear,branchstockunitsthsiweekthisyear,branchstockunitslastyear,terminalstockunitsthisyearsaleitems,terminalstockunitslastyearsaleitems,spacethisyear,spacelastyear) VALUES (@weeknumber,@year_,@company,@currrency,@country,@storenumber,@storename,@neworexistingdep,@salestyoe,@divisionnumberdepartrpro,@divisionnamedepartrpro,@departmentnoclassrpro,@departmentnameclassrpro,@salesvaluethisweekthisyear,@salesvaluethisweeklastyear,@cumulativesalesvaluethisweekthisyear,@cumulativesalesvaluethisweeklastyear,@unitsoldthisweekthisyear,@unitssoldthisweeklastyear,@salestargetforthisweekthisyear,@cumulativesalesforthisweekthisyear,@cashmarginthisweekthisyear,@cashmarginthisweeklastyear,@markdownspendthisyear,@markdownspendlastiyear,@branchstockvaluethisyear,@branchstockvaluelastyear,@branchstockunitsthsiweekthisyear,@branchstockunitslastyear,@terminalstockunitsthisyearsaleitems,@terminalstockunitslastyearsaleitems,@spacethisyear,@spacelastyear) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@weeknumber", _tmpObject.WEEKNUMBER));
command.Parameters.Add(new SqlParameter("@year_", _tmpObject.YEAR_));
command.Parameters.Add(new SqlParameter("@company", _tmpObject.COMPANY));
command.Parameters.Add(new SqlParameter("@currrency", _tmpObject.CURRRENCY));
command.Parameters.Add(new SqlParameter("@country", _tmpObject.COUNTRY));
command.Parameters.Add(new SqlParameter("@storenumber", _tmpObject.STORENUMBER));
command.Parameters.Add(new SqlParameter("@storename", _tmpObject.STORENAME));
command.Parameters.Add(new SqlParameter("@neworexistingdep", _tmpObject.NEWOREXISTINGDEP));
command.Parameters.Add(new SqlParameter("@salestyoe", _tmpObject.SALESTYOE));
command.Parameters.Add(new SqlParameter("@divisionnumberdepartrpro", _tmpObject.DIVISIONNUMBERDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@divisionnamedepartrpro", _tmpObject.DIVISIONNAMEDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@departmentnoclassrpro", _tmpObject.DEPARTMENTNOCLASSRPRO));
command.Parameters.Add(new SqlParameter("@departmentnameclassrpro", _tmpObject.DEPARTMENTNAMECLASSRPRO));
command.Parameters.Add(new SqlParameter("@salesvaluethisweekthisyear", _tmpObject.SALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@salesvaluethisweeklastyear", _tmpObject.SALESVALUETHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@cumulativesalesvaluethisweekthisyear", _tmpObject.CUMULATIVESALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cumulativesalesvaluethisweeklastyear", _tmpObject.CUMULATIVESALESVALUETHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@unitsoldthisweekthisyear", _tmpObject.UNITSOLDTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@unitssoldthisweeklastyear", _tmpObject.UNITSSOLDTHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@salestargetforthisweekthisyear", _tmpObject.SALESTARGETFORTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cumulativesalesforthisweekthisyear", _tmpObject.CUMULATIVESALESFORTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cashmarginthisweekthisyear", _tmpObject.CASHMARGINTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cashmarginthisweeklastyear", _tmpObject.CASHMARGINTHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@markdownspendthisyear", _tmpObject.MARKDOWNSPENDTHISYEAR));
command.Parameters.Add(new SqlParameter("@markdownspendlastiyear", _tmpObject.MARKDOWNSPENDLASTIYEAR));
command.Parameters.Add(new SqlParameter("@branchstockvaluethisyear", _tmpObject.BRANCHSTOCKVALUETHISYEAR));
command.Parameters.Add(new SqlParameter("@branchstockvaluelastyear", _tmpObject.BRANCHSTOCKVALUELASTYEAR));
command.Parameters.Add(new SqlParameter("@branchstockunitsthsiweekthisyear", _tmpObject.BRANCHSTOCKUNITSTHSIWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@branchstockunitslastyear", _tmpObject.BRANCHSTOCKUNITSLASTYEAR));
command.Parameters.Add(new SqlParameter("@terminalstockunitsthisyearsaleitems", _tmpObject.TERMINALSTOCKUNITSTHISYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@terminalstockunitslastyearsaleitems", _tmpObject.TERMINALSTOCKUNITSLASTYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@spacethisyear", _tmpObject.SPACETHISYEAR));
command.Parameters.Add(new SqlParameter("@spacelastyear", _tmpObject.SPACELASTYEAR));
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
 
public int Update(wssr _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(wssr _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE WSSR1 SET weeknumber=@weeknumber,year_=@year_,company=@company,currrency=@currrency,country=@country,storenumber=@storenumber,storename=@storename,neworexistingdep=@neworexistingdep,salestyoe=@salestyoe,divisionnumberdepartrpro=@divisionnumberdepartrpro,divisionnamedepartrpro=@divisionnamedepartrpro,departmentnoclassrpro=@departmentnoclassrpro,departmentnameclassrpro=@departmentnameclassrpro,salesvaluethisweekthisyear=@salesvaluethisweekthisyear,salesvaluethisweeklastyear=@salesvaluethisweeklastyear,cumulativesalesvaluethisweekthisyear=@cumulativesalesvaluethisweekthisyear,cumulativesalesvaluethisweeklastyear=@cumulativesalesvaluethisweeklastyear,unitsoldthisweekthisyear=@unitsoldthisweekthisyear,unitssoldthisweeklastyear=@unitssoldthisweeklastyear,salestargetforthisweekthisyear=@salestargetforthisweekthisyear,cumulativesalesforthisweekthisyear=@cumulativesalesforthisweekthisyear,cashmarginthisweekthisyear=@cashmarginthisweekthisyear,cashmarginthisweeklastyear=@cashmarginthisweeklastyear,markdownspendthisyear=@markdownspendthisyear,markdownspendlastiyear=@markdownspendlastiyear,branchstockvaluethisyear=@branchstockvaluethisyear,branchstockvaluelastyear=@branchstockvaluelastyear,branchstockunitsthsiweekthisyear=@branchstockunitsthsiweekthisyear,branchstockunitslastyear=@branchstockunitslastyear,terminalstockunitsthisyearsaleitems=@terminalstockunitsthisyearsaleitems,terminalstockunitslastyearsaleitems=@terminalstockunitslastyearsaleitems,spacethisyear=@spacethisyear,spacelastyear=@spacelastyear  WHERE idofrecord=@idofrecord", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@weeknumber", _tmpObject.WEEKNUMBER));
command.Parameters.Add(new SqlParameter("@year_", _tmpObject.YEAR_));
command.Parameters.Add(new SqlParameter("@company", _tmpObject.COMPANY));
command.Parameters.Add(new SqlParameter("@currrency", _tmpObject.CURRRENCY));
command.Parameters.Add(new SqlParameter("@country", _tmpObject.COUNTRY));
command.Parameters.Add(new SqlParameter("@storenumber", _tmpObject.STORENUMBER));
command.Parameters.Add(new SqlParameter("@storename", _tmpObject.STORENAME));
command.Parameters.Add(new SqlParameter("@neworexistingdep", _tmpObject.NEWOREXISTINGDEP));
command.Parameters.Add(new SqlParameter("@salestyoe", _tmpObject.SALESTYOE));
command.Parameters.Add(new SqlParameter("@divisionnumberdepartrpro", _tmpObject.DIVISIONNUMBERDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@divisionnamedepartrpro", _tmpObject.DIVISIONNAMEDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@departmentnoclassrpro", _tmpObject.DEPARTMENTNOCLASSRPRO));
command.Parameters.Add(new SqlParameter("@departmentnameclassrpro", _tmpObject.DEPARTMENTNAMECLASSRPRO));
command.Parameters.Add(new SqlParameter("@salesvaluethisweekthisyear", _tmpObject.SALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@salesvaluethisweeklastyear", _tmpObject.SALESVALUETHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@cumulativesalesvaluethisweekthisyear", _tmpObject.CUMULATIVESALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cumulativesalesvaluethisweeklastyear", _tmpObject.CUMULATIVESALESVALUETHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@unitsoldthisweekthisyear", _tmpObject.UNITSOLDTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@unitssoldthisweeklastyear", _tmpObject.UNITSSOLDTHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@salestargetforthisweekthisyear", _tmpObject.SALESTARGETFORTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cumulativesalesforthisweekthisyear", _tmpObject.CUMULATIVESALESFORTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cashmarginthisweekthisyear", _tmpObject.CASHMARGINTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cashmarginthisweeklastyear", _tmpObject.CASHMARGINTHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@markdownspendthisyear", _tmpObject.MARKDOWNSPENDTHISYEAR));
command.Parameters.Add(new SqlParameter("@markdownspendlastiyear", _tmpObject.MARKDOWNSPENDLASTIYEAR));
command.Parameters.Add(new SqlParameter("@branchstockvaluethisyear", _tmpObject.BRANCHSTOCKVALUETHISYEAR));
command.Parameters.Add(new SqlParameter("@branchstockvaluelastyear", _tmpObject.BRANCHSTOCKVALUELASTYEAR));
command.Parameters.Add(new SqlParameter("@branchstockunitsthsiweekthisyear", _tmpObject.BRANCHSTOCKUNITSTHSIWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@branchstockunitslastyear", _tmpObject.BRANCHSTOCKUNITSLASTYEAR));
command.Parameters.Add(new SqlParameter("@terminalstockunitsthisyearsaleitems", _tmpObject.TERMINALSTOCKUNITSTHISYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@terminalstockunitslastyearsaleitems", _tmpObject.TERMINALSTOCKUNITSLASTYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@spacethisyear", _tmpObject.SPACETHISYEAR));
command.Parameters.Add(new SqlParameter("@spacelastyear", _tmpObject.SPACELASTYEAR));
command.Parameters.Add(new SqlParameter("@idofrecord", _tmpObject.IDOFRECORD));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(wssr _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(wssr _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE WSSR1  WHERE idofrecord=@idofrecord", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idofrecord", _tmpObject.IDOFRECORD));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public wssr GetById(int _id)
{
wssr tmpObject = new wssr();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From WSSR1 WHERE idofrecord=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDOFRECORD = (System.Int32)dr["idofrecord"];
tmpObject.WEEKNUMBER = (System.String)dr["weeknumber"];
tmpObject.YEAR_ = (System.String)dr["year_"];
tmpObject.COMPANY = (System.String)dr["company"];
tmpObject.CURRRENCY = (System.String)dr["currrency"];
tmpObject.COUNTRY = (System.String)dr["country"];
tmpObject.STORENUMBER = (System.String)dr["storenumber"];
tmpObject.STORENAME = (System.String)dr["storename"];
tmpObject.NEWOREXISTINGDEP = (System.String)dr["neworexistingdep"];
tmpObject.SALESTYOE = (System.String)dr["salestyoe"];
tmpObject.DIVISIONNUMBERDEPARTRPRO = (System.String)dr["divisionnumberdepartrpro"];
tmpObject.DIVISIONNAMEDEPARTRPRO = (System.String)dr["divisionnamedepartrpro"];
tmpObject.DEPARTMENTNOCLASSRPRO = (System.String)dr["departmentnoclassrpro"];
tmpObject.DEPARTMENTNAMECLASSRPRO = (System.String)dr["departmentnameclassrpro"];
tmpObject.SALESVALUETHISWEEKTHISYEAR = (System.String)dr["salesvaluethisweekthisyear"];
tmpObject.SALESVALUETHISWEEKLASTYEAR = (System.String)dr["salesvaluethisweeklastyear"];
tmpObject.CUMULATIVESALESVALUETHISWEEKTHISYEAR = (System.String)dr["cumulativesalesvaluethisweekthisyear"];
tmpObject.CUMULATIVESALESVALUETHISWEEKLASTYEAR = (System.String)dr["cumulativesalesvaluethisweeklastyear"];
tmpObject.UNITSOLDTHISWEEKTHISYEAR = (System.String)dr["unitsoldthisweekthisyear"];
tmpObject.UNITSSOLDTHISWEEKLASTYEAR = (System.String)dr["unitssoldthisweeklastyear"];
tmpObject.SALESTARGETFORTHISWEEKTHISYEAR = (System.String)dr["salestargetforthisweekthisyear"];
tmpObject.CUMULATIVESALESFORTHISWEEKTHISYEAR = (System.String)dr["cumulativesalesforthisweekthisyear"];
tmpObject.CASHMARGINTHISWEEKTHISYEAR = (System.String)dr["cashmarginthisweekthisyear"];
tmpObject.CASHMARGINTHISWEEKLASTYEAR = (System.String)dr["cashmarginthisweeklastyear"];
tmpObject.MARKDOWNSPENDTHISYEAR = (System.String)dr["markdownspendthisyear"];
tmpObject.MARKDOWNSPENDLASTIYEAR = (System.String)dr["markdownspendlastiyear"];
tmpObject.BRANCHSTOCKVALUETHISYEAR = (System.String)dr["branchstockvaluethisyear"];
tmpObject.BRANCHSTOCKVALUELASTYEAR = (System.String)dr["branchstockvaluelastyear"];
tmpObject.BRANCHSTOCKUNITSTHSIWEEKTHISYEAR = (System.String)dr["branchstockunitsthsiweekthisyear"];
tmpObject.BRANCHSTOCKUNITSLASTYEAR = (System.String)dr["branchstockunitslastyear"];
tmpObject.TERMINALSTOCKUNITSTHISYEARSALEITEMS = (System.String)dr["terminalstockunitsthisyearsaleitems"];
tmpObject.TERMINALSTOCKUNITSLASTYEARSALEITEMS = (System.String)dr["terminalstockunitslastyearsaleitems"];
tmpObject.SPACETHISYEAR = (System.String)dr["spacethisyear"];
tmpObject.SPACELASTYEAR = (System.String)dr["spacelastyear"];
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
