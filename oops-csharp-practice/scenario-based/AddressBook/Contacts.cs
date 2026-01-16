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
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string PhoneNumber;
        public string Email;

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public void DisplayContact()
        {
            Console.WriteLine("First Name   : " + FirstName);
            Console.WriteLine("Last Name    : " + LastName);
            Console.WriteLine("Address      : " + Address);
            Console.WriteLine("City         : " + City);
            Console.WriteLine("State        : " + State);
            Console.WriteLine("Zip          : " + Zip);
            Console.WriteLine("Phone Number : " + PhoneNumber);
            Console.WriteLine("Email        : " + Email);
            Console.WriteLine("--------------------------------");
        }
    }
}


