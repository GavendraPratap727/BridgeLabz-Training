using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{

    class IndexOutOfRangeArrays
    {
        static void GenerateException()
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[5]); 
        }

        static void Main(string[] args)
        {
            try
            {
                GenerateException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Out Of Range Exception c");
                Console.WriteLine(e.Message);
            }

        }
    }

}
