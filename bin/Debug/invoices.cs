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
 
public class invoices
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public invoices()
{
 
  
 
}
 
public invoices (System.Int32 _idinvoice,System.Int32 _id_customer,System.DateTime _dateofinvoice,System.DateTime _datetimeofinvoice,System.Int32 _numofinvoice,System.Int32 _typeofinvoice,System.Int32 _id_pos_ws,System.Int32 _id_store,System.Decimal _amountoftax,System.Decimal _amountofdisc,System.Decimal _amountofinvoice,System.Int32 _id_user,System.String _notes1,System.String _notes2,System.String _notes3,System.Int32 _finalized,System.Int32 _id_company )
{
idinvoice=_idinvoice;
id_customer=_id_customer;
dateofinvoice=_dateofinvoice;
datetimeofinvoice=_datetimeofinvoice;
numofinvoice=_numofinvoice;
typeofinvoice=_typeofinvoice;
id_pos_ws=_id_pos_ws;
id_store=_id_store;
amountoftax=_amountoftax;
amountofdisc=_amountofdisc;
amountofinvoice=_amountofinvoice;
id_user=_id_user;
notes1=_notes1;
notes2=_notes2;
notes3=_notes3;
finalized=_finalized;
id_company=_id_company;
}
 
 
private System.Int32 idinvoice;
 
public System.Int32 IDINVOICE
{
get
{
return idinvoice;
}
set
{
idinvoice=value;
}
}
 
private System.Int32 id_customer;
 
public System.Int32 ID_CUSTOMER
{
get
{
return id_customer;
}
set
{
id_customer=value;
}
}
 
private System.DateTime dateofinvoice;
 
public System.DateTime DATEOFINVOICE
{
get
{
return dateofinvoice;
}
set
{
dateofinvoice=value;
}
}
 
private System.DateTime datetimeofinvoice;
 
public System.DateTime DATETIMEOFINVOICE
{
get
{
return datetimeofinvoice;
}
set
{
datetimeofinvoice=value;
}
}
 
private System.Int32 numofinvoice;
 
public System.Int32 NUMOFINVOICE
{
get
{
return numofinvoice;
}
set
{
numofinvoice=value;
}
}
 
private System.Int32 typeofinvoice;
 
public System.Int32 TYPEOFINVOICE
{
get
{
return typeofinvoice;
}
set
{
typeofinvoice=value;
}
}
 
private System.Int32 id_pos_ws;
 
public System.Int32 ID_POS_WS
{
get
{
return id_pos_ws;
}
set
{
id_pos_ws=value;
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
 
private System.Decimal amountoftax;
 
public System.Decimal AMOUNTOFTAX
{
get
{
return amountoftax;
}
set
{
amountoftax=value;
}
}
 
private System.Decimal amountofdisc;
 
public System.Decimal AMOUNTOFDISC
{
get
{
return amountofdisc;
}
set
{
amountofdisc=value;
}
}
 
private System.Decimal amountofinvoice;
 
public System.Decimal AMOUNTOFINVOICE
{
get
{
return amountofinvoice;
}
set
{
amountofinvoice=value;
}
}
 
private System.Int32 id_user;
 
public System.Int32 ID_USER
{
get
{
return id_user;
}
set
{
id_user=value;
}
}
 
private System.String notes1;
 
public System.String NOTES1
{
get
{
return notes1;
}
set
{
notes1=value;
}
}
 
private System.String notes2;
 
public System.String NOTES2
{
get
{
return notes2;
}
set
{
notes2=value;
}
}
 
private System.String notes3;
 
public System.String NOTES3
{
get
{
return notes3;
}
set
{
notes3=value;
}
}
 
private System.Int32 finalized;
 
public System.Int32 FINALIZED
{
get
{
return finalized;
}
set
{
finalized=value;
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
idinvoice = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
