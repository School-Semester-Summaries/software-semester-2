using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty.Logic.PokemonSubClasses
{
    class Ponyta : Pokemon
    {
        public Ponyta()
        {
            Name = "Ponyta";
            Type = Types.Fire;
            Hitpoints = 50;
        }
    }
}
