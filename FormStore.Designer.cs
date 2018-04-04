namespace REPLACE_WITH_NAMESPACE_OF_APPLICATION 
  {  
  partial class  FormStore
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
this.lbl_id = new System.Windows.Forms.Label();
this.txt_id  = new System.Windows.Forms.TextBox();
this.lbl_Store_no = new System.Windows.Forms.Label();
this.txt_Store_no  = new System.Windows.Forms.TextBox();
this.lbl_Store_code = new System.Windows.Forms.Label();
this.txt_Store_code  = new System.Windows.Forms.TextBox();
this.lbl_Store_name = new System.Windows.Forms.Label();
this.txt_Store_name  = new System.Windows.Forms.TextBox();
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
this.lbl_id.AutoSize = true;
this.lbl_id.Location = new System.Drawing.Point(126,25);
this.lbl_id.Name = "lbl_id";
this.lbl_id.Text = "id";
this.txt_id.Location = new System.Drawing.Point(241,25);
this.txt_id.Name = "txt_id";
this.lbl_Store_no.AutoSize = true;
this.lbl_Store_no.Location = new System.Drawing.Point(126,50);
this.lbl_Store_no.Name = "lbl_Store_no";
this.lbl_Store_no.Text = "Store_no";
this.txt_Store_no.Location = new System.Drawing.Point(241,50);
this.txt_Store_no.Name = "txt_Store_no";
this.lbl_Store_code.AutoSize = true;
this.lbl_Store_code.Location = new System.Drawing.Point(126,75);
this.lbl_Store_code.Name = "lbl_Store_code";
this.lbl_Store_code.Text = "Store_code";
this.txt_Store_code.Location = new System.Drawing.Point(241,75);
this.txt_Store_code.Name = "txt_Store_code";
this.lbl_Store_name.AutoSize = true;
this.lbl_Store_name.Location = new System.Drawing.Point(126,100);
this.lbl_Store_name.Name = "lbl_Store_name";
this.lbl_Store_name.Text = "Store_name";
this.txt_Store_name.Location = new System.Drawing.Point(241,100);
this.txt_Store_name.Name = "txt_Store_name";
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);   
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;   
               this.ClientSize = new System.Drawing.Size(794, 457);  
  this.Controls.Add(this.lbl_id );
  this.Controls.Add(this.txt_id );
  this.Controls.Add(this.lbl_Store_no );
  this.Controls.Add(this.txt_Store_no );
  this.Controls.Add(this.lbl_Store_code );
  this.Controls.Add(this.txt_Store_code );
  this.Controls.Add(this.lbl_Store_name );
  this.Controls.Add(this.txt_Store_name );
       this.Controls.Add(this.btnSave);   
        this.Controls.Add(this.btnCancel);   
 this.Name ="FormStore";
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; 
 this.Text ="FormStore";
  this.Load += new System.EventHandler(this.FormStore_Load);
       this.ResumeLayout(false); 
         this.PerformLayout(); 
      } 
        #endregion 
       private System.Windows.Forms.Button btnCancel; 
     private System.Windows.Forms.Button btnSave; 
  private System.Windows.Forms.Label lbl_id;
  private System.Windows.Forms.TextBox txt_id;
  private System.Windows.Forms.Label lbl_Store_no;
  private System.Windows.Forms.TextBox txt_Store_no;
  private System.Windows.Forms.Label lbl_Store_code;
  private System.Windows.Forms.TextBox txt_Store_code;
  private System.Windows.Forms.Label lbl_Store_name;
  private System.Windows.Forms.TextBox txt_Store_name;
   } 
   } 
