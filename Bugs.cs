using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace ptl
{
    public class Bugs
    {
        public Bugs()
        {

        }

        public Bugs(System.Int32 BUGID, System.DateTime RESOLUTION_DATE, System.Int32 PRODUCT, System.String VERSION, System.String DESCRIPTION, System.String REPORTER, System.Decimal PRICE, System.Decimal PRICE2)
        {
            bugid = BUGID;
            resolution_date = RESOLUTION_DATE;
            product = PRODUCT;
            version = VERSION;
            description = DESCRIPTION;
            reporter = REPORTER;
            price = PRICE;
            price2 = PRICE2;
        }


        private System.Int32 bugid;

        public System.Int32 BugID
        {
            get
            {
                return bugid;
            }
            set
            {
                bugid = value;
            }
        }

        private System.DateTime resolution_date;

        public System.DateTime Resolution_date
        {
            get
            {
                return resolution_date;
            }
            set
            {
                resolution_date = value;
            }
        }

        private System.Int32 product;

        public System.Int32 Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
            }
        }

        private System.String version;

        public System.String Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        private System.String description;

        public System.String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private System.String reporter;

        public System.String Reporter
        {
            get
            {
                return reporter;
            }
            set
            {
                reporter = value;
            }
        }

        private System.Decimal price;

        public System.Decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        private System.Decimal price2;

        public System.Decimal Price2
        {
            get
            {
                return price2;
            }
            set
            {
                price2 = value;
            }
        }

        public int InsertCommand()
        {
            // Use this InsertCommand with PrimaryKey Field which is not AutoIncement;
            int numberinsert = 0;
            // INSERT INTO Bugs(BugID,Resolution_date,Product,Version,Description,Reporter,Price,Price2 ) VALUES(bugid,resolution_date,product,version,description,reporter,price,price2 );
            // For string you need 'string', for datetime 'datetime for numbers just number.ToString();
            return numberinsert;
        }


        public int InsertCommand(int IndexOfIncrementField, string Con)
        {
            // Use this InsertCommand with PrimaryKey Field is AutoIncement;
            int numberinsert = 0;
            string minsert = "INSERT INTO Bugs(Resolution_date,Product,Version,Description,Reporter,Price,Price2 ) VALUES(" + (char)39 + resolution_date.ToString() + (char)39 + (char)44 + product.ToString() + (char)44 + (char)39 + version.ToString() + (char)39 + (char)44 + (char)39 + description.ToString() + (char)39 + (char)44 + (char)39 + reporter.ToString() + (char)39 + (char)44 + price.ToString() + (char)44 + price2.ToString() + (char)41;
            // For string you need 'string', for datetime 'datetime for numbers just number.ToString();
            ptl.DbaseSQLServer sqinsert = new ptl.DbaseSQLServer();
            sqinsert.DbaseConnection = Con;
            sqinsert.SqlText = minsert;
            numberinsert = sqinsert.RunUpdateSQL();
            sqinsert = null;
            return numberinsert;
        }

        public int UpdateEditComand(string Con)
        {
            int numberedit = 0;
            string mupdate = "UPDATE Bugs SET " + "Resolution_date=" + (char)39 + resolution_date.ToString() + (char)39 + (char)44 + "Product=" + product.ToString() + (char)44 + "Version=" + (char)39 + version.ToString() + (char)39 + (char)44 + "Description=" + (char)39 + description.ToString() + (char)39 + (char)44 + "Reporter=" + (char)39 + reporter.ToString() + (char)39 + (char)44 + "Price=" + price.ToString() + (char)44 + "Price2=" + price2.ToString() + " WHERE BugID=" + bugid.ToString();
            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
            sq.DbaseConnection = Con;
            sq.SqlText = mupdate;
            numberedit = sq.RunUpdateSQL();
            sq = null;
            return numberedit;
        }


        public int DeleteComand(string Con)
        {
            int numberdelete = 0;
            string del = "DELETE FROM Bugs WHERE BugID=" + bugid.ToString();
            // BugID=OldData[i].ToString() AND
            // Resolution_date=OldData[i].ToString() AND
            // Product=OldData[i].ToString() AND
            // Version=OldData[i].ToString() AND
            // Description=OldData[i].ToString() AND
            // Reporter=OldData[i].ToString() AND
            // Price=OldData[i].ToString() AND
            // Price2=OldData[i].ToString() AND
            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
            sq.DbaseConnection = Con;
            sq.SqlText = del;
            numberdelete = sq.RunUpdateSQL();
            sq = null;
            return numberdelete;
        }


        public ArrayList SearchResultAsArrayList(string SearchExp, string Con)
        {
            ArrayList alsearch = new ArrayList();
            string alistsearch = "SELECT * FROM Bugs " + SearchExp;
            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
            sq.DbaseConnection = Con;
            sq.SqlText = alistsearch;
            alsearch = sq.RunViewSQL("|");
            sq = null;
            return alsearch;
        }


        public ArrayList GetAllDataAsArrayList(string Con)
        {
            ArrayList alsearch = new ArrayList();
            string alistsearch = "SELECT * FROM Bugs";
            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
            sq.DbaseConnection = Con;
            sq.SqlText = alistsearch;
            alsearch = sq.RunViewSQL("|");
            sq = null;
            return alsearch;
        }


        public DataTable SearchResultAsTable(string SearchExp, string Con)
        {
            DataTable dt = new DataTable();
            string dtsearch = "SELECT * FROM Bugs " + SearchExp;
            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
            sq.DbaseConnection = Con;
            sq.SqlText = dtsearch;
            dt = sq.RunViewSQL();
            sq = null;
            return dt;
        }


        public DataTable GetAllDataAsTable(string Con)
        {
            DataTable dt = new DataTable();
            string dtsearch = "SELECT * FROM Bugs";
            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
            sq.DbaseConnection = Con;
            sq.SqlText = dtsearch;
            dt = sq.RunViewSQL();
            sq = null;
            return dt;
        }

    }
}
