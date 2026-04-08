using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
    class NumberGuess
    {
        static void Main(String[] args) {
            Random r=new Random();
            int num = r.Next(1, 100);
            Console.WriteLine("guess the number between 1-100");
            bool res = false;
            int g;
            while (!res)
            {
                g=int.Parse(Console.ReadLine());
                if (g > num) Console.WriteLine("this is bigger  try again");
                else if (g < num) Console.WriteLine("this is smaller  try again");
                else res = true;
                
            }
            Console.WriteLine("yahh u got it right");
        }
    }
}
