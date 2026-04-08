using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.StriinngBuilder
{
    internal class ConcateString
    {
        static void Main()
        {
            Console.Write("Enter number of strings: ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter string " + (i + 1) + ": ");
                words[i] = Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(words[i]);
            }

            Console.WriteLine("Concatenated String " + sb.ToString());
        }
    }
}
