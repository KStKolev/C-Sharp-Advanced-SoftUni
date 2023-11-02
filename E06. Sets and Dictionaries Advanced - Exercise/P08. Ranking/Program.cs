using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Ranking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> contestPasswords = new Dictionary<string, string>();
            string inputProperties = string.Empty;
            while ((inputProperties = Console.ReadLine()) != "end of contests")
            {
                string[] properties = inputProperties.Split(":",StringSplitOptions.RemoveEmptyEntries);
                string contest = properties[0];
                string password = properties[1];
                if (!contestPasswords.ContainsKey(contest))
                {
                    contestPasswords.Add(contest, password);
                }
            }
            SortedDictionary<string, Dictionary<string, int>> contestants = new SortedDictionary<string, Dictionary<string, int>>();
            string infoContest = string.Empty;
            while ((infoContest = Console.ReadLine()) != "end of submissions")
            {
                string[] information = infoContest.Split("=>");
                string contest = information[0];
                string password = information[1];
                string username = information[2];
                int points = int.Parse(information[3]);
                if (contestPasswords.ContainsKey(contest) 
                   && contestPasswords.ContainsValue(password))
                {
                    if (!contestants.ContainsKey(username))
                    {
                        contestants.Add(username, new Dictionary<string, int>());
                        contestants[username].Add(contest, points);
                    }
                    else if(!contestants[username].ContainsKey(contest))
                    {
                        contestants[username].Add(contest, points);
                    }
                    else if(points > contestants[username][contest])
                    {
                        contestants[username][contest] = points;
                    }
                }
            }

            string bestContestant = contestants
               .OrderByDescending(c => c.Value.Values.Sum())
               .First().Key;
            int mostPoints = contestants[bestContestant].Values.Sum();
            Console.WriteLine($"Best candidate is {bestContestant} with total {mostPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var keyValuePair in contestants)
            {
                Console.WriteLine(keyValuePair.Key);
                foreach (var currentContestant in keyValuePair.Value.OrderByDescending(x=> x.Value).ToDictionary(c => c.Key, c => c.Value))
                {
                    Console.WriteLine($"#  {currentContestant.Key} -> {currentContestant.Value}");
                }
            }
            Console.Read();
        }
    }
}
