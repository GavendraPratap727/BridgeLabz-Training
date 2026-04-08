using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.Binary
{
    internal class PeakElement
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
            int low = 0, high = n - 1;
            while (low < high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] < arr[mid + 1])
                    low = mid + 1;
                else
                    high = mid;
            }
            Console.WriteLine("Peak element is " + arr[low] + " at index " + low);
        }
    }
}
