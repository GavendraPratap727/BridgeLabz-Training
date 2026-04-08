using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class FindNthElement
    {
        static void Main()
        {
            LinkedList<string> list = new LinkedList<string>();

            Console.Write("Enter number of elements: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < count; i++)
            {
                list.AddLast(Console.ReadLine());
            }

            Console.Write("Enter N (from end): ");
            int n = int.Parse(Console.ReadLine());

            string result = FindNthFromEnd(list, n);

            Console.WriteLine("Nth element from end: " + result);
        }

        static string FindNthFromEnd(LinkedList<string> list, int n)
        {
            LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;

            // move first pointer n steps ahead
            for (int i = 0; i < n; i++)
            {
                if (first == null)
                    return "N is greater than list length";

                first = first.Next;
            }

            // move both pointers together
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            return second.Value;
        }
    }
}
