using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    class Factor
    {
        public static int[] FindF(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            int[] fac = new int[count];
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    fac[j++] = i;
            }

            return fac;
        }

        public static int FindS(int[] fac)
        {
            int sum = 0;
            foreach (int f in fac)
                sum += f;
            return sum;
        }
        public static long FindP(int[] fac)
        {
            long pro = 1;
            foreach (int f in fac)
                pro *= f;
            return pro;
        }
        public static double FindSquare(int[] fac)
        {
            double sum = 0;
            foreach (int f in fac)
                sum += Math.Pow(f, 2);
            return sum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine()); //input a number
            int[] fac= FindF(n); //call method to find factors
            Console.WriteLine("Factors are:");
            foreach (int f in fac)
              Console.WriteLine(f+ " ");
            Console.WriteLine("Sum of factors " + FindS(fac));
            Console.WriteLine("Product of factors " + FindP(fac));
            Console.WriteLine("Sum of squares of factors:-" + FindSquare(fac));
        }
    }

}
