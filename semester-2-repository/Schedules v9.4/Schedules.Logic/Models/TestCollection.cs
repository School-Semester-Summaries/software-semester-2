using Schedules.Logic.Interfaces;
using System.Collections.Generic;

namespace Schedules.Logic.Classes
{
    public class TestCollection
    {
        private readonly ITest _dal;

        public TestCollection(ITest dal)
        {
            _dal = dal;
        }

        public void CreateTest(Subjects subject, string name, int weight)
        {
            _dal.CreateTest(subject, name, weight);
        }

        public List<Test> GetAllTests()
        {
            return _dal.GetAllTests();
        }

        public List<Test> GetAllTestsFromSpecifiedGrades(List<Grade> gradeList)
        {
            return _dal.GetAllTestsFromSpecifiedGrades(gradeList);
        }
    }
}
