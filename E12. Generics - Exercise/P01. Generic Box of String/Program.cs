using System;

namespace GenericBoxofString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int TimesToLoop = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < TimesToLoop; i++)
            {
                string inputText = Console.ReadLine();
                box.AddString(inputText);
            }
            Console.WriteLine(box.ToString());
            Console.Read();
        }
    }
}
