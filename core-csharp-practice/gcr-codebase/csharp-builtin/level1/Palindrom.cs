using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class Palindrom
    {
        static bool Palin(string s)
        {
            char[] arr = s.ToLower().ToCharArray();
            Array.Reverse(arr);
            return s.ToLower() == new string(arr);
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            bool res =Palin(input);
            if (res)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
