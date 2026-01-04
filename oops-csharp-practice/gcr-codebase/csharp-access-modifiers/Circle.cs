using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Access_modifiers
{


    public class Circle
    {
        double radius;
        double areaOfCircle;
        double circumOfCircle;
        //parameterized constructor
        public Circle(double Radius)
        {
            this.radius = Radius;
        }


        //method to calculate area and circumference
        void AreaAndCircumference()
        {
            areaOfCircle = 3.14 * (radius * radius);
            circumOfCircle = 2 * 3.14 * radius;

        }
        //method to display area and circumference
        void DAreaAndCircumference()
        {
            Console.WriteLine("Area and circumference of circle are given below");
            Console.WriteLine("Area of Circle is " + areaOfCircle);
            Console.WriteLine("Circumference Of Circle Is  " + circumOfCircle);

        }
        //main method
        static void Main(string[] args)
        {
            Circle radius1 = new Circle(4);
            radius1.AreaAndCircumference();
            radius1.DAreaAndCircumference();

        }
    }
}


