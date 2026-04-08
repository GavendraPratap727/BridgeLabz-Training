using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.Opps_senario.Stack___Queue__HashMap_and_Hashing_Function
{
    
    class SlidingWindow
    {
        static void Main()
        {
            int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int k = 3;
            LinkedList<int> deque = new LinkedList<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }
                while (deque.Count > 0 && arr[deque.Last.Value] < arr[i])
                {
                    deque.RemoveLast();
                }
                deque.AddLast(i);
                if (i >= k - 1)
                {
                    Console.Write(arr[deque.First.Value] + " ");
                }
            }
        }
    }

}
