using Schedules.Logic.Interfaces;
using System.Collections.Generic;

namespace Schedules.Logic.Classes
{
    public class TeacherCollection
    {
        private readonly ITeacher _dal;

        public TeacherCollection(ITeacher dal)
        {
            _dal = dal;
        }

        public void CreateTeacher(int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            Teacher teacher = new Teacher(schoolClassId, name, birthdate, mail, phone);
            _dal.CreateTeacher(schoolClassId, name, birthdate, mail, phone);
        }

        public List<Teacher> GetAllTeachers()
        {
            return _dal.GetAllTeachers();
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return _dal.GetTeacherByID(teacherId);
        }
    }
}
