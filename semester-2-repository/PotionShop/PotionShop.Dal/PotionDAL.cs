using PotionShop.Logic;
using PotionShop.Logic.DalInterfaces;
using System;
using System.Data.SqlClient;

namespace PotionShop.DAL
{
    public class PotionDAL : IPotionDAL
    {
        // Fields
        SqlConnection sqlCon = new SqlConnection("Server=mssql.fhict.local;Database=dbi457632_api;User Id = dbi457632_api; Password=123456789");
        SqlCommand cmd = new SqlCommand();

        // Methods
        public void AddPotion(string name, int cost)
        {
            sqlCon.Open();
            cmd = new SqlCommand("INSERT INTO Potion VALUES('" + name + "','" + cost + "')", sqlCon);
            cmd.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
