using Schedules.Logic.Interfaces;
using System.Collections.Generic;

namespace Schedules.Logic.Classes
{
    public class SchoolClassCollection
    {
        public const int MaxStudentsInSchoolClass = 5;
        private readonly ISchoolClass _dal;

        public SchoolClassCollection(ISchoolClass dal)
        {
            _dal = dal;
        }

        public void CreateSchoolClass(string name, int year, string suffix)
        {
            _dal.CreateSchoolClass(name, year, suffix);
        }

        public List<SchoolClass> GetAllSchoolClasses()
        {
            List<SchoolClass> schoolClassList = _dal.GetAllSchoolClasses();
            return SortListOnYear(schoolClassList);
        }

        public List<SchoolClass> SortListOnYear(List<SchoolClass> schoolClassListParam)
        {
            List<SchoolClass> schoolClassList = schoolClassListParam;
            List<SchoolClass> sortedSchoolClassList = new List<SchoolClass>();
            SchoolClass schoolClassWithLowestYear;

            while (schoolClassList.Count > 0)
            {
                schoolClassWithLowestYear = new SchoolClass("", int.MaxValue, "");
                foreach (SchoolClass schoolClass in schoolClassList)
                {
                    if (schoolClass.Year < schoolClassWithLowestYear.Year)
                    {
                        schoolClassWithLowestYear = schoolClass;
                    }
                }
                sortedSchoolClassList.Add(schoolClassWithLowestYear);
                schoolClassList.Remove(schoolClassWithLowestYear);
            }
            return sortedSchoolClassList;
        }
    }
}
