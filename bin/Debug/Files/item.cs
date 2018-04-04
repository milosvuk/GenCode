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
 
public class item
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public item()
{
 
  
 
}
 
public item (System.Int32 _iditem,System.Int32 _numofitem,System.String _sidofitem,System.Int32 _id_dcs,System.String _dcs,System.Int32 _id_vendor,System.String _aluofitem,System.String _upcofitem,System.String _desc1ofitem,System.String _desc2ofitem,System.String _atrofitem,System.String _sizeofitem,System.Decimal _taxpercofitem,System.Decimal _costofitem,System.Decimal _priceofitem,System.String _imageofitem,System.DateTime _expirydate,System.Int32 _id_company )
{
iditem=_iditem;
numofitem=_numofitem;
sidofitem=_sidofitem;
id_dcs=_id_dcs;
dcs=_dcs;
id_vendor=_id_vendor;
aluofitem=_aluofitem;
upcofitem=_upcofitem;
desc1ofitem=_desc1ofitem;
desc2ofitem=_desc2ofitem;
atrofitem=_atrofitem;
sizeofitem=_sizeofitem;
taxpercofitem=_taxpercofitem;
costofitem=_costofitem;
priceofitem=_priceofitem;
imageofitem=_imageofitem;
expirydate=_expirydate;
id_company=_id_company;
}
 
 
private System.Int32 iditem;
 
public System.Int32 IDITEM
{
get
{
return iditem;
}
set
{
iditem=value;
}
}
 
private System.Int32 numofitem;
 
public System.Int32 NUMOFITEM
{
get
{
return numofitem;
}
set
{
numofitem=value;
}
}
 
private System.String sidofitem;
 
public System.String SIDOFITEM
{
get
{
return sidofitem;
}
set
{
sidofitem=value;
}
}
 
private System.Int32 id_dcs;
 
public System.Int32 ID_DCS
{
get
{
return id_dcs;
}
set
{
id_dcs=value;
}
}
 
private System.String dcs;
 
