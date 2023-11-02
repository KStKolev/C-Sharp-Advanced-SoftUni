namespace P04._Add_VAT
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<double, double> percentage = x => x + x * 0.20;
            double[] digits = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => percentage(x)).ToArray();
            foreach (var digit in digits)
            {
                Console.WriteLine($"{digit:F2}");
            }
            Console.Read();
        }
    }
}
