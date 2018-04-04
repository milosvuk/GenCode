using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class healthcareprofessionalsSingleRecord : System.Web.UI.Page
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
	txtidhealthcareprofessionals.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idhealthcareprofessionals"] != null)
        {
            int _idhealthcareprofessionals = int.Parse(Session["idhealthcareprofessionals"].ToString());
            txtidhealthcareprofessionals.Text = _idhealthcareprofessionals.ToString();
            if (_idhealthcareprofessionals > 0)
            {
                DB_healthcareprofessionals dm_cases = new DB_healthcareprofessionals();
                healthcareprofessionals _obj = new healthcareprofessionals();
                _obj = dm_cases.GetById(_idhealthcareprofessionals);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(healthcareprofessionals obj)
{
txtidprofessional.Text  = obj.IDPROFESSIONAL;
txtname.Text  = obj.NAME;
txtsurname.Text  = obj.SURNAME;
txtmobile.Text  = obj.MOBILE;
txtemail.Text  = obj.EMAIL;
txtusername.Text  = obj.USERNAME;
txtpassword.Text  = obj.PASSWORD;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public healthcareprofessionals GetSingleRecord_From_FormFields()
{
healthcareprofessionals obj = new healthcareprofessionals();
obj.IDPROFESSIONAL = txtidprofessional.Text;
obj.NAME = txtname.Text;
obj.SURNAME = txtsurname.Text;
obj.MOBILE = txtmobile.Text;
obj.EMAIL = txtemail.Text;
obj.USERNAME = txtusername.Text;
obj.PASSWORD = txtpassword.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_healthcareprofessionals dm_cases = new DB_healthcareprofessionals();
        healthcareprofessionals _obj = new healthcareprofessionals();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidhealthcareprofessionals.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idhealthcareprofessionals"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("healthcareprofessionalsEdit.aspx");
    }
}
