using Schedules.Logic.Interfaces;
using System.Collections.Generic;

namespace Schedules.Logic.Classes
{
    public class StudentCollection
    {
        private readonly IStudent _dal;

        public StudentCollection(IStudent dal)
        {
            _dal = dal;
        }

        public void CreateStudent(int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            Student student = new Student(schoolClassId, name, birthdate, mail, phone);
            _dal.CreateStudent(schoolClassId, name, birthdate, mail, phone);
        }

        public List<Student> GetAllStudents()
        {
            return _dal.GetAllStudents();
        }

        public Student GetStudentById(int studentId)
        {
            return _dal.GetStudentById(studentId);
        }
    }
}
