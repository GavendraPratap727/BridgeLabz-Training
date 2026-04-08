using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.kuch_bhi
{
   class FindTotleOfNumber
    {
        static void Main(string[] args) {
            double[] num = new double[10];
            Console.WriteLine("Enter numbers maximum 10 and press 0 or any negative number for stop");
            double totle = 0.0;
            int i = 0;
            while(true)
            {
                num[i]=double.Parse(Console.ReadLine());
                if (num[i] <= 0) break;
                if (i == 10) break;
                totle += num[i];
               
                
            }
            Console.WriteLine("Sum of all numbers " + totle);
        }
    }
}
