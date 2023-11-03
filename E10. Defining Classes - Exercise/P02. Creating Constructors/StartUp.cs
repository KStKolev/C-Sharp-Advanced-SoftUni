using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            person1.Name = "Peter";
            person1.Age = 20;
            person2.Name = "George";
            person2.Age = 18;
            person3.Name = "Jose";
            person3.Age = 43;
        }
    }
}
