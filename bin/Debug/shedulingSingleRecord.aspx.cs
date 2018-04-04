using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class shedulingSingleRecord : System.Web.UI.Page
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
	txtidsheduling.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idsheduling"] != null)
        {
            int _idsheduling = int.Parse(Session["idsheduling"].ToString());
            txtidsheduling.Text = _idsheduling.ToString();
            if (_idsheduling > 0)
            {
                DB_sheduling dm_cases = new DB_sheduling();
                sheduling _obj = new sheduling();
                _obj = dm_cases.GetById(_idsheduling);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(sheduling obj)
{
txtidsheduling.Text  = obj.IDSHEDULING;
txtid_professional.Text  = obj.ID_PROFESSIONAL;
setComboBoxprofessional(obj.ID_PROFESSIONAL);
txtid_seniorcitizen.Text  = obj.ID_SENIORCITIZEN;
setComboBoxseniorcitizen(obj.ID_SENIORCITIZEN);
txtid_services.Text  = obj.ID_SERVICES;
setComboBoxservices(obj.ID_SERVICES);
txtdateofvisit.Text  = obj.DATEOFVISIT;
txttimeovisit.Text  = obj.TIMEOVISIT;
txttimeovisitdec.Text  = obj.TIMEOVISITDEC;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public sheduling GetSingleRecord_From_FormFields()
{
sheduling obj = new sheduling();
obj.IDSHEDULING = txtidsheduling.Text;
obj.ID_PROFESSIONAL = this.DropDownListprofessional.SelectedItem.Value;
obj.ID_PROFESSIONAL = txtid_professional.Text;
obj.ID_SENIORCITIZEN = this.DropDownListseniorcitizen.SelectedItem.Value;
obj.ID_SENIORCITIZEN = txtid_seniorcitizen.Text;
obj.ID_SERVICES = this.DropDownListservices.SelectedItem.Value;
obj.ID_SERVICES = txtid_services.Text;
obj.DATEOFVISIT = txtdateofvisit.Text;
obj.TIMEOVISIT = txttimeovisit.Text;
obj.TIMEOVISITDEC = txttimeovisitdec.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxprofessional(int _id)
    {
        int index = 0;
        DB_professional dm_professional = new DB_professional(); //  
        List<professional> listprofessional = (List<professional>)dm_professional.GetAll();
        this.DropDownListprofessional.DataSource = listprofessional;
        this.DropDownListprofessional.DataTextField = "description";
        this.DropDownListprofessional.DataValueField = "idprofessional";
        this.DropDownListprofessional.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listprofessional.Count; i++)
            {
                if (listprofessional[i].IDPROFESSIONAL == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListprofessional.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListprofessional.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListprofessional.SelectedItem.Value;
    }
private void setComboBoxseniorcitizen(int _id)
    {
        int index = 0;
        DB_seniorcitizen dm_seniorcitizen = new DB_seniorcitizen(); //  
        List<seniorcitizen> listseniorcitizen = (List<seniorcitizen>)dm_seniorcitizen.GetAll();
        this.DropDownListseniorcitizen.DataSource = listseniorcitizen;
        this.DropDownListseniorcitizen.DataTextField = "description";
        this.DropDownListseniorcitizen.DataValueField = "idseniorcitizen";
        this.DropDownListseniorcitizen.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listseniorcitizen.Count; i++)
            {
                if (listseniorcitizen[i].IDSENIORCITIZEN == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListseniorcitizen.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListseniorcitizen.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListseniorcitizen.SelectedItem.Value;
    }
private void setComboBoxservices(int _id)
    {
        int index = 0;
        DB_services dm_services = new DB_services(); //  
        List<services> listservices = (List<services>)dm_services.GetAll();
        this.DropDownListservices.DataSource = listservices;
        this.DropDownListservices.DataTextField = "description";
        this.DropDownListservices.DataValueField = "idservices";
        this.DropDownListservices.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listservices.Count; i++)
            {
                if (listservices[i].IDSERVICES == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListservices.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListservices.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListservices.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_sheduling dm_cases = new DB_sheduling();
        sheduling _obj = new sheduling();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidsheduling.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idsheduling"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("shedulingEdit.aspx");
    }
}
