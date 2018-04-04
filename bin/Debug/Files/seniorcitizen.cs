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
 
public class seniorcitizen
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public seniorcitizen()
{
 
  
 
}
 
public seniorcitizen (System.Int32 _idseniorcitizen,System.String _name,System.String _surname,System.String _idcard,System.String _address1,System.String _address2,System.String _address3,System.String _city,System.String _loccoordlat,System.String _loccoordlong,System.String _phone,System.String _mobile,System.String _email,System.String _comment,System.Int32 _active )
{
idseniorcitizen=_idseniorcitizen;
name=_name;
surname=_surname;
idcard=_idcard;
address1=_address1;
address2=_address2;
address3=_address3;
city=_city;
loccoordlat=_loccoordlat;
loccoordlong=_loccoordlong;
phone=_phone;
mobile=_mobile;
email=_email;
comment=_comment;
active=_active;
}
 
 
private System.Int32 idseniorcitizen;
 
public System.Int32 IDSENIORCITIZEN
{
get
{
return idseniorcitizen;
}
set
{
idseniorcitizen=value;
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
 
private System.String idcard;
 
public System.String IDCARD
{
get
{
return idcard;
}
set
{
idcard=value;
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
 
private System.String address3;
 
public System.String ADDRESS3
{
get
{
return address3;
}
set
{
address3=value;
}
}
 
private System.String city;
 
public System.String CITY
{
get
{
return city;
}
set
{
city=value;
}
}
 
private System.String loccoordlat;
 
public System.String LOCCOORDLAT
{
get
{
return loccoordlat;
}
set
{
loccoordlat=value;
}
}
 
private System.String loccoordlong;
 
public System.String LOCCOORDLONG
{
get
{
return loccoordlong;
}
set
{
loccoordlong=value;
}
}
 
private System.String phone;
 
public System.String PHONE
{
get
{
return phone;
}
set
{
phone=value;
}
}
 
private System.String mobile;
 
public System.String MOBILE
{
get
{
return mobile;
}
set
{
mobile=value;
}
}
 
private System.String email;
 
public System.String EMAIL
{
get
{
return email;
}
set
{
email=value;
}
}
 
private System.String comment;
 
public System.String COMMENT
{
get
{
return comment;
}
set
{
comment=value;
}
}
 
private System.Int32 active;
 
public System.Int32 ACTIVE
{
get
{
return active;
}
set
{
active=value;
}
}
 
 
public void New()
{
idseniorcitizen = 0;
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
// INSERT INTO seniorcitizen(idseniorcitizen,Name,Surname,IDcard,Address1,Address2,Address3,City,LocCoordLat,LocCoordLong,Phone,Mobile,Email,Comment,active ) VALUES(idseniorcitizen,name,surname,idcard,address1,address2,address3,city,loccoordlat,loccoordlong,phone,mobile,email,comment,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO seniorcitizen(Name,Surname,IDcard,Address1,Address2,Address3,City,LocCoordLat,LocCoordLong,Phone,Mobile,Email,Comment,active ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+surname.ToString()+(char)39+(char)44+(char)39+idcard.ToString()+(char)39+(char)44+(char)39+address1.ToString()+(char)39+(char)44+(char)39+address2.ToString()+(char)39+(char)44+(char)39+address3.ToString()+(char)39+(char)44+(char)39+city.ToString()+(char)39+(char)44+(char)39+loccoordlat.ToString()+(char)39+(char)44+(char)39+loccoordlong.ToString()+(char)39+(char)44+(char)39+phone.ToString()+(char)39+(char)44+(char)39+mobile.ToString()+(char)39+(char)44+(char)39+email.ToString()+(char)39+(char)44+(char)39+comment.ToString()+(char)39+(char)44+active.ToString()+(char)41;
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
public bool Save(seniorcitizen _seniorcitizen)
{
bool tmp = false;
int res = -1;
_seniorcitizen.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_seniorcitizen db_seniorcitizen = new DB_seniorcitizen();
if (_seniorcitizen.IDSENIORCITIZEN == 0)
{
res = db_seniorcitizen.Add(_seniorcitizen, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_seniorcitizen.Update(_seniorcitizen, conn, tran);
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
string mupdate = "UPDATE seniorcitizen SET "+"Name="+(char)39+name.ToString()+(char)39+(char)44+"Surname="+(char)39+surname.ToString()+(char)39+(char)44+"IDcard="+(char)39+idcard.ToString()+(char)39+(char)44+"Address1="+(char)39+address1.ToString()+(char)39+(char)44+"Address2="+(char)39+address2.ToString()+(char)39+(char)44+"Address3="+(char)39+address3.ToString()+(char)39+(char)44+"City="+(char)39+city.ToString()+(char)39+(char)44+"LocCoordLat="+(char)39+loccoordlat.ToString()+(char)39+(char)44+"LocCoordLong="+(char)39+loccoordlong.ToString()+(char)39+(char)44+"Phone="+(char)39+phone.ToString()+(char)39+(char)44+"Mobile="+(char)39+mobile.ToString()+(char)39+(char)44+"Email="+(char)39+email.ToString()+(char)39+(char)44+"Comment="+(char)39+comment.ToString()+(char)39+(char)44+"active="+active.ToString()+" WHERE idseniorcitizen="+idseniorcitizen.ToString();
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
string del = "DELETE FROM seniorcitizen WHERE idseniorcitizen="+idseniorcitizen.ToString();
 // idseniorcitizen=OldData[i].ToString() AND
 // Name=OldData[i].ToString() AND
 // Surname=OldData[i].ToString() AND
 // IDcard=OldData[i].ToString() AND
 // Address1=OldData[i].ToString() AND
 // Address2=OldData[i].ToString() AND
 // Address3=OldData[i].ToString() AND
 // City=OldData[i].ToString() AND
 // LocCoordLat=OldData[i].ToString() AND
 // LocCoordLong=OldData[i].ToString() AND
 // Phone=OldData[i].ToString() AND
 // Mobile=OldData[i].ToString() AND
 // Email=OldData[i].ToString() AND
 // Comment=OldData[i].ToString() AND
 // active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM seniorcitizen " +SearchExp;
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
string alistsearch = "SELECT * FROM seniorcitizen";
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
string dtsearch = "SELECT * FROM seniorcitizen " +SearchExp;
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
string dtsearch = "SELECT * FROM seniorcitizen";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
