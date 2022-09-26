using AnimalInheritanceParty.Logic;
using AnimalInheritanceParty.Logic.PokemonSubClasses;
using System;

namespace AnimalInheritanceParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fields
            PokemonTeamCollection pokemonTeamCollection = new PokemonTeamCollection();
            PokemonTeam teamOne = new PokemonTeam(pokemonTeamCollection);
            PokemonTeam teamTwo = new PokemonTeam(pokemonTeamCollection);
            PokemonTeam teamThree = new PokemonTeam(pokemonTeamCollection);

            teamOne.Add(new Charmander());
            teamOne.Add(new Oddish());
            teamTwo.Add(new Bulbasaur());
            teamTwo.Add(new Goldeen());
            teamThree.Add(new Squirtle());
            teamThree.Add(new Ponyta());

            DisplayTeam(teamOne);
            DisplayTeam(teamTwo);
            DisplayTeam(teamThree);

            //pokemonTeamCollection.AllPokemonTeams.Clear();

        }

        // Methods
        private static void DisplayTeam(PokemonTeam pokemonTeam)
        {
            Console.WriteLine("Team Red:");
            foreach (Pokemon pokemon in pokemonTeam.PokemonList)
            {
                Console.WriteLine(pokemon.Name);
            }
            Console.WriteLine();
        }
    }
}
