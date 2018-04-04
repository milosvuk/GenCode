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
 
public class invoiceitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public invoiceitem()
{
 
  
 
}
 
public invoiceitem (System.Int32 _id_invoice_item,System.Int32 _id_invoice,System.Int32 _id_item,System.Decimal _qty_item,System.Decimal _tax_item,System.Decimal _price_item,System.Decimal _disc_item,System.Decimal _total_tax_item,System.Decimal _total_disc_item,System.Decimal _total_price_item,System.Int32 _id_company )
{
id_invoice_item=_id_invoice_item;
id_invoice=_id_invoice;
id_item=_id_item;
qty_item=_qty_item;
tax_item=_tax_item;
price_item=_price_item;
disc_item=_disc_item;
total_tax_item=_total_tax_item;
total_disc_item=_total_disc_item;
total_price_item=_total_price_item;
id_company=_id_company;
}
 
 
private System.Int32 id_invoice_item;
 
public System.Int32 ID_INVOICE_ITEM
{
get
{
return id_invoice_item;
}
set
{
id_invoice_item=value;
}
}
 
private System.Int32 id_invoice;
 
public System.Int32 ID_INVOICE
{
get
{
return id_invoice;
}
set
{
id_invoice=value;
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
 
private System.Decimal tax_item;
 
public System.Decimal TAX_ITEM
{
get
{
return tax_item;
}
set
{
tax_item=value;
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
 
private System.Decimal disc_item;
 
public System.Decimal DISC_ITEM
{
get
{
return disc_item;
}
set
{
disc_item=value;
}
}
 
private System.Decimal total_tax_item;
 
public System.Decimal TOTAL_TAX_ITEM
{
get
{
return total_tax_item;
}
set
{
total_tax_item=value;
}
}
 
private System.Decimal total_disc_item;
 
public System.Decimal TOTAL_DISC_ITEM
{
get
{
return total_disc_item;
}
set
{
total_disc_item=value;
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
id_invoice_item = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
