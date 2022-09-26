using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritanceParty.Logic
{
    class Oddish : Pokemon
    {
        public Oddish()
        {
            Name = "Oddish";
            Type = Types.Grass;
            Hitpoints = 45;
        }
    }
}
