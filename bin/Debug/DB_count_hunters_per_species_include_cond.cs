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
 
public class DB_count_hunters_per_species_include_cond
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_count_hunters_per_species_include_cond()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(count_hunters_per_species_include_cond _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(count_hunters_per_species_include_cond _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO count_hunters_per_species_include_cond (idRecHunter,idRecSpecies) VALUES (@idRecHunter,@idRecSpecies) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idRecHunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@idRecSpecies", _tmpObject.IDRECSPECIES));
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
 
public int Update(count_hunters_per_species_include_cond _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(count_hunters_per_species_include_cond _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE count_hunters_per_species_include_cond SET idRecHunter=@idrechunter,idRecSpecies=@idrecspecies  WHERE NumberOfHunters=@numberofhunters", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
command.Parameters.Add(new SqlParameter("@idrecspecies", _tmpObject.IDRECSPECIES));
command.Parameters.Add(new SqlParameter("@numberofhunters", _tmpObject.NUMBEROFHUNTERS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(count_hunters_per_species_include_cond _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(count_hunters_per_species_include_cond _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE count_hunters_per_species_include_cond  WHERE NumberOfHunters=@numberofhunters", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@numberofhunters", _tmpObject.NUMBEROFHUNTERS));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public count_hunters_per_species_include_cond GetById(int _id)
{
count_hunters_per_species_include_cond tmpObject = new count_hunters_per_species_include_cond();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From count_hunters_per_species_include_cond WHERE NumberOfHunters=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.NUMBEROFHUNTERS = (System.Int32)dr["NumberOfHunters"];
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
////==========================================================================
//GET ALL ---------------------------------------------
////==========================================================================
public List<count_hunters_per_species_include_cond> GetAll()
{
List<count_hunters_per_species_include_cond> tmpList = new List<count_hunters_per_species_include_cond>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From count_hunters_per_species_include_cond", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
count_hunters_per_species_include_cond tmpObject = new count_hunters_per_species_include_cond();
msgRecField="-";
msgRecField=msgRecField + "NumberOfHunters=";
msgRecField=msgRecField + dr["NumberOfHunters"].ToString() +"=";
tmpObject.NUMBEROFHUNTERS = (System.Int32)dr["NumberOfHunters"];
msgRecField=msgRecField + "idRecHunter=";
msgRecField=msgRecField + dr["idRecHunter"].ToString() +"=";
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
msgRecField=msgRecField + "idRecSpecies=";
msgRecField=msgRecField + dr["idRecSpecies"].ToString() +"=";
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
tmpList.Add(tmpObject);
}
 catch (Exception ex)
{
alErrors.Add(LogException(ex));
alErrors.Add(msgRecField);
msgRecField="-";
}
}
dr.Close();
conn.Close();
return tmpList;
}
////==========================================================================
//END OF GetALL ==============
////==========================================================================
////==========================================================================
//GET ALL by cond ---------------------------------------------
////==========================================================================
public List<count_hunters_per_species_include_cond> GetAllByCond(string cond)
{
List<count_hunters_per_species_include_cond> tmpList = new List<count_hunters_per_species_include_cond>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From count_hunters_per_species_include_cond Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
count_hunters_per_species_include_cond tmpObject = new count_hunters_per_species_include_cond();
msgRecField="-";
msgRecField=msgRecField + "NumberOfHunters=";
msgRecField=msgRecField + dr["NumberOfHunters"].ToString() +"=";
tmpObject.NUMBEROFHUNTERS = (System.Int32)dr["NumberOfHunters"];
msgRecField=msgRecField + "idRecHunter=";
msgRecField=msgRecField + dr["idRecHunter"].ToString() +"=";
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
msgRecField=msgRecField + "idRecSpecies=";
msgRecField=msgRecField + dr["idRecSpecies"].ToString() +"=";
tmpObject.IDRECSPECIES = (System.Int32)dr["idRecSpecies"];
tmpList.Add(tmpObject);
}
 catch (Exception ex)
{
alErrors.Add(LogException(ex));
alErrors.Add(msgRecField);
msgRecField="-";
}
}
dr.Close();
conn.Close();
return tmpList;
}
////==========================================================================
//END OF GetALL ==============
////==========================================================================
////==========================================================================
 
public string CheckStringFromField(string StringToCheck, int typeOfReturn)
{
string res = StringToCheck;
if (typeOfReturn == 1 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="No Data";
return res;
}
if (typeOfReturn == 2 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="0";
return res;
}
if (typeOfReturn == 3 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="01/01/1800";
return res;
}
return res;
// using  like CheckStringFromTxtFile(fields[0],1);
}

    private string GetExceptionTypeStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionTypeStack(e.InnerException);
        message = message + "   " + e.GetType().ToString();
        return message;
      }
      else
      {
        return "   " + e.GetType().ToString();
      }
    }

    private string GetExceptionMessageStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionMessageStack(e.InnerException);
        message = message + "   " + e.Message;
        return message;
      }
      else
      {
        return "   " + e.Message;
      }
    }

    private string GetExceptionCallStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionCallStack(e.InnerException);
        message = message + "--- Next Call Stack: ";
        message =  message + e.StackTrace;
        return message;
      }
      else
      {
        return e.StackTrace;
      }
    }


   public string LogException(Exception exception)
    {
      string  error = "";

      error = "Exception classes:   ";
      error = error + GetExceptionTypeStack(exception);
      error = error + " ";
      error = error + " Exception messages: ";
      error = error +GetExceptionMessageStack(exception);

      error= error + " ";
      error= error +" Stack Traces: ";
      error= error +GetExceptionCallStack(exception);
     
      return error;
    }
}
 
