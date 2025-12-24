using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{

    class Chocolate
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int q = number / divisor;  
            int re = number % divisor;
            int[] arr= { q ,re };
            return arr;
        }
       public static void Main(String[] args)
        {
            Console.Write("Enter number of chocolates ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number of children ");
            int nc = int.Parse(Console.ReadLine());
            int[] res= FindRemainderAndQuotient(n, nc);
            Console.WriteLine("no of  chocolates " + res[0]);
            Console.WriteLine("Remaining chocolates are " + res[1]);
        }
    }

}
