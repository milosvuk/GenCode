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
 
public class aquisition
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public aquisition()
{
 
  
 
}
 
public aquisition (System.Int32 _idrecaquisition,System.Int32 _idproperty,System.Int32 _fromowner,System.Int32 _toowner,System.Int32 _idnotary,System.DateTime _dateofaquisition,System.String _comment,System.Int32 _idcompany )
{
idrecaquisition=_idrecaquisition;
idproperty=_idproperty;
fromowner=_fromowner;
toowner=_toowner;
idnotary=_idnotary;
dateofaquisition=_dateofaquisition;
comment=_comment;
idcompany=_idcompany;
}
 
 
private System.Int32 idrecaquisition;
 
public System.Int32 IDRECAQUISITION
{
get
{
return idrecaquisition;
}
set
{
idrecaquisition=value;
}
}
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
}
}
 
private System.Int32 fromowner;
 
public System.Int32 FROMOWNER
{
get
{
return fromowner;
}
set
{
fromowner=value;
}
}
 
private System.Int32 toowner;
 
public System.Int32 TOOWNER
{
get
{
return toowner;
}
set
{
toowner=value;
}
}
 
private System.Int32 idnotary;
 
public System.Int32 IDNOTARY
{
get
{
return idnotary;
}
set
{
idnotary=value;
}
}
 
private System.DateTime dateofaquisition;
 
public System.DateTime DATEOFAQUISITION
{
get
{
return dateofaquisition;
}
set
{
dateofaquisition=value;
}
}
 
private System.String comment;
 
public System.String COMMENT
{
get
{
return comment;
}
set
{
comment=value;
}
}
 
private System.Int32 idcompany;
 
public System.Int32 IDCOMPANY
{
get
{
return idcompany;
}
set
{
idcompany=value;
}
}
 
 
public void New()
{
idrecaquisition = 0;
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
// INSERT INTO aquisition(idRecAquisition,idProperty,FromOwner,ToOwner,idNotary,Dateofaquisition,Comment,idCompany ) VALUES(idrecaquisition,idproperty,fromowner,toowner,idnotary,dateofaquisition,comment,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO aquisition(idProperty,FromOwner,ToOwner,idNotary,Dateofaquisition,Comment,idCompany ) VALUES("+idproperty.ToString()+(char)44+fromowner.ToString()+(char)44+toowner.ToString()+(char)44+idnotary.ToString()+(char)44+(char)39+dateofaquisition.ToString()+(char)39+(char)44+(char)39+comment.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(aquisition _aquisition)
{
bool tmp = false;
int res = -1;
_aquisition.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_aquisition db_aquisition = new DB_aquisition();
if (_aquisition.IDAQUISITION == 0)
{
res = db_aquisition.Add(_aquisition, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_aquisition.Update(_aquisition, conn, tran);
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
string mupdate = "UPDATE aquisition SET "+"idProperty="+idproperty.ToString()+(char)44+"FromOwner="+fromowner.ToString()+(char)44+"ToOwner="+toowner.ToString()+(char)44+"idNotary="+idnotary.ToString()+(char)44+"Dateofaquisition="+(char)39+dateofaquisition.ToString()+(char)39+(char)44+"Comment="+(char)39+comment.ToString()+(char)39+(char)44+"idCompany="+idcompany.ToString()+" WHERE idRecAquisition="+idrecaquisition.ToString();
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
string del = "DELETE FROM aquisition WHERE idRecAquisition="+idrecaquisition.ToString();
 // idRecAquisition=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // FromOwner=OldData[i].ToString() AND
 // ToOwner=OldData[i].ToString() AND
 // idNotary=OldData[i].ToString() AND
 // Dateofaquisition=OldData[i].ToString() AND
 // Comment=OldData[i].ToString() AND
 // idCompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM aquisition " +SearchExp;
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
string alistsearch = "SELECT * FROM aquisition";
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
string dtsearch = "SELECT * FROM aquisition " +SearchExp;
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
string dtsearch = "SELECT * FROM aquisition";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
