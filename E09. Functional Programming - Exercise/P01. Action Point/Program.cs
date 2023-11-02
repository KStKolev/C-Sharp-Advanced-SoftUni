namespace P01._Action_Point
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<string[]> print = name =>
            {
                Console.WriteLine(string.Join(Environment.NewLine, name));
            };
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            print(names);
            Console.Read();
        }
    }
}
