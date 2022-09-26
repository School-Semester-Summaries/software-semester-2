using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulesOnForms.Models
{
    class ToetsCollection
    {
        // Fields
        static List<Toets> alleToetsen = new List<Toets>();

        // Properties
        public List<Toets> AlleToetsen { get { return alleToetsen; } }
    }
}
