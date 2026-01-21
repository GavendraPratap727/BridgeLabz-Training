using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class ReverseList
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            Console.Write("Enter number of elements ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                list.AddLast(int.Parse(Console.ReadLine()));
            }

            ReverseLinkedList(list);

            Console.WriteLine("Reversed LinkedList:");
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }
        }

        static void ReverseLinkedList(LinkedList<int> list)
        {
            LinkedList<int> temp = new LinkedList<int>();

            while (list.Count > 0)
            {
                temp.AddFirst(list.First.Value);
                list.RemoveFirst();
            }

            foreach (int x in temp)
            {
                list.AddLast(x);
            }
        }
    }
}
