using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    class QuadicEquation
    {
        static double[] ab(double a, double b, double c)
        {
            double temp = Math.Pow(b, 2) - 4 * a * c;

            if (temp > 0)
            {
                double x1 = (-b + Math.Sqrt(temp)) / (2 * a);
                double x2 = (-b - Math.Sqrt(temp)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (temp == 0)
            {
                double x = -b / (2 * a);
                return new double[] { x };
            }
            else
            {
                return new double[0];
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c ");
            double c = double.Parse(Console.ReadLine());
            double[] res = ab(a, b, c);
            if (res.Length == 2)
            {
                Console.WriteLine("Root 1" + res[0]);
                Console.WriteLine("Root 2 " + res[1]);
            }
            else if (res.Length == 1)
            {
                Console.WriteLine("Only one root: " + res[0]);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }

}
