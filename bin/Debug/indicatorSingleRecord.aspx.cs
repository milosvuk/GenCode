using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class indicatorSingleRecord : System.Web.UI.Page
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
	txtidindicator.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idindicator"] != null)
        {
            int _idindicator = int.Parse(Session["idindicator"].ToString());
            txtidindicator.Text = _idindicator.ToString();
            if (_idindicator > 0)
            {
                DB_indicator dm_cases = new DB_indicator();
                indicator _obj = new indicator();
                _obj = dm_cases.GetById(_idindicator);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(indicator obj)
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
public indicator GetSingleRecord_From_FormFields()
{
indicator obj = new indicator();
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
        DB_indicator dm_cases = new DB_indicator();
        indicator _obj = new indicator();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidindicator.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idindicator"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("indicatorEdit.aspx");
    }
}
