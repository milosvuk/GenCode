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
 
public class process
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public process()
{
 
  
 
}
 
public process (System.Int32 _idprocess,System.Int32 _typeofprocess,System.String _id_location,System.String _id_entity,System.Decimal _qty,System.Decimal _valueperunit,System.Decimal _totalvalue,System.DateTime _dateofprocess,System.TimeSpan _timeofprocess,System.Int32 _weekofprocess,System.Int32 _monthofprocess,System.Int32 _yearofprocess,System.String _id_document,System.String _documentssource,System.String _filesource,System.String _description1,System.String _description2,System.String _id_relatedentity,System.Int32 _id_company )
{
idprocess=_idprocess;
typeofprocess=_typeofprocess;
id_location=_id_location;
id_entity=_id_entity;
qty=_qty;
valueperunit=_valueperunit;
totalvalue=_totalvalue;
dateofprocess=_dateofprocess;
timeofprocess=_timeofprocess;
weekofprocess=_weekofprocess;
monthofprocess=_monthofprocess;
yearofprocess=_yearofprocess;
id_document=_id_document;
documentssource=_documentssource;
filesource=_filesource;
description1=_description1;
description2=_description2;
id_relatedentity=_id_relatedentity;
id_company=_id_company;
}
 
 
private System.Int32 idprocess;
 
public System.Int32 IDPROCESS
{
get
{
return idprocess;
}
set
{
idprocess=value;
}
}
 
private System.Int32 typeofprocess;
 
public System.Int32 TYPEOFPROCESS
{
get
{
return typeofprocess;
}
set
{
typeofprocess=value;
}
}
 
private System.String id_location;
 
public System.String ID_LOCATION
{
get
{
return id_location;
}
set
{
id_location=value;
}
}
 
private System.String id_entity;
 
public System.String ID_ENTITY
{
get
{
return id_entity;
}
set
{
id_entity=value;
}
}
 
private System.Decimal qty;
 
public System.Decimal QTY
{
get
{
return qty;
}
set
{
qty=value;
}
}
 
private System.Decimal valueperunit;
 
public System.Decimal VALUEPERUNIT
{
get
{
return valueperunit;
}
set
{
valueperunit=value;
}
}
 
private System.Decimal totalvalue;
 
public System.Decimal TOTALVALUE
{
get
{
return totalvalue;
}
set
{
totalvalue=value;
}
}
 
private System.DateTime dateofprocess;
 
public System.DateTime DATEOFPROCESS
{
get
{
return dateofprocess;
}
set
{
dateofprocess=value;
}
}
 
private System.TimeSpan timeofprocess;
 
public System.TimeSpan TIMEOFPROCESS
{
get
{
return timeofprocess;
}
set
{
timeofprocess=value;
}
}
 
private System.Int32 weekofprocess;
 
public System.Int32 WEEKOFPROCESS
{
get
{
return weekofprocess;
}
set
{
weekofprocess=value;
}
}
 
private System.Int32 monthofprocess;
 
public System.Int32 MONTHOFPROCESS
{
get
{
return monthofprocess;
}
set
{
monthofprocess=value;
}
}
 
private System.Int32 yearofprocess;
 
public System.Int32 YEAROFPROCESS
{
get
{
return yearofprocess;
}
set
{
yearofprocess=value;
}
}
 
private System.String id_document;
 
public System.String ID_DOCUMENT
{
get
{
return id_document;
}
set
{
id_document=value;
}
}
 
private System.String documentssource;
 
public System.String DOCUMENTSSOURCE
{
get
{
return documentssource;
}
set
{
documentssource=value;
}
}
 
private System.String filesource;
 
public System.String FILESOURCE
{
get
{
return filesource;
}
set
{
filesource=value;
}
}
 
private System.String description1;
 
public System.String DESCRIPTION1
{
get
{
return description1;
}
set
{
description1=value;
}
}
 
private System.String description2;
 
public System.String DESCRIPTION2
{
get
{
return description2;
}
set
{
description2=value;
}
}
 
private System.String id_relatedentity;
 
