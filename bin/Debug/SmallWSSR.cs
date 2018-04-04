using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class SmallWSSR
 
{
public string connString;
public string connectionString;
public SmallWSSR()
{
  
 
 
}
 
public SmallWSSR (System.Int32 _idofrecord,System.String _weeknumber,System.String _year_,System.String _storenumber,System.String _storename,System.String _divisionnumberdepartrpro,System.String _divisionnamedepartrpro,System.String _departmentnoclassrpro,System.String _departmentnameclassrpro,System.String _salesvaluethisweekthisyear,System.String _salestargetforthisweekthisyear,System.String _var_perc,System.String _salesvaluelastsweekthisyear,System.String _lw_var_perc,System.String _salesvaluethisweeklastyear,System.String _ly_var_perc,System.String _spacethisyear,System.String _av_density,System.String _cumulativesalesvaluethisweekthisyear,System.String _cumulativetargetsalesvaluethisweekthisyear,System.String _cum_var_perc,System.String _cumulativesalesforthisweeklastyear,System.String _ly_cum_var_per,System.String _cum_density,System.String _sales_mix_per,System.String _plan_mix_per,System.String _ly_mix_per,System.String _weeks_cal,System.String _terminalstockunitsthisyearsaleitems,System.String _terminalstockvaluethisyearsaleitems,System.String _term_perc,System.String _fp_stockunitsthsiweekthisyear,System.String _fp_stockvaluethisyear,System.String _fp_perc,System.String _branchstockunitsthsiweekthisyear,System.String _branchstockvaluethisyear,System.String _stock_mix_perc )
{
idofrecord=_idofrecord;
weeknumber=_weeknumber;
year_=_year_;
storenumber=_storenumber;
storename=_storename;
divisionnumberdepartrpro=_divisionnumberdepartrpro;
divisionnamedepartrpro=_divisionnamedepartrpro;
departmentnoclassrpro=_departmentnoclassrpro;
departmentnameclassrpro=_departmentnameclassrpro;
salesvaluethisweekthisyear=_salesvaluethisweekthisyear;
salestargetforthisweekthisyear=_salestargetforthisweekthisyear;
var_perc=_var_perc;
salesvaluelastsweekthisyear=_salesvaluelastsweekthisyear;
lw_var_perc=_lw_var_perc;
salesvaluethisweeklastyear=_salesvaluethisweeklastyear;
ly_var_perc=_ly_var_perc;
spacethisyear=_spacethisyear;
av_density=_av_density;
cumulativesalesvaluethisweekthisyear=_cumulativesalesvaluethisweekthisyear;
cumulativetargetsalesvaluethisweekthisyear=_cumulativetargetsalesvaluethisweekthisyear;
cum_var_perc=_cum_var_perc;
cumulativesalesforthisweeklastyear=_cumulativesalesforthisweeklastyear;
ly_cum_var_per=_ly_cum_var_per;
cum_density=_cum_density;
sales_mix_per=_sales_mix_per;
plan_mix_per=_plan_mix_per;
ly_mix_per=_ly_mix_per;
weeks_cal=_weeks_cal;
terminalstockunitsthisyearsaleitems=_terminalstockunitsthisyearsaleitems;
terminalstockvaluethisyearsaleitems=_terminalstockvaluethisyearsaleitems;
term_perc=_term_perc;
fp_stockunitsthsiweekthisyear=_fp_stockunitsthsiweekthisyear;
fp_stockvaluethisyear=_fp_stockvaluethisyear;
fp_perc=_fp_perc;
branchstockunitsthsiweekthisyear=_branchstockunitsthsiweekthisyear;
branchstockvaluethisyear=_branchstockvaluethisyear;
stock_mix_perc=_stock_mix_perc;
}
 
 
private System.Int32 idofrecord;
 
public System.Int32 IDOFRECORD
{
get
{
return idofrecord;
}
set
{
idofrecord=value;
}
}
 
private System.String weeknumber;
 
public System.String WEEKNUMBER
{
get
{
return weeknumber;
}
set
{
weeknumber=value;
}
}
 
private System.String year_;
 
public System.String YEAR_
{
get
{
return year_;
}
set
{
year_=value;
}
}
 
private System.String storenumber;
 
public System.String STORENUMBER
{
get
{
return storenumber;
}
set
{
storenumber=value;
}
}
 
private System.String storename;
 
public System.String STORENAME
{
get
{
return storename;
}
set
{
storename=value;
}
}
 
private System.String divisionnumberdepartrpro;
 
public System.String DIVISIONNUMBERDEPARTRPRO
{
get
{
return divisionnumberdepartrpro;
}
set
{
divisionnumberdepartrpro=value;
}
}
 
private System.String divisionnamedepartrpro;
 
public System.String DIVISIONNAMEDEPARTRPRO
{
get
{
return divisionnamedepartrpro;
}
set
{
divisionnamedepartrpro=value;
}
}
 
private System.String departmentnoclassrpro;
 
public System.String DEPARTMENTNOCLASSRPRO
{
get
{
return departmentnoclassrpro;
}
set
{
departmentnoclassrpro=value;
}
}
 
private System.String departmentnameclassrpro;
 
public System.String DEPARTMENTNAMECLASSRPRO
{
get
{
return departmentnameclassrpro;
}
set
{
departmentnameclassrpro=value;
}
}
 
private System.String salesvaluethisweekthisyear;
 
public System.String SALESVALUETHISWEEKTHISYEAR
{
get
{
return salesvaluethisweekthisyear;
}
set
{
salesvaluethisweekthisyear=value;
}
}
 
private System.String salestargetforthisweekthisyear;
 
public System.String SALESTARGETFORTHISWEEKTHISYEAR
{
get
{
return salestargetforthisweekthisyear;
}
set
{
salestargetforthisweekthisyear=value;
}
}
 
private System.String var_perc;
 
public System.String VAR_PERC
{
get
{
return var_perc;
}
set
{
var_perc=value;
}
}
 
private System.String salesvaluelastsweekthisyear;
 
public System.String SALESVALUELASTSWEEKTHISYEAR
{
get
{
return salesvaluelastsweekthisyear;
}
set
{
salesvaluelastsweekthisyear=value;
}
}
 
private System.String lw_var_perc;
 
public System.String LW_VAR_PERC
{
get
{
return lw_var_perc;
}
set
{
lw_var_perc=value;
}
}
 
private System.String salesvaluethisweeklastyear;
 
public System.String SALESVALUETHISWEEKLASTYEAR
{
get
{
return salesvaluethisweeklastyear;
}
set
{
salesvaluethisweeklastyear=value;
}
}
 
private System.String ly_var_perc;
 
public System.String LY_VAR_PERC
{
get
{
return ly_var_perc;
}
set
{
ly_var_perc=value;
}
}
 
private System.String spacethisyear;
 
public System.String SPACETHISYEAR
{
get
{
return spacethisyear;
}
set
{
spacethisyear=value;
}
}
 
private System.String av_density;
 
public System.String AV_DENSITY
{
get
{
return av_density;
}
set
{
av_density=value;
}
}
 
private System.String cumulativesalesvaluethisweekthisyear;
 
public System.String CUMULATIVESALESVALUETHISWEEKTHISYEAR
{
get
{
return cumulativesalesvaluethisweekthisyear;
}
set
{
cumulativesalesvaluethisweekthisyear=value;
}
}
 
private System.String cumulativetargetsalesvaluethisweekthisyear;
 
public System.String CUMULATIVETARGETSALESVALUETHISWEEKTHISYEAR
{
get
{
return cumulativetargetsalesvaluethisweekthisyear;
}
set
{
cumulativetargetsalesvaluethisweekthisyear=value;
}
}
 
private System.String cum_var_perc;
 
public System.String CUM_VAR_PERC
{
get
{
return cum_var_perc;
}
set
{
cum_var_perc=value;
}
}
 
private System.String cumulativesalesforthisweeklastyear;
 
public System.String CUMULATIVESALESFORTHISWEEKLASTYEAR
{
get
{
return cumulativesalesforthisweeklastyear;
}
set
{
cumulativesalesforthisweeklastyear=value;
}
}
 
private System.String ly_cum_var_per;
 
public System.String LY_CUM_VAR_PER
{
get
{
return ly_cum_var_per;
}
set
{
ly_cum_var_per=value;
}
}
 
private System.String cum_density;
 
public System.String CUM_DENSITY
{
get
{
return cum_density;
}
set
{
cum_density=value;
}
}
 
private System.String sales_mix_per;
 
public System.String SALES_MIX_PER
{
get
{
return sales_mix_per;
}
set
{
sales_mix_per=value;
}
}
 
private System.String plan_mix_per;
 
public System.String PLAN_MIX_PER
{
get
{
return plan_mix_per;
}
set
{
plan_mix_per=value;
}
}
 
private System.String ly_mix_per;
 
public System.String LY_MIX_PER
{
get
{
return ly_mix_per;
}
set
{
ly_mix_per=value;
}
}
 
private System.String weeks_cal;
 
public System.String WEEKS_CAL
{
get
{
return weeks_cal;
}
set
{
weeks_cal=value;
}
}
 
private System.String terminalstockunitsthisyearsaleitems;
 
public System.String TERMINALSTOCKUNITSTHISYEARSALEITEMS
{
get
{
return terminalstockunitsthisyearsaleitems;
}
set
{
terminalstockunitsthisyearsaleitems=value;
}
}
 
private System.String terminalstockvaluethisyearsaleitems;
 
public System.String TERMINALSTOCKVALUETHISYEARSALEITEMS
{
get
{
return terminalstockvaluethisyearsaleitems;
}
set
{
terminalstockvaluethisyearsaleitems=value;
}
}
 
private System.String term_perc;
 
public System.String TERM_PERC
{
get
{
return term_perc;
}
set
{
term_perc=value;
}
}
 
private System.String fp_stockunitsthsiweekthisyear;
 
public System.String FP_STOCKUNITSTHSIWEEKTHISYEAR
{
get
{
return fp_stockunitsthsiweekthisyear;
}
set
{
fp_stockunitsthsiweekthisyear=value;
}
}
 
private System.String fp_stockvaluethisyear;
 
public System.String FP_STOCKVALUETHISYEAR
{
get
{
return fp_stockvaluethisyear;
}
set
{
fp_stockvaluethisyear=value;
}
}
 
private System.String fp_perc;
 
public System.String FP_PERC
{
get
{
return fp_perc;
}
set
{
fp_perc=value;
}
}
 
private System.String branchstockunitsthsiweekthisyear;
 
public System.String BRANCHSTOCKUNITSTHSIWEEKTHISYEAR
{
get
{
return branchstockunitsthsiweekthisyear;
}
set
{
branchstockunitsthsiweekthisyear=value;
}
}
 
private System.String branchstockvaluethisyear;
 
public System.String BRANCHSTOCKVALUETHISYEAR
{
get
{
return branchstockvaluethisyear;
}
set
{
branchstockvaluethisyear=value;
}
}
 
private System.String stock_mix_perc;
 
public System.String STOCK_MIX_PERC
{
get
{
return stock_mix_perc;
}
set
{
stock_mix_perc=value;
}
}
 
 
public void New()
{
idofrecord = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
////==========================================================================
 
public int InsertCommand()
{
// Use this InsertCommand with PrimaryKey Field which is not AutoIncement;
int numberinsert=0;
// INSERT INTO SmallWSSR(idofrecord,weeknumber,year_,storenumber,storename,divisionnumberdepartrpro,divisionnamedepartrpro,departmentnoclassrpro,departmentnameclassrpro,salesvaluethisweekthisyear,salestargetforthisweekthisyear,var_perc,salesvaluelastsweekthisyear,lw_var_perc,salesvaluethisweeklastyear,ly_var_perc,spacethisyear,av_density,cumulativesalesvaluethisweekthisyear,cumulativetargetsalesvaluethisweekthisyear,cum_var_perc,cumulativesalesforthisweeklastyear,ly_cum_var_per,cum_density,sales_mix_per,plan_mix_per,ly_mix_per,weeks_cal,terminalstockunitsthisyearsaleitems,terminalstockvaluethisyearsaleitems,term_perc,fp_stockunitsthsiweekthisyear,fp_stockvaluethisyear,fp_perc,branchstockunitsthsiweekthisyear,branchstockvaluethisyear,stock_mix_perc ) VALUES(idofrecord,weeknumber,year_,storenumber,storename,divisionnumberdepartrpro,divisionnamedepartrpro,departmentnoclassrpro,departmentnameclassrpro,salesvaluethisweekthisyear,salestargetforthisweekthisyear,var_perc,salesvaluelastsweekthisyear,lw_var_perc,salesvaluethisweeklastyear,ly_var_perc,spacethisyear,av_density,cumulativesalesvaluethisweekthisyear,cumulativetargetsalesvaluethisweekthisyear,cum_var_perc,cumulativesalesforthisweeklastyear,ly_cum_var_per,cum_density,sales_mix_per,plan_mix_per,ly_mix_per,weeks_cal,terminalstockunitsthisyearsaleitems,terminalstockvaluethisyearsaleitems,term_perc,fp_stockunitsthsiweekthisyear,fp_stockvaluethisyear,fp_perc,branchstockunitsthsiweekthisyear,branchstockvaluethisyear,stock_mix_perc );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO SmallWSSR(weeknumber,year_,storenumber,storename,divisionnumberdepartrpro,divisionnamedepartrpro,departmentnoclassrpro,departmentnameclassrpro,salesvaluethisweekthisyear,salestargetforthisweekthisyear,var_perc,salesvaluelastsweekthisyear,lw_var_perc,salesvaluethisweeklastyear,ly_var_perc,spacethisyear,av_density,cumulativesalesvaluethisweekthisyear,cumulativetargetsalesvaluethisweekthisyear,cum_var_perc,cumulativesalesforthisweeklastyear,ly_cum_var_per,cum_density,sales_mix_per,plan_mix_per,ly_mix_per,weeks_cal,terminalstockunitsthisyearsaleitems,terminalstockvaluethisyearsaleitems,term_perc,fp_stockunitsthsiweekthisyear,fp_stockvaluethisyear,fp_perc,branchstockunitsthsiweekthisyear,branchstockvaluethisyear,stock_mix_perc ) VALUES("+(char)39+weeknumber.ToString()+(char)39+(char)44+(char)39+year_.ToString()+(char)39+(char)44+(char)39+storenumber.ToString()+(char)39+(char)44+(char)39+storename.ToString()+(char)39+(char)44+(char)39+divisionnumberdepartrpro.ToString()+(char)39+(char)44+(char)39+divisionnamedepartrpro.ToString()+(char)39+(char)44+(char)39+departmentnoclassrpro.ToString()+(char)39+(char)44+(char)39+departmentnameclassrpro.ToString()+(char)39+(char)44+(char)39+salesvaluethisweekthisyear.ToString()+(char)39+(char)44+(char)39+salestargetforthisweekthisyear.ToString()+(char)39+(char)44+(char)39+var_perc.ToString()+(char)39+(char)44+(char)39+salesvaluelastsweekthisyear.ToString()+(char)39+(char)44+(char)39+lw_var_perc.ToString()+(char)39+(char)44+(char)39+salesvaluethisweeklastyear.ToString()+(char)39+(char)44+(char)39+ly_var_perc.ToString()+(char)39+(char)44+(char)39+spacethisyear.ToString()+(char)39+(char)44+(char)39+av_density.ToString()+(char)39+(char)44+(char)39+cumulativesalesvaluethisweekthisyear.ToString()+(char)39+(char)44+(char)39+cumulativetargetsalesvaluethisweekthisyear.ToString()+(char)39+(char)44+(char)39+cum_var_perc.ToString()+(char)39+(char)44+(char)39+cumulativesalesforthisweeklastyear.ToString()+(char)39+(char)44+(char)39+ly_cum_var_per.ToString()+(char)39+(char)44+(char)39+cum_density.ToString()+(char)39+(char)44+(char)39+sales_mix_per.ToString()+(char)39+(char)44+(char)39+plan_mix_per.ToString()+(char)39+(char)44+(char)39+ly_mix_per.ToString()+(char)39+(char)44+(char)39+weeks_cal.ToString()+(char)39+(char)44+(char)39+terminalstockunitsthisyearsaleitems.ToString()+(char)39+(char)44+(char)39+terminalstockvaluethisyearsaleitems.ToString()+(char)39+(char)44+(char)39+term_perc.ToString()+(char)39+(char)44+(char)39+fp_stockunitsthsiweekthisyear.ToString()+(char)39+(char)44+(char)39+fp_stockvaluethisyear.ToString()+(char)39+(char)44+(char)39+fp_perc.ToString()+(char)39+(char)44+(char)39+branchstockunitsthsiweekthisyear.ToString()+(char)39+(char)44+(char)39+branchstockvaluethisyear.ToString()+(char)39+(char)44+(char)39+stock_mix_perc.ToString()+(char)39+(char)41;
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
ptl.DbaseSQLServer sqinsert = new ptl.DbaseSQLServer();
sqinsert.DbaseConnection = Con;
sqinsert.SqlText = minsert;
numberinsert = sqinsert.RunUpdateSQL();
sqinsert = null;
return numberinsert;
}
////==========================================================================
//START SAVE METHOD OF dm_arbiter ==============
////==========================================================================
public bool Save(SmallWSSR _SmallWSSR)
{
bool tmp = false;
int res = -1;
_SmallWSSR.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_SmallWSSR db_SmallWSSR = new DB_SmallWSSR();
if (_SmallWSSR.IDSMALLWSSR == 0)
{
res = db_SmallWSSR.Add(_SmallWSSR, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_SmallWSSR.Update(_SmallWSSR, conn, tran);
tran.Commit();
tmp = true;
}
}
catch
{
tran.Rollback();
tmp = false;
}
finally
{
conn.Close();
}
return tmp;
}
////==========================================================================
//END OF SAVE DM_ ==============
////==========================================================================
 
public int UpdateEditComand(string Con)
{
int numberedit=0;
string mupdate = "UPDATE SmallWSSR SET "+"weeknumber="+(char)39+weeknumber.ToString()+(char)39+(char)44+"year_="+(char)39+year_.ToString()+(char)39+(char)44+"storenumber="+(char)39+storenumber.ToString()+(char)39+(char)44+"storename="+(char)39+storename.ToString()+(char)39+(char)44+"divisionnumberdepartrpro="+(char)39+divisionnumberdepartrpro.ToString()+(char)39+(char)44+"divisionnamedepartrpro="+(char)39+divisionnamedepartrpro.ToString()+(char)39+(char)44+"departmentnoclassrpro="+(char)39+departmentnoclassrpro.ToString()+(char)39+(char)44+"departmentnameclassrpro="+(char)39+departmentnameclassrpro.ToString()+(char)39+(char)44+"salesvaluethisweekthisyear="+(char)39+salesvaluethisweekthisyear.ToString()+(char)39+(char)44+"salestargetforthisweekthisyear="+(char)39+salestargetforthisweekthisyear.ToString()+(char)39+(char)44+"var_perc="+(char)39+var_perc.ToString()+(char)39+(char)44+"salesvaluelastsweekthisyear="+(char)39+salesvaluelastsweekthisyear.ToString()+(char)39+(char)44+"lw_var_perc="+(char)39+lw_var_perc.ToString()+(char)39+(char)44+"salesvaluethisweeklastyear="+(char)39+salesvaluethisweeklastyear.ToString()+(char)39+(char)44+"ly_var_perc="+(char)39+ly_var_perc.ToString()+(char)39+(char)44+"spacethisyear="+(char)39+spacethisyear.ToString()+(char)39+(char)44+"av_density="+(char)39+av_density.ToString()+(char)39+(char)44+"cumulativesalesvaluethisweekthisyear="+(char)39+cumulativesalesvaluethisweekthisyear.ToString()+(char)39+(char)44+"cumulativetargetsalesvaluethisweekthisyear="+(char)39+cumulativetargetsalesvaluethisweekthisyear.ToString()+(char)39+(char)44+"cum_var_perc="+(char)39+cum_var_perc.ToString()+(char)39+(char)44+"cumulativesalesforthisweeklastyear="+(char)39+cumulativesalesforthisweeklastyear.ToString()+(char)39+(char)44+"ly_cum_var_per="+(char)39+ly_cum_var_per.ToString()+(char)39+(char)44+"cum_density="+(char)39+cum_density.ToString()+(char)39+(char)44+"sales_mix_per="+(char)39+sales_mix_per.ToString()+(char)39+(char)44+"plan_mix_per="+(char)39+plan_mix_per.ToString()+(char)39+(char)44+"ly_mix_per="+(char)39+ly_mix_per.ToString()+(char)39+(char)44+"weeks_cal="+(char)39+weeks_cal.ToString()+(char)39+(char)44+"terminalstockunitsthisyearsaleitems="+(char)39+terminalstockunitsthisyearsaleitems.ToString()+(char)39+(char)44+"terminalstockvaluethisyearsaleitems="+(char)39+terminalstockvaluethisyearsaleitems.ToString()+(char)39+(char)44+"term_perc="+(char)39+term_perc.ToString()+(char)39+(char)44+"fp_stockunitsthsiweekthisyear="+(char)39+fp_stockunitsthsiweekthisyear.ToString()+(char)39+(char)44+"fp_stockvaluethisyear="+(char)39+fp_stockvaluethisyear.ToString()+(char)39+(char)44+"fp_perc="+(char)39+fp_perc.ToString()+(char)39+(char)44+"branchstockunitsthsiweekthisyear="+(char)39+branchstockunitsthsiweekthisyear.ToString()+(char)39+(char)44+"branchstockvaluethisyear="+(char)39+branchstockvaluethisyear.ToString()+(char)39+(char)44+"stock_mix_perc="+(char)39+stock_mix_perc.ToString()+(char)39+" WHERE idofrecord="+idofrecord.ToString();
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = mupdate;
numberedit = sq.RunUpdateSQL();
sq = null;
return numberedit;
}
 
 
public int DeleteComand(string Con)
{
int numberdelete=0;
string del = "DELETE FROM SmallWSSR WHERE idofrecord="+idofrecord.ToString();
 // idofrecord=OldData[i].ToString() AND
 // weeknumber=OldData[i].ToString() AND
 // year_=OldData[i].ToString() AND
 // storenumber=OldData[i].ToString() AND
 // storename=OldData[i].ToString() AND
 // divisionnumberdepartrpro=OldData[i].ToString() AND
 // divisionnamedepartrpro=OldData[i].ToString() AND
 // departmentnoclassrpro=OldData[i].ToString() AND
 // departmentnameclassrpro=OldData[i].ToString() AND
 // salesvaluethisweekthisyear=OldData[i].ToString() AND
 // salestargetforthisweekthisyear=OldData[i].ToString() AND
 // var_perc=OldData[i].ToString() AND
 // salesvaluelastsweekthisyear=OldData[i].ToString() AND
 // lw_var_perc=OldData[i].ToString() AND
 // salesvaluethisweeklastyear=OldData[i].ToString() AND
 // ly_var_perc=OldData[i].ToString() AND
 // spacethisyear=OldData[i].ToString() AND
 // av_density=OldData[i].ToString() AND
 // cumulativesalesvaluethisweekthisyear=OldData[i].ToString() AND
 // cumulativetargetsalesvaluethisweekthisyear=OldData[i].ToString() AND
 // cum_var_perc=OldData[i].ToString() AND
 // cumulativesalesforthisweeklastyear=OldData[i].ToString() AND
 // ly_cum_var_per=OldData[i].ToString() AND
 // cum_density=OldData[i].ToString() AND
 // sales_mix_per=OldData[i].ToString() AND
 // plan_mix_per=OldData[i].ToString() AND
 // ly_mix_per=OldData[i].ToString() AND
 // weeks_cal=OldData[i].ToString() AND
 // terminalstockunitsthisyearsaleitems=OldData[i].ToString() AND
 // terminalstockvaluethisyearsaleitems=OldData[i].ToString() AND
 // term_perc=OldData[i].ToString() AND
 // fp_stockunitsthsiweekthisyear=OldData[i].ToString() AND
 // fp_stockvaluethisyear=OldData[i].ToString() AND
 // fp_perc=OldData[i].ToString() AND
 // branchstockunitsthsiweekthisyear=OldData[i].ToString() AND
 // branchstockvaluethisyear=OldData[i].ToString() AND
 // stock_mix_perc=OldData[i].ToString() AND
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = del;
numberdelete = sq.RunUpdateSQL();
sq = null;
return numberdelete;
}
 
 
public ArrayList SearchResultAsArrayList(string SearchExp, string Con)
{
ArrayList alsearch = new ArrayList();
string alistsearch = "SELECT * FROM SmallWSSR " +SearchExp;
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = alistsearch;
alsearch = sq.RunViewSQL("|");
sq = null;
return alsearch;
}
 
 
public ArrayList GetAllDataAsArrayList(string Con)
{
ArrayList alsearch = new ArrayList();
string alistsearch = "SELECT * FROM SmallWSSR";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = alistsearch;
alsearch = sq.RunViewSQL("|");
sq = null;
return alsearch;
}
 
 
public DataTable SearchResultAsTable(string SearchExp, string Con)
{
DataTable dt = new DataTable();
string dtsearch = "SELECT * FROM SmallWSSR " +SearchExp;
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
 
public DataTable GetAllDataAsTable(string Con)
{
DataTable dt = new DataTable();
string dtsearch = "SELECT * FROM SmallWSSR";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
