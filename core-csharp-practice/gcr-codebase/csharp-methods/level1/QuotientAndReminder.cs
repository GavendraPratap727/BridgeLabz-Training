using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
    class QuotientAndReminder
    {
        public static int[] FindRemainderAndQuotient(int number, int divisor) //method to find result
        {
            int q = number / divisor; //formula to find result
            int r = number % divisor;
            int[] arr = { q ,r }; //store ans in array

            return arr;
        }
       public  static void Main(String[] args)
        {
            Console.Write("Enter the number");
            int n= int.Parse(Console.ReadLine()); //input number and divisor
            Console.Write("Enter the divisor ");
            int di = int.Parse(Console.ReadLine());
            int[] re = FindRemainderAndQuotient(n, di);
            Console.WriteLine("Quotient is: " + re[0]);
            Console.WriteLine("Remainder is: " + re[1]);
        }
    }

}
