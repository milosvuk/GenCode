using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;

class utils_validation
{
    
    public static bool IsValidInteger(string inputTxt)
    {
        bool res = true;

        bool resNull = String.IsNullOrEmpty(inputTxt);
        if (resNull == true)
        {
            return false;
        }


        int numInt;
        res = int.TryParse(inputTxt, out numInt);

        return res;
    }

    public static bool IsValidDouble(string inputTxt)
    {
        bool res = true;

        bool resNull = String.IsNullOrEmpty(inputTxt);
        if (resNull == true)
        {
            return false;
        }

        double numInt;
        res = double.TryParse(inputTxt, out numInt);

        return res;
    }

    public static bool IsValidDecimal(string inputTxt)
    {
        bool res = true;

        bool resNull = String.IsNullOrEmpty(inputTxt);
        if (resNull == true)
        {
            return false;
        }

        decimal numInt;
        res = decimal.TryParse(inputTxt, out numInt);

        return res;
    }

    public static bool IsValidInput(string inputTextMain, string typeOfInput)
    {
        bool res = true;

        if (typeOfInput.CompareTo("System.String") == 0)
        {
            if (String.IsNullOrEmpty(inputTextMain) == true)
            {
                res = false;
                return res;
            }

        }


        if (typeOfInput.CompareTo("System.Int32") == 0)
        {
            res = IsValidInteger(inputTextMain);
        }

        if (typeOfInput.CompareTo("System.Decimal") == 0)
        {

            res = IsValidDecimal(inputTextMain);
        }

        if (typeOfInput.CompareTo("System.DateTime") == 0)
        {

            res = IsValidDateTime(inputTextMain);
        }

        return res;
    }

    public static bool IsValidInputManyFields(string[] inputTextMain, string[] typeOfInput)
    {
        bool res = true;

        for (int i=0;i<inputTextMain.Length;i++)
        {
            res = IsValidInput(inputTextMain[i], typeOfInput[i]);

            if (res == false)
            {
                return res;
            }
        }

        

        return res;

        // using read from arraylist and split to array and for each one 
        // in the second array add System.String or System.Int32 etc 
        // separate txt file could be created with the same structure like
        // System.String,System.Int32,System.String etc 
    }

    

    public static bool IsValidDateTime(string inputTxt)
    {
        bool res = true;

        bool resNull = String.IsNullOrEmpty(inputTxt);
        if (resNull == true)
        {
            return false;
        }

        DateTime numInt;
        res = DateTime.TryParse(inputTxt, out numInt);

        return res;
    }





    // use IsValidInput(string inputTextMain, string typeOfInput) typeOfInput =>> System.DateTime

}

