using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = commands[0];
                int age = int.Parse(commands[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            Console.Read();
        }
    }
}
