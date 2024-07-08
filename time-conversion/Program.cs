using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string period =s.Substring(s.Length-2);
        int hour = int.Parse(s.Substring(0,2));
        string minute = s.Substring(3,2);
        string second =s.Substring(6,2);
        
        if(period=="AM")
        {
            if (hour==12) hour=0;
        }
        else if(period == "PM")
        if(hour!= 12) hour +=12;
        string hourString =hour.ToString("D2");
        return $"{hourString}:{minute}:{second}";

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
