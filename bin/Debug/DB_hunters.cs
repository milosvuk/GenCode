using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class DB_hunters
 
{
public string connString;
public string connectionString;
public DB_hunters()
{
  
    System.Configuration.ConnectionStringSettings connString;
    connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["devdb"];
    connectionString = connString.ConnectionString; 
        
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(hunters _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(hunters _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO hunters (IdCardNumber,Surname,Name,Address1,Address2,Locality,MaltaOrGozo,LicencedMobileNumber,HomePhoneNumber,Desc1,Desc2,LicenceActive,Active) VALUES (@IdCardNumber,@Surname,@Name,@Address1,@Address2,@Locality,@MaltaOrGozo,@LicencedMobileNumber,@HomePhoneNumber,@Desc1,@Desc2,@LicenceActive,@Active) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@IdCardNumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@Surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@Name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@Address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@Address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@Locality", _tmpObject.LOCALITY));
command.Parameters.Add(new SqlParameter("@MaltaOrGozo", _tmpObject.MALTAORGOZO));
command.Parameters.Add(new SqlParameter("@LicencedMobileNumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@HomePhoneNumber", _tmpObject.HOMEPHONENUMBER));
command.Parameters.Add(new SqlParameter("@Desc1", _tmpObject.DESC1));
command.Parameters.Add(new SqlParameter("@Desc2", _tmpObject.DESC2));
command.Parameters.Add(new SqlParameter("@LicenceActive", _tmpObject.LICENCEACTIVE));
command.Parameters.Add(new SqlParameter("@Active", _tmpObject.ACTIVE));
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
 
public int Update(hunters _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(hunters _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE hunters SET IdCardNumber=@idcardnumber,Surname=@surname,Name=@name,Address1=@address1,Address2=@address2,Locality=@locality,MaltaOrGozo=@maltaorgozo,LicencedMobileNumber=@licencedmobilenumber,HomePhoneNumber=@homephonenumber,Desc1=@desc1,Desc2=@desc2,LicenceActive=@licenceactive,Active=@active  WHERE idRecHunter=@idrechunter", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@idcardnumber", _tmpObject.IDCARDNUMBER));
command.Parameters.Add(new SqlParameter("@surname", _tmpObject.SURNAME));
command.Parameters.Add(new SqlParameter("@name", _tmpObject.NAME));
command.Parameters.Add(new SqlParameter("@address1", _tmpObject.ADDRESS1));
command.Parameters.Add(new SqlParameter("@address2", _tmpObject.ADDRESS2));
command.Parameters.Add(new SqlParameter("@locality", _tmpObject.LOCALITY));
command.Parameters.Add(new SqlParameter("@maltaorgozo", _tmpObject.MALTAORGOZO));
command.Parameters.Add(new SqlParameter("@licencedmobilenumber", _tmpObject.LICENCEDMOBILENUMBER));
command.Parameters.Add(new SqlParameter("@homephonenumber", _tmpObject.HOMEPHONENUMBER));
command.Parameters.Add(new SqlParameter("@desc1", _tmpObject.DESC1));
command.Parameters.Add(new SqlParameter("@desc2", _tmpObject.DESC2));
command.Parameters.Add(new SqlParameter("@licenceactive", _tmpObject.LICENCEACTIVE));
command.Parameters.Add(new SqlParameter("@active", _tmpObject.ACTIVE));
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
 
public int Delete(hunters _tmpObject)
{
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(hunters _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE hunters  WHERE idRecHunter=@idrechunter", conn);
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
public hunters GetById(int _id)
{
hunters tmpObject = new hunters();
  
 
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From hunters WHERE idRecHunter=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
tmpObject.SURNAME = (System.String)dr["Surname"];
tmpObject.NAME = (System.String)dr["Name"];
tmpObject.ADDRESS1 = (System.String)dr["Address1"];
tmpObject.ADDRESS2 = (System.String)dr["Address2"];
tmpObject.LOCALITY = (System.String)dr["Locality"];
tmpObject.MALTAORGOZO = (System.String)dr["MaltaOrGozo"];
tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
tmpObject.HOMEPHONENUMBER = (System.String)dr["HomePhoneNumber"];
tmpObject.DESC1 = (System.String)dr["Desc1"];
tmpObject.DESC2 = (System.String)dr["Desc2"];
tmpObject.LICENCEACTIVE = (System.Int32)dr["LicenceActive"];
tmpObject.ACTIVE = (System.Int32)dr["Active"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
////==========================================================================

public List<hunters> GetByCrit(string crite)
{

    List<hunters> lhunters = new List<hunters>();
    hunters tmpObject = new hunters();
    
    SqlConnection conn = new SqlConnection(connectionString);
    SqlCommand command = new SqlCommand("Select idRecHunter, Surname, Name From hunters WHERE Active=1 And " + crite, conn);
    conn.Open();
    SqlDataReader dr = command.ExecuteReader();
    while (dr.Read())
    {
        tmpObject.IDRECHUNTER = (System.Int32)dr["idRecHunter"];
       // tmpObject.IDCARDNUMBER = (System.String)dr["IdCardNumber"];
        tmpObject.SURNAME = (System.String)dr["Surname"];
        tmpObject.NAME = (System.String)dr["Name"];
        //tmpObject.ADDRESS1 = (System.String)dr["Address1"];
        //tmpObject.ADDRESS2 = (System.String)dr["Address2"];
        //tmpObject.LOCALITY = (System.String)dr["Locality"];
        //tmpObject.MALTAORGOZO = (System.String)dr["MaltaOrGozo"];
        //tmpObject.LICENCEDMOBILENUMBER = (System.String)dr["LicencedMobileNumber"];
        //tmpObject.LICENCEACTIVE = (System.Int32)dr["LicenceActive"];
        //tmpObject.ACTIVE = (System.Int32)dr["Active"];

        lhunters.Add(tmpObject);
    }
    dr.Close();
    conn.Close();


    return lhunters;
}

 
}
