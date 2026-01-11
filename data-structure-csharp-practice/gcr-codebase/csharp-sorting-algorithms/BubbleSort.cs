using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Sorting
{
    internal class BubbleSorts
    {
        static int [] BubbleSort(int[] marks)
        {
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = 0; j < marks.Length - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }
            return marks;
        }
        static void Main(String[] args) {
            int[] marks = { 22, 12, 93, 45, 88, 79, 92, 77, 66, 55, 44, 33, 9, 0 };
            Console.WriteLine("marks before Bullble sort");
            foreach (int i in marks) { 
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("marks before Bullble sort");
            marks =BubbleSort(marks);
            foreach (int i in marks)
            {
                Console.Write(i + " ");
            }

        }
    }
}
