using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class Calculator
    {
        static double Add(double x,double y)
        {
            return x+y;
        }
        static double Subtract(double x,double y)
        {
            return x-y;
        }
        static double Multiply(double x,double y)
        {
            return x*y;
        }

        static double Divide(double x,double y)
        {
            return x/y;
        }

        static void Main(String[]args)
        {
            Console.Write("Enter first number: ");
            double num1=double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2=double.Parse(Console.ReadLine());
            Console.Write("Choose operation(+ - * /) ");
            char ch = Console.ReadLine()[0];

            if (ch=='+')
            {
                Console.WriteLine("Result "+Add(num1,num2));
            }
            else if (ch=='-')
            {
                Console.WriteLine("Result "+Subtract(num1,num2));
            }
            else if (ch == '*')
            {
                Console.WriteLine("Result "+Multiply(num1,num2));
            }
            else if (ch=='/')
            {
                Console.WriteLine("Result "+Divide(num1,num2));
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
