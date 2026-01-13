using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.Binary
{
    internal class FirstAndLast
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
            Console.Write("Enter target element ");
            int target = int.Parse(Console.ReadLine());
            int first = -1, last = -1;
            int low = 0, high = n - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    first = mid;
                    high = mid - 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            low = 0;
            high = n - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    last = mid;
                    low = mid + 1;
                }
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            if (first != -1)
            {
                Console.WriteLine("First occurrence at index " + first);
                Console.WriteLine("Last occurrence at index " + last);
            }
            else
                Console.WriteLine("Element not found");
        }
    }
}
