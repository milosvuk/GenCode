using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class paymentSingleRecord : System.Web.UI.Page
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
	txtidpayment.Text = "0"; 
        if (Session["idpayment"] != null)
        {
            int _idpayment = int.Parse(Session["idpayment"].ToString());
            txtidpayment.Text = _idpayment.ToString();
            if (_idpayment > 0)
            {
                DB_payment dm_cases = new DB_payment();
                payment _obj = new payment();
                _obj = dm_cases.GetById(_idpayment);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(payment obj)
{
txtidRecPayment.Text  = obj.IDRECPAYMENT;
txtidProperty.Text  = obj.IDPROPERTY;
txtidCustomer.Text  = obj.IDCUSTOMER;
txtDateOfPayment.Text  = obj.DATEOFPAYMENT;
txtDescription1.Text  = obj.DESCRIPTION1;
txtDescription2.Text  = obj.DESCRIPTION2;
txtAmountPaid.Text  = obj.AMOUNTPAID;
txtAmountAlocated.Text  = obj.AMOUNTALOCATED;
txtActive.Text  = obj.ACTIVE;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public payment GetSingleRecord_From_FormFields()
{
payment obj = new payment();
obj.IDRECPAYMENT = txtidRecPayment.Text;
obj.IDPROPERTY = txtidProperty.Text;
obj.IDCUSTOMER = txtidCustomer.Text;
obj.DATEOFPAYMENT = txtDateOfPayment.Text;
obj.DESCRIPTION1 = txtDescription1.Text;
obj.DESCRIPTION2 = txtDescription2.Text;
obj.AMOUNTPAID = txtAmountPaid.Text;
obj.AMOUNTALOCATED = txtAmountAlocated.Text;
obj.ACTIVE = txtActive.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_payment dm_cases = new DB_payment();
        payment _obj = new payment();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidpayment.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idpayment"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("paymentEdit.aspx");
    }
}
