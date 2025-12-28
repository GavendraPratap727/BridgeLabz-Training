using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class Prime
    {
        static bool IsPrime(int n)
        {
            if (n<=1) return false;

            for (int i=2; i<=n/2;i++)
            {
                if (n%i==0)
                    return false;
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n))
                Console.WriteLine("Prime Number");
            else
                Console.WriteLine("Not a Prime Number");
        }
    }
}
