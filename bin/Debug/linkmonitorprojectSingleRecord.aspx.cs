using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class linkmonitorprojectSingleRecord : System.Web.UI.Page
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
	txtidlinkmonitorproject.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idlinkmonitorproject"] != null)
        {
            int _idlinkmonitorproject = int.Parse(Session["idlinkmonitorproject"].ToString());
            txtidlinkmonitorproject.Text = _idlinkmonitorproject.ToString();
            if (_idlinkmonitorproject > 0)
            {
                DB_linkmonitorproject dm_cases = new DB_linkmonitorproject();
                linkmonitorproject _obj = new linkmonitorproject();
                _obj = dm_cases.GetById(_idlinkmonitorproject);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(linkmonitorproject obj)
{
txtidlinkmonitorproject.Text  = obj.IDLINKMONITORPROJECT;
txtid_project.Text  = obj.ID_PROJECT;
setComboBoxproject(obj.ID_PROJECT);
txtid_monitorpoints.Text  = obj.ID_MONITORPOINTS;
setComboBoxmonitorpoints(obj.ID_MONITORPOINTS);
txtidcompamy.Text  = obj.IDCOMPAMY;
}
    //setSingleRecord
public linkmonitorproject GetSingleRecord_From_FormFields()
{
linkmonitorproject obj = new linkmonitorproject();
obj.IDLINKMONITORPROJECT = txtidlinkmonitorproject.Text;
obj.ID_PROJECT = this.DropDownListproject.SelectedItem.Value;
obj.ID_PROJECT = txtid_project.Text;
obj.ID_MONITORPOINTS = this.DropDownListmonitorpoints.SelectedItem.Value;
obj.ID_MONITORPOINTS = txtid_monitorpoints.Text;
obj.IDCOMPAMY = txtidcompamy.Text;
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
private void setComboBoxmonitorpoints(int _id)
    {
        int index = 0;
        DB_monitorpoints dm_monitorpoints = new DB_monitorpoints(); //  
        List<monitorpoints> listmonitorpoints = (List<monitorpoints>)dm_monitorpoints.GetAll();
        this.DropDownListmonitorpoints.DataSource = listmonitorpoints;
        this.DropDownListmonitorpoints.DataTextField = "description";
        this.DropDownListmonitorpoints.DataValueField = "idmonitorpoints";
        this.DropDownListmonitorpoints.DataBind();
        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listmonitorpoints.Count; i++)
            {
                if (listmonitorpoints[i].IDMONITORPOINTS == _id)
                {
                    index = i;
                    break;
                }
            }
            this.DropDownListmonitorpoints.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownListmonitorpoints.SelectedIndex = 0; // the first one 
        }
        // use string _id = this.DropDownListmonitorpoints.SelectedItem.Value;
    }
    //setComboBox
    private void save_record()
    {
        DB_linkmonitorproject dm_cases = new DB_linkmonitorproject();
        linkmonitorproject _obj = new linkmonitorproject();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidlinkmonitorproject.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idlinkmonitorproject"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("linkmonitorprojectEdit.aspx");
    }
}
