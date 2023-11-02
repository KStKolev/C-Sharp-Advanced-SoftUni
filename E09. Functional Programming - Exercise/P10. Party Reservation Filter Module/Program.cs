namespace P10._Party_Reservation_Filter_Module
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
            Dictionary<string, Predicate<string>> filters = new();
            string inputText = string.Empty;
            while ((inputText = Console.ReadLine()) != "Print")
            {
                string[] commands = inputText.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string criteria = commands[1];
                string value = commands[2];
                if (command.Equals("Add filter"))
                {
                    filters.Add(criteria + value, GetPredicate(criteria, value));
                }
                else if (command.Equals("Remove filter"))
                {
                    filters.Remove(criteria + value);
                }
            }
            foreach (var filter in filters)
            {
                plannedPeople.RemoveAll(filter.Value);
            }
            Console.WriteLine(string.Join(" ", plannedPeople));
            Console.Read();

            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "Starts with":
                        return p => p.StartsWith(value);
                    case "Ends with":
                        return p => p.EndsWith(value);
                    case "Length":
                        return p => p.Length == int.Parse(value);
                    case "Contains":
                        return p => p.Contains(value);
                    default:
                        return default;
                }
            }
        }
    }
}
