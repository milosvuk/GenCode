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
 
public class sheduling
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public sheduling()
{
 
  
 
}
 
public sheduling (System.Int32 _idsheduling,System.Int32 _id_professional,System.Int32 _id_seniorcitizen,System.Int32 _id_services,System.DateTime _dateofvisit,System.Int32 _timeovisit,System.Decimal _timeovisitdec,System.Int32 _active )
{
idsheduling=_idsheduling;
id_professional=_id_professional;
id_seniorcitizen=_id_seniorcitizen;
id_services=_id_services;
dateofvisit=_dateofvisit;
timeovisit=_timeovisit;
timeovisitdec=_timeovisitdec;
active=_active;
}
 
 
private System.Int32 idsheduling;
 
public System.Int32 IDSHEDULING
{
get
{
return idsheduling;
}
set
{
idsheduling=value;
}
}
 
private System.Int32 id_professional;
 
public System.Int32 ID_PROFESSIONAL
{
get
{
return id_professional;
}
set
{
id_professional=value;
}
}
 
private System.Int32 id_seniorcitizen;
 
public System.Int32 ID_SENIORCITIZEN
{
get
{
return id_seniorcitizen;
}
set
{
id_seniorcitizen=value;
}
}
 
private System.Int32 id_services;
 
public System.Int32 ID_SERVICES
{
get
{
return id_services;
}
set
{
id_services=value;
}
}
 
private System.DateTime dateofvisit;
 
public System.DateTime DATEOFVISIT
{
get
{
return dateofvisit;
}
set
{
dateofvisit=value;
}
}
 
private System.Int32 timeovisit;
 
public System.Int32 TIMEOVISIT
{
get
{
return timeovisit;
}
set
{
timeovisit=value;
}
}
 
private System.Decimal timeovisitdec;
 
public System.Decimal TIMEOVISITDEC
{
get
{
return timeovisitdec;
}
set
{
timeovisitdec=value;
}
}
 
private System.Int32 active;
 
public System.Int32 ACTIVE
{
get
{
return active;
}
set
{
active=value;
}
}
 
 
public void New()
{
idsheduling = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
