using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class processdocumentsSingleRecord : System.Web.UI.Page
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
	txtidprocessdocuments.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idprocessdocuments"] != null)
        {
            int _idprocessdocuments = int.Parse(Session["idprocessdocuments"].ToString());
            txtidprocessdocuments.Text = _idprocessdocuments.ToString();
            if (_idprocessdocuments > 0)
            {
                DB_processdocuments dm_cases = new DB_processdocuments();
                processdocuments _obj = new processdocuments();
                _obj = dm_cases.GetById(_idprocessdocuments);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(processdocuments obj)
{
txtidprojectprocessdocuments.Text  = obj.IDPROJECTPROCESSDOCUMENTS;
txtid_process.Text  = obj.ID_PROCESS;
setComboBoxprocess(obj.ID_PROCESS);
txtid_documents.Text  = obj.ID_DOCUMENTS;
setComboBoxdocuments(obj.ID_DOCUMENTS);
txtid_company.Text  = obj.ID_COMPANY;
setComboBoxcompany(obj.ID_COMPANY);
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public processdocuments GetSingleRecord_From_FormFields()
{
processdocuments obj = new processdocuments();
obj.IDPROJECTPROCESSDOCUMENTS = txtidprojectprocessdocuments.Text;
obj.ID_PROCESS = this.DropDownListprocess.SelectedItem.Value;
obj.ID_PROCESS = txtid_process.Text;
obj.ID_DOCUMENTS = this.DropDownListdocuments.SelectedItem.Value;
obj.ID_DOCUMENTS = txtid_documents.Text;
obj.ID_COMPANY = this.DropDownListcompany.SelectedItem.Value;
obj.ID_COMPANY = txtid_company.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxprocess(int _id)
    {
        int index = 0;
        DB_process dm_process = new DB_process(); //  
        List<process> listprocess = (List<process>)dm_process.GetAll();
        this.DropDownListprocess.DataSource = listprocess;
        this.DropDownListprocess.DataTextField = "description";
        this.DropDownListprocess.DataValueField = "idprocess";
        this.DropDownListprocess.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listprocess.Count; i++)
            {
                if (listprocess[i].IDPROCESS == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListprocess.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListprocess.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListprocess.SelectedItem.Value;
    }
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
        DB_processdocuments dm_cases = new DB_processdocuments();
        processdocuments _obj = new processdocuments();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidprocessdocuments.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idprocessdocuments"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("processdocumentsEdit.aspx");
    }
}
