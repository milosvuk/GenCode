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
 
public class healthcareprofessionals
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public healthcareprofessionals()
{
 
  
 
}
 
public healthcareprofessionals (System.Int32 _idprofessional,System.String _name,System.String _surname,System.String _mobile,System.String _email,System.String _username,System.String _password,System.Int32 _active )
{
idprofessional=_idprofessional;
name=_name;
surname=_surname;
mobile=_mobile;
email=_email;
username=_username;
password=_password;
active=_active;
}
 
 
private System.Int32 idprofessional;
 
public System.Int32 IDPROFESSIONAL
{
get
{
return idprofessional;
}
set
{
idprofessional=value;
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
 
private System.String password;
 
public System.String PASSWORD
{
get
{
return password;
}
set
{
password=value;
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
idprofessional = 0;
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
// INSERT INTO healthcareprofessionals(idprofessional,name,surname,mobile,email,username,password,active ) VALUES(idprofessional,name,surname,mobile,email,username,password,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO healthcareprofessionals(name,surname,mobile,email,username,password,active ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+surname.ToString()+(char)39+(char)44+(char)39+mobile.ToString()+(char)39+(char)44+(char)39+email.ToString()+(char)39+(char)44+(char)39+username.ToString()+(char)39+(char)44+(char)39+password.ToString()+(char)39+(char)44+active.ToString()+(char)41;
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
public bool Save(healthcareprofessionals _healthcareprofessionals)
{
bool tmp = false;
int res = -1;
_healthcareprofessionals.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_healthcareprofessionals db_healthcareprofessionals = new DB_healthcareprofessionals();
if (_healthcareprofessionals.IDHEALTHCAREPROFESSIONALS == 0)
{
res = db_healthcareprofessionals.Add(_healthcareprofessionals, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_healthcareprofessionals.Update(_healthcareprofessionals, conn, tran);
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
string mupdate = "UPDATE healthcareprofessionals SET "+"name="+(char)39+name.ToString()+(char)39+(char)44+"surname="+(char)39+surname.ToString()+(char)39+(char)44+"mobile="+(char)39+mobile.ToString()+(char)39+(char)44+"email="+(char)39+email.ToString()+(char)39+(char)44+"username="+(char)39+username.ToString()+(char)39+(char)44+"password="+(char)39+password.ToString()+(char)39+(char)44+"active="+active.ToString()+" WHERE idprofessional="+idprofessional.ToString();
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
string del = "DELETE FROM healthcareprofessionals WHERE idprofessional="+idprofessional.ToString();
 // idprofessional=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // surname=OldData[i].ToString() AND
 // mobile=OldData[i].ToString() AND
 // email=OldData[i].ToString() AND
 // username=OldData[i].ToString() AND
 // password=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM healthcareprofessionals " +SearchExp;
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
string alistsearch = "SELECT * FROM healthcareprofessionals";
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
string dtsearch = "SELECT * FROM healthcareprofessionals " +SearchExp;
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
string dtsearch = "SELECT * FROM healthcareprofessionals";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
