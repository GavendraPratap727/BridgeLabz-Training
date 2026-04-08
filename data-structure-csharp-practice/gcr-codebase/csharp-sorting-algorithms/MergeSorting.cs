using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
    class MergeSorting
    {
        static void Main(String[] args) {
            int[] bookPrice = { 200, 300, 100, 90, 500, 800, 1000, 950, 50 };
            Console.WriteLine("Book price before sorting");
            foreach (int id in bookPrice) 
            {
                Console.Write(id + " ");
            }
            MergeSort(bookPrice, 0, bookPrice.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Book price after sorting");
            foreach (int id in bookPrice)
            {
                Console.Write(id + " ");
            }


        }
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            while (i <= mid)
                temp[k++] = arr[i++];
            while (j <= right)
                temp[k++] = arr[j++];
            for (int x = 0; x < temp.Length; x++)
                arr[left + x] = temp[x];
        }
    }
}
