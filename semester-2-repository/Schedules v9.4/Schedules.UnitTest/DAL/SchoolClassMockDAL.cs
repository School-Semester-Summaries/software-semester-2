using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;

namespace Schedules.UnitTest.Data
{
    public class SchoolClassMockDAL : ISchoolClass
    {
        public void CreateSchoolClass(string name, int year, string suffix)
        {
            SchoolClassData.AddStudent(new SchoolClass(name, year, suffix));
        }

        public List<SchoolClass> GetAllSchoolClasses()
        {
            throw new NotImplementedException();
        }
    }
}
