using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class Fatorial
    {
        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            return n * Fact(n - 1);
        }

       public  static void Main(String[]args)
        {
            Console.Write("Enter a number ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial " + Fact(n));
        }
    }
}
