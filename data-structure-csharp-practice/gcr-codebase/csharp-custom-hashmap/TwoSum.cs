using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function.HashMaps
{
    class TwoSum
    {
        static void Main()
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;

            CustomHashMap map = new CustomHashMap();

            for (int i = 0; i < arr.Length; i++)
            {
                int need = target - arr[i];

                if (map.ContainsKey(need))
                {
                    Console.WriteLine("Indices: " + map.Get(need) + " and " + i);
                    return;
                }

                map.Put(arr[i], i);
            }
        }
    }

}
