using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class SetToList
    {
        static void Main()
        {
            HashSet<int> set = new HashSet<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            // Convert set to list
            List<int> sortedList = new List<int>();

            foreach (int x in set)
            {
                sortedList.Add(x);
            }

            // Sort list
            sortedList.Sort();

            Console.WriteLine("Sorted List:");
            foreach (int x in sortedList)
            {
                Console.Write(x + " ");
            }
        }
    }
}
