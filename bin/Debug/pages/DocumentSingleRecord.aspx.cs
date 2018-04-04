using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DocumentSingleRecord : System.Web.UI.Page
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



        if (Session["idRecDocument"] != null)
        {

            int _id = int.Parse(Session["idRecDocument"].ToString());
            txtidRecDocument.Text = _id.ToString();


            if (_id > 0)
            {
                DB_documentsb dbdocumentsb = new DB_documentsb();
                documentsb _obj = new documentsb();
                _obj = dbdocumentsb.GetById(_id);
                setSingleRecord_To_FormFields(_obj);
                // Here to find the values for each from 
                SetComboBox(_obj.IDPROPERTY);
                txtTypeOfDoc.Visible = true;

                Calendar1.VisibleDate = new DateTime(_obj.DATEOFDOC.Year, _obj.DATEOFDOC.Month, 1);
                Calendar1.SelectedDate = _obj.DATEOFDOC;
            }
            else
            {
                if (Session["idRecProperty"] != null)
                {

                    int _idProperty = int.Parse(Session["idRecProperty"].ToString());

                    if (_idProperty > 0)
                    {
                        SetComboBox(_idProperty);
                    }
                    else
                    {
                        SetComboBox(0);
                    }
                }
                

                //SetComboBox(0);
                // new
                txtTypeOfDoc.Visible = false;
            }

        }
        


        

        
    }

    public void setSingleRecord_To_FormFields(documentsb obj)
    {
        txtidRecDocument.Text = obj.IDRECDOCUMENT.ToString();
        txtidProperty.Text = obj.IDPROPERTY.ToString();
        txtDescription.Text = obj.DESCRIPTION;
        txtTypeOfDoc.Text = obj.TYPEOFDOC;
        txtdateofDoc.Text = obj.DATEOFDOC.Date.ToString("dd/MM/yyyy");
        //txtDocInBinFormat.Text = obj.DOCINBINFORMAT;
        txtKeyword1.Text = obj.KEYWORD1;
        txtKeyword2.Text = obj.KEYWORD2;
        txtKeyword3.Text = obj.KEYWORD3;
        txtIdCompany.Text = obj.IDCOMPANY.ToString();
    }

    public documentsb getSingleRecord_From_FormFields()
    {
        documentsb obj = new documentsb();
        obj.IDRECDOCUMENT = int.Parse(txtidRecDocument.Text);

        obj.IDPROPERTY = int.Parse(this.DropDownList1.SelectedItem.Value);
        obj.DESCRIPTION = txtDescription.Text;

        //obj.DATEOFDOC = Calendar1.SelectedDate;

        if (txtdateofDoc.Text.CompareTo("") == 0)
        {
            obj.DATEOFDOC = Calendar1.SelectedDate;
        }
        else
        {
            obj.DATEOFDOC = DateTime.Parse(txtdateofDoc.Text);
        }

        //obj.TYPEOFDOC = tmArray[1];
        obj.TYPEOFDOC = this.FileUpload1.FileName;
        obj.DOCINBINFORMAT = this.FileUpload1.FileBytes;
        obj.KEYWORD1 = txtKeyword1.Text;
        obj.KEYWORD2 = txtKeyword2.Text;
        obj.KEYWORD3 = txtKeyword3.Text;
        obj.IDCOMPANY = 1;
        //obj.IDCOMPANY = int.Parse(txtIdCompany.Text);
        return obj;
    }


    private void SetComboBox(int _id)
    {
        int index = 0;
        DB_property dm_property = new DB_property(); //  

        List<property> listproperty = (List<property>)dm_property.GetAll();

        this.DropDownList1.DataSource = listproperty;
        this.DropDownList1.DataTextField = "Description";
        this.DropDownList1.DataValueField = "idRecProperty";
        this.DropDownList1.DataBind();

        if (_id > 0)
        {
            // going thrue  the ID which is 
            for (int i = 0; i < listproperty.Count; i++)
            {
                if (listproperty[i].IDRECPROPERTY == _id)
                {
                    index = i;
                    break;
                }
            }

            this.DropDownList1.SelectedIndex = index; // the first one 
        }
        else
        {
            this.DropDownList1.SelectedIndex = 0; // the first one 
        }

        // use string _id = this.DropDownList1.SelectedItem.Value;
    }


    protected void btnSave_Click(object sender, EventArgs e)
    {

        DB_documentsb dbdoc = new DB_documentsb();
        documentsb _obj = getSingleRecord_From_FormFields();

        if (_obj.IDRECDOCUMENT == 0)
        {
            dbdoc.Add(_obj);
        }
        else
        {
            dbdoc.Update(_obj);
        }

        Session["Loggedin"] = Label2.Text;
        Response.Redirect("DocumentRecordsEdit.aspx");
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
      //  txtdateofDoc.Text = Calendar1.SelectedDate.Date.ToString("dd/MM/yyyy");
    }
}