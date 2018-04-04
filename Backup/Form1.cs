using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace WinTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		//private System.DateTime dtime = new DateTime();
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		ArrayList bugs = new ArrayList(  );
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.ListBox listBox2;
		private int hh;
		private int ww;
		private string scon;
		string NameOfTable;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button16;
		bool res;
		DataSet ds = new DataSet();
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		DataView dv = new DataView();
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		DateTime dtime = new DateTime();
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		string fname;
		string classname;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.ListBox listBox4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button16 = new System.Windows.Forms.Button();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.label5 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.button10 = new System.Windows.Forms.Button();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(192)), ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 472);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a something new";
			this.label1.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(96, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "DVUKELIC";
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(256, 456);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "Click";
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(288, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(80, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "sa";
			this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(408, 472);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(400, 432);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "ArrayListToGrid";
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(328, 456);
			this.button3.Name = "button3";
			this.button3.TabIndex = 7;
			this.button3.Text = "AddToAList";
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(24, 80);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(168, 128);
			this.dataGrid1.TabIndex = 8;
			this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click_1);
			this.dataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
			this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate_1);
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			this.dataGrid1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGrid1_Paint);
			this.dataGrid1.MouseEnter += new System.EventHandler(this.dataGrid1_MouseEnter);
			this.dataGrid1.StyleChanged += new System.EventHandler(this.dataGrid1_StyleChanged);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.dataGrid1;
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "";
			this.dataGridTableStyle1.SelectionBackColor = System.Drawing.Color.White;
			this.dataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(216, 88);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(112, 108);
			this.listBox1.TabIndex = 9;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(256, 480);
			this.button4.Name = "button4";
			this.button4.TabIndex = 10;
			this.button4.Text = "button4";
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(328, 432);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 24);
			this.button5.TabIndex = 11;
			this.button5.Text = "Insert";
			this.button5.Visible = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.BackColor = System.Drawing.Color.AliceBlue;
			this.button6.Location = new System.Drawing.Point(712, 48);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(88, 48);
			this.button6.TabIndex = 12;
			this.button6.Text = "NameOfClass";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.BackColor = System.Drawing.Color.AliceBlue;
			this.button7.Location = new System.Drawing.Point(712, 96);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(88, 48);
			this.button7.TabIndex = 13;
			this.button7.Text = "GenerateClass";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button13
			// 
			this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button13.BackColor = System.Drawing.Color.AliceBlue;
			this.button13.Location = new System.Drawing.Point(712, 0);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(88, 48);
			this.button13.TabIndex = 19;
			this.button13.Text = "Display Tables";
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button14
			// 
			this.button14.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button14.Location = new System.Drawing.Point(384, 400);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(112, 48);
			this.button14.TabIndex = 20;
			this.button14.Text = "BinFile";
			this.button14.Visible = false;
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// button15
			// 
			this.button15.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button15.Location = new System.Drawing.Point(488, 104);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(112, 48);
			this.button15.TabIndex = 21;
			this.button15.Text = "BinFileRead";
			this.button15.Visible = false;
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(464, 120);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(224, 95);
			this.listBox2.TabIndex = 22;
			this.listBox2.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 400);
			this.label3.Name = "label3";
			this.label3.TabIndex = 23;
			this.label3.Text = "label3";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(168, 400);
			this.label4.Name = "label4";
			this.label4.TabIndex = 24;
			this.label4.Text = "label4";
			this.label4.Visible = false;
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(256, 432);
			this.button16.Name = "button16";
			this.button16.TabIndex = 25;
			this.button16.Text = "button16";
			this.button16.Visible = false;
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Bugs", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("BugID", "BugID"),
																																																			  new System.Data.Common.DataColumnMapping("Resolution_date", "Resolution_date"),
																																																			  new System.Data.Common.DataColumnMapping("Product", "Product"),
																																																			  new System.Data.Common.DataColumnMapping("Version", "Version")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM Bugs WHERE (BugID = @Original_BugID) AND (Product = @Original_Product OR @Original_Product IS NULL AND Product IS NULL) AND (Resolution_date = @Original_Resolution_date OR @Original_Resolution_date IS NULL AND Resolution_date IS NULL) AND (Version = @Original_Version OR @Original_Version IS NULL AND Version IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_BugID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BugID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Product", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Product", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Resolution_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Resolution_date", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Version", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Version", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=DVUKELIC;packet size=4096;user id=sa;data source=DVUKELIC;persist " +
				"security info=False;initial catalog=Bugs";
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Bugs(Resolution_date, Product, Version) VALUES (@Resolution_date, @Pr" +
				"oduct, @Version); SELECT BugID, Resolution_date, Product, Version FROM Bugs WHER" +
				"E (BugID = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Resolution_date", System.Data.SqlDbType.DateTime, 8, "Resolution_date"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Product", System.Data.SqlDbType.Int, 4, "Product"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.VarChar, 50, "Version"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT BugID, Resolution_date, Product, Version FROM Bugs";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Bugs SET Resolution_date = @Resolution_date, Product = @Product, Version = @Version WHERE (BugID = @Original_BugID) AND (Product = @Original_Product OR @Original_Product IS NULL AND Product IS NULL) AND (Resolution_date = @Original_Resolution_date OR @Original_Resolution_date IS NULL AND Resolution_date IS NULL) AND (Version = @Original_Version OR @Original_Version IS NULL AND Version IS NULL); SELECT BugID, Resolution_date, Product, Version FROM Bugs WHERE (BugID = @BugID)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Resolution_date", System.Data.SqlDbType.DateTime, 8, "Resolution_date"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Product", System.Data.SqlDbType.Int, 4, "Product"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.VarChar, 50, "Version"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_BugID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "BugID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Product", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Product", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Resolution_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Resolution_date", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Version", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Version", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@BugID", System.Data.SqlDbType.Int, 4, "BugID"));
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(32, 432);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.TabIndex = 26;
			this.dateTimePicker1.Value = new System.DateTime(2004, 9, 25, 0, 0, 0, 0);
			this.dateTimePicker1.Visible = false;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "cs";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Exit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(40, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 27;
			this.label5.Text = "Server";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBox3
			// 
			this.listBox3.Location = new System.Drawing.Point(328, 88);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(128, 108);
			this.listBox3.TabIndex = 28;
			this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(216, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 29;
			this.label6.Text = "User name";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(384, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 23);
			this.label7.TabIndex = 31;
			this.label7.Text = "Password";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(456, 56);
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(80, 20);
			this.textBox3.TabIndex = 30;
			this.textBox3.Text = "sa";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(552, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 23);
			this.label8.TabIndex = 33;
			this.label8.Text = "Database";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(624, 56);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(80, 20);
			this.textBox4.TabIndex = 32;
			this.textBox4.Text = "CarsDBase";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(32, 216);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 24);
			this.label9.TabIndex = 34;
			this.label9.Text = "Click on Table name";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(32, 240);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox5.Size = new System.Drawing.Size(488, 112);
			this.textBox5.TabIndex = 35;
			this.textBox5.Text = "";
			this.textBox5.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button15);
			this.panel1.Location = new System.Drawing.Point(16, 360);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 152);
			this.panel1.TabIndex = 37;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(376, 72);
			this.button9.Name = "button9";
			this.button9.TabIndex = 39;
			this.button9.Text = "Use Class";
			this.button9.Visible = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.AliceBlue;
			this.button8.CausesValidation = false;
			this.button8.Location = new System.Drawing.Point(0, 0);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(88, 48);
			this.button8.TabIndex = 38;
			this.button8.Text = "Cancel";
			this.button8.Click += new System.EventHandler(this.button8_Click_1);
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
			this.errorProvider1.ContainerControl = this;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(-56, 368);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(640, 20);
			this.textBox6.TabIndex = 40;
			this.textBox6.Text = "";
			this.textBox6.Visible = false;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(-56, 400);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(624, 20);
			this.textBox7.TabIndex = 41;
			this.textBox7.Text = "";
			this.textBox7.Visible = false;
			// 
			// dataGrid2
			// 
			this.dataGrid2.DataMember = "";
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(320, 392);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.Size = new System.Drawing.Size(248, 88);
			this.dataGrid2.TabIndex = 42;
			this.dataGrid2.Visible = false;
			this.dataGrid2.Click += new System.EventHandler(this.dataGrid2_Click);
			this.dataGrid2.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid2_Navigate);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(416, 464);
			this.button10.Name = "button10";
			this.button10.TabIndex = 43;
			this.button10.Text = "Condition ";
			this.button10.Visible = false;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(504, 456);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(128, 20);
			this.textBox8.TabIndex = 44;
			this.textBox8.Text = "";
			this.textBox8.Visible = false;
			// 
			// listBox4
			// 
			this.listBox4.Location = new System.Drawing.Point(496, 368);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(120, 95);
			this.listBox4.TabIndex = 45;
			this.listBox4.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(800, 534);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.dataGrid2);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button14);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Generating Class from Table";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			scon = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";

			hh = dataGrid1.PreferredRowHeight;
			ww = dataGrid1.PreferredColumnWidth;

			//INSERT INTO Bugs(Resolution_date, Product, Version) VALUES (@Resolution_date, @Product, @Version); SELECT BugID, Resolution_date, Product, Version FROM Bugs WHERE (BugID = @@IDENTITY)
			// DELETE FROM Bugs WHERE (BugID = @Original_BugID) AND (Product = @Original_Product OR @Original_Product IS NULL AND Product IS NULL) AND (Resolution_date = @Original_Resolution_date OR @Original_Resolution_date IS NULL AND Resolution_date IS NULL) AND (Version = @Original_Version OR @Original_Version IS NULL AND Version IS NULL)
			// UPDATE Bugs SET Resolution_date = @Resolution_date, Product = @Product, Version = @Version WHERE (BugID = @Original_BugID) AND (Product = @Original_Product OR @Original_Product IS NULL AND Product IS NULL) AND (Resolution_date = @Original_Resolution_date OR @Original_Resolution_date IS NULL AND Resolution_date IS NULL) AND (Version = @Original_Version OR @Original_Version IS NULL AND Version IS NULL); SELECT BugID, Resolution_date, Product, Version FROM Bugs WHERE (BugID = @BugID)
			// SELECT BugID, Resolution_date, Product, Version FROM Bugs
			

		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text = "1"; 
			this.textBox2.Text = "1";
			int a1 = int.Parse(textBox1.Text);
			int a2 = int.Parse(textBox2.Text);

			int a3 = a1 + a2;
			label2.Text = a3.ToString();

			
 
 
		}

		// the Bug class 
		public class Bug
		{
			// private instance variables
			private int bugID;
			private string title;
			private string reporter;
			private string product;
			private string version;
			private string description;
			private DateTime dateCreated;
			private string severity;
      
			// constructor
			public Bug(int id, 
				string title,        // for display
				string reporter,     // who filed bug
				string product, 
				string version, 
				string description,  // bug report
				DateTime dateCreated, 
				string severity)
			{
				bugID = id;                      
				this.title = title;              
				this.reporter = reporter;        
				this.product = product;          
				this.version = version;
				this.description = description;
				this.dateCreated = dateCreated;
				this.severity = severity;
			}

			// public read only properties
			public int        BugID          
			{ get { return bugID; }}
			public string     Title          
			{ get { return title; }}
			public string     Reporter       
			{ get { return reporter; }}
			public string     Product        
			{ get { return product;  }}
			public string     Version        
			{ get { return version;  }}
			public string     Description    
			{ get { return description; }}
			public DateTime   DateCreated    
			{ get { return dateCreated; }}
			public string     Severity       
			{ get { return severity; }}

		}


		private void button2_Click(object sender, System.EventArgs e)
		{
			
			bugs.Add(
				new Bug(
				101,
				"Bad Property Value",
				"Jesse Liberty", 
				"XBugs",
				"0.01",
				"Property values incorrect",
				DateTime.Now,
				"High"
				)      // end new bug
				);        // end add

			bugs.Add(
				new Bug(
				102,
				"Doesn't load properly",
				"Dan Hurwitz", 
				"XBugs",
				"0.01",
				"The system fails with error x2397",
				DateTime.Now,
				"Medium"
				)      // end new bug
				);        // end add

			// assign the data source
	
			// bind the grid
			//dataGrid1.DataSource = bugs;
			

		}

		private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		   
		}

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			//MessageBox.Show("Clikc");
			//int dt = dataGrid1.CurrentCell.RowNumber;
			//MessageBox.Show(dt.ToString());
			
			
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			
			
				//592, 120
			
			
			bugs.Add(
				new Bug(
				101,
				"Bad Property Value",
				"Jesse Liberty", 
				"XBugs",
				"0.01",
				"Property values incorrect",
				DateTime.Now,
				"High"
				)      // end new bug
				);  
 
			bugs.Add(
				new Bug(
				102,
				"Doesn't load properly",
				"Dan Hurwitz", 
				"XBugs",
				"0.01",
				"The system fails with error x2397",
				DateTime.Now,
				"Medium"
				)      // end new bug
				);   

			dgmake();

			
		}

		private void dgmake()
		{
			DataGrid dg = new DataGrid();
			
			dg.DataSource = bugs;

			dataGrid1 = dg;

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
		 
					

			//	for (int i=1; i<11;i++)
		//	{
		//		//this.listBox1.Items.Add("Something".PadRight(20,' ') +i.ToString().PadLeft(15,' ')); 
		//		this.listBox1.Items.Add("Something".PadRight(20,'_') +i.ToString().PadLeft(15,'_')); 
		//	}

			//ptl.clas4 c4 = new ptl.clas4();
			//c4.BugHistoryID = 35;
			//MessageBox.Show(c4.BugHistoryID.ToString());  
		}

		private void button14_Click(object sender, System.EventArgs e)
		{
			ClassData.BinaryFile bf = new ClassData.BinaryFile();
			bf.FileName = @"C:\Test.dll";
			bf.BinWriter(this.textBox1.Text);
			bf = null;

		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			for (int a=1;a<250;a++)
			{
				char aa = (char)a;

			     //  char aa = (char) 34;  "

			    // char ab = (char) 39; ' 
				// (char) 44  ,
				// (char) 41 )

				this.listBox4.Items.Add(aa.ToString()+" | "+a.ToString() ); 
			}
			//ClassData.BinaryFile bff = new ClassData.BinaryFile();
			//bff.FileName = @"C:\Test.dll";
			//string st = bff.BinReader();
			//bff = null;
			//this.textBox2.Text = st;

		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			ds.Clear();

			ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
			
			scon = "server="+this.textBox1.Text+"; "+"uid="+textBox2.Text+"; "+"pwd="+textBox3.Text+"; "+"database="+textBox4.Text;
			//MessageBox.Show(scon);

			//scon = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";

			sq.DbaseConnection = scon;
			sq.SqlText = "Select Name From sysobjects where Category=513 or Category=1";
			ArrayList al = new ArrayList();
			al = sq.RunViewSQL("|");
 
			DataTable dt = new DataTable();

			 
			dt = sq.RunViewSQL();


			//for (int i=0;i<dt.Columns.Count;i++)
			//{
			//	listBox1.Items.Add(dt.Columns[i].ToString()); 
			//}

			
			int n = dt.Columns.Count;
			//dc.Count;
			
				
			//for (int i=0;i<dt.Columns.Count;i++)
			//{
			//	listBox1.Items.Add(dt.Columns[i].ToString()); 
			//}

			
			dt.TableName = "Tabele";
			ds.Merge(dt);
		

			
			dv.Table = ds.Tables[0];
			dv.Sort = "Name";

		//	dataGrid1.SetDataBinding(ds,"Tabele"); 
			dataGrid1.DataSource = dv;
			
			sq = null;
			
			
		}

		private void dataGrid1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
				

			
			
			
		}

		private void dataGrid1_StyleChanged(object sender, System.EventArgs e)
		{
			//MessageBox.Show("style");
		}

		private void dataGrid1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			 
			
			DataGrid.HitTestInfo clickInfo = dataGrid1.HitTest(e.X, e.Y);
			

			if (clickInfo.Type == DataGrid.HitTestType.RowResize) 
			{ 
				res = true;
				
			} 
			else
			{
				res = false;
			}

			
			//n = this.dataGrid1.CurrentCell.RowNumber;
			
			
			

			

		}

		private void dataGrid1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (res)
			{
				
				dataGrid1.Refresh();

							
			}

			//if (n>-1)
			//	this.dataGrid1.CurrentRowIndex = n;
			
		}

		private void button16_Click(object sender, System.EventArgs e)
		{
			dv.Sort = "Category";

		}

		private void dataGrid1_Click_1(object sender, System.EventArgs e)
		{
			int r = dataGrid1.CurrentRowIndex;
			GetTables(r);
			
		}

		private void GetTables(int nn)
		{
			
			NameOfTable = dataGrid1[nn,0].ToString();

			ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
			
			sq.DbaseConnection = scon;
			sq.SqlText = "Select * From " + NameOfTable;
			ArrayList al = new ArrayList();
			al = sq.RunViewSQL("|");
 
			DataTable dt = new DataTable();

			 
			dt = sq.RunViewSQL();


			listBox1.Items.Clear();
			listBox2.Items.Clear();
			listBox3.Items.Clear();

			for (int i=0;i<dt.Columns.Count;i++)
			{
				listBox1.Items.Add(dt.Columns[i].ToString()); 
				listBox3.Items.Add(dt.Columns[i].DataType.ToString()); 

				listBox2.Items.Add(dt.Columns[i].ToString()); 
				listBox2.Items.Add(dt.Columns[i].DataType.ToString()); 
			}

			
			int n = dt.Columns.Count;
			//dc.Count;
			
				
			//for (int i=0;i<dt.Columns.Count;i++)
			//{
			//	listBox1.Items.Add(dt.Columns[i].ToString()); 
			//}

			
			
			sq = null;


			
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			int d = 5;
			string date = dtime.ToShortDateString(); 
			string number = d.ToString();
			string myversion = "myversion5";
			string ins = @"INSERT INTO Bugs(Resolution_date, Product, Version) VALUES ("+ date  +','+ number+','+ "'"+myversion+"')";
			MessageBox.Show(ins);
			ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
			
			sq.DbaseConnection = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";
			sq.SqlText = ins;
			int nn = sq.RunUpdateSQL();
			MessageBox.Show(nn.ToString());
			sq = null;
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			
			
			dtime = dateTimePicker1.Value;

			string cn = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";
			double d = 10.45;
            decimal d1 = Convert.ToDecimal(d);
 
			decimal d2 = d1;
			ptl.Bugs  bgs = new ptl.Bugs(0,dtime,4,"ver4","desc","hg",d1,d2); 
			int nn = bgs.InsertCommand(0,cn);
//			
			//ptl.clas7 th = new ptl.clas7(3,4,4,4,"hfhf",4,dtime);

//			int num = 5;
//			string number;
//			number = num.ToString();

//			string myversion = "my ver1";

			//int n = bgs.InsertCommand(0);
			//this.textBox6.Text =  bgs.publiccheck; 

			
			
//			string ins = "INSERT INTO Bugs(Resolution_date, Product, Version) VALUES ("+ "'"+dtime.ToLongDateString()+"'" +','+ number+','+ "'"+myversion+"')";
//			string ins2 = "INSERT INTO Bugs(Resolution_date,Product,Version) VALUES ('09/09/2004 00:00:00',1,'my version')";
//
//			//this.textBox6.Text  = ins;
//			//this.textBox7.Text  = ins2;
//
//			
//			//MessageBox.Show(ins);
//
//			ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();
//			sq.DbaseConnection = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";
//			//sq.SqlText =  bgs.publiccheck;
//		   //int nn = sq.RunUpdateSQL();
//			//MessageBox.Show(nn.ToString());
//			sq = null;

			


			
			
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.saveFileDialog1.ShowDialog();
			fname = this.saveFileDialog1.FileName;
			
			string[] cc = fname.Split('\\');
			
			for (int x=0;x<cc.Length;x++)
			{
				if (cc[x].IndexOf('.')>-1)
				{
					string[] ccc = cc[x].Split('.');
					classname = ccc[0];
				}
			}
			
			//MessageBox.Show(fname+ ' ' +classname);
			


		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			

			ArrayList afile = new ArrayList();

			string[] usi = new string[17];
			usi[0] = @"using System;";
            usi[1] =@"using System.Collections;";
			usi[2] =@"using System.ComponentModel;";
			usi[3] = @"using System.Data;";
			usi[4] = @"using System.Drawing;";
			usi[5] = @"using System.Data.SqlClient;";
			usi[6] = " ";
			usi[7] = @"namespace ptl";
			usi[8]= " ";
			usi[9] = "{";
			usi[10] = @"public class "+classname;
			usi[11] = " ";
			usi[12] = "{";
			usi[13] = @"public "+classname +"()";
		    usi[14] = "{";
			usi[15] = " ";
			usi[16] = "}";
		

			string[] endfile = new string[2];
			endfile[0] = "}";
			endfile[1] = "}";

			
			
			for(int i=0;i<usi.Length;i++)
			{
				afile.Add(usi[i]);
			}



			string mempty = " ";
			string public2="public "+classname+" (";
			

			for (int r=0;r<this.listBox2.Items.Count;r=r+2)
			{
				
				string mcoll = this.listBox2.Items[r].ToString();
				string mtypee = this.listBox2.Items[r+1].ToString();

				public2 = public2 + mtypee +' '+ mcoll.ToUpper()+','; 

			}

			public2 = public2+')';
			public2 = public2.Replace(",)"," )");

			afile.Add(mempty);
			afile.Add(public2);
			afile.Add("{");

			for (int rr=0;rr<this.listBox2.Items.Count;rr=rr+2)
			{
				
				string mcolll = this.listBox2.Items[rr].ToString();
				string mtypeee = this.listBox2.Items[rr+1].ToString();

				afile.Add(mcolll.ToLower()+'='+mcolll.ToUpper()+';');
				
			}

			afile.Add("}");

			afile.Add(mempty);

			//MessageBox.Show(public2);

			//@"public "+classname +"()"

			for (int t=0;t<this.listBox2.Items.Count;t=t+2)
			{
				afile.Add(mempty);
				string mcol = this.listBox2.Items[t].ToString();
				string mtype = this.listBox2.Items[t+1].ToString();

				afile.Add("private "+mtype+' '+mcol.ToLower()+';');  
				afile.Add(mempty);  
				afile.Add("public "+mtype+' '+mcol);  
				afile.Add("{");
				afile.Add("get");
				afile.Add("{");
				afile.Add("return "+mcol.ToLower()+';');
				afile.Add("}");
				afile.Add("set");
				afile.Add("{");
				afile.Add(mcol.ToLower()+'='+"value;");
				afile.Add("}");
				afile.Add("}");
			}

		    // methods
			//string NameOfTable

			
			afile.Add(mempty);
			afile.Add("public int InsertCommand()");
			afile.Add("{");
			afile.Add(@"// Use this InsertCommand with PrimaryKey Field which is not AutoIncement;");
			afile.Add("int numberinsert=0;");

			string cinsert=@"// INSERT INTO "+NameOfTable+'(';

			

			for (int xr=0;xr<this.listBox2.Items.Count;xr=xr+2)
			{
				string mcoll2 = this.listBox2.Items[xr].ToString();
				
				cinsert = cinsert +mcoll2+','; 
			}

			cinsert = cinsert+')';
			cinsert = cinsert.Replace(",)"," )");


			cinsert = cinsert + " VALUES(";

			for (int xxr=0;xxr<this.listBox2.Items.Count;xxr=xxr+2)
			{
				string mcoll3 = this.listBox2.Items[xxr].ToString();
				
				cinsert = cinsert +mcoll3.ToLower()+','; 
			}

			cinsert = cinsert+')';
			cinsert = cinsert.Replace(",)"," )");
			cinsert = cinsert +';';
			
			//MessageBox.Show(cinsert);
			afile.Add(cinsert);
			string mes = @"// For string you need 'string', for datetime 'datetime for numbers just number.ToString();";
			afile.Add(mes);
			afile.Add("return numberinsert;");
			afile.Add("}");

            
			afile.Add(mempty);

			///////////
			///

			afile.Add(mempty);
			afile.Add("public int InsertCommand(int IndexOfIncrementField, string Con)");
			afile.Add("{");
			afile.Add(@"// Use this InsertCommand with PrimaryKey Field is AutoIncement;");
			afile.Add("int numberinsert=0;");

			string cinsertI= @"INSERT INTO "+NameOfTable+'(';
			cinsertI = '"'+cinsertI;
			cinsertI = "string minsert = " + cinsertI;

			int lastone = this.listBox2.Items.Count - 2;

			for (int Ixr=2;Ixr<this.listBox2.Items.Count;Ixr=Ixr+2)
			{
				string mcoll2I = this.listBox2.Items[Ixr].ToString();
				cinsertI = cinsertI +mcoll2I+','; 
				
			}

			cinsertI = cinsertI+')';
			cinsertI = cinsertI.Replace(",)"," )");


			cinsertI = cinsertI + " VALUES(" +'"'+"+";
			
			

			    // char aa = (char) 34;  "

			    // char ab = (char) 39; '   

			for (int Ixxr=2;Ixxr<this.listBox2.Items.Count;Ixxr=Ixxr+2)
			{
				string mcoll3I = this.listBox2.Items[Ixxr].ToString();
				string mcoll3A = this.listBox2.Items[Ixxr+1].ToString();
				if (mcoll3A.CompareTo("System.Int32")==0 || mcoll3A.CompareTo("System.Decimal")==0)
				{
					mcoll3I = mcoll3I.ToLower()+".ToString()";
				}
				else
				{
					mcoll3I = @"(char)39+"+mcoll3I.ToLower()+".ToString()"+"+(char)39";
				}


				if (Ixxr == lastone)
				{
					cinsertI = cinsertI +mcoll3I;
				}
				else
				{
					cinsertI = cinsertI +mcoll3I+"+(char)44+";
				}

				
			}

			// 44 ,
			// 41 )
			cinsertI = cinsertI+'+';
			cinsertI = cinsertI+ "(char)41";
			cinsertI = cinsertI + ';';
			
			//MessageBox.Show(cinsert);
			afile.Add(cinsertI);
			string mesI = @"// For string you need 'string', for datetime 'datetime for numbers just number.ToString();";
			afile.Add(mesI);

			afile.Add("ptl.DbaseSQLServer sqinsert = new ptl.DbaseSQLServer();");
			afile.Add("sqinsert.DbaseConnection = Con;");
			afile.Add ("sqinsert.SqlText = minsert;");
			afile.Add("numberinsert = sqinsert.RunUpdateSQL();");
			afile.Add("sqinsert = null;");
			// minsert


			afile.Add("return numberinsert;");
			afile.Add("}");



			////////////
			///
 
			//string ins = @"UPDATE Bugs SET Resolution_date = resolution_date";

			afile.Add(mempty);
			string mupdate = @"public int UpdateEditComand(string Con)";
			afile.Add(mupdate);
			afile.Add("{");
			afile.Add("int numberedit=0;");

			string cupdate="UPDATE "+NameOfTable+ " SET ";
			cupdate = '"'+cupdate;
			cupdate = "string mupdate = "+cupdate +'"' + '+';
			//afile.Add(cupdate);

			//string WtoUpdate = @"//  + WhatToUpdate WHERE";
			//afile.Add(WtoUpdate);

			int lastone2 = this.listBox2.Items.Count - 2;

			for (int axr=2;axr<this.listBox2.Items.Count;axr=axr+2)
			{
				string Amcoll3I = this.listBox2.Items[axr].ToString();
				string Amcoll3A = this.listBox2.Items[axr+1].ToString();

				if (Amcoll3A.CompareTo("System.Int32")==0 || Amcoll3A.CompareTo("System.Decimal")==0)
				{
					Amcoll3I = '"' + Amcoll3I +'=' + '"' + '+' + Amcoll3I.ToLower()+".ToString()";
				}
				else
				{
					Amcoll3I = '"' + Amcoll3I +'='+'"' + '+' + "(char)39+"+Amcoll3I.ToLower()+".ToString()"+"+(char)39";
					
				}

				if (axr == lastone2)
				{
					cupdate = cupdate +Amcoll3I;
				}
				else
				{
					cupdate = cupdate +Amcoll3I+"+(char)44+";
				}

				
			}

			//cdel = cdel + mfield + '=' + '"';
			//cdel = cdel + '+' + mfield.ToLower()+".ToString();";
			
			string mfieldA = this.listBox2.Items[0].ToString();
			cupdate = cupdate + '+' + '"' + " WHERE " + mfieldA + '=' + '"';

			cupdate = cupdate + '+' + mfieldA.ToLower()+".ToString();";
		
			afile.Add(cupdate);

			afile.Add("ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();");
			afile.Add("sq.DbaseConnection = Con;");
			afile.Add ("sq.SqlText = mupdate;");
			afile.Add("numberedit = sq.RunUpdateSQL();");
			afile.Add("sq = null;");
			
			//MessageBox.Show(cinsert);
			
			afile.Add("return numberedit;");
			afile.Add("}");

			afile.Add(mempty);
 
			//string ins = @"UDATE Bugs SET Resolution_date=resolution_date WHERE Resoultion_date=oldResolution_date AND Product=oldProduct ";


			//string ins = @"UPDATE Bugs SET Resolution_date = resolution_date";

			afile.Add(mempty);
			string mdel = @"public int DeleteComand(string Con)";
			afile.Add(mdel);
			afile.Add("{");
			afile.Add("int numberdelete=0;");

			string cdel=@"DELETE FROM "+NameOfTable +" WHERE ";
			// DELETE FROM Bugs WHERE +BugID+=+bugid;
			cdel = '"'+cdel;
			cdel = "string del = "+cdel;
			string mfield = this.listBox2.Items[0].ToString();
			cdel = cdel + mfield + '=' + '"';
			cdel = cdel + '+' + mfield.ToLower()+".ToString();";
			afile.Add(cdel);
			

			for (int aaxr=0;aaxr<this.listBox2.Items.Count;aaxr=aaxr+2)
			{
				string aamcoll2 = this.listBox2.Items[aaxr].ToString();
				string aam = " // " + aamcoll2 + '=' +"OldData[i].ToString() AND";
				
				afile.Add(aam);
			}

			
			
			//MessageBox.Show(cinsert);
			
			afile.Add("ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();");
			afile.Add("sq.DbaseConnection = Con;");
			afile.Add ("sq.SqlText = del;");
			afile.Add("numberdelete = sq.RunUpdateSQL();");
			afile.Add("sq = null;");
			
			afile.Add("return numberdelete;");
			afile.Add("}");

			afile.Add(mempty);

			// string delete = "DELETE FROM Table Where DD";


			afile.Add(mempty);
			string msel = @"public ArrayList SearchResultAsArrayList(string SearchExp, string Con)";
			afile.Add(msel);
			afile.Add("{");
			afile.Add("ArrayList alsearch = new ArrayList();");
						
			string csel="SELECT * FROM "+NameOfTable+' '+'"' +" +SearchExp"+";";
			csel = '"'+ csel;
			csel = "string alistsearch = "+csel;

			afile.Add(csel);

			afile.Add("ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();");
			afile.Add("sq.DbaseConnection = Con;");
			afile.Add ("sq.SqlText = alistsearch;");
			afile.Add(@"alsearch = sq.RunViewSQL("+'"'+'|'+'"'+')'+';');
			afile.Add("sq = null;");
			afile.Add("return alsearch;");
			afile.Add("}");

			afile.Add(mempty);

			afile.Add(mempty);
			string Almsel = @"public ArrayList GetAllDataAsArrayList(string Con)";
			afile.Add(Almsel);
			afile.Add("{");
			afile.Add("ArrayList alsearch = new ArrayList();");
						
			string Alcsel="SELECT * FROM "+NameOfTable+'"'+";";
			Alcsel = '"'+ Alcsel;
			Alcsel = "string alistsearch = "+Alcsel;

			afile.Add(Alcsel);

			afile.Add("ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();");
			afile.Add("sq.DbaseConnection = Con;");
			afile.Add ("sq.SqlText = alistsearch;");
			afile.Add(@"alsearch = sq.RunViewSQL("+'"'+'|'+'"'+')'+';');
			afile.Add("sq = null;");
			afile.Add("return alsearch;");
			afile.Add("}");

			afile.Add(mempty);

			// search SELECT * FROM TABLE WHERE condition

			afile.Add(mempty);
			string msel1 = @"public DataTable SearchResultAsTable(string SearchExp, string Con)";
			afile.Add(msel1);
			afile.Add("{");
			afile.Add("DataTable dt = new DataTable();");
									
			string csel1="SELECT * FROM "+NameOfTable+' '+'"' +" +SearchExp"+";";
			csel1 = '"'+ csel1;
			csel1 = "string dtsearch = "+csel1;

			afile.Add(csel1);

			afile.Add("ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();");
			afile.Add("sq.DbaseConnection = Con;");
			afile.Add ("sq.SqlText = dtsearch;");
			afile.Add("dt = sq.RunViewSQL();");
			afile.Add("sq = null;");
			afile.Add("return dt;");
			afile.Add("}");

			afile.Add(mempty);

			afile.Add(mempty);
			string msel2 = @"public DataTable GetAllDataAsTable(string Con)";
			afile.Add(msel2);
			afile.Add("{");
			afile.Add("DataTable dt = new DataTable();");
									
			string csel2="SELECT * FROM "+NameOfTable+'"'+";";
			csel2 = '"'+ csel2;
			csel2 = "string dtsearch = "+csel2;

			afile.Add(csel2);

			afile.Add("ptl.DbaseSQLServer sq= new ptl.DbaseSQLServer();");
			afile.Add("sq.DbaseConnection = Con;");
			afile.Add ("sq.SqlText = dtsearch;");
			afile.Add("dt = sq.RunViewSQL();");
			afile.Add("sq = null;");
			afile.Add("return dt;");
			afile.Add("}");

			afile.Add(mempty);

			/// Table object return

			//

			for(int y=0;y<endfile.Length;y++)
			{
				afile.Add(endfile[y]);
			}

			ClassData.TxtFile tx = new ClassData.TxtFile();
			tx.FileName = fname;
			tx.ArrayListToFile(afile);

			this.textBox5.Text = "";
			this.textBox5.Visible = true;

            this.textBox5.Lines = tx.FileToArray();  

			tx= null;



		}

		private void dataGrid1_Navigate_1(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			//classname = this.textBox1.Text;
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void dataGrid1_MouseEnter(object sender, System.EventArgs e)
		{
			
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			int n = this.dataGrid1.CurrentCell.RowNumber;
			dataGrid1.Select(n);
			GetTables(n);
			
			
		}

		private void button8_Click_1(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//try
			//{
			//	int n = int.Parse(this.textBox1.Text);
//
//				errorProvider1.SetError(this.textBox1, "");


//			}
//			catch
//			{
//				errorProvider1.SetError(this.textBox1, "Prblem");
//				this.textBox1.Focus(); 
//			}
		}

		private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//MessageBox.Show(KeyValue.ToString());
			// symbol ' = (char) 222
		}

		private void textBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//	MessageBox.Show(e.KeyChar.ToString());
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
//			ptl.Bugs OBugs = new ptl.Bugs();
//			DataSet ds = new DataSet();
//			DataTable dt1 = new DataTable();
//			dt1 = OBugs.DTSearchListComand(scon);
//			OBugs = null;
//
//			ds.Merge(dt1);
//			dataGrid2.DataSource = ds.Tables[0];
//			
			
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			// Where Version LIKE 'M%' for SQL server 2000
			string condition;
			condition = "WHERE BugID<3";
			condition = this.textBox8.Text.ToString();
			ptl.Bugs OBugs = new ptl.Bugs();
			DataSet ds = new DataSet();
			DataTable dt1 = new DataTable();
			ArrayList al = new ArrayList();
			dt1 = OBugs.SearchResultAsTable(condition, scon);
			al = OBugs.SearchResultAsArrayList(condition, scon);
			listBox4.DataSource = al;
			OBugs = null;

			ds.Merge(dt1);
			dataGrid2.DataSource = ds.Tables[0];
		}

		private void dataGrid2_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
			//bdel.BugID 
		}

		private void dataGrid2_Click(object sender, System.EventArgs e)
		{
			int r = dataGrid2.CurrentRowIndex;
			string rr = dataGrid2[r,0].ToString();
			int dd = int.Parse(rr);
			//MessageBox.Show(rr);

			double d = 34.67;
			double a = 45.67;

			decimal d1 = Convert.ToDecimal(d) ;
			decimal d2 = Convert.ToDecimal(a);

			ptl.Bugs  bgs = new ptl.Bugs(0,dtime,4,"Myver4","desc","hg",d1,d2); 
			bgs.BugID = dd;

	
		
			int ddd = bgs.UpdateEditComand(scon); 
			bgs = null;
		}

	}
}
