using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class childtableSingleRecord : System.Web.UI.Page
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
	txtidchildtable.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idchildtable"] != null)
        {
            int _idchildtable = int.Parse(Session["idchildtable"].ToString());
            txtidchildtable.Text = _idchildtable.ToString();
            if (_idchildtable > 0)
            {
                DB_childtable dm_cases = new DB_childtable();
                childtable _obj = new childtable();
                _obj = dm_cases.GetById(_idchildtable);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(childtable obj)
{
txtidchildtable.Text  = obj.IDCHILDTABLE;
txtid_maintable.Text  = obj.ID_MAINTABLE;
setComboBoxmaintable(obj.ID_MAINTABLE);
txtdescription.Text  = obj.DESCRIPTION;
}
    //setSingleRecord
public childtable GetSingleRecord_From_FormFields()
{
childtable obj = new childtable();
obj.IDCHILDTABLE = txtidchildtable.Text;
obj.ID_MAINTABLE = this.DropDownListmaintable.SelectedItem.Value;
obj.ID_MAINTABLE = txtid_maintable.Text;
obj.DESCRIPTION = txtdescription.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxmaintable(int _id)
    {
        int index = 0;
        DB_maintable dm_maintable = new DB_maintable(); //  
        List<maintable> listmaintable = (List<maintable>)dm_maintable.GetAll();
        this.DropDownListmaintable.DataSource = listmaintable;
        this.DropDownListmaintable.DataTextField = "description";
        this.DropDownListmaintable.DataValueField = "idmaintable";
        this.DropDownListmaintable.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listmaintable.Count; i++)
            {
                if (listmaintable[i].IDMAINTABLE == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListmaintable.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListmaintable.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListmaintable.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_childtable dm_cases = new DB_childtable();
        childtable _obj = new childtable();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidchildtable.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idchildtable"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("childtableEdit.aspx");
    }
}
