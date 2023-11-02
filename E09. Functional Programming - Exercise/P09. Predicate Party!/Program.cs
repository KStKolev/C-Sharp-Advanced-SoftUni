namespace P09._Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> plannedPeople = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string inputText = string.Empty;
            while ((inputText = Console.ReadLine()) != "Party!")
            {
                string[] commands = inputText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string criteria = commands[1];
                string value = commands[2];
                if (command.Equals("Remove"))
                {
                    plannedPeople.RemoveAll(GetPredicate(criteria, value));
                }
                else if (command.Equals("Double"))
                {
                    List<string> doublePeople = plannedPeople.FindAll(GetPredicate(criteria, value));
                    foreach (var person in doublePeople)
                    {
                        int index = doublePeople.FindIndex(p => p == person);
                        plannedPeople.Insert(index, person);
                    }
                }
            }
            if (plannedPeople.Any())
            {
                Console.WriteLine($"{string.Join(", ", plannedPeople)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            Console.Read();

            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "StartsWith":
                        return p => p.StartsWith(value);
                    case "EndsWith":
                        return p => p.EndsWith(value);
                    case "Length":
                        return p => p.Length == int.Parse(value);
                    default:
                        return default;
                }
            }
        }
    }
}
