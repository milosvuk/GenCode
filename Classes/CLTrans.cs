using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
 
namespace ptl
 
{
public class CLTrans
 
{
public CLTrans()
{
 
}
 
public CLTrans (System.String CUSTID,System.String CUSTSID,System.String CUSTLASTNAME,System.String CUSTFIRSTNAME,System.String CUSTCOMPANY,System.Int64 RECEIPTNO,System.String STORE,System.String STATION,System.DateTime RECEIPTDATE,System.Decimal RECEIPTTOTAL,System.Int32 POINTSVALUE,System.String TRANSFERSID )
{
custid=CUSTID;
custsid=CUSTSID;
custlastname=CUSTLASTNAME;
custfirstname=CUSTFIRSTNAME;
custcompany=CUSTCOMPANY;
receiptno=RECEIPTNO;
store=STORE;
station=STATION;
receiptdate=RECEIPTDATE;
receipttotal=RECEIPTTOTAL;
pointsvalue=POINTSVALUE;
transfersid=TRANSFERSID;
}
 
 
private System.String custid;
 
public System.String CustID
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
 
public System.String CustSID
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
 
public System.String CustLastName
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
 
public System.String CustFirstName
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
 
public System.String CustCompany
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
 
public System.Int64 ReceiptNo
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
 
public System.String Store
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
 
public System.String Station
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
 
public System.DateTime ReceiptDate
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
 
public System.Decimal ReceiptTotal
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
 
public System.Int32 PointsValue
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
 
public System.String TransferSID
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
 
public int InsertCommand()
{
// Use this InsertCommand with PrimaryKey Field which is not AutoIncement;
int numberinsert=0;
// INSERT INTO CLTrans(CustID,CustSID,CustLastName,CustFirstName,CustCompany,ReceiptNo,Store,Station,ReceiptDate,ReceiptTotal,PointsValue,TransferSID ) VALUES(custid,custsid,custlastname,custfirstname,custcompany,receiptno,store,station,receiptdate,receipttotal,pointsvalue,transfersid );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO CLTrans(CustSID,CustLastName,CustFirstName,CustCompany,ReceiptNo,Store,Station,ReceiptDate,ReceiptTotal,PointsValue,TransferSID ) VALUES("+(char)39+custsid.ToString()+(char)39+(char)44+(char)39+custlastname.ToString()+(char)39+(char)44+(char)39+custfirstname.ToString()+(char)39+(char)44+(char)39+custcompany.ToString()+(char)39+(char)44+(char)39+receiptno.ToString()+(char)39+(char)44+(char)39+store.ToString()+(char)39+(char)44+(char)39+station.ToString()+(char)39+(char)44+(char)39+receiptdate.ToString()+(char)39+(char)44+receipttotal.ToString()+(char)44+pointsvalue.ToString()+(char)44+(char)39+transfersid.ToString()+(char)39+(char)41;
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
ptl.DbaseSQLServer sqinsert = new ptl.DbaseSQLServer();
sqinsert.DbaseConnection = Con;
sqinsert.SqlText = minsert;
numberinsert = sqinsert.RunUpdateSQL();
sqinsert = null;
return numberinsert;
}
 
public int UpdateEditComand(string Con)
{
int numberedit=0;
string mupdate = "UPDATE CLTrans SET "+"CustSID="+(char)39+custsid.ToString()+(char)39+(char)44+"CustLastName="+(char)39+custlastname.ToString()+(char)39+(char)44+"CustFirstName="+(char)39+custfirstname.ToString()+(char)39+(char)44+"CustCompany="+(char)39+custcompany.ToString()+(char)39+(char)44+"ReceiptNo="+(char)39+receiptno.ToString()+(char)39+(char)44+"Store="+(char)39+store.ToString()+(char)39+(char)44+"Station="+(char)39+station.ToString()+(char)39+(char)44+"ReceiptDate="+(char)39+receiptdate.ToString()+(char)39+(char)44+"ReceiptTotal="+receipttotal.ToString()+(char)44+"PointsValue="+pointsvalue.ToString()+(char)44+"TransferSID="+(char)39+transfersid.ToString()+(char)39+" WHERE CustID="+custid.ToString();
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
string del = "DELETE FROM CLTrans WHERE CustID="+custid.ToString();
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
}
