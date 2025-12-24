using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class OperationOnArray
    {
        static void Main(String[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++) {
                if (arr[i] > 0)
                {
                    if (arr[i] % 2 == 0) Console.WriteLine($"The number {arr[i]} is a even number and positive ");
                    else Console.WriteLine($"The number {arr[i]} is a odd number and positive ");
                }
                else if (arr[i] < 0) Console.WriteLine("The number is negative");
                else Console.WriteLine("the number is zero");
                
            }
            if (arr[0] == arr[4]) Console.WriteLine("First and last element are equal");
            else if (arr[0] > arr[4]) Console.WriteLine("First is greater than last element ");
            else Console.WriteLine("First is smaller than last element ");


        }
    }
}
