using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class FindMax
    {
        static int find(int n1, int n2, int n3) {
            return Math.Max(n1, Math.Max(n2, n3));
        }
        static void Main(String[] args)
        {
            Console.WriteLine("enter 3 numbers");
            int n1=int.Parse(Console.ReadLine());
            int n2=int.Parse(Console.ReadLine());
            int n3=int.Parse(Console.ReadLine());
            int res = find(n1, n2, n3);
            Console.WriteLine("Maximum of these is " + res);
        }
    }
}
