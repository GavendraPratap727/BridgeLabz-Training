using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
   class MeanHeight
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the height of all 11 players of the football team");
            double[] arr = new double[11]; //create array to store all 11 players height
            double sum = 0.0;
            for (int i = 0; i < 11; i++)
            {
                arr[i] = double.Parse(Console.ReadLine()); //input height
                sum += arr[i]; //find the sum of all players height
            }
            double mean = sum / 11;

            Console.WriteLine($"the mean of all players is {mean}");
        }
    }
}
