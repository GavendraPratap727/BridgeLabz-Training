using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
   
    class LineOfDistance
    {
        static double findDistance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dist = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
            return dist;
        }

        static double[] findLine(double x1, double y1, double x2, double y2)
        {
            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - m * x1;
            return new double[] { m, b };
        }

        static void Main(string[] args)
        {
            Console.Write("Enter x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double distance = findDistance(x1, y1, x2, y2);
            double[] line = findLine(x1, y1, x2, y2);

            Console.WriteLine("Euclidean Distance = " + distance);
            Console.WriteLine("Equation of line: y = " + line[0] + "x + " + line[1]);
        }
    }

}
