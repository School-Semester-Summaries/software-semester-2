using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty.Logic.PokemonSubClasses
{
    class Squirtle : Pokemon
    {
        public Squirtle()
        {
            Name = "Squirtle";
            Type = Types.Water;
            Hitpoints = 44;
        }
    }
}
