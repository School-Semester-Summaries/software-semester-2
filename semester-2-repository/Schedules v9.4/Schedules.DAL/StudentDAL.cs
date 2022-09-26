using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Schedules.DAL
{
    public class StudentDAL : IStudent
    {
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632;User Id = dbi457632; Password=123456789");
        SqlCommand cmd;

        public void CreateStudent(int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            // before adding student to schoolclass check how many students there are in that schoolclass
            if (new SchoolClassDAL().HowManyStudentsInSchoolClass(schoolClassId) < SchoolClassCollection.MaxStudentsInSchoolClass)
            {
                sqlCon.Open();
                cmd = new SqlCommand("INSERT INTO Student (SchoolClass_ID, Name, Phone, Birthdate, Mail) VALUES (@schoolClassId, @name, @phone, @birthdate, @mail)", sqlCon);
                cmd.Parameters.Add("@schoolClassId", SqlDbType.Int).Value = schoolClassId;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            else
            {
                // give message, already 5 people in schoolClass
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,SchoolClass_ID,Name,Birthdate,Mail,Phone FROM Student", sqlCon);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                int id = Convert.ToInt32(sqlReader["ID"]);
                int schoolClassId = Convert.ToInt32(sqlReader["SchoolClass_ID"]);
                string name = sqlReader["Name"].ToString();
                string birthdate = sqlReader["Birthdate"].ToString();
                string mail = sqlReader["Mail"].ToString();
                int phone = Convert.ToInt32(sqlReader["Phone"]);

                studentList.Add(new Student(id, schoolClassId, name, birthdate, mail, phone));
            }
            sqlCon.Close();
            return studentList;
        }

        public Student GetStudentById(int studentId)
        {
            Student student = new Student(0, 0, "", "", "", 0);

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,SchoolClass_ID,Name,Birthdate,Mail,Phone FROM Student WHERE ID=@ID", sqlCon);
            cmd.Parameters.AddWithValue("ID", studentId);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                int id = Convert.ToInt32(sqlReader["ID"]);
                int schoolClassId = Convert.ToInt32(sqlReader["SchoolClass_ID"]);
                string name = sqlReader["Name"].ToString();
                string birthdate = sqlReader["Birthdate"].ToString();
                string mail = sqlReader["Mail"].ToString();
                int phone = Convert.ToInt32(sqlReader["Phone"]);
                student = new Student(id, schoolClassId, name, birthdate, mail, phone);
            }
            sqlCon.Close();
            return student;
        }

        //public List<string> GetAllStudentNames()
        //{
        //    List<string> studentNameList = new List<string>();
        //    sqlCon.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT Name FROM Student", sqlCon);
        //    SqlDataReader sqlReader;
        //    sqlReader = cmd.ExecuteReader();
        //    while (sqlReader.Read())
        //    {
        //        studentNameList.Add(sqlReader["Name"].ToString());
        //    }
        //    sqlCon.Close();
        //    return studentNameList;
        //}

        //public List<int> GetAllStudentIDs()
        //{
        //    List<int> studentIdList = new List<int>();
        //    sqlCon.Open();
        //    SqlCommand cmd = new SqlCommand("SELECT ID FROM Student", sqlCon);
        //    SqlDataReader sqlReader;
        //    sqlReader = cmd.ExecuteReader();
        //    while (sqlReader.Read())
        //    {
        //        studentIdList.Add(Convert.ToInt32(sqlReader["ID"]));
        //    }
        //    sqlCon.Close();
        //    return studentIdList;
        //}
    }
}
