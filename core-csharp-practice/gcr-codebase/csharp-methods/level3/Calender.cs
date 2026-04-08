using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Method.lvl3
{
    class CalendarPrint
    {
        static string getMonthName(int m)
        {
            string[] months = {"January","February","March","April","May","June", "July","August","September","October","November","December"};
            return months[m - 1];
        }
        static bool isLeap(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                return true;
            else
                return false;
        }

        static int getDaysInMonth(int m, int y)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (m == 2 && isLeap(y))
                return 29;
            return days[m - 1];
        }

        static int getFirstDay(int m, int y)
        {
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter month (1-12): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int y= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("     " + getMonthName(m) + " " + y);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            int f = getFirstDay(m, y);
            int t = getDaysInMonth(m, y);

            for (int i = 0; i < f; i++)
            {
                Console.Write("    ");
            }

            for (int day = 1; day <= t; day++)
            {
                Console.Write("{0,3} ", day);

                if ((day + f) % 7 == 0)
                    Console.WriteLine();
            }

        }
    }

}
