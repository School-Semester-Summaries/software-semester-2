using Schedules.Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schedules.Presentation.Models
{
    public class TestViewModel
    {
        private List<Subjects> _subjectList = Enum.GetValues(typeof(Subjects)).Cast<Subjects>().ToList();
        public List<Subjects> SubjectList { get { return _subjectList; } }
        public Subjects Subject { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }
    }
}
