using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public string Name { get => name; set => name = value; }
        public string Element { get => element; set => element = value; }
        public int Health { get => health; set => health = value; }
    }
}
