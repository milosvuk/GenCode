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
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListBox listBox4;
        private Button button11;
        private Label label11;
        private Label label10;
        private IContainer components;
        private Label label12;
        private Label label13;
        private TextBox textBox9;
        private Button button12;
        private Button button17;
        private Label label14;
        private Button button18;
        private Button button20;
        private Button button19;
        private Button button21;
        private MenuItem menuItem3;
        private Button button22;
        private GroupBox groupBox1;
        private Button button23;
        private Button button8;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2;
        private Label label15;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private string Delimit = @"////==========================================================================";


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem3 = new System.Windows.Forms.MenuItem();
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button23 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(43, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is a something new";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "DESKTOP-5T298NI";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "sa";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(505, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "ArrayListToGrid";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(420, 658);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
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
            this.dataGrid1.Location = new System.Drawing.Point(143, 23);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.PreferredColumnWidth = 125;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.Size = new System.Drawing.Size(217, 119);
            this.dataGrid1.TabIndex = 8;
            this.dataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
            this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click_1);
            this.dataGrid1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGrid1_Paint);
            this.dataGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseDown);
            this.dataGrid1.MouseEnter += new System.EventHandler(this.dataGrid1_MouseEnter);
            this.dataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseUp);
            this.dataGrid1.StyleChanged += new System.EventHandler(this.dataGrid1_StyleChanged);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.dataGrid1;
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(371, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 104);
            this.listBox1.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 683);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 22);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(881, 721);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 24);
            this.button5.TabIndex = 11;
            this.button5.Text = "Insert";
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Location = new System.Drawing.Point(522, -3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 21);
            this.button6.TabIndex = 12;
            this.button6.Text = "NameOfClass";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Location = new System.Drawing.Point(709, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 47);
            this.button7.TabIndex = 13;
            this.button7.Text = "Generate Class";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.BackColor = System.Drawing.Color.AliceBlue;
            this.button13.Location = new System.Drawing.Point(11, 30);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(116, 47);
            this.button13.TabIndex = 19;
            this.button13.Text = "Display Tables";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button14.Location = new System.Drawing.Point(973, 732);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(118, 48);
            this.button14.TabIndex = 20;
            this.button14.Text = "BinFile";
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button15.Location = new System.Drawing.Point(521, 58);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(119, 48);
            this.button15.TabIndex = 21;
            this.button15.Text = "BinFileRead";
            this.button15.Visible = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // listBox2
            // 
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(647, -4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(118, 4);
            this.listBox2.TabIndex = 22;
            this.listBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(103, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(711, 690);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(803, 726);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 24);
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
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_BugID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BugID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Product", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Product", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resolution_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resolution_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Version", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Version", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "workstation id=DVUKELIC;packet size=4096;user id=sa;data source=DVUKELIC;persist " +
    "security info=False;initial catalog=Bugs";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Bugs(Resolution_date, Product, Version) VALUES (@Resolution_date, @Pr" +
    "oduct, @Version); SELECT BugID, Resolution_date, Product, Version FROM Bugs WHER" +
    "E (BugID = @@IDENTITY)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Resolution_date", System.Data.SqlDbType.DateTime, 8, "Resolution_date"),
            new System.Data.SqlClient.SqlParameter("@Product", System.Data.SqlDbType.Int, 4, "Product"),
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.VarChar, 50, "Version")});
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT BugID, Resolution_date, Product, Version FROM Bugs";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Resolution_date", System.Data.SqlDbType.DateTime, 8, "Resolution_date"),
            new System.Data.SqlClient.SqlParameter("@Product", System.Data.SqlDbType.Int, 4, "Product"),
            new System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.VarChar, 50, "Version"),
            new System.Data.SqlClient.SqlParameter("@Original_BugID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BugID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Product", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Product", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Resolution_date", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Resolution_date", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Version", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Version", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@BugID", System.Data.SqlDbType.Int, 4, "BugID")});
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 738);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 26);
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
            this.menuItem3,
            this.menuItem2});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Test";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Exit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(34, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Server";
            // 
            // listBox3
            // 
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(546, 23);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(148, 104);
            this.listBox3.TabIndex = 28;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(34, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "User name";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 26);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "nominalism234";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(34, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Database";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(298, 26);
            this.textBox4.TabIndex = 32;
            this.textBox4.Text = "seGIS";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(149, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Click on Table / View Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(777, -1);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(112, 21);
            this.textBox5.TabIndex = 35;
            this.textBox5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Location = new System.Drawing.Point(87, 755);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 62);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(401, 71);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 23);
            this.button9.TabIndex = 39;
            this.button9.Text = "Use Class";
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(-77, 65);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(683, 26);
            this.textBox6.TabIndex = 40;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(-61, -4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(666, 26);
            this.textBox7.TabIndex = 41;
            this.textBox7.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGrid2
            // 
            this.dataGrid2.DataMember = "";
            this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid2.Location = new System.Drawing.Point(871, 726);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(266, 88);
            this.dataGrid2.TabIndex = 42;
            this.dataGrid2.Visible = false;
            this.dataGrid2.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid2_Navigate);
            this.dataGrid2.Click += new System.EventHandler(this.dataGrid2_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(413, 724);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 23);
            this.button10.TabIndex = 43;
            this.button10.Text = "Condition ";
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(571, 728);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(135, 26);
            this.textBox8.TabIndex = 44;
            this.textBox8.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(898, 721);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(128, 24);
            this.listBox4.TabIndex = 45;
            this.listBox4.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, -1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, -1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(349, -3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 22);
            this.button11.TabIndex = 48;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, -2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "ClassName";
            this.label12.Visible = false;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackColor = System.Drawing.Color.AliceBlue;
            this.button12.Location = new System.Drawing.Point(967, -9);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(115, 33);
            this.button12.TabIndex = 50;
            this.button12.Text = "GenerateClassToReadFromTxt";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1156, 346);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(208, 26);
            this.textBox9.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1163, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "Numbers of index separate by coma";
            this.label13.Visible = false;
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.BackColor = System.Drawing.Color.AliceBlue;
            this.button17.Location = new System.Drawing.Point(4, 25);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(181, 48);
            this.button17.TabIndex = 53;
            this.button17.Text = "Generate Win Form";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(433, -1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "FormName";
            this.label14.Visible = false;
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.BackColor = System.Drawing.Color.AliceBlue;
            this.button18.Location = new System.Drawing.Point(11, 95);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(116, 47);
            this.button18.TabIndex = 55;
            this.button18.Text = "Display Views";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.BackColor = System.Drawing.Color.AliceBlue;
            this.button19.Location = new System.Drawing.Point(189, 25);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(216, 48);
            this.button19.TabIndex = 56;
            this.button19.Text = "Generate HTML_Table Single input";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.BackColor = System.Drawing.Color.AliceBlue;
            this.button20.Location = new System.Drawing.Point(409, 25);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(216, 48);
            this.button20.TabIndex = 57;
            this.button20.Text = "Generate HTML_Table GridView input";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.BackColor = System.Drawing.Color.AliceBlue;
            this.button21.Location = new System.Drawing.Point(629, 25);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(216, 48);
            this.button21.TabIndex = 58;
            this.button21.Text = "Generate HTML_Table GridView Bound Columns";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.BackColor = System.Drawing.Color.AliceBlue;
            this.button22.Location = new System.Drawing.Point(629, 16);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(216, 48);
            this.button22.TabIndex = 59;
            this.button22.Text = "Code Control to View";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(33, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 138);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // button23
            // 
            this.button23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button23.BackColor = System.Drawing.Color.AliceBlue;
            this.button23.Location = new System.Drawing.Point(709, 77);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(127, 51);
            this.button23.TabIndex = 62;
            this.button23.Text = "Save Con file";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Location = new System.Drawing.Point(709, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 52);
            this.button8.TabIndex = 61;
            this.button8.Text = "Open Con file";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_2);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dataGrid1);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(33, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 176);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tables / Views";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(729, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 63);
            this.label15.TabIndex = 63;
            this.label15.Text = "MVC > Model /  Controller";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button19);
            this.groupBox3.Controls.Add(this.button20);
            this.groupBox3.Controls.Add(this.button21);
            this.groupBox3.Location = new System.Drawing.Point(33, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 76);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MVC > View";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Location = new System.Drawing.Point(33, 440);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(852, 68);
            this.groupBox4.TabIndex = 63;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "\"Glue\" Classes - Controller to Model to View | View to Model to Controller";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(1346, 788);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGrid2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Code - ver 1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
            textBox9.Visible = false; // this is to get classes to read from txt file

			scon = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";

			hh = dataGrid1.PreferredRowHeight;
			ww = dataGrid1.PreferredColumnWidth;

            label10.Text = DateTime.Now.ToString(); 

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
            try
            {

                ds.Clear();

                ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();

                scon = "server=" + this.textBox1.Text + "; " + "uid=" + textBox2.Text + "; " + "pwd=" + textBox3.Text + "; " + "database=" + textBox4.Text;
                //MessageBox.Show(scon);

                //scon = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";

                sq.DbaseConnection = scon;
                sq.SqlText = "Select Name From sysobjects where Type='U'";
                //sq.SqlText = "Select Name From sysobjects where Category=513 or Category=1";

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
            catch
            {
                MessageBox.Show("SQL server is not active - use services to start");
            }
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

            fname = NameOfTable + ".cs";
            classname = NameOfTable;

            label12.Text = NameOfTable;
			
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

            ArrayList afileDB = new ArrayList();

			string[] usi = new string[22];
			usi[0] = @"using System;";
            usi[1] =@"using System.Collections;";
			usi[2] =@"using System.ComponentModel;";
			usi[3] = @"using System.Data;";
			usi[4] = @"using System.Drawing;";
			usi[5] = @"using System.Data.SqlClient;";
            usi[6] = @"using System.Collections.Generic;";
            usi[7] = @"using System.Data.Sql;";
            usi[8] = @"using System.Data.SqlTypes;";
            usi[9] = @"using System.Text;";  // using System.Text;
			usi[10] = " ";
			usi[11] = @"public class "+classname;
			usi[12] = " ";
			usi[13] = "{";

            usi[14] = @"public ArrayList alErrors = new ArrayList();";
            usi[15] = "public string connectionString;";  // connectionString

            // public ArrayList alErrors = new ArrayList();
            usi[16] = @"public " + classname + "()";

            usi[17] = "{";
		    usi[18] = " ";

            // WEB
            //usi[18] = "System.Configuration.ConnectionStringSettings connString; ";
            //usi[19] = @"connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + (char)34 + "devdb"+(char)34+"];"; 
            //usi[20] = "connectionString = connString.ConnectionString;";

            //Windows
            usi[19] = "  ";
            usi[20] = " ";

			usi[21] = "}";


                       
            

		

			string[] endfile = new string[1];
			endfile[0] = "}";
			//endfile[1] = "}";

			
			
			for(int i=0;i<usi.Length;i++)
			{
				afile.Add(usi[i]);
			}


            for (int i = 0; i < usi.Length; i++)
            {
                	usi[11] = @"public class DB_"+classname;
                	usi[16] = @"public DB_"+classname +"()";
                afileDB.Add(usi[i]);
            }

          

			string mempty = " ";
			string public2="public "+classname+" (";
            char undescore = '_';

			for (int r=0;r<this.listBox2.Items.Count;r=r+2)
			{
				
				string mcoll = this.listBox2.Items[r].ToString();
				string mtypee = this.listBox2.Items[r+1].ToString();

                public2 = public2 + mtypee + ' ' + undescore .ToString()+ mcoll.ToLower() + ','; 

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

				afile.Add(mcolll.ToLower()+"=_"+mcolll.ToLower()+';');
				
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
				afile.Add("public "+mtype+' '+mcol.ToUpper());  
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
            afile.Add(mempty);

            afile.Add("public void New()");
            afile.Add("{");
            string midprimarikey = this.listBox2.Items[0].ToString().ToLower()+" = 0;";
            afile.Add(midprimarikey);
            afile.Add("}");


            afile.Add(Delimit);
            afile.Add("/// END CLASS WHICH CONTAIN ONLY DATA common objects");
            /////////// Should write just oe file 

            afile.Add(Delimit);

            afile.Add(mempty);

            for (int y = 0; y < endfile.Length; y++)
            {
                afile.Add(endfile[y]);
            }

            ClassData.TxtFile tx = new ClassData.TxtFile();
            string fnameclass = Application.StartupPath + @"\" + classname + ".cs";
            tx.FileName = fnameclass;
            tx.ArrayListToFile(afile);
            /////////**********************************


            afile.Add(Delimit);

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

            // (char)64 is @ 
           

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

            /////////**********************************

            
            /////// START WITH ADD WITH PARAMETERS
            afileDB.Add(Delimit);
            afileDB.Add("// ADD WITH PARAMETERS WITH OR WITHOUT TRANS");
            afileDB.Add(Delimit);
            /// ADD with parameters
            /// 
            afileDB.Add(" ");

            string nameofClass = "public int Add("+classname+ " _tmpObject)"; 

            //afileDB.Add("public int Add(CLASSofTHISTABLE _tmpObject)");
            afileDB.Add(nameofClass);
            afileDB.Add("{");

            //usi[18] = "System.Configuration.ConnectionStringSettings connString; ";
            //usi[19] = @"connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + (char)34 + "devdb" + (char)34 + "];";
            //usi[20] = "connectionString = connString.ConnectionString;";

            afileDB.Add(usi[18]);
            afileDB.Add(usi[19]);
            afileDB.Add(usi[20]);
            afileDB.Add("SqlConnection conn = new SqlConnection(connectionString); ");
            afileDB.Add("conn.Open(); ");
            afileDB.Add("int x = Add(_tmpObject, conn, null); ");
            afileDB.Add("conn.Close();");
            afileDB.Add("return x; ");
            //afileDB.Add(" ");
           
                
            afileDB.Add("}");

            afileDB.Add(Delimit);

            //// ADD SECOND PART WITH PARAMETERS


            afileDB.Add(mempty);

            string nameofclassTrans = "public int Add(" + classname + " _tmpObject, SqlConnection conn, SqlTransaction tran)";

            //afileDB.Add("public int Add(CLASSofTHISTABLE _tmpObject, SqlConnection conn, SqlTransaction tran)");
            afileDB.Add(nameofclassTrans);
            afileDB.Add("{");
            afileDB.Add("int res = 0;");
           // afileDB.Add("int numberinsert=0;");

            // (char)64 is @ 
            // (char)34 is "

            //SqlCommand command = new SqlCommand("INSERT INTO users (username, password) VALUES (@username, @password) SET @loginid = SCOPE_IDENTITY()", conn);

            string cinsertIB = "SqlCommand command = new SqlCommand(";
            cinsertI = cinsertIB + (char)34 + @"INSERT INTO " + NameOfTable + " (";
           
            //int lastone = this.listBox2.Items.Count - 2;

            for (int Ixr = 2; Ixr < this.listBox2.Items.Count; Ixr = Ixr + 2)
            {
                string mcoll2I = this.listBox2.Items[Ixr].ToString();
                cinsertI = cinsertI + mcoll2I + ',';

            }

            cinsertI = cinsertI + ')';
            cinsertI = cinsertI.Replace(",)", ")");
            cinsertI = cinsertI.Replace("(,", "(");


            cinsertI = cinsertI + " VALUES (";

            for (int Ixra = 2; Ixra < this.listBox2.Items.Count; Ixra = Ixra + 2)
            {
                string mcoll2Ia = (char)64 + this.listBox2.Items[Ixra].ToString();
                cinsertI = cinsertI + mcoll2Ia + ',';

            }

            cinsertI = cinsertI + ')';
            cinsertI = cinsertI.Replace(",)", ")");
            cinsertI = cinsertI.Replace("(,", "(");

            char doubleApostrof= '"';

            string iden = @" SET " + (char)64 + "tmpid = SCOPE_IDENTITY()" + doubleApostrof.ToString() + ", conn);";

          //  SET @tmpid = SCOPE_IDENTITY()@, conn)

            cinsertI = cinsertI + iden;

            afileDB.Add(cinsertI);

            afileDB.Add("if (tran != null)"); 
            afileDB.Add("{");
            afileDB.Add("command.Transaction = tran;"); 
            afileDB.Add("}");

            //command.Parameters.Add(new SqlParameter("@username", user.USERNAME));

            // char aa = (char) 34;  "
            // (char)64 is @ 
            // (char)34 is "
            // char ab = (char) 39 is  '   
            // char 44 is ,

            string StartParameters = "command.Parameters.Add(new SqlParameter(";
            string EndParameters = "));";

            char simbol_ar = '@';

            for (int Ixxr = 2; Ixxr < this.listBox2.Items.Count; Ixxr = Ixxr + 2)
            {
                string mcoll3I = this.listBox2.Items[Ixxr].ToString();
                string mparamet = doubleApostrof.ToString() + simbol_ar.ToString() + mcoll3I + doubleApostrof.ToString() + ", ";
                string ColumnsCapital = "_tmpObject."+mcoll3I.ToUpper();
                string all = StartParameters + mparamet + ColumnsCapital + EndParameters;
                afileDB.Add(all);

            }

            string startoutparameter = "command.Parameters.Add(new SqlParameter(";
            string secpart = doubleApostrof.ToString() + simbol_ar.ToString() + "tmpid" + doubleApostrof.ToString() + ", SqlDbType.Int));";
            string allout = startoutparameter + secpart;
            afileDB.Add(allout);

            startoutparameter = "command.Parameters[";
            secpart = doubleApostrof.ToString() + simbol_ar.ToString() + "tmpid" + doubleApostrof.ToString() + "].Direction = ParameterDirection.Output;";

            allout = startoutparameter + secpart;
            afileDB.Add(allout);

           afileDB.Add("command.ExecuteNonQuery();");

           startoutparameter = "res = (int)command.Parameters[";
           secpart = doubleApostrof.ToString() + simbol_ar.ToString() + "tmpid" + doubleApostrof.ToString() + "].Value;";
          
            allout = startoutparameter + secpart;
           afileDB.Add(allout);

           afileDB.Add("return res;");
           afileDB.Add("}");

            // 44 ,
            // 41 )
            

            //// End SECOND PART Add with parameters
           afileDB.Add(Delimit);
           afileDB.Add("//END ADD WITH PARAMETERS");
           afileDB.Add(Delimit);


			////////////
			///


            //// START UPDATE WITH PARAMETERS
            //// FIRST PART

           afileDB.Add(Delimit);
           afileDB.Add("// UPDATE WITH PARAMETERS WITH OR WITHOUT TRANS");
           afileDB.Add(Delimit);
           /// ADD with parameters
           /// 
           afileDB.Add(" ");

          nameofClass = "public int Update(" + classname + " _tmpObject)";

           //afileDB.Add("public int Add(CLASSofTHISTABLE _tmpObject)");
           afileDB.Add(nameofClass);
           afileDB.Add("{");

           //usi[18] = "System.Configuration.ConnectionStringSettings connString; ";
           //usi[19] = @"connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + (char)34 + "devdb" + (char)34 + "];";
           //usi[20] = "connectionString = connString.ConnectionString;";

           afileDB.Add(usi[18]);
           afileDB.Add(usi[19]);
           afileDB.Add(usi[20]);
           afileDB.Add("SqlConnection conn = new SqlConnection(connectionString); ");
           afileDB.Add("conn.Open(); ");
           afileDB.Add("int x = Update(_tmpObject, conn, null); ");
           afileDB.Add("conn.Close();");
           afileDB.Add("return x; ");
           //afileDB.Add(" ");


           afileDB.Add("}");

           afileDB.Add(Delimit);

            //// END FIRST PART

           afileDB.Add(mempty);

           nameofclassTrans = "public int Update(" + classname + " _tmpObject, SqlConnection conn, SqlTransaction tran)";

           //afileDB.Add("public int Add(CLASSofTHISTABLE _tmpObject, SqlConnection conn, SqlTransaction tran)");
           afileDB.Add(nameofclassTrans);
           afileDB.Add("{");
           afileDB.Add("int res = 0;");
           // afileDB.Add("int numberinsert=0;");

           // (char)64 is @ 
           // (char)34 is "

           //SqlCommand command = new SqlCommand("INSERT INTO users (username, password) VALUES (@username, @password) SET @loginid = SCOPE_IDENTITY()", conn);

           cinsertIB = "SqlCommand command = new SqlCommand(";
           cinsertI = cinsertIB + (char)34 + @"UPDATE " + NameOfTable + " SET ";

           //int lastone = this.listBox2.Items.Count - 2;

           for (int Ixr = 2; Ixr < this.listBox2.Items.Count; Ixr = Ixr + 2)
           {
               string mcoll2I = this.listBox2.Items[Ixr].ToString();
               cinsertI = cinsertI + mcoll2I + "=" + simbol_ar.ToString() + mcoll2I.ToLower() + ",";

           }

           cinsertI = cinsertI + "  WHERE ";
           // WHERE loginid=@loginid",

           //cinsertI = cinsertI + ')';
           cinsertI = cinsertI.Replace(", ", " ");
           string Mmcoll2I = this.listBox2.Items[0].ToString();
           cinsertI = cinsertI + Mmcoll2I + "=" + simbol_ar.ToString() + Mmcoll2I.ToLower()+doubleApostrof.ToString()+", conn);";

          // cinsertI = cinsertI.Replace("(,", "(");

           afileDB.Add(cinsertI);

           afileDB.Add("if (tran != null)");
           afileDB.Add("{");
           afileDB.Add("command.Transaction = tran;");
           afileDB.Add("}");

           //command.Parameters.Add(new SqlParameter("@username", user.USERNAME));

           // char aa = (char) 34;  "
           // (char)64 is @ 
           // (char)34 is "
           // char ab = (char) 39 is  '   
           // char 44 is ,

           StartParameters = "command.Parameters.Add(new SqlParameter(";
           EndParameters = "));";

           //char simbol_ar = '@';

           for (int Ixxr = 2; Ixxr < this.listBox2.Items.Count; Ixxr = Ixxr + 2)
           {
               string mcoll3I = this.listBox2.Items[Ixxr].ToString().ToLower();
               string mparamet = doubleApostrof.ToString() + simbol_ar.ToString() + mcoll3I + doubleApostrof.ToString() + ", ";
               string ColumnsCapital = "_tmpObject." + mcoll3I.ToUpper();
               string all = StartParameters + mparamet + ColumnsCapital + EndParameters;
               afileDB.Add(all);

           }

           string mcoll3IA = this.listBox2.Items[0].ToString().ToLower();
           string mparametA = doubleApostrof.ToString() + simbol_ar.ToString() + mcoll3IA + doubleApostrof.ToString() + ", ";
           string ColumnsCapitalA = "_tmpObject." + mcoll3IA.ToUpper();
           string allA = StartParameters + mparametA + ColumnsCapitalA + EndParameters;
           afileDB.Add(allA);

           afileDB.Add("res = command.ExecuteNonQuery();");

           afileDB.Add("return res;");
           afileDB.Add("}");

           // 44 ,
           // 41 )


           //// End SECOND PART Add with parameters
           afileDB.Add(Delimit);
           afileDB.Add("//END UPDATE WITH PARAMETERS");
           afileDB.Add(Delimit);

            /// START FIRST PART DELETE WITH PARAMETERS 
           afileDB.Add(Delimit);
           afileDB.Add("// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS");
           afileDB.Add(Delimit);
           /// ADD with parameters
           /// 
           afileDB.Add(" ");

           nameofClass = "public int Delete(" + classname + " _tmpObject)";

           //afileDB.Add("public int Add(CLASSofTHISTABLE _tmpObject)");
           afileDB.Add(nameofClass);
           afileDB.Add("{");

           //usi[18] = "System.Configuration.ConnectionStringSettings connString; ";
           //usi[19] = @"connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + (char)34 + "devdb" + (char)34 + "];";
           //usi[20] = "connectionString = connString.ConnectionString;";

           afileDB.Add(usi[18]);
           afileDB.Add(usi[19]);
           afileDB.Add(usi[20]);
           afileDB.Add("SqlConnection conn = new SqlConnection(connectionString); ");
           afileDB.Add("conn.Open(); ");
           afileDB.Add("int x = Delete(_tmpObject, conn, null); ");
           afileDB.Add("conn.Close();");
           afileDB.Add("return x; ");
           //afileDB.Add(" ");


           afileDB.Add("}");

           afileDB.Add(Delimit);

           ////// END FIRST PART DELETE WITH PARAMETERS


            ////// START SECOND PART WITH PARAMETERS
           afileDB.Add(mempty);

           nameofclassTrans = "public int Delete(" + classname + " _tmpObject, SqlConnection conn, SqlTransaction tran)";

           //afileDB.Add("public int Add(CLASSofTHISTABLE _tmpObject, SqlConnection conn, SqlTransaction tran)");
           afileDB.Add(nameofclassTrans);
           afileDB.Add("{");
           afileDB.Add("int res = 0;");
           // afileDB.Add("int numberinsert=0;");

           // (char)64 is @ 
           // (char)34 is "

           //SqlCommand command = new SqlCommand("INSERT INTO users (username, password) VALUES (@username, @password) SET @loginid = SCOPE_IDENTITY()", conn);

           cinsertIB = "SqlCommand command = new SqlCommand(";

           /// SQL Command Delete Tabele or Delete From Table (last one applicable for Access2000
           /// cinsertI = cinsertIB + (char)34 + @"DELETE FROM " + NameOfTable + " SET ";

           cinsertI = cinsertIB + (char)34 + @"DELETE FROM " + NameOfTable;

           cinsertI = cinsertI + "  WHERE ";
           // WHERE loginid=@loginid",

           string Mmcoll2IA = this.listBox2.Items[0].ToString();
           cinsertI = cinsertI + Mmcoll2IA + "=" + simbol_ar.ToString() + Mmcoll2IA.ToLower() + doubleApostrof.ToString() + ", conn);";

           // cinsertI = cinsertI.Replace("(,", "(");

           afileDB.Add(cinsertI);

           afileDB.Add("if (tran != null)");
           afileDB.Add("{");
           afileDB.Add("command.Transaction = tran;");
           afileDB.Add("}");

           //command.Parameters.Add(new SqlParameter("@username", user.USERNAME));

           // char aa = (char) 34;  "
           // (char)64 is @ 
           // (char)34 is "
           // char ab = (char) 39 is  '   
           // char 44 is ,

           StartParameters = "command.Parameters.Add(new SqlParameter(";
           EndParameters = "));";

           //char simbol_ar = '@';

           string mcoll3IAB = this.listBox2.Items[0].ToString().ToLower();
           string mparametAB = doubleApostrof.ToString() + simbol_ar.ToString() + mcoll3IAB + doubleApostrof.ToString() + ", ";
           string ColumnsCapitalAB = "_tmpObject." + mcoll3IA.ToUpper();
           string allAB = StartParameters + mparametAB + ColumnsCapitalAB + EndParameters;
           afileDB.Add(allAB);

           afileDB.Add("res = command.ExecuteNonQuery();");

           afileDB.Add("return res;");
           afileDB.Add("}");

           // 44 ,
           // 41 )


           //// End SECOND PART Add with parameters
           afileDB.Add(Delimit);
           afileDB.Add("//END DELETE WITH PARAMETERS");
           afileDB.Add(Delimit);

            ////// END SECOND PART WITH PARAMETERS

            //SqlCommand command = new SqlCommand("UPDATE user SET username=@username, password=@password WHERE loginid=@loginid", conn);

            //// END UPDATE WITH PARAMETERS

           afileDB.Add(mempty);

           afileDB.Add(Delimit);
           afileDB.Add("//GET BY ID ---------------------------------------------");
           afileDB.Add(Delimit);

           nameofclassTrans = "public " + classname + " GetById(int _id)";
           afileDB.Add(nameofclassTrans);
           afileDB.Add("{");

           string mclases = classname + " tmpObject = " + "new "+ classname +"();";

           afileDB.Add(mclases);
           afileDB.Add(usi[18]);
           afileDB.Add(usi[19]);
           afileDB.Add(usi[20]);

           afileDB.Add("SqlConnection conn = new SqlConnection(connectionString); ");
           //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["devdb"].ConnectionString);
           //SqlConnection conn = new SqlConnection(this.connectionString);
           //string slqString = "select * from Cases, Arbiters, CasesArbiters where Cases.id = CasesArbiters.idCase and Arbiters.id = CasesArbiters.idArbiter and Cases.id = 1";
           //string sqlString = "select * from " + //Cases, Arbiters, CasesArbiters where Cases.id = CasesArbiters.idCase and Arbiters.id = CasesArbiters.idArbiter and Cases.id = " + caseId.ToString();
           //string sqlString = "SELECT * FROM users WHERE " + _cond;

//          SqlCommand command = new SqlCommand("Select * From Menu WHERE IdMenu="_id.ToString(), conn);
//conn.Open()
//SqlDataReader dr = command.ExecuteReader()

           string tmpID = this.listBox2.Items[0].ToString();
           string sqlS = "SqlCommand command = new SqlCommand(" + doubleApostrof.ToString() + "Select * From " + NameOfTable + " WHERE " + tmpID + "=" +doubleApostrof + " + _id.ToString()" + ", conn);";
           afileDB.Add(sqlS);
           afileDB.Add("conn.Open();");

           afileDB.Add("SqlDataReader dr = command.ExecuteReader();"); 

           afileDB.Add("while (dr.Read())");
           afileDB.Add("{");

           //  tmpCases.ID = (int)dr["Id"];
           for (int rA = 0; rA < this.listBox2.Items.Count; rA = rA + 2)
           {

               string mcollA = this.listBox2.Items[rA].ToString();
               string mtypeeA = this.listBox2.Items[rA + 1].ToString();

               string mread = "tmpObject." + mcollA.ToUpper() + " = (" + mtypeeA + ")" + "dr[" + doubleApostrof + mcollA + doubleApostrof + "];";
               afileDB.Add(mread);

           }

           afileDB.Add("}");
           afileDB.Add("dr.Close();");
           afileDB.Add("conn.Close();");
           afileDB.Add("return tmpObject;");
           afileDB.Add("}");

           afileDB.Add(Delimit);
           afileDB.Add("//END OF GetByID ==============");
           afileDB.Add(Delimit);
            
            /// GET_Data
            /// GetAll
            /// 

           afileDB.Add(Delimit);
           afileDB.Add("//GET ALL ---------------------------------------------");
           afileDB.Add(Delimit);

           nameofclassTrans = "public List<" + classname + "> GetAll()";
           afileDB.Add(nameofclassTrans);
           afileDB.Add("{");

           mclases = "List<" + classname + "> tmpList = " + "new List<" + classname + ">();";
          

           afileDB.Add(mclases);
           afileDB.Add(usi[18]);
           afileDB.Add(usi[19]);
           afileDB.Add(usi[20]);

           //  alErrors.Clear();

           afileDB.Add("alErrors.Clear();");
           string tmMsgS = @"string msgRecField=" + doubleApostrof + "-" + doubleApostrof + ";";
           afileDB.Add(tmMsgS);

           afileDB.Add("SqlConnection conn = new SqlConnection(connectionString); ");
           //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["devdb"].ConnectionString);
           //SqlConnection conn = new SqlConnection(this.connectionString);
           //string slqString = "select * from Cases, Arbiters, CasesArbiters where Cases.id = CasesArbiters.idCase and Arbiters.id = CasesArbiters.idArbiter and Cases.id = 1";
           //string sqlString = "select * from " + //Cases, Arbiters, CasesArbiters where Cases.id = CasesArbiters.idCase and Arbiters.id = CasesArbiters.idArbiter and Cases.id = " + caseId.ToString();
           //string sqlString = "SELECT * FROM users WHERE " + _cond;

           //          SqlCommand command = new SqlCommand("Select * From Menu WHERE IdMenu="_id.ToString(), conn);
           //conn.Open()
           //SqlDataReader dr = command.ExecuteReader()

           tmpID = this.listBox2.Items[0].ToString();
           sqlS = "SqlCommand command = new SqlCommand(" + doubleApostrof.ToString() + "Select * From " + NameOfTable + doubleApostrof.ToString() + ", conn);";
           afileDB.Add(sqlS);
           afileDB.Add("conn.Open();");

           afileDB.Add("SqlDataReader dr = command.ExecuteReader();");

           afileDB.Add("while (dr.Read())");
           afileDB.Add("{");

           // try
           afileDB.Add("try");
           //{
           afileDB.Add("{");

           mclases = classname + " tmpObject = " + "new " + classname + "();";
           afileDB.Add(mclases);
           //  tmpCases.ID = (int)dr["Id"];

           string tmMsg = @"msgRecField=" + doubleApostrof + "-" + doubleApostrof + ";";
           afileDB.Add(tmMsg);

           for (int rA = 0; rA < this.listBox2.Items.Count; rA = rA + 2)
           {

               string mcollA = this.listBox2.Items[rA].ToString();
               string mtypeeA = this.listBox2.Items[rA + 1].ToString();

               string tmMsgT = @"msgRecField=msgRecField + " + doubleApostrof + mcollA + "=" + doubleApostrof + ";";
               //   message = message + "idRecUser="; 
               afileDB.Add(tmMsgT);
               string mread = "tmpObject." + mcollA.ToUpper() + " = (" + mtypeeA + ")" + "dr[" + doubleApostrof + mcollA + doubleApostrof + "];";
               string tmMsgTr = @"msgRecField=msgRecField + " + "dr[" + doubleApostrof + mcollA + doubleApostrof + "].ToString() +" + doubleApostrof + "=" + doubleApostrof + ";";
               //    message = message + dr["idRecUser"].ToString();
               afileDB.Add(tmMsgTr);
               afileDB.Add(mread);

           }

           afileDB.Add("tmpList.Add(tmpObject);");

           afileDB.Add("}"); // end try

           afileDB.Add(" catch (Exception ex)");

           afileDB.Add("{"); //

         
           afileDB.Add("alErrors.Add(LogException(ex));"); // alErrors.Add(LogException(ex));
           afileDB.Add("alErrors.Add(msgRecField);"); //

           afileDB.Add(tmMsg);

           afileDB.Add("}"); //}

          // afileDB.Add("}");
           afileDB.Add("}");
           afileDB.Add("dr.Close();");
           afileDB.Add("conn.Close();");
           afileDB.Add("return tmpList;");
           afileDB.Add("}");

           afileDB.Add(Delimit);
           afileDB.Add("//END OF GetALL ==============");
           afileDB.Add(Delimit);

           /// GET_Data

            ///


           afileDB.Add(Delimit);
           afileDB.Add("//GET ALL by cond ---------------------------------------------");
           afileDB.Add(Delimit);

           nameofclassTrans = "public List<" + classname + "> GetAllByCond(string cond)";
           afileDB.Add(nameofclassTrans);
           afileDB.Add("{");

           mclases = "List<" + classname + "> tmpList = " + "new List<" + classname + ">();";


           afileDB.Add(mclases);
           afileDB.Add(usi[18]);
           // here clear the Arrlist eror with cleart

           afileDB.Add(usi[19]);
           afileDB.Add(usi[20]);

            tmMsgS = @"string msgRecField=" + doubleApostrof + "-" + doubleApostrof + ";";
           afileDB.Add(tmMsgS);
           afileDB.Add("alErrors.Clear();");

           afileDB.Add("SqlConnection conn = new SqlConnection(connectionString); ");
           //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["devdb"].ConnectionString);
           //SqlConnection conn = new SqlConnection(this.connectionString);
           //string slqString = "select * from Cases, Arbiters, CasesArbiters where Cases.id = CasesArbiters.idCase and Arbiters.id = CasesArbiters.idArbiter and Cases.id = 1";
           //string sqlString = "select * from " + //Cases, Arbiters, CasesArbiters where Cases.id = CasesArbiters.idCase and Arbiters.id = CasesArbiters.idArbiter and Cases.id = " + caseId.ToString();
           //string sqlString = "SELECT * FROM users WHERE " + _cond;

           //          SqlCommand command = new SqlCommand("Select * From Menu WHERE IdMenu="_id.ToString(), conn);
           //conn.Open()
           //SqlDataReader dr = command.ExecuteReader()

           tmpID = this.listBox2.Items[0].ToString();
           sqlS = "SqlCommand command = new SqlCommand(" + doubleApostrof.ToString() + "Select * From " + NameOfTable + " Where " +  doubleApostrof.ToString() + "+cond" + ", conn);";
           afileDB.Add(sqlS);
           afileDB.Add("conn.Open();");

           afileDB.Add("SqlDataReader dr = command.ExecuteReader();");

           afileDB.Add("while (dr.Read())");
           afileDB.Add("{");

            // try
           afileDB.Add("try");
            //{
           afileDB.Add("{");

           mclases = classname + " tmpObject = " + "new " + classname + "();";
           afileDB.Add(mclases);
           //  tmpCases.ID = (int)dr["Id"];

            tmMsg = @"msgRecField=" + doubleApostrof + "-" + doubleApostrof + ";";
           afileDB.Add(tmMsg);


           for (int rA = 0; rA < this.listBox2.Items.Count; rA = rA + 2)
           {

               string mcollA = this.listBox2.Items[rA].ToString();
               string mtypeeA = this.listBox2.Items[rA + 1].ToString();

               string tmMsgT = @"msgRecField=msgRecField + " + doubleApostrof + mcollA + "=" + doubleApostrof + ";";
               //   message = message + "idRecUser="; 
               afileDB.Add(tmMsgT);

               string mread = "tmpObject." + mcollA.ToUpper() + " = (" + mtypeeA + ")" + "dr[" + doubleApostrof + mcollA + doubleApostrof + "];";
               string tmMsgTr = @"msgRecField=msgRecField + " + "dr[" + doubleApostrof + mcollA + doubleApostrof + "].ToString() +" + doubleApostrof + "=" + doubleApostrof + ";";
               //    message = message + dr["idRecUser"].ToString();
               afileDB.Add(tmMsgTr);

               afileDB.Add(mread);

           }

            afileDB.Add("tmpList.Add(tmpObject);");

            afileDB.Add("}"); // end try

            afileDB.Add(" catch (Exception ex)");

            afileDB.Add("{"); //

            afileDB.Add("alErrors.Add(LogException(ex));"); // alErrors.Add(LogException(ex));
            afileDB.Add("alErrors.Add(msgRecField);"); //

            afileDB.Add(tmMsg);

            afileDB.Add("}"); //}
          
            
            afileDB.Add("}");
           afileDB.Add("dr.Close();");
           afileDB.Add("conn.Close();");
           afileDB.Add("return tmpList;");
           afileDB.Add("}");

           afileDB.Add(Delimit);
           afileDB.Add("//END OF GetALL ==============");
           afileDB.Add(Delimit);

           /// GET_Data

           ///

           afileDB.Add(Delimit);

           afileDB.Add(mempty);


           // here part of checking for the good input
           string chekingString = "public string CheckStringFromField(string StringToCheck, int typeOfReturn)";
           afileDB.Add(chekingString);
           afileDB.Add("{");

            afileDB.Add("string res = StringToCheck;");

            afileDB.Add("if (typeOfReturn == 1 || String.IsNullOrEmpty(StringToCheck)==true)");
            afileDB.Add("{"); 
            
            //char doubleapostrof = '"';

            string res1 = "res =" + doubleApostrof.ToString() + "No Data"+ doubleApostrof.ToString()+";";

            afileDB.Add(res1);   
            afileDB.Add("return res;");   
            afileDB.Add("}");

            afileDB.Add("if (typeOfReturn == 2 || String.IsNullOrEmpty(StringToCheck)==true)");
            afileDB.Add("{");

            //char doubleapostrof = '"';

             res1 = "res =" + doubleApostrof.ToString() + "0" + doubleApostrof.ToString() + ";";

            afileDB.Add(res1);
            afileDB.Add("return res;");
            afileDB.Add("}");

            afileDB.Add("if (typeOfReturn == 3 || String.IsNullOrEmpty(StringToCheck)==true)");
            afileDB.Add("{");

            //char doubleapostrof = '"';

            res1 = "res =" + doubleApostrof.ToString() + "01/01/1800" + doubleApostrof.ToString() + ";";

            afileDB.Add(res1);
            afileDB.Add("return res;");
            afileDB.Add("}");


            afileDB.Add("return res;");

            afileDB.Add("// using  like CheckStringFromTxtFile(fields[0],1);"); 
           afileDB.Add("}");
           
            //

           ClassData.TxtFile txEx = new ClassData.TxtFile();
           string fnameAddExc = Application.StartupPath + @"\ExAdding.txt";
           txEx.FileName = fnameAddExc;
           ArrayList alEx = new ArrayList();
           alEx = txEx.FileToArrayList();
           for (int i = 0; i < alEx.Count; i++)
           {
               string tm = alEx[i].ToString();
               afileDB.Add(tm);

           }

            //

           for (int y = 0; y < endfile.Length; y++)
           {
               afileDB.Add(endfile[y]);
           }

           afileDB.Add(mempty);

            // part of exceptions 

           // ExAdding.txt

           


           ClassData.TxtFile tx1 = new ClassData.TxtFile();
           string fnameclass1 = Application.StartupPath + @"\DB_" + classname + ".cs";
           tx1.FileName = fnameclass1;
        
            tx1.ArrayListToFile(afileDB);

            /// 

           

            // PART addDB parametyrs
            //////////////////////////////////////


            /////////////////////////////////////



            ////////////////////////SAVE DM_arbiters

           afile.Add(Delimit);
           afile.Add("//START SAVE METHOD OF dm_arbiter ==============");
           afile.Add(Delimit);

           afile.Add( "public bool Save(" + classname + " _"+classname + ")");
           afile.Add("{");


          afile.Add("bool tmp = false;");
          afile.Add("int res = -1;");

         afile.Add("_"+classname+".DELETED = 1;");
         afile.Add("// ADD apostrof ConnectionStrings[devdb]");

         string sss = @" SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[devdb].ConnectionString);";
         afile.Add(sss);
         afile.Add("conn.Open();");
         afile.Add("SqlTransaction tran = conn.BeginTransaction(IsolationLevel.ReadUncommitted);");

       afile.Add("try");

       afile.Add("{");

       sss = "DB_" + classname + " db_"+classname + " = new DB_"+classname +"();";
       afile.Add(sss);
       
            sss = "if (_"+classname+"."+"ID"+classname.ToUpper()+ " == 0)";

        afile.Add(sss);
           
        afile.Add("{");

         afile.Add("res = db_"+classname+".Add(_"+classname +", conn, tran);");
                // Update trans table
         afile.Add("tran.Commit();");
         afile.Add("tmp = true;");
         afile.Add("}");
         afile.Add("else");
             afile.Add("{");

           afile.Add("res = db_"+classname+".Update(_"+classname +", conn, tran);");
          
         afile.Add("tran.Commit();");
                // Update trans table
          afile.Add("tmp = true;");
         afile.Add("}");


        afile.Add("}");
        afile.Add("catch");
         afile.Add("{");
            afile.Add("tran.Rollback();");
            afile.Add("tmp = false;");
        afile.Add("}");
        afile.Add("finally");
         afile.Add("{");
            afile.Add("conn.Close();");
       afile.Add("}");


        afile.Add("return tmp;");
   afile.Add("}");


          // afile.Add("}");
           afile.Add(Delimit);
           afile.Add("//END OF SAVE DM_ ==============");
           afile.Add(Delimit);
            /////////////////////////////////


 
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

			ClassData.TxtFile txClass = new ClassData.TxtFile();
            string __fname = Application.StartupPath + @"\Files\" + classname + ".cs";
            txClass.FileName = __fname;
            txClass.ArrayListToFile(afile);

			this.textBox5.Text = "";
			this.textBox5.Visible = false;

            this.textBox5.Lines = tx.FileToArray();  

			tx= null;

            MessageBox.Show("Classes - Created");


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
            Application.Exit();
			//this.Close();
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

        private void button11_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            label11.Text = dt.ToString("dd/MM/yyyy"); 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string[] indexs = textBox9.Text.Split(',');

            string clasname = this.label12.Text;

            ArrayList afile = new ArrayList();


            ClassData.TxtFile tx = new ClassData.TxtFile();
            string fnameclass = Application.StartupPath + @"\" + classname + "FromTxtFile.cs";
            tx.FileName = fnameclass;

            string tmp  = @"using System;";
            afile.Add(tmp);
            tmp = @"using System.Collections;";
            afile.Add(tmp);
            tmp = @"using System.Collections.Generic;";
            afile.Add(tmp);

            tmp = @"using System.ComponentModel;";
            afile.Add(tmp);
           tmp = @"using System.Data;";
           afile.Add(tmp);
           tmp = @"using System.Drawing;";
           afile.Add(tmp);
           tmp = @"using System.Data.SqlClient;";
          afile.Add(tmp);
           tmp = @"using System.IO;";
          afile.Add(tmp);
          tmp = @"using System.Text;";
          afile.Add(tmp);

           tmp = @"using System.Data.Sql;";
           afile.Add(tmp);
           tmp = @"using System.Data.SqlTypes;";
           afile.Add(tmp);
           tmp= " ";
           afile.Add(tmp);
           tmp = " ";
           afile.Add(tmp);
           tmp = @"public class " + classname + "FromTxtFile";
           afile.Add(tmp);
           tmp = " ";
           afile.Add(tmp);
           tmp = "{";
           afile.Add(tmp);
            
           tmp = @"public " + classname + "FromTxtFile()";
             afile.Add(tmp);
           tmp = "{";
             afile.Add(tmp);
            // WEB
            //usi[18] = "System.Configuration.ConnectionStringSettings connString; ";
            //usi[19] = @"connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + (char)34 + "devdb"+(char)34+"];"; 
            //usi[20] = "connectionString = connString.ConnectionString;";

            //Windows
            tmp = "}";
             afile.Add(tmp);


             tmp = @"public List<" + classname + "> GetListFromTxt(string filename)";
             afile.Add(tmp);
             tmp = "{";
             afile.Add(tmp);
             // WEB
             //usi[18] = "System.Configuration.ConnectionStringSettings connString; ";
             //usi[19] = @"connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings[" + (char)34 + "devdb"+(char)34+"];"; 
             //usi[20] = "connectionString = connString.ConnectionString;";

            
             tmp = @"List<"+ classname+ "> alist = new List<" + classname +" >();";
             afile.Add(tmp);

            
            tmp = @"string[] aObjects = File.ReadAllLines(filename);";
             afile.Add(tmp);

            tmp = @" for (int i = 0; i < aObjects.Length; i++)";
             afile.Add(tmp);
             tmp = "{";
             afile.Add(tmp);

             tmp = @"string[] tmp = aObjects[i].Split(',');";
             afile.Add(tmp);
            /// here the body
            /// 
             tmp = clasname + " tmpObject = new " + clasname + "();";
             afile.Add(tmp);

             for (int x = 1; x < listBox1.Items.Count; x++)
             {

                 //string mcoll = this.listBox2.Items[r].ToString();
                 //string mtypee = this.listBox2.Items[r + 1].ToString();

                 string parsingStart = "";
                 string parsingEnd = "";

                 if (this.listBox3.Items[x].ToString().CompareTo("System.Int32") == 0)
                 {
                     parsingStart = @"int.Parse(";
                     parsingEnd = @")";
                 }

                 if (this.listBox3.Items[x].ToString().CompareTo("System.DateTime") == 0)
                 {
                     parsingStart = @"int.DateTime(";
                     parsingEnd = @")";
                 }
                 


                 tmp = @"tmpObject." + this.listBox1.Items[x].ToString().ToUpper() + "=" + parsingStart + "tmp[" + indexs[x - 1] + "]" + parsingEnd+";";
                 afile.Add(tmp);

                 
             }
                 tmp = @"alist.Add(tmpObject);";
                 afile.Add(tmp);
               tmp = @"}";
               afile.Add(tmp);  // end of for loop

             tmp = @"return alist;";
             afile.Add(tmp);

             //Windows
             tmp = "}";
             afile.Add(tmp);



            // end of file 

            tmp = "}";
             afile.Add(tmp);

          
            
            
            tx.ArrayListToFile(afile);
            MessageBox.Show("Done!");
           


        }

        private void button17_Click(object sender, EventArgs e)
        {
            string formname = label12.Text;

            //string first = formname.Substring(0,1);
            //int len = label12.Text.Length;
            //string rest = formname.Substring(1,len-1);

            //string newfirst = first.ToUpper();
            //formname = newfirst + rest;

            formname = "Form" + formname;

            label14.Text = formname;

            // generate form.cs

            ArrayList alFormCsFile = new ArrayList();

            ClassData.TxtFile txtObject = new ClassData.TxtFile();
            txtObject.FileName = Application.StartupPath + @"\" + formname + ".cs";

             alFormCsFile.Add("  using System; ");
             alFormCsFile.Add("  using System.Drawing; ");
             alFormCsFile.Add("  using System.Collections;");
             alFormCsFile.Add("  using System.ComponentModel; ");
             alFormCsFile.Add("  using System.Windows.Forms; ");
             alFormCsFile.Add("  using System.Data; ");
             alFormCsFile.Add(" using System.Data.SqlClient; ");

             alFormCsFile.Add("  ");

             alFormCsFile.Add("   ");
    
            alFormCsFile.Add("  namespace REPLACE_WITH_NAMESPACE_OF_APPLICATION ");
             alFormCsFile.Add("  { ");
            string tmp = @"  public partial class  "+ formname + " : Form";
            alFormCsFile.Add(tmp);
            alFormCsFile.Add("  { ");
   
             tmp = @"  public  "+ formname + @"()";
            alFormCsFile.Add(tmp);
             alFormCsFile.Add("  { ");
      
             alFormCsFile.Add("   InitializeComponent(); ");
             alFormCsFile.Add("    } ");

             tmp = @"  private void  " + formname + @"_Load(object sender, EventArgs e)";
             alFormCsFile.Add(tmp);
             alFormCsFile.Add("  { ");
             alFormCsFile.Add("    } ");

             alFormCsFile.Add("    } ");
             alFormCsFile.Add("    } ");

             txtObject.ArrayListToFile(alFormCsFile);
             MessageBox.Show(label14.Text +".cs Generated");
            //private void Form2_Load(object sender, EventArgs e)
                        //{

                       // }
                    //}
                //}

            //////////////
            //ovo treba da se generise u file Form2.Designer.cs
            ArrayList alFormDesignerFile = new ArrayList();
            txtObject.FileName = Application.StartupPath + @"\" + formname + ".Designer.cs";

            alFormDesignerFile.Add(" namespace REPLACE_NAMESPACE_IN_APPLICATION ");

            alFormDesignerFile.Add("  {  ");

             tmp = @"  partial class  "+ formname;

             alFormDesignerFile.Add(tmp);

             alFormDesignerFile.Add("  {  ");

            alFormDesignerFile.Add("  private System.ComponentModel.IContainer components = null; ");
       
            alFormDesignerFile.Add("   protected override void Dispose(bool disposing) ");
         
              alFormDesignerFile.Add("  {  ");

             alFormDesignerFile.Add(" if (disposing && (components != null))  ");
            
              alFormDesignerFile.Add("  {  ");
                alFormDesignerFile.Add("  components.Dispose();  ");
               alFormDesignerFile.Add("  } ");  
            
                alFormDesignerFile.Add("   base.Dispose(disposing); ");  
             
          alFormDesignerFile.Add("  } ");  
            
                alFormDesignerFile.Add("   #region Windows Form Designer generated code");  
       

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
           alFormDesignerFile.Add("  private void InitializeComponent() ");  
        
            alFormDesignerFile.Add("  {  ");
            alFormDesignerFile.Add("   this.btnCancel = new System.Windows.Forms.Button();  ");
             alFormDesignerFile.Add("   this.btnSave = new System.Windows.Forms.Button();  ");
           

             for (int rr=0;rr<this.listBox2.Items.Count;rr=rr+2)
			{
				
			   string mcolll = this.listBox2.Items[rr].ToString();

                string tmpLabel = "this.lbl_"+mcolll+" = new System.Windows.Forms.Label();";
				 alFormDesignerFile.Add(tmpLabel );	
		
                   string tmpTextBox = "this.txt_"+mcolll+"  = new System.Windows.Forms.TextBox();";
				 alFormDesignerFile.Add(tmpTextBox);		
			}
           
            

                  alFormDesignerFile.Add("    this.SuspendLayout();  ");
           
            // 
            // btnCancel
          //   alFormDesignerFile.Add("    this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));   ");
            alFormDesignerFile.Add("   this.btnCancel.Location = new System.Drawing.Point(220, 382);    ");
            char navodnici = '"';
            string name = "this.btnCancel.Name = "  + navodnici.ToString()+ "btnCancel"+navodnici.ToString()+";";
            alFormDesignerFile.Add(name);
            alFormDesignerFile.Add("  this.btnCancel.Size = new System.Drawing.Size(121, 63);    ");
            alFormDesignerFile.Add("   this.btnCancel.TabIndex = 0;    ");
            string textbutton = "this.btnCancel.Text = "  + navodnici.ToString()+ "Cancel"+navodnici.ToString()+";";
            alFormDesignerFile.Add( textbutton);
            alFormDesignerFile.Add("   this.btnCancel.UseVisualStyleBackColor = true;     ");
                      
          
            // 
            // btnSave
            
               alFormDesignerFile.Add("        this.btnSave.Location = new System.Drawing.Point(429, 382);    ");
            name = "this.btnSave.Name = "  + navodnici.ToString()+ "btnSave"+navodnici.ToString()+";";
            alFormDesignerFile.Add(name);
            alFormDesignerFile.Add("   this.btnSave.Size = new System.Drawing.Size(121, 63);    ");
            alFormDesignerFile.Add("    this.btnSave.TabIndex = 1;  ");
            textbutton = " this.btnSave.Text = "  + navodnici.ToString()+ "Save"+navodnici.ToString()+";";
            alFormDesignerFile.Add( textbutton);
            alFormDesignerFile.Add("     this.btnSave.UseVisualStyleBackColor = true;    ");
         

            //this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      
                    
            int start = 25;
            int secondCoordinate = 0;

            for (int rr=0;rr<this.listBox2.Items.Count;rr=rr+2)
			{
				
                secondCoordinate = secondCoordinate + 25;
                string str_secondCoordinate = secondCoordinate.ToString();

			   string mcolll = this.listBox2.Items[rr].ToString();

                string tmpLabelSize = "this.lbl_"+mcolll+".AutoSize = true;";
				 alFormDesignerFile.Add(tmpLabelSize );	
                  string tmpLabelLocation = "this.lbl_"+mcolll+".Location = new System.Drawing.Point(126,"+str_secondCoordinate+");";
				 alFormDesignerFile.Add(tmpLabelLocation );	
		        string tmpLabelName = "this.lbl_"+mcolll+".Name = "+ navodnici+ "lbl_"+mcolll + navodnici+ ";";
				 alFormDesignerFile.Add(tmpLabelName);	

                string tmpLabelText = "this.lbl_"+mcolll+".Text = "+  navodnici+ mcolll + navodnici+ ";";
                alFormDesignerFile.Add(tmpLabelText);	


                   string tmpTextBoxLocation = "this.txt_"+mcolll+".Location = new System.Drawing.Point(241," + str_secondCoordinate+");";
				 alFormDesignerFile.Add( tmpTextBoxLocation);	
	
                   string tmpTextBoxName = "this.txt_"+mcolll+".Name = "+ navodnici+ "txt_"+mcolll + navodnici+ ";";
				 alFormDesignerFile.Add(  tmpTextBoxName);
			}

            // 
            // label1
            // 
            //this.label1.AutoSize = true;
           // this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           // this.label1.Location = new System.Drawing.Point(126, 25);
           // this.label1.Name = "label1";
         //   this.label1.Size = new System.Drawing.Size(51, 20);  M|OZDA MORA
         //   //this.label1.TabIndex = 2;
          //  this.label1.Text = "label1";
           
            
            // 
            // textBox1
            // 
           // this.textBox1.Location = new System.Drawing.Point(241, 25);  // da bude sledeci 241,50 
           // this.textBox1.Name = "textBox1";
           // this.textBox1.Size = new System.Drawing.Size(100, 20);  M|OZDA MORA
            //this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            //this.textBox2.Location = new System.Drawing.Point(584, 25);   // povecati za 25 da bude 584, 50
            //this.textBox2.Name = "textBox2";
            //this.textBox2.Size = new System.Drawing.Size(100, 20);
            //this.textBox2.TabIndex = 5;
            // 
           
            // 
            // Form2
            // 

                 alFormDesignerFile.Add("        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);   ");
                  alFormDesignerFile.Add("          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;   ");
                  alFormDesignerFile.Add("               this.ClientSize = new System.Drawing.Size(794, 457);  ");


                  for (int rr = 0; rr < this.listBox2.Items.Count; rr = rr + 2)
                  {

                      string mcolll = this.listBox2.Items[rr].ToString();

                      string tmpLabel = "  this.Controls.Add(this.lbl_" + mcolll + " );";
                      alFormDesignerFile.Add(tmpLabel);

                      string tmpTextBox = "  this.Controls.Add(this.txt_" + mcolll + " );";
                      alFormDesignerFile.Add(tmpTextBox);
                  }

            //this.Controls.Add(this.textBox3);
            //this.Controls.Add(this.label3);
            //this.Controls.Add(this.textBox4);
            //this.Controls.Add(this.label4);
            //this.Controls.Add(this.textBox2);
            //this.Controls.Add(this.label2);
            //this.Controls.Add(this.textBox1);
            //this.Controls.Add(this.label1);

            alFormDesignerFile.Add("       this.Controls.Add(this.btnSave);   ");
            alFormDesignerFile.Add("        this.Controls.Add(this.btnCancel);   ");


            string nameofform = " this.Name =" + navodnici + formname + navodnici + ";";
            //this.Name = "Form2";
            alFormDesignerFile.Add(nameofform);
            alFormDesignerFile.Add("   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; ");

            string textofform = " this.Text =" + navodnici + formname + navodnici + ";";
            //this.Name = "Form2";
            alFormDesignerFile.Add(textofform);
           // this.Text = "Form2";

            // event form
            string eventform = "  this.Load += new System.EventHandler(this." + formname + "_Load);";
           // this.Load += new System.EventHandler(this.Form2_Load);
            alFormDesignerFile.Add(eventform);

               alFormDesignerFile.Add("       this.ResumeLayout(false); ");
               alFormDesignerFile.Add("         this.PerformLayout(); ");
       
              alFormDesignerFile.Add("      } ");
       
                       alFormDesignerFile.Add("        #endregion ");
     
                alFormDesignerFile.Add("       private System.Windows.Forms.Button btnCancel; ");
                 alFormDesignerFile.Add("     private System.Windows.Forms.Button btnSave; ");

                 for (int rr = 0; rr < this.listBox2.Items.Count; rr = rr + 2)
                 {

                     string mcolll = this.listBox2.Items[rr].ToString();

                     string tmpLabel = "  private System.Windows.Forms.Label " + "lbl_" + mcolll + ";";
                     alFormDesignerFile.Add(tmpLabel);

                     string tmpTextBox = "  private System.Windows.Forms.TextBox " + "txt_" + mcolll + ";";
                     alFormDesignerFile.Add(tmpTextBox);
                 }
      

        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox textBox1;
        
            alFormDesignerFile.Add("   } ");
     alFormDesignerFile.Add("   } ");


     txtObject.ArrayListToFile(alFormDesignerFile);
     MessageBox.Show("Designer Form completed");
            ////////////// END second designer file 



        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
            ds.Clear();

            ptl.DbaseSQLServer sq = new ptl.DbaseSQLServer();

            scon = "server=" + this.textBox1.Text + "; " + "uid=" + textBox2.Text + "; " + "pwd=" + textBox3.Text + "; " + "database=" + textBox4.Text;
            //MessageBox.Show(scon);

            //scon = "server=DVUKELIC; uid=sa; pwd=sa; database=Bugs";

            sq.DbaseConnection = scon;
            sq.SqlText = "Select Name From  sys.views  ";
            //sq.SqlText = "Select Name From sysobjects where Category=513 or Category=1";

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
            catch
            {
                MessageBox.Show("SQL server is not active - use services to start");
            }
        }

        private void CreateTdTr(string nameofcolumn)
        {
             
        }

        private void button19_Click(object sender, EventArgs e)
        {

            string formname = label12.Text;

            //string first = formname.Substring(0,1);
            //int len = label12.Text.Length;
            //string rest = formname.Substring(1,len-1);

            //string newfirst = first.ToUpper();
            //formname = newfirst + rest;

            formname = "FormHTMLSingle" + formname;

            label14.Text = formname;

            // generate form.cs

            ArrayList alFormCsFile = new ArrayList();

            ClassData.TxtFile txtObject = new ClassData.TxtFile();
            //txtObject.FileName = Application.StartupPath + @"\" + formname + ".html";
            txtObject.FileName = Application.StartupPath + @"\" + formname + ".txt";

            char doubleapostrof = '"';
            string strApostrof = doubleapostrof.ToString();

            string tstart = @"<table style=" + strApostrof +  "width: 100%;" + strApostrof+ ">";

            alFormCsFile.Add(tstart);

            for (int i=0; i<this.listBox1.Items.Count;i++)
            {
                	string mcoll = this.listBox1.Items[i].ToString();
                  alFormCsFile.Add("<tr>"); 
 
                 alFormCsFile.Add("<td>");
                 string tlabel = @"<asp:Label ID=" + strApostrof + "lbl" + mcoll + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + mcoll + strApostrof + "></asp:Label>";  
                 alFormCsFile.Add(tlabel);  
                alFormCsFile.Add("</td>");

                 alFormCsFile.Add("<td>");
                  string ttext = @"<asp:TextBox ID=" + strApostrof + "txt" + mcoll + strApostrof + " runat=" + strApostrof + "server" + strApostrof + "></asp:TextBox>";
                  alFormCsFile.Add(ttext);

                  if (mcoll.IndexOf("id_") > -1)
                  {
                      // ima za drop box
                      string[] tm = mcoll.Split('_');
                      string secondpart = tm[1];
                      string ttextD = @"<asp:DropDownList ID=" + strApostrof + "DropDownList" + secondpart + strApostrof + " runat=" + strApostrof + "server" + strApostrof + "></asp:DropDownList>";
                      alFormCsFile.Add(ttextD);

                  }

                 alFormCsFile.Add("</td>");

                

                //  <asp:DropDownList ID="DropDownListOwnerFrom" Width="180px" runat="server">
                //</asp:DropDownList>
                 
            alFormCsFile.Add("</tr>"); 

            }

            alFormCsFile.Add("<tr>"); 
            alFormCsFile.Add("<td>");
            string tlabel1 = @"<asp:Label ID=" + strApostrof + "lbl" + "btn" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + " " + strApostrof + "></asp:Label>";
            alFormCsFile.Add(tlabel1);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("<td>");
            string tbutton = @"<asp:Button ID=" + strApostrof + "btn" + "Save" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "Save" + strApostrof +  " onclick=" + strApostrof +"btnSave_Click"+ strApostrof+ "/>";
            alFormCsFile.Add(tbutton);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("</tr>"); 

            string tend = @" </table>";


            alFormCsFile.Add(tend);

              
           
            //

            

            txtObject.ArrayListToFile(alFormCsFile);
            MessageBox.Show(label14.Text + ".html Generated");
        }



        private void button20_Click(object sender, EventArgs e)
        {
            string formname = label12.Text;

            //string first = formname.Substring(0,1);
            //int len = label12.Text.Length;
            //string rest = formname.Substring(1,len-1);

            //string newfirst = first.ToUpper();
            //formname = newfirst + rest;

            formname = "FormHTMLGridView" + formname;

            label14.Text = formname;

            // generate form.cs

            ArrayList alFormCsFile = new ArrayList();

            ClassData.TxtFile txtObject = new ClassData.TxtFile();
            txtObject.FileName = Application.StartupPath + @"\" + formname + ".html";

            char doubleapostrof = '"';
            string strApostrof = doubleapostrof.ToString();

            string tstart = @"<table style=" + strApostrof + "width: 100%;" + strApostrof + ">";

            alFormCsFile.Add(tstart);

           // for (int i = 0; i < this.listBox1.Items.Count; i++)
          //  {
               // string mcoll = this.listBox1.Items[i].ToString();
                alFormCsFile.Add("<tr>");

                alFormCsFile.Add("<td>");
                string tlabel = @"<asp:Label ID=" + strApostrof + "lbl" + "Search" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "Search" + strApostrof + "></asp:Label>";
                alFormCsFile.Add(tlabel);
                alFormCsFile.Add("</td>");

                alFormCsFile.Add("<td>");
               // string ttext = @"<asp:TextBox ID=" + strApostrof + "txt" + mcoll + strApostrof + " runat=" + strApostrof + "server" + strApostrof + "></asp:TextBox>";
               // alFormCsFile.Add(ttext);
                alFormCsFile.Add("</td>");


                alFormCsFile.Add("</tr>");

                // Grid

                alFormCsFile.Add("<tr>");

                alFormCsFile.Add("<td>");
                tlabel = @"<asp:Label ID=" + strApostrof + "lbl" + "View" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "View" + strApostrof + "></asp:Label>";
                alFormCsFile.Add(tlabel);
                alFormCsFile.Add("</td>");

                alFormCsFile.Add("<td>");
             
                string ttext = @" <asp:GridView ID=" + strApostrof + "GridView1" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + "></asp:GridView>";
                 alFormCsFile.Add(ttext);
                alFormCsFile.Add("</td>");


                alFormCsFile.Add("</tr>");
                 // end grid

          //  }

            alFormCsFile.Add("<tr>");
            alFormCsFile.Add("<td>");
            string tlabel1 = @"<asp:Label ID=" + strApostrof + "lbl" + "btn" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + " " + strApostrof + "></asp:Label>";
            alFormCsFile.Add(tlabel1);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("<td>");
            string tbutton = @"<asp:Button ID=" + strApostrof + "btn" + "Search" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "Search" + strApostrof + "/>";
            alFormCsFile.Add(tbutton);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("</tr>");

            string tend = @" </table>";

            alFormCsFile.Add(tend);

            // 

            //



            txtObject.ArrayListToFile(alFormCsFile);
            MessageBox.Show(label14.Text + "GridView.html Generated");
        }

        private void codeWeb_setGrid_list(string _classname)
        {

            // here take this and replace DVUKDVUKXXXX with table name

        }

        private void codeWeb_LoadPage()
        {

            //if (!IsPostBack)
            //{
            //    set_login();
            //} 
           

        }

        private void codeWeb_setLogin()
        {
                // Global.asax
               //void Session_Start(object sender, EventArgs e)
               //{
               //       Session["Loggedin"] = "0";
               // }
            
                    //private void set_login()
                    //{
                    //    int logid = 0;

                    //    if (Session["Loggedin"] != null)
                    //    {
                    //        logid = int.Parse(Session["Loggedin"].ToString());

                    //    }
                    //    else
                    //    {
                    //        Response.Redirect("MainLogin.aspx");
                    //    }

                    //    if (logid > 0)
                    //    {
                    //        Label2.Text = logid.ToString();
                    //    }
                    //    else
                    //    {
                    //        Response.Redirect("MainLogin.aspx");
                    //    }
                    //}


        }


        private void button21_Click(object sender, EventArgs e)
        {

            string formname = label12.Text;

            //string first = formname.Substring(0,1);
            //int len = label12.Text.Length;
            //string rest = formname.Substring(1,len-1);

            //string newfirst = first.ToUpper();
            //formname = newfirst + rest;

            formname = "FormHTMLGridViewB" + formname;

            label14.Text = formname;

            // generate form.cs

            ArrayList alFormCsFile = new ArrayList();

            ClassData.TxtFile txtObject = new ClassData.TxtFile();
           // txtObject.FileName = Application.StartupPath + @"\" + formname + ".html";

            txtObject.FileName = Application.StartupPath + @"\" + formname + ".txt";

            char doubleapostrof = '"';
            string strApostrof = doubleapostrof.ToString();

            string tstart = @"<table style=" + strApostrof + "width: 100%;" + strApostrof + ">";

            alFormCsFile.Add(tstart);

            // for (int i = 0; i < this.listBox1.Items.Count; i++)
            //  {
            // string mcoll = this.listBox1.Items[i].ToString();
            alFormCsFile.Add("<tr>");

            alFormCsFile.Add("<td>");
            string tlabel = @"<asp:Label ID=" + strApostrof + "lbl" + "Search" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "Search" + strApostrof + "></asp:Label>";
            alFormCsFile.Add(tlabel);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("<td>");
            // string ttext = @"<asp:TextBox ID=" + strApostrof + "txt" + mcoll + strApostrof + " runat=" + strApostrof + "server" + strApostrof + "></asp:TextBox>";
            // alFormCsFile.Add(ttext);
            alFormCsFile.Add("</td>");


            alFormCsFile.Add("</tr>");

            // Grid

            alFormCsFile.Add("<tr>");

            alFormCsFile.Add("<td>");
            tlabel = @"<asp:Label ID=" + strApostrof + "lbl" + "View" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "View" + strApostrof + "></asp:Label>";
            alFormCsFile.Add(tlabel);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("<td>");

            string ttext = @" <asp:GridView ID=" + strApostrof + "GridView1" + strApostrof + " runat=" + strApostrof + "server" + strApostrof;
            alFormCsFile.Add(ttext);
            //ttext = @" <asp:GridView ID=" + strApostrof + "GridView1" + strApostrof + " runat=" + strApostrof + "server" + strApostrof;

            ttext = @"AutoGenerateColumns=""False"" DataKeyNames="+ doubleapostrof +  this.listBox1.Items[0].ToString() + doubleapostrof;
            alFormCsFile.Add(ttext);

            ttext = @"DELETE  onrowediting=""GridView1_RowEditing""  and do on control click na events and that click Row_editing";

            alFormCsFile.Add(ttext);

            ttext = @">";

            alFormCsFile.Add(ttext);


            ttext = @"   <Columns>";
            alFormCsFile.Add(ttext);

            ttext = @"<asp:CommandField HeaderText=""Edit"" ShowHeader=""True"" ShowEditButton=""True""/>";
            alFormCsFile.Add(ttext);

            // here parts of columns 
            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                //
                string mcoll = this.listBox1.Items[i].ToString();
                ttext = @"<asp:BoundField DataField=" + doubleapostrof + mcoll + doubleapostrof + " " + "HeaderText=" + doubleapostrof + mcoll + doubleapostrof + " />";
                //  <asp:BoundField DataField="Surname" HeaderText="Surname" />

                alFormCsFile.Add(ttext);
                //
            }
            // end 


            ttext = @"    </Columns>";
            alFormCsFile.Add(ttext);
            

            ttext = @"</asp:GridView>";
            alFormCsFile.Add(ttext);



            alFormCsFile.Add("</td>");


            alFormCsFile.Add("</tr>");
            // end grid

            //  }

            alFormCsFile.Add("<tr>");
            alFormCsFile.Add("<td>");
            string tlabel1 = @"<asp:Label ID=" + strApostrof + "lbl" + "btn" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + " " + strApostrof + "></asp:Label>";
            alFormCsFile.Add(tlabel1);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("<td>");
            string tbutton = @"<asp:Button ID=" + strApostrof + "btn" + "Search" + strApostrof + " runat=" + strApostrof + "server" + strApostrof + " Text=" + strApostrof + "Search" + strApostrof + "/>";
            alFormCsFile.Add(tbutton);
            alFormCsFile.Add("</td>");

            alFormCsFile.Add("</tr>");

            string tend = @" </table>";

            alFormCsFile.Add(tend);


           


            txtObject.ArrayListToFile(alFormCsFile);
            MessageBox.Show(label14.Text + "GridView.html Generated");
            
    //        <asp:GridView ID="GridView1" runat="server" 
    //        AutoGenerateColumns="False" DataKeyNames="idRecHunter" Width="414px" 
    //   DELETE  onrowediting="GridView1_RowEditing" onrowdeleting="GridView1_RowDeleting"> and do on control click na events and that event _editing
    //    <Columns>
    //        <asp:CommandField HeaderText="Edit" ShowHeader="True" ShowEditButton="True"/>
          
    //        <asp:BoundField DataField="Surname" HeaderText="Surname" />
    //        <asp:BoundField DataField="Name" HeaderText="Name"/>
    //         <asp:BoundField DataField="IdCardNumber" HeaderText="IdCard"/>
    //          <asp:BoundField DataField="LicencedMobileNumber" HeaderText="Mobile"/>
          
    //    <asp:CommandField HeaderText="View" ShowHeader="True" ShowDeleteButton="True" 
    //            DeleteText="View"/>
             
    //    </Columns>
    //</asp:GridView>


    // protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    int n = e.NewEditIndex;
    //    e.Cancel = true;
        
    //    this.ListBox1.SelectedIndex = n;

    //    string idRec = this.ListBox1.SelectedItem.Value;
     
    
    //    //string idRec = this.GridView1.Rows[n].Cells[1].Text;
                
    //    Session["idRec"] = idRec;
    //    Session["Loggedin"] = Label2.Text;

        
    //   Response.Redirect("UpdatePersonDetails.aspx");  //change to real update page
    //}


        }

        private void code_Web_GridEditing()
        {

        }


        private void menuItem3_Click(object sender, EventArgs e)
        {
           
            string con = "server=" + this.textBox1.Text + "; " + "uid=" + textBox2.Text + "; " + "pwd=" + textBox3.Text + "; " + "database=" + textBox4.Text;
            TestForm tform = new TestForm(con);
            tform.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string mcoll = this.listBox1.Items[i].ToString();
                al.Add(mcoll);

            }

            FormCode frmCode = new FormCode(NameOfTable, listBox1.Items[0].ToString(), listBox1.Items[0].ToString(),al);
            frmCode.ShowDialog();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {

            this.openFileDialog1.ShowDialog();
            string fname = this.openFileDialog1.FileName;

            string[] cfg = System.IO.File.ReadAllLines(fname);

            this.textBox1.Text = cfg[0];
            this.textBox2.Text = cfg[1];
            this.textBox3.Text = cfg[2];
            this.textBox4.Text = cfg[3];

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
            string fname = this.saveFileDialog1.FileName;

            string[] cfg = new string[4];

             cfg[0] = this.textBox1.Text;
             cfg[1] = this.textBox2.Text;
             cfg[2] = this.textBox3.Text;
             cfg[3]= this.textBox4.Text;

             System.IO.File.WriteAllLines(fname, cfg);
             MessageBox.Show("Saved!");
        }  // Part of the real programm do not comment 

	}
}
