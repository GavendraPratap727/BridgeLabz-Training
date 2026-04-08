using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class FrequencyDigits
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number"); //input a number
            int num=int.Parse(Console.ReadLine());
            if (num == 0) //if num ==0 than we do this
            {
                Console.WriteLine("Frequency of 0 in the number is 1");
                return;
            }
            int[] arr = new int[10]; //create a array of size 10 so we can store how much time digit 0-9 comes in the number
            while (num != 0) {
                int temp = num % 10;
                arr[temp]++;
                num = num / 10;
            }
            for (int i = 0; i < 10; i++) //print the answer
            {
                if (arr[i] > 0) {
                    Console.WriteLine($"Frequency of {i} in the number is {arr[i]}");
                }
                
            }
        }
    }
}
