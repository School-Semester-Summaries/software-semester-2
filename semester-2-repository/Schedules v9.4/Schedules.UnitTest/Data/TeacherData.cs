using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.UnitTest.Data
{
    class TeacherData
    {
        public List<Teacher> TeacherList { get { return _teacherList; } }
        private List<Teacher> _teacherList = new List<Teacher>();
        public TeacherData()
        {
            _teacherList.Add(new Teacher(1, "Selçuk Gögcay", "1965-02-04", "selçukgögcay@schedules.com", 653425354));
            _teacherList.Add(new Teacher(1, "Seyfettin Karniyarik", "1949-05-17", "seyfettinkarniyarik@schedules.com", 656523444));
            _teacherList.Add(new Teacher(1, "Bella Delphine", "2017-09-25", "belladelphine@schedules.com", 645577685));
        }
    }
}
