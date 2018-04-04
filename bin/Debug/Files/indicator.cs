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
 
public class indicator
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public indicator()
{
 
  
 
}
 
public indicator (System.Int32 _idindicator,System.String _code,System.String _name,System.Decimal _lowvaluerange,System.Decimal _highvaluerange,System.String _description,System.Int32 _idcompany )
{
idindicator=_idindicator;
code=_code;
name=_name;
lowvaluerange=_lowvaluerange;
highvaluerange=_highvaluerange;
description=_description;
idcompany=_idcompany;
}
 
 
private System.Int32 idindicator;
 
public System.Int32 IDINDICATOR
{
get
{
return idindicator;
}
set
{
idindicator=value;
}
}
 
private System.String code;
 
public System.String CODE
{
get
{
return code;
}
set
{
code=value;
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
 
private System.Decimal lowvaluerange;
 
public System.Decimal LOWVALUERANGE
{
get
{
return lowvaluerange;
}
set
{
lowvaluerange=value;
}
}
 
private System.Decimal highvaluerange;
 
public System.Decimal HIGHVALUERANGE
{
get
{
return highvaluerange;
}
set
{
highvaluerange=value;
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
idindicator = 0;
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
// INSERT INTO indicator(idindicator,code,name,lowvaluerange,highvaluerange,description,idcompany ) VALUES(idindicator,code,name,lowvaluerange,highvaluerange,description,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO indicator(code,name,lowvaluerange,highvaluerange,description,idcompany ) VALUES("+(char)39+code.ToString()+(char)39+(char)44+(char)39+name.ToString()+(char)39+(char)44+lowvaluerange.ToString()+(char)44+highvaluerange.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(indicator _indicator)
{
bool tmp = false;
int res = -1;
_indicator.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_indicator db_indicator = new DB_indicator();
if (_indicator.IDINDICATOR == 0)
{
res = db_indicator.Add(_indicator, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_indicator.Update(_indicator, conn, tran);
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
string mupdate = "UPDATE indicator SET "+"code="+(char)39+code.ToString()+(char)39+(char)44+"name="+(char)39+name.ToString()+(char)39+(char)44+"lowvaluerange="+lowvaluerange.ToString()+(char)44+"highvaluerange="+highvaluerange.ToString()+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"idcompany="+idcompany.ToString()+" WHERE idindicator="+idindicator.ToString();
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
string del = "DELETE FROM indicator WHERE idindicator="+idindicator.ToString();
 // idindicator=OldData[i].ToString() AND
 // code=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // lowvaluerange=OldData[i].ToString() AND
 // highvaluerange=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM indicator " +SearchExp;
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
string alistsearch = "SELECT * FROM indicator";
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
string dtsearch = "SELECT * FROM indicator " +SearchExp;
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
string dtsearch = "SELECT * FROM indicator";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
