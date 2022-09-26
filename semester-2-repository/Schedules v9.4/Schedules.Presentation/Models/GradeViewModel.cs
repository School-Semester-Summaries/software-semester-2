using Schedules.Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Schedules.Presentation.Models
{
    public class GradeViewModel
    {
        private readonly List<Subjects> _subjectList = Enum.GetValues(typeof(Subjects)).Cast<Subjects>().ToList();
        
        public int Test_ID { get; set; }
        public int Student_ID { get; set; }
        public decimal Grade { get; set; }
        public List<Grade> GradeList { get; set; }
        public List<Test> TestList { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Subjects> SubjectList { get { return _subjectList; } }
    }
}
