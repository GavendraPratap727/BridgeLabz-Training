using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
    class HeapSorting
    {
        static void Main()
        {
            int[] salaries = { 45000, 32000, 78000, 50000, 61000, 29000 };

            Console.WriteLine("Before sorting:");
            foreach (int s in salaries)
                Console.Write(s + " ");

            HeapSort(salaries);
            Console.WriteLine();
            Console.WriteLine("After sorting:");
            foreach (int s in salaries)
                Console.Write(s + " ");
        }

        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                int parent = i;

                while (true)
                {
                    int left = 2 * parent + 1;
                    int right = 2 * parent + 2;
                    int largest = parent;

                    if (left < n && arr[left] > arr[largest])
                        largest = left;

                    if (right < n && arr[right] > arr[largest])
                        largest = right;

                    if (largest == parent)
                        break;

                    int temp = arr[parent];
                    arr[parent] = arr[largest];
                    arr[largest] = temp;

                    parent = largest;
                }
            }

            for (int end = n - 1; end > 0; end--)
            {
                int swap = arr[0];
                arr[0] = arr[end];
                arr[end] = swap;

                int parent = 0;

                while (true)
                {
                    int left = 2 * parent + 1;
                    int right = 2 * parent + 2;
                    int largest = parent;

                    if (left < end && arr[left] > arr[largest])
                        largest = left;

                    if (right < end && arr[right] > arr[largest])
                        largest = right;

                    if (largest == parent)
                        break;

                    int temp = arr[parent];
                    arr[parent] = arr[largest];
                    arr[largest] = temp;

                    parent = largest;
                }
            }
        }
    }
}
