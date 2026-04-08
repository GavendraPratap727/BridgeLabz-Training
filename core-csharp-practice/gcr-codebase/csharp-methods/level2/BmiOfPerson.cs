using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    class BmiOfPerson
    {
        static void bmi(double[,] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                double temp = arr[i, 1] / 100;
                arr[i, 2] = arr[i, 0] / (temp * temp);
            }
        }

        static string[] res(double[,] arr)
        {
            string[] temp = new string[10];

            for (int i = 0; i < 10; i++)
            {
                if (arr[i, 2] < 18.5)
                    temp[i] = "Underweight";
                else if (arr[i, 2] < 25)
                    temp[i] = "Normal";
                else if (arr[i, 2] < 30)
                    temp[i] = "Overweight";
                else
                    temp[i] = "Obese";
            }

            return temp;
        }

        static void Main(string[] args)
        {
            double[,] arr = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Person " + (i + 1));

                Console.Write("Enter weight (kg) ");
                arr[i, 0] = double.Parse(Console.ReadLine());

                Console.Write("Enter height (cm): ");
                arr[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            bmi(arr);
            string[] count = res(arr);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Person " + (i + 1));
                Console.WriteLine("BMI: " + arr[i, 2]);
                Console.WriteLine("Status: " + count[i]);
            }
        }
    }

}
