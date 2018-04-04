using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class itemsPL
 
{
public string connString;
public string connectionString;
public itemsPL()
{
  
 
 
}
 
public itemsPL (System.Int32 _item_id,System.Int64 _item_sid,System.Int64 _item_stylesid,System.Int32 _item_number,System.String _item_upc,System.String _item_alu,System.String _item_dcs,System.String _item_dept,System.String _item_class,System.String _item_subclass,System.String _item_vendor,System.String _item_desc1,System.String _item_desc2,System.String _item_desc3,System.String _item_desc4,System.String _item_attr,System.String _item_size,System.String _item_udf1,System.String _item_udf2,System.String _item_udf3,System.String _item_udf4,System.String _item_aux1,System.String _item_aux2,System.String _item_aux3,System.String _item_aux4,System.String _item_aux5,System.String _item_aux6,System.String _item_aux7,System.String _item_aux8,System.String _item_udfname,System.DateTime _item_udfdate,System.DateTime _item_firstreceived,System.DateTime _item_lastreceived,System.DateTime _item_lastsold,System.Int32 _item_storeqty1,System.Int32 _item_storeqty2,System.Int32 _item_storeqty3,System.Int32 _item_storeqty4,System.Int32 _item_storeqty5,System.Int32 _item_storeqty6,System.String _item_taxcode,System.Decimal _item_p$,System.Decimal _item_t$,System.Decimal _item_c$,System.String _item_pricelevels,System.Decimal _item_spif,System.Decimal _item_foc$,System.DateTime _item_lastedit,System.Decimal _pricelevel_1,System.Decimal _pricelevel_2,System.Decimal _pricelevel_3,System.Decimal _pricelevel_4,System.Decimal _pricelevel_5,System.Decimal _pricelevel_6,System.Decimal _pricelevel_7,System.Decimal _pricelevel_8,System.Decimal _pricelevel_9,System.Decimal _pricelevel_10,System.Decimal _pricelevel_11,System.Decimal _pricelevel_12,System.Decimal _pricelevel_13,System.Decimal _pricelevel_14,System.Decimal _pricelevel_15,System.Decimal _pricelevel_16,System.Decimal _pricelevel_17,System.Decimal _pricelevel_18,System.Decimal _pricelevel_19,System.Decimal _pricelevel_20 )
{
item_id=_item_id;
item_sid=_item_sid;
item_stylesid=_item_stylesid;
item_number=_item_number;
item_upc=_item_upc;
item_alu=_item_alu;
item_dcs=_item_dcs;
item_dept=_item_dept;
item_class=_item_class;
item_subclass=_item_subclass;
item_vendor=_item_vendor;
item_desc1=_item_desc1;
item_desc2=_item_desc2;
item_desc3=_item_desc3;
item_desc4=_item_desc4;
item_attr=_item_attr;
item_size=_item_size;
item_udf1=_item_udf1;
item_udf2=_item_udf2;
item_udf3=_item_udf3;
item_udf4=_item_udf4;
item_aux1=_item_aux1;
item_aux2=_item_aux2;
item_aux3=_item_aux3;
item_aux4=_item_aux4;
item_aux5=_item_aux5;
item_aux6=_item_aux6;
item_aux7=_item_aux7;
item_aux8=_item_aux8;
item_udfname=_item_udfname;
item_udfdate=_item_udfdate;
item_firstreceived=_item_firstreceived;
item_lastreceived=_item_lastreceived;
item_lastsold=_item_lastsold;
item_storeqty1=_item_storeqty1;
item_storeqty2=_item_storeqty2;
item_storeqty3=_item_storeqty3;
item_storeqty4=_item_storeqty4;
item_storeqty5=_item_storeqty5;
item_storeqty6=_item_storeqty6;
item_taxcode=_item_taxcode;
item_p$=_item_p$;
item_t$=_item_t$;
item_c$=_item_c$;
item_pricelevels=_item_pricelevels;
item_spif=_item_spif;
item_foc$=_item_foc$;
item_lastedit=_item_lastedit;
pricelevel_1=_pricelevel_1;
pricelevel_2=_pricelevel_2;
pricelevel_3=_pricelevel_3;
pricelevel_4=_pricelevel_4;
pricelevel_5=_pricelevel_5;
pricelevel_6=_pricelevel_6;
pricelevel_7=_pricelevel_7;
pricelevel_8=_pricelevel_8;
pricelevel_9=_pricelevel_9;
pricelevel_10=_pricelevel_10;
pricelevel_11=_pricelevel_11;
pricelevel_12=_pricelevel_12;
pricelevel_13=_pricelevel_13;
pricelevel_14=_pricelevel_14;
pricelevel_15=_pricelevel_15;
pricelevel_16=_pricelevel_16;
pricelevel_17=_pricelevel_17;
pricelevel_18=_pricelevel_18;
pricelevel_19=_pricelevel_19;
pricelevel_20=_pricelevel_20;
}
 
 
private System.Int32 item_id;
 
public System.Int32 ITEM_ID
{
get
{
return item_id;
}
set
{
item_id=value;
}
}
 
private System.Int64 item_sid;
 
public System.Int64 ITEM_SID
{
get
{
return item_sid;
}
set
{
item_sid=value;
}
}
 
private System.Int64 item_stylesid;
 
public System.Int64 ITEM_STYLESID
{
get
{
return item_stylesid;
}
set
{
item_stylesid=value;
}
}
 
private System.Int32 item_number;
 
public System.Int32 ITEM_NUMBER
{
get
{
return item_number;
}
set
{
item_number=value;
}
}
 
private System.String item_upc;
 
public System.String ITEM_UPC
{
get
{
return item_upc;
}
set
{
item_upc=value;
}
}
 
private System.String item_alu;
 
public System.String ITEM_ALU
{
get
{
return item_alu;
}
set
{
item_alu=value;
}
}
 
private System.String item_dcs;
 
public System.String ITEM_DCS
{
get
{
return item_dcs;
}
set
{
item_dcs=value;
}
}
 
private System.String item_dept;
 
public System.String ITEM_DEPT
{
get
{
return item_dept;
}
set
{
item_dept=value;
}
}
 
private System.String item_class;
 
public System.String ITEM_CLASS
{
get
{
return item_class;
}
set
{
item_class=value;
}
}
 
private System.String item_subclass;
 
public System.String ITEM_SUBCLASS
{
get
{
return item_subclass;
}
set
{
item_subclass=value;
}
}
 
private System.String item_vendor;
 
public System.String ITEM_VENDOR
{
get
{
return item_vendor;
}
set
{
item_vendor=value;
}
}
 
private System.String item_desc1;
 
public System.String ITEM_DESC1
{
get
{
return item_desc1;
}
set
{
item_desc1=value;
}
}
 
private System.String item_desc2;
 
public System.String ITEM_DESC2
{
get
{
return item_desc2;
}
set
{
item_desc2=value;
}
}
 
private System.String item_desc3;
 
public System.String ITEM_DESC3
{
get
{
return item_desc3;
}
set
{
item_desc3=value;
}
}
 
private System.String item_desc4;
 
public System.String ITEM_DESC4
{
get
{
return item_desc4;
}
set
{
item_desc4=value;
}
}
 
private System.String item_attr;
 
public System.String ITEM_ATTR
{
get
{
return item_attr;
}
set
{
item_attr=value;
}
}
 
private System.String item_size;
 
public System.String ITEM_SIZE
{
get
{
return item_size;
}
set
{
item_size=value;
}
}
 
private System.String item_udf1;
 
public System.String ITEM_UDF1
{
get
{
return item_udf1;
}
set
{
item_udf1=value;
}
}
 
private System.String item_udf2;
 
public System.String ITEM_UDF2
{
get
{
return item_udf2;
}
set
{
item_udf2=value;
}
}
 
private System.String item_udf3;
 
public System.String ITEM_UDF3
{
get
{
return item_udf3;
}
set
{
item_udf3=value;
}
}
 
private System.String item_udf4;
 
public System.String ITEM_UDF4
{
get
{
return item_udf4;
}
set
{
item_udf4=value;
}
}
 
private System.String item_aux1;
 
public System.String ITEM_AUX1
{
get
{
return item_aux1;
}
set
{
item_aux1=value;
}
}
 
private System.String item_aux2;
 
public System.String ITEM_AUX2
{
get
{
return item_aux2;
}
set
{
item_aux2=value;
}
}
 
private System.String item_aux3;
 
public System.String ITEM_AUX3
{
get
{
return item_aux3;
}
set
{
item_aux3=value;
}
}
 
private System.String item_aux4;
 
public System.String ITEM_AUX4
{
get
{
return item_aux4;
}
set
{
item_aux4=value;
}
}
 
private System.String item_aux5;
 
public System.String ITEM_AUX5
{
get
{
return item_aux5;
}
set
{
item_aux5=value;
}
}
 
private System.String item_aux6;
 
public System.String ITEM_AUX6
{
get
{
return item_aux6;
}
set
{
item_aux6=value;
}
}
 
private System.String item_aux7;
 
public System.String ITEM_AUX7
{
get
{
return item_aux7;
}
set
{
item_aux7=value;
}
}
 
private System.String item_aux8;
 
public System.String ITEM_AUX8
{
get
{
return item_aux8;
}
set
{
item_aux8=value;
}
}
 
private System.String item_udfname;
 
public System.String ITEM_UDFNAME
{
get
{
return item_udfname;
}
set
{
item_udfname=value;
}
}
 
private System.DateTime item_udfdate;
 
public System.DateTime ITEM_UDFDATE
{
get
{
return item_udfdate;
}
set
{
item_udfdate=value;
}
}
 
private System.DateTime item_firstreceived;
 
public System.DateTime ITEM_FIRSTRECEIVED
{
get
{
return item_firstreceived;
}
set
{
item_firstreceived=value;
}
}
 
private System.DateTime item_lastreceived;
 
public System.DateTime ITEM_LASTRECEIVED
{
get
{
return item_lastreceived;
}
set
{
item_lastreceived=value;
}
}
 
private System.DateTime item_lastsold;
 
public System.DateTime ITEM_LASTSOLD
{
get
{
return item_lastsold;
}
set
{
item_lastsold=value;
}
}
 
private System.Int32 item_storeqty1;
 
public System.Int32 ITEM_STOREQTY1
{
get
{
return item_storeqty1;
}
set
{
item_storeqty1=value;
}
}
 
private System.Int32 item_storeqty2;
 
public System.Int32 ITEM_STOREQTY2
{
get
{
return item_storeqty2;
}
set
{
item_storeqty2=value;
}
}
 
private System.Int32 item_storeqty3;
 
public System.Int32 ITEM_STOREQTY3
{
get
{
return item_storeqty3;
}
set
{
item_storeqty3=value;
}
}
 
private System.Int32 item_storeqty4;
 
public System.Int32 ITEM_STOREQTY4
{
get
{
return item_storeqty4;
}
set
{
item_storeqty4=value;
}
}
 
private System.Int32 item_storeqty5;
 
public System.Int32 ITEM_STOREQTY5
{
get
{
return item_storeqty5;
}
set
{
item_storeqty5=value;
}
}
 
private System.Int32 item_storeqty6;
 
public System.Int32 ITEM_STOREQTY6
{
get
{
return item_storeqty6;
}
set
{
item_storeqty6=value;
}
}
 
private System.String item_taxcode;
 
public System.String ITEM_TAXCODE
{
get
{
return item_taxcode;
}
set
{
item_taxcode=value;
}
}
 
private System.Decimal item_p$;
 
public System.Decimal ITEM_P$
{
get
{
return item_p$;
}
set
{
item_p$=value;
}
}
 
private System.Decimal item_t$;
 
public System.Decimal ITEM_T$
{
get
{
return item_t$;
}
set
{
item_t$=value;
}
}
 
private System.Decimal item_c$;
 
public System.Decimal ITEM_C$
{
get
{
return item_c$;
}
set
{
item_c$=value;
}
}
 
private System.String item_pricelevels;
 
public System.String ITEM_PRICELEVELS
{
get
{
return item_pricelevels;
}
set
{
item_pricelevels=value;
}
}
 
private System.Decimal item_spif;
 
public System.Decimal ITEM_SPIF
{
get
{
return item_spif;
}
set
{
item_spif=value;
}
}
 
private System.Decimal item_foc$;
 
public System.Decimal ITEM_FOC$
{
get
{
return item_foc$;
}
set
{
item_foc$=value;
}
}
 
private System.DateTime item_lastedit;
 
public System.DateTime ITEM_LASTEDIT
{
get
{
return item_lastedit;
}
set
{
item_lastedit=value;
}
}
 
private System.Decimal pricelevel_1;
 
public System.Decimal PRICELEVEL_1
{
get
{
return pricelevel_1;
}
set
{
pricelevel_1=value;
}
}
 
private System.Decimal pricelevel_2;
 
public System.Decimal PRICELEVEL_2
{
get
{
return pricelevel_2;
}
set
{
pricelevel_2=value;
}
}
 
private System.Decimal pricelevel_3;
 
public System.Decimal PRICELEVEL_3
{
get
{
return pricelevel_3;
}
set
{
pricelevel_3=value;
}
}
 
private System.Decimal pricelevel_4;
 
public System.Decimal PRICELEVEL_4
{
get
{
return pricelevel_4;
}
set
{
pricelevel_4=value;
}
}
 
private System.Decimal pricelevel_5;
 
public System.Decimal PRICELEVEL_5
{
get
{
return pricelevel_5;
}
set
{
pricelevel_5=value;
}
}
 
private System.Decimal pricelevel_6;
 
public System.Decimal PRICELEVEL_6
{
get
{
return pricelevel_6;
}
set
{
pricelevel_6=value;
}
}
 
private System.Decimal pricelevel_7;
 
public System.Decimal PRICELEVEL_7
{
get
{
return pricelevel_7;
}
set
{
pricelevel_7=value;
}
}
 
private System.Decimal pricelevel_8;
 
public System.Decimal PRICELEVEL_8
{
get
{
return pricelevel_8;
}
set
{
pricelevel_8=value;
}
}
 
private System.Decimal pricelevel_9;
 
public System.Decimal PRICELEVEL_9
{
get
{
return pricelevel_9;
}
set
{
pricelevel_9=value;
}
}
 
private System.Decimal pricelevel_10;
 
public System.Decimal PRICELEVEL_10
{
get
{
return pricelevel_10;
}
set
{
pricelevel_10=value;
}
}
 
private System.Decimal pricelevel_11;
 
public System.Decimal PRICELEVEL_11
{
get
{
return pricelevel_11;
}
set
{
pricelevel_11=value;
}
}
 
private System.Decimal pricelevel_12;
 
public System.Decimal PRICELEVEL_12
{
get
{
return pricelevel_12;
}
set
{
pricelevel_12=value;
}
}
 
private System.Decimal pricelevel_13;
 
public System.Decimal PRICELEVEL_13
{
get
{
return pricelevel_13;
}
set
{
pricelevel_13=value;
}
}
 
private System.Decimal pricelevel_14;
 
public System.Decimal PRICELEVEL_14
{
get
{
return pricelevel_14;
}
set
{
pricelevel_14=value;
}
}
 
private System.Decimal pricelevel_15;
 
public System.Decimal PRICELEVEL_15
{
get
{
return pricelevel_15;
}
set
{
pricelevel_15=value;
}
}
 
private System.Decimal pricelevel_16;
 
public System.Decimal PRICELEVEL_16
{
get
{
return pricelevel_16;
}
set
{
pricelevel_16=value;
}
}
 
private System.Decimal pricelevel_17;
 
public System.Decimal PRICELEVEL_17
{
get
{
return pricelevel_17;
}
set
{
pricelevel_17=value;
}
}
 
private System.Decimal pricelevel_18;
 
public System.Decimal PRICELEVEL_18
{
get
{
return pricelevel_18;
}
set
{
pricelevel_18=value;
}
}
 
private System.Decimal pricelevel_19;
 
public System.Decimal PRICELEVEL_19
{
get
{
return pricelevel_19;
}
set
{
pricelevel_19=value;
}
}
 
private System.Decimal pricelevel_20;
 
public System.Decimal PRICELEVEL_20
{
get
{
return pricelevel_20;
}
set
{
pricelevel_20=value;
}
}
 
 
public void New()
{
item_id = 0;
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
// INSERT INTO tb_Items(item_id,item_sid,item_stylesid,item_number,item_upc,item_alu,item_dcs,item_dept,item_class,item_subClass,item_vendor,item_desc1,item_desc2,item_desc3,item_desc4,item_attr,item_size,item_udf1,item_udf2,item_udf3,item_udf4,item_aux1,item_aux2,item_aux3,item_aux4,item_aux5,item_aux6,item_aux7,item_aux8,item_udfname,item_udfdate,item_firstreceived,item_lastreceived,item_lastsold,item_storeqty1,item_storeqty2,item_storeqty3,item_storeqty4,item_storeqty5,item_storeqty6,item_taxcode,item_p$,item_t$,item_c$,item_pricelevels,item_spif,item_foc$,item_lastedit,PriceLevel_1,PriceLevel_2,PriceLevel_3,PriceLevel_4,PriceLevel_5,PriceLevel_6,PriceLevel_7,PriceLevel_8,PriceLevel_9,PriceLevel_10,PriceLevel_11,PriceLevel_12,PriceLevel_13,PriceLevel_14,PriceLevel_15,PriceLevel_16,PriceLevel_17,PriceLevel_18,PriceLevel_19,PriceLevel_20 ) VALUES(item_id,item_sid,item_stylesid,item_number,item_upc,item_alu,item_dcs,item_dept,item_class,item_subclass,item_vendor,item_desc1,item_desc2,item_desc3,item_desc4,item_attr,item_size,item_udf1,item_udf2,item_udf3,item_udf4,item_aux1,item_aux2,item_aux3,item_aux4,item_aux5,item_aux6,item_aux7,item_aux8,item_udfname,item_udfdate,item_firstreceived,item_lastreceived,item_lastsold,item_storeqty1,item_storeqty2,item_storeqty3,item_storeqty4,item_storeqty5,item_storeqty6,item_taxcode,item_p$,item_t$,item_c$,item_pricelevels,item_spif,item_foc$,item_lastedit,pricelevel_1,pricelevel_2,pricelevel_3,pricelevel_4,pricelevel_5,pricelevel_6,pricelevel_7,pricelevel_8,pricelevel_9,pricelevel_10,pricelevel_11,pricelevel_12,pricelevel_13,pricelevel_14,pricelevel_15,pricelevel_16,pricelevel_17,pricelevel_18,pricelevel_19,pricelevel_20 );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO tb_Items(item_sid,item_stylesid,item_number,item_upc,item_alu,item_dcs,item_dept,item_class,item_subClass,item_vendor,item_desc1,item_desc2,item_desc3,item_desc4,item_attr,item_size,item_udf1,item_udf2,item_udf3,item_udf4,item_aux1,item_aux2,item_aux3,item_aux4,item_aux5,item_aux6,item_aux7,item_aux8,item_udfname,item_udfdate,item_firstreceived,item_lastreceived,item_lastsold,item_storeqty1,item_storeqty2,item_storeqty3,item_storeqty4,item_storeqty5,item_storeqty6,item_taxcode,item_p$,item_t$,item_c$,item_pricelevels,item_spif,item_foc$,item_lastedit,PriceLevel_1,PriceLevel_2,PriceLevel_3,PriceLevel_4,PriceLevel_5,PriceLevel_6,PriceLevel_7,PriceLevel_8,PriceLevel_9,PriceLevel_10,PriceLevel_11,PriceLevel_12,PriceLevel_13,PriceLevel_14,PriceLevel_15,PriceLevel_16,PriceLevel_17,PriceLevel_18,PriceLevel_19,PriceLevel_20 ) VALUES("+(char)39+item_sid.ToString()+(char)39+(char)44+(char)39+item_stylesid.ToString()+(char)39+(char)44+item_number.ToString()+(char)44+(char)39+item_upc.ToString()+(char)39+(char)44+(char)39+item_alu.ToString()+(char)39+(char)44+(char)39+item_dcs.ToString()+(char)39+(char)44+(char)39+item_dept.ToString()+(char)39+(char)44+(char)39+item_class.ToString()+(char)39+(char)44+(char)39+item_subclass.ToString()+(char)39+(char)44+(char)39+item_vendor.ToString()+(char)39+(char)44+(char)39+item_desc1.ToString()+(char)39+(char)44+(char)39+item_desc2.ToString()+(char)39+(char)44+(char)39+item_desc3.ToString()+(char)39+(char)44+(char)39+item_desc4.ToString()+(char)39+(char)44+(char)39+item_attr.ToString()+(char)39+(char)44+(char)39+item_size.ToString()+(char)39+(char)44+(char)39+item_udf1.ToString()+(char)39+(char)44+(char)39+item_udf2.ToString()+(char)39+(char)44+(char)39+item_udf3.ToString()+(char)39+(char)44+(char)39+item_udf4.ToString()+(char)39+(char)44+(char)39+item_aux1.ToString()+(char)39+(char)44+(char)39+item_aux2.ToString()+(char)39+(char)44+(char)39+item_aux3.ToString()+(char)39+(char)44+(char)39+item_aux4.ToString()+(char)39+(char)44+(char)39+item_aux5.ToString()+(char)39+(char)44+(char)39+item_aux6.ToString()+(char)39+(char)44+(char)39+item_aux7.ToString()+(char)39+(char)44+(char)39+item_aux8.ToString()+(char)39+(char)44+(char)39+item_udfname.ToString()+(char)39+(char)44+(char)39+item_udfdate.ToString()+(char)39+(char)44+(char)39+item_firstreceived.ToString()+(char)39+(char)44+(char)39+item_lastreceived.ToString()+(char)39+(char)44+(char)39+item_lastsold.ToString()+(char)39+(char)44+item_storeqty1.ToString()+(char)44+item_storeqty2.ToString()+(char)44+item_storeqty3.ToString()+(char)44+item_storeqty4.ToString()+(char)44+item_storeqty5.ToString()+(char)44+item_storeqty6.ToString()+(char)44+(char)39+item_taxcode.ToString()+(char)39+(char)44+item_p$.ToString()+(char)44+item_t$.ToString()+(char)44+item_c$.ToString()+(char)44+(char)39+item_pricelevels.ToString()+(char)39+(char)44+item_spif.ToString()+(char)44+item_foc$.ToString()+(char)44+(char)39+item_lastedit.ToString()+(char)39+(char)44+pricelevel_1.ToString()+(char)44+pricelevel_2.ToString()+(char)44+pricelevel_3.ToString()+(char)44+pricelevel_4.ToString()+(char)44+pricelevel_5.ToString()+(char)44+pricelevel_6.ToString()+(char)44+pricelevel_7.ToString()+(char)44+pricelevel_8.ToString()+(char)44+pricelevel_9.ToString()+(char)44+pricelevel_10.ToString()+(char)44+pricelevel_11.ToString()+(char)44+pricelevel_12.ToString()+(char)44+pricelevel_13.ToString()+(char)44+pricelevel_14.ToString()+(char)44+pricelevel_15.ToString()+(char)44+pricelevel_16.ToString()+(char)44+pricelevel_17.ToString()+(char)44+pricelevel_18.ToString()+(char)44+pricelevel_19.ToString()+(char)44+pricelevel_20.ToString()+(char)41;
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
public bool Save(itemsPL _itemsPL)
{
bool tmp = false;
int res = -1;
_itemsPL.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_itemsPL db_itemsPL = new DB_itemsPL();
if (_itemsPL.IDITEMSPL == 0)
{
res = db_itemsPL.Add(_itemsPL, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_itemsPL.Update(_itemsPL, conn, tran);
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
string mupdate = "UPDATE tb_Items SET "+"item_sid="+(char)39+item_sid.ToString()+(char)39+(char)44+"item_stylesid="+(char)39+item_stylesid.ToString()+(char)39+(char)44+"item_number="+item_number.ToString()+(char)44+"item_upc="+(char)39+item_upc.ToString()+(char)39+(char)44+"item_alu="+(char)39+item_alu.ToString()+(char)39+(char)44+"item_dcs="+(char)39+item_dcs.ToString()+(char)39+(char)44+"item_dept="+(char)39+item_dept.ToString()+(char)39+(char)44+"item_class="+(char)39+item_class.ToString()+(char)39+(char)44+"item_subClass="+(char)39+item_subclass.ToString()+(char)39+(char)44+"item_vendor="+(char)39+item_vendor.ToString()+(char)39+(char)44+"item_desc1="+(char)39+item_desc1.ToString()+(char)39+(char)44+"item_desc2="+(char)39+item_desc2.ToString()+(char)39+(char)44+"item_desc3="+(char)39+item_desc3.ToString()+(char)39+(char)44+"item_desc4="+(char)39+item_desc4.ToString()+(char)39+(char)44+"item_attr="+(char)39+item_attr.ToString()+(char)39+(char)44+"item_size="+(char)39+item_size.ToString()+(char)39+(char)44+"item_udf1="+(char)39+item_udf1.ToString()+(char)39+(char)44+"item_udf2="+(char)39+item_udf2.ToString()+(char)39+(char)44+"item_udf3="+(char)39+item_udf3.ToString()+(char)39+(char)44+"item_udf4="+(char)39+item_udf4.ToString()+(char)39+(char)44+"item_aux1="+(char)39+item_aux1.ToString()+(char)39+(char)44+"item_aux2="+(char)39+item_aux2.ToString()+(char)39+(char)44+"item_aux3="+(char)39+item_aux3.ToString()+(char)39+(char)44+"item_aux4="+(char)39+item_aux4.ToString()+(char)39+(char)44+"item_aux5="+(char)39+item_aux5.ToString()+(char)39+(char)44+"item_aux6="+(char)39+item_aux6.ToString()+(char)39+(char)44+"item_aux7="+(char)39+item_aux7.ToString()+(char)39+(char)44+"item_aux8="+(char)39+item_aux8.ToString()+(char)39+(char)44+"item_udfname="+(char)39+item_udfname.ToString()+(char)39+(char)44+"item_udfdate="+(char)39+item_udfdate.ToString()+(char)39+(char)44+"item_firstreceived="+(char)39+item_firstreceived.ToString()+(char)39+(char)44+"item_lastreceived="+(char)39+item_lastreceived.ToString()+(char)39+(char)44+"item_lastsold="+(char)39+item_lastsold.ToString()+(char)39+(char)44+"item_storeqty1="+item_storeqty1.ToString()+(char)44+"item_storeqty2="+item_storeqty2.ToString()+(char)44+"item_storeqty3="+item_storeqty3.ToString()+(char)44+"item_storeqty4="+item_storeqty4.ToString()+(char)44+"item_storeqty5="+item_storeqty5.ToString()+(char)44+"item_storeqty6="+item_storeqty6.ToString()+(char)44+"item_taxcode="+(char)39+item_taxcode.ToString()+(char)39+(char)44+"item_p$="+item_p$.ToString()+(char)44+"item_t$="+item_t$.ToString()+(char)44+"item_c$="+item_c$.ToString()+(char)44+"item_pricelevels="+(char)39+item_pricelevels.ToString()+(char)39+(char)44+"item_spif="+item_spif.ToString()+(char)44+"item_foc$="+item_foc$.ToString()+(char)44+"item_lastedit="+(char)39+item_lastedit.ToString()+(char)39+(char)44+"PriceLevel_1="+pricelevel_1.ToString()+(char)44+"PriceLevel_2="+pricelevel_2.ToString()+(char)44+"PriceLevel_3="+pricelevel_3.ToString()+(char)44+"PriceLevel_4="+pricelevel_4.ToString()+(char)44+"PriceLevel_5="+pricelevel_5.ToString()+(char)44+"PriceLevel_6="+pricelevel_6.ToString()+(char)44+"PriceLevel_7="+pricelevel_7.ToString()+(char)44+"PriceLevel_8="+pricelevel_8.ToString()+(char)44+"PriceLevel_9="+pricelevel_9.ToString()+(char)44+"PriceLevel_10="+pricelevel_10.ToString()+(char)44+"PriceLevel_11="+pricelevel_11.ToString()+(char)44+"PriceLevel_12="+pricelevel_12.ToString()+(char)44+"PriceLevel_13="+pricelevel_13.ToString()+(char)44+"PriceLevel_14="+pricelevel_14.ToString()+(char)44+"PriceLevel_15="+pricelevel_15.ToString()+(char)44+"PriceLevel_16="+pricelevel_16.ToString()+(char)44+"PriceLevel_17="+pricelevel_17.ToString()+(char)44+"PriceLevel_18="+pricelevel_18.ToString()+(char)44+"PriceLevel_19="+pricelevel_19.ToString()+(char)44+"PriceLevel_20="+pricelevel_20.ToString()+" WHERE item_id="+item_id.ToString();
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
string del = "DELETE FROM tb_Items WHERE item_id="+item_id.ToString();
 // item_id=OldData[i].ToString() AND
 // item_sid=OldData[i].ToString() AND
 // item_stylesid=OldData[i].ToString() AND
 // item_number=OldData[i].ToString() AND
 // item_upc=OldData[i].ToString() AND
 // item_alu=OldData[i].ToString() AND
 // item_dcs=OldData[i].ToString() AND
 // item_dept=OldData[i].ToString() AND
 // item_class=OldData[i].ToString() AND
 // item_subClass=OldData[i].ToString() AND
 // item_vendor=OldData[i].ToString() AND
 // item_desc1=OldData[i].ToString() AND
 // item_desc2=OldData[i].ToString() AND
 // item_desc3=OldData[i].ToString() AND
 // item_desc4=OldData[i].ToString() AND
 // item_attr=OldData[i].ToString() AND
 // item_size=OldData[i].ToString() AND
 // item_udf1=OldData[i].ToString() AND
 // item_udf2=OldData[i].ToString() AND
 // item_udf3=OldData[i].ToString() AND
 // item_udf4=OldData[i].ToString() AND
 // item_aux1=OldData[i].ToString() AND
 // item_aux2=OldData[i].ToString() AND
 // item_aux3=OldData[i].ToString() AND
 // item_aux4=OldData[i].ToString() AND
 // item_aux5=OldData[i].ToString() AND
 // item_aux6=OldData[i].ToString() AND
 // item_aux7=OldData[i].ToString() AND
 // item_aux8=OldData[i].ToString() AND
 // item_udfname=OldData[i].ToString() AND
 // item_udfdate=OldData[i].ToString() AND
 // item_firstreceived=OldData[i].ToString() AND
 // item_lastreceived=OldData[i].ToString() AND
 // item_lastsold=OldData[i].ToString() AND
 // item_storeqty1=OldData[i].ToString() AND
 // item_storeqty2=OldData[i].ToString() AND
 // item_storeqty3=OldData[i].ToString() AND
 // item_storeqty4=OldData[i].ToString() AND
 // item_storeqty5=OldData[i].ToString() AND
 // item_storeqty6=OldData[i].ToString() AND
 // item_taxcode=OldData[i].ToString() AND
 // item_p$=OldData[i].ToString() AND
 // item_t$=OldData[i].ToString() AND
 // item_c$=OldData[i].ToString() AND
 // item_pricelevels=OldData[i].ToString() AND
 // item_spif=OldData[i].ToString() AND
 // item_foc$=OldData[i].ToString() AND
 // item_lastedit=OldData[i].ToString() AND
 // PriceLevel_1=OldData[i].ToString() AND
 // PriceLevel_2=OldData[i].ToString() AND
 // PriceLevel_3=OldData[i].ToString() AND
 // PriceLevel_4=OldData[i].ToString() AND
 // PriceLevel_5=OldData[i].ToString() AND
 // PriceLevel_6=OldData[i].ToString() AND
 // PriceLevel_7=OldData[i].ToString() AND
 // PriceLevel_8=OldData[i].ToString() AND
 // PriceLevel_9=OldData[i].ToString() AND
 // PriceLevel_10=OldData[i].ToString() AND
 // PriceLevel_11=OldData[i].ToString() AND
 // PriceLevel_12=OldData[i].ToString() AND
 // PriceLevel_13=OldData[i].ToString() AND
 // PriceLevel_14=OldData[i].ToString() AND
 // PriceLevel_15=OldData[i].ToString() AND
 // PriceLevel_16=OldData[i].ToString() AND
 // PriceLevel_17=OldData[i].ToString() AND
 // PriceLevel_18=OldData[i].ToString() AND
 // PriceLevel_19=OldData[i].ToString() AND
 // PriceLevel_20=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM tb_Items " +SearchExp;
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
string alistsearch = "SELECT * FROM tb_Items";
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
string dtsearch = "SELECT * FROM tb_Items " +SearchExp;
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
string dtsearch = "SELECT * FROM tb_Items";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
