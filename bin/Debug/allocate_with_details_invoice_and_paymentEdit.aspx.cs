using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class allocate_with_details_invoice_and_paymentEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            set_login();
            set_grid();
        } 
    }
    private void set_login()
    {
        int logid = 0;
        if (Session["Loggedin"] != null)
        {
            logid = int.Parse(Session["Loggedin"].ToString());
        }
        else
        {
            Response.Redirect("MainLogin.aspx");
        }
        if (logid > 0)
        {
            Label2.Text = logid.ToString();
        }
        else
        {
            Response.Redirect("MainLogin.aspx");
        }
    }
              private void set_grid()
               {
                    DB_allocate_with_details_invoice_and_payment dm_allocate_with_details_invoice_and_payment = new DB_allocate_with_details_invoice_and_payment();
                    List<allocate_with_details_invoice_and_payment> listallocate_with_details_invoice_and_payment = (List<allocate_with_details_invoice_and_payment>)dm_allocate_with_details_invoice_and_payment.GetAll();;
                    this.GridView1.DataSource = listallocate_with_details_invoice_and_payment;
                    this.GridView1.DataBind();
                    this.ListBox1.DataSource = listallocate_with_details_invoice_and_payment;
                    this.ListBox1.DataTextField = "idRecAlocate";
                    this.ListBox1.DataValueField = "idRecAlocate";
                    this.ListBox1.DataBind();
               }
	//setgridDD
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int n = e.NewEditIndex;
        e.Cancel = true;
        this.ListBox1.SelectedIndex = n;
        string idRecord = this.ListBox1.SelectedItem.Value;
        Session["idallocate_with_details_invoice_and_payment"] = idRecord;  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("allocate_with_details_invoice_and_paymentSingleRecord.aspx");  //change to real single page
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
         Session["idallocate_with_details_invoice_and_payment"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
         Response.Redirect("allocate_with_details_invoice_and_paymentSingleRecord.aspx");  //change to real single page
    }
}
