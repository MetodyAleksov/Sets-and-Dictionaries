using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<int> numbers = new HashSet<int>();
            Dictionary<int, int> occurences = new Dictionary<int, int>();
                 
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (numbers.Contains(num))
                {
                    occurences[num]++;
                }
                else
                {
                    numbers.Add(num);
                    occurences.Add(num, 1);
                }
            }

            foreach (var number in occurences)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                    break;
                }
            }
        }
    }
}
