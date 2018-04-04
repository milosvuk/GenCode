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
 
 
public class huntersFromTxtFile
 
{
public huntersFromTxtFile()
{
}
public List<hunters> GetListFromTxt(string filename)
{
List<hunters> alist = new List<hunters >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
hunters tmpObject = new hunters();
tmpObject.IDCARDNUMBER=tmp[0];
tmpObject.SURNAME=tmp[1];
tmpObject.NAME=tmp[2];
tmpObject.ADDRESS1=tmp[3];
tmpObject.ADDRESS2=tmp[4];
tmpObject.LOCALITY=tmp[5];
tmpObject.MALTAORGOZO=tmp[6];
tmpObject.LICENCEDMOBILENUMBER=tmp[7];
tmpObject.LICENCEACTIVE=int.Parse(tmp[8]);
tmpObject.ACTIVE=int.Parse(tmp[9]);
alist.Add(tmpObject);
}
return alist;
}
}
