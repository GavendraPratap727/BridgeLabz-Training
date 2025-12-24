using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
    class EvenOdd
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a natural number");
            int n = int.Parse(Console.ReadLine()); //input a number
            if (n <= 0)
            {
                Console.WriteLine("enter a natural number"); 
                return;
            }
            int[] odd = new int[n/2+1 ]; // create 2 array in one array we store odd and in second we store even numbers
            int[] even = new int[n/2+1];
            int j = 0;
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    even[j++] = i;
                }
                else odd[k++] = i;
            }

            Console.WriteLine("Odd numbers are");
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(odd[i]);
            }
            Console.WriteLine("Even numbers are");

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(even[i]);
            }


        }
    }
}
