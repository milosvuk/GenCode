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
 
public class usershs
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public usershs()
{
 
  
 
}
 
public usershs (System.Int32 _iduser,System.Int32 _id_usergroup,System.String _username,System.String _password,System.String _useremail,System.Int32 _active,System.Int32 _id_company )
{
iduser=_iduser;
id_usergroup=_id_usergroup;
username=_username;
password=_password;
useremail=_useremail;
active=_active;
id_company=_id_company;
}
 
 
private System.Int32 iduser;
 
public System.Int32 IDUSER
{
get
{
return iduser;
}
set
{
iduser=value;
}
}
 
private System.Int32 id_usergroup;
 
public System.Int32 ID_USERGROUP
{
get
{
return id_usergroup;
}
set
{
id_usergroup=value;
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
 
private System.String useremail;
 
public System.String USEREMAIL
{
get
{
return useremail;
}
set
{
useremail=value;
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
iduser = 0;
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
// INSERT INTO usershs(iduser,id_usergroup,username,password,useremail,active,id_company ) VALUES(iduser,id_usergroup,username,password,useremail,active,id_company );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO usershs(id_usergroup,username,password,useremail,active,id_company ) VALUES("+id_usergroup.ToString()+(char)44+(char)39+username.ToString()+(char)39+(char)44+(char)39+password.ToString()+(char)39+(char)44+(char)39+useremail.ToString()+(char)39+(char)44+active.ToString()+(char)44+id_company.ToString()+(char)41;
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
public bool Save(usershs _usershs)
{
bool tmp = false;
int res = -1;
_usershs.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_usershs db_usershs = new DB_usershs();
if (_usershs.IDUSERSHS == 0)
{
res = db_usershs.Add(_usershs, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_usershs.Update(_usershs, conn, tran);
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
string mupdate = "UPDATE usershs SET "+"id_usergroup="+id_usergroup.ToString()+(char)44+"username="+(char)39+username.ToString()+(char)39+(char)44+"password="+(char)39+password.ToString()+(char)39+(char)44+"useremail="+(char)39+useremail.ToString()+(char)39+(char)44+"active="+active.ToString()+(char)44+"id_company="+id_company.ToString()+" WHERE iduser="+iduser.ToString();
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
string del = "DELETE FROM usershs WHERE iduser="+iduser.ToString();
 // iduser=OldData[i].ToString() AND
 // id_usergroup=OldData[i].ToString() AND
 // username=OldData[i].ToString() AND
 // password=OldData[i].ToString() AND
 // useremail=OldData[i].ToString() AND
 // active=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM usershs " +SearchExp;
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
string alistsearch = "SELECT * FROM usershs";
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
string dtsearch = "SELECT * FROM usershs " +SearchExp;
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
string dtsearch = "SELECT * FROM usershs";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
