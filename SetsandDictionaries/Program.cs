using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsandDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> number = new Dictionary<double, int>(); 

            foreach (double item in arr)
            {
                if (number.ContainsKey(item))
                {
                    number[item]++;
                }
                else
                {
                    number.Add(item, 1);
                }
            }

            foreach (var item in number)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
