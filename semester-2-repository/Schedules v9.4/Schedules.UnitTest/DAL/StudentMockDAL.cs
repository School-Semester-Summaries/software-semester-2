using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;

namespace Schedules.UnitTest.Data
{
    class StudentMockDAL : IStudent
    {
        public void CreateStudent(int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int studentId)
        {
            throw new NotImplementedException();
        }
    }
}
