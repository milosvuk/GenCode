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
 
public class receiving
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public receiving()
{
 
  
 
}
 
public receiving (System.Int32 _idreceivedv,System.DateTime _dateofreceiving,System.DateTime _datetimeofreceving,System.Int32 _numofreceiving,System.Int32 _id_store,System.Int32 _id_user,System.Int32 _id_vendor,System.Decimal _amountofreceiving,System.Int32 _finalized,System.Int32 _id_company )
{
idreceivedv=_idreceivedv;
dateofreceiving=_dateofreceiving;
datetimeofreceving=_datetimeofreceving;
numofreceiving=_numofreceiving;
id_store=_id_store;
id_user=_id_user;
id_vendor=_id_vendor;
amountofreceiving=_amountofreceiving;
finalized=_finalized;
id_company=_id_company;
}
 
 
private System.Int32 idreceivedv;
 
public System.Int32 IDRECEIVEDV
{
get
{
return idreceivedv;
}
set
{
idreceivedv=value;
}
}
 
private System.DateTime dateofreceiving;
 
public System.DateTime DATEOFRECEIVING
{
get
{
return dateofreceiving;
}
set
{
dateofreceiving=value;
}
}
 
private System.DateTime datetimeofreceving;
 
public System.DateTime DATETIMEOFRECEVING
{
get
{
return datetimeofreceving;
}
set
{
datetimeofreceving=value;
}
}
 
private System.Int32 numofreceiving;
 
public System.Int32 NUMOFRECEIVING
{
get
{
return numofreceiving;
}
set
{
numofreceiving=value;
}
}
 
private System.Int32 id_store;
 
public System.Int32 ID_STORE
{
get
{
return id_store;
}
set
{
id_store=value;
}
}
 
private System.Int32 id_user;
 
public System.Int32 ID_USER
{
get
{
return id_user;
}
set
{
id_user=value;
}
}
 
private System.Int32 id_vendor;
 
public System.Int32 ID_VENDOR
{
get
{
return id_vendor;
}
set
{
id_vendor=value;
}
}
 
private System.Decimal amountofreceiving;
 
public System.Decimal AMOUNTOFRECEIVING
{
get
{
return amountofreceiving;
}
set
{
amountofreceiving=value;
}
}
 
private System.Int32 finalized;
 
public System.Int32 FINALIZED
{
get
{
return finalized;
}
set
{
finalized=value;
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
idreceivedv = 0;
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
// INSERT INTO receiving(idreceivedv,dateOfReceiving,datetimeOfReceving,numOfReceiving,id_store,id_user,id_vendor,amountOfReceiving,finalized,id_company ) VALUES(idreceivedv,dateofreceiving,datetimeofreceving,numofreceiving,id_store,id_user,id_vendor,amountofreceiving,finalized,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO receiving(dateOfReceiving,datetimeOfReceving,numOfReceiving,id_store,id_user,id_vendor,amountOfReceiving,finalized,id_company ) VALUES("+(char)39+dateofreceiving.ToString()+(char)39+(char)44+(char)39+datetimeofreceving.ToString()+(char)39+(char)44+numofreceiving.ToString()+(char)44+id_store.ToString()+(char)44+id_user.ToString()+(char)44+id_vendor.ToString()+(char)44+amountofreceiving.ToString()+(char)44+finalized.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(receiving _receiving)
{
bool tmp = false;
int res = -1;
_receiving.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_receiving db_receiving = new DB_receiving();
if (_receiving.IDRECEIVING == 0)
{
res = db_receiving.Add(_receiving, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_receiving.Update(_receiving, conn, tran);
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
string mupdate = "UPDATE receiving SET "+"dateOfReceiving="+(char)39+dateofreceiving.ToString()+(char)39+(char)44+"datetimeOfReceving="+(char)39+datetimeofreceving.ToString()+(char)39+(char)44+"numOfReceiving="+numofreceiving.ToString()+(char)44+"id_store="+id_store.ToString()+(char)44+"id_user="+id_user.ToString()+(char)44+"id_vendor="+id_vendor.ToString()+(char)44+"amountOfReceiving="+amountofreceiving.ToString()+(char)44+"finalized="+finalized.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE idreceivedv="+idreceivedv.ToString();
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
string del = "DELETE FROM receiving WHERE idreceivedv="+idreceivedv.ToString();
 // idreceivedv=OldData[i].ToString() AND
 // dateOfReceiving=OldData[i].ToString() AND
 // datetimeOfReceving=OldData[i].ToString() AND
 // numOfReceiving=OldData[i].ToString() AND
 // id_store=OldData[i].ToString() AND
 // id_user=OldData[i].ToString() AND
 // id_vendor=OldData[i].ToString() AND
 // amountOfReceiving=OldData[i].ToString() AND
 // finalized=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM receiving " +SearchExp;
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
string alistsearch = "SELECT * FROM receiving";
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
string dtsearch = "SELECT * FROM receiving " +SearchExp;
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
string dtsearch = "SELECT * FROM receiving";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
