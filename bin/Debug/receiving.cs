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
 
public class receiving
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public receiving()
{
 
  
 
}
 
public receiving (System.Int32 _idreceivedv,System.DateTime _dateofreceiving,System.DateTime _datetimeofreceving,System.Int32 _numofreceiving,System.Int32 _id_store,System.Int32 _id_user,System.Int32 _id_vendor,System.Decimal _amountofreceiving,System.Int32 _finalized,System.Int32 _id_company )
{
idreceivedv=_idreceivedv;
dateofreceiving=_dateofreceiving;
datetimeofreceving=_datetimeofreceving;
numofreceiving=_numofreceiving;
id_store=_id_store;
id_user=_id_user;
id_vendor=_id_vendor;
amountofreceiving=_amountofreceiving;
finalized=_finalized;
id_company=_id_company;
}
 
 
private System.Int32 idreceivedv;
 
public System.Int32 IDRECEIVEDV
{
get
{
return idreceivedv;
}
set
{
idreceivedv=value;
}
}
 
private System.DateTime dateofreceiving;
 
public System.DateTime DATEOFRECEIVING
{
get
{
return dateofreceiving;
}
set
{
dateofreceiving=value;
}
}
 
private System.DateTime datetimeofreceving;
 
public System.DateTime DATETIMEOFRECEVING
{
get
{
return datetimeofreceving;
}
set
{
datetimeofreceving=value;
}
}
 
private System.Int32 numofreceiving;
 
public System.Int32 NUMOFRECEIVING
{
get
{
return numofreceiving;
}
set
{
numofreceiving=value;
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
 
private System.Int32 id_vendor;
 
public System.Int32 ID_VENDOR
{
get
{
return id_vendor;
}
set
{
id_vendor=value;
}
}
 
private System.Decimal amountofreceiving;
 
public System.Decimal AMOUNTOFRECEIVING
{
get
{
return amountofreceiving;
}
set
{
amountofreceiving=value;
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
idreceivedv = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
