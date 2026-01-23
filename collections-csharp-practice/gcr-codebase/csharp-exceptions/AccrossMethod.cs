using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Exceptions
{
    internal class AccrossMethod
    {
        static void Method1()
        {
            int x = 10 / 0;   // runtime exception here
        }

        static void Method2()
        {
            Method1();
        }

        static void Main(string[] args)
        {
            try
            {
                Method2();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Handled exception in Main");
            }

            Console.ReadLine(); // keeps console open
        }
    }
}
