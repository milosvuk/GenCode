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
 
public class process
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public process()
{
 
  
 
}
 
public process (System.Int32 _idprocess,System.Int32 _typeofprocess,System.String _id_location,System.String _id_entity,System.Decimal _qty,System.Decimal _valueperunit,System.Decimal _totalvalue,System.DateTime _dateofprocess,System.TimeSpan _timeofprocess,System.Int32 _weekofprocess,System.Int32 _monthofprocess,System.Int32 _yearofprocess,System.String _id_document,System.String _documentssource,System.String _filesource,System.String _description1,System.String _description2,System.String _id_relatedentity,System.Int32 _id_company )
{
idprocess=_idprocess;
typeofprocess=_typeofprocess;
id_location=_id_location;
id_entity=_id_entity;
qty=_qty;
valueperunit=_valueperunit;
totalvalue=_totalvalue;
dateofprocess=_dateofprocess;
timeofprocess=_timeofprocess;
weekofprocess=_weekofprocess;
monthofprocess=_monthofprocess;
yearofprocess=_yearofprocess;
id_document=_id_document;
documentssource=_documentssource;
filesource=_filesource;
description1=_description1;
description2=_description2;
id_relatedentity=_id_relatedentity;
id_company=_id_company;
}
 
 
private System.Int32 idprocess;
 
public System.Int32 IDPROCESS
{
get
{
return idprocess;
}
set
{
idprocess=value;
}
}
 
private System.Int32 typeofprocess;
 
public System.Int32 TYPEOFPROCESS
{
get
{
return typeofprocess;
}
set
{
typeofprocess=value;
}
}
 
private System.String id_location;
 
public System.String ID_LOCATION
{
get
{
return id_location;
}
set
{
id_location=value;
}
}
 
private System.String id_entity;
 
public System.String ID_ENTITY
{
get
{
return id_entity;
}
set
{
id_entity=value;
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
 
private System.Decimal valueperunit;
 
public System.Decimal VALUEPERUNIT
{
get
{
return valueperunit;
}
set
{
valueperunit=value;
}
}
 
private System.Decimal totalvalue;
 
public System.Decimal TOTALVALUE
{
get
{
return totalvalue;
}
set
{
totalvalue=value;
}
}
 
private System.DateTime dateofprocess;
 
public System.DateTime DATEOFPROCESS
{
get
{
return dateofprocess;
}
set
{
dateofprocess=value;
}
}
 
private System.TimeSpan timeofprocess;
 
public System.TimeSpan TIMEOFPROCESS
{
get
{
return timeofprocess;
}
set
{
timeofprocess=value;
}
}
 
private System.Int32 weekofprocess;
 
public System.Int32 WEEKOFPROCESS
{
get
{
return weekofprocess;
}
set
{
weekofprocess=value;
}
}
 
private System.Int32 monthofprocess;
 
public System.Int32 MONTHOFPROCESS
{
get
{
return monthofprocess;
}
set
{
monthofprocess=value;
}
}
 
private System.Int32 yearofprocess;
 
public System.Int32 YEAROFPROCESS
{
get
{
return yearofprocess;
}
set
{
yearofprocess=value;
}
}
 
private System.String id_document;
 
public System.String ID_DOCUMENT
{
get
{
return id_document;
}
set
{
id_document=value;
}
}
 
private System.String documentssource;
 
public System.String DOCUMENTSSOURCE
{
get
{
return documentssource;
}
set
{
documentssource=value;
}
}
 
private System.String filesource;
 
public System.String FILESOURCE
{
get
{
return filesource;
}
set
{
filesource=value;
}
}
 
private System.String description1;
 
public System.String DESCRIPTION1
{
get
{
return description1;
}
set
{
description1=value;
}
}
 
private System.String description2;
 
public System.String DESCRIPTION2
{
get
{
return description2;
}
set
{
description2=value;
}
}
 
private System.String id_relatedentity;
 
public System.String ID_RELATEDENTITY
{
get
{
return id_relatedentity;
}
set
{
id_relatedentity=value;
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
idprocess = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
