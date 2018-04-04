using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_CustomerLoyTrans
 
{
public string connString;
public string connectionString;
public DB_CustomerLoyTrans()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(CustomerLoyTrans _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(CustomerLoyTrans _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO CLTrans (CustID,CustSID,CustLastName,CustFirstName,CustCompany,ReceiptNo,Store,Station,ReceiptDate,ReceiptTotal,PointsValue,TransferSID) VALUES (@CustID,@CustSID,@CustLastName,@CustFirstName,@CustCompany,@ReceiptNo,@Store,@Station,@ReceiptDate,@ReceiptTotal,@PointsValue,@TransferSID) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@CustID", _tmpObject.CUSTID));
command.Parameters.Add(new SqlParameter("@CustSID", _tmpObject.CUSTSID));
command.Parameters.Add(new SqlParameter("@CustLastName", _tmpObject.CUSTLASTNAME));
command.Parameters.Add(new SqlParameter("@CustFirstName", _tmpObject.CUSTFIRSTNAME));
command.Parameters.Add(new SqlParameter("@CustCompany", _tmpObject.CUSTCOMPANY));
command.Parameters.Add(new SqlParameter("@ReceiptNo", _tmpObject.RECEIPTNO));
command.Parameters.Add(new SqlParameter("@Store", _tmpObject.STORE));
command.Parameters.Add(new SqlParameter("@Station", _tmpObject.STATION));
command.Parameters.Add(new SqlParameter("@ReceiptDate", _tmpObject.RECEIPTDATE));
command.Parameters.Add(new SqlParameter("@ReceiptTotal", _tmpObject.RECEIPTTOTAL));
command.Parameters.Add(new SqlParameter("@PointsValue", _tmpObject.POINTSVALUE));
command.Parameters.Add(new SqlParameter("@TransferSID", _tmpObject.TRANSFERSID));
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
 
public int Update(CustomerLoyTrans _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(CustomerLoyTrans _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE CLTrans SET CustID=@custid,CustSID=@custsid,CustLastName=@custlastname,CustFirstName=@custfirstname,CustCompany=@custcompany,ReceiptNo=@receiptno,Store=@store,Station=@station,ReceiptDate=@receiptdate,ReceiptTotal=@receipttotal,PointsValue=@pointsvalue,TransferSID=@transfersid  WHERE idRec=@idrec", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@custid", _tmpObject.CUSTID));
command.Parameters.Add(new SqlParameter("@custsid", _tmpObject.CUSTSID));
command.Parameters.Add(new SqlParameter("@custlastname", _tmpObject.CUSTLASTNAME));
command.Parameters.Add(new SqlParameter("@custfirstname", _tmpObject.CUSTFIRSTNAME));
command.Parameters.Add(new SqlParameter("@custcompany", _tmpObject.CUSTCOMPANY));
command.Parameters.Add(new SqlParameter("@receiptno", _tmpObject.RECEIPTNO));
command.Parameters.Add(new SqlParameter("@store", _tmpObject.STORE));
command.Parameters.Add(new SqlParameter("@station", _tmpObject.STATION));
command.Parameters.Add(new SqlParameter("@receiptdate", _tmpObject.RECEIPTDATE));
command.Parameters.Add(new SqlParameter("@receipttotal", _tmpObject.RECEIPTTOTAL));
command.Parameters.Add(new SqlParameter("@pointsvalue", _tmpObject.POINTSVALUE));
command.Parameters.Add(new SqlParameter("@transfersid", _tmpObject.TRANSFERSID));
command.Parameters.Add(new SqlParameter("@idrec", _tmpObject.IDREC));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(CustomerLoyTrans _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(CustomerLoyTrans _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE CLTrans  WHERE idRec=@idrec", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idrec", _tmpObject.IDREC));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public CustomerLoyTrans GetById(int _id)
{
CustomerLoyTrans tmpObject = new CustomerLoyTrans();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From CLTrans WHERE idRec=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDREC = (System.Int32)dr["idRec"];
tmpObject.CUSTID = (System.String)dr["CustID"];
tmpObject.CUSTSID = (System.String)dr["CustSID"];
tmpObject.CUSTLASTNAME = (System.String)dr["CustLastName"];
tmpObject.CUSTFIRSTNAME = (System.String)dr["CustFirstName"];
tmpObject.CUSTCOMPANY = (System.String)dr["CustCompany"];
tmpObject.RECEIPTNO = (System.Int64)dr["ReceiptNo"];
tmpObject.STORE = (System.String)dr["Store"];
tmpObject.STATION = (System.String)dr["Station"];
tmpObject.RECEIPTDATE = (System.DateTime)dr["ReceiptDate"];
tmpObject.RECEIPTTOTAL = (System.Decimal)dr["ReceiptTotal"];
tmpObject.POINTSVALUE = (System.Int32)dr["PointsValue"];
tmpObject.TRANSFERSID = (System.String)dr["TransferSID"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
////==========================================================================
 
}
