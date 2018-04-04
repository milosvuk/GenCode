using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class socialindicatorSingleRecord : System.Web.UI.Page
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
	txtidsocialindicator.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idsocialindicator"] != null)
        {
            int _idsocialindicator = int.Parse(Session["idsocialindicator"].ToString());
            txtidsocialindicator.Text = _idsocialindicator.ToString();
            if (_idsocialindicator > 0)
            {
                DB_socialindicator dm_cases = new DB_socialindicator();
                socialindicator _obj = new socialindicator();
                _obj = dm_cases.GetById(_idsocialindicator);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(socialindicator obj)
{
txtidindicator.Text  = obj.IDINDICATOR;
txtcode.Text  = obj.CODE;
txtname.Text  = obj.NAME;
txtlowvaluerange.Text  = obj.LOWVALUERANGE;
txthighvaluerange.Text  = obj.HIGHVALUERANGE;
txtdescription.Text  = obj.DESCRIPTION;
txtidcompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public socialindicator GetSingleRecord_From_FormFields()
{
socialindicator obj = new socialindicator();
obj.IDINDICATOR = txtidindicator.Text;
obj.CODE = txtcode.Text;
obj.NAME = txtname.Text;
obj.LOWVALUERANGE = txtlowvaluerange.Text;
obj.HIGHVALUERANGE = txthighvaluerange.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.IDCOMPANY = txtidcompany.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_socialindicator dm_cases = new DB_socialindicator();
        socialindicator _obj = new socialindicator();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidsocialindicator.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idsocialindicator"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("socialindicatorEdit.aspx");
    }
}
