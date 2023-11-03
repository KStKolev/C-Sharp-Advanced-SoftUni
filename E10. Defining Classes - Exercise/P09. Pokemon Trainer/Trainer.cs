using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, int badges, List<Pokemon> pokemons)
        {
            this.Name = name;
            this.Badges = badges;
            this.Pokemons = pokemons;
        }

        public string Name { get => name; set => name = value; }
        public int Badges { get => badges; set => badges = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }

        public List<Pokemon> ElementChecker(string elementInput) 
        {
            List<Pokemon> afterTournamentPokemons = Pokemons;
            bool isOtherElement = false;
            foreach (var pokemon in Pokemons)
            {
                if (pokemon.Element.Equals(elementInput))
                {
                    isOtherElement = false;
                    Badges++;
                    break;
                }
                else
                {
                    isOtherElement = true;
                }
            }
            if (isOtherElement == true)
            {
                foreach (var pokemon in Pokemons)
                {
                    pokemon.Health -= 10;
                }
            }
            Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
            return Pokemons;
        }
    }
}