public System.String DCS
{
get
{
return dcs;
}
set
{
dcs=value;
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
 
private System.String aluofitem;
 
public System.String ALUOFITEM
{
get
{
return aluofitem;
}
set
{
aluofitem=value;
}
}
 
private System.String upcofitem;
 
public System.String UPCOFITEM
{
get
{
return upcofitem;
}
set
{
upcofitem=value;
}
}
 
private System.String desc1ofitem;
 
public System.String DESC1OFITEM
{
get
{
return desc1ofitem;
}
set
{
desc1ofitem=value;
}
}
 
private System.String desc2ofitem;
 
public System.String DESC2OFITEM
{
get
{
return desc2ofitem;
}
set
{
desc2ofitem=value;
}
}
 
private System.String atrofitem;
 
public System.String ATROFITEM
{
get
{
return atrofitem;
}
set
{
atrofitem=value;
}
}
 
private System.String sizeofitem;
 
public System.String SIZEOFITEM
{
get
{
return sizeofitem;
}
set
{
sizeofitem=value;
}
}
 
private System.Decimal taxpercofitem;
 
public System.Decimal TAXPERCOFITEM
{
get
{
return taxpercofitem;
}
set
{
taxpercofitem=value;
}
}
 
private System.Decimal costofitem;
 
public System.Decimal COSTOFITEM
{
get
{
return costofitem;
}
set
{
costofitem=value;
}
}
 
private System.Decimal priceofitem;
 
public System.Decimal PRICEOFITEM
{
get
{
return priceofitem;
}
set
{
priceofitem=value;
}
}
 
private System.String imageofitem;
 
public System.String IMAGEOFITEM
{
get
{
return imageofitem;
}
set
{
imageofitem=value;
}
}
 
private System.DateTime expirydate;
 
public System.DateTime EXPIRYDATE
{
get
{
return expirydate;
}
set
{
expirydate=value;
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
iditem = 0;
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
// INSERT INTO item(iditem,numOfItem,sidOfItem,id_dcs,dcs,id_vendor,aluOfItem,upcOfItem,desc1OfItem,desc2OfItem,atrOfItem,sizeOfItem,taxPercOfItem,costOfItem,priceOfItem,imageOfItem,expiryDate,id_company ) VALUES(iditem,numofitem,sidofitem,id_dcs,dcs,id_vendor,aluofitem,upcofitem,desc1ofitem,desc2ofitem,atrofitem,sizeofitem,taxpercofitem,costofitem,priceofitem,imageofitem,expirydate,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO item(numOfItem,sidOfItem,id_dcs,dcs,id_vendor,aluOfItem,upcOfItem,desc1OfItem,desc2OfItem,atrOfItem,sizeOfItem,taxPercOfItem,costOfItem,priceOfItem,imageOfItem,expiryDate,id_company ) VALUES("+numofitem.ToString()+(char)44+(char)39+sidofitem.ToString()+(char)39+(char)44+id_dcs.ToString()+(char)44+(char)39+dcs.ToString()+(char)39+(char)44+id_vendor.ToString()+(char)44+(char)39+aluofitem.ToString()+(char)39+(char)44+(char)39+upcofitem.ToString()+(char)39+(char)44+(char)39+desc1ofitem.ToString()+(char)39+(char)44+(char)39+desc2ofitem.ToString()+(char)39+(char)44+(char)39+atrofitem.ToString()+(char)39+(char)44+(char)39+sizeofitem.ToString()+(char)39+(char)44+taxpercofitem.ToString()+(char)44+costofitem.ToString()+(char)44+priceofitem.ToString()+(char)44+(char)39+imageofitem.ToString()+(char)39+(char)44+(char)39+expirydate.ToString()+(char)39+(char)44+id_company.ToString()+(char)41;
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
public bool Save(item _item)
{
bool tmp = false;
int res = -1;
_item.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_item db_item = new DB_item();
if (_item.IDITEM == 0)
{
res = db_item.Add(_item, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_item.Update(_item, conn, tran);
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
string mupdate = "UPDATE item SET "+"numOfItem="+numofitem.ToString()+(char)44+"sidOfItem="+(char)39+sidofitem.ToString()+(char)39+(char)44+"id_dcs="+id_dcs.ToString()+(char)44+"dcs="+(char)39+dcs.ToString()+(char)39+(char)44+"id_vendor="+id_vendor.ToString()+(char)44+"aluOfItem="+(char)39+aluofitem.ToString()+(char)39+(char)44+"upcOfItem="+(char)39+upcofitem.ToString()+(char)39+(char)44+"desc1OfItem="+(char)39+desc1ofitem.ToString()+(char)39+(char)44+"desc2OfItem="+(char)39+desc2ofitem.ToString()+(char)39+(char)44+"atrOfItem="+(char)39+atrofitem.ToString()+(char)39+(char)44+"sizeOfItem="+(char)39+sizeofitem.ToString()+(char)39+(char)44+"taxPercOfItem="+taxpercofitem.ToString()+(char)44+"costOfItem="+costofitem.ToString()+(char)44+"priceOfItem="+priceofitem.ToString()+(char)44+"imageOfItem="+(char)39+imageofitem.ToString()+(char)39+(char)44+"expiryDate="+(char)39+expirydate.ToString()+(char)39+(char)44+"id_company="+id_company.ToString()+" WHERE iditem="+iditem.ToString();
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
string del = "DELETE FROM item WHERE iditem="+iditem.ToString();
 // iditem=OldData[i].ToString() AND
 // numOfItem=OldData[i].ToString() AND
 // sidOfItem=OldData[i].ToString() AND
 // id_dcs=OldData[i].ToString() AND
 // dcs=OldData[i].ToString() AND
 // id_vendor=OldData[i].ToString() AND
 // aluOfItem=OldData[i].ToString() AND
 // upcOfItem=OldData[i].ToString() AND
 // desc1OfItem=OldData[i].ToString() AND
 // desc2OfItem=OldData[i].ToString() AND
 // atrOfItem=OldData[i].ToString() AND
 // sizeOfItem=OldData[i].ToString() AND
 // taxPercOfItem=OldData[i].ToString() AND
 // costOfItem=OldData[i].ToString() AND
 // priceOfItem=OldData[i].ToString() AND
 // imageOfItem=OldData[i].ToString() AND
 // expiryDate=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM item " +SearchExp;
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
string alistsearch = "SELECT * FROM item";
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
string dtsearch = "SELECT * FROM item " +SearchExp;
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
string dtsearch = "SELECT * FROM item";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
