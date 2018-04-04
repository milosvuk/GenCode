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
 
public class alltransactions
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public alltransactions()
{
 
  
 
}
 
public alltransactions (System.Int32 _idrec,System.Int32 _iddoc,System.String _dateofdoc,System.String _typeofdoc,System.String _description,System.Decimal _amountofdoc,System.Decimal _remainingamount )
{
idrec=_idrec;
iddoc=_iddoc;
dateofdoc=_dateofdoc;
typeofdoc=_typeofdoc;
description=_description;
amountofdoc=_amountofdoc;
remainingamount=_remainingamount;
}
 
 
private System.Int32 idrec;
 
public System.Int32 IDREC
{
get
{
return idrec;
}
set
{
idrec=value;
}
}
 
private System.Int32 iddoc;
 
public System.Int32 IDDOC
{
get
{
return iddoc;
}
set
{
iddoc=value;
}
}
 
private System.String dateofdoc;
 
public System.String DATEOFDOC
{
get
{
return dateofdoc;
}
set
{
dateofdoc=value;
}
}
 
private System.String typeofdoc;
 
public System.String TYPEOFDOC
{
get
{
return typeofdoc;
}
set
{
typeofdoc=value;
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
 
private System.Decimal amountofdoc;
 
public System.Decimal AMOUNTOFDOC
{
get
{
return amountofdoc;
}
set
{
amountofdoc=value;
}
}
 
private System.Decimal remainingamount;
 
public System.Decimal REMAININGAMOUNT
{
get
{
return remainingamount;
}
set
{
remainingamount=value;
}
}
 
 
public void New()
{
idrec = 0;
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
// INSERT INTO alltransactions(idRec,idDoc,DateOfDoc,TypeOfDoc,Description,AmountOfDoc,RemainingAmount ) VALUES(idrec,iddoc,dateofdoc,typeofdoc,description,amountofdoc,remainingamount );
// For string you need 'string', for datetime 'datetime for numbers just number.ToString();
return numberinsert;
}
 
 
public int InsertCommand(int IndexOfIncrementField, string Con)
{
// Use this InsertCommand with PrimaryKey Field is AutoIncement;
int numberinsert=0;
string minsert = "INSERT INTO alltransactions(idDoc,DateOfDoc,TypeOfDoc,Description,AmountOfDoc,RemainingAmount ) VALUES("+iddoc.ToString()+(char)44+(char)39+dateofdoc.ToString()+(char)39+(char)44+(char)39+typeofdoc.ToString()+(char)39+(char)44+(char)39+description.ToString()+(char)39+(char)44+amountofdoc.ToString()+(char)44+remainingamount.ToString()+(char)41;
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
public bool Save(alltransactions _alltransactions)
{
bool tmp = false;
int res = -1;
_alltransactions.DELETED = 1;
// ADD apostrof ConnectionStrings[devdb]
 SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);
conn.Open();
SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);
try
{
DB_alltransactions db_alltransactions = new DB_alltransactions();
if (_alltransactions.IDALLTRANSACTIONS == 0)
{
res = db_alltransactions.Add(_alltransactions, conn, tran);
tran.Commit();
tmp = true;
}
else
{
res = db_alltransactions.Update(_alltransactions, conn, tran);
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
string mupdate = "UPDATE alltransactions SET "+"idDoc="+iddoc.ToString()+(char)44+"DateOfDoc="+(char)39+dateofdoc.ToString()+(char)39+(char)44+"TypeOfDoc="+(char)39+typeofdoc.ToString()+(char)39+(char)44+"Description="+(char)39+description.ToString()+(char)39+(char)44+"AmountOfDoc="+amountofdoc.ToString()+(char)44+"RemainingAmount="+remainingamount.ToString()+" WHERE idRec="+idrec.ToString();
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
string del = "DELETE FROM alltransactions WHERE idRec="+idrec.ToString();
 // idRec=OldData[i].ToString() AND
 // idDoc=OldData[i].ToString() AND
 // DateOfDoc=OldData[i].ToString() AND
 // TypeOfDoc=OldData[i].ToString() AND
 // Description=OldData[i].ToString() AND
 // AmountOfDoc=OldData[i].ToString() AND
 // RemainingAmount=OldData[i].ToString() AND
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
string alistsearch = "SELECT * FROM alltransactions " +SearchExp;
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
string alistsearch = "SELECT * FROM alltransactions";
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
string dtsearch = "SELECT * FROM alltransactions " +SearchExp;
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
string dtsearch = "SELECT * FROM alltransactions";
ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();
sq.DbaseConnection = Con;
sq.SqlText = dtsearch;
dt = sq.RunViewSQL();
sq = null;
return dt;
}
 
}
