using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Logic.Interfaces
{
    public interface ITest
    {
        public void CreateTest(Subjects subject, string name, int weight);

        public List<Test> GetAllTests();

        public List<Test> GetAllTestsFromSpecifiedGrades(List<Grade> gradeList);
    }
}
