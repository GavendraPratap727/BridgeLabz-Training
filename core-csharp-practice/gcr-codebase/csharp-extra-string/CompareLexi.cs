using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
    class CompareLexi
    {
        static void Main(String[]args)
        {
            Console.Write("Enter first string");
            string s1 = Console.ReadLine();
            Console.Write("Enter second string ");
            string s2 = Console.ReadLine();
            int len = s1.Length < s2.Length ? s1.Length : s2.Length;
            int res = 0;
            for (int i = 0; i < len; i++)
            {
                if (s1[i] != s2[i])
                {
                    res = s1[i] - s2[i];
                    break;
                }
            }

            if (res == 0)
                res = s1.Length - s2.Length;

            if (res < 0)
                Console.WriteLine("String 1 come before String 2");
            else if (res > 0)
                Console.WriteLine("String 2 come before String 1");
            else
                Console.WriteLine("Both strings are equal");
        }
    }
}
