using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.LinkedListttt
{
        class Ticket
        {
            public int ticketId;
            public string customerName;
            public string movieName;
            public int seatNo;
            public string bookingTime;
            public Ticket next;
            public Ticket(int id, string cname, string mname, int seat, string time)
            {
                ticketId = id;
                customerName = cname;
                movieName = mname;
                seatNo = seat;
                bookingTime = time;
                next = null;
            }
        }
        class TicketList
        {
            Ticket head = null;

            public void AddTicket(int id, string cname, string mname, int seat, string time)
            {
                Ticket t = new Ticket(id, cname, mname, seat, time);
                if (head == null)
                {
                    head = t;
                    t.next = head;
                    return;
                }
                Ticket temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                temp.next = t;
                t.next = head;
            }
            public void RemoveTicket(int id)
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets available");
                    return;
                }
                Ticket curr = head;
                Ticket prev = null;
                do
                {
                    if (curr.ticketId == id)
                    {
                        if (curr == head)
                        {
                            Ticket last = head;
                            while (last.next != head)
                            {
                                last = last.next;
                            }

                            head = head.next;
                            last.next = head;
                        }
                        else
                        {
                            prev.next = curr.next;
                        }

                        Console.WriteLine("Ticket removed");
                        return;
                    }
                    prev = curr;
                    curr = curr.next;

                } while (curr != head);

                Console.WriteLine("Ticket not found");
            }
            public void DisplayTickets()
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets booked");
                    return;
                }
                Ticket temp = head;
                Console.WriteLine("Booked Tickets:");
                do
                {
                Console.WriteLine("ID: " + temp.ticketId + ", Customer: " + temp.customerName + ", Movie: " + temp.movieName + ", Seat: " + temp.seatNo + ", Time: " + temp.bookingTime);

                    temp = temp.next;
                }
                while (temp != head);
            }
            public void SearchByCustomer(string name)
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets booked");
                    return;
                }
                Ticket temp = head;
                bool found = false;
                do
                {
                    if (temp.customerName.ToLower() == name.ToLower())
                    {
                    Console.WriteLine("ID: " + temp.ticketId + ", Movie: " + temp.movieName + ", Seat: " + temp.seatNo);



                        
                        found = true;
                    }
                    temp = temp.next;
                }
                while (temp != head);

                if (!found)
                    Console.WriteLine("No ticket found for this customer");
            }

            public void SearchByMovie(string movie)
            {
                if (head == null)
                {
                    Console.WriteLine("No tickets booked");
                    return;
                }
                Ticket temp = head;
                bool found = false;
                do
                {
                    if (temp.movieName.ToLower() == movie.ToLower())
                    {
                    Console.WriteLine("ID: " + temp.ticketId + ", Customer: " + temp.customerName + ", Seat: " + temp.seatNo);



                        
                        found = true;
                    }
                    temp = temp.next;
                }
                while (temp != head);

                if (!found)
                    Console.WriteLine("No tickets found for this movie");
            }
            public void TotalTickets()
            {
                if (head == null)
                {
                    Console.WriteLine("Total Tickets: 0");
                    return;
                }
                int count = 0;
                Ticket temp = head;
                do
                {
                    count++;
                    temp = temp.next;
                }
                while (temp != head);

                Console.WriteLine("Total Tickets Booked: " + count);
            }
        }

        class TicketReservation
    {
            static void Main(string[] args)
            {
                TicketList list = new TicketList();
                list.AddTicket(1, "Aman", "Inception", 12, "10:30 AM");
                list.AddTicket(2, "Riya", "Avatar", 15, "11:00 AM");
                list.AddTicket(3, "Rahul", "Inception", 18, "11:15 AM");
                list.DisplayTickets();
                Console.WriteLine();
                list.SearchByCustomer("Aman");
                Console.WriteLine();
                list.SearchByMovie("Inception");
                Console.WriteLine();
                list.RemoveTicket(2);
                Console.WriteLine();
                list.DisplayTickets();
                Console.WriteLine();
                list.TotalTickets();
            }
        }
    }


