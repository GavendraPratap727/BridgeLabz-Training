using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
    class UpperCase
    {
        public static string Uppercasec(string s) {
            string res = "";
            foreach(char c in s) {
                if (c >= 'a' && c <= 'z') {
                    res += (char)(c - 32);
                }
                else {
                    res += c;
                }
            }
            return res; ;
        }
        public static void Main(String[] args) {
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine(); //input a string
            string res1 = Uppercasec(str); //calling custom method to convert uppercase
            string res2 = str.ToUpper(); //calling inbuild method to convert uppercase
            Console.WriteLine("Uppercase by custom func.." + res1);
            Console.WriteLine("Uppercase by inbuilt func.." + res2);
            Console.WriteLine("both results are same and correct");
        }
    }
}
