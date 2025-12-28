using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Builtin
{
    class TimeZone
    {
        static void Main()
        {
            DateTimeOffset u = DateTimeOffset.UtcNow;
            TimeZoneInfo g = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            TimeZoneInfo i = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo p = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            Console.WriteLine("GMT:" + TimeZoneInfo.ConvertTime(u, g));
            Console.WriteLine("IST:" + TimeZoneInfo.ConvertTime(u, i));
            Console.WriteLine("PST:" + TimeZoneInfo.ConvertTime(u, p));
        }
    }
}
