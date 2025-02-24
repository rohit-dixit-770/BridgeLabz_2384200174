using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TodoAttribute : Attribute
    {
        public string Task { get; }
        public string AssignedTo { get; }
        public string Priority { get; }

        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }

    public class ProjectTasks
    {
        [Todo("Implement login feature", "Alice", "HIGH")]
        [Todo("Fix logout issue", "Bob")]
        public void AuthenticationModule() { }

        [Todo("Optimize database queries", "Charlie", "LOW")]
        public void DatabaseOptimization() { }

        [Todo("Refactor UI components", "Dave", "MEDIUM")]
        public void UIRefactoring() { }
    }
    class Check2
    {
        public void Check2Data()
        {
            Type type = typeof(ProjectTasks);
            foreach (MethodInfo method in type.GetMethods())
            {
                var todos = method.GetCustomAttributes<TodoAttribute>();
                foreach (var todo in todos)
                {
                    Console.WriteLine($"Method: {method.Name}\n Task: {todo.Task}\n Assigned To: {todo.AssignedTo}\n Priority: {todo.Priority}\n");
                }
            }
        }
    }
}
