using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Logic.Interfaces
{
    public interface ISchoolClass
    {
        public void CreateSchoolClass(string name, int year, string suffix);
        public List<SchoolClass> GetAllSchoolClasses();
    }
}
