using System;
using System.Collections.Generic;

namespace P07._Parking_Lot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputCommand = string.Empty;
            HashSet<string> carNumbers = new HashSet<string>();
            while ((inputCommand = Console.ReadLine()) != "END")
            {
                string[] commands = inputCommand.Split(", ");
                string direction = commands[0];
                string carNumber = commands[1];
                if (direction.Equals("IN"))
                {
                    carNumbers.Add(carNumber);
                }
                else if (direction.Equals("OUT"))
                {
                    carNumbers.Remove(carNumber);
                }
            }
            if (carNumbers.Count > 0)
            {
                foreach (var currentCarNumber in carNumbers)
                {
                    Console.WriteLine(currentCarNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            Console.Read();
        }
    }
}
