using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class processEdit : System.Web.UI.Page
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
                    DB_process dm_process = new DB_process();
                    List<process> listprocess = (List<process>)dm_process.GetAll();;
                    this.GridView1.DataSource = listprocess;
                    this.GridView1.DataBind();
                    this.ListBox1.DataSource = listprocess;
                    this.ListBox1.DataTextField = "idprocess";
                    this.ListBox1.DataValueField = "idprocess";
                    this.ListBox1.DataBind();
               }
	//setgridDD
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int n = e.NewEditIndex;
        e.Cancel = true;
        this.ListBox1.SelectedIndex = n;
        string idRecord = this.ListBox1.SelectedItem.Value;
        Session["idprocess"] = idRecord;  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("processSingleRecord.aspx");  //change to real single page
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
         Session["idprocess"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
         Response.Redirect("processSingleRecord.aspx");  //change to real single page
    }
}
