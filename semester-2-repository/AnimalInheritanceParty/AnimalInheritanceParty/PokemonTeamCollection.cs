using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty
{
    public class PokemonTeamCollection
    {
        public PokemonTeamCollection()
        {

        }

        // Fields
        List<PokemonTeam> allPokemonTeams = new List<PokemonTeam>();

        // Properties
        public List<PokemonTeam> AllPokemonTeams { get { return allPokemonTeams; } }

        // Methods
        public void Add(PokemonTeam pokemonTeam)
        {
            allPokemonTeams.Add(pokemonTeam);
        }
    }
}
