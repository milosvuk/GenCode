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
    public partial class FormCode : Form
    {

        string _classname;
        string _fieldText;
        string _fieldData;
        ArrayList alFlds = new ArrayList();
        // here the list of all fields

        public FormCode()
        {
            InitializeComponent();
        }

        public FormCode(string classname, string fieldText, string fieldData)
        {
            InitializeComponent();
             _classname = classname;
             _fieldText =  fieldText;
             _fieldData =  fieldData;
        }

        public FormCode(string classname, string fieldText, string fieldData, ArrayList alFields)
        {
            InitializeComponent();
            _classname = classname;
            _fieldText = fieldText;
            _fieldData = fieldData;

            for (int i = 0; i < alFields.Count; i++)
            {
                string tmp = alFields[i].ToString();
                alFlds.Add(tmp);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pageLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\Load_Page.txt";
            ReadFileAndShow(fname);
        }

        private void setListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\DropDownList.txt";
            ReadFileAndShow(fname);
        }

        private void ReadFileAndShow(string fname)
        {
            this.richTextBox1.Text = System.IO.File.ReadAllText(fname);

            this.richTextBox1.Text = this.richTextBox1.Text.Replace("classname", _classname);
            this.richTextBox1.Text = this.richTextBox1.Text.Replace("FieldDescription", _fieldText);
            this.richTextBox1.Text = this.richTextBox1.Text.Replace("FieldValue", _fieldData);

            // FieldDescription
        }

        private ArrayList ReadFileChangeToArrayList(string fname)
        {
            ArrayList res = new ArrayList();

            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = fname;

            al = txFile.FileToArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tm0 = al[i].ToString();
                string tm1 = tm0.Replace("classname", _classname);
                string tm2 = tm1.Replace("FieldDescription", _fieldText);
                string tm3 = tm2.Replace("FieldValue", _fieldData);
                res.Add(tm3);
            }
                                
            
            return res;
            // FieldDescription
        }

        private void getValueFRomGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\GridView1_RowEditing.txt";
            ReadFileAndShow(fname);
           
        }

        private void setLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\set_login.txt";
            ReadFileAndShow(fname);
           
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\set_grid.txt";
            ReadFileAndShow(fname);
        }

        private void getListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = " string idRec = this.ListBox1.SelectedItem.Value;";
        }

        private void exportCSVWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\ExportCSV_Web.txt";
            ReadFileAndShow(fname);
           
        }

        private void setGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WinGUI\setgrid.txt";
            ReadFileAndShow(fname);
        }

        private void setListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WinGUI\setlist.txt";
            ReadFileAndShow(fname);
        }

        private void setComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WinGUI\setcbox.txt";
            ReadFileAndShow(fname);
        }

        private void getListBoxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WinGUI\getValueList.txt";
            ReadFileAndShow(fname);
        }

        private void getComboBoxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WinGUI\getValueCbox.txt";
            ReadFileAndShow(fname);
        }

        private void getGridValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = @"string r = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();";
        }

        private void helpClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Application.StartupPath + @"\UtilsClasses\";
            this.openFileDialog1.ShowDialog();
            string fname = this.openFileDialog1.FileName;
            this.richTextBox1.Text =   System.IO.File.ReadAllText(fname);
        }

        private void setSingleRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            string fname = Application.StartupPath + @"\WinGUI\singleWin.txt";
            txFile.FileName = fname; 


            string line1 = @"public void SetSingleRecord_To_FormFields(" + _classname + " obj)";
            al.Add(line1);
            al.Add("{");

            for (int i = 0; i < alFlds.Count; i++)
            {
                string tm = alFlds[i].ToString();
                string tmAll = "this.txt_" + tm + ".Text  = " + "obj." + tm.ToUpper() + ";";
                al.Add(tmAll);
            }

            al.Add("}");

            txFile.ArrayListToFile(al);
            MessageBox.Show("Single Record file created");
            this.richTextBox1.Text = System.IO.File.ReadAllText(fname);


    //        public static string StringToIntFormat(int intToFormat)
    //{
    //    return String.Format("{0:0}", intToFormat);
    //}
            // for web txtidRecUserGroup
           
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            string fname = Application.StartupPath + @"\WebGUI\singleWeb.txt";
            txFile.FileName = fname;


            string line1 = @"public void SetSingleRecord_To_FormFields(" + _classname + " obj)";
            al.Add(line1);
            al.Add("{");

            for (int i = 0; i < alFlds.Count; i++)
            {
                string tm = alFlds[i].ToString();
                string tmAll = "txt" + tm + ".Text  = " + "obj." + tm.ToUpper() + ";";
                al.Add(tmAll);
            }

            al.Add("}");

            txFile.ArrayListToFile(al);
            MessageBox.Show("Single Record file created");
            this.richTextBox1.Text = System.IO.File.ReadAllText(fname);

            // txtidRecUserGroup
        }

        private ArrayList alSetSingleRecord()
        {
            ArrayList al = new ArrayList();
           
            string line1 = @"public void SetSingleRecord_To_FormFields(" + _classname + " obj)";
            al.Add(line1);
            al.Add("{");

            for (int i = 0; i < alFlds.Count; i++)
            {
                string tm = alFlds[i].ToString();
                string tmAll = "txt" + tm + ".Text  = " + "obj." + tm.ToUpper() + ";";
                al.Add(tmAll);

                if (tm.IndexOf("id_") > -1)
                {

                    // // use string _id = this.DropDownList1.SelectedItem.Value;
                    string[] tmpi = tm.Split('_');
                    string tmList = "setComboBox" + tmpi[1] + "(" + "obj." + tm.ToUpper() + ");";
                    al.Add(tmList);
                }

            }

            al.Add("}");
            
            return al;
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            string fname = Application.StartupPath + @"\WinGUI\GetsingleWin.txt";
            txFile.FileName = fname;


            string line1 = @"public " + _classname + " GetSingleRecord_From_FormFields()";
            al.Add(line1);
            al.Add("{");

            string _cl = _classname + " obj = new " + _classname + "();"; 

            al.Add(_cl);

            for (int i = 0; i < alFlds.Count; i++)
            {
                string tm = alFlds[i].ToString();
                string tmAll = "obj." + tm.ToUpper()+ " = this.txt_" + tm + ".Text;";
                al.Add(tmAll);
            }

            al.Add("return obj;");
            al.Add("}");

            txFile.ArrayListToFile(al);
            MessageBox.Show("Single Record file created - Get method");
            this.richTextBox1.Text = System.IO.File.ReadAllText(fname);


            //        public static string StringToIntFormat(int intToFormat)
            //{
            //    return String.Format("{0:0}", intToFormat);
            //}
            // for web txtidRecUserGroup
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            string fname = Application.StartupPath + @"\WebGUI\GetsingleWin.txt";
            txFile.FileName = fname;


            string line1 = @"public " + _classname + " GetSingleRecord_From_FormFields()";
            al.Add(line1);
            al.Add("{");

            string _cl = _classname + " obj = new " + _classname + "();";

            al.Add(_cl);

            for (int i = 0; i < alFlds.Count; i++)
            {
                string tm = alFlds[i].ToString();
                string tmAll = "obj." + tm.ToUpper() + " = txt" + tm + ".Text;";
                al.Add(tmAll);
            }

            al.Add("return obj;");
            al.Add("}");

            txFile.ArrayListToFile(al);
            MessageBox.Show("Single Record file created - Get method");
            this.richTextBox1.Text = System.IO.File.ReadAllText(fname);


        }

        private ArrayList alGetSingleRecord()
        {
            ArrayList al = new ArrayList();
            
            string line1 = @"public " + _classname + " GetSingleRecord_From_FormFields()";
            al.Add(line1);
            al.Add("{");

            string _cl = _classname + " obj = new " + _classname + "();";

            al.Add(_cl);

            for (int i = 0; i < alFlds.Count; i++)
            {
                string tm = alFlds[i].ToString();
                string tmAll = "obj." + tm.ToUpper() + " = txt" + tm + ".Text;";

                if (tm.IndexOf("id_") > -1)
                {

                    // // use string _id = this.DropDownList1.SelectedItem.Value;
                    string[] tmpi = tm.Split('_');
                    string tmList = "obj." + tm.ToUpper() + " = this.DropDownList" + tmpi[1] + ".SelectedItem.Value;";
                    //string tmList = "setComboBox" + tmpi + "(" + "obj." + tm.ToUpper() + ");";
                    al.Add(tmList);
                }

                al.Add(tmAll);
            }

            al.Add("return obj;");
            al.Add("}");

            return al;

        }

        private void importCSVWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\uploadFromCSV.txt";
            ReadFileAndShow(fname);
        }

        private void createWebPageAspxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // template html 
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            string fname = Application.StartupPath + @"\WebGUI\tHTML.txt";
            txFile.FileName = fname;

            al = txFile.FileToArrayList();

            
            // read from GridBound
            string dataKey = "";
            ArrayList alDGB = new ArrayList();

            ArrayList alGB = new ArrayList();
            TxtFile txFileGB = new TxtFile();
            string formname = "FormHTMLGridViewB" + _classname;
            txFileGB.FileName = Application.StartupPath + @"\" + formname + ".txt";
            alGB = txFileGB.FileToArrayList();
            for (int i = 0; i < alGB.Count; i++)
            {
                string tmp = alGB[i].ToString();
                if (tmp.IndexOf("DataKeyNames") > 0)
                {
                    dataKey = tmp;
                }

                if (tmp.IndexOf("<asp:BoundField") > -1)
                {
                    alDGB.Add(tmp);
                }

            }

            
            // new array za web page 
            ArrayList alNew = new ArrayList();

            //string endcolumn = @"</Columns>";

            string lineZero = al[0].ToString();
            string lineZeroNew = lineZero.Replace("classname",_classname);
            alNew.Add(lineZeroNew);

            // First pass
            for (int i = 1; i < al.Count; i++)
            {
                string tmp = al[i].ToString();

                if (tmp.IndexOf("DataKeyNames") == -1 && tmp.IndexOf("<asp:BoundField") == -1)
                {
                    // add to new AlNew
                    alNew.Add(tmp);
                }
                else
                {
                    if (tmp.IndexOf("DataKeyNames") > 0)
                    {
                        alNew.Add(dataKey);
                    }

                    
                }
            } // END FIRRST PASS

            // second pass

            ArrayList alNewFinal = new ArrayList();
            for (int i = 0; i < alNew.Count; i++)
            {
                string tmp = alNew[i].ToString();

                if (tmp.IndexOf("<asp:CommandField") > -1)
                {
                    // add to new AlNew
                    // loop

                    alNewFinal.Add(tmp);

                    for (int x = 0; x < alDGB.Count; x++)
                    {
                        string tmpX = alDGB[x].ToString();
                        alNewFinal.Add(tmpX);
                    }

                    //
                    
                }
                else
                {
                    alNewFinal.Add(tmp);
                }
            }


            // Create Edit.aspx

            //ArrayList alGB = new ArrayList();
            TxtFile txFileFinal = new TxtFile();
            string fnameaspx = _classname + "Edit.aspx";
            txFileFinal.FileName = Application.StartupPath + @"\" + fnameaspx;

            txFileFinal.ArrayListToFile(alNewFinal);
            MessageBox.Show("Done!");


        }

        private void createCodePageAspxcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fname = Application.StartupPath + @"\WebGUI\set_grid.txt";
            ArrayList alsetGrid = ReadFileChangeToArrayList(fname);

            //read template
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = Application.StartupPath + @"\WebGUI\tCS.txt";
            al = txFile.FileToArrayList();

            // if classname replace with _
            ArrayList alNewFinal = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tmp = al[i].ToString();
                string tmp0 = tmp.Replace("classname", _classname);

                if (tmp0.IndexOf("setgridDD") > -1)
                {
                    for (int x = 0; x < alsetGrid.Count; x++)
                    {
                        string resT = alsetGrid[x].ToString();
                        alNewFinal.Add(resT);
                    }
                }

                alNewFinal.Add(tmp0);

            }
            
            TxtFile txFileFinal = new TxtFile();
            string fnameaspx = _classname + "Edit.aspx.cs";
            txFileFinal.FileName = Application.StartupPath + @"\" + fnameaspx;

            txFileFinal.ArrayListToFile(alNewFinal);
            MessageBox.Show("Done!");
        }

        private void createSingleWebPageAspxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // template html 
            ArrayList alNew = new ArrayList();
            TxtFile txFile = new TxtFile();
            string fname = Application.StartupPath + @"\WebGUI\tHTML_Single.txt";
            txFile.FileName = fname;

            alNew = txFile.FileToArrayList();


            // read from singlehtml
            string dataKey = "";
            ArrayList alDGB = new ArrayList();

            ArrayList alGB = new ArrayList();
            TxtFile txFileGB = new TxtFile();
            string formname = "FormHTMLSingle" + _classname;
            txFileGB.FileName = Application.StartupPath + @"\" + formname + ".txt";
            alGB = txFileGB.FileToArrayList();

            // new array za web page 
         
            //string endcolumn = @"</Columns>";

            ArrayList alNewFinal = new ArrayList();

            string lineZero = alNew[0].ToString();
            string lineZeroNew = lineZero.Replace("classname", _classname);
            alNewFinal.Add(lineZeroNew);

            // DropDownList and add part of id_classname
            for (int i = 1; i < alNew.Count; i++)
            {
                string tmp = alNew[i].ToString();

                if (tmp.IndexOf("Label2") > -1)
                {
                    // add to new AlNew
                    // loop

                    for (int x = 0; x < alGB.Count; x++)
                    {
                        string tmpX = alGB[x].ToString();
                        alNewFinal.Add(tmpX);
                    }

                    alNewFinal.Add(tmp);
                    //

                }
                else
                {
                    alNewFinal.Add(tmp);
                }
            }


            // Create aspx

            //ArrayList alGB = new ArrayList();
            TxtFile txFileFinal = new TxtFile();
            string fnameaspx = _classname + "SingleRecord.aspx";
            txFileFinal.FileName = Application.StartupPath + @"\" + fnameaspx;

            txFileFinal.ArrayListToFile(alNewFinal);
            MessageBox.Show("Done!");

        }

        private void createSingleRecordCodePageAspxcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //in table main it has to be idclassname (tablename)
            // foreighkey must be id_classname (od te druge table)
            TxtFile txtF = new TxtFile();
            txtF.FileName = Application.StartupPath + @"\WebGUI\tCS_Single_Droplist.txt";
            ArrayList alDropList = txtF.FileToArrayList();


            ArrayList alSetRecord = alSetSingleRecord();
            ArrayList alGetRecord = alGetSingleRecord();

            //read template
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = Application.StartupPath + @"\WebGUI\tCS_Single.txt";
            al = txFile.FileToArrayList();

            // if classname replace with _
            ArrayList alNewFinal = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tmp = al[i].ToString();
                string tmp0 = tmp.Replace("classname", _classname);

                if (tmp0.IndexOf("setSingleRecord") > -1)
                {
                    for (int x = 0; x < alSetRecord.Count; x++)
                    {
                        string resT = alSetRecord[x].ToString();
                        alNewFinal.Add(resT);
                    }
                }

                if (tmp0.IndexOf("getSingleRecord") > -1)
                {
                    for (int x = 0; x < alGetRecord.Count; x++)
                    {
                        string resT = alGetRecord[x].ToString();
                        alNewFinal.Add(resT);
                    }
                }

                if (tmp0.IndexOf("setComboBox") > -1)
                {
                    for (int ii = 0; ii < alFlds.Count; ii++)
                    {
                        string fieldname = alFlds[ii].ToString();
                        if (fieldname.IndexOf("id_") > -1)
                        {
                            string[] tmpi = fieldname.Split('_');
                            string __classname = tmpi[1];
                            string __CLASSNAME = tmpi[1].ToUpper();
                            // second loop
                            for (int a = 0; a < alDropList.Count; a++)
                            {
                                string tmpfromArrayList = alDropList[a].ToString();
                                string final1 = tmpfromArrayList.Replace("classname", __classname);
                                string final2 = final1.Replace("CLASSNAME", __CLASSNAME);
                                alNewFinal.Add(final2);
                            }
                        }

                    }
                }
                alNewFinal.Add(tmp0);

            }


            

            // read from txt DropList
            // move thrue  ArrayList alFlds = new ArrayList();
            // here the list of all fields
            // and if you find id_
            // replace with content of file and add to aspx.cs like method

            TxtFile txFileFinal = new TxtFile();
            string fnameaspx = _classname + "SingleRecord.aspx.cs";
            txFileFinal.FileName = Application.StartupPath + @"\" + fnameaspx;

            txFileFinal.ArrayListToFile(alNewFinal);
            MessageBox.Show("Done!");
        }

        private void getToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = Application.StartupPath + @"\WebGUI\HandlerTemplateGet.txt";
            al = txFile.FileToArrayList();

            // if classname replace with _
            ArrayList alNewFinal = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tmp = al[i].ToString();
                string tmp0 = tmp.Replace("CLASSNAME", _classname);

                alNewFinal.Add(tmp0);
            }
            
            txFile.FileName = Application.StartupPath + @"\Code\Handl"+_classname+"Get.ashx";
            txFile.ArrayListToFile(alNewFinal);
            MessageBox.Show("Created " + txFile.FileName);

        }


        public void API_Add()
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = Application.StartupPath + @"\WebGUI\HandlerTemplateAdd.txt";
            al = txFile.FileToArrayList();

            // if classname replace with _
            ArrayList alNewFinal = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tmp = al[i].ToString();
                string tmp0 = tmp.Replace("CLASSNAME", _classname);

                alNewFinal.Add(tmp0);
            }

            txFile.FileName = Application.StartupPath + @"\Code\Handl" + _classname + "Add.ashx";
            txFile.ArrayListToFile(alNewFinal);
            MessageBox.Show("Created " + txFile.FileName);
        }

        public void API_Update()
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = Application.StartupPath + @"\WebGUI\HandlerTemplateUpdate.txt";
            al = txFile.FileToArrayList();

            // if classname replace with _
            ArrayList alNewFinal = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tmp = al[i].ToString();
                string tmp0 = tmp.Replace("CLASSNAME", _classname);

                alNewFinal.Add(tmp0);
            }

            txFile.FileName = Application.StartupPath + @"\Code\Handl" + _classname + "Update.ashx";
            txFile.ArrayListToFile(alNewFinal);
            MessageBox.Show("Created " + txFile.FileName);
        }
        // end of create page
        public void API_Delete()
        {
            ArrayList al = new ArrayList();
            TxtFile txFile = new TxtFile();
            txFile.FileName = Application.StartupPath + @"\WebGUI\HandlerTemplateDelete.txt";
            al = txFile.FileToArrayList();

            // if classname replace with _
            ArrayList alNewFinal = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string tmp = al[i].ToString();
                string tmp0 = tmp.Replace("CLASSNAME", _classname);

                alNewFinal.Add(tmp0);
            }

            txFile.FileName = Application.StartupPath + @"\Code\Handl" + _classname + "Delete.ashx";
            txFile.ArrayListToFile(alNewFinal);
            MessageBox.Show("Created " + txFile.FileName);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API_Add();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API_Update();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API_Delete();
        }
    }
}
