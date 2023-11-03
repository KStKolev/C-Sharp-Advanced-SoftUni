using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int timesToLoopEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < timesToLoopEngines; i++)
            {
                string[] engineProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = engineProperties[0];
                int power = int.Parse(engineProperties[1]);
                if (engineProperties.Length > 2 && engineProperties.Length < 4)
                {
                    int displacement = 0;
                    if (int.TryParse(engineProperties[2], out displacement))
                    {
                        Engine engine = new Engine(model, power, displacement, null);
                        engines.Add(engine);
                    }
                    else
                    {
                        string efficiency = engineProperties[2];
                        Engine engine = new Engine(model, power, displacement, efficiency);
                        engines.Add(engine);
                    }
                }
                else if (engineProperties.Length == 4)
                {
                    int displacement = int.Parse(engineProperties[2]);
                    string efficiency = engineProperties[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }
            }
            List<Car> cars = new List<Car>();
            int timesToLoopCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < timesToLoopCars; i++)
            {
                string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carProperties[0];
                string engineModel = carProperties[1];
                Engine engine = Engine.ModelSearch(engines, engineModel);
                if (carProperties.Length > 2 && carProperties.Length < 4)
                {
                    int weight = 0;
                    if (int.TryParse(carProperties[2], out weight))
                    {
                        Car car = new Car(model, engine, weight, null);
                        cars.Add(car);
                    }
                    else
                    {
                        string color = carProperties[2];
                        Car car = new Car(model, engine, weight, color);
                        cars.Add(car);
                    }
                }
                else if (carProperties.Length == 4)
                {
                    int weight = int.Parse(carProperties[2]);
                    string color = carProperties[3];
                    Car car = new Car(model, engine, weight, color);
                    cars.Add(car);
                }
                else
                {
                    Car car = new Car(model, engine);
                    cars.Add(car);
                }
            }
            foreach (var currentCar in cars)
            {
                if (currentCar.Engine.Efficiency == null)
                {
                    currentCar.Engine.Efficiency = "n/a";
                }
                if (currentCar.Color == null)
                {
                    currentCar.Color = "n/a";
                }
                Console.WriteLine(currentCar);
            }
            Console.Read();
        }
    }
}
