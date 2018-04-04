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
 
public class exportedinvoice
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public exportedinvoice()
{
 
  
 
}
 
public exportedinvoice (System.Int32 _idexportedinvoice,System.Int32 _idinvoice,System.String _typeofac,System.String _accountreference,System.String _nominalacref,System.String _department,System.String _dateofinv,System.String _referencecode,System.String _details,System.String _netamount,System.String _taxcode,System.String _taxamount,System.String _exchangerate,System.String _extrareference,System.String _username,System.String _projectrefn,System.String _costocderefn )
{
idexportedinvoice=_idexportedinvoice;
idinvoice=_idinvoice;
typeofac=_typeofac;
accountreference=_accountreference;
nominalacref=_nominalacref;
department=_department;
dateofinv=_dateofinv;
referencecode=_referencecode;
details=_details;
netamount=_netamount;
taxcode=_taxcode;
taxamount=_taxamount;
exchangerate=_exchangerate;
extrareference=_extrareference;
username=_username;
projectrefn=_projectrefn;
costocderefn=_costocderefn;
}
 
 
private System.Int32 idexportedinvoice;
 
public System.Int32 IDEXPORTEDINVOICE
{
get
{
return idexportedinvoice;
}
set
{
idexportedinvoice=value;
}
}
 
private System.Int32 idinvoice;
 
public System.Int32 IDINVOICE
{
get
{
return idinvoice;
}
set
{
idinvoice=value;
}
}
 
private System.String typeofac;
 
public System.String TYPEOFAC
{
get
{
return typeofac;
}
set
{
typeofac=value;
}
}
 
private System.String accountreference;
 
public System.String ACCOUNTREFERENCE
{
get
{
return accountreference;
}
set
{
accountreference=value;
}
}
 
private System.String nominalacref;
 
public System.String NOMINALACREF
{
get
{
return nominalacref;
}
set
{
nominalacref=value;
}
}
 
private System.String department;
 
public System.String DEPARTMENT
{
get
{
return department;
}
set
{
department=value;
}
}
 
private System.String dateofinv;
 
public System.String DATEOFINV
{
get
{
return dateofinv;
}
set
{
dateofinv=value;
}
}
 
private System.String referencecode;
 
public System.String REFERENCECODE
{
get
{
return referencecode;
}
set
{
referencecode=value;
}
}
 
private System.String details;
 
public System.String DETAILS
{
get
{
return details;
}
set
{
details=value;
}
}
 
private System.String netamount;
 
public System.String NETAMOUNT
{
get
{
return netamount;
}
set
{
netamount=value;
}
}
 
private System.String taxcode;
 
public System.String TAXCODE
{
get
{
return taxcode;
}
set
{
taxcode=value;
}
}
 
private System.String taxamount;
 
public System.String TAXAMOUNT
{
get
{
return taxamount;
}
set
{
taxamount=value;
}
}
 
private System.String exchangerate;
 
public System.String EXCHANGERATE
{
get
{
return exchangerate;
}
set
{
exchangerate=value;
}
}
 
private System.String extrareference;
 
public System.String EXTRAREFERENCE
{
get
{
return extrareference;
}
set
{
extrareference=value;
}
}
 
private System.String username;
 
public System.String USERNAME
{
get
{
return username;
}
set
{
username=value;
}
}
 
private System.String projectrefn;
 
public System.String PROJECTREFN
{
get
{
return projectrefn;
}
set
{
projectrefn=value;
}
}
 
private System.String costocderefn;
 
