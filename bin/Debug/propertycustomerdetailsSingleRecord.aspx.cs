using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class propertycustomerdetailsSingleRecord : System.Web.UI.Page
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
	txtidpropertycustomerdetails.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idpropertycustomerdetails"] != null)
        {
            int _idpropertycustomerdetails = int.Parse(Session["idpropertycustomerdetails"].ToString());
            txtidpropertycustomerdetails.Text = _idpropertycustomerdetails.ToString();
            if (_idpropertycustomerdetails > 0)
            {
                DB_propertycustomerdetails dm_cases = new DB_propertycustomerdetails();
                propertycustomerdetails _obj = new propertycustomerdetails();
                _obj = dm_cases.GetById(_idpropertycustomerdetails);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(propertycustomerdetails obj)
{
txtidpropertcustomerdetails.Text  = obj.IDPROPERTCUSTOMERDETAILS;
txtid_propertycustomer.Text  = obj.ID_PROPERTYCUSTOMER;
setComboBoxpropertycustomer(obj.ID_PROPERTYCUSTOMER);
txtdatefrom.Text  = obj.DATEFROM;
txtdateto.Text  = obj.DATETO;
txtnumberofdaystocreateinvoice.Text  = obj.NUMBEROFDAYSTOCREATEINVOICE;
txtamountforthatperiod.Text  = obj.AMOUNTFORTHATPERIOD;
txtamountpereachinvoice.Text  = obj.AMOUNTPEREACHINVOICE;
txtdescription.Text  = obj.DESCRIPTION;
txtnumberofinvoicestogenerate.Text  = obj.NUMBEROFINVOICESTOGENERATE;
txtgeneratedinvoicesfromthis.Text  = obj.GENERATEDINVOICESFROMTHIS;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public propertycustomerdetails GetSingleRecord_From_FormFields()
{
propertycustomerdetails obj = new propertycustomerdetails();
obj.IDPROPERTCUSTOMERDETAILS = txtidpropertcustomerdetails.Text;
obj.ID_PROPERTYCUSTOMER = this.DropDownListpropertycustomer.SelectedItem.Value;
obj.ID_PROPERTYCUSTOMER = txtid_propertycustomer.Text;
obj.DATEFROM = txtdatefrom.Text;
obj.DATETO = txtdateto.Text;
obj.NUMBEROFDAYSTOCREATEINVOICE = txtnumberofdaystocreateinvoice.Text;
obj.AMOUNTFORTHATPERIOD = txtamountforthatperiod.Text;
obj.AMOUNTPEREACHINVOICE = txtamountpereachinvoice.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.NUMBEROFINVOICESTOGENERATE = txtnumberofinvoicestogenerate.Text;
obj.GENERATEDINVOICESFROMTHIS = txtgeneratedinvoicesfromthis.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxpropertycustomer(int _id)
    {
        int index = 0;
        DB_propertycustomer dm_propertycustomer = new DB_propertycustomer(); //  
        List<propertycustomer> listpropertycustomer = (List<propertycustomer>)dm_propertycustomer.GetAll();
        this.DropDownListpropertycustomer.DataSource = listpropertycustomer;
        this.DropDownListpropertycustomer.DataTextField = "description";
        this.DropDownListpropertycustomer.DataValueField = "idpropertycustomer";
        this.DropDownListpropertycustomer.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listpropertycustomer.Count; i++)
            {
                if (listpropertycustomer[i].IDPROPERTYCUSTOMER == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListpropertycustomer.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListpropertycustomer.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListpropertycustomer.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_propertycustomerdetails dm_cases = new DB_propertycustomerdetails();
        propertycustomerdetails _obj = new propertycustomerdetails();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidpropertycustomerdetails.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idpropertycustomerdetails"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("propertycustomerdetailsEdit.aspx");
    }
}
