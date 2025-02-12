using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRobinSchedulingAlgorithm
{
    class CircularLinkedList
    {
        private ProcessNode head;
        private ProcessNode tail;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
        }

        // Add a new process at the end of the circular list
        public void AddProcess(int processID, int burstTime, int priority)
        {
            ProcessNode newNode = new ProcessNode(processID, burstTime, priority);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                tail.Next = head; // Make it circular
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head; // Make it circular
            }
            Console.WriteLine($"Process {processID} added to the queue.");
        }

        // Remove a process by Process ID after its execution
        public void RemoveProcess(int processID)
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            ProcessNode current = head;
            ProcessNode previous = null;

            do
            {
                if (current.ProcessID == processID)
                {
                    if (current == head && current == tail) // Only one node
                    {
                        head = null;
                        tail = null;
                    }
                    else if (current == head) // Remove head
                    {
                        head = head.Next;
                        tail.Next = head;
                    }
                    else if (current == tail) // Remove tail
                    {
                        tail = previous;
                        tail.Next = head;
                    }
                    else // Remove middle node
                    {
                        previous.Next = current.Next;
                    }
                    Console.WriteLine($"Process {processID} removed from the queue.");
                    return;
                }
                previous = current;
                current = current.Next;
            } while (current != head);

            Console.WriteLine($"Process {processID} not found in the queue.");
        }

        // Simulate the scheduling of processes in a round-robin manner
        public void RoundRobinScheduling(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes in the queue.");
                return;
            }

            int totalWaitingTime = 0;
            int totalTurnAroundTime = 0;
            int totalProcesses = 0;

            ProcessNode current = head;
            do
            {
                totalProcesses++;
                current = current.Next;
            } while (current != head);

            while (head != null)
            {
                current = head;
                do
                {
                    if (current.BurstTime > 0)
                    {
                        Console.WriteLine($"Executing Process {current.ProcessID} with Burst Time {current.BurstTime}");
                        int executionTime = Math.Min(timeQuantum, current.BurstTime);
                        current.BurstTime -= executionTime;

                        // Calculate waiting and turn-around time
                        totalWaitingTime += executionTime * (totalProcesses - 1);
                        totalTurnAroundTime += executionTime * totalProcesses;

                        if (current.BurstTime == 0)
                        {
                            RemoveProcess(current.ProcessID);
                            totalProcesses--;
                        }
                    }
                    current = current.Next;
                } while (current != head);

                DisplayProcesses();
            }

            // Calculate and display average waiting and turn-around time
            double averageWaitingTime = (double)totalWaitingTime / totalProcesses;
            double averageTurnAroundTime = (double)totalTurnAroundTime / totalProcesses;
            Console.WriteLine($"Average Waiting Time: {averageWaitingTime}");
            Console.WriteLine($"Average Turn-Around Time: {averageTurnAroundTime}");
        }

        // Display the list of processes in the circular queue
        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No processes in the queue.");
                return;
            }

            ProcessNode current = head;
            Console.WriteLine("Processes in the queue:");
            do
            {
                Console.WriteLine($"Process ID: {current.ProcessID}, Burst Time: {current.BurstTime}, Priority: {current.Priority}");
                current = current.Next;
            } while (current != head);
        }
    }

}
