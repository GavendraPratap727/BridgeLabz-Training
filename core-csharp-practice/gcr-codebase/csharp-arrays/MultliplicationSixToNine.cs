using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class MultliplicationSixToNine
    {
        static void Main(String [] args)
        {
            Console.WriteLine("Enter a number to get its table form 6 to 9");
            int n=int.Parse(Console.ReadLine()); //Enter a number to get its table form 6 to 9
            int[] mul = new int[4]; //make array of size 4
            int j = 0;
            for(int i = 6; i <= 9; i++) //use for loop to store results in mul array
            {
                mul[j++] = n * i;
            }
            j = 0;
            for (int i = 6; i <=9; i++) //this loop is for display the result
            {
                Console.WriteLine($"{n} * {i} = {mul[j++]}");
                
            }
        }
    }
}
