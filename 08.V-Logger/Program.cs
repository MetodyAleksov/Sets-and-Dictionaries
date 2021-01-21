using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vloggers = new HashSet<string>();
            List<Vlogger> vlogInfo = new List<Vlogger>();

            string[] log = Console.ReadLine().Split();

            while (log[0] != "Statistics")
            {
                if ( log[1] == "joined")
                {
                    if (!vloggers.Contains(log[0]))
                    {
                        Vlogger curr = new Vlogger(log[0]);
                        vloggers.Add(log[0]);
                        vlogInfo.Add(curr);
                    }
                }
                else if (log[1] == "followed")
                {
                    if (vloggers.Contains(log[0]) && vloggers.Contains(log[2]) && log[0] != log[2])
                    {
                        int index1 = vlogInfo.FindIndex(x => x.Name == log[0]);
                        int index2 = vlogInfo.FindIndex(x => x.Name == log[2]);

                        if (!vlogInfo[index1].Following.Contains(vlogInfo[index2].Name))
                        {
                            vlogInfo[index1].Following.Add(vlogInfo[index2].Name);
                            vlogInfo[index2].Followers.Add(vlogInfo[index1].Name);
                        }
                    }
                }
                log = Console.ReadLine().Split();
            }

            Console.WriteLine($"The V-Logger has a total of {vlogInfo.Count} vloggers in its logs.");

            vlogInfo = vlogInfo.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Name).ToList();

            Console.WriteLine($"1. {vlogInfo[0].Name} : {vlogInfo[0].Followers.Count} followers, {vlogInfo[0].Following.Count} following");
            foreach (var follower in vlogInfo[0].Followers.OrderBy(x => x))
            {
                Console.WriteLine($"*  {follower}");
            }

            vlogInfo.RemoveAt(0);
            vlogInfo = vlogInfo.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following.Count).ToList();

            for (int i = 0; i < vlogInfo.Count; i++)
            {
                Console.WriteLine($"{i + 2}. {vlogInfo[i].Name} : {vlogInfo[i].Followers.Count} followers, {vlogInfo[i].Following.Count} following");
            }
        }
    }
    class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new List<string>();
            Following = new List<string>();
        }

        public string Name { get; set; }
        public List<string> Followers { get; set; }
        public List<string> Following { get; set; }
    }

}
