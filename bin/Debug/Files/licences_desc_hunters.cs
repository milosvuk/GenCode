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
 
public class licences_desc_hunters
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public licences_desc_hunters()
{
 
  
 
}
 
public licences_desc_hunters (System.Int32 _idrechunter,System.String _idcardnumber,System.String _surname,System.String _name,System.String _licencedmobilenumber,System.Int32 _idreclicence,System.Int32 _licenceyear,System.Int32 _paid,System.Decimal _amount,System.String _licencedescription,System.DateTime _startdate,System.DateTime _enddate,System.Int32 _activel,System.String _address2,System.String _address1,System.String _locality,System.String _maltaorgozo )
{
idrechunter=_idrechunter;
idcardnumber=_idcardnumber;
surname=_surname;
name=_name;
licencedmobilenumber=_licencedmobilenumber;
idreclicence=_idreclicence;
licenceyear=_licenceyear;
paid=_paid;
amount=_amount;
licencedescription=_licencedescription;
startdate=_startdate;
enddate=_enddate;
activel=_activel;
address2=_address2;
address1=_address1;
locality=_locality;
maltaorgozo=_maltaorgozo;
}
 
 
private System.Int32 idrechunter;
 
public System.Int32 IDRECHUNTER
{
get
{
return idrechunter;
}
set
{
idrechunter=value;
}
}
 
private System.String idcardnumber;
 
public System.String IDCARDNUMBER
{
get
{
return idcardnumber;
}
set
{
idcardnumber=value;
}
}
 
private System.String surname;
 
