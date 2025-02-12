namespace OnlineTicketReservationSystem
{
    class Program
    {
        static void Main()
        {
            TicketCircularLinkedList ticketList = new TicketCircularLinkedList();

            // Add new tickets
            ticketList.AddAtEnd(1, "Annu", "Inception", "A1", DateTime.Now);
            ticketList.AddAtEnd(2, "Boby", "The Dark Knight", "B2", DateTime.Now);
            ticketList.AddAtEnd(3, "Tushar", "Interstellar", "C3", DateTime.Now);

            // Display all tickets
            Console.WriteLine("All Tickets:");
            ticketList.DisplayAllTickets();

            // Search for a ticket by Customer Name or Movie Name
            Console.WriteLine("\nSearch for ticket with Customer Name 'Bob':");
            TicketNode ticket = ticketList.SearchByCustomerOrMovie("Boby");
            if (ticket != null)
            {
                Console.WriteLine(ticket.ToString());
            }
            else
            {
                Console.WriteLine("Ticket not found.");
            }

            // Calculate the total number of booked tickets
            Console.WriteLine("\nTotal number of booked tickets:");
            int totalTickets = ticketList.CountTotalTickets();
            Console.WriteLine(totalTickets);

            // Remove a ticket by Ticket ID
            Console.WriteLine("\nRemove ticket with Ticket ID 2:");
            ticketList.RemoveByTicketID(2);
            ticketList.DisplayAllTickets();
            Console.ReadKey();
        }
    }

}