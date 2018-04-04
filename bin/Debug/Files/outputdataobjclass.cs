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
 
public class outputdataobjclass
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public outputdataobjclass()
{
 
  
 
}
 
public outputdataobjclass (System.Int32 _idoutput,System.String _name,System.String _typeandname,System.String _ruleswithaction,System.Int32 _id_objclasses )
{
idoutput=_idoutput;
name=_name;
typeandname=_typeandname;
ruleswithaction=_ruleswithaction;
id_objclasses=_id_objclasses;
}
 
 
private System.Int32 idoutput;
 
public System.Int32 IDOUTPUT
{
get
{
return idoutput;
}
set
{
idoutput=value;
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
 
private System.String typeandname;
 
public System.String TYPEANDNAME
{
get
{
return typeandname;
}
set
{
typeandname=value;
}
}
 
private System.String ruleswithaction;
 
public System.String RULESWITHACTION
{
get
{
return ruleswithaction;
}
set
{
ruleswithaction=value;
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
 
 
public void New()
{
idoutput = 0;
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
// INSERT INTO outputdataobjclass(idoutput,name,typeandname,ruleswithaction,id_objclasses ) VALUES(idoutput,name,typeandname,ruleswithaction,id_objclasses );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO outputdataobjclass(name,typeandname,ruleswithaction,id_objclasses ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+typeandname.ToString()+(char)39+(char)44+(char)39+ruleswithaction.ToString()+(char)39+(char)44+id_objclasses.ToString()+(char)41;
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
public bool Save(outputdataobjclass _outputdataobjclass)
{
bool tmp = false;
int res = -1;
_outputdataobjclass.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_outputdataobjclass db_outputdataobjclass = new DB_outputdataobjclass();
if (_outputdataobjclass.IDOUTPUTDATAOBJCLASS == 0)
{
res = db_outputdataobjclass.Add(_outputdataobjclass, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_outputdataobjclass.Update(_outputdataobjclass, conn, tran);
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
string mupdate = "UPDATE outputdataobjclass SET "+"name="+(char)39+name.ToString()+(char)39+(char)44+"typeandname="+(char)39+typeandname.ToString()+(char)39+(char)44+"ruleswithaction="+(char)39+ruleswithaction.ToString()+(char)39+(char)44+"id_objclasses="+id_objclasses.ToString()+" WHERE idoutput="+idoutput.ToString();
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
string del = "DELETE FROM outputdataobjclass WHERE idoutput="+idoutput.ToString();
 // idoutput=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // typeandname=OldData[i].ToString() AND
 // ruleswithaction=OldData[i].ToString() AND
 // id_objclasses=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM outputdataobjclass " +SearchExp;
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
string alistsearch = "SELECT * FROM outputdataobjclass";
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
string dtsearch = "SELECT * FROM outputdataobjclass " +SearchExp;
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
string dtsearch = "SELECT * FROM outputdataobjclass";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
