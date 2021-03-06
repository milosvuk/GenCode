﻿using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;



class utils_formating
{
        
    
    public static string StringToDecimalFormat(decimal decimalToFormat)
    {
        return String.Format("{0:0.00}", decimalToFormat);
    }

    public static string StringToIntFormat(int intToFormat)
    {
        return String.Format("{0:0}", intToFormat);
    }

    public static decimal ConvertStringToDecimal(string res)
    {
        decimal result = 0;

        try
        {
            result = decimal.Parse(res);
        }
        catch
        {
            result = 0;
        }

        return result;
    }

    
    public static string Convert_to_sql_date(DateTime date)
    {
        return string.Format("'{0,2:00}-{1,2:00}-{2,2:00}'", date.Year, date.Month, date.Day);

        // select * from QtyOnHandPerDayPerStoreVendCodeDepartmentClass where DateOfSales = '2012/01/26'
    }

    
    private static string ConvertNumToMonthString(int m)
    {
        string res = "";

        if (m == 1)
            res = "JAN";

        if (m == 2)
            res = "FEB";

        if (m == 3)
            res = "MAR";

        if (m == 4)
            res = "APR";

        if (m == 5)
            res = "MAY";

        if (m == 6)
            res = "JUN";

        if (m == 7)
            res = "JUL";

        if (m == 8)
            res = "AUG";

        if (m == 9)
            res = "SEP";

        if (m == 10)
            res = "OCT";

        if (m == 11)
            res = "NOV";

        if (m == 12)
            res = "DEC";

        return res;

    }

   

    public static string Convert_date_to_Oracle_format(DateTime dateToConvert)
    {
        string res = "";
        int intMonth = dateToConvert.Month;
        string strMonth = utils_formating.ConvertNumToMonthString(intMonth);
        res = dateToConvert.Day.ToString() + "-" + strMonth + "-" + dateToConvert.Year.ToString();
        return res;
    }
    //    DateTime dtBefore = DateTime.Now.AddDays(-1);
    //    DateTime dtAfter = DateTime.Now.AddDays(1);

    public static string ConvertDateToFormatDDMMYYYY(DateTime startGlobalDate)
    {
        string res = "";

        string _dayStartDate = startGlobalDate.Day.ToString();
        if (_dayStartDate.Length == 1)
        {
            _dayStartDate = "0" + _dayStartDate;
        }

        string _monthStartDate = startGlobalDate.Month.ToString();
        if (_monthStartDate.Length == 1)
        {
            _monthStartDate = "0" + _monthStartDate;
        }

        res = _dayStartDate + _monthStartDate + startGlobalDate.Year.ToString();



        return res;
    }

    public static string ConvertDateTimeNowToFormatDDMMYYYYHHMMSS()
    {
        string res = "";
        DateTime startGlobalDate = DateTime.Now;

        string _dayStartDate = DateTime.Now.Day.ToString();
        if (_dayStartDate.Length == 1)
        {
            _dayStartDate = "0" + _dayStartDate;
        }

        string _monthStartDate = startGlobalDate.Month.ToString();
        if (_monthStartDate.Length == 1)
        {
            _monthStartDate = "0" + _monthStartDate;
        }

        string _hours = startGlobalDate.Hour.ToString();
        if (_hours.Length == 1)
        {
            _hours = "0" + _hours;
        }

        string _min = startGlobalDate.Minute.ToString();
        if (_min.Length == 1)
        {
            _min = "0" + _min;
        }

        string _sec = startGlobalDate.Second.ToString();
        if (_sec.Length == 1)
        {
            _sec = "0" + _sec;

        }
        res = _dayStartDate + _monthStartDate + startGlobalDate.Year.ToString() + "_" + _hours + _min + _sec;

        return res;
    }
          
    
    public static int GetIso8601WeekOfYear(DateTime time)
    {
        DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
        if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
        {
            time = time.AddDays(3);
        }

        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        // 46
        //int thisWeekNumber = GetIso8601WeekOfYear(DateTime.Today); 
    }



    public static DateTime FirstDateOfWeek(int year, int weekOfYear, System.Globalization.CultureInfo ci)
    {
        DateTime jan1 = new DateTime(year, 1, 1);
        int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
        DateTime firstWeekDay = jan1.AddDays(daysOffset);
        int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
        if (firstWeek <= 1 || firstWeek > 50)
        {
            weekOfYear -= 1;
        }
        return firstWeekDay.AddDays(weekOfYear * 7);
        //Then you can get both dates in the following way:
        // 11/11/2013  
        //DateTime firstDayOfWeek= FirstDateOfWeek(2013, thisWeekNumber, CultureInfo.CurrentCulture); 
        // 11/12/2012  
        ///DateTime firstDayOfLastYearWeek = FirstDateOfWeek(2012, thisWeekNumber, CultureInfo.CurrentCulture);   
        //Add 6 days to get the end of the week.
    }


}

