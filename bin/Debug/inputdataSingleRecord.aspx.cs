using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class inputdataSingleRecord : System.Web.UI.Page
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
	txtidinputdata.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idinputdata"] != null)
        {
            int _idinputdata = int.Parse(Session["idinputdata"].ToString());
            txtidinputdata.Text = _idinputdata.ToString();
            if (_idinputdata > 0)
            {
                DB_inputdata dm_cases = new DB_inputdata();
                inputdata _obj = new inputdata();
                _obj = dm_cases.GetById(_idinputdata);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(inputdata obj)
{
txtidinput.Text  = obj.IDINPUT;
txtid_objclasses.Text  = obj.ID_OBJCLASSES;
setComboBoxobjclasses(obj.ID_OBJCLASSES);
txttypeandname.Text  = obj.TYPEANDNAME;
txtruleswithaction.Text  = obj.RULESWITHACTION;
txtidcompany.Text  = obj.IDCOMPANY;
txtactive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public inputdata GetSingleRecord_From_FormFields()
{
inputdata obj = new inputdata();
obj.IDINPUT = txtidinput.Text;
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
        DB_inputdata dm_cases = new DB_inputdata();
        inputdata _obj = new inputdata();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidinputdata.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idinputdata"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("inputdataEdit.aspx");
    }
}
