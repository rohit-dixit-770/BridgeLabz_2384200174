namespace StudentRecordManagement
{
    public class Program
    {
        public static void Main() 
        {
            StudentRecordSLL students = new StudentRecordSLL();

            // Add new students
            students.AddAtEnd(1, "Rohit", 24, 'A');
            students.AddAtEnd(2, "Yash", 23, 'B');
            students.AddAtEnd(3, "Navneet", 24, 'B');

            // Display all students
            Console.WriteLine("All Students:");
            students.DisplayAllRecords();

            // Search for a student
            Node student = students.SearchRollNumber(2);
            if (student != null)
            {
                Console.WriteLine(student.ToString());
            }
            else
            {
                Console.WriteLine("Student not found");
            }

            // Update a student's grade
            students.UpdateGrade(2, 'A');

            // Delete a student
            students.DeleteUsingRollNumber(2);

            Console.WriteLine("\nAll Students:");
            students.DisplayAllRecords();
            
        }
    }
}