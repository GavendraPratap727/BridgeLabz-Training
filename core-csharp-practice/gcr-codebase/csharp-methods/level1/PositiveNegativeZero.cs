using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
    class PositiveNegativeZero
    {
        static int Check(int number)
        {
            if (number > 0)    return 1;    
            else if (number < 0) return -1;   
            else return 0;      
        }

      public  static void Main(String[] args)
        {
            Console.Write("Enter a number ");
            int n = int.Parse(Console.ReadLine());
            int res = Check(n);
            if (res == 1) Console.WriteLine("Positive");
            else if (res == -1) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");
        }
    }

}
