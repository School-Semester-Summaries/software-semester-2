using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Presentation.Models
{
    public class SchoolClassViewModel
    {
        public List<SchoolClass> SchoolClassList { get; set; }
        public string Name { get { return "Groep " + Year + Suffix; } }
        public int Year { get; set; }
        public string Suffix { get; set; }
    }
}
