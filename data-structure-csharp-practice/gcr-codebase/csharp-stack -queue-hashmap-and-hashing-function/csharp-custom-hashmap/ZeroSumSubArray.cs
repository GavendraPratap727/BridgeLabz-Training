using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function.HashMaps
{
    using System;

    class ZeroSumSubArray
    {
        static void Main()
        {
            int[] arr = { 4, 2, -3, 1, 6 };
            CustomHashMap map = new CustomHashMap();
            int sum = 0;
            map.Put(0, 1);
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (map.ContainsKey(sum))
                    Console.WriteLine("Zero sum subarray found ending at index " + i);
                map.Put(sum, 1);
            }
        }
    }

}
