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
 
public class measurement
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public measurement()
{
 
  
 
}
 
public measurement (System.Int32 _idmeasurement,System.String _codeoflocation,System.DateTime _dateofmeasurement,System.String _codeofindicator,System.Decimal _valueofmeasurement,System.String _description,System.Int32 _weekm,System.Int32 _monthm,System.Int32 _yearm,System.Int32 _idcustomer )
{
idmeasurement=_idmeasurement;
codeoflocation=_codeoflocation;
dateofmeasurement=_dateofmeasurement;
codeofindicator=_codeofindicator;
valueofmeasurement=_valueofmeasurement;
description=_description;
weekm=_weekm;
monthm=_monthm;
yearm=_yearm;
idcustomer=_idcustomer;
}
 
 
private System.Int32 idmeasurement;
 
public System.Int32 IDMEASUREMENT
{
get
{
return idmeasurement;
}
set
{
idmeasurement=value;
}
}
 
private System.String codeoflocation;
 
public System.String CODEOFLOCATION
{
get
{
return codeoflocation;
}
set
{
codeoflocation=value;
}
}
 
private System.DateTime dateofmeasurement;
 
public System.DateTime DATEOFMEASUREMENT
{
get
{
return dateofmeasurement;
}
set
{
dateofmeasurement=value;
}
}
 
private System.String codeofindicator;
 
public System.String CODEOFINDICATOR
{
get
{
return codeofindicator;
}
set
{
codeofindicator=value;
}
}
 
private System.Decimal valueofmeasurement;
 
public System.Decimal VALUEOFMEASUREMENT
{
get
{
return valueofmeasurement;
}
set
{
valueofmeasurement=value;
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
 
private System.Int32 weekm;
 
public System.Int32 WEEKM
{
get
{
return weekm;
}
set
{
weekm=value;
}
}
 
private System.Int32 monthm;
 
public System.Int32 MONTHM
{
get
{
return monthm;
}
set
{
monthm=value;
}
}
 
private System.Int32 yearm;
 
public System.Int32 YEARM
{
get
{
return yearm;
}
set
{
yearm=value;
}
}
 
private System.Int32 idcustomer;
 
public System.Int32 IDCUSTOMER
{
get
{
return idcustomer;
}
set
{
idcustomer=value;
}
}
 
 
public void New()
{
idmeasurement = 0;
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
// INSERT INTO measurement(idmeasurement,codeoflocation,dateofmeasurement,codeofindicator,valueofmeasurement,description,weekm,monthm,yearm,idcustomer ) VALUES(idmeasurement,codeoflocation,dateofmeasurement,codeofindicator,valueofmeasurement,description,weekm,monthm,yearm,idcustomer );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO measurement(codeoflocation,dateofmeasurement,codeofindicator,valueofmeasurement,description,weekm,monthm,yearm,idcustomer ) VALUES("+(char)39+codeoflocation.ToString()+(char)39+(char)44+(char)39+dateofmeasurement.ToString()+(char)39+(char)44+(char)39+codeofindicator.ToString()+(char)39+(char)44+valueofmeasurement.ToString()+(char)44+(char)39+description.ToString()+(char)39+(char)44+weekm.ToString()+(char)44+monthm.ToString()+(char)44+yearm.ToString()+(char)44+idcustomer.ToString()+(char)41;
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
public bool Save(measurement _measurement)
{
bool tmp = false;
int res = -1;
_measurement.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_measurement db_measurement = new DB_measurement();
if (_measurement.IDMEASUREMENT == 0)
{
res = db_measurement.Add(_measurement, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_measurement.Update(_measurement, conn, tran);
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
string mupdate = "UPDATE measurement SET "+"codeoflocation="+(char)39+codeoflocation.ToString()+(char)39+(char)44+"dateofmeasurement="+(char)39+dateofmeasurement.ToString()+(char)39+(char)44+"codeofindicator="+(char)39+codeofindicator.ToString()+(char)39+(char)44+"valueofmeasurement="+valueofmeasurement.ToString()+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"weekm="+weekm.ToString()+(char)44+"monthm="+monthm.ToString()+(char)44+"yearm="+yearm.ToString()+(char)44+"idcustomer="+idcustomer.ToString()+" WHERE idmeasurement="+idmeasurement.ToString();
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
string del = "DELETE FROM measurement WHERE idmeasurement="+idmeasurement.ToString();
 // idmeasurement=OldData[i].ToString() AND
 // codeoflocation=OldData[i].ToString() AND
 // dateofmeasurement=OldData[i].ToString() AND
 // codeofindicator=OldData[i].ToString() AND
 // valueofmeasurement=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // weekm=OldData[i].ToString() AND
 // monthm=OldData[i].ToString() AND
 // yearm=OldData[i].ToString() AND
 // idcustomer=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM measurement " +SearchExp;
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
string alistsearch = "SELECT * FROM measurement";
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
string dtsearch = "SELECT * FROM measurement " +SearchExp;
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
string dtsearch = "SELECT * FROM measurement";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
