using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> color = new HashSet<string>();
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string[] clothe = input[1].Split(",");

                if (!color.Contains(input[0]))
                {
                    color.Add(input[0]);
                    clothes.Add(input[0], new Dictionary<string, int>());
                }

                foreach (var item in clothe)
                {
                    if (clothes[input[0]].ContainsKey(item))
                    {
                        clothes[input[0]][item]++;
                    }
                    else
                    {
                        clothes[input[0]].Add(item, 1);
                    }
                }

            }

            string[] arr = Console.ReadLine().Split();
            bool curColor = false;

            foreach (var currColor in clothes)
            {
                if (arr[0] == currColor.Key)
                {
                    curColor = true;
                }
                Console.WriteLine($"{currColor.Key} clothes: ");
                foreach (var clothe in currColor.Value)
                {
                    Console.Write($"* {clothe.Key} - {clothe.Value}");
                    if (curColor == true && clothe.Key == arr[1])
                    {
                        Console.Write($" (found!)");
                        curColor = false;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
