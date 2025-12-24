using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{


    class NoOfHandshakes2
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine()); //input number of student

            int handshakes = (n * (n - 1)) / 2; ; // formula to find the max number of handshakes

            Console.WriteLine("The maximum number of handshakes between " + n + " no. students is " + handshakes);
        }
    }

}
