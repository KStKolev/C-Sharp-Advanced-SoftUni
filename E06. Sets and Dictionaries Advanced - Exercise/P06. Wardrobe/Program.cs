using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Wardrobe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] inputClothes = Console.ReadLine().Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = inputClothes[0];
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                for (int l = 1; l < inputClothes.Length; l++)
                {
                    if (!clothes[color].ContainsKey(inputClothes[l]))
                    {
                        clothes[color].Add(inputClothes[l], 1);
                    }
                    else
                    {
                        clothes[color][inputClothes[l]]++;
                    }
                }
            }
            string[] wantedClothing = Console.ReadLine().Split();
            string wantedColor = wantedClothing[0];
            string clothing = wantedClothing[1];
            foreach (var keyValuePair in clothes)
            {
                Console.WriteLine($"{keyValuePair.Key} clothes:");
                if (keyValuePair.Key.Equals(wantedColor))
                {
                    foreach (var valuePair in keyValuePair.Value)
                    {
                        if (valuePair.Key.Equals(clothing))
                        {
                            Console.WriteLine($"* {valuePair.Key} - {valuePair.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {valuePair.Key} - {valuePair.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var valuePair in keyValuePair.Value)
                    {
                        Console.WriteLine($"* {valuePair.Key} - {valuePair.Value}");
                    }
                }
            }
            Console.Read();
        }
    }
}
