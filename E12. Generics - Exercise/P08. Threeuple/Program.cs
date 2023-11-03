using System;

namespace CustomThreeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] address = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(address[0] + " " + address[1], address[2], string.Join(" ", address[3..]));
            string[] litersPerson = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(litersPerson[0], int.Parse(litersPerson[1]), litersPerson[2].Equals("drunk"));
            string[] bank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(bank[0], double.Parse(bank[1]), bank[2]);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
            Console.Read();
        }
    }
}
