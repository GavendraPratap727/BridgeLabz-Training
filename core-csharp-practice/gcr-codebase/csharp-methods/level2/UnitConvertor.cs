using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{

    class UnitConvertor
    {
        public static double YardsToFeet(double yards)
        {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        public static double FeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        public static double MetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        public static double InchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        public static double InchesToCentimeters(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }

        public static void Main(String[] args)
        {
            Console.Write("Enter yards ");
            double yards = double.Parse(Console.ReadLine());
            Console.WriteLine("Feet = " + YardsToFeet(yards));
            Console.Write("Enter feet ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine(" Yards = " + FeetToYards(feet));
            Console.Write("Enter meters ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine("Inches = " + MetersToInches(meters));
            Console.Write("Enter inches ");
            double inches= double.Parse(Console.ReadLine());
            Console.WriteLine("Meters = " + InchesToMeters(inches));
            Console.WriteLine("Centimeters = " + InchesToCentimeters(inches));
        }
    }

}
