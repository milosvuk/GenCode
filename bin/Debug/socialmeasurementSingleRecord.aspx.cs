using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class socialmeasurementSingleRecord : System.Web.UI.Page
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
	txtidsocialmeasurement.Text = "0"; 
        // here add ComboBox(0) for all drop boxes
        if (Session["idsocialmeasurement"] != null)
        {
            int _idsocialmeasurement = int.Parse(Session["idsocialmeasurement"].ToString());
            txtidsocialmeasurement.Text = _idsocialmeasurement.ToString();
            if (_idsocialmeasurement > 0)
            {
                DB_socialmeasurement dm_cases = new DB_socialmeasurement();
                socialmeasurement _obj = new socialmeasurement();
                _obj = dm_cases.GetById(_idsocialmeasurement);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(socialmeasurement obj)
{
txtidmeasurement.Text  = obj.IDMEASUREMENT;
txtcodeoflocation.Text  = obj.CODEOFLOCATION;
txtdateofmeasurement.Text  = obj.DATEOFMEASUREMENT;
txtcodeofindicator.Text  = obj.CODEOFINDICATOR;
txtvalueofmeasurement.Text  = obj.VALUEOFMEASUREMENT;
txtdescription.Text  = obj.DESCRIPTION;
txtweekm.Text  = obj.WEEKM;
txtmonthm.Text  = obj.MONTHM;
txtyearm.Text  = obj.YEARM;
txtidcustomer.Text  = obj.IDCUSTOMER;
}
    //setSingleRecord
public socialmeasurement GetSingleRecord_From_FormFields()
{
socialmeasurement obj = new socialmeasurement();
obj.IDMEASUREMENT = txtidmeasurement.Text;
obj.CODEOFLOCATION = txtcodeoflocation.Text;
obj.DATEOFMEASUREMENT = txtdateofmeasurement.Text;
obj.CODEOFINDICATOR = txtcodeofindicator.Text;
obj.VALUEOFMEASUREMENT = txtvalueofmeasurement.Text;
obj.DESCRIPTION = txtdescription.Text;
obj.WEEKM = txtweekm.Text;
obj.MONTHM = txtmonthm.Text;
obj.YEARM = txtyearm.Text;
obj.IDCUSTOMER = txtidcustomer.Text;
return obj;
}
    //getSingleRecord
    //setComboBox
    private void save_record()
    {
        DB_socialmeasurement dm_cases = new DB_socialmeasurement();
        socialmeasurement _obj = new socialmeasurement();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidsocialmeasurement.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idsocialmeasurement"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("socialmeasurementEdit.aspx");
    }
}
