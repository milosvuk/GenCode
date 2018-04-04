using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Text;
 
public class receivingitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public receivingitem()
{
 
  
 
}
 
public receivingitem (System.Int32 _idreceivingitem,System.Int32 _id_receiving,System.Int32 _id_item,System.Decimal _qty_item,System.Decimal _price_item,System.Decimal _total_price_item,System.Int32 _id_company )
{
idreceivingitem=_idreceivingitem;
id_receiving=_id_receiving;
id_item=_id_item;
qty_item=_qty_item;
price_item=_price_item;
total_price_item=_total_price_item;
id_company=_id_company;
}
 
 
private System.Int32 idreceivingitem;
 
public System.Int32 IDRECEIVINGITEM
{
get
{
return idreceivingitem;
}
set
{
idreceivingitem=value;
}
}
 
private System.Int32 id_receiving;
 
public System.Int32 ID_RECEIVING
{
get
{
return id_receiving;
}
set
{
id_receiving=value;
}
}
 
private System.Int32 id_item;
 
public System.Int32 ID_ITEM
{
get
{
return id_item;
}
set
{
id_item=value;
}
}
 
private System.Decimal qty_item;
 
public System.Decimal QTY_ITEM
{
get
{
return qty_item;
}
set
{
qty_item=value;
}
}
 
private System.Decimal price_item;
 
public System.Decimal PRICE_ITEM
{
get
{
return price_item;
}
set
{
price_item=value;
}
}
 
private System.Decimal total_price_item;
 
public System.Decimal TOTAL_PRICE_ITEM
{
get
{
return total_price_item;
}
set
{
total_price_item=value;
}
}
 
private System.Int32 id_company;
 
public System.Int32 ID_COMPANY
{
get
{
return id_company;
}
set
{
id_company=value;
}
}
 
 
public void New()
{
idreceivingitem = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
