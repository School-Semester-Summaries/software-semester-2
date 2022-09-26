using Schedules.Logic.Interfaces;
using System.Collections.Generic;

namespace Schedules.Logic.Classes
{
    public class GradeCollection
    {
        private readonly IGrade _dal;

        public GradeCollection(IGrade dal)
        {
            _dal = dal;
        }

        public void CreateGrade(int studentId, int testId, decimal grade)
        {
            _dal.CreateGrade(studentId, testId, grade);
        }
        
        public List<Grade> GetAllGradesFromSpecifiedStudent(int studentId)
        {
            return _dal.GetAllGradesFromSpecifiedStudent(studentId);
        }
    }
}
