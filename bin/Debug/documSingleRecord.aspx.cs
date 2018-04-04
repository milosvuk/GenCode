using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class documSingleRecord : System.Web.UI.Page
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
	txtiddocum.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["iddocum"] != null)
        {
            int _iddocum = int.Parse(Session["iddocum"].ToString());
            txtiddocum.Text = _iddocum.ToString();
            if (_iddocum > 0)
            {
                DB_docum dm_cases = new DB_docum();
                docum _obj = new docum();
                _obj = dm_cases.GetById(_iddocum);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(docum obj)
{
txtiddocument.Text  = obj.IDDOCUMENT;
txtcodeofdocument.Text  = obj.CODEOFDOCUMENT;
txtnameofdocuments.Text  = obj.NAMEOFDOCUMENTS;
txtidcompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public docum GetSingleRecord_From_FormFields()
{
docum obj = new docum();
obj.IDDOCUMENT = txtiddocument.Text;
obj.CODEOFDOCUMENT = txtcodeofdocument.Text;
obj.NAMEOFDOCUMENTS = txtnameofdocuments.Text;
obj.IDCOMPANY = txtidcompany.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_docum dm_cases = new DB_docum();
        docum _obj = new docum();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtiddocum.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["iddocum"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("documEdit.aspx");
    }
}
