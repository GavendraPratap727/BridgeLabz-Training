using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Strings
{
    class WordLength
    {
        static int len(string s)
        {
            int t = 0;
            foreach (char c in s)
            {
                t++;
            }
            return t;
        }

        static string[,] calc(string str)
        {
            string[] arr = new string[50];
            int k = 0;
            string s = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    s += str[i];
                }
                else
                {
                    if (s != "")
                    {
                        arr[k++] = s;
                        s = "";
                    }
                }
            }

            if (s != "")
            {
                arr[k++] = s;
            }

            string[,] res = new string[k, 2];

            for (int i = 0; i < k; i++)
            {
                res[i, 0] = arr[i];
                res[i, 1] = len(arr[i]).ToString();
            }

            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            string str = Console.ReadLine();
            string[,] res = calc(str);
            for (int i = 0; i < res.GetLength(0); i++)
            {
                Console.WriteLine(res[i, 0] + " " + res[i, 1]);
            }
        }
    }

}
