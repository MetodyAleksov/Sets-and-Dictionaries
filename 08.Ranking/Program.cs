using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string[] curr = Console.ReadLine().Split(":");
            while (curr[0] != "end of contests")
            {
                contests.Add(curr[0], curr[1]);

                curr = Console.ReadLine().Split(":");
            }

            List<User> users = new List<User>();

            string[] input = Console.ReadLine().Split("=>");
            while (input[0] != "end of submissions")
            {
                if (contests.ContainsKey(input[0]))
                {
                    if (contests[input[0]] == input[1])
                    {
                        int index = users.FindIndex(x => x.Name == input[2]);
                        if (index >= 0)
                        {
                            if (users[index].Contests.ContainsKey(input[0]))
                            {
                                if (users[index].Contests[input[0]] < int.Parse(input[3]))
                                {
                                    users[index].Contests[input[0]] = int.Parse(input[3]);
                                }
                            }
                            else
                            {
                                users[index].Contests.Add(input[0], int.Parse(input[3]));
                            }
                        }
                        else
                        {
                            users.Add(new User(input[2]));
                            users[users.FindIndex(x => x.Name == input[2])].Contests.Add(input[0], int.Parse(input[3]));
                        }
                        
                    }
                }
                input = Console.ReadLine().Split("=>");
            }

            users = users.OrderByDescending(x => x.Contests.Values.Sum()).ToList();

            Console.WriteLine($"Best candidate is {users[0].Name} with total {users[0].Contests.Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in users.OrderBy(x => x.Name))
            {
                Console.WriteLine(item.Name);
                foreach (var contest in item.Contests.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }

    class User
    {
        public User(string name)
        {
            Name = name;
            Contests = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> Contests { get; set; }
    }


}
