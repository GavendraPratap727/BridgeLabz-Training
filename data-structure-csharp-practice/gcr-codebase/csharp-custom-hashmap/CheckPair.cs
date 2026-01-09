using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function.HashMaps
{
   
    class CheckPair
    {
        static void Main()
        {
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int target = 10;

            CustomHashMap map = new CustomHashMap();

            for (int i = 0; i < arr.Length; i++)
            {
                int need = target - arr[i];

                if (map.ContainsKey(need))
                {
                    Console.WriteLine("Pair found: " + arr[i] + " and " + need);
                    return;
                }

                map.Put(arr[i], 1);
            }

            Console.WriteLine("No pair found");
        }
    }

}
