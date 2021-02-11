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

class Solution
{

    // Complete the commonChild function below.
    static int commonChild(string s1, string s2)
    {
        char[] arr1 = s1.ToCharArray();
        int s1Length = s1.Length;
        int maxCommonChildLength = 0;


        for(int i=0; (i< s1Length &&((i+ maxCommonChildLength) < s1Length) ); i++)
        {
            int commonChildLegth = 0;
            int s2MaxIndex = 0;

            for (int j=i; j< s1Length; j++)
            { 
               int s2Index = s2Find(s2.ToCharArray(), s2MaxIndex, s1[j]);
               if (!(s2Index == -1) )
                {
                    s2MaxIndex = s2Index+1;
                    commonChildLegth++;                  
                    
                }

            }

            if(maxCommonChildLength< commonChildLegth)
            {
                maxCommonChildLength = commonChildLegth;
            }


        }

        return maxCommonChildLength;

    }

     
    static int s2Find(char[] arr2, int startIndex, char searchChar)
    {
         
        int length = arr2.Length;

        for(int i= startIndex; i< length; i++)
        {
            if (arr2[i] == searchChar)
                return i;
           
        }
       
        return -1;

    }





    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();

        string s2 = Console.ReadLine();

        int result = commonChild(s1, s2);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
