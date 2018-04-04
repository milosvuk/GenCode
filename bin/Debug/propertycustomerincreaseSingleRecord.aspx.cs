using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class propertycustomerincreaseSingleRecord : System.Web.UI.Page
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
	txtidpropertycustomerincrease.Text = "0"; 
        if (Session["idpropertycustomerincrease"] != null)
        {
            int _idpropertycustomerincrease = int.Parse(Session["idpropertycustomerincrease"].ToString());
            txtidpropertycustomerincrease.Text = _idpropertycustomerincrease.ToString();
            if (_idpropertycustomerincrease > 0)
            {
                DB_propertycustomerincrease dm_cases = new DB_propertycustomerincrease();
                propertycustomerincrease _obj = new propertycustomerincrease();
                _obj = dm_cases.GetById(_idpropertycustomerincrease);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(propertycustomerincrease obj)
{
txtidPropertyCustomerincrease.Text  = obj.IDPROPERTYCUSTOMERINCREASE;
txtidPropertyCustomer.Text  = obj.IDPROPERTYCUSTOMER;
txtDateFrom.Text  = obj.DATEFROM;
txtDateTo.Text  = obj.DATETO;
txtIncreasePerc.Text  = obj.INCREASEPERC;
txtIncreaseAmount.Text  = obj.INCREASEAMOUNT;
txtActive.Text  = obj.ACTIVE;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public propertycustomerincrease GetSingleRecord_From_FormFields()
{
propertycustomerincrease obj = new propertycustomerincrease();
obj.IDPROPERTYCUSTOMERINCREASE = txtidPropertyCustomerincrease.Text;
obj.IDPROPERTYCUSTOMER = txtidPropertyCustomer.Text;
obj.DATEFROM = txtDateFrom.Text;
obj.DATETO = txtDateTo.Text;
obj.INCREASEPERC = txtIncreasePerc.Text;
obj.INCREASEAMOUNT = txtIncreaseAmount.Text;
obj.ACTIVE = txtActive.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_propertycustomerincrease dm_cases = new DB_propertycustomerincrease();
        propertycustomerincrease _obj = new propertycustomerincrease();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidpropertycustomerincrease.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idpropertycustomerincrease"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("propertycustomerincreaseEdit.aspx");
    }
}
