using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    public class ConvertKmToMile
    {
        public static double Abc(double km)
        {
            double a = 0.621371;
            double res = km * a;
            return res;
        }

        public static double Cba(double miles)
        {
            double a = 1.60934;
            double res = miles * a;
            return res;
        }

        public static double ConvertMetersToFeet(double meters)
        {
            double a = 3.28084;
            double res = meters * a;
            return res;
        }

        public static double ConvertFeetToMeters(double feet)
        {
            double a = 0.3048;
            double res= feet * a;
            return res;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("enter disance in km ,miles meter,feet");
            double a=double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Km to miles " +Abc(a));
            Console.WriteLine("Miles to km" + Cba(b));
            Console.WriteLine("meters to feet " + ConvertMetersToFeet(c));
            Console.WriteLine("Feet to meters " +ConvertFeetToMeters(d));
        }
    }

}
