using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinTest
{
    public partial class TestForm : Form
    {
        public string SqlCon;

        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(string con)
        {
            InitializeComponent();
            SqlCon = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = this.listBox2.SelectedIndex;
            string res = this.listBox2.Items[x].ToString();
            this.textBox1.Text = res; 

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = this.listBox1.SelectedIndex;
            string res = this.listBox1.Items[x].ToString();
            this.textBox1.Text = res; 
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            

        }

        private void setGrid()
        {
            DataTable dt = new DataTable();
            GeneralDataLayer gdl = new GeneralDataLayer();
            dt = gdl.GetTableFromSQLServer(SqlCon,"Select * From usershs");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralDataLayer dl = new GeneralDataLayer(SqlCon);
            ArrayList al = new ArrayList();
            al = dl.RunViewSQL(",", SqlCon, "Select Username,Password, Active From usershs");

           // this.listBox1.DataSource = al;

            //int[] fieldsFromArrayList = new int[2];
            //fieldsFromArrayList[0] = 0;
            //fieldsFromArrayList[1] = 2;

            // TWO INI FILES
            // ONE for columns to extract like 0,2 

            // One for types of the columsn corespding
            // like System.String,System.Int32


            int[] fieldsFromArrayList = utils_alist.SetArrayOfIntFromString("0,1",',');

            ArrayList alTest = utils_alist.GetColumnsFromArrayList(al, fieldsFromArrayList, ',');
          //  ArrayList alTest = utils_alist.GetColumnsFromArrayList(al, fieldsFromArrayList, '|');

            //EXAMPLE OF validaton of list members 
            ArrayList alEr = new ArrayList();
            for (int inx = 0; inx<alTest.Count;inx++)
            {
              string tmpStr = alTest[inx].ToString();
              string[] tmpArray = tmpStr.Split(',');

              // read from separate ini file System.String,System.DateTime
              string tmpStrType = "System.String,System.Int32";
              string[] tmpArrayType = tmpStrType.Split(',');
              if (utils_validation.IsValidInputManyFields(tmpArray, tmpArrayType) == false)
              {
                  alEr.Add(tmpStr);
              }


            }

            setListBox(alTest, listBox1);


            setComboBox(al, this.comboBox1);

            ArrayList al3 = Utils.GetColumnFromArrayList(al, 0, ',');
            this.listBox3.DataSource = al3;

            if (dl.alErrors.Count > 0)
            {
                this.listBox2.DataSource = dl.alErrors;
            }

        }


        /// <summary>
        ///  Setup list box any ArrayList with any listbox 
        /// </summary>
        /// <param name="al"></param>
        /// <param name="lBox"></param>
        private void setListBox(ArrayList al, ListBox lBox)
        {
            for (int i = 0; i < al.Count; i++)
            {
                lBox.Items.Add(al[i].ToString());
            }
        }

        private void setComboBox(ArrayList al, ComboBox cBox)
        {
            for (int i = 0; i < al.Count; i++)
            {
                cBox.Items.Add(al[i].ToString());
            }
        }

        private string getValueFromComboBox(ComboBox cBox, int _index)
        {
            string res = "";

            if (cBox.Items.Count > 0)
            {
                int x = cBox.SelectedIndex;
                res = cBox.Items[x].ToString();
            }

            return res;
        }

        private string getValueFromListBox(ListBox lBox, int _index)
        {
            string res = "";

            if (lBox.Items.Count > 0)
            {
                int x = lBox.SelectedIndex;
                res = lBox.Items[x].ToString();
            }

            return res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = getValueFromComboBox(comboBox1, comboBox1.SelectedIndex);
        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                string r = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                MessageBox.Show(r);
            }
            catch
            {
                MessageBox.Show("The complete row must be selected");
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // string r = e.RowIndex.ToString();
           // MessageBox.Show(r);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
