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
 
 
public class QtyOnHandPerDayPerStoreVendCodeDepartmentClassFromTxtFile
 
{
public QtyOnHandPerDayPerStoreVendCodeDepartmentClassFromTxtFile()
{
}
public List<QtyOnHandPerDayPerStoreVendCodeDepartmentClass> GetListFromTxt(string filename)
{
List<QtyOnHandPerDayPerStoreVendCodeDepartmentClass> alist = new List<QtyOnHandPerDayPerStoreVendCodeDepartmentClass >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
QtyOnHandPerDayPerStoreVendCodeDepartmentClass tmpObject = new QtyOnHandPerDayPerStoreVendCodeDepartmentClass();
tmpObject.STORE_NO=int.Parse(tmp[0]);
tmpObject.VENDOR_CODE=tmp[1];
tmpObject.DEPARTMENT=tmp[2];
tmpObject.CLASS_=tmp[3];
tmpObject.DATEOFSALES=int.DateTime(tmp[4]);
tmpObject.CALENDARWEEK=int.Parse(tmp[5]);
tmpObject.MONTH=int.Parse(tmp[6]);
tmpObject.YEAR=int.Parse(tmp[7]);
tmpObject.TOTALQTYONHAND=int.Parse(tmp[8]);
tmpObject.TOTALVALUEQTYONHAND=tmp[9];
tmpObject.TYPEOFSALE=tmp[10];
alist.Add(tmpObject);
}
return alist;
}
}
