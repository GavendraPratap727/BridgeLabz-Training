using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
    internal class CountSorting
    {
        static void Main()
        {
            int[] ages = { 15, 12, 18, 14, 10, 16, 13, 15, 11, 17 };

            Console.WriteLine("Before sorting:");
            foreach (int a in ages)
                Console.Write(a + " ");

            CountingSort(ages);
            Console.WriteLine();
            Console.WriteLine("After sorting:");
            foreach (int a in ages)
                Console.Write(a + " ");
        }

        static void CountingSort(int[] arr)
        {
            int min = 10;
            int max = 18;

            int[] count = new int[max - min + 1];

            for (int i = 0; i < arr.Length; i++)
                count[arr[i] - min]++;

            int index = 0;

            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    arr[index] = i + min;
                    index++;
                    count[i]--;
                }
            }
        }
    }
}
