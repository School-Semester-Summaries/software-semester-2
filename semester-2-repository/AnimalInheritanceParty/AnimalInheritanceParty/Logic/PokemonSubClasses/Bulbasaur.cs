using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty.Logic.PokemonSubClasses
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            Name = "Bulbasaur";
            Type = Types.Grass;
            Hitpoints = 45;
        }
    }
}
