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
 
public class DB_propertycustomer
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_propertycustomer()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(propertycustomer _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(propertycustomer _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO propertycustomer (idProperty,idCustomer,LeaseAgDateFrom,LeaseAgDateTo,idNotary,DateOfAg,FrenqOfPayment,AmountOfContract,IncreasePerc,IncreaseAmount,IncreaseCostOfLiving,FreqInDaysToApplyIncrease,DateofLastinvoice,AmtOfLastInvoice,Active,idCompany) VALUES (@idProperty,@idCustomer,@LeaseAgDateFrom,@LeaseAgDateTo,@idNotary,@DateOfAg,@FrenqOfPayment,@AmountOfContract,@IncreasePerc,@IncreaseAmount,@IncreaseCostOfLiving,@FreqInDaysToApplyIncrease,@DateofLastinvoice,@AmtOfLastInvoice,@Active,@idCompany) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idProperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idCustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@LeaseAgDateFrom", _tmpObject.LEASEAGDATEFROM));
command.Parameters.Add(new SqlParameter("@LeaseAgDateTo", _tmpObject.LEASEAGDATETO));
command.Parameters.Add(new SqlParameter("@idNotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@DateOfAg", _tmpObject.DATEOFAG));
command.Parameters.Add(new SqlParameter("@FrenqOfPayment", _tmpObject.FRENQOFPAYMENT));
command.Parameters.Add(new SqlParameter("@AmountOfContract", _tmpObject.AMOUNTOFCONTRACT));
command.Parameters.Add(new SqlParameter("@IncreasePerc", _tmpObject.INCREASEPERC));
command.Parameters.Add(new SqlParameter("@IncreaseAmount", _tmpObject.INCREASEAMOUNT));
command.Parameters.Add(new SqlParameter("@IncreaseCostOfLiving", _tmpObject.INCREASECOSTOFLIVING));
command.Parameters.Add(new SqlParameter("@FreqInDaysToApplyIncrease", _tmpObject.FREQINDAYSTOAPPLYINCREASE));
command.Parameters.Add(new SqlParameter("@DateofLastinvoice", _tmpObject.DATEOFLASTINVOICE));
command.Parameters.Add(new SqlParameter("@AmtOfLastInvoice", _tmpObject.AMTOFLASTINVOICE));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idCompany", _tmpObject.IDCOMPANY));
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
 
public int Update(propertycustomer _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(propertycustomer _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE propertycustomer SET idProperty=@idproperty,idCustomer=@idcustomer,LeaseAgDateFrom=@leaseagdatefrom,LeaseAgDateTo=@leaseagdateto,idNotary=@idnotary,DateOfAg=@dateofag,FrenqOfPayment=@frenqofpayment,AmountOfContract=@amountofcontract,IncreasePerc=@increaseperc,IncreaseAmount=@increaseamount,IncreaseCostOfLiving=@increasecostofliving,FreqInDaysToApplyIncrease=@freqindaystoapplyincrease,DateofLastinvoice=@dateoflastinvoice,AmtOfLastInvoice=@amtoflastinvoice,Active=@active,idCompany=@idcompany  WHERE idPropertyCustomer=@idpropertycustomer", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idproperty", _tmpObject.IDPROPERTY));
command.Parameters.Add(new SqlParameter("@idcustomer", _tmpObject.IDCUSTOMER));
command.Parameters.Add(new SqlParameter("@leaseagdatefrom", _tmpObject.LEASEAGDATEFROM));
command.Parameters.Add(new SqlParameter("@leaseagdateto", _tmpObject.LEASEAGDATETO));
command.Parameters.Add(new SqlParameter("@idnotary", _tmpObject.IDNOTARY));
command.Parameters.Add(new SqlParameter("@dateofag", _tmpObject.DATEOFAG));
command.Parameters.Add(new SqlParameter("@frenqofpayment", _tmpObject.FRENQOFPAYMENT));
command.Parameters.Add(new SqlParameter("@amountofcontract", _tmpObject.AMOUNTOFCONTRACT));
command.Parameters.Add(new SqlParameter("@increaseperc", _tmpObject.INCREASEPERC));
command.Parameters.Add(new SqlParameter("@increaseamount", _tmpObject.INCREASEAMOUNT));
command.Parameters.Add(new SqlParameter("@increasecostofliving", _tmpObject.INCREASECOSTOFLIVING));
command.Parameters.Add(new SqlParameter("@freqindaystoapplyincrease", _tmpObject.FREQINDAYSTOAPPLYINCREASE));
command.Parameters.Add(new SqlParameter("@dateoflastinvoice", _tmpObject.DATEOFLASTINVOICE));
command.Parameters.Add(new SqlParameter("@amtoflastinvoice", _tmpObject.AMTOFLASTINVOICE));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
command.Parameters.Add(new SqlParameter("@idcompany", _tmpObject.IDCOMPANY));
command.Parameters.Add(new SqlParameter("@idpropertycustomer", _tmpObject.IDPROPERTYCUSTOMER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(propertycustomer _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(propertycustomer _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE propertycustomer  WHERE idPropertyCustomer=@idpropertycustomer", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idpropertycustomer", _tmpObject.IDPROPERTYCUSTOMER));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public propertycustomer GetById(int _id)
{
propertycustomer tmpObject = new propertycustomer();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomer WHERE idPropertyCustomer=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
tmpObject.LEASEAGDATEFROM = (System.DateTime)dr["LeaseAgDateFrom"];
tmpObject.LEASEAGDATETO = (System.DateTime)dr["LeaseAgDateTo"];
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
tmpObject.DATEOFAG = (System.DateTime)dr["DateOfAg"];
tmpObject.FRENQOFPAYMENT = (System.Int32)dr["FrenqOfPayment"];
tmpObject.AMOUNTOFCONTRACT = (System.Decimal)dr["AmountOfContract"];
tmpObject.INCREASEPERC = (System.Int32)dr["IncreasePerc"];
tmpObject.INCREASEAMOUNT = (System.Decimal)dr["IncreaseAmount"];
tmpObject.INCREASECOSTOFLIVING = (System.Int32)dr["IncreaseCostOfLiving"];
tmpObject.FREQINDAYSTOAPPLYINCREASE = (System.Int32)dr["FreqInDaysToApplyIncrease"];
tmpObject.DATEOFLASTINVOICE = (System.DateTime)dr["DateofLastinvoice"];
tmpObject.AMTOFLASTINVOICE = (System.Decimal)dr["AmtOfLastInvoice"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
tmpObject.IDCOMPANY = (System.Int32)dr["idCompany"];
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
public List<propertycustomer> GetAll()
{
List<propertycustomer> tmpList = new List<propertycustomer>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomer", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomer tmpObject = new propertycustomer();
msgRecField="-";
msgRecField=msgRecField + "idPropertyCustomer=";
msgRecField=msgRecField + dr["idPropertyCustomer"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "LeaseAgDateFrom=";
msgRecField=msgRecField + dr["LeaseAgDateFrom"].ToString() +"=";
tmpObject.LEASEAGDATEFROM = (System.DateTime)dr["LeaseAgDateFrom"];
msgRecField=msgRecField + "LeaseAgDateTo=";
msgRecField=msgRecField + dr["LeaseAgDateTo"].ToString() +"=";
tmpObject.LEASEAGDATETO = (System.DateTime)dr["LeaseAgDateTo"];
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "DateOfAg=";
msgRecField=msgRecField + dr["DateOfAg"].ToString() +"=";
tmpObject.DATEOFAG = (System.DateTime)dr["DateOfAg"];
msgRecField=msgRecField + "FrenqOfPayment=";
msgRecField=msgRecField + dr["FrenqOfPayment"].ToString() +"=";
tmpObject.FRENQOFPAYMENT = (System.Int32)dr["FrenqOfPayment"];
msgRecField=msgRecField + "AmountOfContract=";
msgRecField=msgRecField + dr["AmountOfContract"].ToString() +"=";
tmpObject.AMOUNTOFCONTRACT = (System.Decimal)dr["AmountOfContract"];
msgRecField=msgRecField + "IncreasePerc=";
msgRecField=msgRecField + dr["IncreasePerc"].ToString() +"=";
tmpObject.INCREASEPERC = (System.Int32)dr["IncreasePerc"];
msgRecField=msgRecField + "IncreaseAmount=";
msgRecField=msgRecField + dr["IncreaseAmount"].ToString() +"=";
tmpObject.INCREASEAMOUNT = (System.Decimal)dr["IncreaseAmount"];
msgRecField=msgRecField + "IncreaseCostOfLiving=";
msgRecField=msgRecField + dr["IncreaseCostOfLiving"].ToString() +"=";
tmpObject.INCREASECOSTOFLIVING = (System.Int32)dr["IncreaseCostOfLiving"];
msgRecField=msgRecField + "FreqInDaysToApplyIncrease=";
msgRecField=msgRecField + dr["FreqInDaysToApplyIncrease"].ToString() +"=";
tmpObject.FREQINDAYSTOAPPLYINCREASE = (System.Int32)dr["FreqInDaysToApplyIncrease"];
msgRecField=msgRecField + "DateofLastinvoice=";
msgRecField=msgRecField + dr["DateofLastinvoice"].ToString() +"=";
tmpObject.DATEOFLASTINVOICE = (System.DateTime)dr["DateofLastinvoice"];
msgRecField=msgRecField + "AmtOfLastInvoice=";
msgRecField=msgRecField + dr["AmtOfLastInvoice"].ToString() +"=";
tmpObject.AMTOFLASTINVOICE = (System.Decimal)dr["AmtOfLastInvoice"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
msgRecField=msgRecField + "idCompany=";
msgRecField=msgRecField + dr["idCompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idCompany"];
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
public List<propertycustomer> GetAllByCond(string cond)
{
List<propertycustomer> tmpList = new List<propertycustomer>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From propertycustomer Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
propertycustomer tmpObject = new propertycustomer();
msgRecField="-";
msgRecField=msgRecField + "idPropertyCustomer=";
msgRecField=msgRecField + dr["idPropertyCustomer"].ToString() +"=";
tmpObject.IDPROPERTYCUSTOMER = (System.Int32)dr["idPropertyCustomer"];
msgRecField=msgRecField + "idProperty=";
msgRecField=msgRecField + dr["idProperty"].ToString() +"=";
tmpObject.IDPROPERTY = (System.Int32)dr["idProperty"];
msgRecField=msgRecField + "idCustomer=";
msgRecField=msgRecField + dr["idCustomer"].ToString() +"=";
tmpObject.IDCUSTOMER = (System.Int32)dr["idCustomer"];
msgRecField=msgRecField + "LeaseAgDateFrom=";
msgRecField=msgRecField + dr["LeaseAgDateFrom"].ToString() +"=";
tmpObject.LEASEAGDATEFROM = (System.DateTime)dr["LeaseAgDateFrom"];
msgRecField=msgRecField + "LeaseAgDateTo=";
msgRecField=msgRecField + dr["LeaseAgDateTo"].ToString() +"=";
tmpObject.LEASEAGDATETO = (System.DateTime)dr["LeaseAgDateTo"];
msgRecField=msgRecField + "idNotary=";
msgRecField=msgRecField + dr["idNotary"].ToString() +"=";
tmpObject.IDNOTARY = (System.Int32)dr["idNotary"];
msgRecField=msgRecField + "DateOfAg=";
msgRecField=msgRecField + dr["DateOfAg"].ToString() +"=";
tmpObject.DATEOFAG = (System.DateTime)dr["DateOfAg"];
msgRecField=msgRecField + "FrenqOfPayment=";
msgRecField=msgRecField + dr["FrenqOfPayment"].ToString() +"=";
tmpObject.FRENQOFPAYMENT = (System.Int32)dr["FrenqOfPayment"];
msgRecField=msgRecField + "AmountOfContract=";
msgRecField=msgRecField + dr["AmountOfContract"].ToString() +"=";
tmpObject.AMOUNTOFCONTRACT = (System.Decimal)dr["AmountOfContract"];
msgRecField=msgRecField + "IncreasePerc=";
msgRecField=msgRecField + dr["IncreasePerc"].ToString() +"=";
tmpObject.INCREASEPERC = (System.Int32)dr["IncreasePerc"];
msgRecField=msgRecField + "IncreaseAmount=";
msgRecField=msgRecField + dr["IncreaseAmount"].ToString() +"=";
tmpObject.INCREASEAMOUNT = (System.Decimal)dr["IncreaseAmount"];
msgRecField=msgRecField + "IncreaseCostOfLiving=";
msgRecField=msgRecField + dr["IncreaseCostOfLiving"].ToString() +"=";
tmpObject.INCREASECOSTOFLIVING = (System.Int32)dr["IncreaseCostOfLiving"];
msgRecField=msgRecField + "FreqInDaysToApplyIncrease=";
msgRecField=msgRecField + dr["FreqInDaysToApplyIncrease"].ToString() +"=";
tmpObject.FREQINDAYSTOAPPLYINCREASE = (System.Int32)dr["FreqInDaysToApplyIncrease"];
msgRecField=msgRecField + "DateofLastinvoice=";
msgRecField=msgRecField + dr["DateofLastinvoice"].ToString() +"=";
tmpObject.DATEOFLASTINVOICE = (System.DateTime)dr["DateofLastinvoice"];
msgRecField=msgRecField + "AmtOfLastInvoice=";
msgRecField=msgRecField + dr["AmtOfLastInvoice"].ToString() +"=";
tmpObject.AMTOFLASTINVOICE = (System.Decimal)dr["AmtOfLastInvoice"];
msgRecField=msgRecField + "Active=";
msgRecField=msgRecField + dr["Active"].ToString() +"=";
tmpObject.ACTIVE = (System.Int32)dr["Active"];
msgRecField=msgRecField + "idCompany=";
msgRecField=msgRecField + dr["idCompany"].ToString() +"=";
tmpObject.IDCOMPANY = (System.Int32)dr["idCompany"];
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
 
