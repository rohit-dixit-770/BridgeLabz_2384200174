using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment1
{
    public abstract class CourseType
    {
        public string CourseName { get; set; }
        public string Department { get; set; }

        public CourseType(string courseName, string department)
        {
            CourseName = courseName;
            Department = department;
        }

        public abstract void Evaluate();
    }

    // Exam-based Course
    public class ExamCourse : CourseType
    {
        public int ExamWeight { get; set; }

        public ExamCourse(string courseName, string department, int examWeight)
            : base(courseName, department)
        {
            ExamWeight = examWeight;
        }

        public override void Evaluate()
        {
            Console.WriteLine($"Evaluating {CourseName} with Exam Weight: {ExamWeight}%");
        }
    }

    // Assignment-based Course
    public class AssignmentCourse : CourseType
    {
        public int AssignmentCount { get; set; }

        public AssignmentCourse(string courseName, string department, int assignmentCount)
            : base(courseName, department)
        {
            AssignmentCount = assignmentCount;
        }

        public override void Evaluate()
        {
            Console.WriteLine($"Evaluating {CourseName} with {AssignmentCount} assignments.");
        }
    }

    // Generic Course Manager
    public class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        public void ListCourses()
        {
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseName} - {course.Department}");
                course.Evaluate();
            }
        }
    }
}
