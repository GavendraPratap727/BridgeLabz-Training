using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl2
{
    class WhoYoungestAndTallest
    {
        public static int ab(int[] x)
        {
            int res = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] < x[res])
                {
                    res = i;
                }
            }
            return res;
        }

        static int temp(double[] x)
        {
            int count = 0;
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > x[count])
                {
                    count = i;
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            string[] arr = { "Amar", "Akbar", "Anthony" };
            int[] age = new int[3];




            double[] height = new double[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("For " + arr[i]);
                Console.Write("Enter age ");
                age[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter height ");
                height[i] = Convert.ToDouble(Console.ReadLine());
            }
            int res = ab(age);
            int count = temp(height);




            Console.WriteLine("Youngest Friend is " + arr[res]);
            Console.WriteLine("Tallest Friend is " + arr[count]);
        }
    }

}
