using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationSystem
{
    public class TicketCircularLinkedList
    {
        private TicketNode head; 

        public TicketCircularLinkedList()
        {
            head = null;
        }

        // Add a new ticket reservation at the end of the circular list
        public void AddAtEnd(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            TicketNode newNode = new TicketNode(ticketID, customerName, movieName, seatNumber, bookingTime);
            if (head == null)
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                TicketNode tail = head;
                while (tail.Next != head)
                {
                    tail = tail.Next;
                }

                tail.Next = newNode;
                newNode.Next = head;
            }
        }

        // Remove a ticket by Ticket ID
        public void RemoveByTicketID(int ticketID)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            TicketNode current = head;
            TicketNode prev = null;
            do
            {
                if (current.TicketID == ticketID)
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
                        TicketNode tail = head;
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

            Console.WriteLine("Ticket with given ID not found.");
        }

        // Display the current tickets in the list
        public void DisplayAllTickets()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            TicketNode current = head;
            do
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            } while (current != head);
        }

        // Search for a ticket by Customer Name or Movie Name
        public TicketNode SearchByCustomerOrMovie(string searchQuery)
        {
            if (head == null)
            {
                return null;
            }

            TicketNode current = head;
            do
            {
                if (current.CustomerName.Equals(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    current.MovieName.Equals(searchQuery, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }

                current = current.Next;
            } while (current != head);

            return null;
        }

        // Calculate the total number of booked tickets
        public int CountTotalTickets()
        {
            if (head == null)
            {
                return 0;
            }

            int count = 0;
            TicketNode current = head;
            do
            {
                count++;
                current = current.Next;
            } while (current != head);

            return count;
        }
    }

}
