using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformsStaticLogin.Models;

namespace WinformsStaticLogin.DAL
{
    class Database
    {
        // Objects
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632;User Id = dbi457632; Password=123456789");
        User user = new User();

        // Fields
        string tableName = "_StaticLoginTest";

        // Methods
        public void SendData(string username, string information, string age)
        {
            sqlCon.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("insert into " + tableName + " values('" + username + "','" + information + "','" + age + "')", sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        public List<string> GetAllUsernames()
        {
            List<string> usernameList = new List<string>();
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT username FROM " + tableName, sqlCon);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            while (sqlReader.Read())
            {
                usernameList.Add(sqlReader["username"].ToString());
            }
            sqlCon.Close();
            return usernameList;
        }
        public string GetInformation(string username)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("Select Information from " + tableName + " where username=@username", sqlCon);
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                //user.Username = sqlReader["Username"].ToString();
                user.Information = sqlReader["Information"].ToString();
            }
            sqlCon.Close();
            return user.Information;
        }
        public string GetAge(string username)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("Select Age from " + tableName + " where username=@username", sqlCon);
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                user.Age = sqlReader["Age"].ToString();
            }
            sqlCon.Close();
            return user.Age;
        }
        public string GetUsername(string username)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("Select Username from " + tableName + " where username=@username", sqlCon);
            cmd.Parameters.AddWithValue("username", username);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            if (sqlReader.Read())
            {
                user.Username = sqlReader["Username"].ToString();
            }
            sqlCon.Close();
            return user.Username;
        }
        public void DeleteUser(string username)
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + tableName + " WHERE username=@username", sqlCon);
            cmd.Parameters.AddWithValue("username", username);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
        public void UpdateUser(string username, string information, string age)
        {
            sqlCon.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(" UPDATE _StaticLoginTest SET age = @age, username = @username, information = @information WHERE username = @username", sqlCon);
            cmd.Parameters.AddWithValue("age", age);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("information", information);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
