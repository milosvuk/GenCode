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
 
public class objclassesfields
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public objclassesfields()
{
 
  
 
}
 
public objclassesfields (System.Int32 _idobjclassesfields,System.String _name,System.String _type,System.Int32 _id_objclasses,System.Int32 _idcompany,System.Int32 _active )
{
idobjclassesfields=_idobjclassesfields;
name=_name;
type=_type;
id_objclasses=_id_objclasses;
idcompany=_idcompany;
active=_active;
}
 
 
private System.Int32 idobjclassesfields;
 
public System.Int32 IDOBJCLASSESFIELDS
{
get
{
return idobjclassesfields;
}
set
{
idobjclassesfields=value;
}
}
 
private System.String name;
 
public System.String NAME
{
get
{
return name;
}
set
{
name=value;
}
}
 
private System.String type;
 
public System.String TYPE
{
get
{
return type;
}
set
{
type=value;
}
}
 
private System.Int32 id_objclasses;
 
public System.Int32 ID_OBJCLASSES
{
get
{
return id_objclasses;
}
set
{
id_objclasses=value;
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
idobjclassesfields = 0;
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
// INSERT INTO objclassesfields(idobjclassesfields,name,type,id_objclasses,idcompany,active ) VALUES(idobjclassesfields,name,type,id_objclasses,idcompany,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO objclassesfields(name,type,id_objclasses,idcompany,active ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+type.ToString()+(char)39+(char)44+id_objclasses.ToString()+(char)44+idcompany.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(objclassesfields _objclassesfields)
{
bool tmp = false;
int res = -1;
_objclassesfields.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_objclassesfields db_objclassesfields = new DB_objclassesfields();
if (_objclassesfields.IDOBJCLASSESFIELDS == 0)
{
res = db_objclassesfields.Add(_objclassesfields, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_objclassesfields.Update(_objclassesfields, conn, tran);
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
string mupdate = "UPDATE objclassesfields SET "+"name="+(char)39+name.ToString()+(char)39+(char)44+"type="+(char)39+type.ToString()+(char)39+(char)44+"id_objclasses="+id_objclasses.ToString()+(char)44+"idcompany="+idcompany.ToString()+(char)44+"active="+active.ToString()+" WHERE idobjclassesfields="+idobjclassesfields.ToString();
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
string del = "DELETE FROM objclassesfields WHERE idobjclassesfields="+idobjclassesfields.ToString();
 // idobjclassesfields=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // type=OldData[i].ToString() AND
 // id_objclasses=OldData[i].ToString() AND
 // idcompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM objclassesfields " +SearchExp;
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
string alistsearch = "SELECT * FROM objclassesfields";
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
string dtsearch = "SELECT * FROM objclassesfields " +SearchExp;
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
string dtsearch = "SELECT * FROM objclassesfields";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
