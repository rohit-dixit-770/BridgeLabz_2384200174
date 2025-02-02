using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;

        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        public double GetSalary()
        {
            return this.salary ;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
    }

    class Manager : Employee
    {
        public string teamName;

        public Manager(int employeeID, string department, double salary, string teamName)
            : base(employeeID, department, salary)
        {
            this.teamName = teamName;
        }

        public static void Main()
        {
            Manager manager = new Manager(123, "Finance", 50000, "Team Alpha");

            Console.WriteLine($"Employee ID: {manager.employeeID}");
            Console.WriteLine($"Department: {manager.department}");
            Console.WriteLine($"Salary: {manager.GetSalary()}");
            Console.WriteLine($"Team Name: {manager.teamName}");
        }
    }

}
