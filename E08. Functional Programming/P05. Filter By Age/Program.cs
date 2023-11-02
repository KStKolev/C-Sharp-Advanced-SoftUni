namespace P05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            List<Person> people = ReadPeople(timesToLoop);
            string input = Console.ReadLine();
            int ageInput = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = FilterPeople(input, ageInput);
            people = people.Where(x => filter(x)).ToList();
            string printProperties = Console.ReadLine();
            Action<Person> printer = CreatePrinter(printProperties);
            foreach (var person in people)
            {
                printer(person);
            }
            Console.Read();
        }

        private static Action<Person> CreatePrinter(string printProperties)
        {
            switch (printProperties)
            {
                case "name":
                    return person => Console.WriteLine($"{person.name}");
                case "age":
                    return person => Console.WriteLine($"{person.age}");
                case "name age":
                    return person => Console.WriteLine($"{person.name} - {person.age}");
                default:
                    throw new ArgumentException(printProperties);
            }
        }

        private static Func<Person, bool> FilterPeople(string input, int ageInput)
        {
            switch (input)
            {
                case "younger":
                    return x => x.age < ageInput;
                case "older":
                    return x => x.age >= ageInput;
                default:
                    throw new ArgumentException(input);
            }
        }

        private static List<Person> ReadPeople(int timesToLoop)
        {
            List<Person> person = new List<Person>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] words = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = words[0];
                int age = int.Parse(words[1]);
                person.Add(new Person(name, age));
            }
            return person;
        }

        public class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
    }
}
