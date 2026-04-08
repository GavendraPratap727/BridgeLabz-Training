using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.Binary
{
    internal class RotationPoint
    {
        static void Main()
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int low = 0, high = n - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] > arr[high])
                    low = mid + 1;
                else
                    high = mid;
            }

            Console.WriteLine("Rotation point index: " + low);
            Console.WriteLine("Smallest element: " + arr[low]);
        }
    }
}
