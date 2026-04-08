using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
    class IndexExpe
    {
        static void GenerateException()
        {
            string s = "Hello";
            Console.WriteLine(s[10]); 
        }

        static void Main(string[] args)
        {
            try
            {
                GenerateException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException caught");
                Console.WriteLine(e.Message);
            }

        }
    }

}
