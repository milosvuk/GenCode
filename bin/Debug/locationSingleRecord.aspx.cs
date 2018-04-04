using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class locationSingleRecord : System.Web.UI.Page
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
	txtidlocation.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idlocation"] != null)
        {
            int _idlocation = int.Parse(Session["idlocation"].ToString());
            txtidlocation.Text = _idlocation.ToString();
            if (_idlocation > 0)
            {
                DB_location dm_cases = new DB_location();
                location _obj = new location();
                _obj = dm_cases.GetById(_idlocation);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(location obj)
{
txtidlocation.Text  = obj.IDLOCATION;
txtcodeoflocation.Text  = obj.CODEOFLOCATION;
txtnameoflocation.Text  = obj.NAMEOFLOCATION;
txtlatit.Text  = obj.LATIT;
txtlongi.Text  = obj.LONGI;
txtdescription.Text  = obj.DESCRIPTION;
txtidcompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public location GetSingleRecord_From_FormFields()
{
location obj = new location();
obj.IDLOCATION = txtidlocation.Text;
obj.CODEOFLOCATION = txtcodeoflocation.Text;
obj.NAMEOFLOCATION = txtnameoflocation.Text;
obj.LATIT = txtlatit.Text;
obj.LONGI = txtlongi.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.IDCOMPANY = txtidcompany.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_location dm_cases = new DB_location();
        location _obj = new location();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidlocation.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idlocation"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("locationEdit.aspx");
    }
}
