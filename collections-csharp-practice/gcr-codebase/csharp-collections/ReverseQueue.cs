using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class ReverseQueue
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(int.Parse(Console.ReadLine()));
            }

            Reverse(queue);

            Console.WriteLine("Reversed Queue:");
            foreach (int x in queue)
            {
                Console.Write(x + " ");
            }
        }

        static void Reverse(Queue<int> q)
        {
            if (q.Count == 0)
                return;

            int front = q.Dequeue();   // remove front
            Reverse(q);                // reverse remaining
            q.Enqueue(front);          // add back at end
        }
    }
}
