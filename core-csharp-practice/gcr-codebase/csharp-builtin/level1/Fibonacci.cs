using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class Fibonacci
    {
        static void Fib(int n)
        {
            int a=0,b=1;
            for (int i=1;i<=n;i++)
            {
                Console.Write(a+" ");
                int c=a+b;
                a=b;
                b=c;
            }
        }

        static void Main()
        {
            Console.Write("Enter a number  ");
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }
    }
}
