using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (students.ContainsKey(input[0]))
                {
                    students[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    students.Add(input[0], new List<double>());
                    students[input[0]].Add(double.Parse(input[1]));
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value)} (avrg: {(student.Value.Sum() / student.Value.Count):f2})");
            }
        }
    }
}
