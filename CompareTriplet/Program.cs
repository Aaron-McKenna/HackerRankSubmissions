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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int dl = 0, dr = 0;
        int[,] matrix = new int[3,3];
        string temp = arr[1].ToString();
        Console.WriteLine(temp);
        for (int i = 0; i < 3; i++)
        {

            for (int j = 0; j < 3; j++)
            {
                
                matrix[i, j] = Convert.ToInt32(temp);
                
            }
        }

        for (int i = 0; i < 3; i++)
        {
            dl += Convert.ToInt32(matrix[i,i]);

            dr += Convert.ToInt32(matrix[i,(3 - i)]);
            
        }

        int result;

        result = Math.Abs(dl - dr);

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        

        List<List<int>> arr = new List<List<int>>();
        List<int> test = new List<int>();
        int[] arry = { 1, 4, 5, 6, 7, 8, 9, 3, 10 };

        /*arr.AddRange();
        arry.*/

        //arr[1].AddRange(arry);

        arr[1][1].ForEach(item => Console.WriteLine(item));

        //Console.WriteLine(arr.First());

        var result = Result.diagonalDifference(arr);

        //Console.WriteLine(result);
        
    }
}
