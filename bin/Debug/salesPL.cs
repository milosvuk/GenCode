using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class salesPL
 
{
public string connString;
public string connectionString;
public salesPL()
{
  
 
 
}
 
public salesPL (System.Int32 _id,System.String _invc_storenumb,System.String _invc_storecode,System.String _invc_invoiceno,System.Int64 _invc_docsid,System.String _invc_invdate,System.String _invc_invtime,System.Int32 _invc_itemnumb,System.Int64 _invc_itemsid,System.String _invc_itemupc,System.String _invc_itemalu,System.Int32 _invc_qty,System.Decimal _invc_p$,System.Decimal _invc_t$,System.Decimal _invc_c$,System.Decimal _invc_d$,System.String _invc_pricelevel,System.String _invc_type,System.Int32 _invc_workstation )
{
id=_id;
invc_storenumb=_invc_storenumb;
invc_storecode=_invc_storecode;
invc_invoiceno=_invc_invoiceno;
invc_docsid=_invc_docsid;
invc_invdate=_invc_invdate;
invc_invtime=_invc_invtime;
invc_itemnumb=_invc_itemnumb;
invc_itemsid=_invc_itemsid;
invc_itemupc=_invc_itemupc;
invc_itemalu=_invc_itemalu;
invc_qty=_invc_qty;
invc_p$=_invc_p$;
invc_t$=_invc_t$;
invc_c$=_invc_c$;
invc_d$=_invc_d$;
invc_pricelevel=_invc_pricelevel;
invc_type=_invc_type;
invc_workstation=_invc_workstation;
}
 
 
private System.Int32 id;
 
public System.Int32 ID
{
get
{
return id;
}
set
{
id=value;
}
}
 
private System.String invc_storenumb;
 
public System.String INVC_STORENUMB
{
get
{
return invc_storenumb;
}
set
{
invc_storenumb=value;
}
}
 
private System.String invc_storecode;
 
public System.String INVC_STORECODE
{
get
{
return invc_storecode;
}
set
{
invc_storecode=value;
}
}
 
private System.String invc_invoiceno;
 
public System.String INVC_INVOICENO
{
get
{
return invc_invoiceno;
}
set
{
invc_invoiceno=value;
}
}
 
private System.Int64 invc_docsid;
 
public System.Int64 INVC_DOCSID
{
get
{
return invc_docsid;
}
set
{
invc_docsid=value;
}
}
 
private System.String invc_invdate;
 
public System.String INVC_INVDATE
{
get
{
return invc_invdate;
}
set
{
invc_invdate=value;
}
}
 
private System.String invc_invtime;
 
public System.String INVC_INVTIME
{
get
{
return invc_invtime;
}
set
{
invc_invtime=value;
}
}
 
private System.Int32 invc_itemnumb;
 
public System.Int32 INVC_ITEMNUMB
{
get
{
return invc_itemnumb;
}
set
{
invc_itemnumb=value;
}
}
 
private System.Int64 invc_itemsid;
 
public System.Int64 INVC_ITEMSID
{
get
{
return invc_itemsid;
}
set
{
invc_itemsid=value;
}
}
 
private System.String invc_itemupc;
 
public System.String INVC_ITEMUPC
{
get
{
return invc_itemupc;
}
set
{
invc_itemupc=value;
}
}
 
private System.String invc_itemalu;
 
public System.String INVC_ITEMALU
{
get
{
return invc_itemalu;
}
set
{
invc_itemalu=value;
}
}
 
private System.Int32 invc_qty;
 
public System.Int32 INVC_QTY
{
get
{
return invc_qty;
}
set
{
invc_qty=value;
}
}
 
private System.Decimal invc_p$;
 
public System.Decimal INVC_P$
{
get
{
return invc_p$;
}
set
{
invc_p$=value;
}
}
 
private System.Decimal invc_t$;
 
public System.Decimal INVC_T$
{
get
{
return invc_t$;
}
set
{
invc_t$=value;
}
}
 
private System.Decimal invc_c$;
 
public System.Decimal INVC_C$
{
get
{
return invc_c$;
}
set
{
invc_c$=value;
}
}
 
private System.Decimal invc_d$;
 
public System.Decimal INVC_D$
{
get
{
return invc_d$;
}
set
{
invc_d$=value;
}
}
 
private System.String invc_pricelevel;
 
public System.String INVC_PRICELEVEL
{
get
{
return invc_pricelevel;
}
set
{
invc_pricelevel=value;
}
}
 
private System.String invc_type;
 
public System.String INVC_TYPE
{
get
{
return invc_type;
}
set
{
invc_type=value;
}
}
 
private System.Int32 invc_workstation;
 
public System.Int32 INVC_WORKSTATION
{
get
{
return invc_workstation;
}
set
{
invc_workstation=value;
}
}
 
 
public void New()
{
id = 0;
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
// INSERT INTO tb_sales(id,invc_storenumb,invc_storecode,invc_invoiceno,invc_docsid,invc_invdate,invc_invtime,invc_itemnumb,invc_itemsid,invc_itemupc,invc_itemalu,invc_qty,invc_p$,invc_t$,invc_c$,invc_d$,invc_pricelevel,invc_type,invc_workstation ) VALUES(id,invc_storenumb,invc_storecode,invc_invoiceno,invc_docsid,invc_invdate,invc_invtime,invc_itemnumb,invc_itemsid,invc_itemupc,invc_itemalu,invc_qty,invc_p$,invc_t$,invc_c$,invc_d$,invc_pricelevel,invc_type,invc_workstation );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO tb_sales(invc_storenumb,invc_storecode,invc_invoiceno,invc_docsid,invc_invdate,invc_invtime,invc_itemnumb,invc_itemsid,invc_itemupc,invc_itemalu,invc_qty,invc_p$,invc_t$,invc_c$,invc_d$,invc_pricelevel,invc_type,invc_workstation ) VALUES("+(char)39+invc_storenumb.ToString()+(char)39+(char)44+(char)39+invc_storecode.ToString()+(char)39+(char)44+(char)39+invc_invoiceno.ToString()+(char)39+(char)44+(char)39+invc_docsid.ToString()+(char)39+(char)44+(char)39+invc_invdate.ToString()+(char)39+(char)44+(char)39+invc_invtime.ToString()+(char)39+(char)44+invc_itemnumb.ToString()+(char)44+(char)39+invc_itemsid.ToString()+(char)39+(char)44+(char)39+invc_itemupc.ToString()+(char)39+(char)44+(char)39+invc_itemalu.ToString()+(char)39+(char)44+invc_qty.ToString()+(char)44+invc_p$.ToString()+(char)44+invc_t$.ToString()+(char)44+invc_c$.ToString()+(char)44+invc_d$.ToString()+(char)44+(char)39+invc_pricelevel.ToString()+(char)39+(char)44+(char)39+invc_type.ToString()+(char)39+(char)44+invc_workstation.ToString()+(char)41;
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
public bool Save(salesPL _salesPL)
{
bool tmp = false;
int res = -1;
_salesPL.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_salesPL db_salesPL = new DB_salesPL();
if (_salesPL.IDSALESPL == 0)
{
res = db_salesPL.Add(_salesPL, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_salesPL.Update(_salesPL, conn, tran);
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
string mupdate = "UPDATE tb_sales SET "+"invc_storenumb="+(char)39+invc_storenumb.ToString()+(char)39+(char)44+"invc_storecode="+(char)39+invc_storecode.ToString()+(char)39+(char)44+"invc_invoiceno="+(char)39+invc_invoiceno.ToString()+(char)39+(char)44+"invc_docsid="+(char)39+invc_docsid.ToString()+(char)39+(char)44+"invc_invdate="+(char)39+invc_invdate.ToString()+(char)39+(char)44+"invc_invtime="+(char)39+invc_invtime.ToString()+(char)39+(char)44+"invc_itemnumb="+invc_itemnumb.ToString()+(char)44+"invc_itemsid="+(char)39+invc_itemsid.ToString()+(char)39+(char)44+"invc_itemupc="+(char)39+invc_itemupc.ToString()+(char)39+(char)44+"invc_itemalu="+(char)39+invc_itemalu.ToString()+(char)39+(char)44+"invc_qty="+invc_qty.ToString()+(char)44+"invc_p$="+invc_p$.ToString()+(char)44+"invc_t$="+invc_t$.ToString()+(char)44+"invc_c$="+invc_c$.ToString()+(char)44+"invc_d$="+invc_d$.ToString()+(char)44+"invc_pricelevel="+(char)39+invc_pricelevel.ToString()+(char)39+(char)44+"invc_type="+(char)39+invc_type.ToString()+(char)39+(char)44+"invc_workstation="+invc_workstation.ToString()+" WHERE id="+id.ToString();
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
string del = "DELETE FROM tb_sales WHERE id="+id.ToString();
 // id=OldData[i].ToString() AND
 // invc_storenumb=OldData[i].ToString() AND
 // invc_storecode=OldData[i].ToString() AND
 // invc_invoiceno=OldData[i].ToString() AND
 // invc_docsid=OldData[i].ToString() AND
 // invc_invdate=OldData[i].ToString() AND
 // invc_invtime=OldData[i].ToString() AND
 // invc_itemnumb=OldData[i].ToString() AND
 // invc_itemsid=OldData[i].ToString() AND
 // invc_itemupc=OldData[i].ToString() AND
 // invc_itemalu=OldData[i].ToString() AND
 // invc_qty=OldData[i].ToString() AND
 // invc_p$=OldData[i].ToString() AND
 // invc_t$=OldData[i].ToString() AND
 // invc_c$=OldData[i].ToString() AND
 // invc_d$=OldData[i].ToString() AND
 // invc_pricelevel=OldData[i].ToString() AND
 // invc_type=OldData[i].ToString() AND
 // invc_workstation=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM tb_sales " +SearchExp;
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
string alistsearch = "SELECT * FROM tb_sales";
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
string dtsearch = "SELECT * FROM tb_sales " +SearchExp;
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
string dtsearch = "SELECT * FROM tb_sales";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
