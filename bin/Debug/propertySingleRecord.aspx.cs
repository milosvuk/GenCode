using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class propertySingleRecord : System.Web.UI.Page
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
	txtidproperty.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idproperty"] != null)
        {
            int _idproperty = int.Parse(Session["idproperty"].ToString());
            txtidproperty.Text = _idproperty.ToString();
            if (_idproperty > 0)
            {
                DB_property dm_cases = new DB_property();
                property _obj = new property();
                _obj = dm_cases.GetById(_idproperty);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(property obj)
{
txtidproperty.Text  = obj.IDPROPERTY;
txtname.Text  = obj.NAME;
txtdescription.Text  = obj.DESCRIPTION;
txtid_documents.Text  = obj.ID_DOCUMENTS;
setComboBoxdocuments(obj.ID_DOCUMENTS);
txtentitiesyesno.Text  = obj.ENTITIESYESNO;
txtid_company.Text  = obj.ID_COMPANY;
setComboBoxcompany(obj.ID_COMPANY);
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public property GetSingleRecord_From_FormFields()
{
property obj = new property();
obj.IDPROPERTY = txtidproperty.Text;
obj.NAME = txtname.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.ID_DOCUMENTS = this.DropDownListdocuments.SelectedItem.Value;
obj.ID_DOCUMENTS = txtid_documents.Text;
obj.ENTITIESYESNO = txtentitiesyesno.Text;
obj.ID_COMPANY = this.DropDownListcompany.SelectedItem.Value;
obj.ID_COMPANY = txtid_company.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxdocuments(int _id)
    {
        int index = 0;
        DB_documents dm_documents = new DB_documents(); //  
        List<documents> listdocuments = (List<documents>)dm_documents.GetAll();
        this.DropDownListdocuments.DataSource = listdocuments;
        this.DropDownListdocuments.DataTextField = "description";
        this.DropDownListdocuments.DataValueField = "iddocuments";
        this.DropDownListdocuments.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listdocuments.Count; i++)
            {
                if (listdocuments[i].IDDOCUMENTS == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListdocuments.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListdocuments.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListdocuments.SelectedItem.Value;
    }
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
        DB_property dm_cases = new DB_property();
        property _obj = new property();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidproperty.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idproperty"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("propertyEdit.aspx");
    }
}
