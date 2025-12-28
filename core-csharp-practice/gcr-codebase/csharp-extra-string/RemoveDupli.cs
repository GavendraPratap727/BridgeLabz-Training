using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
     class RemoveDupli
    {
        static void Main(String[] args) {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine(); //input a string
            string res = "";
            for(int i=0;i<s.Length;i++) {
                if(!res.Contains(s[i])) {
                    res += s[i];
                }

            }
            Console.WriteLine("String after removing duplicates " + res); //result string 
        }
    }
}
