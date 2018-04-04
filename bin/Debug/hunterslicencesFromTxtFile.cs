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
 
 
public class hunterslicencesFromTxtFile
 
{
public hunterslicencesFromTxtFile()
{
}
public List<hunterslicences> GetListFromTxt(string filename)
{
List<hunterslicences> alist = new List<hunterslicences >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
hunterslicences tmpObject = new hunterslicences();
tmpObject.IDRECHUNTER=int.Parse(tmp[0]);
tmpObject.IDRECLICENCE=int.Parse(tmp[1]);
tmpObject.LICENCEYEAR=int.Parse(tmp[2]);
tmpObject.PAID=int.Parse(tmp[3]);
tmpObject.AMOUNT=tmp[4];
tmpObject.COMMENTS=tmp[5];
tmpObject.ACTIVE=int.Parse(tmp[6]);
alist.Add(tmpObject);
}
return alist;
}
}
