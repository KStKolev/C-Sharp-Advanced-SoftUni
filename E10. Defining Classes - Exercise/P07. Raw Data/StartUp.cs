using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int timesToLoop = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < timesToLoop; i++)
            {
                string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carProperties[0];
                int engineSpeed = int.Parse(carProperties[1]);
                int enginePower = int.Parse(carProperties[2]);
                int cargoWeight = int.Parse(carProperties[3]);
                string cargoType = carProperties[4];
                double tyre1Pressure = double.Parse(carProperties[5]);
                int tyre1Age = int.Parse(carProperties[6]);
                double tyre2Pressure = double.Parse(carProperties[7]);
                int tyre2Age = int.Parse(carProperties[8]);
                double tyre3Pressure = double.Parse(carProperties[9]);
                int tyre3Age = int.Parse(carProperties[10]);
                double tyre4Pressure = double.Parse(carProperties[11]);
                int tyre4Age = int.Parse(carProperties[12]);
                Car car = new Car(model,
                    new Engine(engineSpeed, enginePower),
                    new Cargo(cargoType, cargoWeight),
                    new Tire[] 
                    {
                        new Tire(tyre1Age, tyre1Pressure), new Tire(tyre2Age, tyre2Pressure),
                        new Tire(tyre3Age, tyre3Pressure), new Tire(tyre4Age, tyre4Pressure) 
                    });
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command.Equals("fragile"))
            {
                foreach (var currentCar in cars)
                {
                    if (currentCar.Cargo.Type.Equals("fragile"))
                    {
                        Car.PrintFragileCars(currentCar.Tires, currentCar.Model);
                    }
                }
            }
            else if (command.Equals("flammable"))
            {
                foreach (var currentCar in cars)
                {
                    if (currentCar.Cargo.Type.Equals("flammable"))
                    {
                        Car.PrintFlammableCars(currentCar.Engine, currentCar.Model);
                    }
                }
            }
            Console.Read();
        }
    }
}
