using System;

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

        public Contacts(string firstName, string lastName, string address,
                        string city, string state, string zip,
                        string phoneNumber, string email)
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

        // UC-7 Duplicate Check
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Contacts))
                return false;

            Contacts other = (Contacts)obj;
            return FirstName.Equals(other.FirstName)
                && LastName.Equals(other.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }

        public void DisplayContact()
        {
            Console.WriteLine("First Name : " + FirstName);
            Console.WriteLine("Last Name  : " + LastName);
            Console.WriteLine("Address    : " + Address);
            Console.WriteLine("City       : " + City);
            Console.WriteLine("State      : " + State);
            Console.WriteLine("Zip        : " + Zip);
            Console.WriteLine("Phone      : " + PhoneNumber);
            Console.WriteLine("Email      : " + Email);
            Console.WriteLine("--------------------------------");
        }
    }
}
