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
 
public class linkprocessdocuments
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkprocessdocuments()
{
 
  
 
}
 
public linkprocessdocuments (System.Int32 _idprojectprocessdocuments,System.String _processname,System.String _documentname,System.Int32 _id_process,System.Int32 _id_documents )
{
idprojectprocessdocuments=_idprojectprocessdocuments;
processname=_processname;
documentname=_documentname;
id_process=_id_process;
id_documents=_id_documents;
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
 
private System.String processname;
 
public System.String PROCESSNAME
{
get
{
return processname;
}
set
{
processname=value;
}
}
 
private System.String documentname;
 
public System.String DOCUMENTNAME
{
get
{
return documentname;
}
set
{
documentname=value;
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
// INSERT INTO linkprocessdocuments(idprojectprocessdocuments,ProcessName,DocumentName,id_process,id_documents ) VALUES(idprojectprocessdocuments,processname,documentname,id_process,id_documents );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO linkprocessdocuments(ProcessName,DocumentName,id_process,id_documents ) VALUES("+(char)39+processname.ToString()+(char)39+(char)44+(char)39+documentname.ToString()+(char)39+(char)44+id_process.ToString()+(char)44+id_documents.ToString()+(char)41;
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
public bool Save(linkprocessdocuments _linkprocessdocuments)
{
bool tmp = false;
int res = -1;
_linkprocessdocuments.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_linkprocessdocuments db_linkprocessdocuments = new DB_linkprocessdocuments();
if (_linkprocessdocuments.IDLINKPROCESSDOCUMENTS == 0)
{
res = db_linkprocessdocuments.Add(_linkprocessdocuments, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_linkprocessdocuments.Update(_linkprocessdocuments, conn, tran);
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
string mupdate = "UPDATE linkprocessdocuments SET "+"ProcessName="+(char)39+processname.ToString()+(char)39+(char)44+"DocumentName="+(char)39+documentname.ToString()+(char)39+(char)44+"id_process="+id_process.ToString()+(char)44+"id_documents="+id_documents.ToString()+" WHERE idprojectprocessdocuments="+idprojectprocessdocuments.ToString();
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
string del = "DELETE FROM linkprocessdocuments WHERE idprojectprocessdocuments="+idprojectprocessdocuments.ToString();
 // idprojectprocessdocuments=OldData[i].ToString() AND
 // ProcessName=OldData[i].ToString() AND
 // DocumentName=OldData[i].ToString() AND
 // id_process=OldData[i].ToString() AND
 // id_documents=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM linkprocessdocuments " +SearchExp;
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
string alistsearch = "SELECT * FROM linkprocessdocuments";
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
string dtsearch = "SELECT * FROM linkprocessdocuments " +SearchExp;
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
string dtsearch = "SELECT * FROM linkprocessdocuments";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
