using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Schedules.DAL
{
    public class SchoolClassDAL : ISchoolClass
    {
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632;User Id = dbi457632; Password=123456789");
        SqlCommand cmd;

        public void CreateSchoolClass(string name, int year, string suffix)
        {
            if (!SchoolClassAlreadyExists(name))
            {
                sqlCon.Open();
                cmd = new SqlCommand("INSERT INTO SchoolClass (Name, Year, Suffix) VALUES(@name, @year, @suffix)", sqlCon);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@year", SqlDbType.Int).Value = year;
                cmd.Parameters.Add("@suffix", SqlDbType.NVarChar).Value = suffix;
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            else
            {
                Console.WriteLine("ERROR: " + name + " bestaat al");
                throw new Exception();
            }
        }

        int GetSpecifiedSchoolClassId(string name, int id)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM SchoolClass WHERE name=@name", sqlCon);
            cmd.Parameters.AddWithValue("name", name);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                id = (int)sqlReader["ID"];
            }
            sqlCon.Close();
            return id;
        }

        bool SchoolClassAlreadyExists(string name)
        {
            return (GetSpecifiedSchoolClassId(name, 0) != 0);
        }

        public List<SchoolClass> GetAllSchoolClasses()
        {
            List<SchoolClass> schoolClassList = new List<SchoolClass>();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,Name,Year,Suffix FROM SchoolClass", sqlCon);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                int id = Convert.ToInt32(sqlReader["ID"]);
                string name = sqlReader["Name"].ToString();
                int year = Convert.ToInt32(sqlReader["Year"]);
                string suffix = sqlReader["Suffix"].ToString();
                schoolClassList.Add(new SchoolClass(id, name, year, suffix));
            }
            sqlCon.Close();
            return schoolClassList;
        }

        public int HowManyStudentsInSchoolClass(int schoolClassId)
        {
            int amountOfStudentsInSchoolClass = 0;

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT SchoolClass_ID FROM Student WHERE SchoolClass_ID=@SchoolClass_ID", sqlCon);
            cmd.Parameters.AddWithValue("SchoolClass_ID", schoolClassId);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                amountOfStudentsInSchoolClass++;
            }
            sqlCon.Close();

            return amountOfStudentsInSchoolClass;
        }
    }
}
