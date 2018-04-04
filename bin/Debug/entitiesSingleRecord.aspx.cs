using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class entitiesSingleRecord : System.Web.UI.Page
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
	txtidentities.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["identities"] != null)
        {
            int _identities = int.Parse(Session["identities"].ToString());
            txtidentities.Text = _identities.ToString();
            if (_identities > 0)
            {
                DB_entities dm_cases = new DB_entities();
                entities _obj = new entities();
                _obj = dm_cases.GetById(_identities);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(entities obj)
{
txtidentities.Text  = obj.IDENTITIES;
txtname.Text  = obj.NAME;
txtdescription.Text  = obj.DESCRIPTION;
txtactive.Text  = obj.ACTIVE;
txtid_comany.Text  = obj.ID_COMANY;
setComboBoxcomany(obj.ID_COMANY);
}
    //setSingleRecord
public entities GetSingleRecord_From_FormFields()
{
entities obj = new entities();
obj.IDENTITIES = txtidentities.Text;
obj.NAME = txtname.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.ACTIVE = txtactive.Text;
obj.ID_COMANY = this.DropDownListcomany.SelectedItem.Value;
obj.ID_COMANY = txtid_comany.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxcomany(int _id)
    {
        int index = 0;
        DB_comany dm_comany = new DB_comany(); //  
        List<comany> listcomany = (List<comany>)dm_comany.GetAll();
        this.DropDownListcomany.DataSource = listcomany;
        this.DropDownListcomany.DataTextField = "description";
        this.DropDownListcomany.DataValueField = "idcomany";
        this.DropDownListcomany.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listcomany.Count; i++)
            {
                if (listcomany[i].IDCOMANY == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListcomany.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListcomany.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListcomany.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_entities dm_cases = new DB_entities();
        entities _obj = new entities();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidentities.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["identities"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("entitiesEdit.aspx");
    }
}
