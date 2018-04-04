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
 
public class docum
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public docum()
{
 
  
 
}
 
public docum (System.Int32 _iddocument,System.String _codeofdocument,System.String _nameofdocuments,System.Int32 _idcompany )
{
iddocument=_iddocument;
codeofdocument=_codeofdocument;
nameofdocuments=_nameofdocuments;
idcompany=_idcompany;
}
 
 
private System.Int32 iddocument;
 
public System.Int32 IDDOCUMENT
{
get
{
return iddocument;
}
set
{
iddocument=value;
}
}
 
private System.String codeofdocument;
 
public System.String CODEOFDOCUMENT
{
get
{
return codeofdocument;
}
set
{
codeofdocument=value;
}
}
 
private System.String nameofdocuments;
 
public System.String NAMEOFDOCUMENTS
{
get
{
return nameofdocuments;
}
set
{
nameofdocuments=value;
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
iddocument = 0;
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
// INSERT INTO docum(iddocument,codeofdocument,nameofdocuments,idcompany ) VALUES(iddocument,codeofdocument,nameofdocuments,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO docum(codeofdocument,nameofdocuments,idcompany ) VALUES("+(char)39+codeofdocument.ToString()+(char)39+(char)44+(char)39+nameofdocuments.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(docum _docum)
{
bool tmp = false;
int res = -1;
_docum.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_docum db_docum = new DB_docum();
if (_docum.IDDOCUM == 0)
{
res = db_docum.Add(_docum, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_docum.Update(_docum, conn, tran);
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
string mupdate = "UPDATE docum SET "+"codeofdocument="+(char)39+codeofdocument.ToString()+(char)39+(char)44+"nameofdocuments="+(char)39+nameofdocuments.ToString()+(char)39+(char)44+"idcompany="+idcompany.ToString()+" WHERE iddocument="+iddocument.ToString();
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
string del = "DELETE FROM docum WHERE iddocument="+iddocument.ToString();
 // iddocument=OldData[i].ToString() AND
 // codeofdocument=OldData[i].ToString() AND
 // nameofdocuments=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM docum " +SearchExp;
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
string alistsearch = "SELECT * FROM docum";
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
string dtsearch = "SELECT * FROM docum " +SearchExp;
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
string dtsearch = "SELECT * FROM docum";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
