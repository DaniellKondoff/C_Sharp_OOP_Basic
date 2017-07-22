using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<Trainer> trainersList = new HashSet<Trainer>();

            while (input != "Tournament")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = trainersList.FirstOrDefault(t=>t.Name==trainerName);
               
                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                }
                trainer.Pokemons.Add(pokemon);
                trainersList.Add(trainer);

                input = Console.ReadLine();
            }

            string cmd = Console.ReadLine();

            while (cmd != "End")
            {
                foreach (var trainer in trainersList)
                {
                    if (trainer.Pokemons.Any(p=>p.Element==cmd))
                    {
                        trainer.NumberOfBadges += 1;
                    }
                    else
                    {
                        trainer.Pokemons.ToList().ForEach(p=>p.Health-=10);
                        var killedPokemons = trainer.Pokemons.Where(p => p.Health <= 0).ToList();
                        if (killedPokemons != null)
                        {
                            foreach (var pokemon in killedPokemons)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                        }
                    }
                }

                cmd = Console.ReadLine();
            }

            trainersList.OrderByDescending(t => t.NumberOfBadges).ToList()
                .ForEach(t => Console.WriteLine($"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count}"));
        }
    }
}
