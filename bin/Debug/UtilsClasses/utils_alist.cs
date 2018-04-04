using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;





class utils_alist 
{

    public static string GetSumFromArrayListAsDecimal(ArrayList alItems)
    {
        string res = "0";

        decimal tmp = 0;
        for (int i = 0; i < alItems.Count; i++)
        {
            decimal tmpA = 0;
            try
            {
                tmpA = decimal.Parse(alItems[i].ToString());
            }
            catch
            {
                tmpA = 0;
            }

            tmp = tmp + tmpA;
        }

        res = String.Format("{0:0.00}", tmp);
        //res = tmp.ToString("N2");

        return res;

        // select * from QtyOnHandPerDayPerStoreVendCodeDepartmentClass where DateOfSales = '2012/01/26'
    }

    public static string GetSumFromArrayListAllIntegers(ArrayList alItems)
    {
        string res = "0";

        decimal tmp = 0;
        for (int i = 0; i < alItems.Count; i++)
        {
            decimal tmpA = 0;
            try
            {
                tmpA = int.Parse(alItems[i].ToString());
            }
            catch
            {
                tmpA = 0;
            }

            tmp = tmp + tmpA;
        }

        res = tmp.ToString();
        //res = tmp.ToString("N2");

        return res;

        // select * from QtyOnHandPerDayPerStoreVendCodeDepartmentClass where DateOfSales = '2012/01/26'
    }

     
    public static ArrayList RemoveDups(ArrayList items)
    {

        ArrayList noDups = new ArrayList();

        foreach (string strItem in items)
        {

            if (!noDups.Contains(strItem.Trim()))
            {

                noDups.Add(strItem.Trim());

            }

        }

        return noDups;

    }

    public static int[] SetArrayOfIntFromString(string _tmp, char delimeter)
    {
        string[] tmpAr = _tmp.Split(delimeter);

        int[] res = new int[tmpAr.Length];

        for (int i = 0; i < tmpAr.Length; i++)
        {
            res[i] = int.Parse(tmpAr[i]);
        }

        return res;

    }

    public static ArrayList GetColumnFromArrayList(ArrayList items, int _column, char delimiter)
    {

        ArrayList noDups = new ArrayList();

        foreach (string strItem in items)
        {

            string[] tmp = strItem.Split(delimiter);

            noDups.Add(tmp[_column]);



        }

        return noDups;

    }

    public static ArrayList GetColumnsFromArrayList(ArrayList items, int[] _column, char delimiter)
    {

        ArrayList noDups = new ArrayList();

        
        foreach (string strItem in items)
        {

            string[] tmp = strItem.Split(delimiter);
            string tmpRead = "";

            for (int i=0;i<_column.Length;i++)
            {
                
                int column = _column[i];
                if (i == 0)
                {
                    tmpRead = tmp[column];
                    //noDups.Add(tmpRead);
                }
                else
                {
                    tmpRead = tmpRead + delimiter.ToString() + tmp[column];
                    //noDups.Add(tmpRead);
                }

                

            }


            noDups.Add(tmpRead);


        }

        return noDups;

    }


     

}

