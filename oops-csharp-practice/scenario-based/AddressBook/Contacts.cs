using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bridge.AddressBook
{
    internal class Contacts
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Zip { get; set; }
        public String PhoneNumber { get; set; }
        public String EMail { get; set; }
        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
        }
        
            public  void DisplayContact()
        {
            Console.WriteLine("First Name   : " + FirstName);
            Console.WriteLine("Last Name    : " + LastName);
            Console.WriteLine("Address      : " + Address);
            Console.WriteLine("City         : " + City);
            Console.WriteLine("State        : " + State);
            Console.WriteLine("Zip          : " + Zip);
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("Email        : " + EMail);
        }
    }
    }


