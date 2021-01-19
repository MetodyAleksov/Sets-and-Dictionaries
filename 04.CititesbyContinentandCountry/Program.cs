using System;
using System.Collections.Generic;

namespace _04.CititesbyContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();

                if (continents.ContainsKey(arr[0]))
                {
                    if (continents[arr[0]].ContainsKey(arr[1]))
                    {
                        continents[arr[0]][arr[1]].Add(arr[2]);
                    }
                    else
                    {
                        continents[arr[0]].Add(arr[1], new List<string>());
                        continents[arr[0]][arr[1]].Add(arr[2]);
                    }
                }
                else
                {
                    continents.Add(arr[0], new Dictionary<string, List<string>>());
                    continents[arr[0]].Add(arr[1], new List<string>());
                    continents[arr[0]][arr[1]].Add(arr[2]);
                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}: ");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
