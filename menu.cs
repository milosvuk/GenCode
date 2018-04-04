using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
namespace WinTest
{

 
public class menu
 
{
string connString;
string connectionString;
public menu()
{
System.Configuration.ConnectionStringSettings connString; 
connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
connectionString = connString.ConnectionString;
}
 
public menu (System.Int32 _idmenu,System.Int32 _menulevel,System.Int32 _idwebpage,System.Int32 _submenuposition )
{
idmenu=_idmenu;
menulevel=_menulevel;
idwebpage=_idwebpage;
submenuposition=_submenuposition;
}
 
 
private System.Int32 idmenu;
 
public System.Int32 IDMENU
{
get
{
return idmenu;
}
set
{
idmenu=value;
}
}
 
private System.Int32 menulevel;
 
public System.Int32 MENULEVEL
{
get
{
return menulevel;
}
set
{
menulevel=value;
}
}
 
private System.Int32 idwebpage;
 
public System.Int32 IDWEBPAGE
{
get
{
return idwebpage;
}
set
{
idwebpage=value;
}
}
 
private System.Int32 submenuposition;
 
public System.Int32 SUBMENUPOSITION
{
get
{
return submenuposition;
}
set
{
submenuposition=value;
}
}
 
 
public void New()
{
idmenu = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
public int InsertCommand()
{
// Use this InsertCommand with PrimaryKey Field which is not AutoIncement;
int numberinsert=0;
// INSERT INTO Menu(IdMenu,MenuLevel,IdWebPage,SubMenuPosition ) VALUES(idmenu,menulevel,idwebpage,submenuposition );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO Menu(MenuLevel,IdWebPage,SubMenuPosition ) VALUES("+menulevel.ToString()+(char)44+idwebpage.ToString()+(char)44+submenuposition.ToString()+(char)41;
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
ptl.DbaseSQLServer sqinsert = new ptl.DbaseSQLServer();
sqinsert.DbaseConnection = Con;
sqinsert.SqlText = minsert;
numberinsert = sqinsert.RunUpdateSQL();
sqinsert = null;
return numberinsert;
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(menu _tmpObject)
{
System.Configuration.ConnectionStringSettings connString; 
connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
connectionString = connString.ConnectionString;
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(menu _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO Menu (MenuLevel,IdWebPage,SubMenuPosition) VALUES (@MenuLevel,@IdWebPage,@SubMenuPosition) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@MenuLevel", _tmpObject.MENULEVEL));
command.Parameters.Add(new SqlParameter("@IdWebPage", _tmpObject.IDWEBPAGE));
command.Parameters.Add(new SqlParameter("@SubMenuPosition", _tmpObject.SUBMENUPOSITION));
command.Parameters.Add(new SqlParameter("@tmpid", SqlDbType.Int));
command.Parameters["@tmpid"].Direction = ParameterDirection.Output;
command.ExecuteNonQuery();
res = (int)command.Parameters["@tmpid"].Value;
return res;
}
////==========================================================================
//END ADD WITH PARAMETERS
////==========================================================================
////==========================================================================
// UPDATE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Update(menu _tmpObject)
{
System.Configuration.ConnectionStringSettings connString; 
connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
connectionString = connString.ConnectionString;
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(menu _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE Menu SET MenuLevel=@menulevel,IdWebPage=@idwebpage,SubMenuPosition=@submenuposition  WHERE IdMenu=@idmenu", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@menulevel", _tmpObject.MENULEVEL));
command.Parameters.Add(new SqlParameter("@idwebpage", _tmpObject.IDWEBPAGE));
command.Parameters.Add(new SqlParameter("@submenuposition", _tmpObject.SUBMENUPOSITION));
command.Parameters.Add(new SqlParameter("@idmenu", _tmpObject.IDMENU));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(menu _tmpObject)
{
System.Configuration.ConnectionStringSettings connString; 
connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
connectionString = connString.ConnectionString;
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(menu _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE Menu  WHERE IdMenu=@idmenu", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idmenu", _tmpObject.IDMENU));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public menu GetById(int _id)
{
menu tmpObject = new menu();
System.Configuration.ConnectionStringSettings connString; 
connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
connectionString = connString.ConnectionString;
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From Menu WHERE IdMenu=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDMENU = (System.Int32)dr["IdMenu"];
tmpObject.MENULEVEL = (System.Int32)dr["MenuLevel"];
tmpObject.IDWEBPAGE = (System.Int32)dr["IdWebPage"];
tmpObject.SUBMENUPOSITION = (System.Int32)dr["SubMenuPosition"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
 
public int UpdateEditComand(string Con)
{
int numberedit=0;
string mupdate = "UPDATE Menu SET "+"MenuLevel="+menulevel.ToString()+(char)44+"IdWebPage="+idwebpage.ToString()+(char)44+"SubMenuPosition="+submenuposition.ToString()+" WHERE IdMenu="+idmenu.ToString();
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
string del = "DELETE FROM Menu WHERE IdMenu="+idmenu.ToString();
 // IdMenu=OldData[i].ToString() AND
 // MenuLevel=OldData[i].ToString() AND
 // IdWebPage=OldData[i].ToString() AND
 // SubMenuPosition=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM Menu " +SearchExp;
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
string alistsearch = "SELECT * FROM Menu";
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
string dtsearch = "SELECT * FROM Menu " +SearchExp;
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
string dtsearch = "SELECT * FROM Menu";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
}