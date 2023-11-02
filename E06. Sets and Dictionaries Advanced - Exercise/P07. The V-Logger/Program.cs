using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._The_V_Logger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string inputCommand = string.Empty;
            while ((inputCommand = Console.ReadLine()) != "Statistics")
            {
                string[] commands = inputCommand.Split();
                string nameVlogger = commands[0];
                string command = commands[1];
                if (command.Equals("joined") && !vloggers.ContainsKey(nameVlogger))
                {
                    vloggers.Add(nameVlogger, new Dictionary<string, HashSet<string>>());
                    vloggers[nameVlogger].Add("followers", new HashSet<string>());
                    vloggers[nameVlogger].Add("following", new HashSet<string>());
                }
                else if (command.Equals("followed"))
                {
                    string followed = commands[2];
                    if (vloggers.ContainsKey(nameVlogger) 
                        && vloggers.ContainsKey(followed) 
                        && !followed.Equals(nameVlogger))
                    {
                        vloggers[nameVlogger]["following"].Add(followed);
                        vloggers[followed]["followers"].Add(nameVlogger);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Dictionary<string, Dictionary<string, HashSet<string>>> orderedVloggers = vloggers
            .OrderByDescending(v => v.Value["followers"].Count)
            .ThenBy(v => v.Value["following"].Count)
            .ToDictionary(v => v.Key, v => v.Value);

            int count = 1;
            foreach (var vlogger in orderedVloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                if (count == 1)
                {
                    List<string> orderedFollowers = vlogger.Value["followers"]
                        .OrderBy(x => x)
                        .ToList();
                    foreach (var follower in orderedFollowers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
            Console.Read();
        }
    }
}
