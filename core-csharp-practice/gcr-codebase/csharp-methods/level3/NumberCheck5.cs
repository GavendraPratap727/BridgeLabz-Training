using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
    class NumberChecker5
    {
        static int[] getFactors(int num)
        {
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }
        static int greatestFactor(int[] factors)
        {
            int max = factors[0];
            for (int i = 1; i < factors.Length; i++)
            {
                if (factors[i] > max)
                    max = factors[i];
            }
            return max;
        }

        static int sumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum = sum + factors[i];
            }
            return sum;
        }
        static long productOfFactors(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product = product * factors[i];
            }
            return product;
        }

        static double productOfCubeFactors(int[] factors)
        {
            double product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product = product * Math.Pow(factors[i], 3);
            }
            return product;
        }
        static int sumProperDivisors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length - 1; i++)
            {
                sum = sum + factors[i];
            }
            return sum;
        }

        static bool isPerfect(int num, int[] factors)
        {
            return sumProperDivisors(factors) == num;
        }
        static bool isAbundant(int num, int[] factors)
        {
            return sumProperDivisors(factors) > num;
        }
        static bool isDeficient(int num, int[] factors)
        {
            return sumProperDivisors(factors) < num;
        }
        static int factorial(int digit)
        {
            int fact = 1;
            for (int i = 1; i <= digit; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static bool isStrong(int num)
        {
            int temp = num;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum = sum + factorial(digit);
                temp = temp / 10;
            }

            return sum == num;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number ");
            int n = int.Parse(Console.ReadLine());

            int[] fac = getFactors(n);

            Console.Write("Factors: ");
            for (int i = 0; i < fac.Length; i++)
            {
                Console.Write(fac[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Greatest Factor " + greatestFactor(fac));
            Console.WriteLine("Sum of Factors" + sumOfFactors(fac));
            Console.WriteLine("Product of Factor " + productOfFactors(fac));
            Console.WriteLine("Product of Cube of Factors " + productOfCubeFactors(fac));
            Console.WriteLine("Perfect Number:- " + isPerfect(n, fac));
            Console.WriteLine("Abundant Number " + isAbundant(n, fac));
            Console.WriteLine("Deficient Number= " + isDeficient(n, fac));
            Console.WriteLine("Strong Number " + isStrong(n));
        }
    }

}
