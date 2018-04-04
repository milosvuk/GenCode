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
 
 
public class SpacePerStoreFromTxtFile
 
{
public SpacePerStoreFromTxtFile()
{
}
public List<SpacePerStore> GetListFromTxt(string filename)
{
List<SpacePerStore> alist = new List<SpacePerStore >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
SpacePerStore tmpObject = new SpacePerStore();
tmpObject.STORE_NO=int.Parse(tmp[0]);
tmpObject.VENDOR_CODE=tmp[1];
tmpObject.DEPARTMENT=tmp[2];
tmpObject.CLASS_=tmp[3];
tmpObject.YEAR=int.Parse(tmp[4]);
tmpObject.CALENDARWEEK=int.Parse(tmp[5]);
tmpObject.SPACE_QM=tmp[6];
alist.Add(tmpObject);
}
return alist;
}
}
