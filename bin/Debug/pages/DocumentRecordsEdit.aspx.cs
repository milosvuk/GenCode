using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DocumentRecordsEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            set_login();
            

            if (Session["idRecProperty"] != null)
            {
                int _idProperty = int.Parse(Session["idRecProperty"].ToString());
                SetComboBox(_idProperty);
                CheckBox1.Checked = false;
                string crit = "idProperty=" + _idProperty;
                lblFilter.Text = "All Documents for Property=" + this.DropDownList1.SelectedItem.Text;
                set_grid(crit);
            }
            else
            {
                set_grid("1=1");
                SetComboBox(0);
            }
           // CheckBox1.Checked = true;
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


    private void set_grid(string crit)
    {

        DB_documentsb dm_documentsb = new DB_documentsb();

        List<documentsb> listdocumentsb = (List<documentsb>)dm_documentsb.GetAllByCond(crit);
        //List<documentsb> listdocumentsb = (List<documentsb>)dm_documentsb.GetAllByCond(crit);

        this.GridView1.DataSource = listdocumentsb;
        this.GridView1.DataBind();

        this.ListBox1.DataSource = listdocumentsb;
        this.ListBox1.DataTextField = "idRecDocument";
        this.ListBox1.DataValueField = "idRecDocument";
        this.ListBox1.DataBind();

        this.ListBox2.DataSource = listdocumentsb;
        this.ListBox2.DataTextField = "TypeOfDoc";
        this.ListBox2.DataValueField = "TypeOfDoc";
        this.ListBox2.DataBind();
    }

    private void set_gridDesc(string crit)
    {

        DB_documentsb dm_documentsb = new DB_documentsb();

        List<documentsb> listdocumentsb = (List<documentsb>)dm_documentsb.GetAllByCondDesc(crit);
        //List<documentsb> listdocumentsb = (List<documentsb>)dm_documentsb.GetAllByCond(crit);

        this.GridView1.DataSource = listdocumentsb;
        this.GridView1.DataBind();

        this.ListBox1.DataSource = listdocumentsb;
        this.ListBox1.DataTextField = "idRecDocument";
        this.ListBox1.DataValueField = "idRecDocument";
        this.ListBox1.DataBind();

        this.ListBox2.DataSource = listdocumentsb;
        this.ListBox2.DataTextField = "TypeOfDoc";
        this.ListBox2.DataValueField = "TypeOfDoc";
        this.ListBox2.DataBind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        int n = e.NewEditIndex;
        e.Cancel = true;
        this.ListBox1.SelectedIndex = n;
        this.ListBox2.SelectedIndex = n;
        string mpage = this.ListBox1.SelectedItem.Value;
        this.lblTypeDoc.Text = n.ToString() + " " + ListBox1.SelectedItem.Value + " " + this.ListBox2.SelectedItem.Value; ;
        //string mpage = this.GridView1.Rows[n].Cells[1].Text;
        Session["Loggedin"] = Label2.Text;
        Session["IdRecDocument"] = mpage;


        // here is it image
        // doc
        // pdf
         Response.Redirect("DocumentSingleRecord.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int n = e.RowIndex;
        e.Cancel = true;
        this.ListBox1.SelectedIndex = n;
        this.ListBox2.SelectedIndex = n;
        string mpage = this.ListBox1.SelectedItem.Value;
        this.lblTypeDoc.Text = n.ToString() + " " + this.ListBox1.SelectedItem.Value + " " + this.ListBox2.SelectedItem.Value; ;
        //string mpage = this.GridView1.Rows[n].Cells[1].Text;
        Session["Loggedin"] = Label2.Text;
        Session["IdRecDocument"] = mpage;
        // here is it image
        // doc
        // pdf
        // idRecDoc

        

        string tm = this.ListBox2.SelectedItem.Value;
        string[] tmArray = tm.Split('.');
        string compareToType = tmArray[1].ToUpper();

        if (compareToType.CompareTo("PDF")==0)
        {
            // pdf document
            Response.Redirect("Handler2.ashx?idRecDoc=" + mpage); // pdf
        }

        if (compareToType.CompareTo("DOC") == 0 || compareToType.CompareTo("DOCX") == 0)
        {
            // word document
            Response.Redirect("HandlerDoc.ashx?DocForm=" + mpage);  // word doc
        }

        if (compareToType.CompareTo("JPG") == 0 || compareToType.CompareTo("JPEG") == 0)
        {
            // word document
            Response.Redirect("HandlerJpg.ashx?idRecDoc=" + mpage);  // word doc
        }

        // // Response.Redirect("Handler2.ashx?idRecDoc=" + mpage); // pdf
       // 
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
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Session["Loggedin"] = Label2.Text;
        Session["IdRecDocument"] = "0";
        Response.Redirect("DocumentSingleRecord.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        setFilter();
    }

    private void setFilter()
    {
        string crit = "";

        string apostrof = @"'";
        string percentage = @"%";

        string descfilter = "";

        if (txtDesc.Text.CompareTo("") == 0)
        {
            // do not 
        }
        else
        {
            //descfilter = " And Description like " + apostrof + txtDesc.Text + percentage + apostrof;
        }

        if (txtBoxKeyword.Text.CompareTo("") == 0 && CheckBox1.Checked == true)
        {
            crit = "1=1";
            lblFilter.Text = "All Documents";
        }

        if (txtBoxKeyword.Text.CompareTo("") != 0 && CheckBox1.Checked == true)
        {
            // all documents with keywords 
            // Keyword1 like '%court%' or Keyword2 like '%court%' or Keyword3 like '%court%'

            crit = " Keyword1 like " + apostrof + percentage + txtBoxKeyword.Text + percentage + apostrof;
            crit = crit + " Or Keyword2 like " + apostrof + percentage + txtBoxKeyword.Text + percentage + apostrof;
            crit = crit + " Or Keyword3 like " + apostrof + percentage + txtBoxKeyword.Text + percentage + apostrof;

           // crit = crit + descfilter;

            lblFilter.Text = "All Documents for keyword=" + txtBoxKeyword.Text;
        }

        if (txtBoxKeyword.Text.CompareTo("") == 0 && CheckBox1.Checked == false)
        {
            string _idProperty = this.DropDownList1.SelectedItem.Value;
            crit = "idProperty=" + _idProperty;
           // crit = crit + descfilter;
            lblFilter.Text = "All Documents for Property=" + this.DropDownList1.SelectedItem.Text;
        }

        if (txtBoxKeyword.Text.CompareTo("") != 0 && CheckBox1.Checked == false)
        {
            string _idProperty = this.DropDownList1.SelectedItem.Value;
            crit = "idProperty=" + _idProperty;

            crit = crit + " And (Keyword1 like " + apostrof + percentage + txtBoxKeyword.Text + percentage + apostrof;
            crit = crit + " Or Keyword2 like " + apostrof + percentage + txtBoxKeyword.Text + percentage + apostrof;
            crit = crit + " Or Keyword3 like " + apostrof + percentage + txtBoxKeyword.Text + percentage + apostrof + ")";

           // crit = crit + descfilter;
            lblFilter.Text = " All Documents for Property=" + this.DropDownList1.SelectedItem.Text + " and keyword=" + txtBoxKeyword.Text;
            // and 
        }

        set_grid(crit);
    }

    private void setFilterDescr()
    {
        string crit = "";

        string apostrof = @"'";
        string percentage = @"%";

        string descfilter = "";

        if (txtDesc.Text.CompareTo("") == 0)
        {
            // do not 
        }
        else
        {
            //descfilter = " And Description like " + apostrof + txtDesc.Text + percentage + apostrof;
        }

        if (txtDesc.Text.CompareTo("") == 0 && CheckBox1.Checked == true)
        {
            crit = " 1=1 order by Description asc ";
            lblFilter.Text = "All Documents";
        }

        if (txtDesc.Text.CompareTo("") != 0 && CheckBox1.Checked == true)
        {
            // all documents with keywords 
            // Keyword1 like '%court%' or Keyword2 like '%court%' or Keyword3 like '%court%'

            crit = " Description like " + apostrof + txtDesc.Text + percentage + apostrof;
            crit = crit + " order by Description asc "; 
            // crit = crit + descfilter;

            lblFilter.Text = "All Documents for description=" + txtDesc.Text;
        }

        if (txtDesc.Text.CompareTo("") != 0 && CheckBox1.Checked == false)
        {
            string _idProperty = this.DropDownList1.SelectedItem.Value;
            crit = "idProperty=" + _idProperty + " And Description like " + apostrof + txtDesc.Text + percentage + apostrof; ;
            // crit = crit + descfilter;
            lblFilter.Text = "All Documents for Property=" + this.DropDownList1.SelectedItem.Text;
           // lblFilter.Text = crit;
        }

        set_gridDesc(crit);
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        setFilterDescr();
    }
}