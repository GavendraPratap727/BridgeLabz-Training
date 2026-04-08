using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{

    class NoOfRounds
    {
        
        public static double CalculateRounds(double a, double b, double c)
        {
            double perimeter = a+b+c;   // perimeter in meter
            double totalDistance = 5000; // 5 km = 5000 meter
            return totalDistance / perimeter;
        }

        public static void Main(String[] args)
        {
           
            Console.Write("Enter side 1 of the  park (in meters)"); //input all three side of the park
            double a= double.Parse(Console.ReadLine());
            Console.Write("Enter side 2 of the park (in meters): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side 3 of the park (in meters): ");
            double c = double.Parse(Console.ReadLine());
            double res = CalculateRounds(a, b, c); //call the method to find the no of rounds
            Console.WriteLine("No. of rounds  " + res);
        }
    }

}
