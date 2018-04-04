using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_SmallWSSR
 
{
public string connString;
public string connectionString;
public DB_SmallWSSR()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(SmallWSSR _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(SmallWSSR _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO SmallWSSR (weeknumber,year_,storenumber,storename,divisionnumberdepartrpro,divisionnamedepartrpro,departmentnoclassrpro,departmentnameclassrpro,salesvaluethisweekthisyear,salestargetforthisweekthisyear,var_perc,salesvaluelastsweekthisyear,lw_var_perc,salesvaluethisweeklastyear,ly_var_perc,spacethisyear,av_density,cumulativesalesvaluethisweekthisyear,cumulativetargetsalesvaluethisweekthisyear,cum_var_perc,cumulativesalesforthisweeklastyear,ly_cum_var_per,cum_density,sales_mix_per,plan_mix_per,ly_mix_per,weeks_cal,terminalstockunitsthisyearsaleitems,terminalstockvaluethisyearsaleitems,term_perc,fp_stockunitsthsiweekthisyear,fp_stockvaluethisyear,fp_perc,branchstockunitsthsiweekthisyear,branchstockvaluethisyear,stock_mix_perc) VALUES (@weeknumber,@year_,@storenumber,@storename,@divisionnumberdepartrpro,@divisionnamedepartrpro,@departmentnoclassrpro,@departmentnameclassrpro,@salesvaluethisweekthisyear,@salestargetforthisweekthisyear,@var_perc,@salesvaluelastsweekthisyear,@lw_var_perc,@salesvaluethisweeklastyear,@ly_var_perc,@spacethisyear,@av_density,@cumulativesalesvaluethisweekthisyear,@cumulativetargetsalesvaluethisweekthisyear,@cum_var_perc,@cumulativesalesforthisweeklastyear,@ly_cum_var_per,@cum_density,@sales_mix_per,@plan_mix_per,@ly_mix_per,@weeks_cal,@terminalstockunitsthisyearsaleitems,@terminalstockvaluethisyearsaleitems,@term_perc,@fp_stockunitsthsiweekthisyear,@fp_stockvaluethisyear,@fp_perc,@branchstockunitsthsiweekthisyear,@branchstockvaluethisyear,@stock_mix_perc) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@weeknumber", _tmpObject.WEEKNUMBER));
command.Parameters.Add(new SqlParameter("@year_", _tmpObject.YEAR_));
command.Parameters.Add(new SqlParameter("@storenumber", _tmpObject.STORENUMBER));
command.Parameters.Add(new SqlParameter("@storename", _tmpObject.STORENAME));
command.Parameters.Add(new SqlParameter("@divisionnumberdepartrpro", _tmpObject.DIVISIONNUMBERDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@divisionnamedepartrpro", _tmpObject.DIVISIONNAMEDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@departmentnoclassrpro", _tmpObject.DEPARTMENTNOCLASSRPRO));
command.Parameters.Add(new SqlParameter("@departmentnameclassrpro", _tmpObject.DEPARTMENTNAMECLASSRPRO));
command.Parameters.Add(new SqlParameter("@salesvaluethisweekthisyear", _tmpObject.SALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@salestargetforthisweekthisyear", _tmpObject.SALESTARGETFORTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@var_perc", _tmpObject.VAR_PERC));
command.Parameters.Add(new SqlParameter("@salesvaluelastsweekthisyear", _tmpObject.SALESVALUELASTSWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@lw_var_perc", _tmpObject.LW_VAR_PERC));
command.Parameters.Add(new SqlParameter("@salesvaluethisweeklastyear", _tmpObject.SALESVALUETHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@ly_var_perc", _tmpObject.LY_VAR_PERC));
command.Parameters.Add(new SqlParameter("@spacethisyear", _tmpObject.SPACETHISYEAR));
command.Parameters.Add(new SqlParameter("@av_density", _tmpObject.AV_DENSITY));
command.Parameters.Add(new SqlParameter("@cumulativesalesvaluethisweekthisyear", _tmpObject.CUMULATIVESALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cumulativetargetsalesvaluethisweekthisyear", _tmpObject.CUMULATIVETARGETSALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cum_var_perc", _tmpObject.CUM_VAR_PERC));
command.Parameters.Add(new SqlParameter("@cumulativesalesforthisweeklastyear", _tmpObject.CUMULATIVESALESFORTHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@ly_cum_var_per", _tmpObject.LY_CUM_VAR_PER));
command.Parameters.Add(new SqlParameter("@cum_density", _tmpObject.CUM_DENSITY));
command.Parameters.Add(new SqlParameter("@sales_mix_per", _tmpObject.SALES_MIX_PER));
command.Parameters.Add(new SqlParameter("@plan_mix_per", _tmpObject.PLAN_MIX_PER));
command.Parameters.Add(new SqlParameter("@ly_mix_per", _tmpObject.LY_MIX_PER));
command.Parameters.Add(new SqlParameter("@weeks_cal", _tmpObject.WEEKS_CAL));
command.Parameters.Add(new SqlParameter("@terminalstockunitsthisyearsaleitems", _tmpObject.TERMINALSTOCKUNITSTHISYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@terminalstockvaluethisyearsaleitems", _tmpObject.TERMINALSTOCKVALUETHISYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@term_perc", _tmpObject.TERM_PERC));
command.Parameters.Add(new SqlParameter("@fp_stockunitsthsiweekthisyear", _tmpObject.FP_STOCKUNITSTHSIWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@fp_stockvaluethisyear", _tmpObject.FP_STOCKVALUETHISYEAR));
command.Parameters.Add(new SqlParameter("@fp_perc", _tmpObject.FP_PERC));
command.Parameters.Add(new SqlParameter("@branchstockunitsthsiweekthisyear", _tmpObject.BRANCHSTOCKUNITSTHSIWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@branchstockvaluethisyear", _tmpObject.BRANCHSTOCKVALUETHISYEAR));
command.Parameters.Add(new SqlParameter("@stock_mix_perc", _tmpObject.STOCK_MIX_PERC));
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
 
public int Update(SmallWSSR _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(SmallWSSR _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE SmallWSSR SET weeknumber=@weeknumber,year_=@year_,storenumber=@storenumber,storename=@storename,divisionnumberdepartrpro=@divisionnumberdepartrpro,divisionnamedepartrpro=@divisionnamedepartrpro,departmentnoclassrpro=@departmentnoclassrpro,departmentnameclassrpro=@departmentnameclassrpro,salesvaluethisweekthisyear=@salesvaluethisweekthisyear,salestargetforthisweekthisyear=@salestargetforthisweekthisyear,var_perc=@var_perc,salesvaluelastsweekthisyear=@salesvaluelastsweekthisyear,lw_var_perc=@lw_var_perc,salesvaluethisweeklastyear=@salesvaluethisweeklastyear,ly_var_perc=@ly_var_perc,spacethisyear=@spacethisyear,av_density=@av_density,cumulativesalesvaluethisweekthisyear=@cumulativesalesvaluethisweekthisyear,cumulativetargetsalesvaluethisweekthisyear=@cumulativetargetsalesvaluethisweekthisyear,cum_var_perc=@cum_var_perc,cumulativesalesforthisweeklastyear=@cumulativesalesforthisweeklastyear,ly_cum_var_per=@ly_cum_var_per,cum_density=@cum_density,sales_mix_per=@sales_mix_per,plan_mix_per=@plan_mix_per,ly_mix_per=@ly_mix_per,weeks_cal=@weeks_cal,terminalstockunitsthisyearsaleitems=@terminalstockunitsthisyearsaleitems,terminalstockvaluethisyearsaleitems=@terminalstockvaluethisyearsaleitems,term_perc=@term_perc,fp_stockunitsthsiweekthisyear=@fp_stockunitsthsiweekthisyear,fp_stockvaluethisyear=@fp_stockvaluethisyear,fp_perc=@fp_perc,branchstockunitsthsiweekthisyear=@branchstockunitsthsiweekthisyear,branchstockvaluethisyear=@branchstockvaluethisyear,stock_mix_perc=@stock_mix_perc  WHERE idofrecord=@idofrecord", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@weeknumber", _tmpObject.WEEKNUMBER));
command.Parameters.Add(new SqlParameter("@year_", _tmpObject.YEAR_));
command.Parameters.Add(new SqlParameter("@storenumber", _tmpObject.STORENUMBER));
command.Parameters.Add(new SqlParameter("@storename", _tmpObject.STORENAME));
command.Parameters.Add(new SqlParameter("@divisionnumberdepartrpro", _tmpObject.DIVISIONNUMBERDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@divisionnamedepartrpro", _tmpObject.DIVISIONNAMEDEPARTRPRO));
command.Parameters.Add(new SqlParameter("@departmentnoclassrpro", _tmpObject.DEPARTMENTNOCLASSRPRO));
command.Parameters.Add(new SqlParameter("@departmentnameclassrpro", _tmpObject.DEPARTMENTNAMECLASSRPRO));
command.Parameters.Add(new SqlParameter("@salesvaluethisweekthisyear", _tmpObject.SALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@salestargetforthisweekthisyear", _tmpObject.SALESTARGETFORTHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@var_perc", _tmpObject.VAR_PERC));
command.Parameters.Add(new SqlParameter("@salesvaluelastsweekthisyear", _tmpObject.SALESVALUELASTSWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@lw_var_perc", _tmpObject.LW_VAR_PERC));
command.Parameters.Add(new SqlParameter("@salesvaluethisweeklastyear", _tmpObject.SALESVALUETHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@ly_var_perc", _tmpObject.LY_VAR_PERC));
command.Parameters.Add(new SqlParameter("@spacethisyear", _tmpObject.SPACETHISYEAR));
command.Parameters.Add(new SqlParameter("@av_density", _tmpObject.AV_DENSITY));
command.Parameters.Add(new SqlParameter("@cumulativesalesvaluethisweekthisyear", _tmpObject.CUMULATIVESALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cumulativetargetsalesvaluethisweekthisyear", _tmpObject.CUMULATIVETARGETSALESVALUETHISWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@cum_var_perc", _tmpObject.CUM_VAR_PERC));
command.Parameters.Add(new SqlParameter("@cumulativesalesforthisweeklastyear", _tmpObject.CUMULATIVESALESFORTHISWEEKLASTYEAR));
command.Parameters.Add(new SqlParameter("@ly_cum_var_per", _tmpObject.LY_CUM_VAR_PER));
command.Parameters.Add(new SqlParameter("@cum_density", _tmpObject.CUM_DENSITY));
command.Parameters.Add(new SqlParameter("@sales_mix_per", _tmpObject.SALES_MIX_PER));
command.Parameters.Add(new SqlParameter("@plan_mix_per", _tmpObject.PLAN_MIX_PER));
command.Parameters.Add(new SqlParameter("@ly_mix_per", _tmpObject.LY_MIX_PER));
command.Parameters.Add(new SqlParameter("@weeks_cal", _tmpObject.WEEKS_CAL));
command.Parameters.Add(new SqlParameter("@terminalstockunitsthisyearsaleitems", _tmpObject.TERMINALSTOCKUNITSTHISYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@terminalstockvaluethisyearsaleitems", _tmpObject.TERMINALSTOCKVALUETHISYEARSALEITEMS));
command.Parameters.Add(new SqlParameter("@term_perc", _tmpObject.TERM_PERC));
command.Parameters.Add(new SqlParameter("@fp_stockunitsthsiweekthisyear", _tmpObject.FP_STOCKUNITSTHSIWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@fp_stockvaluethisyear", _tmpObject.FP_STOCKVALUETHISYEAR));
command.Parameters.Add(new SqlParameter("@fp_perc", _tmpObject.FP_PERC));
command.Parameters.Add(new SqlParameter("@branchstockunitsthsiweekthisyear", _tmpObject.BRANCHSTOCKUNITSTHSIWEEKTHISYEAR));
command.Parameters.Add(new SqlParameter("@branchstockvaluethisyear", _tmpObject.BRANCHSTOCKVALUETHISYEAR));
command.Parameters.Add(new SqlParameter("@stock_mix_perc", _tmpObject.STOCK_MIX_PERC));
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
 
public int Delete(SmallWSSR _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(SmallWSSR _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE SmallWSSR  WHERE idofrecord=@idofrecord", conn);
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
public SmallWSSR GetById(int _id)
{
SmallWSSR tmpObject = new SmallWSSR();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From SmallWSSR WHERE idofrecord=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDOFRECORD = (System.Int32)dr["idofrecord"];
tmpObject.WEEKNUMBER = (System.String)dr["weeknumber"];
tmpObject.YEAR_ = (System.String)dr["year_"];
tmpObject.STORENUMBER = (System.String)dr["storenumber"];
tmpObject.STORENAME = (System.String)dr["storename"];
tmpObject.DIVISIONNUMBERDEPARTRPRO = (System.String)dr["divisionnumberdepartrpro"];
tmpObject.DIVISIONNAMEDEPARTRPRO = (System.String)dr["divisionnamedepartrpro"];
tmpObject.DEPARTMENTNOCLASSRPRO = (System.String)dr["departmentnoclassrpro"];
tmpObject.DEPARTMENTNAMECLASSRPRO = (System.String)dr["departmentnameclassrpro"];
tmpObject.SALESVALUETHISWEEKTHISYEAR = (System.String)dr["salesvaluethisweekthisyear"];
tmpObject.SALESTARGETFORTHISWEEKTHISYEAR = (System.String)dr["salestargetforthisweekthisyear"];
tmpObject.VAR_PERC = (System.String)dr["var_perc"];
tmpObject.SALESVALUELASTSWEEKTHISYEAR = (System.String)dr["salesvaluelastsweekthisyear"];
tmpObject.LW_VAR_PERC = (System.String)dr["lw_var_perc"];
tmpObject.SALESVALUETHISWEEKLASTYEAR = (System.String)dr["salesvaluethisweeklastyear"];
tmpObject.LY_VAR_PERC = (System.String)dr["ly_var_perc"];
tmpObject.SPACETHISYEAR = (System.String)dr["spacethisyear"];
tmpObject.AV_DENSITY = (System.String)dr["av_density"];
tmpObject.CUMULATIVESALESVALUETHISWEEKTHISYEAR = (System.String)dr["cumulativesalesvaluethisweekthisyear"];
tmpObject.CUMULATIVETARGETSALESVALUETHISWEEKTHISYEAR = (System.String)dr["cumulativetargetsalesvaluethisweekthisyear"];
tmpObject.CUM_VAR_PERC = (System.String)dr["cum_var_perc"];
tmpObject.CUMULATIVESALESFORTHISWEEKLASTYEAR = (System.String)dr["cumulativesalesforthisweeklastyear"];
tmpObject.LY_CUM_VAR_PER = (System.String)dr["ly_cum_var_per"];
tmpObject.CUM_DENSITY = (System.String)dr["cum_density"];
tmpObject.SALES_MIX_PER = (System.String)dr["sales_mix_per"];
tmpObject.PLAN_MIX_PER = (System.String)dr["plan_mix_per"];
tmpObject.LY_MIX_PER = (System.String)dr["ly_mix_per"];
tmpObject.WEEKS_CAL = (System.String)dr["weeks_cal"];
tmpObject.TERMINALSTOCKUNITSTHISYEARSALEITEMS = (System.String)dr["terminalstockunitsthisyearsaleitems"];
tmpObject.TERMINALSTOCKVALUETHISYEARSALEITEMS = (System.String)dr["terminalstockvaluethisyearsaleitems"];
tmpObject.TERM_PERC = (System.String)dr["term_perc"];
tmpObject.FP_STOCKUNITSTHSIWEEKTHISYEAR = (System.String)dr["fp_stockunitsthsiweekthisyear"];
tmpObject.FP_STOCKVALUETHISYEAR = (System.String)dr["fp_stockvaluethisyear"];
tmpObject.FP_PERC = (System.String)dr["fp_perc"];
tmpObject.BRANCHSTOCKUNITSTHSIWEEKTHISYEAR = (System.String)dr["branchstockunitsthsiweekthisyear"];
tmpObject.BRANCHSTOCKVALUETHISYEAR = (System.String)dr["branchstockvaluethisyear"];
tmpObject.STOCK_MIX_PERC = (System.String)dr["stock_mix_perc"];
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
