using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_salesPL
 
{
public string connString;
public string connectionString;
public DB_salesPL()
{
  
 
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(salesPL _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(salesPL _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO tb_sales (invc_storenumb,invc_storecode,invc_invoiceno,invc_docsid,invc_invdate,invc_invtime,invc_itemnumb,invc_itemsid,invc_itemupc,invc_itemalu,invc_qty,invc_p$,invc_t$,invc_c$,invc_d$,invc_pricelevel,invc_type,invc_workstation) VALUES (@invc_storenumb,@invc_storecode,@invc_invoiceno,@invc_docsid,@invc_invdate,@invc_invtime,@invc_itemnumb,@invc_itemsid,@invc_itemupc,@invc_itemalu,@invc_qty,@invc_p$,@invc_t$,@invc_c$,@invc_d$,@invc_pricelevel,@invc_type,@invc_workstation) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@invc_storenumb", _tmpObject.INVC_STORENUMB));
command.Parameters.Add(new SqlParameter("@invc_storecode", _tmpObject.INVC_STORECODE));
command.Parameters.Add(new SqlParameter("@invc_invoiceno", _tmpObject.INVC_INVOICENO));
command.Parameters.Add(new SqlParameter("@invc_docsid", _tmpObject.INVC_DOCSID));
command.Parameters.Add(new SqlParameter("@invc_invdate", _tmpObject.INVC_INVDATE));
command.Parameters.Add(new SqlParameter("@invc_invtime", _tmpObject.INVC_INVTIME));
command.Parameters.Add(new SqlParameter("@invc_itemnumb", _tmpObject.INVC_ITEMNUMB));
command.Parameters.Add(new SqlParameter("@invc_itemsid", _tmpObject.INVC_ITEMSID));
command.Parameters.Add(new SqlParameter("@invc_itemupc", _tmpObject.INVC_ITEMUPC));
command.Parameters.Add(new SqlParameter("@invc_itemalu", _tmpObject.INVC_ITEMALU));
command.Parameters.Add(new SqlParameter("@invc_qty", _tmpObject.INVC_QTY));
command.Parameters.Add(new SqlParameter("@invc_p$", _tmpObject.INVC_P$));
command.Parameters.Add(new SqlParameter("@invc_t$", _tmpObject.INVC_T$));
command.Parameters.Add(new SqlParameter("@invc_c$", _tmpObject.INVC_C$));
command.Parameters.Add(new SqlParameter("@invc_d$", _tmpObject.INVC_D$));
command.Parameters.Add(new SqlParameter("@invc_pricelevel", _tmpObject.INVC_PRICELEVEL));
command.Parameters.Add(new SqlParameter("@invc_type", _tmpObject.INVC_TYPE));
command.Parameters.Add(new SqlParameter("@invc_workstation", _tmpObject.INVC_WORKSTATION));
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
 
public int Update(salesPL _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(salesPL _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE tb_sales SET invc_storenumb=@invc_storenumb,invc_storecode=@invc_storecode,invc_invoiceno=@invc_invoiceno,invc_docsid=@invc_docsid,invc_invdate=@invc_invdate,invc_invtime=@invc_invtime,invc_itemnumb=@invc_itemnumb,invc_itemsid=@invc_itemsid,invc_itemupc=@invc_itemupc,invc_itemalu=@invc_itemalu,invc_qty=@invc_qty,invc_p$=@invc_p$,invc_t$=@invc_t$,invc_c$=@invc_c$,invc_d$=@invc_d$,invc_pricelevel=@invc_pricelevel,invc_type=@invc_type,invc_workstation=@invc_workstation  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@invc_storenumb", _tmpObject.INVC_STORENUMB));
command.Parameters.Add(new SqlParameter("@invc_storecode", _tmpObject.INVC_STORECODE));
command.Parameters.Add(new SqlParameter("@invc_invoiceno", _tmpObject.INVC_INVOICENO));
command.Parameters.Add(new SqlParameter("@invc_docsid", _tmpObject.INVC_DOCSID));
command.Parameters.Add(new SqlParameter("@invc_invdate", _tmpObject.INVC_INVDATE));
command.Parameters.Add(new SqlParameter("@invc_invtime", _tmpObject.INVC_INVTIME));
command.Parameters.Add(new SqlParameter("@invc_itemnumb", _tmpObject.INVC_ITEMNUMB));
command.Parameters.Add(new SqlParameter("@invc_itemsid", _tmpObject.INVC_ITEMSID));
command.Parameters.Add(new SqlParameter("@invc_itemupc", _tmpObject.INVC_ITEMUPC));
command.Parameters.Add(new SqlParameter("@invc_itemalu", _tmpObject.INVC_ITEMALU));
command.Parameters.Add(new SqlParameter("@invc_qty", _tmpObject.INVC_QTY));
command.Parameters.Add(new SqlParameter("@invc_p$", _tmpObject.INVC_P$));
command.Parameters.Add(new SqlParameter("@invc_t$", _tmpObject.INVC_T$));
command.Parameters.Add(new SqlParameter("@invc_c$", _tmpObject.INVC_C$));
command.Parameters.Add(new SqlParameter("@invc_d$", _tmpObject.INVC_D$));
command.Parameters.Add(new SqlParameter("@invc_pricelevel", _tmpObject.INVC_PRICELEVEL));
command.Parameters.Add(new SqlParameter("@invc_type", _tmpObject.INVC_TYPE));
command.Parameters.Add(new SqlParameter("@invc_workstation", _tmpObject.INVC_WORKSTATION));
command.Parameters.Add(new SqlParameter("@id", _tmpObject.ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(salesPL _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(salesPL _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE tb_sales  WHERE id=@id", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id", _tmpObject.ID));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public salesPL GetById(int _id)
{
salesPL tmpObject = new salesPL();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From tb_sales WHERE id=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID = (System.Int32)dr["id"];
tmpObject.INVC_STORENUMB = (System.String)dr["invc_storenumb"];
tmpObject.INVC_STORECODE = (System.String)dr["invc_storecode"];
tmpObject.INVC_INVOICENO = (System.String)dr["invc_invoiceno"];
tmpObject.INVC_DOCSID = (System.Int64)dr["invc_docsid"];
tmpObject.INVC_INVDATE = (System.String)dr["invc_invdate"];
tmpObject.INVC_INVTIME = (System.String)dr["invc_invtime"];
tmpObject.INVC_ITEMNUMB = (System.Int32)dr["invc_itemnumb"];
tmpObject.INVC_ITEMSID = (System.Int64)dr["invc_itemsid"];
tmpObject.INVC_ITEMUPC = (System.String)dr["invc_itemupc"];
tmpObject.INVC_ITEMALU = (System.String)dr["invc_itemalu"];
tmpObject.INVC_QTY = (System.Int32)dr["invc_qty"];
tmpObject.INVC_P$ = (System.Decimal)dr["invc_p$"];
tmpObject.INVC_T$ = (System.Decimal)dr["invc_t$"];
tmpObject.INVC_C$ = (System.Decimal)dr["invc_c$"];
tmpObject.INVC_D$ = (System.Decimal)dr["invc_d$"];
tmpObject.INVC_PRICELEVEL = (System.String)dr["invc_pricelevel"];
tmpObject.INVC_TYPE = (System.String)dr["invc_type"];
tmpObject.INVC_WORKSTATION = (System.Int32)dr["invc_workstation"];
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
