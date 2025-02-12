using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskScheduler
{
    public class TaskCircularLinkedList
    {
        private TaskNode head; // Reference to the head node
        private TaskNode current; // Reference to the current node

        public TaskCircularLinkedList()
        {
            head = null;
            current = null;
        }

        // Add a task at the beginning
        public void AddAtBeginning(int taskID, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                TaskNode tail = head;
                while (tail.Next != head)
                {
                    tail = tail.Next;
                }

                newNode.Next = head;
                head = newNode;
                tail.Next = head;
            }

            if (current == null)
            {
                current = head;
            }
        }

        // Add a task at the end
        public void AddAtEnd(int taskID, string taskName, int priority, DateTime dueDate)
        {
            TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                TaskNode tail = head;
                while (tail.Next != head)
                {
                    tail = tail.Next;
                }

                tail.Next = newNode;
                newNode.Next = head;
            }

            if (current == null)
            {
                current = head;
            }
        }

        // Add a task at a specific position
        public void AddAtPosition(int taskID, string taskName, int priority, DateTime dueDate, int position)
        {
            if (position == 0)
            {
                AddAtBeginning(taskID, taskName, priority, dueDate);
                return;
            }

            TaskNode newNode = new TaskNode(taskID, taskName, priority, dueDate);
            TaskNode current = head;
            for (int i = 0; i < position - 1; i++)
            {
                if (current.Next == head)
                {
                    Console.WriteLine("Position out of bounds.");
                    return;
                }

                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        // Remove a task by Task ID
        public void RemoveByTaskID(int taskID)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            TaskNode current = head;
            TaskNode prev = null;
            do
            {
                if (current.TaskID == taskID)
                {
                    if (prev != null)
                    {
                        prev.Next = current.Next;
                        if (current == head)
                        {
                            head = current.Next;
                        }
                    }
                    else
                    {
                        TaskNode tail = head;
                        while (tail.Next != head)
                        {
                            tail = tail.Next;
                        }

                        head = head.Next;
                        tail.Next = head;
                    }

                    return;
                }

                prev = current;
                current = current.Next;
            } while (current != head);

            Console.WriteLine("Task with given ID not found.");
        }

        // View the current task and move to the next task
        public void ViewCurrentTask()
        {
            if (current != null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
            else
            {
                Console.WriteLine("No tasks available.");
            }
        }

        // Display all tasks starting from the head node
        public void DisplayAllTasks()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            TaskNode current = head;
            do
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            } while (current != head);
        }

        // Search for a task by Priority
        public TaskNode SearchByPriority(int priority)
        {
            if (head == null)
            {
                return null;
            }

            TaskNode current = head;
            do
            {
                if (current.Priority == priority)
                {
                    return current;
                }

                current = current.Next;
            } while (current != head);

            return null;
        }
    }

}
