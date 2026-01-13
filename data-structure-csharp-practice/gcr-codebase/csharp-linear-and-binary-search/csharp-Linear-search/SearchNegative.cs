using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.Linar
{
    internal class SearchNegative
    {
        static void Main()
        {
            Console.Write("Enter size of array ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + " ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int index = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine("First negative number is " + arr[index] + " at index " + index);
            else
                Console.WriteLine("No negative number found");
        }
    }
}
