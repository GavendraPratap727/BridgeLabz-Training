using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Liner_ans_Bin.StriinngBuilder
{
    internal class StringPerformance
    {
        static void Main(String[] args)
        {
            int times = 100000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                sb.Append("A");
            }
            sw.Stop();
            Console.WriteLine("Time taken by StringBuilder: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
