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
 
public class attribute
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public attribute()
{
 
  
 
}
 
public attribute (System.Int32 _idattribute,System.String _name,System.String _description,System.Int32 _id_entities,System.Int32 _id_company,System.Int32 _active )
{
idattribute=_idattribute;
name=_name;
description=_description;
id_entities=_id_entities;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idattribute;
 
public System.Int32 IDATTRIBUTE
{
get
{
return idattribute;
}
set
{
idattribute=value;
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
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
}
}
 
private System.Int32 id_entities;
 
public System.Int32 ID_ENTITIES
{
get
{
return id_entities;
}
set
{
id_entities=value;
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
idattribute = 0;
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
// INSERT INTO attribute(idattribute,name,description,id_entities,id_company,active ) VALUES(idattribute,name,description,id_entities,id_company,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO attribute(name,description,id_entities,id_company,active ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+description.ToString()+(char)39+(char)44+id_entities.ToString()+(char)44+id_company.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(attribute _attribute)
{
bool tmp = false;
int res = -1;
_attribute.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_attribute db_attribute = new DB_attribute();
if (_attribute.IDATTRIBUTE == 0)
{
res = db_attribute.Add(_attribute, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_attribute.Update(_attribute, conn, tran);
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
string mupdate = "UPDATE attribute SET "+"name="+(char)39+name.ToString()+(char)39+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"id_entities="+id_entities.ToString()+(char)44+"id_company="+id_company.ToString()+(char)44+"active="+active.ToString()+" WHERE idattribute="+idattribute.ToString();
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
string del = "DELETE FROM attribute WHERE idattribute="+idattribute.ToString();
 // idattribute=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // id_entities=OldData[i].ToString() AND
 // id_company=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM attribute " +SearchExp;
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
string alistsearch = "SELECT * FROM attribute";
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
string dtsearch = "SELECT * FROM attribute " +SearchExp;
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
string dtsearch = "SELECT * FROM attribute";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
