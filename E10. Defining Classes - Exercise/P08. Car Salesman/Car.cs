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
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            if (engine.Displacement == 0 && weight == 0)
            {
                return string.Format($"{Model}:" + Environment.NewLine + $"  {Engine.Model}:" + Environment.NewLine + $"   Power: {Engine.Power}"
                + Environment.NewLine + $"   Displacement: n/a" + Environment.NewLine + $"   Efficiency: {Engine.Efficiency}"
                + Environment.NewLine + $"  Weight: n/a" + Environment.NewLine + $"  Color: {Color}");
            }
            else if (weight == 0)
            {
                return string.Format($"{Model}:" + Environment.NewLine + $"  {Engine.Model}:" + Environment.NewLine + $"   Power: {Engine.Power}"
                + Environment.NewLine + $"   Displacement: {Engine.Displacement}" + Environment.NewLine + $"   Efficiency: {Engine.Efficiency}"
                + Environment.NewLine + $"  Weight: n/a" + Environment.NewLine + $"  Color: {Color}");
            }
            else if (engine.Displacement == 0)
            {
                return string.Format($"{Model}:" + Environment.NewLine + $"  {Engine.Model}:" + Environment.NewLine + $"   Power: {Engine.Power}"
                + Environment.NewLine + $"   Displacement: n/a" + Environment.NewLine + $"   Efficiency: {Engine.Efficiency}"
                + Environment.NewLine + $"  Weight: {Weight}" + Environment.NewLine + $"  Color: {Color}");
            }
            return string.Format($"{Model}:" + Environment.NewLine + $"  {Engine.Model}:" + Environment.NewLine + $"   Power: {Engine.Power}"
                + Environment.NewLine + $"   Displacement: {Engine.Displacement}" + Environment.NewLine + $"   Efficiency: {Engine.Efficiency}"
                + Environment.NewLine + $"  Weight: {Weight}" + Environment.NewLine + $"  Color: {Color}");
        }
    }
}
