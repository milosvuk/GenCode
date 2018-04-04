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
 
public class documentsb
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public documentsb()
{
 
  
 
}
 
public documentsb (System.Int32 _idrecdocument,System.Int32 _idproperty,System.String _description,System.String _typeofdoc,System.Byte[] _docinbinformat,System.String _keyword1,System.String _keyword2,System.String _keyword3,System.Int32 _idcompany )
{
idrecdocument=_idrecdocument;
idproperty=_idproperty;
description=_description;
typeofdoc=_typeofdoc;
docinbinformat=_docinbinformat;
keyword1=_keyword1;
keyword2=_keyword2;
keyword3=_keyword3;
idcompany=_idcompany;
}
 
 
private System.Int32 idrecdocument;
 
public System.Int32 IDRECDOCUMENT
{
get
{
return idrecdocument;
}
set
{
idrecdocument=value;
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
 
private System.String typeofdoc;
 
public System.String TYPEOFDOC
{
get
{
return typeofdoc;
}
set
{
typeofdoc=value;
}
}
 
private System.Byte[] docinbinformat;
 
public System.Byte[] DOCINBINFORMAT
{
get
{
return docinbinformat;
}
set
{
docinbinformat=value;
}
}
 
private System.String keyword1;
 
public System.String KEYWORD1
{
get
{
return keyword1;
}
set
{
keyword1=value;
}
}
 
private System.String keyword2;
 
public System.String KEYWORD2
{
get
{
return keyword2;
}
set
{
keyword2=value;
}
}
 
private System.String keyword3;
 
public System.String KEYWORD3
{
get
{
return keyword3;
}
set
{
keyword3=value;
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
idrecdocument = 0;
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
// INSERT INTO documentsb(idRecDocument,idProperty,Description,TypeOfDoc,DocInBinFormat,Keyword1,Keyword2,Keyword3,IdCompany ) VALUES(idrecdocument,idproperty,description,typeofdoc,docinbinformat,keyword1,keyword2,keyword3,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO documentsb(idProperty,Description,TypeOfDoc,DocInBinFormat,Keyword1,Keyword2,Keyword3,IdCompany ) VALUES("+idproperty.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+(char)39+typeofdoc.ToString()+(char)39+(char)44+(char)39+docinbinformat.ToString()+(char)39+(char)44+(char)39+keyword1.ToString()+(char)39+(char)44+(char)39+keyword2.ToString()+(char)39+(char)44+(char)39+keyword3.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(documentsb _documentsb)
{
bool tmp = false;
int res = -1;
_documentsb.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_documentsb db_documentsb = new DB_documentsb();
if (_documentsb.IDDOCUMENTSB == 0)
{
res = db_documentsb.Add(_documentsb, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_documentsb.Update(_documentsb, conn, tran);
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
string mupdate = "UPDATE documentsb SET "+"idProperty="+idproperty.ToString()+(char)44+"Description="+(char)39+description.ToString()+(char)39+(char)44+"TypeOfDoc="+(char)39+typeofdoc.ToString()+(char)39+(char)44+"DocInBinFormat="+(char)39+docinbinformat.ToString()+(char)39+(char)44+"Keyword1="+(char)39+keyword1.ToString()+(char)39+(char)44+"Keyword2="+(char)39+keyword2.ToString()+(char)39+(char)44+"Keyword3="+(char)39+keyword3.ToString()+(char)39+(char)44+"IdCompany="+idcompany.ToString()+" WHERE idRecDocument="+idrecdocument.ToString();
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
string del = "DELETE FROM documentsb WHERE idRecDocument="+idrecdocument.ToString();
 // idRecDocument=OldData[i].ToString() AND
 // idProperty=OldData[i].ToString() AND
 // Description=OldData[i].ToString() AND
 // TypeOfDoc=OldData[i].ToString() AND
 // DocInBinFormat=OldData[i].ToString() AND
 // Keyword1=OldData[i].ToString() AND
 // Keyword2=OldData[i].ToString() AND
 // Keyword3=OldData[i].ToString() AND
 // IdCompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM documentsb " +SearchExp;
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
string alistsearch = "SELECT * FROM documentsb";
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
string dtsearch = "SELECT * FROM documentsb " +SearchExp;
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
string dtsearch = "SELECT * FROM documentsb";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
