using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method
{
    using System;

    class SpringSeason
    {
        static bool Abc(int m, int d)
        {
            if ((m == 3 && d >= 20) || (m== 4) || (m == 5) || (m == 6 && d <= 20))return true;
            
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter month and date in numbers  ");
            int m =int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            bool res = Abc(m, d);
            if (res) Console.WriteLine("Spring Season");
            else
                Console.WriteLine("Not a Spring Season");
        }
    }

}
