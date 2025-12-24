using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
   
         class BmiOfPerson
        {
            static void Main(String[] args)
            {
                Console.WriteLine("Enter number of person");
                int np = int.Parse(Console.ReadLine());

                double[] weight = new double[np];
                double[] height = new double[np];
                double[] bmi = new double[np];
                string[] status = new string[np];

                Console.WriteLine("Enter weight and hieght of Person");
                for (int i = 0; i < np; i++)
                {

                    Console.WriteLine("Enter weight ");
                    weight[i] = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter height(cm) ");
                    height[i] = double.Parse(Console.ReadLine())/100;

                }

                //BMI status
                for (int i = 0; i < np; i++)
                {
                    bmi[i] = weight[i] / (height[i] * height[i]);
                 if (bmi[i] < 18.5) status[i] = "Underweight";
                else if (bmi[i] < 25) status[i] = "Normal";
                else if (bmi[i] < 30) status[i] = "Overweight";
                else status[i] = "Obese";
            }

                for (int i = 0; i < np; i++)
                {
                    Console.WriteLine("Person " + (i + 1));
                    Console.WriteLine("Height " + height[i] + " m");
                    Console.WriteLine("Weight " + weight[i] + " kg");
                    Console.WriteLine("BMI : " + bmi[i]);
                    Console.WriteLine("Status " + status[i]);
                }
            }
        }
    }
