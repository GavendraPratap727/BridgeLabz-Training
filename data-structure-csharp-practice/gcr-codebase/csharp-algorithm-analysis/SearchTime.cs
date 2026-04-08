using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.RunTime
{
    internal class SearchTime
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            int target = -5;

            foreach (int n in sizes)
            {
                Console.WriteLine("\nData Size: " + n);

                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                    arr[i] = i + 1;

                Stopwatch watch = new Stopwatch();

                watch.Start();
                Linear(arr, target);
                watch.Stop();
                Console.WriteLine("Linear Search Time: " + watch.ElapsedMilliseconds + " ms");

                watch.Reset();

                watch.Start();
                Binary(arr, target);
                watch.Stop();
                Console.WriteLine("Binary Search Time: " + watch.ElapsedMilliseconds + " ms");
            }
        }

        static int Linear(int[] a, int t)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == t)
                    return i;
            }
            return -1;
        }

        static int Binary(int[] a, int t)
        {
            int l = 0, r = a.Length - 1;

            while (l <= r)
            {
                int m = (l + r) / 2;

                if (a[m] == t)
                    return m;
                else if (a[m] < t)
                    l = m + 1;
                else
                    r = m - 1;
            }
            return -1;
        }
    }
}
