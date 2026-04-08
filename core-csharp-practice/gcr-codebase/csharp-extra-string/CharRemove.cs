using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
     class CharRemove
    {
        static void Main(String[] args) {
            Console.WriteLine("Enter a string");
            string s=Console.ReadLine();
            Console.WriteLine("enter the char u want to remove from the string");
            char c = Console.ReadLine()[0];
            string res = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i]!=c) res+= s[i];
            }
            Console.WriteLine("The remove char sting is " + res);
        }
        
    }
}
