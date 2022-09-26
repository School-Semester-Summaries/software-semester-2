using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty.Logic.PokemonSubClasses
{
    class Charmander : Pokemon
    {
        public Charmander()
        {
            Name = "Charmander";
            Type = Types.Fire;
            Hitpoints = 39;
        }
    }
}
