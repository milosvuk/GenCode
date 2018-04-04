using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_itemsPL
 
{
public string connString;
public string connectionString;
public DB_itemsPL()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(itemsPL _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(itemsPL _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO tb_Items (item_sid,item_stylesid,item_number,item_upc,item_alu,item_dcs,item_dept,item_class,item_subClass,item_vendor,item_desc1,item_desc2,item_desc3,item_desc4,item_attr,item_size,item_udf1,item_udf2,item_udf3,item_udf4,item_aux1,item_aux2,item_aux3,item_aux4,item_aux5,item_aux6,item_aux7,item_aux8,item_udfname,item_udfdate,item_firstreceived,item_lastreceived,item_lastsold,item_storeqty1,item_storeqty2,item_storeqty3,item_storeqty4,item_storeqty5,item_storeqty6,item_taxcode,item_p$,item_t$,item_c$,item_pricelevels,item_spif,item_foc$,item_lastedit,PriceLevel_1,PriceLevel_2,PriceLevel_3,PriceLevel_4,PriceLevel_5,PriceLevel_6,PriceLevel_7,PriceLevel_8,PriceLevel_9,PriceLevel_10,PriceLevel_11,PriceLevel_12,PriceLevel_13,PriceLevel_14,PriceLevel_15,PriceLevel_16,PriceLevel_17,PriceLevel_18,PriceLevel_19,PriceLevel_20) VALUES (@item_sid,@item_stylesid,@item_number,@item_upc,@item_alu,@item_dcs,@item_dept,@item_class,@item_subClass,@item_vendor,@item_desc1,@item_desc2,@item_desc3,@item_desc4,@item_attr,@item_size,@item_udf1,@item_udf2,@item_udf3,@item_udf4,@item_aux1,@item_aux2,@item_aux3,@item_aux4,@item_aux5,@item_aux6,@item_aux7,@item_aux8,@item_udfname,@item_udfdate,@item_firstreceived,@item_lastreceived,@item_lastsold,@item_storeqty1,@item_storeqty2,@item_storeqty3,@item_storeqty4,@item_storeqty5,@item_storeqty6,@item_taxcode,@item_p$,@item_t$,@item_c$,@item_pricelevels,@item_spif,@item_foc$,@item_lastedit,@PriceLevel_1,@PriceLevel_2,@PriceLevel_3,@PriceLevel_4,@PriceLevel_5,@PriceLevel_6,@PriceLevel_7,@PriceLevel_8,@PriceLevel_9,@PriceLevel_10,@PriceLevel_11,@PriceLevel_12,@PriceLevel_13,@PriceLevel_14,@PriceLevel_15,@PriceLevel_16,@PriceLevel_17,@PriceLevel_18,@PriceLevel_19,@PriceLevel_20) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@item_sid", _tmpObject.ITEM_SID));
command.Parameters.Add(new SqlParameter("@item_stylesid", _tmpObject.ITEM_STYLESID));
command.Parameters.Add(new SqlParameter("@item_number", _tmpObject.ITEM_NUMBER));
command.Parameters.Add(new SqlParameter("@item_upc", _tmpObject.ITEM_UPC));
command.Parameters.Add(new SqlParameter("@item_alu", _tmpObject.ITEM_ALU));
command.Parameters.Add(new SqlParameter("@item_dcs", _tmpObject.ITEM_DCS));
command.Parameters.Add(new SqlParameter("@item_dept", _tmpObject.ITEM_DEPT));
command.Parameters.Add(new SqlParameter("@item_class", _tmpObject.ITEM_CLASS));
command.Parameters.Add(new SqlParameter("@item_subClass", _tmpObject.ITEM_SUBCLASS));
command.Parameters.Add(new SqlParameter("@item_vendor", _tmpObject.ITEM_VENDOR));
command.Parameters.Add(new SqlParameter("@item_desc1", _tmpObject.ITEM_DESC1));
command.Parameters.Add(new SqlParameter("@item_desc2", _tmpObject.ITEM_DESC2));
command.Parameters.Add(new SqlParameter("@item_desc3", _tmpObject.ITEM_DESC3));
command.Parameters.Add(new SqlParameter("@item_desc4", _tmpObject.ITEM_DESC4));
command.Parameters.Add(new SqlParameter("@item_attr", _tmpObject.ITEM_ATTR));
command.Parameters.Add(new SqlParameter("@item_size", _tmpObject.ITEM_SIZE));
command.Parameters.Add(new SqlParameter("@item_udf1", _tmpObject.ITEM_UDF1));
command.Parameters.Add(new SqlParameter("@item_udf2", _tmpObject.ITEM_UDF2));
command.Parameters.Add(new SqlParameter("@item_udf3", _tmpObject.ITEM_UDF3));
command.Parameters.Add(new SqlParameter("@item_udf4", _tmpObject.ITEM_UDF4));
command.Parameters.Add(new SqlParameter("@item_aux1", _tmpObject.ITEM_AUX1));
command.Parameters.Add(new SqlParameter("@item_aux2", _tmpObject.ITEM_AUX2));
command.Parameters.Add(new SqlParameter("@item_aux3", _tmpObject.ITEM_AUX3));
command.Parameters.Add(new SqlParameter("@item_aux4", _tmpObject.ITEM_AUX4));
command.Parameters.Add(new SqlParameter("@item_aux5", _tmpObject.ITEM_AUX5));
command.Parameters.Add(new SqlParameter("@item_aux6", _tmpObject.ITEM_AUX6));
command.Parameters.Add(new SqlParameter("@item_aux7", _tmpObject.ITEM_AUX7));
command.Parameters.Add(new SqlParameter("@item_aux8", _tmpObject.ITEM_AUX8));
command.Parameters.Add(new SqlParameter("@item_udfname", _tmpObject.ITEM_UDFNAME));
command.Parameters.Add(new SqlParameter("@item_udfdate", _tmpObject.ITEM_UDFDATE));
command.Parameters.Add(new SqlParameter("@item_firstreceived", _tmpObject.ITEM_FIRSTRECEIVED));
command.Parameters.Add(new SqlParameter("@item_lastreceived", _tmpObject.ITEM_LASTRECEIVED));
command.Parameters.Add(new SqlParameter("@item_lastsold", _tmpObject.ITEM_LASTSOLD));
command.Parameters.Add(new SqlParameter("@item_storeqty1", _tmpObject.ITEM_STOREQTY1));
command.Parameters.Add(new SqlParameter("@item_storeqty2", _tmpObject.ITEM_STOREQTY2));
command.Parameters.Add(new SqlParameter("@item_storeqty3", _tmpObject.ITEM_STOREQTY3));
command.Parameters.Add(new SqlParameter("@item_storeqty4", _tmpObject.ITEM_STOREQTY4));
command.Parameters.Add(new SqlParameter("@item_storeqty5", _tmpObject.ITEM_STOREQTY5));
command.Parameters.Add(new SqlParameter("@item_storeqty6", _tmpObject.ITEM_STOREQTY6));
command.Parameters.Add(new SqlParameter("@item_taxcode", _tmpObject.ITEM_TAXCODE));
command.Parameters.Add(new SqlParameter("@item_p$", _tmpObject.ITEM_P$));
command.Parameters.Add(new SqlParameter("@item_t$", _tmpObject.ITEM_T$));
command.Parameters.Add(new SqlParameter("@item_c$", _tmpObject.ITEM_C$));
command.Parameters.Add(new SqlParameter("@item_pricelevels", _tmpObject.ITEM_PRICELEVELS));
command.Parameters.Add(new SqlParameter("@item_spif", _tmpObject.ITEM_SPIF));
command.Parameters.Add(new SqlParameter("@item_foc$", _tmpObject.ITEM_FOC$));
command.Parameters.Add(new SqlParameter("@item_lastedit", _tmpObject.ITEM_LASTEDIT));
command.Parameters.Add(new SqlParameter("@PriceLevel_1", _tmpObject.PRICELEVEL_1));
command.Parameters.Add(new SqlParameter("@PriceLevel_2", _tmpObject.PRICELEVEL_2));
command.Parameters.Add(new SqlParameter("@PriceLevel_3", _tmpObject.PRICELEVEL_3));
command.Parameters.Add(new SqlParameter("@PriceLevel_4", _tmpObject.PRICELEVEL_4));
command.Parameters.Add(new SqlParameter("@PriceLevel_5", _tmpObject.PRICELEVEL_5));
command.Parameters.Add(new SqlParameter("@PriceLevel_6", _tmpObject.PRICELEVEL_6));
command.Parameters.Add(new SqlParameter("@PriceLevel_7", _tmpObject.PRICELEVEL_7));
command.Parameters.Add(new SqlParameter("@PriceLevel_8", _tmpObject.PRICELEVEL_8));
command.Parameters.Add(new SqlParameter("@PriceLevel_9", _tmpObject.PRICELEVEL_9));
command.Parameters.Add(new SqlParameter("@PriceLevel_10", _tmpObject.PRICELEVEL_10));
command.Parameters.Add(new SqlParameter("@PriceLevel_11", _tmpObject.PRICELEVEL_11));
command.Parameters.Add(new SqlParameter("@PriceLevel_12", _tmpObject.PRICELEVEL_12));
command.Parameters.Add(new SqlParameter("@PriceLevel_13", _tmpObject.PRICELEVEL_13));
command.Parameters.Add(new SqlParameter("@PriceLevel_14", _tmpObject.PRICELEVEL_14));
command.Parameters.Add(new SqlParameter("@PriceLevel_15", _tmpObject.PRICELEVEL_15));
command.Parameters.Add(new SqlParameter("@PriceLevel_16", _tmpObject.PRICELEVEL_16));
command.Parameters.Add(new SqlParameter("@PriceLevel_17", _tmpObject.PRICELEVEL_17));
command.Parameters.Add(new SqlParameter("@PriceLevel_18", _tmpObject.PRICELEVEL_18));
command.Parameters.Add(new SqlParameter("@PriceLevel_19", _tmpObject.PRICELEVEL_19));
command.Parameters.Add(new SqlParameter("@PriceLevel_20", _tmpObject.PRICELEVEL_20));
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
 
public int Update(itemsPL _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(itemsPL _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE tb_Items SET item_sid=@item_sid,item_stylesid=@item_stylesid,item_number=@item_number,item_upc=@item_upc,item_alu=@item_alu,item_dcs=@item_dcs,item_dept=@item_dept,item_class=@item_class,item_subClass=@item_subclass,item_vendor=@item_vendor,item_desc1=@item_desc1,item_desc2=@item_desc2,item_desc3=@item_desc3,item_desc4=@item_desc4,item_attr=@item_attr,item_size=@item_size,item_udf1=@item_udf1,item_udf2=@item_udf2,item_udf3=@item_udf3,item_udf4=@item_udf4,item_aux1=@item_aux1,item_aux2=@item_aux2,item_aux3=@item_aux3,item_aux4=@item_aux4,item_aux5=@item_aux5,item_aux6=@item_aux6,item_aux7=@item_aux7,item_aux8=@item_aux8,item_udfname=@item_udfname,item_udfdate=@item_udfdate,item_firstreceived=@item_firstreceived,item_lastreceived=@item_lastreceived,item_lastsold=@item_lastsold,item_storeqty1=@item_storeqty1,item_storeqty2=@item_storeqty2,item_storeqty3=@item_storeqty3,item_storeqty4=@item_storeqty4,item_storeqty5=@item_storeqty5,item_storeqty6=@item_storeqty6,item_taxcode=@item_taxcode,item_p$=@item_p$,item_t$=@item_t$,item_c$=@item_c$,item_pricelevels=@item_pricelevels,item_spif=@item_spif,item_foc$=@item_foc$,item_lastedit=@item_lastedit,PriceLevel_1=@pricelevel_1,PriceLevel_2=@pricelevel_2,PriceLevel_3=@pricelevel_3,PriceLevel_4=@pricelevel_4,PriceLevel_5=@pricelevel_5,PriceLevel_6=@pricelevel_6,PriceLevel_7=@pricelevel_7,PriceLevel_8=@pricelevel_8,PriceLevel_9=@pricelevel_9,PriceLevel_10=@pricelevel_10,PriceLevel_11=@pricelevel_11,PriceLevel_12=@pricelevel_12,PriceLevel_13=@pricelevel_13,PriceLevel_14=@pricelevel_14,PriceLevel_15=@pricelevel_15,PriceLevel_16=@pricelevel_16,PriceLevel_17=@pricelevel_17,PriceLevel_18=@pricelevel_18,PriceLevel_19=@pricelevel_19,PriceLevel_20=@pricelevel_20  WHERE item_id=@item_id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@item_sid", _tmpObject.ITEM_SID));
command.Parameters.Add(new SqlParameter("@item_stylesid", _tmpObject.ITEM_STYLESID));
command.Parameters.Add(new SqlParameter("@item_number", _tmpObject.ITEM_NUMBER));
command.Parameters.Add(new SqlParameter("@item_upc", _tmpObject.ITEM_UPC));
command.Parameters.Add(new SqlParameter("@item_alu", _tmpObject.ITEM_ALU));
command.Parameters.Add(new SqlParameter("@item_dcs", _tmpObject.ITEM_DCS));
command.Parameters.Add(new SqlParameter("@item_dept", _tmpObject.ITEM_DEPT));
command.Parameters.Add(new SqlParameter("@item_class", _tmpObject.ITEM_CLASS));
command.Parameters.Add(new SqlParameter("@item_subclass", _tmpObject.ITEM_SUBCLASS));
command.Parameters.Add(new SqlParameter("@item_vendor", _tmpObject.ITEM_VENDOR));
command.Parameters.Add(new SqlParameter("@item_desc1", _tmpObject.ITEM_DESC1));
command.Parameters.Add(new SqlParameter("@item_desc2", _tmpObject.ITEM_DESC2));
command.Parameters.Add(new SqlParameter("@item_desc3", _tmpObject.ITEM_DESC3));
command.Parameters.Add(new SqlParameter("@item_desc4", _tmpObject.ITEM_DESC4));
command.Parameters.Add(new SqlParameter("@item_attr", _tmpObject.ITEM_ATTR));
command.Parameters.Add(new SqlParameter("@item_size", _tmpObject.ITEM_SIZE));
command.Parameters.Add(new SqlParameter("@item_udf1", _tmpObject.ITEM_UDF1));
command.Parameters.Add(new SqlParameter("@item_udf2", _tmpObject.ITEM_UDF2));
command.Parameters.Add(new SqlParameter("@item_udf3", _tmpObject.ITEM_UDF3));
command.Parameters.Add(new SqlParameter("@item_udf4", _tmpObject.ITEM_UDF4));
command.Parameters.Add(new SqlParameter("@item_aux1", _tmpObject.ITEM_AUX1));
command.Parameters.Add(new SqlParameter("@item_aux2", _tmpObject.ITEM_AUX2));
command.Parameters.Add(new SqlParameter("@item_aux3", _tmpObject.ITEM_AUX3));
command.Parameters.Add(new SqlParameter("@item_aux4", _tmpObject.ITEM_AUX4));
command.Parameters.Add(new SqlParameter("@item_aux5", _tmpObject.ITEM_AUX5));
command.Parameters.Add(new SqlParameter("@item_aux6", _tmpObject.ITEM_AUX6));
command.Parameters.Add(new SqlParameter("@item_aux7", _tmpObject.ITEM_AUX7));
command.Parameters.Add(new SqlParameter("@item_aux8", _tmpObject.ITEM_AUX8));
command.Parameters.Add(new SqlParameter("@item_udfname", _tmpObject.ITEM_UDFNAME));
command.Parameters.Add(new SqlParameter("@item_udfdate", _tmpObject.ITEM_UDFDATE));
command.Parameters.Add(new SqlParameter("@item_firstreceived", _tmpObject.ITEM_FIRSTRECEIVED));
command.Parameters.Add(new SqlParameter("@item_lastreceived", _tmpObject.ITEM_LASTRECEIVED));
command.Parameters.Add(new SqlParameter("@item_lastsold", _tmpObject.ITEM_LASTSOLD));
command.Parameters.Add(new SqlParameter("@item_storeqty1", _tmpObject.ITEM_STOREQTY1));
command.Parameters.Add(new SqlParameter("@item_storeqty2", _tmpObject.ITEM_STOREQTY2));
command.Parameters.Add(new SqlParameter("@item_storeqty3", _tmpObject.ITEM_STOREQTY3));
command.Parameters.Add(new SqlParameter("@item_storeqty4", _tmpObject.ITEM_STOREQTY4));
command.Parameters.Add(new SqlParameter("@item_storeqty5", _tmpObject.ITEM_STOREQTY5));
command.Parameters.Add(new SqlParameter("@item_storeqty6", _tmpObject.ITEM_STOREQTY6));
command.Parameters.Add(new SqlParameter("@item_taxcode", _tmpObject.ITEM_TAXCODE));
command.Parameters.Add(new SqlParameter("@item_p$", _tmpObject.ITEM_P$));
command.Parameters.Add(new SqlParameter("@item_t$", _tmpObject.ITEM_T$));
command.Parameters.Add(new SqlParameter("@item_c$", _tmpObject.ITEM_C$));
command.Parameters.Add(new SqlParameter("@item_pricelevels", _tmpObject.ITEM_PRICELEVELS));
command.Parameters.Add(new SqlParameter("@item_spif", _tmpObject.ITEM_SPIF));
command.Parameters.Add(new SqlParameter("@item_foc$", _tmpObject.ITEM_FOC$));
command.Parameters.Add(new SqlParameter("@item_lastedit", _tmpObject.ITEM_LASTEDIT));
command.Parameters.Add(new SqlParameter("@pricelevel_1", _tmpObject.PRICELEVEL_1));
command.Parameters.Add(new SqlParameter("@pricelevel_2", _tmpObject.PRICELEVEL_2));
command.Parameters.Add(new SqlParameter("@pricelevel_3", _tmpObject.PRICELEVEL_3));
command.Parameters.Add(new SqlParameter("@pricelevel_4", _tmpObject.PRICELEVEL_4));
command.Parameters.Add(new SqlParameter("@pricelevel_5", _tmpObject.PRICELEVEL_5));
command.Parameters.Add(new SqlParameter("@pricelevel_6", _tmpObject.PRICELEVEL_6));
command.Parameters.Add(new SqlParameter("@pricelevel_7", _tmpObject.PRICELEVEL_7));
command.Parameters.Add(new SqlParameter("@pricelevel_8", _tmpObject.PRICELEVEL_8));
command.Parameters.Add(new SqlParameter("@pricelevel_9", _tmpObject.PRICELEVEL_9));
command.Parameters.Add(new SqlParameter("@pricelevel_10", _tmpObject.PRICELEVEL_10));
command.Parameters.Add(new SqlParameter("@pricelevel_11", _tmpObject.PRICELEVEL_11));
command.Parameters.Add(new SqlParameter("@pricelevel_12", _tmpObject.PRICELEVEL_12));
command.Parameters.Add(new SqlParameter("@pricelevel_13", _tmpObject.PRICELEVEL_13));
command.Parameters.Add(new SqlParameter("@pricelevel_14", _tmpObject.PRICELEVEL_14));
command.Parameters.Add(new SqlParameter("@pricelevel_15", _tmpObject.PRICELEVEL_15));
command.Parameters.Add(new SqlParameter("@pricelevel_16", _tmpObject.PRICELEVEL_16));
command.Parameters.Add(new SqlParameter("@pricelevel_17", _tmpObject.PRICELEVEL_17));
command.Parameters.Add(new SqlParameter("@pricelevel_18", _tmpObject.PRICELEVEL_18));
command.Parameters.Add(new SqlParameter("@pricelevel_19", _tmpObject.PRICELEVEL_19));
command.Parameters.Add(new SqlParameter("@pricelevel_20", _tmpObject.PRICELEVEL_20));
command.Parameters.Add(new SqlParameter("@item_id", _tmpObject.ITEM_ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(itemsPL _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(itemsPL _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE tb_Items  WHERE item_id=@item_id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@item_id", _tmpObject.ITEM_ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public itemsPL GetById(int _id)
{
itemsPL tmpObject = new itemsPL();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From tb_Items WHERE item_id=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ITEM_ID = (System.Int32)dr["item_id"];
tmpObject.ITEM_SID = (System.Int64)dr["item_sid"];
tmpObject.ITEM_STYLESID = (System.Int64)dr["item_stylesid"];
tmpObject.ITEM_NUMBER = (System.Int32)dr["item_number"];
tmpObject.ITEM_UPC = (System.String)dr["item_upc"];
tmpObject.ITEM_ALU = (System.String)dr["item_alu"];
tmpObject.ITEM_DCS = (System.String)dr["item_dcs"];
tmpObject.ITEM_DEPT = (System.String)dr["item_dept"];
tmpObject.ITEM_CLASS = (System.String)dr["item_class"];
tmpObject.ITEM_SUBCLASS = (System.String)dr["item_subClass"];
tmpObject.ITEM_VENDOR = (System.String)dr["item_vendor"];
tmpObject.ITEM_DESC1 = (System.String)dr["item_desc1"];
tmpObject.ITEM_DESC2 = (System.String)dr["item_desc2"];
tmpObject.ITEM_DESC3 = (System.String)dr["item_desc3"];
tmpObject.ITEM_DESC4 = (System.String)dr["item_desc4"];
tmpObject.ITEM_ATTR = (System.String)dr["item_attr"];
tmpObject.ITEM_SIZE = (System.String)dr["item_size"];
tmpObject.ITEM_UDF1 = (System.String)dr["item_udf1"];
tmpObject.ITEM_UDF2 = (System.String)dr["item_udf2"];
tmpObject.ITEM_UDF3 = (System.String)dr["item_udf3"];
tmpObject.ITEM_UDF4 = (System.String)dr["item_udf4"];
tmpObject.ITEM_AUX1 = (System.String)dr["item_aux1"];
tmpObject.ITEM_AUX2 = (System.String)dr["item_aux2"];
tmpObject.ITEM_AUX3 = (System.String)dr["item_aux3"];
tmpObject.ITEM_AUX4 = (System.String)dr["item_aux4"];
tmpObject.ITEM_AUX5 = (System.String)dr["item_aux5"];
tmpObject.ITEM_AUX6 = (System.String)dr["item_aux6"];
tmpObject.ITEM_AUX7 = (System.String)dr["item_aux7"];
tmpObject.ITEM_AUX8 = (System.String)dr["item_aux8"];
tmpObject.ITEM_UDFNAME = (System.String)dr["item_udfname"];
tmpObject.ITEM_UDFDATE = (System.DateTime)dr["item_udfdate"];
tmpObject.ITEM_FIRSTRECEIVED = (System.DateTime)dr["item_firstreceived"];
tmpObject.ITEM_LASTRECEIVED = (System.DateTime)dr["item_lastreceived"];
tmpObject.ITEM_LASTSOLD = (System.DateTime)dr["item_lastsold"];
tmpObject.ITEM_STOREQTY1 = (System.Int32)dr["item_storeqty1"];
tmpObject.ITEM_STOREQTY2 = (System.Int32)dr["item_storeqty2"];
tmpObject.ITEM_STOREQTY3 = (System.Int32)dr["item_storeqty3"];
tmpObject.ITEM_STOREQTY4 = (System.Int32)dr["item_storeqty4"];
tmpObject.ITEM_STOREQTY5 = (System.Int32)dr["item_storeqty5"];
tmpObject.ITEM_STOREQTY6 = (System.Int32)dr["item_storeqty6"];
tmpObject.ITEM_TAXCODE = (System.String)dr["item_taxcode"];
tmpObject.ITEM_P$ = (System.Decimal)dr["item_p$"];
tmpObject.ITEM_T$ = (System.Decimal)dr["item_t$"];
tmpObject.ITEM_C$ = (System.Decimal)dr["item_c$"];
tmpObject.ITEM_PRICELEVELS = (System.String)dr["item_pricelevels"];
tmpObject.ITEM_SPIF = (System.Decimal)dr["item_spif"];
tmpObject.ITEM_FOC$ = (System.Decimal)dr["item_foc$"];
tmpObject.ITEM_LASTEDIT = (System.DateTime)dr["item_lastedit"];
tmpObject.PRICELEVEL_1 = (System.Decimal)dr["PriceLevel_1"];
tmpObject.PRICELEVEL_2 = (System.Decimal)dr["PriceLevel_2"];
tmpObject.PRICELEVEL_3 = (System.Decimal)dr["PriceLevel_3"];
tmpObject.PRICELEVEL_4 = (System.Decimal)dr["PriceLevel_4"];
tmpObject.PRICELEVEL_5 = (System.Decimal)dr["PriceLevel_5"];
tmpObject.PRICELEVEL_6 = (System.Decimal)dr["PriceLevel_6"];
tmpObject.PRICELEVEL_7 = (System.Decimal)dr["PriceLevel_7"];
tmpObject.PRICELEVEL_8 = (System.Decimal)dr["PriceLevel_8"];
tmpObject.PRICELEVEL_9 = (System.Decimal)dr["PriceLevel_9"];
tmpObject.PRICELEVEL_10 = (System.Decimal)dr["PriceLevel_10"];
tmpObject.PRICELEVEL_11 = (System.Decimal)dr["PriceLevel_11"];
tmpObject.PRICELEVEL_12 = (System.Decimal)dr["PriceLevel_12"];
tmpObject.PRICELEVEL_13 = (System.Decimal)dr["PriceLevel_13"];
tmpObject.PRICELEVEL_14 = (System.Decimal)dr["PriceLevel_14"];
tmpObject.PRICELEVEL_15 = (System.Decimal)dr["PriceLevel_15"];
tmpObject.PRICELEVEL_16 = (System.Decimal)dr["PriceLevel_16"];
tmpObject.PRICELEVEL_17 = (System.Decimal)dr["PriceLevel_17"];
tmpObject.PRICELEVEL_18 = (System.Decimal)dr["PriceLevel_18"];
tmpObject.PRICELEVEL_19 = (System.Decimal)dr["PriceLevel_19"];
tmpObject.PRICELEVEL_20 = (System.Decimal)dr["PriceLevel_20"];
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
