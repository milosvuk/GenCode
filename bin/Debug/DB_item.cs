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
 
public class DB_item
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_item()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(item _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(item _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO item (numOfItem,sidOfItem,id_dcs,dcs,id_vendor,aluOfItem,upcOfItem,desc1OfItem,desc2OfItem,atrOfItem,sizeOfItem,taxPercOfItem,costOfItem,priceOfItem,imageOfItem,expiryDate,id_company) VALUES (@numOfItem,@sidOfItem,@id_dcs,@dcs,@id_vendor,@aluOfItem,@upcOfItem,@desc1OfItem,@desc2OfItem,@atrOfItem,@sizeOfItem,@taxPercOfItem,@costOfItem,@priceOfItem,@imageOfItem,@expiryDate,@id_company) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@numOfItem", _tmpObject.NUMOFITEM));
command.Parameters.Add(new SqlParameter("@sidOfItem", _tmpObject.SIDOFITEM));
command.Parameters.Add(new SqlParameter("@id_dcs", _tmpObject.ID_DCS));
command.Parameters.Add(new SqlParameter("@dcs", _tmpObject.DCS));
command.Parameters.Add(new SqlParameter("@id_vendor", _tmpObject.ID_VENDOR));
command.Parameters.Add(new SqlParameter("@aluOfItem", _tmpObject.ALUOFITEM));
command.Parameters.Add(new SqlParameter("@upcOfItem", _tmpObject.UPCOFITEM));
command.Parameters.Add(new SqlParameter("@desc1OfItem", _tmpObject.DESC1OFITEM));
command.Parameters.Add(new SqlParameter("@desc2OfItem", _tmpObject.DESC2OFITEM));
command.Parameters.Add(new SqlParameter("@atrOfItem", _tmpObject.ATROFITEM));
command.Parameters.Add(new SqlParameter("@sizeOfItem", _tmpObject.SIZEOFITEM));
command.Parameters.Add(new SqlParameter("@taxPercOfItem", _tmpObject.TAXPERCOFITEM));
command.Parameters.Add(new SqlParameter("@costOfItem", _tmpObject.COSTOFITEM));
command.Parameters.Add(new SqlParameter("@priceOfItem", _tmpObject.PRICEOFITEM));
command.Parameters.Add(new SqlParameter("@imageOfItem", _tmpObject.IMAGEOFITEM));
command.Parameters.Add(new SqlParameter("@expiryDate", _tmpObject.EXPIRYDATE));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
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
 
public int Update(item _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(item _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE item SET numOfItem=@numofitem,sidOfItem=@sidofitem,id_dcs=@id_dcs,dcs=@dcs,id_vendor=@id_vendor,aluOfItem=@aluofitem,upcOfItem=@upcofitem,desc1OfItem=@desc1ofitem,desc2OfItem=@desc2ofitem,atrOfItem=@atrofitem,sizeOfItem=@sizeofitem,taxPercOfItem=@taxpercofitem,costOfItem=@costofitem,priceOfItem=@priceofitem,imageOfItem=@imageofitem,expiryDate=@expirydate,id_company=@id_company  WHERE iditem=@iditem", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@numofitem", _tmpObject.NUMOFITEM));
command.Parameters.Add(new SqlParameter("@sidofitem", _tmpObject.SIDOFITEM));
command.Parameters.Add(new SqlParameter("@id_dcs", _tmpObject.ID_DCS));
command.Parameters.Add(new SqlParameter("@dcs", _tmpObject.DCS));
command.Parameters.Add(new SqlParameter("@id_vendor", _tmpObject.ID_VENDOR));
command.Parameters.Add(new SqlParameter("@aluofitem", _tmpObject.ALUOFITEM));
command.Parameters.Add(new SqlParameter("@upcofitem", _tmpObject.UPCOFITEM));
command.Parameters.Add(new SqlParameter("@desc1ofitem", _tmpObject.DESC1OFITEM));
command.Parameters.Add(new SqlParameter("@desc2ofitem", _tmpObject.DESC2OFITEM));
command.Parameters.Add(new SqlParameter("@atrofitem", _tmpObject.ATROFITEM));
command.Parameters.Add(new SqlParameter("@sizeofitem", _tmpObject.SIZEOFITEM));
command.Parameters.Add(new SqlParameter("@taxpercofitem", _tmpObject.TAXPERCOFITEM));
command.Parameters.Add(new SqlParameter("@costofitem", _tmpObject.COSTOFITEM));
command.Parameters.Add(new SqlParameter("@priceofitem", _tmpObject.PRICEOFITEM));
command.Parameters.Add(new SqlParameter("@imageofitem", _tmpObject.IMAGEOFITEM));
command.Parameters.Add(new SqlParameter("@expirydate", _tmpObject.EXPIRYDATE));
command.Parameters.Add(new SqlParameter("@id_company", _tmpObject.ID_COMPANY));
command.Parameters.Add(new SqlParameter("@iditem", _tmpObject.IDITEM));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(item _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(item _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE item  WHERE iditem=@iditem", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@iditem", _tmpObject.IDITEM));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public item GetById(int _id)
{
item tmpObject = new item();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From item WHERE iditem=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDITEM = (System.Int32)dr["iditem"];
tmpObject.NUMOFITEM = (System.Int32)dr["numOfItem"];
tmpObject.SIDOFITEM = (System.String)dr["sidOfItem"];
tmpObject.ID_DCS = (System.Int32)dr["id_dcs"];
tmpObject.DCS = (System.String)dr["dcs"];
tmpObject.ID_VENDOR = (System.Int32)dr["id_vendor"];
tmpObject.ALUOFITEM = (System.String)dr["aluOfItem"];
tmpObject.UPCOFITEM = (System.String)dr["upcOfItem"];
tmpObject.DESC1OFITEM = (System.String)dr["desc1OfItem"];
tmpObject.DESC2OFITEM = (System.String)dr["desc2OfItem"];
tmpObject.ATROFITEM = (System.String)dr["atrOfItem"];
tmpObject.SIZEOFITEM = (System.String)dr["sizeOfItem"];
tmpObject.TAXPERCOFITEM = (System.Decimal)dr["taxPercOfItem"];
tmpObject.COSTOFITEM = (System.Decimal)dr["costOfItem"];
tmpObject.PRICEOFITEM = (System.Decimal)dr["priceOfItem"];
tmpObject.IMAGEOFITEM = (System.String)dr["imageOfItem"];
tmpObject.EXPIRYDATE = (System.DateTime)dr["expiryDate"];
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
public List<item> GetAll()
{
List<item> tmpList = new List<item>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From item", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
item tmpObject = new item();
msgRecField="-";
msgRecField=msgRecField + "iditem=";
msgRecField=msgRecField + dr["iditem"].ToString() +"=";
tmpObject.IDITEM = (System.Int32)dr["iditem"];
msgRecField=msgRecField + "numOfItem=";
msgRecField=msgRecField + dr["numOfItem"].ToString() +"=";
tmpObject.NUMOFITEM = (System.Int32)dr["numOfItem"];
msgRecField=msgRecField + "sidOfItem=";
msgRecField=msgRecField + dr["sidOfItem"].ToString() +"=";
tmpObject.SIDOFITEM = (System.String)dr["sidOfItem"];
msgRecField=msgRecField + "id_dcs=";
msgRecField=msgRecField + dr["id_dcs"].ToString() +"=";
tmpObject.ID_DCS = (System.Int32)dr["id_dcs"];
msgRecField=msgRecField + "dcs=";
msgRecField=msgRecField + dr["dcs"].ToString() +"=";
tmpObject.DCS = (System.String)dr["dcs"];
msgRecField=msgRecField + "id_vendor=";
msgRecField=msgRecField + dr["id_vendor"].ToString() +"=";
tmpObject.ID_VENDOR = (System.Int32)dr["id_vendor"];
msgRecField=msgRecField + "aluOfItem=";
msgRecField=msgRecField + dr["aluOfItem"].ToString() +"=";
tmpObject.ALUOFITEM = (System.String)dr["aluOfItem"];
msgRecField=msgRecField + "upcOfItem=";
msgRecField=msgRecField + dr["upcOfItem"].ToString() +"=";
tmpObject.UPCOFITEM = (System.String)dr["upcOfItem"];
msgRecField=msgRecField + "desc1OfItem=";
msgRecField=msgRecField + dr["desc1OfItem"].ToString() +"=";
tmpObject.DESC1OFITEM = (System.String)dr["desc1OfItem"];
msgRecField=msgRecField + "desc2OfItem=";
msgRecField=msgRecField + dr["desc2OfItem"].ToString() +"=";
tmpObject.DESC2OFITEM = (System.String)dr["desc2OfItem"];
msgRecField=msgRecField + "atrOfItem=";
msgRecField=msgRecField + dr["atrOfItem"].ToString() +"=";
tmpObject.ATROFITEM = (System.String)dr["atrOfItem"];
msgRecField=msgRecField + "sizeOfItem=";
msgRecField=msgRecField + dr["sizeOfItem"].ToString() +"=";
tmpObject.SIZEOFITEM = (System.String)dr["sizeOfItem"];
msgRecField=msgRecField + "taxPercOfItem=";
msgRecField=msgRecField + dr["taxPercOfItem"].ToString() +"=";
tmpObject.TAXPERCOFITEM = (System.Decimal)dr["taxPercOfItem"];
msgRecField=msgRecField + "costOfItem=";
msgRecField=msgRecField + dr["costOfItem"].ToString() +"=";
tmpObject.COSTOFITEM = (System.Decimal)dr["costOfItem"];
msgRecField=msgRecField + "priceOfItem=";
msgRecField=msgRecField + dr["priceOfItem"].ToString() +"=";
tmpObject.PRICEOFITEM = (System.Decimal)dr["priceOfItem"];
msgRecField=msgRecField + "imageOfItem=";
msgRecField=msgRecField + dr["imageOfItem"].ToString() +"=";
tmpObject.IMAGEOFITEM = (System.String)dr["imageOfItem"];
msgRecField=msgRecField + "expiryDate=";
msgRecField=msgRecField + dr["expiryDate"].ToString() +"=";
tmpObject.EXPIRYDATE = (System.DateTime)dr["expiryDate"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
public List<item> GetAllByCond(string cond)
{
List<item> tmpList = new List<item>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From item Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
item tmpObject = new item();
msgRecField="-";
msgRecField=msgRecField + "iditem=";
msgRecField=msgRecField + dr["iditem"].ToString() +"=";
tmpObject.IDITEM = (System.Int32)dr["iditem"];
msgRecField=msgRecField + "numOfItem=";
msgRecField=msgRecField + dr["numOfItem"].ToString() +"=";
tmpObject.NUMOFITEM = (System.Int32)dr["numOfItem"];
msgRecField=msgRecField + "sidOfItem=";
msgRecField=msgRecField + dr["sidOfItem"].ToString() +"=";
tmpObject.SIDOFITEM = (System.String)dr["sidOfItem"];
msgRecField=msgRecField + "id_dcs=";
msgRecField=msgRecField + dr["id_dcs"].ToString() +"=";
tmpObject.ID_DCS = (System.Int32)dr["id_dcs"];
msgRecField=msgRecField + "dcs=";
msgRecField=msgRecField + dr["dcs"].ToString() +"=";
tmpObject.DCS = (System.String)dr["dcs"];
msgRecField=msgRecField + "id_vendor=";
msgRecField=msgRecField + dr["id_vendor"].ToString() +"=";
tmpObject.ID_VENDOR = (System.Int32)dr["id_vendor"];
msgRecField=msgRecField + "aluOfItem=";
msgRecField=msgRecField + dr["aluOfItem"].ToString() +"=";
tmpObject.ALUOFITEM = (System.String)dr["aluOfItem"];
msgRecField=msgRecField + "upcOfItem=";
msgRecField=msgRecField + dr["upcOfItem"].ToString() +"=";
tmpObject.UPCOFITEM = (System.String)dr["upcOfItem"];
msgRecField=msgRecField + "desc1OfItem=";
msgRecField=msgRecField + dr["desc1OfItem"].ToString() +"=";
tmpObject.DESC1OFITEM = (System.String)dr["desc1OfItem"];
msgRecField=msgRecField + "desc2OfItem=";
msgRecField=msgRecField + dr["desc2OfItem"].ToString() +"=";
tmpObject.DESC2OFITEM = (System.String)dr["desc2OfItem"];
msgRecField=msgRecField + "atrOfItem=";
msgRecField=msgRecField + dr["atrOfItem"].ToString() +"=";
tmpObject.ATROFITEM = (System.String)dr["atrOfItem"];
msgRecField=msgRecField + "sizeOfItem=";
msgRecField=msgRecField + dr["sizeOfItem"].ToString() +"=";
tmpObject.SIZEOFITEM = (System.String)dr["sizeOfItem"];
msgRecField=msgRecField + "taxPercOfItem=";
msgRecField=msgRecField + dr["taxPercOfItem"].ToString() +"=";
tmpObject.TAXPERCOFITEM = (System.Decimal)dr["taxPercOfItem"];
msgRecField=msgRecField + "costOfItem=";
msgRecField=msgRecField + dr["costOfItem"].ToString() +"=";
tmpObject.COSTOFITEM = (System.Decimal)dr["costOfItem"];
msgRecField=msgRecField + "priceOfItem=";
msgRecField=msgRecField + dr["priceOfItem"].ToString() +"=";
tmpObject.PRICEOFITEM = (System.Decimal)dr["priceOfItem"];
msgRecField=msgRecField + "imageOfItem=";
msgRecField=msgRecField + dr["imageOfItem"].ToString() +"=";
tmpObject.IMAGEOFITEM = (System.String)dr["imageOfItem"];
msgRecField=msgRecField + "expiryDate=";
msgRecField=msgRecField + dr["expiryDate"].ToString() +"=";
tmpObject.EXPIRYDATE = (System.DateTime)dr["expiryDate"];
msgRecField=msgRecField + "id_company=";
msgRecField=msgRecField + dr["id_company"].ToString() +"=";
tmpObject.ID_COMPANY = (System.Int32)dr["id_company"];
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
 
