using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            List<Person> sortedPeople = new List<Person>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = commands[0];
                int age = int.Parse(commands[1]);
                Person person = new Person(name, age);
                if (person.Age > 30)
                {
                    sortedPeople.Add(person);
                }
            }
            foreach (var currentPerson in sortedPeople.OrderBy(person => person.Name))
            {
                Console.WriteLine($"{currentPerson.Name} - {currentPerson.Age}");
            }
            Console.Read();
        }
    }
}
