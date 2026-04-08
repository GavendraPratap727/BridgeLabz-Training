using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace bridge.RunTime
{
    class SortTest
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };

            foreach (int n in sizes)
            {
                Console.WriteLine("Data Size: " + n);

                int[] data = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                    data[i] = rnd.Next(1, n);

                if (n <= 10000)
                {
                    int[] bubbleArr = (int[])data.Clone();
                    Stopwatch w1 = Stopwatch.StartNew();
                    BubbleSort(bubbleArr);
                    w1.Stop();
                    Console.WriteLine("Bubble Sort Time: " + w1.ElapsedMilliseconds + " ms");
                }
                else
                {
                    Console.WriteLine("Bubble Sort Time: Unfeasible");
                }

                int[] mergeArr = (int[])data.Clone();
                Stopwatch w2 = Stopwatch.StartNew();
                MergeSort(mergeArr, 0, mergeArr.Length - 1);
                w2.Stop();
                Console.WriteLine("Merge Sort Time: " + w2.ElapsedMilliseconds + " ms");

                int[] quickArr = (int[])data.Clone();
                Stopwatch w3 = Stopwatch.StartNew();
                QuickSort(quickArr, 0, quickArr.Length - 1);
                w3.Stop();
                Console.WriteLine("Quick Sort Time: " + w3.ElapsedMilliseconds + " ms");
            }
        }

        static void BubbleSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int t = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = t;
                    }
                }
            }
        }

        static void MergeSort(int[] a, int l, int r)
        {
            if (l >= r) return;

            int m = (l + r) / 2;
            MergeSort(a, l, m);
            MergeSort(a, m + 1, r);
            Merge(a, l, m, r);
        }

        static void Merge(int[] a, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++) L[i] = a[l + i];
            for (int j = 0; j < n2; j++) R[j] = a[m + 1 + j];

            int i1 = 0, i2 = 0, k = l;

            while (i1 < n1 && i2 < n2)
                a[k++] = L[i1] <= R[i2] ? L[i1++] : R[i2++];

            while (i1 < n1) a[k++] = L[i1++];
            while (i2 < n2) a[k++] = R[i2++];
        }

        static void QuickSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(a, low, high);
                QuickSort(a, low, p - 1);
                QuickSort(a, p + 1, high);
            }
        }

        static int Partition(int[] a, int low, int high)
        {
            int pivot = a[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (a[j] < pivot)
                {
                    i++;
                    int t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                }
            }

            int temp = a[i + 1];
            a[i + 1] = a[high];
            a[high] = temp;

            return i + 1;
        }
    }

}
