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
 
 
public class QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscountFromTxtFile
 
{
public QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscountFromTxtFile()
{
}
public List<QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscount> GetListFromTxt(string filename)
{
List<QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscount> alist = new List<QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscount >();
string[] aObjects = File.ReadAllLines(filename);
 for (int i = 0; i < aObjects.Length; i++)
{
string[] tmp = aObjects[i].Split(',');
QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscount tmpObject = new QtyOnHandPerDayPerStoreVendCodeDepartmentClassDiscount();
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
