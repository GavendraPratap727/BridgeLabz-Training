using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class WhoYongestAndTallest
    {
      
           static void Main(String[] args)
            {   
                string[] arr = { "Amar", "Akbar", "Anthony" };
                int[] age = new int[3];
                double[] height = new double[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"for {arr[i]}");
                Console.Write("Enter age ");
                age[i] = int.Parse(Console.ReadLine());
                Console.Write("Enter height ");
                height[i] = int.Parse(Console.ReadLine());
            }
                int l = 0;
                int m= 0;
                for (int i = 1; i < 3; i++)
                {
                    if (age[i] < age[l]) l = i;

                if (height[i] > height[m]) m = i;

            }
                Console.WriteLine("Youngest Friend  is " + arr[l]);
                Console.WriteLine("Tallest Friend  is " + arr[m]);
            }
        }
    }
