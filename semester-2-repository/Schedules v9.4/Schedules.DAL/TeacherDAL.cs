using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Schedules.DAL
{
    public class TeacherDAL : ITeacher
    {
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632;User Id = dbi457632; Password=123456789");
        SqlCommand cmd;

        public void CreateTeacher(int schoolClassId, string name, string birthdate, string mail, int phone)
        {
            if (HowManyTeachersInSchoolClass(schoolClassId) < 1)
            {
                sqlCon.Open();
                cmd = new SqlCommand("INSERT INTO Teacher (SchoolClass_ID, Name, Birthdate, Phone, Mail) VALUES (@schoolClassId, @name, @birthdate, @phone, @mail)", sqlCon);
                cmd.Parameters.Add("@schoolClassId", SqlDbType.Int).Value = schoolClassId;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = birthdate;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            else
            {
                throw new OverflowException();
            }
        }

        public Teacher GetTeacherByID(int Teacher_ID)
        {
            Teacher teacher = new Teacher(0, null, null, null, 0);
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT SchoolClass_ID,Name,Phone,Birthdate,Mail FROM Teacher WHERE ID=@ID", sqlCon);
            cmd.Parameters.AddWithValue("ID", Teacher_ID);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                int schoolClassId = Convert.ToInt32(sqlReader["SchoolClass_ID"]);
                string name = sqlReader["Name"].ToString();
                int phone = Convert.ToInt32(sqlReader["Phone"]);
                string birthdate = sqlReader["Birthdate"].ToString();
                string mail = sqlReader["Mail"].ToString();
                teacher = new Teacher(schoolClassId, name, birthdate, mail, phone);
            }
            sqlCon.Close();
            return teacher;
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teacherList = new List<Teacher>();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,SchoolClass_ID,Name,Phone,Birthdate,Mail FROM Teacher", sqlCon);
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
                teacherList.Add(new Teacher(id, schoolClassId, name, birthdate, mail, phone));
            }
            sqlCon.Close();
            return teacherList;
        }

        public int HowManyTeachersInSchoolClass(int schoolClassId)
        {
            int amountOfTeachersInSchoolClass = 0;
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT SchoolClass_ID FROM Teacher WHERE SchoolClass_ID=@SchoolClass_ID", sqlCon);
            cmd.Parameters.AddWithValue("SchoolClass_ID", schoolClassId);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                amountOfTeachersInSchoolClass++;
            }
            sqlCon.Close();
            return amountOfTeachersInSchoolClass;
        }
    }
}
