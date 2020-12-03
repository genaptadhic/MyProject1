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

namespace ConsoleApp8
{
    class Program
    {
        class Result
        {

            public static List<int> gradingStudents(int gradesCount, List<int> grades)
            {
                for (int i = 0; i < gradesCount; i++)
                {
                    if (grades[i] > 37)
                    {
                        if ((grades[i] / 5 + 1) * 5 - grades[i] < 3)
                        {
                            grades[i] = (grades[i] / 5 + 1) * 5;
                        }
                    }

                }
                return grades;
            }
        }

        static void Main(string[] args)
        {

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(gradesCount, grades);
            Console.WriteLine(Convert.ToString(result));
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
