using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class SortCsvFileBySalary
    {
        public void SalarySort()
        {
            try
            {
                string filePath = "employees.csv"; // Ensure this file exists
                string[] lines = File.ReadAllLines(filePath);

                Employee[] employees = new Employee[lines.Length - 1]; // Exclude header

                // Read data into an array
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    employees[i - 1] = new Employee(parts[0], parts[1], decimal.Parse(parts[2]));
                }

                // Bubble Sort (Descending Order by Salary)
                for (int i = 0; i < employees.Length - 1; i++)
                {
                    for (int j = 0; j < employees.Length - i - 1; j++)
                    {
                        if (employees[j].Salary < employees[j + 1].Salary)
                        {
                           
                            Employee temp = employees[j];
                            employees[j] = employees[j + 1];
                            employees[j + 1] = temp;
                        }
                    }
                }

                // Print top 5 highest-paid employees
                Console.WriteLine("Top 5 Highest-Paid Employees:");
                for (int i = 0; i < Math.Min(5, employees.Length); i++)
                {
                    Console.WriteLine($"{employees[i].Name} ({employees[i].Role}) - ${employees[i].Salary}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Employee
    {
        public string Name { get; }
        public string Role { get; }
        public decimal Salary { get; }

        public Employee(string name, string role, decimal salary)
        {
            Name = name;
            Role = role;
            Salary = salary;
        }
    }
}