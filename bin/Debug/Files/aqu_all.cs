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
 
public class aqu_all
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public aqu_all()
{
 
  
 
}
 
public aqu_all (System.Int32 _idrecaquisition,System.Int32 _fromowner,System.Int32 _toowner,System.Int32 _idnotary,System.DateTime _dateofaquisition,System.String _comment,System.String _ownercode,System.String _ownerfullname,System.String _ownercodeto,System.String _ownernameto,System.String _notaryname,System.Int32 _idproperty,System.String _description )
{
idrecaquisition=_idrecaquisition;
fromowner=_fromowner;
toowner=_toowner;
idnotary=_idnotary;
dateofaquisition=_dateofaquisition;
comment=_comment;
ownercode=_ownercode;
ownerfullname=_ownerfullname;
ownercodeto=_ownercodeto;
ownernameto=_ownernameto;
notaryname=_notaryname;
idproperty=_idproperty;
description=_description;
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
 
private System.String ownercode;
 
public System.String OWNERCODE
{
get
{
return ownercode;
}
set
{
ownercode=value;
}
}
 
private System.String ownerfullname;
 
public System.String OWNERFULLNAME
{
get
{
return ownerfullname;
}
set
{
ownerfullname=value;
}
}
 
private System.String ownercodeto;
 
public System.String OWNERCODETO
{
get
{
return ownercodeto;
}
set
{
ownercodeto=value;
}
}
 
private System.String ownernameto;
 
public System.String OWNERNAMETO
{
get
{
return ownernameto;
}
set
{
ownernameto=value;
}
}
 
private System.String notaryname;
 
public System.String NOTARYNAME
{
get
{
return notaryname;
}
set
{
notaryname=value;
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
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
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
// INSERT INTO aqu_all(idRecAquisition,FromOwner,ToOwner,idNotary,Dateofaquisition,Comment,OwnerCode,OwnerFullName,OwnerCodeTo,OwnerNameTo,NotaryName,idProperty,Description ) VALUES(idrecaquisition,fromowner,toowner,idnotary,dateofaquisition,comment,ownercode,ownerfullname,ownercodeto,ownernameto,notaryname,idproperty,description );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO aqu_all(FromOwner,ToOwner,idNotary,Dateofaquisition,Comment,OwnerCode,OwnerFullName,OwnerCodeTo,OwnerNameTo,NotaryName,idProperty,Description ) VALUES("+fromowner.ToString()+(char)44+toowner.ToString()+(char)44+idnotary.ToString()+(char)44+(char)39+dateofaquisition.ToString()+(char)39+(char)44+(char)39+comment.ToString()+(char)39+(char)44+(char)39+ownercode.ToString()+(char)39+(char)44+(char)39+ownerfullname.ToString()+(char)39+(char)44+(char)39+ownercodeto.ToString()+(char)39+(char)44+(char)39+ownernameto.ToString()+(char)39+(char)44+(char)39+notaryname.ToString()+(char)39+(char)44+idproperty.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)41;
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
public bool Save(aqu_all _aqu_all)
{
bool tmp = false;
int res = -1;
_aqu_all.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_aqu_all db_aqu_all = new DB_aqu_all();
if (_aqu_all.IDAQU_ALL == 0)
{
res = db_aqu_all.Add(_aqu_all, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_aqu_all.Update(_aqu_all, conn, tran);
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
string mupdate = "UPDATE aqu_all SET "+"FromOwner="+fromowner.ToString()+(char)44+"ToOwner="+toowner.ToString()+(char)44+"idNotary="+idnotary.ToString()+(char)44+"Dateofaquisition="+(char)39+dateofaquisition.ToString()+(char)39+(char)44+"Comment="+(char)39+comment.ToString()+(char)39+(char)44+"OwnerCode="+(char)39+ownercode.ToString()+(char)39+(char)44+"OwnerFullName="+(char)39+ownerfullname.ToString()+(char)39+(char)44+"OwnerCodeTo="+(char)39+ownercodeto.ToString()+(char)39+(char)44+"OwnerNameTo="+(char)39+ownernameto.ToString()+(char)39+(char)44+"NotaryName="+(char)39+notaryname.ToString()+(char)39+(char)44+"idProperty="+idproperty.ToString()+(char)44+"Description="+(char)39+description.ToString()+(char)39+" WHERE idRecAquisition="+idrecaquisition.ToString();
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
string del = "DELETE FROM aqu_all WHERE idRecAquisition="+idrecaquisition.ToString();
 // idRecAquisition=OldData[i].ToString() AND
 // FromOwner=OldData[i].ToString() AND
 // ToOwner=OldData[i].ToString() AND
 // idNotary=OldData[i].ToString() AND
 // Dateofaquisition=OldData[i].ToString() AND
 // Comment=OldData[i].ToString() AND
 // OwnerCode=OldData[i].ToString() AND
 // OwnerFullName=OldData[i].ToString() AND
 // OwnerCodeTo=OldData[i].ToString() AND
 // OwnerNameTo=OldData[i].ToString() AND
 // NotaryName=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // Description=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM aqu_all " +SearchExp;
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
string alistsearch = "SELECT * FROM aqu_all";
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
string dtsearch = "SELECT * FROM aqu_all " +SearchExp;
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
string dtsearch = "SELECT * FROM aqu_all";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
