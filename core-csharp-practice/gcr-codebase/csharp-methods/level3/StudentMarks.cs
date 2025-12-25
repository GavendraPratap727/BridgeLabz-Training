using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
     class StudentMarks
    
    {
        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] marks = getMarks(n);
            double[,] result = getResult(marks, n);

            showResult(n, marks, result);
        }

        static int[,] getMarks(int n)
        {
            int[,] arr = new int[n, 3];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i, 0] = r.Next(10, 100);
                arr[i, 1] = r.Next(10, 100);
                arr[i, 2] = r.Next(10, 100);
            }

            return arr;
        }

        static double[,] getResult(int[,] marks, int n)
        {
            double[,] res = new double[n, 3];

            for (int i = 0; i < n; i++)
            {
                int p = marks[i, 0];
                int c = marks[i, 1];
                int m = marks[i, 2];

                double total = p + c + m;
                double avg = total / 3;
                double per = (total / 300) * 100;

                res[i, 0] = total;
                res[i, 1] = avg;
                res[i, 2] = per;
            }

            return res;
        }

        static void showResult(int n, int[,] marks, double[,] res)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student " + (i + 1));
                Console.WriteLine("Physics: " + marks[i, 0]);
                Console.WriteLine("Chemistry: " + marks[i, 1]);
                Console.WriteLine("Math: " + marks[i, 2]);
                Console.WriteLine("Total: " + res[i, 0]);
                Console.WriteLine("Average: " + res[i, 1]);
                Console.WriteLine("Percentage: " + res[i, 2]);
                Console.WriteLine();
            }
        }
    }
}
