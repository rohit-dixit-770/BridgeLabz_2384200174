using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
     public class Employee
    {
        private string name;
        private int id;
        private double salary;

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Salary: " + salary);
        }
    }
}
