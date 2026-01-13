using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.StriinngBuilder
{
    internal class RemoveDuplicate
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < result.Length; j++)
                {
                    if (str[i] == result[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result.Append(str[i]);
                }
            }
            Console.WriteLine("String after removing duplicates is  " + result.ToString());
        }
    }
}
