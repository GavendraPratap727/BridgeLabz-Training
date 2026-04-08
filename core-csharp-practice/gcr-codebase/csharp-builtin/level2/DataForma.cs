using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
     class DataForma
    {
        static void Main()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString("dd/MM/yyyy"));
            Console.WriteLine(d.ToString("yyyy-MM-dd"));
            Console.WriteLine(d.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
