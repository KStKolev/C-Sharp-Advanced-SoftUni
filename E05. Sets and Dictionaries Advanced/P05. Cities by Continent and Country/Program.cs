using System;
using System.Collections.Generic;

namespace P05._Cities_by_Continent_and_Country
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> earthContinentals = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] worldPlaces = Console.ReadLine().Split();
                string continent = worldPlaces[0];
                string country = worldPlaces[1];
                string city = worldPlaces[2];
                if (!earthContinentals.ContainsKey(continent))
                {
                    earthContinentals.Add(continent, new Dictionary<string, List<string>>());
                    earthContinentals[continent].Add(country, new List<string>());
                    earthContinentals[continent][country].Add(city);
                }
                else if(!earthContinentals[continent].ContainsKey(country))
                {
                    earthContinentals[continent].Add(country, new List<string>());
                    earthContinentals[continent][country].Add(city);
                }
                else
                {
                    earthContinentals[continent][country].Add(city);
                }
            }
            foreach (var keyValuePair in earthContinentals)
            {
                Console.WriteLine($"{keyValuePair.Key}:");
                foreach (var currentValue in keyValuePair.Value)
                {
                    Console.WriteLine($"{currentValue.Key} -> {string.Join(", ", currentValue.Value)}");
                }
            }
            Console.Read();
        }
    }
}
