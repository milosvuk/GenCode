using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class projectclassSingleRecord : System.Web.UI.Page
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
	txtidprojectclass.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idprojectclass"] != null)
        {
            int _idprojectclass = int.Parse(Session["idprojectclass"].ToString());
            txtidprojectclass.Text = _idprojectclass.ToString();
            if (_idprojectclass > 0)
            {
                DB_projectclass dm_cases = new DB_projectclass();
                projectclass _obj = new projectclass();
                _obj = dm_cases.GetById(_idprojectclass);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(projectclass obj)
{
txtidprojectclass.Text  = obj.IDPROJECTCLASS;
txtid_project.Text  = obj.ID_PROJECT;
setComboBoxproject(obj.ID_PROJECT);
txtid_objclasses.Text  = obj.ID_OBJCLASSES;
setComboBoxobjclasses(obj.ID_OBJCLASSES);
txtidcompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public projectclass GetSingleRecord_From_FormFields()
{
projectclass obj = new projectclass();
obj.IDPROJECTCLASS = txtidprojectclass.Text;
obj.ID_PROJECT = this.DropDownListproject.SelectedItem.Value;
obj.ID_PROJECT = txtid_project.Text;
obj.ID_OBJCLASSES = this.DropDownListobjclasses.SelectedItem.Value;
obj.ID_OBJCLASSES = txtid_objclasses.Text;
obj.IDCOMPANY = txtidcompany.Text;
return obj;
}
    //getSingleRecord
private void setComboBoxproject(int _id)
    {
        int index = 0;
        DB_project dm_project = new DB_project(); //  
        List<project> listproject = (List<project>)dm_project.GetAll();
        this.DropDownListproject.DataSource = listproject;
        this.DropDownListproject.DataTextField = "description";
        this.DropDownListproject.DataValueField = "idproject";
        this.DropDownListproject.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listproject.Count; i++)
            {
                if (listproject[i].IDPROJECT == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListproject.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListproject.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListproject.SelectedItem.Value;
    }
private void setComboBoxobjclasses(int _id)
    {
        int index = 0;
        DB_objclasses dm_objclasses = new DB_objclasses(); //  
        List<objclasses> listobjclasses = (List<objclasses>)dm_objclasses.GetAll();
        this.DropDownListobjclasses.DataSource = listobjclasses;
        this.DropDownListobjclasses.DataTextField = "description";
        this.DropDownListobjclasses.DataValueField = "idobjclasses";
        this.DropDownListobjclasses.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listobjclasses.Count; i++)
            {
                if (listobjclasses[i].IDOBJCLASSES == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListobjclasses.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListobjclasses.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListobjclasses.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_projectclass dm_cases = new DB_projectclass();
        projectclass _obj = new projectclass();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidprojectclass.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idprojectclass"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("projectclassEdit.aspx");
    }
}
