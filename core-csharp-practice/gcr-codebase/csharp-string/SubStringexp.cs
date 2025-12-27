using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
    class SubStringexp
    {
        static void GenerateException()
        {
            string s = "Programming";
            Console.WriteLine(s.Substring(8, 10));
        }

        static void Main(string[] args)
        {
            try
            {
                GenerateException();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ArgumentOutOfRangeException ");
                Console.WriteLine(e.Message);
            }

        }
    }

}
