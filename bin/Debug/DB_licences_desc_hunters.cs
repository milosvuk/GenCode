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
 
public class DB_licences_desc_hunters
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_licences_desc_hunters()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(licences_desc_hunters _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(licences_desc_hunters _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO licences_desc_hunters (IdCardNumber,Surname,Name,LicencedMobileNumber,idRecLicence,LicenceYear,Paid,Amount,LicenceDescription,StartDate,EndDate,ActiveL,Address2,Address1,Locality,MaltaOrGozo) VALUES (@IdCardNumber,@Surname,@Name,@LicencedMobileNumber,@idRecLicence,@LicenceYear,@Paid,@Amount,@LicenceDescription,@StartDate,@EndDate,@ActiveL,@Address2,@Address1,@Locality,@MaltaOrGozo) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@IdCardNumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@Surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@Name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@LicencedMobileNumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@idRecLicence", _tmpObject.IDRECLICENCE));
command.Parameters.Add(new SqlParameter("@LicenceYear", _tmpObject.LICENCEYEAR));
command.Parameters.Add(new SqlParameter("@Paid", _tmpObject.PAID));
command.Parameters.Add(new SqlParameter("@Amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@LicenceDescription", _tmpObject.LICENCEDESCRIPTION));
command.Parameters.Add(new SqlParameter("@StartDate", _tmpObject.STARTDATE));
command.Parameters.Add(new SqlParameter("@EndDate", _tmpObject.ENDDATE));
command.Parameters.Add(new SqlParameter("@ActiveL", _tmpObject.ACTIVEL));
command.Parameters.Add(new SqlParameter("@Address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@Address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@Locality", _tmpObject.LOCALITY));
command.Parameters.Add(new SqlParameter("@MaltaOrGozo", _tmpObject.MALTAORGOZO));
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
 
public int Update(licences_desc_hunters _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(licences_desc_hunters _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE licences_desc_hunters SET IdCardNumber=@idcardnumber,Surname=@surname,Name=@name,LicencedMobileNumber=@licencedmobilenumber,idRecLicence=@idreclicence,LicenceYear=@licenceyear,Paid=@paid,Amount=@amount,LicenceDescription=@licencedescription,StartDate=@startdate,EndDate=@enddate,ActiveL=@activel,Address2=@address2,Address1=@address1,Locality=@locality,MaltaOrGozo=@maltaorgozo  WHERE idRecHunter=@idrechunter", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idcardnumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@licencedmobilenumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@idreclicence", _tmpObject.IDRECLICENCE));
command.Parameters.Add(new SqlParameter("@licenceyear", _tmpObject.LICENCEYEAR));
command.Parameters.Add(new SqlParameter("@paid", _tmpObject.PAID));
command.Parameters.Add(new SqlParameter("@amount", _tmpObject.AMOUNT));
command.Parameters.Add(new SqlParameter("@licencedescription", _tmpObject.LICENCEDESCRIPTION));
command.Parameters.Add(new SqlParameter("@startdate", _tmpObject.STARTDATE));
command.Parameters.Add(new SqlParameter("@enddate", _tmpObject.ENDDATE));
command.Parameters.Add(new SqlParameter("@activel", _tmpObject.ACTIVEL));
command.Parameters.Add(new SqlParameter("@address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@locality", _tmpObject.LOCALITY));
command.Parameters.Add(new SqlParameter("@maltaorgozo", _tmpObject.MALTAORGOZO));
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(licences_desc_hunters _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(licences_desc_hunters _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE licences_desc_hunters  WHERE idRecHunter=@idrechunter", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrechunter", _tmpObject.IDRECHUNTER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public licences_desc_hunters GetById(int _id)
{
licences_desc_hunters tmpObject = new licences_desc_hunters();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From licences_desc_hunters WHERE idRecHunter=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
tmpObject.SURNAME = (System.String)dr["Surname"];
tmpObject.NAME = (System.String)dr["Name"];
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
tmpObject.IDRECLICENCE = (System.Int32)dr["idRecLicence"];
tmpObject.LICENCEYEAR = (System.Int32)dr["LicenceYear"];
tmpObject.PAID = (System.Int32)dr["Paid"];
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
tmpObject.LICENCEDESCRIPTION = (System.String)dr["LicenceDescription"];
tmpObject.STARTDATE = (System.DateTime)dr["StartDate"];
tmpObject.ENDDATE = (System.DateTime)dr["EndDate"];
tmpObject.ACTIVEL = (System.Int32)dr["ActiveL"];
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
tmpObject.LOCALITY = (System.String)dr["Locality"];
tmpObject.MALTAORGOZO = (System.String)dr["MaltaOrGozo"];
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
public List<licences_desc_hunters> GetAll()
{
List<licences_desc_hunters> tmpList = new List<licences_desc_hunters>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From licences_desc_hunters", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
licences_desc_hunters tmpObject = new licences_desc_hunters();
msgRecField="-";
msgRecField=msgRecField + "idRecHunter=";
msgRecField=msgRecField + dr["idRecHunter"].ToString() +"=";
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
msgRecField=msgRecField + "IdCardNumber=";
msgRecField=msgRecField + dr["IdCardNumber"].ToString() +"=";
tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
msgRecField=msgRecField + "Surname=";
msgRecField=msgRecField + dr["Surname"].ToString() +"=";
tmpObject.SURNAME = (System.String)dr["Surname"];
msgRecField=msgRecField + "Name=";
msgRecField=msgRecField + dr["Name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["Name"];
msgRecField=msgRecField + "LicencedMobileNumber=";
msgRecField=msgRecField + dr["LicencedMobileNumber"].ToString() +"=";
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
msgRecField=msgRecField + "idRecLicence=";
msgRecField=msgRecField + dr["idRecLicence"].ToString() +"=";
tmpObject.IDRECLICENCE = (System.Int32)dr["idRecLicence"];
msgRecField=msgRecField + "LicenceYear=";
msgRecField=msgRecField + dr["LicenceYear"].ToString() +"=";
tmpObject.LICENCEYEAR = (System.Int32)dr["LicenceYear"];
msgRecField=msgRecField + "Paid=";
msgRecField=msgRecField + dr["Paid"].ToString() +"=";
tmpObject.PAID = (System.Int32)dr["Paid"];
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
msgRecField=msgRecField + "LicenceDescription=";
msgRecField=msgRecField + dr["LicenceDescription"].ToString() +"=";
tmpObject.LICENCEDESCRIPTION = (System.String)dr["LicenceDescription"];
msgRecField=msgRecField + "StartDate=";
msgRecField=msgRecField + dr["StartDate"].ToString() +"=";
tmpObject.STARTDATE = (System.DateTime)dr["StartDate"];
msgRecField=msgRecField + "EndDate=";
msgRecField=msgRecField + dr["EndDate"].ToString() +"=";
tmpObject.ENDDATE = (System.DateTime)dr["EndDate"];
msgRecField=msgRecField + "ActiveL=";
msgRecField=msgRecField + dr["ActiveL"].ToString() +"=";
tmpObject.ACTIVEL = (System.Int32)dr["ActiveL"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Locality=";
msgRecField=msgRecField + dr["Locality"].ToString() +"=";
tmpObject.LOCALITY = (System.String)dr["Locality"];
msgRecField=msgRecField + "MaltaOrGozo=";
msgRecField=msgRecField + dr["MaltaOrGozo"].ToString() +"=";
tmpObject.MALTAORGOZO = (System.String)dr["MaltaOrGozo"];
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
public List<licences_desc_hunters> GetAllByCond(string cond)
{
List<licences_desc_hunters> tmpList = new List<licences_desc_hunters>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From licences_desc_hunters Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
licences_desc_hunters tmpObject = new licences_desc_hunters();
msgRecField="-";
msgRecField=msgRecField + "idRecHunter=";
msgRecField=msgRecField + dr["idRecHunter"].ToString() +"=";
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
msgRecField=msgRecField + "IdCardNumber=";
msgRecField=msgRecField + dr["IdCardNumber"].ToString() +"=";
tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
msgRecField=msgRecField + "Surname=";
msgRecField=msgRecField + dr["Surname"].ToString() +"=";
tmpObject.SURNAME = (System.String)dr["Surname"];
msgRecField=msgRecField + "Name=";
msgRecField=msgRecField + dr["Name"].ToString() +"=";
tmpObject.NAME = (System.String)dr["Name"];
msgRecField=msgRecField + "LicencedMobileNumber=";
msgRecField=msgRecField + dr["LicencedMobileNumber"].ToString() +"=";
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
msgRecField=msgRecField + "idRecLicence=";
msgRecField=msgRecField + dr["idRecLicence"].ToString() +"=";
tmpObject.IDRECLICENCE = (System.Int32)dr["idRecLicence"];
msgRecField=msgRecField + "LicenceYear=";
msgRecField=msgRecField + dr["LicenceYear"].ToString() +"=";
tmpObject.LICENCEYEAR = (System.Int32)dr["LicenceYear"];
msgRecField=msgRecField + "Paid=";
msgRecField=msgRecField + dr["Paid"].ToString() +"=";
tmpObject.PAID = (System.Int32)dr["Paid"];
msgRecField=msgRecField + "Amount=";
msgRecField=msgRecField + dr["Amount"].ToString() +"=";
tmpObject.AMOUNT = (System.Decimal)dr["Amount"];
msgRecField=msgRecField + "LicenceDescription=";
msgRecField=msgRecField + dr["LicenceDescription"].ToString() +"=";
tmpObject.LICENCEDESCRIPTION = (System.String)dr["LicenceDescription"];
msgRecField=msgRecField + "StartDate=";
msgRecField=msgRecField + dr["StartDate"].ToString() +"=";
tmpObject.STARTDATE = (System.DateTime)dr["StartDate"];
msgRecField=msgRecField + "EndDate=";
msgRecField=msgRecField + dr["EndDate"].ToString() +"=";
tmpObject.ENDDATE = (System.DateTime)dr["EndDate"];
msgRecField=msgRecField + "ActiveL=";
msgRecField=msgRecField + dr["ActiveL"].ToString() +"=";
tmpObject.ACTIVEL = (System.Int32)dr["ActiveL"];
msgRecField=msgRecField + "Address2=";
msgRecField=msgRecField + dr["Address2"].ToString() +"=";
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
msgRecField=msgRecField + "Address1=";
msgRecField=msgRecField + dr["Address1"].ToString() +"=";
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
msgRecField=msgRecField + "Locality=";
msgRecField=msgRecField + dr["Locality"].ToString() +"=";
tmpObject.LOCALITY = (System.String)dr["Locality"];
msgRecField=msgRecField + "MaltaOrGozo=";
msgRecField=msgRecField + dr["MaltaOrGozo"].ToString() +"=";
tmpObject.MALTAORGOZO = (System.String)dr["MaltaOrGozo"];
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
 
