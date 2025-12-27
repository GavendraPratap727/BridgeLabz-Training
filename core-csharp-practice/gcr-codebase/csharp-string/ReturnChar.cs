using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
   class ReturnChar
    {
        public static char[] cre(string str)
        {
            char[] res=new char[str.Length];
            for(int i=0;i< str.Length; i++)
            {
                res[i] = str[i];
                
            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine(); //input a string
            char[] res1 = cre(str); //calling cutom meathod to get res
            char[]res2= str.ToCharArray(); //calling inbuild meathod to get res
            Console.WriteLine("result by using custom func..");
            foreach(char c in res1)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("result by using inbuilt func..");
            foreach (char c in res2)
            {
                Console.Write(c + " ");
            }

        }
    }
}
