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
 
public class count_hunters_per_species_include_cond
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public count_hunters_per_species_include_cond()
{
 
  
 
}
 
public count_hunters_per_species_include_cond (System.Int32 _numberofhunters,System.Int32 _idrechunter,System.Int32 _idrecspecies )
{
numberofhunters=_numberofhunters;
idrechunter=_idrechunter;
idrecspecies=_idrecspecies;
}
 
 
private System.Int32 numberofhunters;
 
public System.Int32 NUMBEROFHUNTERS
{
get
{
return numberofhunters;
}
set
{
numberofhunters=value;
}
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
 
private System.Int32 idrecspecies;
 
public System.Int32 IDRECSPECIES
{
get
{
return idrecspecies;
}
set
{
idrecspecies=value;
}
}
 
 
public void New()
{
numberofhunters = 0;
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
// INSERT INTO count_hunters_per_species_include_cond(NumberOfHunters,idRecHunter,idRecSpecies ) VALUES(numberofhunters,idrechunter,idrecspecies );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO count_hunters_per_species_include_cond(idRecHunter,idRecSpecies ) VALUES("+idrechunter.ToString()+(char)44+idrecspecies.ToString()+(char)41;
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
public bool Save(count_hunters_per_species_include_cond _count_hunters_per_species_include_cond)
{
bool tmp = false;
int res = -1;
_count_hunters_per_species_include_cond.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_count_hunters_per_species_include_cond db_count_hunters_per_species_include_cond = new DB_count_hunters_per_species_include_cond();
if (_count_hunters_per_species_include_cond.IDCOUNT_HUNTERS_PER_SPECIES_INCLUDE_COND == 0)
{
res = db_count_hunters_per_species_include_cond.Add(_count_hunters_per_species_include_cond, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_count_hunters_per_species_include_cond.Update(_count_hunters_per_species_include_cond, conn, tran);
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
string mupdate = "UPDATE count_hunters_per_species_include_cond SET "+"idRecHunter="+idrechunter.ToString()+(char)44+"idRecSpecies="+idrecspecies.ToString()+" WHERE NumberOfHunters="+numberofhunters.ToString();
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
string del = "DELETE FROM count_hunters_per_species_include_cond WHERE NumberOfHunters="+numberofhunters.ToString();
 // NumberOfHunters=OldData[i].ToString() AND
 // idRecHunter=OldData[i].ToString() AND
 // idRecSpecies=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM count_hunters_per_species_include_cond " +SearchExp;
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
string alistsearch = "SELECT * FROM count_hunters_per_species_include_cond";
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
string dtsearch = "SELECT * FROM count_hunters_per_species_include_cond " +SearchExp;
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
string dtsearch = "SELECT * FROM count_hunters_per_species_include_cond";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
