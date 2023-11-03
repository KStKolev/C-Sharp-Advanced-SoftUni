using System;

namespace GenericBoxofInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int TimesToLoop = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < TimesToLoop; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                box.AddString(digits);
            }
            Console.WriteLine(box.ToString());
            Console.Read();
        }
    }
}
