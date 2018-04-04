using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class objclassesSingleRecord : System.Web.UI.Page
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
	txtidobjclasses.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idobjclasses"] != null)
        {
            int _idobjclasses = int.Parse(Session["idobjclasses"].ToString());
            txtidobjclasses.Text = _idobjclasses.ToString();
            if (_idobjclasses > 0)
            {
                DB_objclasses dm_cases = new DB_objclasses();
                objclasses _obj = new objclasses();
                _obj = dm_cases.GetById(_idobjclasses);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(objclasses obj)
{
txtidobjclasses.Text  = obj.IDOBJCLASSES;
txtname.Text  = obj.NAME;
txtidcompany.Text  = obj.IDCOMPANY;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public objclasses GetSingleRecord_From_FormFields()
{
objclasses obj = new objclasses();
obj.IDOBJCLASSES = txtidobjclasses.Text;
obj.NAME = txtname.Text;
obj.IDCOMPANY = txtidcompany.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_objclasses dm_cases = new DB_objclasses();
        objclasses _obj = new objclasses();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidobjclasses.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idobjclasses"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("objclassesEdit.aspx");
    }
}