public System.String COSTOCDEREFN
{
get
{
return costocderefn;
}
set
{
costocderefn=value;
}
}
 
 
public void New()
{
idexportedinvoice = 0;
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
// INSERT INTO exportedinvoice(idexportedinvoice,idinvoice,typeofac,accountreference,nominalacref,department,dateofinv,referencecode,details,netamount,taxcode,taxamount,exchangerate,extrareference,username,projectrefn,costocderefn ) VALUES(idexportedinvoice,idinvoice,typeofac,accountreference,nominalacref,department,dateofinv,referencecode,details,netamount,taxcode,taxamount,exchangerate,extrareference,username,projectrefn,costocderefn );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO exportedinvoice(idinvoice,typeofac,accountreference,nominalacref,department,dateofinv,referencecode,details,netamount,taxcode,taxamount,exchangerate,extrareference,username,projectrefn,costocderefn ) VALUES("+idinvoice.ToString()+(char)44+(char)39+typeofac.ToString()+(char)39+(char)44+(char)39+accountreference.ToString()+(char)39+(char)44+(char)39+nominalacref.ToString()+(char)39+(char)44+(char)39+department.ToString()+(char)39+(char)44+(char)39+dateofinv.ToString()+(char)39+(char)44+(char)39+referencecode.ToString()+(char)39+(char)44+(char)39+details.ToString()+(char)39+(char)44+(char)39+netamount.ToString()+(char)39+(char)44+(char)39+taxcode.ToString()+(char)39+(char)44+(char)39+taxamount.ToString()+(char)39+(char)44+(char)39+exchangerate.ToString()+(char)39+(char)44+(char)39+extrareference.ToString()+(char)39+(char)44+(char)39+username.ToString()+(char)39+(char)44+(char)39+projectrefn.ToString()+(char)39+(char)44+(char)39+costocderefn.ToString()+(char)39+(char)41;
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
public bool Save(exportedinvoice _exportedinvoice)
{
bool tmp = false;
int res = -1;
_exportedinvoice.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_exportedinvoice db_exportedinvoice = new DB_exportedinvoice();
if (_exportedinvoice.IDEXPORTEDINVOICE == 0)
{
res = db_exportedinvoice.Add(_exportedinvoice, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_exportedinvoice.Update(_exportedinvoice, conn, tran);
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
string mupdate = "UPDATE exportedinvoice SET "+"idinvoice="+idinvoice.ToString()+(char)44+"typeofac="+(char)39+typeofac.ToString()+(char)39+(char)44+"accountreference="+(char)39+accountreference.ToString()+(char)39+(char)44+"nominalacref="+(char)39+nominalacref.ToString()+(char)39+(char)44+"department="+(char)39+department.ToString()+(char)39+(char)44+"dateofinv="+(char)39+dateofinv.ToString()+(char)39+(char)44+"referencecode="+(char)39+referencecode.ToString()+(char)39+(char)44+"details="+(char)39+details.ToString()+(char)39+(char)44+"netamount="+(char)39+netamount.ToString()+(char)39+(char)44+"taxcode="+(char)39+taxcode.ToString()+(char)39+(char)44+"taxamount="+(char)39+taxamount.ToString()+(char)39+(char)44+"exchangerate="+(char)39+exchangerate.ToString()+(char)39+(char)44+"extrareference="+(char)39+extrareference.ToString()+(char)39+(char)44+"username="+(char)39+username.ToString()+(char)39+(char)44+"projectrefn="+(char)39+projectrefn.ToString()+(char)39+(char)44+"costocderefn="+(char)39+costocderefn.ToString()+(char)39+" WHERE idexportedinvoice="+idexportedinvoice.ToString();
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
string del = "DELETE FROM exportedinvoice WHERE idexportedinvoice="+idexportedinvoice.ToString();
 // idexportedinvoice=OldData[i].ToString() AND
 // idinvoice=OldData[i].ToString() AND
 // typeofac=OldData[i].ToString() AND
 // accountreference=OldData[i].ToString() AND
 // nominalacref=OldData[i].ToString() AND
 // department=OldData[i].ToString() AND
 // dateofinv=OldData[i].ToString() AND
 // referencecode=OldData[i].ToString() AND
 // details=OldData[i].ToString() AND
 // netamount=OldData[i].ToString() AND
 // taxcode=OldData[i].ToString() AND
 // taxamount=OldData[i].ToString() AND
 // exchangerate=OldData[i].ToString() AND
 // extrareference=OldData[i].ToString() AND
 // username=OldData[i].ToString() AND
 // projectrefn=OldData[i].ToString() AND
 // costocderefn=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM exportedinvoice " +SearchExp;
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
string alistsearch = "SELECT * FROM exportedinvoice";
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
string dtsearch = "SELECT * FROM exportedinvoice " +SearchExp;
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
string dtsearch = "SELECT * FROM exportedinvoice";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
