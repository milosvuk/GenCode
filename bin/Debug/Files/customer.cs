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
 
public class customer
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public customer()
{
 
  
 
}
 
public customer (System.Int32 _idcustomer,System.String _customerid,System.String _customersid,System.String _nameofcustomer,System.String _surnameofcustomer,System.String _addressofcustomer,System.String _cityofcustomer,System.String _countryofcustomer,System.Int32 _id_company )
{
idcustomer=_idcustomer;
customerid=_customerid;
customersid=_customersid;
nameofcustomer=_nameofcustomer;
surnameofcustomer=_surnameofcustomer;
addressofcustomer=_addressofcustomer;
cityofcustomer=_cityofcustomer;
countryofcustomer=_countryofcustomer;
id_company=_id_company;
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
 
private System.String customerid;
 
public System.String CUSTOMERID
{
get
{
return customerid;
}
set
{
customerid=value;
}
}
 
private System.String customersid;
 
public System.String CUSTOMERSID
{
get
{
return customersid;
}
set
{
customersid=value;
}
}
 
private System.String nameofcustomer;
 
public System.String NAMEOFCUSTOMER
{
get
{
return nameofcustomer;
}
set
{
nameofcustomer=value;
}
}
 
private System.String surnameofcustomer;
 
public System.String SURNAMEOFCUSTOMER
{
get
{
return surnameofcustomer;
}
set
{
surnameofcustomer=value;
}
}
 
private System.String addressofcustomer;
 
public System.String ADDRESSOFCUSTOMER
{
get
{
return addressofcustomer;
}
set
{
addressofcustomer=value;
}
}
 
private System.String cityofcustomer;
 
public System.String CITYOFCUSTOMER
{
get
{
return cityofcustomer;
}
set
{
cityofcustomer=value;
}
}
 
private System.String countryofcustomer;
 
public System.String COUNTRYOFCUSTOMER
{
get
{
return countryofcustomer;
}
set
{
countryofcustomer=value;
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
idcustomer = 0;
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
// INSERT INTO customer(idcustomer,customerid,customersid,nameOfCustomer,surnameOfCustomer,addressOfCustomer,cityofCustomer,countryOfCustomer,id_company ) VALUES(idcustomer,customerid,customersid,nameofcustomer,surnameofcustomer,addressofcustomer,cityofcustomer,countryofcustomer,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO customer(customerid,customersid,nameOfCustomer,surnameOfCustomer,addressOfCustomer,cityofCustomer,countryOfCustomer,id_company ) VALUES("+(char)39+customerid.ToString()+(char)39+(char)44+(char)39+customersid.ToString()+(char)39+(char)44+(char)39+nameofcustomer.ToString()+(char)39+(char)44+(char)39+surnameofcustomer.ToString()+(char)39+(char)44+(char)39+addressofcustomer.ToString()+(char)39+(char)44+(char)39+cityofcustomer.ToString()+(char)39+(char)44+(char)39+countryofcustomer.ToString()+(char)39+(char)44+id_company.ToString()+(char)41;
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
public bool Save(customer _customer)
{
bool tmp = false;
int res = -1;
_customer.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_customer db_customer = new DB_customer();
if (_customer.IDCUSTOMER == 0)
{
res = db_customer.Add(_customer, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_customer.Update(_customer, conn, tran);
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
string mupdate = "UPDATE customer SET "+"customerid="+(char)39+customerid.ToString()+(char)39+(char)44+"customersid="+(char)39+customersid.ToString()+(char)39+(char)44+"nameOfCustomer="+(char)39+nameofcustomer.ToString()+(char)39+(char)44+"surnameOfCustomer="+(char)39+surnameofcustomer.ToString()+(char)39+(char)44+"addressOfCustomer="+(char)39+addressofcustomer.ToString()+(char)39+(char)44+"cityofCustomer="+(char)39+cityofcustomer.ToString()+(char)39+(char)44+"countryOfCustomer="+(char)39+countryofcustomer.ToString()+(char)39+(char)44+"id_company="+id_company.ToString()+" WHERE idcustomer="+idcustomer.ToString();
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
string del = "DELETE FROM customer WHERE idcustomer="+idcustomer.ToString();
 // idcustomer=OldData[i].ToString() AND
 // customerid=OldData[i].ToString() AND
 // customersid=OldData[i].ToString() AND
 // nameOfCustomer=OldData[i].ToString() AND
 // surnameOfCustomer=OldData[i].ToString() AND
 // addressOfCustomer=OldData[i].ToString() AND
 // cityofCustomer=OldData[i].ToString() AND
 // countryOfCustomer=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM customer " +SearchExp;
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
string alistsearch = "SELECT * FROM customer";
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
string dtsearch = "SELECT * FROM customer " +SearchExp;
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
string dtsearch = "SELECT * FROM customer";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
