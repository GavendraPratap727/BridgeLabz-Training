using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
    using System;

    class CollinearCheck
    {
        static void Main()
        {
            Console.Write("Enter x for point 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y for point 1: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x for point 2: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y for point 2: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter x for point 3: ");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y for point 3: ");
            double f = Convert.ToDouble(Console.ReadLine());
            bool r1 = checkBySlope(a, b, c, d, e, f);
            bool r2 = checkByArea(a, b, c, d, e, f);

            if (r1)
                Console.WriteLine("Points are collinear using slope method");
            else
                Console.WriteLine("Points are not collinear using slope method");
            if (r2)
                Console.WriteLine("Points are collinear using area method");
            else
                Console.WriteLine("Points are not collinear using area method");
        }

        static bool checkBySlope(double a, double b, double c, double d, double e, double f)
        {
            double s1 = (d - b) / (c - a);
            double s2 = (f - d) / (e - c);
            double s3 = (f - b) / (e - a);

            double t = 0.0001;

            return Math.Abs(s1 - s2) < t &&
                   Math.Abs(s2 - s3) < t &&
                   Math.Abs(s1 - s3) < t;
        }
        static bool checkByArea(double a, double b, double c, double d, double e, double f)
        {
            double area = 0.5 * (a * (d - f) + c * (f - b) + e * (b - d));
            double t = 0.0001;
            return Math.Abs(area) < t;
        }
    }
}