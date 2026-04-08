using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class RemoveDuplicate
    {
        static void Main()
        {
            List<int> original = new List<int>();
            List<int> result = new List<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                original.Add(int.Parse(Console.ReadLine()));
            }

            // removing duplicates while keeping order
            for (int i = 0; i < original.Count; i++)
            {
                int current = original[i];

                if (!result.Contains(current))
                {
                    result.Add(current);
                }
            }

            Console.WriteLine("List after removing duplicates:");
            foreach (int x in result)
            {
                Console.Write(x + " ");
            }
        }
    }
}
