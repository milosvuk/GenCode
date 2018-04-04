using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class categorydocSingleRecord : System.Web.UI.Page
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
	txtidcategorydoc.Text = "0"; 
        if (Session["idcategorydoc"] != null)
        {
            int _idcategorydoc = int.Parse(Session["idcategorydoc"].ToString());
            txtidcategorydoc.Text = _idcategorydoc.ToString();
            if (_idcategorydoc > 0)
            {
                DB_categorydoc dm_cases = new DB_categorydoc();
                categorydoc _obj = new categorydoc();
                _obj = dm_cases.GetById(_idcategorydoc);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(categorydoc obj)
{
txtidCategory.Text  = obj.IDCATEGORY;
txtDescription.Text  = obj.DESCRIPTION;
txtActive.Text  = obj.ACTIVE;
}
    //setSingleRecord
public categorydoc GetSingleRecord_From_FormFields()
{
categorydoc obj = new categorydoc();
obj.IDCATEGORY = txtidCategory.Text;
obj.DESCRIPTION = txtDescription.Text;
obj.ACTIVE = txtActive.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_categorydoc dm_cases = new DB_categorydoc();
        categorydoc _obj = new categorydoc();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidcategorydoc.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idcategorydoc"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("categorydocEdit.aspx");
    }
}
