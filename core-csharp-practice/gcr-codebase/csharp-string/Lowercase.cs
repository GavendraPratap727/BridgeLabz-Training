using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
    class Lowercase
    {
        public static string Lowercasec(string s)
        {
            string res = "";
            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    res += (char)(c + 32);
                }
                else
                {
                    res += c;
                }
            }
            return res; ;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine(); //input a string
            string res1 = Lowercasec(str); //calling custom method to convert lowercase
            string res2 = str.ToLower(); //calling inbuild method to convert lowe case
            Console.WriteLine("lowercase by custom func.." + res1);
            Console.WriteLine("lower case by inbuilt func.." + res2);
            Console.WriteLine("both results are same and correct");
        }
    }
}
