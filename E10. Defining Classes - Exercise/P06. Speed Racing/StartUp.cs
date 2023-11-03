using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCarsToTrack = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCarsToTrack; i++)
            {
                string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carProperties[0];
                double fuelAmount = double.Parse(carProperties[1]);
                double fuelConsumptionFor1km = double.Parse(carProperties[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = commands[1];
                int amountOfKm = int.Parse(commands[2]);
                foreach (var currentCar in cars)
                {
                    if (currentCar.Model.Equals(carModel))
                    {
                        currentCar.TravelCar(carModel, amountOfKm);
                        break;
                    }
                }
            }
            foreach (var currentCar in cars)
            {
                Console.WriteLine($"{currentCar.Model} {currentCar.FuelAmount:F2} {currentCar.TravelledDistance} ");
            }
            Console.Read();
        }
    }
}
