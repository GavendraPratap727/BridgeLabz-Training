using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
   
    class SimpleInterest
    {
        public static double CalculateSI(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100; //formula for SI
        }

        static void Main(string[] args)
        {
           
            Console.Write("Enter Principal  "); // enter principal rate and time
            double pri = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate  ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Time ");
            double time = double.Parse(Console.ReadLine());
            double si = CalculateSI(pri, rate, time); //funcall to cal the SI

            Console.WriteLine("The Simple Interest is " + si +" for Principal " + pri + "   Rate of Interest " + rate + " and Time " + time);
        }
    }

}
