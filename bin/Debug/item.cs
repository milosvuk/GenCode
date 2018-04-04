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
 
public class item
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public item()
{
 
  
 
}
 
public item (System.Int32 _iditem,System.Int32 _numofitem,System.String _sidofitem,System.Int32 _id_dcs,System.String _dcs,System.Int32 _id_vendor,System.String _aluofitem,System.String _upcofitem,System.String _desc1ofitem,System.String _desc2ofitem,System.String _atrofitem,System.String _sizeofitem,System.Decimal _taxpercofitem,System.Decimal _costofitem,System.Decimal _priceofitem,System.String _imageofitem,System.DateTime _expirydate,System.Int32 _id_company )
{
iditem=_iditem;
numofitem=_numofitem;
sidofitem=_sidofitem;
id_dcs=_id_dcs;
dcs=_dcs;
id_vendor=_id_vendor;
aluofitem=_aluofitem;
upcofitem=_upcofitem;
desc1ofitem=_desc1ofitem;
desc2ofitem=_desc2ofitem;
atrofitem=_atrofitem;
sizeofitem=_sizeofitem;
taxpercofitem=_taxpercofitem;
costofitem=_costofitem;
priceofitem=_priceofitem;
imageofitem=_imageofitem;
expirydate=_expirydate;
id_company=_id_company;
}
 
 
private System.Int32 iditem;
 
public System.Int32 IDITEM
{
get
{
return iditem;
}
set
{
iditem=value;
}
}
 
private System.Int32 numofitem;
 
public System.Int32 NUMOFITEM
{
get
{
return numofitem;
}
set
{
numofitem=value;
}
}
 
private System.String sidofitem;
 
public System.String SIDOFITEM
{
get
{
return sidofitem;
}
set
{
sidofitem=value;
}
}
 
private System.Int32 id_dcs;
 
public System.Int32 ID_DCS
{
get
{
return id_dcs;
}
set
{
id_dcs=value;
}
}
 
private System.String dcs;
 
public System.String DCS
{
get
{
return dcs;
}
set
{
dcs=value;
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
 
private System.String aluofitem;
 
public System.String ALUOFITEM
{
get
{
return aluofitem;
}
set
{
aluofitem=value;
}
}
 
private System.String upcofitem;
 
public System.String UPCOFITEM
{
get
{
return upcofitem;
}
set
{
upcofitem=value;
}
}
 
private System.String desc1ofitem;
 
public System.String DESC1OFITEM
{
get
{
return desc1ofitem;
}
set
{
desc1ofitem=value;
}
}
 
private System.String desc2ofitem;
 
public System.String DESC2OFITEM
{
get
{
return desc2ofitem;
}
set
{
desc2ofitem=value;
}
}
 
private System.String atrofitem;
 
public System.String ATROFITEM
{
get
{
return atrofitem;
}
set
{
atrofitem=value;
}
}
 
private System.String sizeofitem;
 
public System.String SIZEOFITEM
{
get
{
return sizeofitem;
}
set
{
sizeofitem=value;
}
}
 
private System.Decimal taxpercofitem;
 
public System.Decimal TAXPERCOFITEM
{
get
{
return taxpercofitem;
}
set
{
taxpercofitem=value;
}
}
 
private System.Decimal costofitem;
 
public System.Decimal COSTOFITEM
{
get
{
return costofitem;
}
set
{
costofitem=value;
}
}
 
private System.Decimal priceofitem;
 
public System.Decimal PRICEOFITEM
{
get
{
return priceofitem;
}
set
{
priceofitem=value;
}
}
 
private System.String imageofitem;
 
public System.String IMAGEOFITEM
{
get
{
return imageofitem;
}
set
{
imageofitem=value;
}
}
 
private System.DateTime expirydate;
 
public System.DateTime EXPIRYDATE
{
get
{
return expirydate;
}
set
{
expirydate=value;
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
iditem = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
