using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class Copy2DArray
    {
        static void Main(String[] args) {
            Console.WriteLine("Enter the number of rows and column");
            int row=int.Parse(Console.ReadLine());
            int col=int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            Console.WriteLine("Enter the elements of the array");
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int [] copy= new int[row * col];
            int idx = 0;
            for(int i=0;i<row;i++) {
                for(int j=0;j<col;j++) {
                    copy[idx++] = arr[i, j];
                }
            }
            for (int i = 0; i < copy.Length; i++) { 
                Console.Write(copy[i] + " ");
            }

        }
    }
}
