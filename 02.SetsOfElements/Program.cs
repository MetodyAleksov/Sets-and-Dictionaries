using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < arr[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstSet.Add(input);
            }
            for (int i = 0; i < arr[1]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondSet.Add(input);
            }

            foreach (int item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
