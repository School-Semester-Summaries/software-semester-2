using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Schedules.DAL
{
    public class TestDAL : ITest
    {
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632;User Id = dbi457632; Password=123456789");
        SqlCommand cmd;

        public void CreateTest(Subjects subject, string name, int weight)
        {
            sqlCon.Open();
            cmd = new SqlCommand("INSERT INTO Test (Subject, Name, Weight) VALUES (@subject, @name, @weight)", sqlCon);
            cmd.Parameters.Add("@subject", SqlDbType.NVarChar).Value = subject.ToString();
            cmd.Parameters.Add("@weight", SqlDbType.Int).Value = weight;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        public List<Test> GetAllTests()
        {
            List<Test> testList = new List<Test>();

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID,Subject,Name,Weight FROM Test", sqlCon);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                int id = Convert.ToInt32(sqlReader["ID"]);
                Subjects subject = (Subjects)Enum.Parse(typeof(Subjects), sqlReader["Subject"].ToString(), true);
                string name = sqlReader["Name"].ToString();
                int weight = Convert.ToInt32(sqlReader["Weight"]);
                testList.Add(new Test(id, subject, name, weight));
            }
            sqlCon.Close();
            return testList;
        }

        public List<Test> GetAllTestsFromSpecifiedGrades(List<Grade> gradeList)
        {
            List<Test> testList = new List<Test>();
            for (int i = 0; i < gradeList.Count; i++)
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID,Subject,Name,Weight FROM Test WHERE ID=@ID ", sqlCon);
                cmd.Parameters.AddWithValue("ID", gradeList[i].TestId);
                SqlDataReader sqlReader;
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["ID"]);
                    Subjects subject = (Subjects)Enum.Parse(typeof(Subjects), sqlReader["Subject"].ToString(), true);
                    string name = sqlReader["Name"].ToString();
                    int weight = Convert.ToInt32(sqlReader["Weight"]);
                    testList.Add(new Test(id, subject, name, weight));
                }
                sqlCon.Close();
            }
            return testList;
        }
    }
}
