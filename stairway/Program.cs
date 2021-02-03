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

    // Complete the staircase function below.
    static void staircase(int n)
    {
        int steps = 1;
        bool blankFilled = false;
        for (int i = 0; i < n; i++)
        {
            
            for (int j = 0; j < steps; j++)
            {
                if (!blankFilled)
                {
                    //Console.WriteLine((n - steps));
                    for (int k = 0; k < (n - steps); k++)
                    {
                        //Console.WriteLine(k);
                        Console.Write(" ");
                    }
                    blankFilled = true;
                }
                Console.Write("#");
            }
            steps++;
            blankFilled = false;
            Console.WriteLine();
        }

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
