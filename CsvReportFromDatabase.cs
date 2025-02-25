using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Data.SqlClient;

namespace Week_5_Assignment_1
{
    internal class CsvReportFromDatabase
    {
        public void Database()
        {
            string connectionString = "your_connection_string_here";
            string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
            string filePath = "EmployeeReport.csv";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Write headers
                        writer.WriteLine("Employee ID,Name,Department,Salary");

                        // Write data rows
                        while (reader.Read())
                        {
                            writer.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                        }
                    }
                }
                Console.WriteLine("CSV report generated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
