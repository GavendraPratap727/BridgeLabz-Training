using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
    internal class Angram
    {
        static void Main()
        {
            Console.Write("Enter first string");
            string s1=Console.ReadLine().ToLower();
            Console.Write("Enter second string");
            string s2=Console.ReadLine().ToLower();
            bool res=true;
            for (int i=0;i<s1.Length;i++)
            {
                if (!(s2.Contains(s1[i].ToString())&& s1.Contains(s2[i].ToString())))
                {
                    res = false;
                    break;
                }
            }

            if (res&& s1.Length== s2.Length)
                Console.WriteLine("Strings are Anagrams");
            else
                Console.WriteLine("Not Anagrams");
        }
}
}
