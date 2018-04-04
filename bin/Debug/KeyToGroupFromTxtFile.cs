using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Data.Sql;
using System.Data.SqlTypes;
 
 
public class KeyToGroupFromTxtFile
 
{
public KeyToGroupFromTxtFile()
{
}
public List<KeyToGroup> GetListFromTxt(string filename)
{
List<KeyToGroup> alist = new List<KeyToGroup >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
KeyToGroup tmpObject = new KeyToGroup();
tmpObject.STORE_NO=int.Parse(tmp[0]);
tmpObject.DEPARTMENT=tmp[1];
tmpObject.CLASS_=tmp[2];
tmpObject.VENDOR_CODE=tmp[3];
alist.Add(tmpObject);
}
return alist;
}
}
