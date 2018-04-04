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
 
public class DB_documentsb
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_documentsb()
{
 
   System.Configuration.ConnectionStringSettings connString;
    connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
    connectionString = connString.ConnectionString;
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(documentsb _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(documentsb _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO documentsb (idProperty,Description,TypeOfDoc,DocInBinFormat,Keyword1,Keyword2,Keyword3,IdCompany) VALUES (@idProperty,@Description,@TypeOfDoc,@DocInBinFormat,@Keyword1,@Keyword2,@Keyword3,@IdCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@Description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@TypeOfDoc", _tmpObject.TYPEOFDOC));
command.Parameters.Add(new SqlParameter("@DocInBinFormat", _tmpObject.DOCINBINFORMAT));
command.Parameters.Add(new SqlParameter("@Keyword1", _tmpObject.KEYWORD1));
command.Parameters.Add(new SqlParameter("@Keyword2", _tmpObject.KEYWORD2));
command.Parameters.Add(new SqlParameter("@Keyword3", _tmpObject.KEYWORD3));
command.Parameters.Add(new SqlParameter("@IdCompany", _tmpObject.IDCOMPANY));
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
 
public int Update(documentsb _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(documentsb _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE documentsb SET idProperty=@idproperty,Description=@description,TypeOfDoc=@typeofdoc,DocInBinFormat=@docinbinformat,Keyword1=@keyword1,Keyword2=@keyword2,Keyword3=@keyword3,IdCompany=@idcompany  WHERE idRecDocument=@idrecdocument", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@typeofdoc", _tmpObject.TYPEOFDOC));
command.Parameters.Add(new SqlParameter("@docinbinformat", _tmpObject.DOCINBINFORMAT));
command.Parameters.Add(new SqlParameter("@keyword1", _tmpObject.KEYWORD1));
command.Parameters.Add(new SqlParameter("@keyword2", _tmpObject.KEYWORD2));
command.Parameters.Add(new SqlParameter("@keyword3", _tmpObject.KEYWORD3));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idrecdocument", _tmpObject.IDRECDOCUMENT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(documentsb _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(documentsb _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE documentsb  WHERE idRecDocument=@idrecdocument", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrecdocument", _tmpObject.IDRECDOCUMENT));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public documentsb GetById(int _id)
{
documentsb tmpObject = new documentsb();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From documentsb WHERE idRecDocument=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECDOCUMENT = (System.Int32)dr["idRecDocument"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.DESCRIPTION = (System.String)dr["Description"];
tmpObject.TYPEOFDOC = (System.String)dr["TypeOfDoc"];
tmpObject.DOCINBINFORMAT = (System.Byte[])dr["DocInBinFormat"];
tmpObject.KEYWORD1 = (System.String)dr["Keyword1"];
tmpObject.KEYWORD2 = (System.String)dr["Keyword2"];
tmpObject.KEYWORD3 = (System.String)dr["Keyword3"];
tmpObject.IDCOMPANY = (System.Int32)dr["IdCompany"];
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
public List<documentsb> GetAll()
{
List<documentsb> tmpList = new List<documentsb>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From documentsb", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
documentsb tmpObject = new documentsb();
msgRecField="-";
msgRecField=msgRecField + "idRecDocument=";
msgRecField=msgRecField + dr["idRecDocument"].ToString() +"=";
tmpObject.IDRECDOCUMENT = (System.Int32)dr["idRecDocument"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "TypeOfDoc=";
msgRecField=msgRecField + dr["TypeOfDoc"].ToString() +"=";
tmpObject.TYPEOFDOC = (System.String)dr["TypeOfDoc"];
msgRecField=msgRecField + "DocInBinFormat=";
msgRecField=msgRecField + dr["DocInBinFormat"].ToString() +"=";
tmpObject.DOCINBINFORMAT = (System.Byte[])dr["DocInBinFormat"];
msgRecField=msgRecField + "Keyword1=";
msgRecField=msgRecField + dr["Keyword1"].ToString() +"=";
tmpObject.KEYWORD1 = (System.String)dr["Keyword1"];
msgRecField=msgRecField + "Keyword2=";
msgRecField=msgRecField + dr["Keyword2"].ToString() +"=";
tmpObject.KEYWORD2 = (System.String)dr["Keyword2"];
msgRecField=msgRecField + "Keyword3=";
msgRecField=msgRecField + dr["Keyword3"].ToString() +"=";
tmpObject.KEYWORD3 = (System.String)dr["Keyword3"];
msgRecField=msgRecField + "IdCompany=";
msgRecField=msgRecField + dr["IdCompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["IdCompany"];
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
public List<documentsb> GetAllByCond(string cond)
{
List<documentsb> tmpList = new List<documentsb>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From documentsb Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
documentsb tmpObject = new documentsb();
msgRecField="-";
msgRecField=msgRecField + "idRecDocument=";
msgRecField=msgRecField + dr["idRecDocument"].ToString() +"=";
tmpObject.IDRECDOCUMENT = (System.Int32)dr["idRecDocument"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "Description=";
msgRecField=msgRecField + dr["Description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["Description"];
msgRecField=msgRecField + "TypeOfDoc=";
msgRecField=msgRecField + dr["TypeOfDoc"].ToString() +"=";
tmpObject.TYPEOFDOC = (System.String)dr["TypeOfDoc"];
msgRecField=msgRecField + "DocInBinFormat=";
msgRecField=msgRecField + dr["DocInBinFormat"].ToString() +"=";
tmpObject.DOCINBINFORMAT = (System.Byte[])dr["DocInBinFormat"];
msgRecField=msgRecField + "Keyword1=";
msgRecField=msgRecField + dr["Keyword1"].ToString() +"=";
tmpObject.KEYWORD1 = (System.String)dr["Keyword1"];
msgRecField=msgRecField + "Keyword2=";
msgRecField=msgRecField + dr["Keyword2"].ToString() +"=";
tmpObject.KEYWORD2 = (System.String)dr["Keyword2"];
msgRecField=msgRecField + "Keyword3=";
msgRecField=msgRecField + dr["Keyword3"].ToString() +"=";
tmpObject.KEYWORD3 = (System.String)dr["Keyword3"];
msgRecField=msgRecField + "IdCompany=";
msgRecField=msgRecField + dr["IdCompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["IdCompany"];
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
 
