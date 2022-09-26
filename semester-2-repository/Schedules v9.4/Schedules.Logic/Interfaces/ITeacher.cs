using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Logic.Interfaces
{
    public interface ITeacher
    {
        public void CreateTeacher(int schoolClassId, string name, string birthdate, string mail, int phone);

        public Teacher GetTeacherByID(int Teacher_ID);

        public List<Teacher> GetAllTeachers();
    }
}
