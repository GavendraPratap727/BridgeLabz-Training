using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Exceptions
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException()
        {
        }
    }

    internal class CustomExpection
    {
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException();
            }
        }

        static void Main()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Age must be 18 or above");
            }
        }
    }
}
