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
 
public class linkinfoprocess
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public linkinfoprocess()
{
 
  
 
}
 
public linkinfoprocess (System.Int32 _idprojectprocessinfo,System.String _nameofinformation,System.String _nameofprocess,System.Int32 _id_info,System.Int32 _id_process )
{
idprojectprocessinfo=_idprojectprocessinfo;
nameofinformation=_nameofinformation;
nameofprocess=_nameofprocess;
id_info=_id_info;
id_process=_id_process;
}
 
 
private System.Int32 idprojectprocessinfo;
 
public System.Int32 IDPROJECTPROCESSINFO
{
get
{
return idprojectprocessinfo;
}
set
{
idprojectprocessinfo=value;
}
}
 
private System.String nameofinformation;
 
public System.String NAMEOFINFORMATION
{
get
{
return nameofinformation;
}
set
{
nameofinformation=value;
}
}
 
private System.String nameofprocess;
 
public System.String NAMEOFPROCESS
{
get
{
return nameofprocess;
}
set
{
nameofprocess=value;
}
}
 
private System.Int32 id_info;
 
public System.Int32 ID_INFO
{
get
{
return id_info;
}
set
{
id_info=value;
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
 
 
public void New()
{
idprojectprocessinfo = 0;
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
// INSERT INTO linkinfoprocess(idprojectprocessinfo,NameOfInformation,NameOfProcess,id_info,id_process ) VALUES(idprojectprocessinfo,nameofinformation,nameofprocess,id_info,id_process );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO linkinfoprocess(NameOfInformation,NameOfProcess,id_info,id_process ) VALUES("+(char)39+nameofinformation.ToString()+(char)39+(char)44+(char)39+nameofprocess.ToString()+(char)39+(char)44+id_info.ToString()+(char)44+id_process.ToString()+(char)41;
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
public bool Save(linkinfoprocess _linkinfoprocess)
{
bool tmp = false;
int res = -1;
_linkinfoprocess.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_linkinfoprocess db_linkinfoprocess = new DB_linkinfoprocess();
if (_linkinfoprocess.IDLINKINFOPROCESS == 0)
{
res = db_linkinfoprocess.Add(_linkinfoprocess, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_linkinfoprocess.Update(_linkinfoprocess, conn, tran);
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
string mupdate = "UPDATE linkinfoprocess SET "+"NameOfInformation="+(char)39+nameofinformation.ToString()+(char)39+(char)44+"NameOfProcess="+(char)39+nameofprocess.ToString()+(char)39+(char)44+"id_info="+id_info.ToString()+(char)44+"id_process="+id_process.ToString()+" WHERE idprojectprocessinfo="+idprojectprocessinfo.ToString();
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
string del = "DELETE FROM linkinfoprocess WHERE idprojectprocessinfo="+idprojectprocessinfo.ToString();
 // idprojectprocessinfo=OldData[i].ToString() AND
 // NameOfInformation=OldData[i].ToString() AND
 // NameOfProcess=OldData[i].ToString() AND
 // id_info=OldData[i].ToString() AND
 // id_process=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM linkinfoprocess " +SearchExp;
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
string alistsearch = "SELECT * FROM linkinfoprocess";
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
string dtsearch = "SELECT * FROM linkinfoprocess " +SearchExp;
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
string dtsearch = "SELECT * FROM linkinfoprocess";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
