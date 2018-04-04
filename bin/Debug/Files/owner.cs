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
 
public class owner
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public owner()
{
 
  
 
}
 
public owner (System.Int32 _idowner,System.String _ownercode,System.String _ownerfullname,System.String _address,System.String _contact,System.String _comment,System.Int32 _active )
{
idowner=_idowner;
ownercode=_ownercode;
ownerfullname=_ownerfullname;
address=_address;
contact=_contact;
comment=_comment;
active=_active;
}
 
 
private System.Int32 idowner;
 
public System.Int32 IDOWNER
{
get
{
return idowner;
}
set
{
idowner=value;
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
 
private System.String address;
 
public System.String ADDRESS
{
get
{
return address;
}
set
{
address=value;
}
}
 
private System.String contact;
 
public System.String CONTACT
{
get
{
return contact;
}
set
{
contact=value;
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
idowner = 0;
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
// INSERT INTO owner(idOwner,OwnerCode,OwnerFullName,Address,Contact,Comment,Active ) VALUES(idowner,ownercode,ownerfullname,address,contact,comment,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO owner(OwnerCode,OwnerFullName,Address,Contact,Comment,Active ) VALUES("+(char)39+ownercode.ToString()+(char)39+(char)44+(char)39+ownerfullname.ToString()+(char)39+(char)44+(char)39+address.ToString()+(char)39+(char)44+(char)39+contact.ToString()+(char)39+(char)44+(char)39+comment.ToString()+(char)39+(char)44+active.ToString()+(char)41;
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
public bool Save(owner _owner)
{
bool tmp = false;
int res = -1;
_owner.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_owner db_owner = new DB_owner();
if (_owner.IDOWNER == 0)
{
res = db_owner.Add(_owner, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_owner.Update(_owner, conn, tran);
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
string mupdate = "UPDATE owner SET "+"OwnerCode="+(char)39+ownercode.ToString()+(char)39+(char)44+"OwnerFullName="+(char)39+ownerfullname.ToString()+(char)39+(char)44+"Address="+(char)39+address.ToString()+(char)39+(char)44+"Contact="+(char)39+contact.ToString()+(char)39+(char)44+"Comment="+(char)39+comment.ToString()+(char)39+(char)44+"Active="+active.ToString()+" WHERE idOwner="+idowner.ToString();
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
string del = "DELETE FROM owner WHERE idOwner="+idowner.ToString();
 // idOwner=OldData[i].ToString() AND
 // OwnerCode=OldData[i].ToString() AND
 // OwnerFullName=OldData[i].ToString() AND
 // Address=OldData[i].ToString() AND
 // Contact=OldData[i].ToString() AND
 // Comment=OldData[i].ToString() AND
 // Active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM owner " +SearchExp;
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
string alistsearch = "SELECT * FROM owner";
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
string dtsearch = "SELECT * FROM owner " +SearchExp;
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
string dtsearch = "SELECT * FROM owner";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
