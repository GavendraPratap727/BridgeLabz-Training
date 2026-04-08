using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
    internal class TempConver
    {
        static double Ctof(double c)
        {
            return (c*9/5)+32;
        }

        static double Ftoc(double f)
        {
            return (f-32)*5/9;
        }

        static void Main(String[]args)
        {
            Console.Write("Enter temperature ");
            double temp = double.Parse(Console.ReadLine());
            Console.Write("Enter type (C/F) ");
            char type = char.ToUpper(Console.ReadLine()[0]);
            if (type == 'C')
                Console.WriteLine("Fahrenheit: " + Ctof(temp));
            else
                Console.WriteLine("Celsius: " + Ftoc(temp));
        }
    }
}
