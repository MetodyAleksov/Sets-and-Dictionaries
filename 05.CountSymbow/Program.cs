using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbow
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<char> chars = new HashSet<char>();
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (char item in input)
            {
                if (chars.Contains(item))
                {
                    occurences[item]++;
                }
                else
                {
                    chars.Add(item);
                    occurences.Add(item, 1);
                }
            }

            foreach (var item in occurences.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
