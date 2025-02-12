using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketReservationSystem
{
    public class TicketNode
    {
        public int TicketID;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;
        public TicketNode Next;

        public TicketNode(int ticketID, string customerName, string movieName, string seatNumber, DateTime bookingTime)
        {
            TicketID = ticketID;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
            Next = null;
        }

        public override string ToString()
        {
            return $"Ticket ID: {TicketID}, Customer: {CustomerName}, Movie: {MovieName}, Seat: {SeatNumber}, Time: {BookingTime}";
        }
    }

}
