using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class processingdataSingleRecord : System.Web.UI.Page
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
	txtidprocessingdata.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idprocessingdata"] != null)
        {
            int _idprocessingdata = int.Parse(Session["idprocessingdata"].ToString());
            txtidprocessingdata.Text = _idprocessingdata.ToString();
            if (_idprocessingdata > 0)
            {
                DB_processingdata dm_cases = new DB_processingdata();
                processingdata _obj = new processingdata();
                _obj = dm_cases.GetById(_idprocessingdata);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(processingdata obj)
{
txtidprocessing.Text  = obj.IDPROCESSING;
txtid_objclasses.Text  = obj.ID_OBJCLASSES;
setComboBoxobjclasses(obj.ID_OBJCLASSES);
txttypeandname.Text  = obj.TYPEANDNAME;
txtruleswithaction.Text  = obj.RULESWITHACTION;
txtidcompany.Text  = obj.IDCOMPANY;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public processingdata GetSingleRecord_From_FormFields()
{
processingdata obj = new processingdata();
obj.IDPROCESSING = txtidprocessing.Text;
obj.ID_OBJCLASSES = this.DropDownListobjclasses.SelectedItem.Value;
obj.ID_OBJCLASSES = txtid_objclasses.Text;
obj.TYPEANDNAME = txttypeandname.Text;
obj.RULESWITHACTION = txtruleswithaction.Text;
obj.IDCOMPANY = txtidcompany.Text;
obj.ACTIVE = txtactive.Text;
return obj;
}
    //getSingleRecord
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
        DB_processingdata dm_cases = new DB_processingdata();
        processingdata _obj = new processingdata();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidprocessingdata.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idprocessingdata"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("processingdataEdit.aspx");
    }
}
