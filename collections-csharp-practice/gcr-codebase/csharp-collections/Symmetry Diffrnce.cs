using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class Symmetry_Diffrnce
    {
        static void Main()
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            Console.Write("Enter number of elements in Set 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements of Set 1:");
            for (int i = 0; i < n1; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter number of elements in Set 2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements of Set 2:");
            for (int i = 0; i < n2; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> result = new HashSet<int>();

            // Elements in set1 but not in set2
            foreach (int x in set1)
            {
                if (!set2.Contains(x))
                    result.Add(x);
            }

            // Elements in set2 but not in set1
            foreach (int x in set2)
            {
                if (!set1.Contains(x))
                    result.Add(x);
            }

            Console.WriteLine("\nSymmetric Difference:");
            foreach (int x in result)
            {
                Console.Write(x + " ");
            }
        }
    }
}
