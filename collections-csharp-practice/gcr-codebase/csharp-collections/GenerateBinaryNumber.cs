using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class GenerateBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");

            Console.WriteLine("Binary numbers:");

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                Console.Write(current + " ");

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }
        }
    }
}
