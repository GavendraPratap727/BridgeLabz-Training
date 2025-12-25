using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    class SumOfNaturalNumber
    {
        static int RSum(int n)
        {
            if (n == 0) return 0;
            return n + RSum(n - 1);
        }
        static int FSum(int n)
        {
            return n * (n + 1) / 2;
        }

        public static void Main(String[] args)
        {
            Console.Write("Enter a natural number ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a natural number.");
                return;
            }
            int result1 = RSum(n);
            int result2 = FSum(n);
            Console.WriteLine("Sum using recursion " + result1);
            Console.WriteLine("Sum using formula  " + result2);

            if (result1 == result2) Console.WriteLine("Both results are correct and equal.");
            else  Console.WriteLine("Results are not equal.");
           
        }
    }

}
