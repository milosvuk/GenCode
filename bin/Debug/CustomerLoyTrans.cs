using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class CustomerLoyTrans
 
{
public string connString;
public string connectionString;
public CustomerLoyTrans()
{
  
 
 
}
 
public CustomerLoyTrans (System.Int32 _idrec,System.String _custid,System.String _custsid,System.String _custlastname,System.String _custfirstname,System.String _custcompany,System.Int64 _receiptno,System.String _store,System.String _station,System.DateTime _receiptdate,System.Decimal _receipttotal,System.Int32 _pointsvalue,System.String _transfersid )
{
idrec=_idrec;
custid=_custid;
custsid=_custsid;
custlastname=_custlastname;
custfirstname=_custfirstname;
custcompany=_custcompany;
receiptno=_receiptno;
store=_store;
station=_station;
receiptdate=_receiptdate;
receipttotal=_receipttotal;
pointsvalue=_pointsvalue;
transfersid=_transfersid;
}
 
 
private System.Int32 idrec;
 
public System.Int32 IDREC
{
get
{
return idrec;
}
set
{
idrec=value;
}
}
 
private System.String custid;
 
public System.String CUSTID
{
get
{
return custid;
}
set
{
custid=value;
}
}
 
private System.String custsid;
 
public System.String CUSTSID
{
get
{
return custsid;
}
set
{
custsid=value;
}
}
 
private System.String custlastname;
 
public System.String CUSTLASTNAME
{
get
{
return custlastname;
}
set
{
custlastname=value;
}
}
 
private System.String custfirstname;
 
public System.String CUSTFIRSTNAME
{
get
{
return custfirstname;
}
set
{
custfirstname=value;
}
}
 
private System.String custcompany;
 
public System.String CUSTCOMPANY
{
get
{
return custcompany;
}
set
{
custcompany=value;
}
}
 
private System.Int64 receiptno;
 
public System.Int64 RECEIPTNO
{
get
{
return receiptno;
}
set
{
receiptno=value;
}
}
 
private System.String store;
 
public System.String STORE
{
get
{
return store;
}
set
{
store=value;
}
}
 
private System.String station;
 
public System.String STATION
{
get
{
return station;
}
set
{
station=value;
}
}
 
private System.DateTime receiptdate;
 
public System.DateTime RECEIPTDATE
{
get
{
return receiptdate;
}
set
{
receiptdate=value;
}
}
 
private System.Decimal receipttotal;
 
public System.Decimal RECEIPTTOTAL
{
get
{
return receipttotal;
}
set
{
receipttotal=value;
}
}
 
private System.Int32 pointsvalue;
 
public System.Int32 POINTSVALUE
{
get
{
return pointsvalue;
}
set
{
pointsvalue=value;
}
}
 
private System.String transfersid;
 
public System.String TRANSFERSID
{
get
{
return transfersid;
}
set
{
transfersid=value;
}
}
 
 
public void New()
{
idrec = 0;
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
// INSERT INTO CLTrans(idRec,CustID,CustSID,CustLastName,CustFirstName,CustCompany,ReceiptNo,Store,Station,ReceiptDate,ReceiptTotal,PointsValue,TransferSID ) VALUES(idrec,custid,custsid,custlastname,custfirstname,custcompany,receiptno,store,station,receiptdate,receipttotal,pointsvalue,transfersid );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO CLTrans(CustID,CustSID,CustLastName,CustFirstName,CustCompany,ReceiptNo,Store,Station,ReceiptDate,ReceiptTotal,PointsValue,TransferSID ) VALUES("+(char)39+custid.ToString()+(char)39+(char)44+(char)39+custsid.ToString()+(char)39+(char)44+(char)39+custlastname.ToString()+(char)39+(char)44+(char)39+custfirstname.ToString()+(char)39+(char)44+(char)39+custcompany.ToString()+(char)39+(char)44+(char)39+receiptno.ToString()+(char)39+(char)44+(char)39+store.ToString()+(char)39+(char)44+(char)39+station.ToString()+(char)39+(char)44+(char)39+receiptdate.ToString()+(char)39+(char)44+receipttotal.ToString()+(char)44+pointsvalue.ToString()+(char)44+(char)39+transfersid.ToString()+(char)39+(char)41;
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
public bool Save(CustomerLoyTrans _CustomerLoyTrans)
{
bool tmp = false;
int res = -1;
_CustomerLoyTrans.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_CustomerLoyTrans db_CustomerLoyTrans = new DB_CustomerLoyTrans();
if (_CustomerLoyTrans.IDCUSTOMERLOYTRANS == 0)
{
res = db_CustomerLoyTrans.Add(_CustomerLoyTrans, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_CustomerLoyTrans.Update(_CustomerLoyTrans, conn, tran);
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
string mupdate = "UPDATE CLTrans SET "+"CustID="+(char)39+custid.ToString()+(char)39+(char)44+"CustSID="+(char)39+custsid.ToString()+(char)39+(char)44+"CustLastName="+(char)39+custlastname.ToString()+(char)39+(char)44+"CustFirstName="+(char)39+custfirstname.ToString()+(char)39+(char)44+"CustCompany="+(char)39+custcompany.ToString()+(char)39+(char)44+"ReceiptNo="+(char)39+receiptno.ToString()+(char)39+(char)44+"Store="+(char)39+store.ToString()+(char)39+(char)44+"Station="+(char)39+station.ToString()+(char)39+(char)44+"ReceiptDate="+(char)39+receiptdate.ToString()+(char)39+(char)44+"ReceiptTotal="+receipttotal.ToString()+(char)44+"PointsValue="+pointsvalue.ToString()+(char)44+"TransferSID="+(char)39+transfersid.ToString()+(char)39+" WHERE idRec="+idrec.ToString();
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
string del = "DELETE FROM CLTrans WHERE idRec="+idrec.ToString();
 // idRec=OldData[i].ToString() AND
 // CustID=OldData[i].ToString() AND
 // CustSID=OldData[i].ToString() AND
 // CustLastName=OldData[i].ToString() AND
 // CustFirstName=OldData[i].ToString() AND
 // CustCompany=OldData[i].ToString() AND
 // ReceiptNo=OldData[i].ToString() AND
 // Store=OldData[i].ToString() AND
 // Station=OldData[i].ToString() AND
 // ReceiptDate=OldData[i].ToString() AND
 // ReceiptTotal=OldData[i].ToString() AND
 // PointsValue=OldData[i].ToString() AND
 // TransferSID=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM CLTrans " +SearchExp;
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
string alistsearch = "SELECT * FROM CLTrans";
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
string dtsearch = "SELECT * FROM CLTrans " +SearchExp;
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
string dtsearch = "SELECT * FROM CLTrans";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
