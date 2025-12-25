using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
   public  class UnitConvertor2
    {
        public static double tempToCel(double ab)
        {
            double temp = (ab - 32) * 5 / 9;
            return temp;
        }

        public static double celToTemp(double ab)
        {
            double temp = (ab * 9 / 5) + 32;
            return temp;
        }

        public static double poundToKg(double ab)
        {
            double res = ab * 0.453592;
            return res;
        }

        public static double kgToPound(double ab)
        {
            double res = ab * 2.20462;
            return res;
        }

        public static double gallonToLiter(double ab)
        {
            double res = ab * 3.78541;
            return res;
        }
        public static double literToGallon(double ab)
        {
            double res = ab * 0.264172;
            return res;
        }

       public  static void Main(String[] args)
        {
            Console.Write("Enter temperature in Fahrenheit ");
            double ab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius = " + tempToCel(ab));

            Console.Write("Enter temperature in Celsius ");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fahrenheit = " + celToTemp(temp));

            Console.Write("Enter weight in pounds");
            double count = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilograms = " + poundToKg(count));

            Console.Write("Enter weight in kilograms ");
            double res = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pounds = " + kgToPound(res));

            Console.Write("Enter volume in gallons: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gallons to Liters = " + gallonToLiter(x));

            Console.Write("Enter volume in liters ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Liters to Gallons = " + literToGallon(y));
        }
    }

}
