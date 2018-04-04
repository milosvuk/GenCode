using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_WeekSS
 
{
public string connString;
public string connectionString;
public DB_WeekSS()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(WeekSS _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(WeekSS _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO WeekSS (weeknumber,year_,storenumber,storename,divisionnumberdepartrpro,divisionnamedepartrpro,departmentnoclassrpro,departmentnameclassrpro,vendorcode,Sales_QtySold_NoDisc,Sales_Value_Euro_NoDisc,Sales_Value_Pound_NoDisc,SalesMixPercenatage_NoDisc,StockOnHand_NoDisc,StockOnHand_ValueEuro_NoDisc,StockOnHand_ValuePound_NoDisc,StockOnHandMixPercenatage_NoDisc,StockOnHandBranchCover_NoDisc,Sales_QtySold_Disc,Sales_Value_Euro_Disc,Sales_Value_Pound_Disc,SalesMixPercenatage_Disc,StockOnHand_Disc,StockOnHand_ValueEuro_Disc,StockOnHand_ValuePound_Disc,StockOnHandMixPercenatage_Disc,StockOnHandBranchCover_Disc,Sales_QtySold_Full,Sales_Value_Euro_Full,Sales_Value_Pound_Full,SalesMixPercenatage_Full,StockOnHand_Full,StockOnHand_ValueEuro_Full,StockOnHand_ValuePound_Full,StockOnHandMixPercenatage_Full,StockOnHandBranchCover_Full) VALUES (@weeknumber,@year_,@storenumber,@storename,@divisionnumberdepartrpro,@divisionnamedepartrpro,@departmentnoclassrpro,@departmentnameclassrpro,@vendorcode,@Sales_QtySold_NoDisc,@Sales_Value_Euro_NoDisc,@Sales_Value_Pound_NoDisc,@SalesMixPercenatage_NoDisc,@StockOnHand_NoDisc,@StockOnHand_ValueEuro_NoDisc,@StockOnHand_ValuePound_NoDisc,@StockOnHandMixPercenatage_NoDisc,@StockOnHandBranchCover_NoDisc,@Sales_QtySold_Disc,@Sales_Value_Euro_Disc,@Sales_Value_Pound_Disc,@SalesMixPercenatage_Disc,@StockOnHand_Disc,@StockOnHand_ValueEuro_Disc,@StockOnHand_ValuePound_Disc,@StockOnHandMixPercenatage_Disc,@StockOnHandBranchCover_Disc,@Sales_QtySold_Full,@Sales_Value_Euro_Full,@Sales_Value_Pound_Full,@SalesMixPercenatage_Full,@StockOnHand_Full,@StockOnHand_ValueEuro_Full,@StockOnHand_ValuePound_Full,@StockOnHandMixPercenatage_Full,@StockOnHandBranchCover_Full) SET @tmpid = SCOPE_IDENTITY()", conn);
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
command.Parameters.Add(new SqlParameter("@vendorcode", _tmpObject.VENDORCODE));
command.Parameters.Add(new SqlParameter("@Sales_QtySold_NoDisc", _tmpObject.SALES_QTYSOLD_NODISC));
command.Parameters.Add(new SqlParameter("@Sales_Value_Euro_NoDisc", _tmpObject.SALES_VALUE_EURO_NODISC));
command.Parameters.Add(new SqlParameter("@Sales_Value_Pound_NoDisc", _tmpObject.SALES_VALUE_POUND_NODISC));
command.Parameters.Add(new SqlParameter("@SalesMixPercenatage_NoDisc", _tmpObject.SALESMIXPERCENATAGE_NODISC));
command.Parameters.Add(new SqlParameter("@StockOnHand_NoDisc", _tmpObject.STOCKONHAND_NODISC));
command.Parameters.Add(new SqlParameter("@StockOnHand_ValueEuro_NoDisc", _tmpObject.STOCKONHAND_VALUEEURO_NODISC));
command.Parameters.Add(new SqlParameter("@StockOnHand_ValuePound_NoDisc", _tmpObject.STOCKONHAND_VALUEPOUND_NODISC));
command.Parameters.Add(new SqlParameter("@StockOnHandMixPercenatage_NoDisc", _tmpObject.STOCKONHANDMIXPERCENATAGE_NODISC));
command.Parameters.Add(new SqlParameter("@StockOnHandBranchCover_NoDisc", _tmpObject.STOCKONHANDBRANCHCOVER_NODISC));
command.Parameters.Add(new SqlParameter("@Sales_QtySold_Disc", _tmpObject.SALES_QTYSOLD_DISC));
command.Parameters.Add(new SqlParameter("@Sales_Value_Euro_Disc", _tmpObject.SALES_VALUE_EURO_DISC));
command.Parameters.Add(new SqlParameter("@Sales_Value_Pound_Disc", _tmpObject.SALES_VALUE_POUND_DISC));
command.Parameters.Add(new SqlParameter("@SalesMixPercenatage_Disc", _tmpObject.SALESMIXPERCENATAGE_DISC));
command.Parameters.Add(new SqlParameter("@StockOnHand_Disc", _tmpObject.STOCKONHAND_DISC));
command.Parameters.Add(new SqlParameter("@StockOnHand_ValueEuro_Disc", _tmpObject.STOCKONHAND_VALUEEURO_DISC));
command.Parameters.Add(new SqlParameter("@StockOnHand_ValuePound_Disc", _tmpObject.STOCKONHAND_VALUEPOUND_DISC));
command.Parameters.Add(new SqlParameter("@StockOnHandMixPercenatage_Disc", _tmpObject.STOCKONHANDMIXPERCENATAGE_DISC));
command.Parameters.Add(new SqlParameter("@StockOnHandBranchCover_Disc", _tmpObject.STOCKONHANDBRANCHCOVER_DISC));
command.Parameters.Add(new SqlParameter("@Sales_QtySold_Full", _tmpObject.SALES_QTYSOLD_FULL));
command.Parameters.Add(new SqlParameter("@Sales_Value_Euro_Full", _tmpObject.SALES_VALUE_EURO_FULL));
command.Parameters.Add(new SqlParameter("@Sales_Value_Pound_Full", _tmpObject.SALES_VALUE_POUND_FULL));
command.Parameters.Add(new SqlParameter("@SalesMixPercenatage_Full", _tmpObject.SALESMIXPERCENATAGE_FULL));
command.Parameters.Add(new SqlParameter("@StockOnHand_Full", _tmpObject.STOCKONHAND_FULL));
command.Parameters.Add(new SqlParameter("@StockOnHand_ValueEuro_Full", _tmpObject.STOCKONHAND_VALUEEURO_FULL));
command.Parameters.Add(new SqlParameter("@StockOnHand_ValuePound_Full", _tmpObject.STOCKONHAND_VALUEPOUND_FULL));
command.Parameters.Add(new SqlParameter("@StockOnHandMixPercenatage_Full", _tmpObject.STOCKONHANDMIXPERCENATAGE_FULL));
command.Parameters.Add(new SqlParameter("@StockOnHandBranchCover_Full", _tmpObject.STOCKONHANDBRANCHCOVER_FULL));
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
 
public int Update(WeekSS _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(WeekSS _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE WeekSS SET weeknumber=@weeknumber,year_=@year_,storenumber=@storenumber,storename=@storename,divisionnumberdepartrpro=@divisionnumberdepartrpro,divisionnamedepartrpro=@divisionnamedepartrpro,departmentnoclassrpro=@departmentnoclassrpro,departmentnameclassrpro=@departmentnameclassrpro,vendorcode=@vendorcode,Sales_QtySold_NoDisc=@sales_qtysold_nodisc,Sales_Value_Euro_NoDisc=@sales_value_euro_nodisc,Sales_Value_Pound_NoDisc=@sales_value_pound_nodisc,SalesMixPercenatage_NoDisc=@salesmixpercenatage_nodisc,StockOnHand_NoDisc=@stockonhand_nodisc,StockOnHand_ValueEuro_NoDisc=@stockonhand_valueeuro_nodisc,StockOnHand_ValuePound_NoDisc=@stockonhand_valuepound_nodisc,StockOnHandMixPercenatage_NoDisc=@stockonhandmixpercenatage_nodisc,StockOnHandBranchCover_NoDisc=@stockonhandbranchcover_nodisc,Sales_QtySold_Disc=@sales_qtysold_disc,Sales_Value_Euro_Disc=@sales_value_euro_disc,Sales_Value_Pound_Disc=@sales_value_pound_disc,SalesMixPercenatage_Disc=@salesmixpercenatage_disc,StockOnHand_Disc=@stockonhand_disc,StockOnHand_ValueEuro_Disc=@stockonhand_valueeuro_disc,StockOnHand_ValuePound_Disc=@stockonhand_valuepound_disc,StockOnHandMixPercenatage_Disc=@stockonhandmixpercenatage_disc,StockOnHandBranchCover_Disc=@stockonhandbranchcover_disc,Sales_QtySold_Full=@sales_qtysold_full,Sales_Value_Euro_Full=@sales_value_euro_full,Sales_Value_Pound_Full=@sales_value_pound_full,SalesMixPercenatage_Full=@salesmixpercenatage_full,StockOnHand_Full=@stockonhand_full,StockOnHand_ValueEuro_Full=@stockonhand_valueeuro_full,StockOnHand_ValuePound_Full=@stockonhand_valuepound_full,StockOnHandMixPercenatage_Full=@stockonhandmixpercenatage_full,StockOnHandBranchCover_Full=@stockonhandbranchcover_full  WHERE idofrecord=@idofrecord", conn);
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
command.Parameters.Add(new SqlParameter("@vendorcode", _tmpObject.VENDORCODE));
command.Parameters.Add(new SqlParameter("@sales_qtysold_nodisc", _tmpObject.SALES_QTYSOLD_NODISC));
command.Parameters.Add(new SqlParameter("@sales_value_euro_nodisc", _tmpObject.SALES_VALUE_EURO_NODISC));
command.Parameters.Add(new SqlParameter("@sales_value_pound_nodisc", _tmpObject.SALES_VALUE_POUND_NODISC));
command.Parameters.Add(new SqlParameter("@salesmixpercenatage_nodisc", _tmpObject.SALESMIXPERCENATAGE_NODISC));
command.Parameters.Add(new SqlParameter("@stockonhand_nodisc", _tmpObject.STOCKONHAND_NODISC));
command.Parameters.Add(new SqlParameter("@stockonhand_valueeuro_nodisc", _tmpObject.STOCKONHAND_VALUEEURO_NODISC));
command.Parameters.Add(new SqlParameter("@stockonhand_valuepound_nodisc", _tmpObject.STOCKONHAND_VALUEPOUND_NODISC));
command.Parameters.Add(new SqlParameter("@stockonhandmixpercenatage_nodisc", _tmpObject.STOCKONHANDMIXPERCENATAGE_NODISC));
command.Parameters.Add(new SqlParameter("@stockonhandbranchcover_nodisc", _tmpObject.STOCKONHANDBRANCHCOVER_NODISC));
command.Parameters.Add(new SqlParameter("@sales_qtysold_disc", _tmpObject.SALES_QTYSOLD_DISC));
command.Parameters.Add(new SqlParameter("@sales_value_euro_disc", _tmpObject.SALES_VALUE_EURO_DISC));
command.Parameters.Add(new SqlParameter("@sales_value_pound_disc", _tmpObject.SALES_VALUE_POUND_DISC));
command.Parameters.Add(new SqlParameter("@salesmixpercenatage_disc", _tmpObject.SALESMIXPERCENATAGE_DISC));
command.Parameters.Add(new SqlParameter("@stockonhand_disc", _tmpObject.STOCKONHAND_DISC));
command.Parameters.Add(new SqlParameter("@stockonhand_valueeuro_disc", _tmpObject.STOCKONHAND_VALUEEURO_DISC));
command.Parameters.Add(new SqlParameter("@stockonhand_valuepound_disc", _tmpObject.STOCKONHAND_VALUEPOUND_DISC));
command.Parameters.Add(new SqlParameter("@stockonhandmixpercenatage_disc", _tmpObject.STOCKONHANDMIXPERCENATAGE_DISC));
command.Parameters.Add(new SqlParameter("@stockonhandbranchcover_disc", _tmpObject.STOCKONHANDBRANCHCOVER_DISC));
command.Parameters.Add(new SqlParameter("@sales_qtysold_full", _tmpObject.SALES_QTYSOLD_FULL));
command.Parameters.Add(new SqlParameter("@sales_value_euro_full", _tmpObject.SALES_VALUE_EURO_FULL));
command.Parameters.Add(new SqlParameter("@sales_value_pound_full", _tmpObject.SALES_VALUE_POUND_FULL));
command.Parameters.Add(new SqlParameter("@salesmixpercenatage_full", _tmpObject.SALESMIXPERCENATAGE_FULL));
command.Parameters.Add(new SqlParameter("@stockonhand_full", _tmpObject.STOCKONHAND_FULL));
command.Parameters.Add(new SqlParameter("@stockonhand_valueeuro_full", _tmpObject.STOCKONHAND_VALUEEURO_FULL));
command.Parameters.Add(new SqlParameter("@stockonhand_valuepound_full", _tmpObject.STOCKONHAND_VALUEPOUND_FULL));
command.Parameters.Add(new SqlParameter("@stockonhandmixpercenatage_full", _tmpObject.STOCKONHANDMIXPERCENATAGE_FULL));
command.Parameters.Add(new SqlParameter("@stockonhandbranchcover_full", _tmpObject.STOCKONHANDBRANCHCOVER_FULL));
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
 
public int Delete(WeekSS _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(WeekSS _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE WeekSS  WHERE idofrecord=@idofrecord", conn);
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
public WeekSS GetById(int _id)
{
WeekSS tmpObject = new WeekSS();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From WeekSS WHERE idofrecord=" + _id.ToString(), conn);
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
tmpObject.VENDORCODE = (System.String)dr["vendorcode"];
tmpObject.SALES_QTYSOLD_NODISC = (System.String)dr["Sales_QtySold_NoDisc"];
tmpObject.SALES_VALUE_EURO_NODISC = (System.String)dr["Sales_Value_Euro_NoDisc"];
tmpObject.SALES_VALUE_POUND_NODISC = (System.String)dr["Sales_Value_Pound_NoDisc"];
tmpObject.SALESMIXPERCENATAGE_NODISC = (System.String)dr["SalesMixPercenatage_NoDisc"];
tmpObject.STOCKONHAND_NODISC = (System.String)dr["StockOnHand_NoDisc"];
tmpObject.STOCKONHAND_VALUEEURO_NODISC = (System.String)dr["StockOnHand_ValueEuro_NoDisc"];
tmpObject.STOCKONHAND_VALUEPOUND_NODISC = (System.String)dr["StockOnHand_ValuePound_NoDisc"];
tmpObject.STOCKONHANDMIXPERCENATAGE_NODISC = (System.String)dr["StockOnHandMixPercenatage_NoDisc"];
tmpObject.STOCKONHANDBRANCHCOVER_NODISC = (System.String)dr["StockOnHandBranchCover_NoDisc"];
tmpObject.SALES_QTYSOLD_DISC = (System.String)dr["Sales_QtySold_Disc"];
tmpObject.SALES_VALUE_EURO_DISC = (System.String)dr["Sales_Value_Euro_Disc"];
tmpObject.SALES_VALUE_POUND_DISC = (System.String)dr["Sales_Value_Pound_Disc"];
tmpObject.SALESMIXPERCENATAGE_DISC = (System.String)dr["SalesMixPercenatage_Disc"];
tmpObject.STOCKONHAND_DISC = (System.String)dr["StockOnHand_Disc"];
tmpObject.STOCKONHAND_VALUEEURO_DISC = (System.String)dr["StockOnHand_ValueEuro_Disc"];
tmpObject.STOCKONHAND_VALUEPOUND_DISC = (System.String)dr["StockOnHand_ValuePound_Disc"];
tmpObject.STOCKONHANDMIXPERCENATAGE_DISC = (System.String)dr["StockOnHandMixPercenatage_Disc"];
tmpObject.STOCKONHANDBRANCHCOVER_DISC = (System.String)dr["StockOnHandBranchCover_Disc"];
tmpObject.SALES_QTYSOLD_FULL = (System.String)dr["Sales_QtySold_Full"];
tmpObject.SALES_VALUE_EURO_FULL = (System.String)dr["Sales_Value_Euro_Full"];
tmpObject.SALES_VALUE_POUND_FULL = (System.String)dr["Sales_Value_Pound_Full"];
tmpObject.SALESMIXPERCENATAGE_FULL = (System.String)dr["SalesMixPercenatage_Full"];
tmpObject.STOCKONHAND_FULL = (System.String)dr["StockOnHand_Full"];
tmpObject.STOCKONHAND_VALUEEURO_FULL = (System.String)dr["StockOnHand_ValueEuro_Full"];
tmpObject.STOCKONHAND_VALUEPOUND_FULL = (System.String)dr["StockOnHand_ValuePound_Full"];
tmpObject.STOCKONHANDMIXPERCENATAGE_FULL = (System.String)dr["StockOnHandMixPercenatage_Full"];
tmpObject.STOCKONHANDBRANCHCOVER_FULL = (System.String)dr["StockOnHandBranchCover_Full"];
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
