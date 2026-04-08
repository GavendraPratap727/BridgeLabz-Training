using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.RunTime
{
    internal class FibonacciTest
    {
        static void Main()
        {
            int[] values = { 10, 30 };

            foreach (int n in values)
            {
                Console.WriteLine("\nFibonacci N = " + n);

                Stopwatch watch = new Stopwatch();

                watch.Start();
                int r = FibRecursive(n);
                watch.Stop();
                Console.WriteLine("Recursive Result: " + r);
                Console.WriteLine("Recursive Time: " + watch.ElapsedMilliseconds + " ms");

                watch.Reset();

                watch.Start();
                int i = FibIterative(n);
                watch.Stop();
                Console.WriteLine("Iterative Result: " + i);
                Console.WriteLine("Iterative Time: " + watch.ElapsedMilliseconds + " ms");
            }

            Console.WriteLine("\nSkipping Recursive Fibonacci for N = 50 (Unfeasible)");
            Stopwatch w = Stopwatch.StartNew();
            int fast = FibIterative(50);
            w.Stop();
            Console.WriteLine("Iterative Result (50): " + fast);
            Console.WriteLine("Iterative Time: " + w.ElapsedMilliseconds + " ms");
        }

        static int FibRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibRecursive(n - 1) + FibRecursive(n - 2);
        }

        static int FibIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }
}
