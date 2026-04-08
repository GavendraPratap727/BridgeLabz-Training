using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
     class SubStringOccu
    {
        static void Main(String[] args) {
            Console.Write("Enter a string ");
            string s = Console.ReadLine();
            Console.Write("Enter substring ");
            string sub = Console.ReadLine();
            int count = 0;
            int i = 0;

            while (s.IndexOf(sub, i) != -1)
            {
                i = s.IndexOf(sub, i);
                count++;
                i = i + sub.Length;
            }

            Console.WriteLine("Occurrences: " + count);
        }
    }
}
