using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class HotelBooking
    {
        public string guestName;
        public string roomType;
        public int nights;

        // Default Constructor
        public HotelBooking() 
        {
            this.guestName = "Guest";
            this.roomType = "Standard";
            this.nights = 1;
        }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights) 
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking other) 
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Guest Name: " + this.guestName);
            Console.WriteLine("Room Type: " + this.roomType);
            Console.WriteLine("number of nights: " + this.nights);
        }

        public static void Main()
        {
            // create object of HotelBooking class
            HotelBooking hb1 = new HotelBooking();
            HotelBooking hb2 = new HotelBooking("Rohit", "AC Room", 3);
            HotelBooking hb3 = new HotelBooking(hb2);

            hb1.DisplayDetails();
            hb2.DisplayDetails();
            hb3.DisplayDetails();
        }
    }
}
