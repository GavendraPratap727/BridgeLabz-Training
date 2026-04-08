using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
   class Substrings
    {
        public static string crea( string str, int s, int e) {
            string res = "";
            for (int i = s; i < e; i++) {
                res += str[i];
            }
            return res;
        }
        public static void Main(String[] args) {
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();  //input a string
            Console.WriteLine("Enter starting index and end index");
            int s=int.Parse(Console.ReadLine()); //taking starting and ending index
            int e=int.Parse(Console.ReadLine());
            string res = crea( str,  s, e); //call method to creating sub string
            string res2= str.Substring(s, e - s); //use inbuild func.. to create substring
            Console.WriteLine("Substring by custom function "+res);
            Console.WriteLine("Substring by inbuilt function "+res2);
            Console.WriteLine("both results are same and correct");


        }
    }
}
