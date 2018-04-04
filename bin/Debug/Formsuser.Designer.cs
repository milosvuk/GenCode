 namespace REPLACE_NAMESPACE_IN_APPLICATION 
  {  
  partial class  Formsuser
  {  
  private System.ComponentModel.IContainer components = null; 
   protected override void Dispose(bool disposing) 
  {  
 if (disposing && (components != null))  
  {  
  components.Dispose();  
  } 
   base.Dispose(disposing); 
  } 
   #region Windows Form Designer generated code
  private void InitializeComponent() 
  {  
   this.btnCancel = new System.Windows.Forms.Button();  
   this.btnSave = new System.Windows.Forms.Button();  
this.lbl_iduser = new System.Windows.Forms.Label();
this.txt_iduser  = new System.Windows.Forms.TextBox();
this.lbl_username = new System.Windows.Forms.Label();
this.txt_username  = new System.Windows.Forms.TextBox();
this.lbl_passw = new System.Windows.Forms.Label();
this.txt_passw  = new System.Windows.Forms.TextBox();
this.lbl_userlevel = new System.Windows.Forms.Label();
this.txt_userlevel  = new System.Windows.Forms.TextBox();
this.lbl_id_company = new System.Windows.Forms.Label();
this.txt_id_company  = new System.Windows.Forms.TextBox();
    this.SuspendLayout();  
   this.btnCancel.Location = new System.Drawing.Point(220, 382);    
this.btnCancel.Name = "btnCancel";
  this.btnCancel.Size = new System.Drawing.Size(121, 63);    
   this.btnCancel.TabIndex = 0;    
this.btnCancel.Text = "Cancel";
   this.btnCancel.UseVisualStyleBackColor = true;     
        this.btnSave.Location = new System.Drawing.Point(429, 382);    
this.btnSave.Name = "btnSave";
   this.btnSave.Size = new System.Drawing.Size(121, 63);    
    this.btnSave.TabIndex = 1;  
 this.btnSave.Text = "Save";
     this.btnSave.UseVisualStyleBackColor = true;    
this.lbl_iduser.AutoSize = true;
this.lbl_iduser.Location = new System.Drawing.Point(126,25);
this.lbl_iduser.Name = "lbl_iduser";
this.lbl_iduser.Text = "iduser";
this.txt_iduser.Location = new System.Drawing.Point(241,25);
this.txt_iduser.Name = "txt_iduser";
this.lbl_username.AutoSize = true;
this.lbl_username.Location = new System.Drawing.Point(126,50);
this.lbl_username.Name = "lbl_username";
this.lbl_username.Text = "username";
this.txt_username.Location = new System.Drawing.Point(241,50);
this.txt_username.Name = "txt_username";
this.lbl_passw.AutoSize = true;
this.lbl_passw.Location = new System.Drawing.Point(126,75);
this.lbl_passw.Name = "lbl_passw";
this.lbl_passw.Text = "passw";
this.txt_passw.Location = new System.Drawing.Point(241,75);
this.txt_passw.Name = "txt_passw";
this.lbl_userlevel.AutoSize = true;
this.lbl_userlevel.Location = new System.Drawing.Point(126,100);
this.lbl_userlevel.Name = "lbl_userlevel";
this.lbl_userlevel.Text = "userlevel";
this.txt_userlevel.Location = new System.Drawing.Point(241,100);
this.txt_userlevel.Name = "txt_userlevel";
this.lbl_id_company.AutoSize = true;
this.lbl_id_company.Location = new System.Drawing.Point(126,125);
this.lbl_id_company.Name = "lbl_id_company";
this.lbl_id_company.Text = "id_company";
this.txt_id_company.Location = new System.Drawing.Point(241,125);
this.txt_id_company.Name = "txt_id_company";
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);   
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;   
               this.ClientSize = new System.Drawing.Size(794, 457);  
  this.Controls.Add(this.lbl_iduser );
  this.Controls.Add(this.txt_iduser );
  this.Controls.Add(this.lbl_username );
  this.Controls.Add(this.txt_username );
  this.Controls.Add(this.lbl_passw );
  this.Controls.Add(this.txt_passw );
  this.Controls.Add(this.lbl_userlevel );
  this.Controls.Add(this.txt_userlevel );
  this.Controls.Add(this.lbl_id_company );
  this.Controls.Add(this.txt_id_company );
       this.Controls.Add(this.btnSave);   
        this.Controls.Add(this.btnCancel);   
 this.Name ="Formsuser";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; 
 this.Text ="Formsuser";
  this.Load += new System.EventHandler(this.Formsuser_Load);
       this.ResumeLayout(false); 
         this.PerformLayout(); 
      } 
        #endregion 
       private System.Windows.Forms.Button btnCancel; 
     private System.Windows.Forms.Button btnSave; 
  private System.Windows.Forms.Label lbl_iduser;
  private System.Windows.Forms.TextBox txt_iduser;
  private System.Windows.Forms.Label lbl_username;
  private System.Windows.Forms.TextBox txt_username;
  private System.Windows.Forms.Label lbl_passw;
  private System.Windows.Forms.TextBox txt_passw;
  private System.Windows.Forms.Label lbl_userlevel;
  private System.Windows.Forms.TextBox txt_userlevel;
  private System.Windows.Forms.Label lbl_id_company;
  private System.Windows.Forms.TextBox txt_id_company;
   } 
   } 
