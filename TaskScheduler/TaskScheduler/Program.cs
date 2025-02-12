namespace TaskScheduler
{
    class Program
    {
        static void Main()
        {
            TaskCircularLinkedList taskList = new TaskCircularLinkedList();

            // Add new tasks
            taskList.AddAtEnd(1, "Task 1", 1, DateTime.Now.AddDays(1));
            taskList.AddAtEnd(2, "Task 2", 2, DateTime.Now.AddDays(2));
            taskList.AddAtEnd(3, "Task 3", 3, DateTime.Now.AddDays(3));

            // Display all tasks
            Console.WriteLine("All Tasks:");
            taskList.DisplayAllTasks();

            // View the current task and move to the next task
            Console.WriteLine("\nView Current Task:");
            taskList.ViewCurrentTask();
            taskList.ViewCurrentTask();
            taskList.ViewCurrentTask();

            // Search for a task by Priority
            Console.WriteLine("\nSearch for task with Priority 2:");
            TaskNode task = taskList.SearchByPriority(2);
            if (task != null)
            {
                Console.WriteLine(task.ToString());
            }
            else
            {
                Console.WriteLine("Task not found.");
            }

            // Remove a task by Task ID
            Console.WriteLine("\nRemove Task with Task ID 2:");
            taskList.RemoveByTaskID(2);
            taskList.DisplayAllTasks();
            Console.ReadKey();
        }
    }

}
