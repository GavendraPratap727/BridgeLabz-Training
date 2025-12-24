using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
     class Multiplication
    {
        static void Main(String[] args) {
            Console.WriteLine("Enter a number for its table"); //enter a number to get table
            int num=int.Parse(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine($"{num} * {i} = {(num * i)}"); //print table of that input
                
            }
        }
    }
}
