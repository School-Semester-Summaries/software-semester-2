using Schedules.Logic.Classes;
using System.Collections.Generic;

namespace Schedules.Logic.Interfaces
{
    public interface IStudent
    {
        public void CreateStudent(int schoolClassId, string name, string birthdate, string mail, int phone);

        public List<Student> GetAllStudents();

        public Student GetStudentById(int studentId);
    }
}
