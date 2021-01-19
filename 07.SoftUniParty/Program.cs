using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> normalInvs = new HashSet<string>();
            HashSet<string> VIPInvs = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                if (input[0] >= 60 && input[0] <= 71)
                {
                    if (!normalInvs.Contains(input))
                    {
                        VIPInvs.Add(input);
                    }
                }
                else
                {
                    if (!VIPInvs.Contains(input))
                    {
                        normalInvs.Add(input);
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (VIPInvs.Contains(input))
                {
                    VIPInvs.Remove(input);
                }
                else if (normalInvs.Contains(input))
                {
                    normalInvs.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(VIPInvs.Count + normalInvs.Count);

            Console.Write(string.Join(Environment.NewLine, VIPInvs));
            Console.WriteLine(string.Join(Environment.NewLine, normalInvs));
        }
    }
}
