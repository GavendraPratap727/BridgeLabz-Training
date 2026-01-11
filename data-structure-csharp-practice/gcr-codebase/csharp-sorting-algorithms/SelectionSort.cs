using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
    internal class SelectionSorting
    {
        static void Main(String[] args) {
            int[] scores = { 78, 45, 89, 62, 33, 95, 50 };

            Console.WriteLine("Before sorting:");
            foreach (int s in scores)
                Console.Write(s + " ");

            SelectionSort(scores);
            Console.WriteLine();    
            Console.WriteLine("After sorting:");
            foreach (int s in scores)
                Console.Write(s + " ");
        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        }
}
