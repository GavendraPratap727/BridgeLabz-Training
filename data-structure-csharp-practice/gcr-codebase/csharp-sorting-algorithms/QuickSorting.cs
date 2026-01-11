using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
    class QuickSorting
    {
        static void Main(String[] args)
        {
            int[] Price = { 200, 300, 100, 90, 500, 800, 1000, 950, 50 };
            Console.WriteLine("Price before sorting");
            foreach (int prices in Price)
            {
                Console.Write(prices + " ");
            }
            QuickSort(Price, 0, Price.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Price after sorting");
            foreach (int prices in Price)
            {
                Console.Write(prices + " ");
            }
            static void QuickSort(int[] arr, int low, int high)
            {
                if (low >= high)
                    return;

                int pivot = arr[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }

                int temp = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp;

                int pos = i + 1;

                QuickSort(arr, low, pos - 1);
                QuickSort(arr, pos + 1, high);
            }

        }
    }
}
