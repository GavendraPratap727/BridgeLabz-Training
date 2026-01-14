using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.RunTime
{
    internal class StringTest
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };

            foreach (int n in sizes)
            {
                Console.WriteLine("\nOperations: " + n);

                Stopwatch w = new Stopwatch();

                string s = "";
                w.Start();
                for (int i = 0; i < n; i++)
                    s += "a";
                w.Stop();
                Console.WriteLine("string time: " + w.ElapsedMilliseconds + " ms");

                w.Reset();

                StringBuilder sb = new StringBuilder();
                w.Start();
                for (int i = 0; i < n; i++)
                    sb.Append("a");
                w.Stop();
                Console.WriteLine("StringBuilder time: " + w.ElapsedMilliseconds + " ms");
            }
        }
    }
}
