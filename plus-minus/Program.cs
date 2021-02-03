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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        decimal p = 0, n = 0, z = 0; 
        foreach (var item in arr)
        {
            p += (item > 0) ? 1 : 0;
            n += (item < 0) ? 1 : 0;
            z += (item == 0) ? 1 : 0; 
            
        }
        
        p = p / arr.Length;
        n = n / arr.Length;
        z = z / arr.Length;

        Console.WriteLine(p.ToString("N6"));
        Console.WriteLine(n.ToString("N6"));
        Console.WriteLine(z.ToString("N6"));
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        plusMinus(arr);
    }
}
