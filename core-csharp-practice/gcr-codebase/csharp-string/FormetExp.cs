using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
    class FormetExp
    {
        static void GenerateException()
        {
            int num = int.Parse("abc"); 
        }

        static void Main(string[] args)
        {
            try
            {
                GenerateException();
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException caught");
                Console.WriteLine(e.Message);
            }

        }
    }

}
