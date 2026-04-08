using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Constructor
{
    class Stay
    {
        string guest;
        string room;
        int days;

        Stay() : this("Guest", "Standard", 1)
        {
            Console.WriteLine("Default Constructor Called");
        }

        Stay(string guest, string room, int days)
        {
            Console.WriteLine("Parameterized Constructor called");
            this.guest = guest;
            this.room = room;
            this.days = days;
        }

        Stay(Stay oldStay)
        {
            Console.WriteLine("Copy Constructor called");
            guest = oldStay.guest;
            room = oldStay.room;
            days = oldStay.days;
        }

        void show()
        {
            Console.WriteLine("Hotel Booking Details:");
            Console.WriteLine("Name: " + guest);
            Console.WriteLine("Room Type: " + room);
            Console.WriteLine("Nights: " + days);
        }
        // Main method
        static void Main()
        {
            Stay s1 = new Stay();
            Stay s2 = new Stay("Raja", "Deluxe Room", 15);
            Stay s3 = new Stay(s2);

            s1.show(); // Display details of default stay
            s2.show();// Display details of parameterized stay
            s3.show();// Display details of copied stay
        }
    }

}
