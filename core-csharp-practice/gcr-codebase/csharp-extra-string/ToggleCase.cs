using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
    class ToggleCase
    {
        static void Main(String[] args){
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            string res = "";
            for (int i = 0; i < s.Length; i++) {
                char c=s[i];
                if (c >= 'a' && c <= 'z') res += (char)(c - 32);
                else if (c >= 'A' && c <= 'Z') res += (char)(c + 32);
                else res += c;

            }
            Console.WriteLine(res);

        }

    }
}
