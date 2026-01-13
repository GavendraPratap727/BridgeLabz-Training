using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.StriinngBuilder
{
    internal class ReverseString
    {
        static void Main(String[] args)
        {
            Console.Write("Enter a string ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            StringBuilder reversed = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                reversed.Append(sb[i]);
            }
            Console.WriteLine("Reversed string " + reversed.ToString());
        }
    }
}
