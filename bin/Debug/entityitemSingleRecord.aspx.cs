using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class entityitemSingleRecord : System.Web.UI.Page
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
	txtidentityitem.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["identityitem"] != null)
        {
            int _identityitem = int.Parse(Session["identityitem"].ToString());
            txtidentityitem.Text = _identityitem.ToString();
            if (_identityitem > 0)
            {
                DB_entityitem dm_cases = new DB_entityitem();
                entityitem _obj = new entityitem();
                _obj = dm_cases.GetById(_identityitem);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(entityitem obj)
{
txtidofentity.Text  = obj.IDOFENTITY;
txtcodeofentity.Text  = obj.CODEOFENTITY;
txtnameofentity.Text  = obj.NAMEOFENTITY;
txtudf1.Text  = obj.UDF1;
txtudf2.Text  = obj.UDF2;
txtudf3.Text  = obj.UDF3;
txtidcompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public entityitem GetSingleRecord_From_FormFields()
{
entityitem obj = new entityitem();
obj.IDOFENTITY = txtidofentity.Text;
obj.CODEOFENTITY = txtcodeofentity.Text;
obj.NAMEOFENTITY = txtnameofentity.Text;
obj.UDF1 = txtudf1.Text;
obj.UDF2 = txtudf2.Text;
obj.UDF3 = txtudf3.Text;
obj.IDCOMPANY = txtidcompany.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_entityitem dm_cases = new DB_entityitem();
        entityitem _obj = new entityitem();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidentityitem.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["identityitem"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("entityitemEdit.aspx");
    }
}
