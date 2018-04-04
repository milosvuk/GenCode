using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class capitalexpandSingleRecord : System.Web.UI.Page
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
	txtidcapitalexpand.Text = "0"; 
        if (Session["idcapitalexpand"] != null)
        {
            int _idcapitalexpand = int.Parse(Session["idcapitalexpand"].ToString());
            txtidcapitalexpand.Text = _idcapitalexpand.ToString();
            if (_idcapitalexpand > 0)
            {
                DB_capitalexpand dm_cases = new DB_capitalexpand();
                capitalexpand _obj = new capitalexpand();
                _obj = dm_cases.GetById(_idcapitalexpand);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(capitalexpand obj)
{
txtidCapitalExp.Text  = obj.IDCAPITALEXP;
txtidProperty.Text  = obj.IDPROPERTY;
txtIdExpense.Text  = obj.IDEXPENSE;
txtDateOfCap.Text  = obj.DATEOFCAP;
txtDetails.Text  = obj.DETAILS;
txtAmount.Text  = obj.AMOUNT;
txtActive.Text  = obj.ACTIVE;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public capitalexpand GetSingleRecord_From_FormFields()
{
capitalexpand obj = new capitalexpand();
obj.IDCAPITALEXP = txtidCapitalExp.Text;
obj.IDPROPERTY = txtidProperty.Text;
obj.IDEXPENSE = txtIdExpense.Text;
obj.DATEOFCAP = txtDateOfCap.Text;
obj.DETAILS = txtDetails.Text;
obj.AMOUNT = txtAmount.Text;
obj.ACTIVE = txtActive.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_capitalexpand dm_cases = new DB_capitalexpand();
        capitalexpand _obj = new capitalexpand();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidcapitalexpand.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idcapitalexpand"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("capitalexpandEdit.aspx");
    }
}
