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
 
public class processdocuments
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public processdocuments()
{
 
  
 
}
 
public processdocuments (System.Int32 _idprojectprocessdocuments,System.Int32 _id_process,System.Int32 _id_documents,System.Int32 _id_company,System.Int32 _active )
{
idprojectprocessdocuments=_idprojectprocessdocuments;
id_process=_id_process;
id_documents=_id_documents;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idprojectprocessdocuments;
 
public System.Int32 IDPROJECTPROCESSDOCUMENTS
{
get
{
return idprojectprocessdocuments;
}
set
{
idprojectprocessdocuments=value;
}
}
 
private System.Int32 id_process;
 
public System.Int32 ID_PROCESS
{
get
{
return id_process;
}
set
{
id_process=value;
}
}
 
private System.Int32 id_documents;
 
public System.Int32 ID_DOCUMENTS
{
get
{
return id_documents;
}
set
{
id_documents=value;
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
idprojectprocessdocuments = 0;
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
// INSERT INTO processdocuments(idprojectprocessdocuments,id_process,id_documents,id_company,active ) VALUES(idprojectprocessdocuments,id_process,id_documents,id_company,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO processdocuments(id_process,id_documents,id_company,active ) VALUES("+id_process.ToString()+(char)44+id_documents.ToString()+(char)44+id_company.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(processdocuments _processdocuments)
{
bool tmp = false;
int res = -1;
_processdocuments.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_processdocuments db_processdocuments = new DB_processdocuments();
if (_processdocuments.IDPROCESSDOCUMENTS == 0)
{
res = db_processdocuments.Add(_processdocuments, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_processdocuments.Update(_processdocuments, conn, tran);
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
string mupdate = "UPDATE processdocuments SET "+"id_process="+id_process.ToString()+(char)44+"id_documents="+id_documents.ToString()+(char)44+"id_company="+id_company.ToString()+(char)44+"active="+active.ToString()+" WHERE idprojectprocessdocuments="+idprojectprocessdocuments.ToString();
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
string del = "DELETE FROM processdocuments WHERE idprojectprocessdocuments="+idprojectprocessdocuments.ToString();
 // idprojectprocessdocuments=OldData[i].ToString() AND
 // id_process=OldData[i].ToString() AND
 // id_documents=OldData[i].ToString() AND
 // id_company=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM processdocuments " +SearchExp;
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
string alistsearch = "SELECT * FROM processdocuments";
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
string dtsearch = "SELECT * FROM processdocuments " +SearchExp;
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
string dtsearch = "SELECT * FROM processdocuments";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