public System.String SURNAME
{
get
{
return surname;
}
set
{
surname=value;
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
 
private System.String licencedmobilenumber;
 
public System.String LICENCEDMOBILENUMBER
{
get
{
return licencedmobilenumber;
}
set
{
licencedmobilenumber=value;
}
}
 
private System.Int32 idreclicence;
 
public System.Int32 IDRECLICENCE
{
get
{
return idreclicence;
}
set
{
idreclicence=value;
}
}
 
private System.Int32 licenceyear;
 
public System.Int32 LICENCEYEAR
{
get
{
return licenceyear;
}
set
{
licenceyear=value;
}
}
 
private System.Int32 paid;
 
public System.Int32 PAID
{
get
{
return paid;
}
set
{
paid=value;
}
}
 
private System.Decimal amount;
 
public System.Decimal AMOUNT
{
get
{
return amount;
}
set
{
amount=value;
}
}
 
private System.String licencedescription;
 
public System.String LICENCEDESCRIPTION
{
get
{
return licencedescription;
}
set
{
licencedescription=value;
}
}
 
private System.DateTime startdate;
 
public System.DateTime STARTDATE
{
get
{
return startdate;
}
set
{
startdate=value;
}
}
 
private System.DateTime enddate;
 
public System.DateTime ENDDATE
{
get
{
return enddate;
}
set
{
enddate=value;
}
}
 
private System.Int32 activel;
 
public System.Int32 ACTIVEL
{
get
{
return activel;
}
set
{
activel=value;
}
}
 
private System.String address2;
 
public System.String ADDRESS2
{
get
{
return address2;
}
set
{
address2=value;
}
}
 
private System.String address1;
 
public System.String ADDRESS1
{
get
{
return address1;
}
set
{
address1=value;
}
}
 
private System.String locality;
 
public System.String LOCALITY
{
get
{
return locality;
}
set
{
locality=value;
}
}
 
private System.String maltaorgozo;
 
public System.String MALTAORGOZO
{
get
{
return maltaorgozo;
}
set
{
maltaorgozo=value;
}
}
 
 
public void New()
{
idrechunter = 0;
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
// INSERT INTO licences_desc_hunters(idRecHunter,IdCardNumber,Surname,Name,LicencedMobileNumber,idRecLicence,LicenceYear,Paid,Amount,LicenceDescription,StartDate,EndDate,ActiveL,Address2,Address1,Locality,MaltaOrGozo ) VALUES(idrechunter,idcardnumber,surname,name,licencedmobilenumber,idreclicence,licenceyear,paid,amount,licencedescription,startdate,enddate,activel,address2,address1,locality,maltaorgozo );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO licences_desc_hunters(IdCardNumber,Surname,Name,LicencedMobileNumber,idRecLicence,LicenceYear,Paid,Amount,LicenceDescription,StartDate,EndDate,ActiveL,Address2,Address1,Locality,MaltaOrGozo ) VALUES("+(char)39+idcardnumber.ToString()+(char)39+(char)44+(char)39+surname.ToString()+(char)39+(char)44+(char)39+name.ToString()+(char)39+(char)44+(char)39+licencedmobilenumber.ToString()+(char)39+(char)44+idreclicence.ToString()+(char)44+licenceyear.ToString()+(char)44+paid.ToString()+(char)44+amount.ToString()+(char)44+(char)39+licencedescription.ToString()+(char)39+(char)44+(char)39+startdate.ToString()+(char)39+(char)44+(char)39+enddate.ToString()+(char)39+(char)44+activel.ToString()+(char)44+(char)39+address2.ToString()+(char)39+(char)44+(char)39+address1.ToString()+(char)39+(char)44+(char)39+locality.ToString()+(char)39+(char)44+(char)39+maltaorgozo.ToString()+(char)39+(char)41;
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
public bool Save(licences_desc_hunters _licences_desc_hunters)
{
bool tmp = false;
int res = -1;
_licences_desc_hunters.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_licences_desc_hunters db_licences_desc_hunters = new DB_licences_desc_hunters();
if (_licences_desc_hunters.IDLICENCES_DESC_HUNTERS == 0)
{
res = db_licences_desc_hunters.Add(_licences_desc_hunters, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_licences_desc_hunters.Update(_licences_desc_hunters, conn, tran);
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
string mupdate = "UPDATE licences_desc_hunters SET "+"IdCardNumber="+(char)39+idcardnumber.ToString()+(char)39+(char)44+"Surname="+(char)39+surname.ToString()+(char)39+(char)44+"Name="+(char)39+name.ToString()+(char)39+(char)44+"LicencedMobileNumber="+(char)39+licencedmobilenumber.ToString()+(char)39+(char)44+"idRecLicence="+idreclicence.ToString()+(char)44+"LicenceYear="+licenceyear.ToString()+(char)44+"Paid="+paid.ToString()+(char)44+"Amount="+amount.ToString()+(char)44+"LicenceDescription="+(char)39+licencedescription.ToString()+(char)39+(char)44+"StartDate="+(char)39+startdate.ToString()+(char)39+(char)44+"EndDate="+(char)39+enddate.ToString()+(char)39+(char)44+"ActiveL="+activel.ToString()+(char)44+"Address2="+(char)39+address2.ToString()+(char)39+(char)44+"Address1="+(char)39+address1.ToString()+(char)39+(char)44+"Locality="+(char)39+locality.ToString()+(char)39+(char)44+"MaltaOrGozo="+(char)39+maltaorgozo.ToString()+(char)39+" WHERE idRecHunter="+idrechunter.ToString();
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
string del = "DELETE FROM licences_desc_hunters WHERE idRecHunter="+idrechunter.ToString();
 // idRecHunter=OldData[i].ToString() AND
 // IdCardNumber=OldData[i].ToString() AND
 // Surname=OldData[i].ToString() AND
 // Name=OldData[i].ToString() AND
 // LicencedMobileNumber=OldData[i].ToString() AND
 // idRecLicence=OldData[i].ToString() AND
 // LicenceYear=OldData[i].ToString() AND
 // Paid=OldData[i].ToString() AND
 // Amount=OldData[i].ToString() AND
 // LicenceDescription=OldData[i].ToString() AND
 // StartDate=OldData[i].ToString() AND
 // EndDate=OldData[i].ToString() AND
 // ActiveL=OldData[i].ToString() AND
 // Address2=OldData[i].ToString() AND
 // Address1=OldData[i].ToString() AND
 // Locality=OldData[i].ToString() AND
 // MaltaOrGozo=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM licences_desc_hunters " +SearchExp;
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
string alistsearch = "SELECT * FROM licences_desc_hunters";
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
string dtsearch = "SELECT * FROM licences_desc_hunters " +SearchExp;
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
string dtsearch = "SELECT * FROM licences_desc_hunters";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
