using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{

    class WindChill
    {
        static double CalculateWindChill(double temp, double windSpeed)
        {
            double res = 35.74+0.6215*temp+(0.4275 * temp - 35.75)*Math.Pow(windSpeed, 0.16);
            return res;
        }
       public static void Main(String[] args)
        {
            Console.Write("enter temperature in fahrenheit ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Enter wind speed in mph ");
            double w = double.Parse(Console.ReadLine());
            double res = CalculateWindChill(t, w);
            Console.WriteLine("The wind chill temperature is  " + res);
        }
    }

}
