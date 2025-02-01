using System;

namespace EmployeeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Testing Employee Class
            Employee emp = new Employee("John Doe", 101, 50000);
            Console.WriteLine("=== Employee Details ===");
            emp.DisplayDetails();


            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
