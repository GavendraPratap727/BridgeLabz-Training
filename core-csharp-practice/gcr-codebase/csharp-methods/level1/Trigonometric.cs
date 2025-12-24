using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
    class Trigonometry
    {
        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            double r = angle * Math.PI / 180;

            double sin= Math.Sin(r);
            double cos = Math.Cos(r);
            double tan = Math.Tan(r);
            double []arr= {sin,cos,tan };
            return arr;
        }
       public static void Main(String[] args)
        {
            Console.Write("Enter angle in degrees to find ans "); 
            double angle = double.Parse(Console.ReadLine()); //taking angle input
            double[] res = CalculateTrigonometricFunctions(angle); //call fun to find result
            Console.WriteLine("Sin = " + res[0]);
            Console.WriteLine("Cos= " + res[1]);
            Console.WriteLine("Tan = " + res[2]);
        }
    }

}
