using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            List<Trainer> trainers = new List<Trainer>();
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = commands[0];
                string pokemonName = commands[1];
                string element = commands[2];
                int health = int.Parse(commands[3]);
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                if (trainer != null)
                {
                    trainer.Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName, 0, new List<Pokemon>());
                    newTrainer.Pokemons.Add(pokemon);
                    trainers.Add(newTrainer);
                }
            }
            string elementInput = string.Empty;
            while ((elementInput = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.Pokemons = trainer.ElementChecker(elementInput);
                }
            }
            foreach (var currentTrainer in trainers.OrderByDescending(trainer => trainer.Badges))
            {
                Console.WriteLine($"{currentTrainer.Name} {currentTrainer.Badges} {currentTrainer.Pokemons.Count}");
            }
            Console.Read();
        }
    }
}