public System.String ID_RELATEDENTITY
{
get
{
return id_relatedentity;
}
set
{
id_relatedentity=value;
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
 
 
public void New()
{
idprocess = 0;
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
// INSERT INTO process(idprocess,typeofprocess,id_location,id_entity,qty,valueperunit,totalvalue,dateofprocess,timeofprocess,weekofprocess,monthofprocess,yearofprocess,id_document,documentssource,filesource,description1,description2,id_relatedentity,id_company ) VALUES(idprocess,typeofprocess,id_location,id_entity,qty,valueperunit,totalvalue,dateofprocess,timeofprocess,weekofprocess,monthofprocess,yearofprocess,id_document,documentssource,filesource,description1,description2,id_relatedentity,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO process(typeofprocess,id_location,id_entity,qty,valueperunit,totalvalue,dateofprocess,timeofprocess,weekofprocess,monthofprocess,yearofprocess,id_document,documentssource,filesource,description1,description2,id_relatedentity,id_company ) VALUES("+typeofprocess.ToString()+(char)44+(char)39+id_location.ToString()+(char)39+(char)44+(char)39+id_entity.ToString()+(char)39+(char)44+qty.ToString()+(char)44+valueperunit.ToString()+(char)44+totalvalue.ToString()+(char)44+(char)39+dateofprocess.ToString()+(char)39+(char)44+(char)39+timeofprocess.ToString()+(char)39+(char)44+weekofprocess.ToString()+(char)44+monthofprocess.ToString()+(char)44+yearofprocess.ToString()+(char)44+(char)39+id_document.ToString()+(char)39+(char)44+(char)39+documentssource.ToString()+(char)39+(char)44+(char)39+filesource.ToString()+(char)39+(char)44+(char)39+description1.ToString()+(char)39+(char)44+(char)39+description2.ToString()+(char)39+(char)44+(char)39+id_relatedentity.ToString()+(char)39+(char)44+id_company.ToString()+(char)41;
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
public bool Save(process _process)
{
bool tmp = false;
int res = -1;
_process.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_process db_process = new DB_process();
if (_process.IDPROCESS == 0)
{
res = db_process.Add(_process, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_process.Update(_process, conn, tran);
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
string mupdate = "UPDATE process SET "+"typeofprocess="+typeofprocess.ToString()+(char)44+"id_location="+(char)39+id_location.ToString()+(char)39+(char)44+"id_entity="+(char)39+id_entity.ToString()+(char)39+(char)44+"qty="+qty.ToString()+(char)44+"valueperunit="+valueperunit.ToString()+(char)44+"totalvalue="+totalvalue.ToString()+(char)44+"dateofprocess="+(char)39+dateofprocess.ToString()+(char)39+(char)44+"timeofprocess="+(char)39+timeofprocess.ToString()+(char)39+(char)44+"weekofprocess="+weekofprocess.ToString()+(char)44+"monthofprocess="+monthofprocess.ToString()+(char)44+"yearofprocess="+yearofprocess.ToString()+(char)44+"id_document="+(char)39+id_document.ToString()+(char)39+(char)44+"documentssource="+(char)39+documentssource.ToString()+(char)39+(char)44+"filesource="+(char)39+filesource.ToString()+(char)39+(char)44+"description1="+(char)39+description1.ToString()+(char)39+(char)44+"description2="+(char)39+description2.ToString()+(char)39+(char)44+"id_relatedentity="+(char)39+id_relatedentity.ToString()+(char)39+(char)44+"id_company="+id_company.ToString()+" WHERE idprocess="+idprocess.ToString();
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
string del = "DELETE FROM process WHERE idprocess="+idprocess.ToString();
 // idprocess=OldData[i].ToString() AND
 // typeofprocess=OldData[i].ToString() AND
 // id_location=OldData[i].ToString() AND
 // id_entity=OldData[i].ToString() AND
 // qty=OldData[i].ToString() AND
 // valueperunit=OldData[i].ToString() AND
 // totalvalue=OldData[i].ToString() AND
 // dateofprocess=OldData[i].ToString() AND
 // timeofprocess=OldData[i].ToString() AND
 // weekofprocess=OldData[i].ToString() AND
 // monthofprocess=OldData[i].ToString() AND
 // yearofprocess=OldData[i].ToString() AND
 // id_document=OldData[i].ToString() AND
 // documentssource=OldData[i].ToString() AND
 // filesource=OldData[i].ToString() AND
 // description1=OldData[i].ToString() AND
 // description2=OldData[i].ToString() AND
 // id_relatedentity=OldData[i].ToString() AND
 // id_company=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM process " +SearchExp;
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
string alistsearch = "SELECT * FROM process";
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
string dtsearch = "SELECT * FROM process " +SearchExp;
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
string dtsearch = "SELECT * FROM process";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
