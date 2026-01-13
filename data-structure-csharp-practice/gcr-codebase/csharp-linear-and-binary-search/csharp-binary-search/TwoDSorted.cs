using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.Binary
{
    internal class TwoDSorted
    {
        static void Main()
        {
            Console.Write("Enter number of rows: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matrix = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("Enter element [" + i + "," + j + "]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());

            int low = 0, high = (r * c) - 1;
            bool found = false;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int row = mid / c;
                int col = mid % c;

                if (matrix[row, col] == target)
                {
                    Console.WriteLine("Target found at position [" + row + "," + col + "]");
                    found = true;
                    break;
                }
                else if (matrix[row, col] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            if (!found)
                Console.WriteLine("Target not found in matrix");
        }
    }
}
