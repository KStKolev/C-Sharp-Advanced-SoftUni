using System;

namespace ManageTuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] address = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, string> tuple1 = new Tuple<string, string>(address[0] + " " + address[1], address[2]);
            string[] litersPerson = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, int> tuple2 = new Tuple<string, int>(litersPerson[0], int.Parse(litersPerson[1]));
            string[] digits = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(digits[0]), double.Parse(digits[1]));
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
