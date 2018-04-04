using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinTest
{
	/// <summary>
	/// Summary description for DataForm1.
	/// </summary>
	public class DataForm1 : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private WinTest.d1 objd1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancelAll;
		private System.Windows.Forms.Label lblidDepartment;
		private System.Windows.Forms.Label lblchrDeptName;
		private System.Windows.Forms.TextBox editidDepartment;
		private System.Windows.Forms.TextBox editchrDeptName;
		private System.Windows.Forms.Label lbltxtDeptDesc;
		private System.Windows.Forms.Label lblchrDeptImage;
		private System.Windows.Forms.TextBox edittxtDeptDesc;
		private System.Windows.Forms.TextBox editchrDeptImage;
		private System.Windows.Forms.Button btnNavFirst;
		private System.Windows.Forms.Button btnNavPrev;
		private System.Windows.Forms.Label lblNavLocation;
		private System.Windows.Forms.Button btnNavNext;
		private System.Windows.Forms.Button btnLast;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataForm1()
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
				if(components != null)
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
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.objd1 = new WinTest.d1();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancelAll = new System.Windows.Forms.Button();
			this.lblidDepartment = new System.Windows.Forms.Label();
			this.lblchrDeptName = new System.Windows.Forms.Label();
			this.editidDepartment = new System.Windows.Forms.TextBox();
			this.editchrDeptName = new System.Windows.Forms.TextBox();
			this.lbltxtDeptDesc = new System.Windows.Forms.Label();
			this.lblchrDeptImage = new System.Windows.Forms.Label();
			this.edittxtDeptDesc = new System.Windows.Forms.TextBox();
			this.editchrDeptImage = new System.Windows.Forms.TextBox();
			this.btnNavFirst = new System.Windows.Forms.Button();
			this.btnNavPrev = new System.Windows.Forms.Button();
			this.lblNavLocation = new System.Windows.Forms.Label();
			this.btnNavNext = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.objd1)).BeginInit();
			this.SuspendLayout();
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT idDepartment, chrDeptName, txtDeptDesc, chrDeptImage FROM Department";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Auto Translate=True;User ID=sa;Tag with column collation when possible=False;Data Source=DVUKELIC;Password=sa;Initial Catalog=students;Use Procedure for Prepare=1;Provider=""SQLOLEDB.1"";Persist Security Info=True;Workstation ID=DVUKELIC;Use Encryption for Data=False;Packet Size=4096";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Department(chrDeptName, txtDeptDesc, chrDeptImage) VALUES (?, ?, ?); " +
				"SELECT idDepartment, chrDeptName, txtDeptDesc, chrDeptImage FROM Department WHER" +
				"E (idDepartment = @@IDENTITY)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("chrDeptName", System.Data.OleDb.OleDbType.VarChar, 255, "chrDeptName"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("txtDeptDesc", System.Data.OleDb.OleDbType.VarChar, 50, "txtDeptDesc"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("chrDeptImage", System.Data.OleDb.OleDbType.VarChar, 255, "chrDeptImage"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Department SET chrDeptName = ?, txtDeptDesc = ?, chrDeptImage = ? WHERE (idDepartment = ?) AND (chrDeptImage = ? OR ? IS NULL AND chrDeptImage IS NULL) AND (chrDeptName = ? OR ? IS NULL AND chrDeptName IS NULL) AND (txtDeptDesc = ? OR ? IS NULL AND txtDeptDesc IS NULL); SELECT idDepartment, chrDeptName, txtDeptDesc, chrDeptImage FROM Department WHERE (idDepartment = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("chrDeptName", System.Data.OleDb.OleDbType.VarChar, 255, "chrDeptName"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("txtDeptDesc", System.Data.OleDb.OleDbType.VarChar, 50, "txtDeptDesc"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("chrDeptImage", System.Data.OleDb.OleDbType.VarChar, 255, "chrDeptImage"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_idDepartment", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "idDepartment", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptImage", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptImage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptImage1", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptImage", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptName", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptName1", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptName", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_txtDeptDesc", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "txtDeptDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_txtDeptDesc1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "txtDeptDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Select_idDepartment", System.Data.OleDb.OleDbType.Integer, 4, "idDepartment"));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Department WHERE (idDepartment = ?) AND (chrDeptImage = ? OR ? IS NUL" +
				"L AND chrDeptImage IS NULL) AND (chrDeptName = ? OR ? IS NULL AND chrDeptName IS" +
				" NULL) AND (txtDeptDesc = ? OR ? IS NULL AND txtDeptDesc IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_idDepartment", System.Data.OleDb.OleDbType.Integer, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "idDepartment", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptImage", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptImage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptImage1", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptImage", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptName", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_chrDeptName1", System.Data.OleDb.OleDbType.VarChar, 255, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "chrDeptName", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_txtDeptDesc", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "txtDeptDesc", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_txtDeptDesc1", System.Data.OleDb.OleDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "txtDeptDesc", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Department", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("idDepartment", "idDepartment"),
																																																					  new System.Data.Common.DataColumnMapping("chrDeptName", "chrDeptName"),
																																																					  new System.Data.Common.DataColumnMapping("txtDeptDesc", "txtDeptDesc"),
																																																					  new System.Data.Common.DataColumnMapping("chrDeptImage", "chrDeptImage")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// objd1
			// 
			this.objd1.DataSetName = "d1";
			this.objd1.Locale = new System.Globalization.CultureInfo("en-GB");
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(10, 10);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "&Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(365, 10);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "&Update";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnCancelAll
			// 
			this.btnCancelAll.Location = new System.Drawing.Point(365, 43);
			this.btnCancelAll.Name = "btnCancelAll";
			this.btnCancelAll.TabIndex = 2;
			this.btnCancelAll.Text = "Ca&ncel All";
			this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
			// 
			// lblidDepartment
			// 
			this.lblidDepartment.Location = new System.Drawing.Point(10, 76);
			this.lblidDepartment.Name = "lblidDepartment";
			this.lblidDepartment.TabIndex = 3;
			this.lblidDepartment.Text = "idDepartment";
			// 
			// lblchrDeptName
			// 
			this.lblchrDeptName.Location = new System.Drawing.Point(10, 109);
			this.lblchrDeptName.Name = "lblchrDeptName";
			this.lblchrDeptName.TabIndex = 4;
			this.lblchrDeptName.Text = "chrDeptName";
			// 
			// editidDepartment
			// 
			this.editidDepartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objd1, "Department.idDepartment"));
			this.editidDepartment.Location = new System.Drawing.Point(120, 76);
			this.editidDepartment.Name = "editidDepartment";
			this.editidDepartment.TabIndex = 5;
			this.editidDepartment.Text = "";
			// 
			// editchrDeptName
			// 
			this.editchrDeptName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objd1, "Department.chrDeptName"));
			this.editchrDeptName.Location = new System.Drawing.Point(120, 109);
			this.editchrDeptName.Name = "editchrDeptName";
			this.editchrDeptName.TabIndex = 6;
			this.editchrDeptName.Text = "";
			// 
			// lbltxtDeptDesc
			// 
			this.lbltxtDeptDesc.Location = new System.Drawing.Point(230, 76);
			this.lbltxtDeptDesc.Name = "lbltxtDeptDesc";
			this.lbltxtDeptDesc.TabIndex = 7;
			this.lbltxtDeptDesc.Text = "txtDeptDesc";
			// 
			// lblchrDeptImage
			// 
			this.lblchrDeptImage.Location = new System.Drawing.Point(230, 109);
			this.lblchrDeptImage.Name = "lblchrDeptImage";
			this.lblchrDeptImage.TabIndex = 8;
			this.lblchrDeptImage.Text = "chrDeptImage";
			// 
			// edittxtDeptDesc
			// 
			this.edittxtDeptDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objd1, "Department.txtDeptDesc"));
			this.edittxtDeptDesc.Location = new System.Drawing.Point(340, 76);
			this.edittxtDeptDesc.Name = "edittxtDeptDesc";
			this.edittxtDeptDesc.TabIndex = 9;
			this.edittxtDeptDesc.Text = "";
			// 
			// editchrDeptImage
			// 
			this.editchrDeptImage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.objd1, "Department.chrDeptImage"));
			this.editchrDeptImage.Location = new System.Drawing.Point(340, 109);
			this.editchrDeptImage.Name = "editchrDeptImage";
			this.editchrDeptImage.TabIndex = 10;
			this.editchrDeptImage.Text = "";
			// 
			// btnNavFirst
			// 
			this.btnNavFirst.Location = new System.Drawing.Point(195, 142);
			this.btnNavFirst.Name = "btnNavFirst";
			this.btnNavFirst.Size = new System.Drawing.Size(40, 23);
			this.btnNavFirst.TabIndex = 11;
			this.btnNavFirst.Text = "<<";
			this.btnNavFirst.Click += new System.EventHandler(this.btnNavFirst_Click);
			// 
			// btnNavPrev
			// 
			this.btnNavPrev.Location = new System.Drawing.Point(235, 142);
			this.btnNavPrev.Name = "btnNavPrev";
			this.btnNavPrev.Size = new System.Drawing.Size(35, 23);
			this.btnNavPrev.TabIndex = 12;
			this.btnNavPrev.Text = "<";
			this.btnNavPrev.Click += new System.EventHandler(this.btnNavPrev_Click);
			// 
			// lblNavLocation
			// 
			this.lblNavLocation.BackColor = System.Drawing.Color.White;
			this.lblNavLocation.Location = new System.Drawing.Point(270, 142);
			this.lblNavLocation.Name = "lblNavLocation";
			this.lblNavLocation.Size = new System.Drawing.Size(95, 23);
			this.lblNavLocation.TabIndex = 13;
			this.lblNavLocation.Text = "No Records";
			this.lblNavLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNavNext
			// 
			this.btnNavNext.Location = new System.Drawing.Point(365, 142);
			this.btnNavNext.Name = "btnNavNext";
			this.btnNavNext.Size = new System.Drawing.Size(35, 23);
			this.btnNavNext.TabIndex = 14;
			this.btnNavNext.Text = ">";
			this.btnNavNext.Click += new System.EventHandler(this.btnNavNext_Click);
			// 
			// btnLast
			// 
			this.btnLast.Location = new System.Drawing.Point(400, 142);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(40, 23);
			this.btnLast.TabIndex = 15;
			this.btnLast.Text = ">>";
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(195, 175);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(280, 175);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(365, 175);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(480, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(200, 160);
			this.listBox1.TabIndex = 19;
			// 
			// DataForm1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 358);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCancelAll);
			this.Controls.Add(this.lblidDepartment);
			this.Controls.Add(this.lblchrDeptName);
			this.Controls.Add(this.editidDepartment);
			this.Controls.Add(this.editchrDeptName);
			this.Controls.Add(this.lbltxtDeptDesc);
			this.Controls.Add(this.lblchrDeptImage);
			this.Controls.Add(this.edittxtDeptDesc);
			this.Controls.Add(this.editchrDeptImage);
			this.Controls.Add(this.btnNavFirst);
			this.Controls.Add(this.btnNavPrev);
			this.Controls.Add(this.lblNavLocation);
			this.Controls.Add(this.btnNavNext);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCancel);
			this.Name = "DataForm1";
			this.Text = "DataForm1";
			this.Load += new System.EventHandler(this.DataForm1_Load);
			((System.ComponentModel.ISupportInitialize)(this.objd1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public void FillDataSet(WinTest.d1 dataSet)
		{
			// Turn off constraint checking before the dataset is filled.
			// This allows the adapters to fill the dataset without concern
			// for dependencies between the tables.
			dataSet.EnforceConstraints = false;
			try 
			{
				// Open the connection.
				this.oleDbConnection1.Open();
				// Attempt to fill the dataset through the OleDbDataAdapter1.
				this.oleDbDataAdapter1.Fill(dataSet);
			}
			catch (System.Exception fillException) 
			{
				// Add your error handling code here.
				throw fillException;
			}
			finally 
			{
				// Turn constraint checking back on.
				dataSet.EnforceConstraints = true;
				// Close the connection whether or not the exception was thrown.
				this.oleDbConnection1.Close();
			}

		}

		public void UpdateDataSource(WinTest.d1 ChangedRows)
		{
			try 
			{
				// The data source only needs to be updated if there are changes pending.
				if ((ChangedRows != null)) 
				{
					// Open the connection.
					this.oleDbConnection1.Open();
					// Attempt to update the data source.
					oleDbDataAdapter1.Update(ChangedRows);
				}
			}
			catch (System.Exception updateException) 
			{
				// Add your error handling code here.
				throw updateException;
			}
			finally 
			{
				// Close the connection whether or not the exception was thrown.
				this.oleDbConnection1.Close();
			}

		}

		public void LoadDataSet()
		{
			// Create a new dataset to hold the records returned from the call to FillDataSet.
			// A temporary dataset is used because filling the existing dataset would
			// require the databindings to be rebound.
			WinTest.d1 objDataSetTemp;
			objDataSetTemp = new WinTest.d1();
			try 
			{
				// Attempt to fill the temporary dataset.
				this.FillDataSet(objDataSetTemp);
			}
			catch (System.Exception eFillDataSet) 
			{
				// Add your error handling code here.
				throw eFillDataSet;
			}
			try 
			{
				// Empty the old records from the dataset.
				objd1.Clear();
				// Merge the records into the main dataset.
				objd1.Merge(objDataSetTemp);
			}
			catch (System.Exception eLoadMerge) 
			{
				// Add your error handling code here.
				throw eLoadMerge;
			}

		}

		public void UpdateDataSet()
		{
			// Create a new dataset to hold the changes that have been made to the main dataset.
			WinTest.d1 objDataSetChanges = new WinTest.d1();
			// Stop any current edits.
			this.BindingContext[objd1,"Department"].EndCurrentEdit();
			// Get the changes that have been made to the main dataset.
			objDataSetChanges = ((WinTest.d1)(objd1.GetChanges()));
			// Check to see if any changes have been made.
			if ((objDataSetChanges != null)) 
			{
				try 
				{
					// There are changes that need to be made, so attempt to update the datasource by
					// calling the update method and passing the dataset and any parameters.
					this.UpdateDataSource(objDataSetChanges);
					objd1.Merge(objDataSetChanges);
					objd1.AcceptChanges();
				}
				catch (System.Exception eUpdate) 
				{
					// Add your error handling code here.
					throw eUpdate;
				}
				// Add your code to check the returned dataset for any errors that may have been
				// pushed into the row object's error.
			}

		}

		private void btnCancelAll_Click(object sender, System.EventArgs e)
		{
			this.objd1.RejectChanges();

		}

		private void objd1_PositionChanged()
		{
			this.lblNavLocation.Text = ((((this.BindingContext[objd1,"Department"].Position + 1)).ToString() + " of  ") 
				+ this.BindingContext[objd1,"Department"].Count.ToString());

		}

		private void btnNavNext_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objd1,"Department"].Position = (this.BindingContext[objd1,"Department"].Position + 1);
			this.objd1_PositionChanged();

		}

		private void btnNavPrev_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objd1,"Department"].Position = (this.BindingContext[objd1,"Department"].Position - 1);
			this.objd1_PositionChanged();

		}

		private void btnLast_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objd1,"Department"].Position = (this.objd1.Tables["Department"].Rows.Count - 1);
			this.objd1_PositionChanged();

		}

		private void btnNavFirst_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objd1,"Department"].Position = 0;
			this.objd1_PositionChanged();

		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Attempt to load the dataset.
				this.LoadDataSet();
			}
			catch (System.Exception eLoad) 
			{
				// Add your error handling code here.
				// Display error message, if any.
				System.Windows.Forms.MessageBox.Show(eLoad.Message);
			}
			this.objd1_PositionChanged();

		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Attempt to update the datasource.
				this.UpdateDataSet();
			}
			catch (System.Exception eUpdate) 
			{
				// Add your error handling code here.
				// Display error message, if any.
				System.Windows.Forms.MessageBox.Show(eUpdate.Message);
			}
			this.objd1_PositionChanged();

		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			try 
			{
				// Clear out the current edits
				this.BindingContext[objd1,"Department"].EndCurrentEdit();
				this.BindingContext[objd1,"Department"].AddNew();
			}
			catch (System.Exception eEndEdit) 
			{
				System.Windows.Forms.MessageBox.Show(eEndEdit.Message);
			}
			this.objd1_PositionChanged();

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if ((this.BindingContext[objd1,"Department"].Count > 0)) 
			{
				this.BindingContext[objd1,"Department"].RemoveAt(this.BindingContext[objd1,"Department"].Position);
				this.objd1_PositionChanged();
			}

		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.BindingContext[objd1,"Department"].CancelCurrentEdit();
			this.objd1_PositionChanged();

		}

		private void DataForm1_Load(object sender, System.EventArgs e)
		{
			BReportS.Class1 obj = new BReportS.Class1();
			
		}
	}
}
