using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace bridge.Senario
{
    class MathematicalOperation
    {
        // Menu method to choose different mathematical operations
        static void MathOperationMenu() {
            while (true)
            {
                Console.WriteLine("CHOOSE THE OPERATION U WANT TO PERFORM");
                Console.WriteLine("PRESS 1: FOR FACTORIAL");
                Console.WriteLine("PRESS 2: TO CHECK PRIME");
                Console.WriteLine("PRESS 3: TO FIND GCD OF TWO NUMBERS");
                Console.WriteLine("PRESS 4: FIND Nth FIBONACCI NUMBER");
                Console.WriteLine("PRESS 5: FOR EXIT");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Factorial();
                        break;
                    case 2:
                        CheckPrime();
                        break;
                    case 3:
                        GCD();
                        break;
                    case 4:
                        FindNthFibonacci();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
            }
            
        }
        // Method to calculate factorial of a number
        static void Factorial() {
            Console.WriteLine("Enter the number");
            int number= int.Parse(Console.ReadLine());
            int res = 1;
            if (number < 0) {
                Console.WriteLine("Invalid input enter positive numbers");
                return;
            }
            for (int i = 1; i <= number; i++) {
                res *= i;
            }
            Console.WriteLine("Factorial = " + res);
        }
        // Method to check whether a number is prime or not
        static void CheckPrime() {
            Console.WriteLine("Enter a number to check prime");
            int number= int.Parse(Console.ReadLine());
            bool res = true;
            if (number <= 1)
            {

                Console.WriteLine("Invalid inpput enter number greater than equal to 2");
            }
            {
                
            }
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    res = false;
                    break;
                }
            }
            if (res) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");

        }
        // Method to find GCD of two numbers
        public static void GCD()
        {
            Console.WriteLine("Enter two numbers");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1 <= 0 || number2 <= 0) {
                Console.WriteLine("Invalid input plls enter number greater than 0");
                return;
            }
            int gcd = 1;
            int min = number1 < number2 ? number1 : number2;
            for (int i = 2; i < min; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    gcd = i;
                }

            }
            Console.WriteLine("The GCD of two numbers is : " + gcd);
        }
        // Method to find nth Fibonacci number (1-based indexing)
        static void FindNthFibonacci() {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int a=0,b=1,c = 0;
            if (number <= 0)
            {
                Console.WriteLine("Invalid Input :Enter number greater than 0");
                return;
            }
            else if(number == 1)
            {
                Console.WriteLine("The nth  fibonacci number is " + a);
                return;
            }
            else if(number == 2)
            {
                Console.WriteLine("The nth  fibonacci number is " + b);
                return;
            }
            else
            {
                for (int i = 3; i <= number; i++) {
                    c =a+b;
                    a =b;
                    b =c;
                }
                Console.WriteLine("The nth  fibonacci number is " + c);
            }


        }

        // Main method - program execution starts here
        static void Main(string[] args)
        {
            MathOperationMenu(); //call menu method
        }
    }
}
