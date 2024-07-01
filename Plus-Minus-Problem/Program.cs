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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
       int plus=0;
       int minus=0;
       int zero=0;
        int n=arr.Count;
        foreach(int i in arr)
        {
            if(i<0){
                minus++;
            }
            else if(i>0){
                plus++;
            }
            else zero++;
            
        }
      float plusratio=(float)plus/n;
      float minusratio=(float)minus/n;
      float zeroratio= (float)zero/n;
      Console.WriteLine(plusratio.ToString("F6"));
      Console.WriteLine(minusratio.ToString("F6"));
      Console.WriteLine(zeroratio.ToString("F6"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
