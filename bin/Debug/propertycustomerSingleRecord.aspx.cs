using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class propertycustomerSingleRecord : System.Web.UI.Page
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
	txtidpropertycustomer.Text = "0"; 
        if (Session["idpropertycustomer"] != null)
        {
            int _idpropertycustomer = int.Parse(Session["idpropertycustomer"].ToString());
            txtidpropertycustomer.Text = _idpropertycustomer.ToString();
            if (_idpropertycustomer > 0)
            {
                DB_propertycustomer dm_cases = new DB_propertycustomer();
                propertycustomer _obj = new propertycustomer();
                _obj = dm_cases.GetById(_idpropertycustomer);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(propertycustomer obj)
{
txtidPropertyCustomer.Text  = obj.IDPROPERTYCUSTOMER;
txtidProperty.Text  = obj.IDPROPERTY;
txtidCustomer.Text  = obj.IDCUSTOMER;
txtLeaseAgDateFrom.Text  = obj.LEASEAGDATEFROM;
txtLeaseAgDateTo.Text  = obj.LEASEAGDATETO;
txtidNotary.Text  = obj.IDNOTARY;
txtDateOfAg.Text  = obj.DATEOFAG;
txtFrenqOfPayment.Text  = obj.FRENQOFPAYMENT;
txtAmountOfContract.Text  = obj.AMOUNTOFCONTRACT;
txtIncreasePerc.Text  = obj.INCREASEPERC;
txtIncreaseAmount.Text  = obj.INCREASEAMOUNT;
txtIncreaseCostOfLiving.Text  = obj.INCREASECOSTOFLIVING;
txtFreqInDaysToApplyIncrease.Text  = obj.FREQINDAYSTOAPPLYINCREASE;
txtDateofLastinvoice.Text  = obj.DATEOFLASTINVOICE;
txtAmtOfLastInvoice.Text  = obj.AMTOFLASTINVOICE;
txtActive.Text  = obj.ACTIVE;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public propertycustomer GetSingleRecord_From_FormFields()
{
propertycustomer obj = new propertycustomer();
obj.IDPROPERTYCUSTOMER = txtidPropertyCustomer.Text;
obj.IDPROPERTY = txtidProperty.Text;
obj.IDCUSTOMER = txtidCustomer.Text;
obj.LEASEAGDATEFROM = txtLeaseAgDateFrom.Text;
obj.LEASEAGDATETO = txtLeaseAgDateTo.Text;
obj.IDNOTARY = txtidNotary.Text;
obj.DATEOFAG = txtDateOfAg.Text;
obj.FRENQOFPAYMENT = txtFrenqOfPayment.Text;
obj.AMOUNTOFCONTRACT = txtAmountOfContract.Text;
obj.INCREASEPERC = txtIncreasePerc.Text;
obj.INCREASEAMOUNT = txtIncreaseAmount.Text;
obj.INCREASECOSTOFLIVING = txtIncreaseCostOfLiving.Text;
obj.FREQINDAYSTOAPPLYINCREASE = txtFreqInDaysToApplyIncrease.Text;
obj.DATEOFLASTINVOICE = txtDateofLastinvoice.Text;
obj.AMTOFLASTINVOICE = txtAmtOfLastInvoice.Text;
obj.ACTIVE = txtActive.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_propertycustomer dm_cases = new DB_propertycustomer();
        propertycustomer _obj = new propertycustomer();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidpropertycustomer.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idpropertycustomer"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("propertycustomerEdit.aspx");
    }
}
