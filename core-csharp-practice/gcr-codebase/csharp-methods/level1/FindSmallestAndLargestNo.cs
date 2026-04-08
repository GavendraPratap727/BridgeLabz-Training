using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
    class FindSmallestAndLargestNo
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)// method to find smallest and largest
        {
            int sm = number1;
            int lr = number1;

            if (number2 < sm)
                sm = number2;
            if (number3 < sm)
                sm = number3;

            if (number2 > lr)
                lr = number2;
            if (number3 > lr)
                lr = number3;
            int[] arr = { sm, lr };

            return arr;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number ");
            int num1 = int.Parse(Console.ReadLine()); //enter 3 numbers
            Console.Write("Enter second number ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number ");
            int num3 = int.Parse(Console.ReadLine());
            int[] res = FindSmallestAndLargest(num1, num2, num3);  // call method to find smallest and largest
            Console.WriteLine("Smallest number is " + res[0]+ " and Largest number is " + res[1]);
        }
    }

}
