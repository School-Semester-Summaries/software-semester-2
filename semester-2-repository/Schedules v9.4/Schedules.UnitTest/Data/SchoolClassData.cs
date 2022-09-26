using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.UnitTest.Data
{
    class SchoolClassData
    {
        //public List<SchoolClass> SchoolClassList1 { get { return _schoolClassList1; } }
        //public List<SchoolClass> SchoolClassList2 { get { return _schoolClassList2; } }
        public static List<SchoolClass> SchoolClassList = new List<SchoolClass>();
        public List<List<SchoolClass>> ListWithSchoolClassLists { get { return _listWithSchoolClassLists; } }
        private readonly List<SchoolClass> _schoolClassList1 = new List<SchoolClass>();
        private readonly List<SchoolClass> _schoolClassList2 = new List<SchoolClass>();
        private readonly List<List<SchoolClass>> _listWithSchoolClassLists = new List<List<SchoolClass>>();

        public SchoolClassData()
        {
            _schoolClassList1.Add(new SchoolClass("Groep 7a", 7, "a"));
            _schoolClassList1.Add(new SchoolClass("Groep 3a", 3, "a"));
            _schoolClassList1.Add(new SchoolClass("Groep 4a", 4, "a"));
            _schoolClassList1.Add(new SchoolClass("Groep 3b", 3, "b"));
            _schoolClassList1.Add(new SchoolClass("Groep 8a", 8, "a"));
            _schoolClassList1.Add(new SchoolClass("Groep 6b", 6, "b"));
            _listWithSchoolClassLists.Add(_schoolClassList1);

            _schoolClassList2.Add(new SchoolClass("Groep 2b", 2, "b"));
            _schoolClassList2.Add(new SchoolClass("Groep 5a", 5, "a"));
            _schoolClassList2.Add(new SchoolClass("Groep 3a", 3, "a"));
            _schoolClassList2.Add(new SchoolClass("Groep 1b", 1, "b"));
            _schoolClassList2.Add(new SchoolClass("Groep 7a", 7, "a"));
            _schoolClassList2.Add(new SchoolClass("Groep 6a", 6, "a"));
            _listWithSchoolClassLists.Add(_schoolClassList2);
        }

        public static void AddStudent(SchoolClass schoolClass)
        {
            SchoolClassList.Add(schoolClass);
        }
    }
}
