using FruitShop.AppLogic.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.AppLogic.Data
{
    public static class FruitData
    {
        public static string ConnectionString { private get;  set; }

        private static List<Fruit> _fruits = new List<Fruit>();
        public static List<Fruit> Fruits
        {
            get { return _fruits; }
        }


        public static Fruit CreateFruit(string name, string color, string season)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string select = "INSERT INTO Fruits VALUES (@Id, @Name, @Color, @Season)";
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    int newId = GetMaxFruitId() + 1;
                    command.Parameters.AddWithValue("@Id", newId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@Season", season);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        Fruit fruit = new Fruit
                        {
                            Id = newId,
                            Name = name,
                            Color = color,
                            Season = season
                        };
                        Fruits.Add(fruit);
                        return fruit;
                    }
                    else
                    { 
                        throw new Exception("Error creating fruit"); 
                    }
                }
            }
        }

        private static int GetMaxFruitId()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string select = "SELECT MAX(Id) FROM Fruits";
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public static bool DeleteFruit(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string select = "DELETE FROM Fruits WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        Fruits.RemoveAll(f => f.Id == id);
                        return true;
                    }

                    return false;
                }
            }
        }

        public static void GetAllFruit()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string select = "SELECT * FROM Fruits";
                using (SqlCommand command = new SqlCommand(select, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Fruit fruit = new Fruit
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Color = reader.GetString(2),
                                Season = reader.GetString(3)
                            };
                            _fruits.Add(fruit);
                        }
                    }
                }
            }
        }
    }
}
