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
 
public class notary
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public notary()
{
 
  
 
}
 
public notary (System.Int32 _idnotary,System.String _fullname,System.String _address,System.String _phone,System.String _email,System.String _comment,System.Int32 _idcompany )
{
idnotary=_idnotary;
fullname=_fullname;
address=_address;
phone=_phone;
email=_email;
comment=_comment;
idcompany=_idcompany;
}
 
 
private System.Int32 idnotary;
 
public System.Int32 IDNOTARY
{
get
{
return idnotary;
}
set
{
idnotary=value;
}
}
 
private System.String fullname;
 
public System.String FULLNAME
{
get
{
return fullname;
}
set
{
fullname=value;
}
}
 
private System.String address;
 
public System.String ADDRESS
{
get
{
return address;
}
set
{
address=value;
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
 
private System.Int32 idcompany;
 
public System.Int32 IDCOMPANY
{
get
{
return idcompany;
}
set
{
idcompany=value;
}
}
 
 
public void New()
{
idnotary = 0;
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
// INSERT INTO notary(idNotary,FullName,Address,Phone,Email,Comment,idCompany ) VALUES(idnotary,fullname,address,phone,email,comment,idcompany );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO notary(FullName,Address,Phone,Email,Comment,idCompany ) VALUES("+(char)39+fullname.ToString()+(char)39+(char)44+(char)39+address.ToString()+(char)39+(char)44+(char)39+phone.ToString()+(char)39+(char)44+(char)39+email.ToString()+(char)39+(char)44+(char)39+comment.ToString()+(char)39+(char)44+idcompany.ToString()+(char)41;
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
public bool Save(notary _notary)
{
bool tmp = false;
int res = -1;
_notary.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_notary db_notary = new DB_notary();
if (_notary.IDNOTARY == 0)
{
res = db_notary.Add(_notary, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_notary.Update(_notary, conn, tran);
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
string mupdate = "UPDATE notary SET "+"FullName="+(char)39+fullname.ToString()+(char)39+(char)44+"Address="+(char)39+address.ToString()+(char)39+(char)44+"Phone="+(char)39+phone.ToString()+(char)39+(char)44+"Email="+(char)39+email.ToString()+(char)39+(char)44+"Comment="+(char)39+comment.ToString()+(char)39+(char)44+"idCompany="+idcompany.ToString()+" WHERE idNotary="+idnotary.ToString();
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
string del = "DELETE FROM notary WHERE idNotary="+idnotary.ToString();
 // idNotary=OldData[i].ToString() AND
 // FullName=OldData[i].ToString() AND
 // Address=OldData[i].ToString() AND
 // Phone=OldData[i].ToString() AND
 // Email=OldData[i].ToString() AND
 // Comment=OldData[i].ToString() AND
 // idCompany=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM notary " +SearchExp;
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
string alistsearch = "SELECT * FROM notary";
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
string dtsearch = "SELECT * FROM notary " +SearchExp;
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
string dtsearch = "SELECT * FROM notary";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
