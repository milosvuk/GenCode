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
////==========================================================================
 
public int InsertCommand()
{
// Use this InsertCommand with PrimaryKey Field which is not AutoIncement;
int numberinsert=0;
// INSERT INTO sheduling(idsheduling,id_professional,id_seniorcitizen,id_services,dateofvisit,timeovisit,timeovisitdec,active ) VALUES(idsheduling,id_professional,id_seniorcitizen,id_services,dateofvisit,timeovisit,timeovisitdec,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO sheduling(id_professional,id_seniorcitizen,id_services,dateofvisit,timeovisit,timeovisitdec,active ) VALUES("+id_professional.ToString()+(char)44+id_seniorcitizen.ToString()+(char)44+id_services.ToString()+(char)44+(char)39+dateofvisit.ToString()+(char)39+(char)44+timeovisit.ToString()+(char)44+timeovisitdec.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(sheduling _sheduling)
{
bool tmp = false;
int res = -1;
_sheduling.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_sheduling db_sheduling = new DB_sheduling();
if (_sheduling.IDSHEDULING == 0)
{
res = db_sheduling.Add(_sheduling, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_sheduling.Update(_sheduling, conn, tran);
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
string mupdate = "UPDATE sheduling SET "+"id_professional="+id_professional.ToString()+(char)44+"id_seniorcitizen="+id_seniorcitizen.ToString()+(char)44+"id_services="+id_services.ToString()+(char)44+"dateofvisit="+(char)39+dateofvisit.ToString()+(char)39+(char)44+"timeovisit="+timeovisit.ToString()+(char)44+"timeovisitdec="+timeovisitdec.ToString()+(char)44+"active="+active.ToString()+" WHERE idsheduling="+idsheduling.ToString();
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
string del = "DELETE FROM sheduling WHERE idsheduling="+idsheduling.ToString();
 // idsheduling=OldData[i].ToString() AND
 // id_professional=OldData[i].ToString() AND
 // id_seniorcitizen=OldData[i].ToString() AND
 // id_services=OldData[i].ToString() AND
 // dateofvisit=OldData[i].ToString() AND
 // timeovisit=OldData[i].ToString() AND
 // timeovisitdec=OldData[i].ToString() AND
 // active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM sheduling " +SearchExp;
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
string alistsearch = "SELECT * FROM sheduling";
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
string dtsearch = "SELECT * FROM sheduling " +SearchExp;
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
string dtsearch = "SELECT * FROM sheduling";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
