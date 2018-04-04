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
 
 
public class StoreFromTxtFile
 
{
public StoreFromTxtFile()
{
}
public List<Store> GetListFromTxt(string filename)
{
List<Store> alist = new List<Store >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
Store tmpObject = new Store();
tmpObject.STORE_NO=int.Parse(tmp[0]);
tmpObject.STORE_CODE=tmp[2];
tmpObject.STORE_NAME=tmp[3];
alist.Add(tmpObject);
}
return alist;
}
}
