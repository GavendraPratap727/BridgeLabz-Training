using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
    class NumberChecker4
    {
        static bool isPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        static bool isNeon(int num)
        {
            int square = num * num;
            int sum = 0;

            while (square > 0)
            {
                sum = sum + square % 10;
                square = square / 10;
            }

            return sum == num;
        }

        static bool isSpy(int num)
        {
            int sum = 0;
            int product = 1;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                product = product * digit;
                num = num / 10;
            }

            return sum == product;
        }

        static bool isAutomorphic(int num)
        {
            int square = num * num;
            return square.ToString().EndsWith(num.ToString());
        }

        static bool isBuzz(int num)
        {
            if (num % 7 == 0 || num % 10 == 7)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime  " + isPrime(number));
            Console.WriteLine("Neon Number: " + isNeon(number));
            Console.WriteLine("Spy Num " + isSpy(number));
            Console.WriteLine("Automorphic Number: " + isAutomorphic(number));
            Console.WriteLine("Buzz  " + isBuzz(number));
        }
    }

}
