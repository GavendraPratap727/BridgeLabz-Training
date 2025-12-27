using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{

    class NullExpection
    {
        static void Expections()
        {
            string name = null;   
            Console.WriteLine(name.Length);
        }

        static void Main(string[] args)
        {
            try
            {
                Expections();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception caught NullReferenceException");
                Console.WriteLine(e.Message);
            }
            //Console.ReadKey();
        }
    }

}
