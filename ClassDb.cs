using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace BReportS
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Class1
	{
		public Class1()
		{
			//
			// TODO: Add constructor logic here
			//
			
		}

		private int NumOfFields;
		private string commandString;
		private string connectionString;

		public string CommandString
		{
			set
			{
			  commandString = value;
			}
			get
			{
                return commandString;
			}

		}

		public string ConString
		{
			set
			{
				connectionString = value;
			}
			get
			{
				return connectionString;
			}

		}

		public ArrayList Objectdreader(string delimiter)
		{
			// mozda ubaciti da su parametri conString, commandString, char za razdvajanje
			// ili samo char za razdvajanje 

			string ListFields;
			ListFields= delimiter;

			NumOfFields = 0;
		
			string[] SubString;

			if (commandString.IndexOf(',') > 0)
			{
				SubString = commandString.Split(',');
				NumOfFields = SubString.Length;
			}
			else
			{
				NumOfFields = 1;
			}

			;

			ArrayList al = new ArrayList(); 
		
			// = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";
			//string commandString = "Select BugID, Description From Bugs";

			SqlConnection cn = new SqlConnection();
			cn.ConnectionString = connectionString;

			cn.Open();
			SqlCommand cmd = new SqlCommand(commandString, cn);
			SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
			while (dr.Read())
			{
				for (int i=0;i<NumOfFields;i++)
				{
					
					ListFields = dr[i].ToString()+ListFields;
					//al.Add( (dr["BugID"].ToString() + "|" + dr["Description"].ToString()));
				}
                al.Add(ListFields);

			}
			dr.Close();

			return al;
		}
	}
}
