using System;
using System.Collections.Generic;
using System.Collections;
 
using System.Text;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.OracleClient;
using System.Data.SqlTypes;
using System.Xml;
using System.IO;


    class GeneralDataLayer
    {
        public string connectionStringOracle = "";
        public ArrayList alErrors = new ArrayList();

		// C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\System.Data.OracleClient.dll to add in reference
		
        public GeneralDataLayer()
        {
        }

        public GeneralDataLayer(string connString)
        {
            connectionStringOracle = connString;
        }

        public ArrayList RunViewSQL(string delimiter, string connectionString, string commandString)
        {
            alErrors.Clear();
            string msgRecField = "-";

            string ListFields;
            ListFields = delimiter;
            ArrayList al = new ArrayList();

             
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = connectionString;

                cn.Open();
                SqlCommand cmd = new SqlCommand(commandString, cn);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                int rec = 0;

                while (dr.Read())
                {
                    rec = rec + 1;
                    try
                    {
                        ListFields = "";
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            // "|" + dr.GetFieldType(i).ToString()
                            //string 

                            
                            // reader.GetFieldType(int ordinal)                       

                            ListFields = ListFields + dr[i].ToString() + delimiter;

                            bool res = Utils.IsValidInput(dr[i].ToString(), dr.GetFieldType(i).ToString());


                            if (res == false)
                            {
                                alErrors.Add(rec.ToString() + " ==" + i.ToString() + " - " + dr[i].ToString() + "=" + dr.GetName(i) + "="+ ListFields);
                                 


                            }
                        }

                        ListFields = ListFields.Remove(ListFields.Length - 1, 1);

                        al.Add(ListFields);
                    }
                    catch (Exception ex)
                    {
                        alErrors.Add(LogException(ex));
                        
                         
                    }
                }
                dr.Close();
            
             
            return al;
        }


        public void Write(DataTable dt, string filePath)
        {
            int i = 0;
            StreamWriter sw = null;

            try
            {

                sw = new StreamWriter(filePath, false);


                for (i = 0; i < dt.Columns.Count - 1; i++)
                {

                    sw.Write(dt.Columns[i].ColumnName + ",");

                }
                sw.Write(dt.Columns[i].ColumnName);
                sw.WriteLine();


                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;

                    for (i = 0; i < array.Length - 1; i++)
                    {
                        sw.Write(array[i].ToString() + ",");
                    }
                    sw.Write(array[i].ToString());
                    sw.WriteLine();

                }

                sw.Close();
            }

            catch (Exception ex)
            {
                // MessageBox.Show("Invalid Operation : \n" + ex.ToString(),  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable GetTableFromSQLServer(string connectionString, string sSql)
        {
            DataTable dt = new DataTable();

            string tmp = "";
            SqlConnection conn = new SqlConnection(connectionString);


            if (conn.State == ConnectionState.Closed)
            { conn.Open(); }


            SqlCommand OrCmd = new SqlCommand();

         
            OrCmd = new SqlCommand(sSql, conn);
          
            SqlDataReader orReader = OrCmd.ExecuteReader();
            dt.Load(orReader);

            orReader.Close();
            orReader.Dispose();
            OrCmd.Dispose();
            conn.Close();
            conn.Dispose();

        
            return dt;
        }

        public DataTable GetTableFromOracle(string connStringOracle, string sSql)
        {
            DataTable dt = new DataTable();

            string tmp = "er";
            OracleConnection OrConn = new OracleConnection(connStringOracle);

            if (OrConn.State == ConnectionState.Closed)
            { OrConn.Open(); }


            OracleCommand OrCmd = new OracleCommand();


            OrCmd = new OracleCommand(sSql, OrConn);

            OracleDataReader orReader = OrCmd.ExecuteReader();
            dt.Load(orReader);

            //DataSet ds = new DataSet();
            //ds.Tables.Add(dt);
            ////this.dataGridView1.DataSource = ds.Tables[0];


            orReader.Close();
            orReader.Dispose();
            OrCmd.Dispose();
            OrConn.Close();
            OrConn.Dispose();

            if (dt.Rows.Count > 0)
            {
                tmp = dt.Rows[0][0].ToString();
            }
            else
            { tmp = "0"; }

            return dt;
        }

       
        public ArrayList GetColumnFromTableAsArrayList(DataTable dt, int ColumnIndex)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tmp = dt.Rows[i][ColumnIndex].ToString().Trim();
                al.Add(tmp);
            }

            return al;

        }

        public ArrayList GetColumnFromTableAsArrayListWithCheck(DataTable dt, int ColumnIndex)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    tmp = dt.Rows[i][ColumnIndex].ToString().Trim();
                }
                catch
                {
                    tmp = "0";
                }

                if (tmp.CompareTo("") == 0 || tmp == null)
                {
                    tmp = "0";
                }

                al.Add(tmp);
            }

            return al;

        }


        public ArrayList GetTwoColumnsAsKeyFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim();
                al.Add(tmp);
            }

            return al;

        }

        public ArrayList GetTwoColumnsAsKeyFromTableAsArrayListUnique(DataTable dt, int ColumnIndex1, int ColumnIndex2)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim();

                if (i > 0)
                {
                    int index = al.IndexOf(tmp);
                    if (index > -1)   // do not put the same one = no duplicates
                    {
                        al.Add(tmp);  // 
                    }
                }
                else
                {
                    al.Add(tmp);
                }
            }

            return al;

        }

        public ArrayList GetFourColumnsAsKeyFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2, int ColumnIndex3, int ColumnIndex4)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim() + "," + dt.Rows[i][ColumnIndex3].ToString().Trim() + "," + dt.Rows[i][ColumnIndex4].ToString().Trim();
                    al.Add(tmp);
                }
                catch
                {
                    // the data are not proper 
                }

            }

            return al;

        }

        public ArrayList GetFiveColumnsAsKeyFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2, int ColumnIndex3, int ColumnIndex4, int ColumnIndex5)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim() + "," + dt.Rows[i][ColumnIndex3].ToString().Trim() + "," + dt.Rows[i][ColumnIndex4].ToString().Trim() + "," + dt.Rows[i][ColumnIndex5].ToString().Trim();
                al.Add(tmp);
            }

            return al;

        }

        public ArrayList GetSixColumnsAsKeyFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2, int ColumnIndex3, int ColumnIndex4, int ColumnIndex5, int ColumnIndex6)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim() + "," + dt.Rows[i][ColumnIndex3].ToString().Trim() + "," + dt.Rows[i][ColumnIndex4].ToString().Trim() + "," + dt.Rows[i][ColumnIndex5].ToString().Trim() + "," + dt.Rows[i][ColumnIndex6].ToString().Trim();
                al.Add(tmp);
            }

            return al;

        }


        public ArrayList GetFourColumnsAsKeyPlusOneWithSpecialDateFormatFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2, int ColumnIndex3, int ColumnIndex4)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    DateTime tmpDateTime = DateTime.Parse(dt.Rows[i][ColumnIndex4].ToString().Trim());
                    string specialDateFormatMMDDYYYY = tmpDateTime.Day.ToString() + tmpDateTime.Month.ToString() + tmpDateTime.Year.ToString();
                    tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim() + "," + dt.Rows[i][ColumnIndex3].ToString().Trim() + "," + dt.Rows[i][ColumnIndex4].ToString().Trim() + "," + specialDateFormatMMDDYYYY;
                    al.Add(tmp);
                }
                catch
                {
                    // the data are not proper 
                }

            }

            return al;

        }

        public ArrayList GetFiveColumnsAsKeyPlusOneWithSpecialDateFormatFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2, int ColumnIndex3, int ColumnIndex4, int ColumnIndex5)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime tmpDateTime = DateTime.Parse(dt.Rows[i][ColumnIndex4].ToString().Trim());
                string specialDateFormatMMDDYYYY = tmpDateTime.Day.ToString() + tmpDateTime.Month.ToString() + tmpDateTime.Year.ToString();
                tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim() + "," + dt.Rows[i][ColumnIndex3].ToString().Trim() + "," + dt.Rows[i][ColumnIndex4].ToString().Trim() + "," + dt.Rows[i][ColumnIndex5].ToString().Trim() + "," + specialDateFormatMMDDYYYY;
                al.Add(tmp);
            }

            return al;

        }


        public ArrayList GetThreeColumnsAsKeyFromTableAsArrayList(DataTable dt, int ColumnIndex1, int ColumnIndex2, int ColumnIndex3)
        {
            ArrayList al = new ArrayList();
            string tmp;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                tmp = dt.Rows[i][ColumnIndex1].ToString().Trim() + "," + dt.Rows[i][ColumnIndex2].ToString().Trim() + "," + dt.Rows[i][ColumnIndex3].ToString().Trim();
                al.Add(tmp);
            }

            return al;

        }
        
        public string OracleReaderTest(string OracleCon, string Value, string _Type)
        {
            string tmp = "";
            OracleConnection OrConn = new OracleConnection(OracleCon);

            if (OrConn.State == ConnectionState.Closed)
            { OrConn.Open(); }

            DataTable dt = new DataTable();
            OracleCommand OrCmd = new OracleCommand();

            //String sSql = "SELECT ITEM_SID FROM INVENTORY_V ";

            // String sSql = "SELECT CUST_SID, FIRST_NAME, LAST_NAME FROM CUSTOMER ";
            String sSql = @"Select INVOICE_V.POST_DATE, INVOICE_V.Created_DATE, INVOICE_V.INVC_NO, Invoice_V.Invc_Sid, Invc_Item_V.Invc_Sid, Invc_Item_V.QTY, Invc_Item_V.PRICE From Invc_Item_V,  Invoice_V Where (Invc_Item_V.Invc_Sid=Invoice_V.Invc_Sid AND INVOICE_V.POST_DATE<'05-OCT-12' AND INVOICE_V.POST_DATE>'03-OCT-12')";

            //switch (_Type.ToUpper().ToString())
            //{
            //    case "NAME":
            //        sSql += "WHERE LAST_NAME = :p1";
            //        break;
            //    case "SID":
            //        sSql += "WHERE CUST_SID = :p1";
            //        break;
            //}


            OrCmd = new OracleCommand(sSql, OrConn);
            //OracleParameter p = new OracleParameter();
            //p.ParameterName = "p1";
            //p.Value = Value;

            //switch (_Type.ToUpper().ToString())
            //{
            //    case "NAME":
            //        p.OracleType = OracleType.VarChar;
            //        break;
            //    case "SID":
            //        //sSql += "WHERE ITEM_NO =p1";
            //        p.OracleType = OracleType.Number;
            //        break;
            //}
            //OrCmd.Parameters.Add(p);

            OracleDataReader orReader = OrCmd.ExecuteReader();
            dt.Load(orReader);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
           // this.dataGridView1.DataSource = ds.Tables[0];


            orReader.Close();
            orReader.Dispose();
            OrCmd.Dispose();
            OrConn.Close();
            OrConn.Dispose();

            if (dt.Rows.Count > 0)
            {
                tmp = dt.Rows[0][0].ToString();
            }
            else
            { tmp = "0"; }

            return tmp;
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
                message = message + e.StackTrace;
                return message;
            }
            else
            {
                return e.StackTrace;
            }
        }


        public string LogException(Exception exception)
        {
            string error = "";

            error = "Exception classes:   ";
            error = error + GetExceptionTypeStack(exception);
            error = error + " ";
            error = error + " Exception messages: ";
            error = error + GetExceptionMessageStack(exception);

            error = error + " ";
            error = error + " Stack Traces: ";
            error = error + GetExceptionCallStack(exception);

            return error;
        }
}
