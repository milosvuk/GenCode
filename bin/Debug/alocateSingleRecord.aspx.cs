using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class alocateSingleRecord : System.Web.UI.Page
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
	txtidalocate.Text = "0"; 
        if (Session["idalocate"] != null)
        {
            int _idalocate = int.Parse(Session["idalocate"].ToString());
            txtidalocate.Text = _idalocate.ToString();
            if (_idalocate > 0)
            {
                DB_alocate dm_cases = new DB_alocate();
                alocate _obj = new alocate();
                _obj = dm_cases.GetById(_idalocate);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(alocate obj)
{
txtidRecAlocate.Text  = obj.IDRECALOCATE;
txtidInvoice.Text  = obj.IDINVOICE;
txtidPayment.Text  = obj.IDPAYMENT;
txtAmount.Text  = obj.AMOUNT;
txtActive.Text  = obj.ACTIVE;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public alocate GetSingleRecord_From_FormFields()
{
alocate obj = new alocate();
obj.IDRECALOCATE = txtidRecAlocate.Text;
obj.IDINVOICE = txtidInvoice.Text;
obj.IDPAYMENT = txtidPayment.Text;
obj.AMOUNT = txtAmount.Text;
obj.ACTIVE = txtActive.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_alocate dm_cases = new DB_alocate();
        alocate _obj = new alocate();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidalocate.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idalocate"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("alocateEdit.aspx");
    }
}
