using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Exceptions
{
    internal class FinallyBlock
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine("Result " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed");
            }
            finally
            {
                Console.WriteLine("Operation completed");
            }
        }
    }
}
