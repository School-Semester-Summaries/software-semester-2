using System;
using System.Collections.Generic;

namespace AnimalInheritanceParty
{
    public class PokemonTeam
    {
        public PokemonTeam(PokemonTeamCollection pokemonTeamCollection)
        {
            pokemonTeamCollection.Add(this);
        }

        // Fields
        List<Pokemon> pokemonList = new List<Pokemon>();

        // Property
        public List<Pokemon> PokemonList { get { return pokemonList; } }

        // Methods
        public void Add(Pokemon pokemon)
        {
            pokemonList.Add(pokemon);
        }
    }
}