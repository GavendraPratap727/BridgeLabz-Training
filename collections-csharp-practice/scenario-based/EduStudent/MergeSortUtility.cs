using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Senario.EduStudent
{
    class MergeSortUtility : ISortUtility
    {
        public void Sort(Student[] students)
        {
            MergeSort(students, 0, students.Length - 1);
        }

        private void MergeSort(Student[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        private void Merge(Student[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            Student[] L = new Student[n1];
            Student[] R = new Student[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            // DESCENDING + STABLE
            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex].GetMarks() >= R[jIndex].GetMarks())
                    arr[k++] = L[iIndex++];
                else
                    arr[k++] = R[jIndex++];
            }

            while (iIndex < n1)
                arr[k++] = L[iIndex++];

            while (jIndex < n2)
                arr[k++] = R[jIndex++];
        }
    }

}
