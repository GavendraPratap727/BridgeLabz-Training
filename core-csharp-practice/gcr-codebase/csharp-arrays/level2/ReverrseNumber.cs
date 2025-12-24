using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
    
         class ReverseNumber
        {
             static void Main(String[] args)
            {
                Console.WriteLine("Enter a number ");
                int n = int.Parse(Console.ReadLine()); //input a number

                if (n == 0) Console.WriteLine("Reverse number of 0 is 0");
                int temp = n;
                int count = 0;
                while (temp != 0)
                {
                    count++;
                    temp = temp / 10;

                }
               
                int[] revenum = new int[count];

                temp = n;

                for (int i = 0; i < count; i++) //store reverse number into a array namde revenum
                {
                    revenum[i] = temp % 10;
                    temp /= 10;

                }


                Console.Write($"Reverse number of {n} is  ");
                for (int i = 0; i < count; i++)
                {

                    Console.Write(revenum[i]);
                }


            }
        }
    }

