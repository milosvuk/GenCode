using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class maintableSingleRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            set_login();
            set_page();
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
    private void set_page()
    {
	txtidmaintable.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idmaintable"] != null)
        {
            int _idmaintable = int.Parse(Session["idmaintable"].ToString());
            txtidmaintable.Text = _idmaintable.ToString();
            if (_idmaintable > 0)
            {
                DB_maintable dm_cases = new DB_maintable();
                maintable _obj = new maintable();
                _obj = dm_cases.GetById(_idmaintable);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(maintable obj)
{
txtidmaintable.Text  = obj.IDMAINTABLE;
txtdescription.Text  = obj.DESCRIPTION;
}
    //setSingleRecord
public maintable GetSingleRecord_From_FormFields()
{
maintable obj = new maintable();
obj.IDMAINTABLE = txtidmaintable.Text;
obj.DESCRIPTION = txtdescription.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_maintable dm_cases = new DB_maintable();
        maintable _obj = new maintable();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidmaintable.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idmaintable"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("maintableEdit.aspx");
    }
}
