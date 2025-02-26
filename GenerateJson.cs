using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    internal class GenerateJson
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
        }
        static void Main()
        {
            string connectionString = "your_connection_string";
            string query = "SELECT Name, Age, Email FROM Users";
            var users = new List<User>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            Name = reader["Name"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }

            string jsonReport = JsonConvert.SerializeObject(users, Formatting.Indented);
            Console.WriteLine(jsonReport);
            System.IO.File.WriteAllText("UserReport.json", jsonReport); 
        }
    }
}
