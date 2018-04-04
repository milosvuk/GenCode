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
 
public class entityitem
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public entityitem()
{
 
  
 
}
 
public entityitem (System.Int32 _idofentity,System.String _codeofentity,System.String _nameofentity,System.String _udf1,System.String _udf2,System.String _udf3,System.Int32 _idcompany )
{
idofentity=_idofentity;
codeofentity=_codeofentity;
nameofentity=_nameofentity;
udf1=_udf1;
udf2=_udf2;
udf3=_udf3;
idcompany=_idcompany;
}
 
 
private System.Int32 idofentity;
 
public System.Int32 IDOFENTITY
{
get
{
return idofentity;
}
set
{
idofentity=value;
}
}
 
private System.String codeofentity;
 
public System.String CODEOFENTITY
{
get
{
return codeofentity;
}
set
{
codeofentity=value;
}
}
 
private System.String nameofentity;
 
public System.String NAMEOFENTITY
{
get
{
return nameofentity;
}
set
{
nameofentity=value;
}
}
 
private System.String udf1;
 
public System.String UDF1
{
get
{
return udf1;
}
set
{
udf1=value;
}
}
 
private System.String udf2;
 
public System.String UDF2
{
get
{
return udf2;
}
set
{
udf2=value;
}
}
 
private System.String udf3;
 
public System.String UDF3
{
get
{
return udf3;
}
set
{
udf3=value;
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
idofentity = 0;
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
// INSERT INTO entityitem(idofentity,codeofentity,nameofentity,udf1,udf2,udf3,idcompany ) VALUES(idofentity,codeofentity,nameofentity,udf1,udf2,udf3,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO entityitem(codeofentity,nameofentity,udf1,udf2,udf3,idcompany ) VALUES("+(char)39+codeofentity.ToString()+(char)39+(char)44+(char)39+nameofentity.ToString()+(char)39+(char)44+(char)39+udf1.ToString()+(char)39+(char)44+(char)39+udf2.ToString()+(char)39+(char)44+(char)39+udf3.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(entityitem _entityitem)
{
bool tmp = false;
int res = -1;
_entityitem.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_entityitem db_entityitem = new DB_entityitem();
if (_entityitem.IDENTITYITEM == 0)
{
res = db_entityitem.Add(_entityitem, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_entityitem.Update(_entityitem, conn, tran);
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
string mupdate = "UPDATE entityitem SET "+"codeofentity="+(char)39+codeofentity.ToString()+(char)39+(char)44+"nameofentity="+(char)39+nameofentity.ToString()+(char)39+(char)44+"udf1="+(char)39+udf1.ToString()+(char)39+(char)44+"udf2="+(char)39+udf2.ToString()+(char)39+(char)44+"udf3="+(char)39+udf3.ToString()+(char)39+(char)44+"idcompany="+idcompany.ToString()+" WHERE idofentity="+idofentity.ToString();
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
string del = "DELETE FROM entityitem WHERE idofentity="+idofentity.ToString();
 // idofentity=OldData[i].ToString() AND
 // codeofentity=OldData[i].ToString() AND
 // nameofentity=OldData[i].ToString() AND
 // udf1=OldData[i].ToString() AND
 // udf2=OldData[i].ToString() AND
 // udf3=OldData[i].ToString() AND
 // idcompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM entityitem " +SearchExp;
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
string alistsearch = "SELECT * FROM entityitem";
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
string dtsearch = "SELECT * FROM entityitem " +SearchExp;
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
string dtsearch = "SELECT * FROM entityitem";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
