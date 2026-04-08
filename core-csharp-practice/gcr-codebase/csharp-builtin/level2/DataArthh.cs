using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
    internal class DataArthh
    {
        static void Main(String[] args)
        {
            Console.Write("Enter date:");
            DateTime d = DateTime.Parse(Console.ReadLine());
            d = d.AddDays(7);
            d = d.AddMonths(1);
            d = d.AddYears(2);
            d = d.AddDays(-21);
            Console.WriteLine("Final date:" + d.ToShortDateString());
        }
    }
}
