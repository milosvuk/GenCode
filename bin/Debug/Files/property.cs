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
 
public class property
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public property()
{
 
  
 
}
 
public property (System.Int32 _idproperty,System.String _name,System.String _description,System.Int32 _id_documents,System.Int32 _entitiesyesno,System.Int32 _id_company,System.Int32 _active )
{
idproperty=_idproperty;
name=_name;
description=_description;
id_documents=_id_documents;
entitiesyesno=_entitiesyesno;
id_company=_id_company;
active=_active;
}
 
 
private System.Int32 idproperty;
 
public System.Int32 IDPROPERTY
{
get
{
return idproperty;
}
set
{
idproperty=value;
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
 
private System.Int32 id_documents;
 
public System.Int32 ID_DOCUMENTS
{
get
{
return id_documents;
}
set
{
id_documents=value;
}
}
 
private System.Int32 entitiesyesno;
 
public System.Int32 ENTITIESYESNO
{
get
{
return entitiesyesno;
}
set
{
entitiesyesno=value;
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
idproperty = 0;
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
// INSERT INTO property(idproperty,name,description,id_documents,entitiesyesno,id_company,active ) VALUES(idproperty,name,description,id_documents,entitiesyesno,id_company,active );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO property(name,description,id_documents,entitiesyesno,id_company,active ) VALUES("+(char)39+name.ToString()+(char)39+(char)44+(char)39+description.ToString()+(char)39+(char)44+id_documents.ToString()+(char)44+entitiesyesno.ToString()+(char)44+id_company.ToString()+(char)44+active.ToString()+(char)41;
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
public bool Save(property _property)
{
bool tmp = false;
int res = -1;
_property.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_property db_property = new DB_property();
if (_property.IDPROPERTY == 0)
{
res = db_property.Add(_property, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_property.Update(_property, conn, tran);
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
string mupdate = "UPDATE property SET "+"name="+(char)39+name.ToString()+(char)39+(char)44+"description="+(char)39+description.ToString()+(char)39+(char)44+"id_documents="+id_documents.ToString()+(char)44+"entitiesyesno="+entitiesyesno.ToString()+(char)44+"id_company="+id_company.ToString()+(char)44+"active="+active.ToString()+" WHERE idproperty="+idproperty.ToString();
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
string del = "DELETE FROM property WHERE idproperty="+idproperty.ToString();
 // idproperty=OldData[i].ToString() AND
 // name=OldData[i].ToString() AND
 // description=OldData[i].ToString() AND
 // id_documents=OldData[i].ToString() AND
 // entitiesyesno=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM property " +SearchExp;
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
string alistsearch = "SELECT * FROM property";
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
string dtsearch = "SELECT * FROM property " +SearchExp;
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
string dtsearch = "SELECT * FROM property";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
