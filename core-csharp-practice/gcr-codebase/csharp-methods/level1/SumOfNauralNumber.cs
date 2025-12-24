using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{


    class SumOfNauralNumber
    {
        static int CalSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

       public  static void Main(String[] args)
        {
            Console.Write("Enter a natural number ");
            int n = int.Parse(Console.ReadLine()); //entering a natural number
            int result = CalSum(n);
            Console.WriteLine("The sum of "+n+" natural numbers is "+result);
        }
    }

}
