using Schedules.Logic.Classes;
using Schedules.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Schedules.DAL
{
    public class GradeDAL : IGrade
    {
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632;User Id = dbi457632; Password=123456789");
        SqlCommand cmd;

        public void CreateGrade(int studentId, int testId, decimal grade)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            sqlFormattedDate = sqlFormattedDate.Replace('/', '-');
            sqlFormattedDate = sqlFormattedDate.Substring(0, 10);

            sqlCon.Open();
            cmd = new SqlCommand("INSERT INTO Grade (Student_ID, Test_ID, Grade, SubmissionDate) VALUES (@Student_ID, @Test_ID, @Grade, @SubmissionDate)", sqlCon);
            cmd.Parameters.Add("@Student_ID", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("@Test_ID", SqlDbType.Int).Value = testId;
            cmd.Parameters.Add("@Grade", SqlDbType.Decimal).Value = grade;
            cmd.Parameters.Add("@SubmissionDate", SqlDbType.Date).Value = sqlFormattedDate;
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        public List<Grade> GetAllGradesFromSpecifiedStudent(int studentId)
        {
            List<Grade> gradeList = new List<Grade>();
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT Test_ID,Grade,SubmissionDate FROM Grade WHERE Student_ID=@Student_ID", sqlCon);
            cmd.Parameters.AddWithValue("Student_ID", studentId);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                int testId = Convert.ToInt32(sqlReader["Test_ID"]);
                decimal grade = Convert.ToDecimal(sqlReader["Grade"]);
                string submissionDate = sqlReader["SubmissionDate"].ToString().Substring(0, 10);
                gradeList.Add(new Grade(studentId, testId, grade, submissionDate));
            }
            sqlCon.Close();
            return gradeList;
        }
    }
}
