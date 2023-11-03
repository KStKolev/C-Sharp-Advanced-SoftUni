using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires = new Tire[4];

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public Cargo Cargo { get => cargo; set => cargo = value; }
        public Tire[] Tires { get => tires; set => tires = value; }

        public static void PrintFragileCars(Tire[] tires, string model)
        {
            if (tires.Any(tire => tire.Pressure < 1))
            {
                Console.WriteLine(model);
            }
        }

        public static void PrintFlammableCars(Engine engine, string model)
        {

            if (engine.Power > 250)
            {
                Console.WriteLine(model);
            }

        }
    }
}
