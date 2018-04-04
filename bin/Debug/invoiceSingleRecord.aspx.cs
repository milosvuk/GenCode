using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class invoiceSingleRecord : System.Web.UI.Page
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
	txtidinvoice.Text = "0"; 
        if (Session["idinvoice"] != null)
        {
            int _idinvoice = int.Parse(Session["idinvoice"].ToString());
            txtidinvoice.Text = _idinvoice.ToString();
            if (_idinvoice > 0)
            {
                DB_invoice dm_cases = new DB_invoice();
                invoice _obj = new invoice();
                _obj = dm_cases.GetById(_idinvoice);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(invoice obj)
{
txtidRecInv.Text  = obj.IDRECINV;
txtidProperty.Text  = obj.IDPROPERTY;
txtidCustomer.Text  = obj.IDCUSTOMER;
txtDateOfInv.Text  = obj.DATEOFINV;
txtidExpense.Text  = obj.IDEXPENSE;
txtAmount.Text  = obj.AMOUNT;
txtTaxPerc.Text  = obj.TAXPERC;
txtTaxAmount.Text  = obj.TAXAMOUNT;
txtTotalAmount.Text  = obj.TOTALAMOUNT;
txtFinalized.Text  = obj.FINALIZED;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public invoice GetSingleRecord_From_FormFields()
{
invoice obj = new invoice();
obj.IDRECINV = txtidRecInv.Text;
obj.IDPROPERTY = txtidProperty.Text;
obj.IDCUSTOMER = txtidCustomer.Text;
obj.DATEOFINV = txtDateOfInv.Text;
obj.IDEXPENSE = txtidExpense.Text;
obj.AMOUNT = txtAmount.Text;
obj.TAXPERC = txtTaxPerc.Text;
obj.TAXAMOUNT = txtTaxAmount.Text;
obj.TOTALAMOUNT = txtTotalAmount.Text;
obj.FINALIZED = txtFinalized.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_invoice dm_cases = new DB_invoice();
        invoice _obj = new invoice();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidinvoice.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idinvoice"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("invoiceEdit.aspx");
    }
}
