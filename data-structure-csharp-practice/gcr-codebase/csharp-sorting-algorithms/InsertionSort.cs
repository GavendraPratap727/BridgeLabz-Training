using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
     class InsertionSort
    {
        static void Main(String[] args) {
            int[] empId = { 22, 12, 93, 45, 88, 79, 92, 77, 66, 55, 44, 33, 9, 0 };
            Console.WriteLine("Employee id before shorting");
            foreach (int id in empId) {
                Console.Write(id + " ");
            }
            InsertionSorting(empId);
            Console.WriteLine();
            Console.WriteLine("Employee Id after shorting");
            foreach (int id in empId)
            {
                Console.Write(id + " ");
            }
        }
        static void InsertionSorting(int[] empIds)
        {
            for (int i = 1; i < empIds.Length; i++)
            {
                int current = empIds[i];
                int j = i - 1;

                while (j >= 0 && empIds[j] > current)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }

                empIds[j + 1] = current;
            }
        }
        }
}
