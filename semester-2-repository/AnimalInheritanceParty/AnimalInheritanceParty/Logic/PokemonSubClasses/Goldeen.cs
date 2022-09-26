using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty.Logic.PokemonSubClasses
{
    class Goldeen : Pokemon
    {
        public Goldeen()
        {
            Name = "Goldeen";
            Type = Types.Water;
            Hitpoints = 45;
        }
    }
}
