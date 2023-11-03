using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            DateModifier date = new DateModifier();
            Console.WriteLine(date.DifferenceDates(firstInput, secondInput));
            Console.Read();
        }
    }
}
