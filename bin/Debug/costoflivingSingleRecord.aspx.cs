using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class costoflivingSingleRecord : System.Web.UI.Page
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
	txtidcostofliving.Text = "0"; 
        if (Session["idcostofliving"] != null)
        {
            int _idcostofliving = int.Parse(Session["idcostofliving"].ToString());
            txtidcostofliving.Text = _idcostofliving.ToString();
            if (_idcostofliving > 0)
            {
                DB_costofliving dm_cases = new DB_costofliving();
                costofliving _obj = new costofliving();
                _obj = dm_cases.GetById(_idcostofliving);
                SetSingleRecord_To_FormFields(_obj);
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        save_record();
    }
public void SetSingleRecord_To_FormFields(costofliving obj)
{
txtidRecCostOfLiving.Text  = obj.IDRECCOSTOFLIVING;
txtIncreaseInPerc.Text  = obj.INCREASEINPERC;
txtStartDate.Text  = obj.STARTDATE;
txtActive.Text  = obj.ACTIVE;
txtidCompany.Text  = obj.IDCOMPANY;
}
    //setSingleRecord
public costofliving GetSingleRecord_From_FormFields()
{
costofliving obj = new costofliving();
obj.IDRECCOSTOFLIVING = txtidRecCostOfLiving.Text;
obj.INCREASEINPERC = txtIncreaseInPerc.Text;
obj.STARTDATE = txtStartDate.Text;
obj.ACTIVE = txtActive.Text;
obj.IDCOMPANY = txtidCompany.Text;
return obj;
}
    //getSingleRecord
    private void save_record()
    {
        DB_costofliving dm_cases = new DB_costofliving();
        costofliving _obj = new costofliving();
	 _obj = GetSingleRecord_From_FormFields();
        if (int.Parse(txtidcostofliving.Text) == 0)
        {
            dm_cases.Add(_obj);
        }
        else
        {
            dm_cases.Update(_obj);
            // update 
        }
	Session["idcostofliving"]  = "0";  // IT HAS TO CLASSNAME sesssion variable created in Global.aspx
        Session["Loggedin"] = Label2.Text;
        Response.Redirect("costoflivingEdit.aspx");
    }
}
