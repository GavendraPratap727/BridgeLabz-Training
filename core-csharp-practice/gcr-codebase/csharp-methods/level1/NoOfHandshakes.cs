using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
  

    class NoOfHandshakes
    {
        
        public static int CalHand(int n)
        {
            return (n * (n - 1)) / 2;
        }

       public  static void Main(string[] args)
        {
        
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine()); //input number of student

            int handshakes = CalHand(n); // call to find the max number of handshakes

            Console.WriteLine("The maximum number of handshakes among "+ n+ " students is " + handshakes);
        }
    }

}
