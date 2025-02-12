namespace RoundRobinSchedulingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList scheduler = new CircularLinkedList();

            // Add processes
            scheduler.AddProcess(1, 10, 2);
            scheduler.AddProcess(2, 5, 1);
            scheduler.AddProcess(3, 8, 3);

            // Display processes
            scheduler.DisplayProcesses();

            // Simulate Round Robin Scheduling with time quantum = 3
            scheduler.RoundRobinScheduling(3);
            Console.ReadKey();
        }
    }

}