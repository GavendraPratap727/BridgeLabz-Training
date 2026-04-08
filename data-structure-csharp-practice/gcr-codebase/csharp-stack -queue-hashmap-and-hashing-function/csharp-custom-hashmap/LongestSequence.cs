using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function.HashMaps
{
    internal class LongestSequence
    {
     


        static void Main()
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };
            CustomHashMap map = new CustomHashMap();

            for (int i = 0; i < arr.Length; i++)
                map.Put(arr[i], 1);

            int longest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i] - 1))
                {
                    int curr = arr[i];
                    int count = 1;

                    while (map.ContainsKey(curr + 1))
                    {
                        curr++;
                        count++;
                    }

                    if (count > longest)
                        longest = count;
                }
            }

            Console.WriteLine("Longest consecutive length: " + longest);
        }
    }

}

