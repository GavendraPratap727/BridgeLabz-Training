using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class DataCamparison
    {
        static void Main()
        {
            Console.Write("Enter first date:");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter second date:");
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            if (d1 < d2) Console.WriteLine("First is before second");
            else if (d1 > d2) Console.WriteLine("First is after second");
            else Console.WriteLine("Both are same");
        }
    }
}
