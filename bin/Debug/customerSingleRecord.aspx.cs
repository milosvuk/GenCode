using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class customerSingleRecord : System.Web.UI.Page
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
	txtidcustomer.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idcustomer"] != null)
        {
            int _idcustomer = int.Parse(Session["idcustomer"].ToString());
            txtidcustomer.Text = _idcustomer.ToString();
            if (_idcustomer > 0)
            {
                DB_customer dm_cases = new DB_customer();
                customer _obj = new customer();
                _obj = dm_cases.GetById(_idcustomer);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(customer obj)
{
txtidcustomer.Text  = obj.IDCUSTOMER;
txtcustomerid.Text  = obj.CUSTOMERID;
txtcustomersid.Text  = obj.CUSTOMERSID;
txtnameOfCustomer.Text  = obj.NAMEOFCUSTOMER;
txtsurnameOfCustomer.Text  = obj.SURNAMEOFCUSTOMER;
txtaddressOfCustomer.Text  = obj.ADDRESSOFCUSTOMER;
txtcityofCustomer.Text  = obj.CITYOFCUSTOMER;
txtcountryOfCustomer.Text  = obj.COUNTRYOFCUSTOMER;
txtid_company.Text  = obj.ID_COMPANY;
setComboBoxcompany(obj.ID_COMPANY);
}
    //setSingleRecord
public customer GetSingleRecord_From_FormFields()
{
customer obj = new customer();
obj.IDCUSTOMER = txtidcustomer.Text;
obj.CUSTOMERID = txtcustomerid.Text;
obj.CUSTOMERSID = txtcustomersid.Text;
obj.NAMEOFCUSTOMER = txtnameOfCustomer.Text;
obj.SURNAMEOFCUSTOMER = txtsurnameOfCustomer.Text;
obj.ADDRESSOFCUSTOMER = txtaddressOfCustomer.Text;
obj.CITYOFCUSTOMER = txtcityofCustomer.Text;
obj.COUNTRYOFCUSTOMER = txtcountryOfCustomer.Text;
obj.ID_COMPANY = this.DropDownListcompany.SelectedItem.Value;
obj.ID_COMPANY = txtid_company.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxcompany(int _id)
    {
        int index = 0;
        DB_company dm_company = new DB_company(); //  
        List<company> listcompany = (List<company>)dm_company.GetAll();
        this.DropDownListcompany.DataSource = listcompany;
        this.DropDownListcompany.DataTextField = "description";
        this.DropDownListcompany.DataValueField = "idcompany";
        this.DropDownListcompany.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listcompany.Count; i++)
            {
                if (listcompany[i].IDCOMPANY == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListcompany.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListcompany.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListcompany.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_customer dm_cases = new DB_customer();
        customer _obj = new customer();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidcustomer.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idcustomer"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("customerEdit.aspx");
    }
}
