using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class servicesSingleRecord : System.Web.UI.Page
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
	txtidservices.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idservices"] != null)
        {
            int _idservices = int.Parse(Session["idservices"].ToString());
            txtidservices.Text = _idservices.ToString();
            if (_idservices > 0)
            {
                DB_services dm_cases = new DB_services();
                services _obj = new services();
                _obj = dm_cases.GetById(_idservices);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(services obj)
{
txtidservices.Text  = obj.IDSERVICES;
txtName.Text  = obj.NAME;
txtDescription.Text  = obj.DESCRIPTION;
txtactive.Text  = obj.ACTIVE;
txtid_company.Text  = obj.ID_COMPANY;
setComboBoxcompany(obj.ID_COMPANY);
}
    //setSingleRecord
public services GetSingleRecord_From_FormFields()
{
services obj = new services();
obj.IDSERVICES = txtidservices.Text;
obj.NAME = txtName.Text;
obj.DESCRIPTION = txtDescription.Text;
obj.ACTIVE = txtactive.Text;
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
        DB_services dm_cases = new DB_services();
        services _obj = new services();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidservices.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idservices"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("servicesEdit.aspx");
    }
}
