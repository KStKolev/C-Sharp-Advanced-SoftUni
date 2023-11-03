using System;

namespace GenericCountMethodDouble
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < timesToLoop; i++)
            {
                double inputText = double.Parse(Console.ReadLine());
                box.AddString(inputText);
            }
            double elementToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CompareCount(elementToCompare));
            Console.Read();
        }
    }
}
