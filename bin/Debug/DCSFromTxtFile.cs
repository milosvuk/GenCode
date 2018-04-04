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
 
 
public class DCSFromTxtFile
 
{
public DCSFromTxtFile()
{
}
public List<DCS> GetListFromTxt(string filename)
{
List<DCS> alist = new List<DCS >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
DCS tmpObject = new DCS();
tmpObject.DCS_CODE=tmp[0];
tmpObject.DEPARTMENT=tmp[1];
tmpObject.CLASS_=tmp[2];
tmpObject.DEPARTMENT_NAME=tmp[3];
tmpObject.CLASS_NAME=tmp[4];
tmpObject.CREATEID_IN_YEAR=int.Parse(tmp[5]);
alist.Add(tmpObject);
}
return alist;
}
}
