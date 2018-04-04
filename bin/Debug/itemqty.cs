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
 
public class itemqty
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public itemqty()
{
 
  
 
}
 
public itemqty (System.Int32 _idqtystore,System.Int32 _id_item,System.Int32 _id_store,System.Decimal _qty,System.Decimal _price,System.Int32 _id_company )
{
idqtystore=_idqtystore;
id_item=_id_item;
id_store=_id_store;
qty=_qty;
price=_price;
id_company=_id_company;
}
 
 
private System.Int32 idqtystore;
 
public System.Int32 IDQTYSTORE
{
get
{
return idqtystore;
}
set
{
idqtystore=value;
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
 
private System.Int32 id_store;
 
public System.Int32 ID_STORE
{
get
{
return id_store;
}
set
{
id_store=value;
}
}
 
private System.Decimal qty;
 
public System.Decimal QTY
{
get
{
return qty;
}
set
{
qty=value;
}
}
 
private System.Decimal price;
 
public System.Decimal PRICE
{
get
{
return price;
}
set
{
price=value;
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
idqtystore = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
