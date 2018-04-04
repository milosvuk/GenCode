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
 
 
public class key_to_groupFromTxtFile
 
{
public key_to_groupFromTxtFile()
{
}
public List<key_to_group> GetListFromTxt(string filename)
{
List<key_to_group> alist = new List<key_to_group >();
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
