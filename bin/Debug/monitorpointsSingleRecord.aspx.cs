using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class monitorpointsSingleRecord : System.Web.UI.Page
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
	txtidmonitorpoints.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idmonitorpoints"] != null)
        {
            int _idmonitorpoints = int.Parse(Session["idmonitorpoints"].ToString());
            txtidmonitorpoints.Text = _idmonitorpoints.ToString();
            if (_idmonitorpoints > 0)
            {
                DB_monitorpoints dm_cases = new DB_monitorpoints();
                monitorpoints _obj = new monitorpoints();
                _obj = dm_cases.GetById(_idmonitorpoints);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(monitorpoints obj)
{
txtidmonitorpoints.Text  = obj.IDMONITORPOINTS;
txtdescription.Text  = obj.DESCRIPTION;
txtimplication.Text  = obj.IMPLICATION;
txtresolution.Text  = obj.RESOLUTION;
txtstatus.Text  = obj.STATUS;
txtidcompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public monitorpoints GetSingleRecord_From_FormFields()
{
monitorpoints obj = new monitorpoints();
obj.IDMONITORPOINTS = txtidmonitorpoints.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.IMPLICATION = txtimplication.Text;
obj.RESOLUTION = txtresolution.Text;
obj.STATUS = txtstatus.Text;
obj.IDCOMPANY = txtidcompany.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_monitorpoints dm_cases = new DB_monitorpoints();
        monitorpoints _obj = new monitorpoints();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidmonitorpoints.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idmonitorpoints"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("monitorpointsEdit.aspx");
    }
}
