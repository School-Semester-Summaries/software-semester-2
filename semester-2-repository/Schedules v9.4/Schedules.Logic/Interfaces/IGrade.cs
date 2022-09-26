using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Logic.Interfaces
{
    public interface IGrade
    {
        public void CreateGrade(int studentId, int testId, decimal grade);

        public List<Grade> GetAllGradesFromSpecifiedStudent(int studentId);
    }
}
