using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class seniorcitizenSingleRecord : System.Web.UI.Page
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
	txtidseniorcitizen.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idseniorcitizen"] != null)
        {
            int _idseniorcitizen = int.Parse(Session["idseniorcitizen"].ToString());
            txtidseniorcitizen.Text = _idseniorcitizen.ToString();
            if (_idseniorcitizen > 0)
            {
                DB_seniorcitizen dm_cases = new DB_seniorcitizen();
                seniorcitizen _obj = new seniorcitizen();
                _obj = dm_cases.GetById(_idseniorcitizen);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(seniorcitizen obj)
{
txtidseniorcitizen.Text  = obj.IDSENIORCITIZEN;
txtName.Text  = obj.NAME;
txtSurname.Text  = obj.SURNAME;
txtIDcard.Text  = obj.IDCARD;
txtAddress1.Text  = obj.ADDRESS1;
txtAddress2.Text  = obj.ADDRESS2;
txtAddress3.Text  = obj.ADDRESS3;
txtCity.Text  = obj.CITY;
txtLocCoordLat.Text  = obj.LOCCOORDLAT;
txtLocCoordLong.Text  = obj.LOCCOORDLONG;
txtPhone.Text  = obj.PHONE;
txtMobile.Text  = obj.MOBILE;
txtEmail.Text  = obj.EMAIL;
txtComment.Text  = obj.COMMENT;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public seniorcitizen GetSingleRecord_From_FormFields()
{
seniorcitizen obj = new seniorcitizen();
obj.IDSENIORCITIZEN = txtidseniorcitizen.Text;
obj.NAME = txtName.Text;
obj.SURNAME = txtSurname.Text;
obj.IDCARD = txtIDcard.Text;
obj.ADDRESS1 = txtAddress1.Text;
obj.ADDRESS2 = txtAddress2.Text;
obj.ADDRESS3 = txtAddress3.Text;
obj.CITY = txtCity.Text;
obj.LOCCOORDLAT = txtLocCoordLat.Text;
obj.LOCCOORDLONG = txtLocCoordLong.Text;
obj.PHONE = txtPhone.Text;
obj.MOBILE = txtMobile.Text;
obj.EMAIL = txtEmail.Text;
obj.COMMENT = txtComment.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_seniorcitizen dm_cases = new DB_seniorcitizen();
        seniorcitizen _obj = new seniorcitizen();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidseniorcitizen.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idseniorcitizen"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("seniorcitizenEdit.aspx");
    }
}
