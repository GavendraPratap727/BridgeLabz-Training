using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class UnionIntersection
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

            HashSet<int> union = new HashSet<int>();
            HashSet<int> intersection = new HashSet<int>();

            // Union
            foreach (int x in set1)
                union.Add(x);

            foreach (int x in set2)
                union.Add(x);

            // Intersection
            foreach (int x in set1)
            {
                if (set2.Contains(x))
                    intersection.Add(x);
            }

            Console.WriteLine("\nUnion:");
            foreach (int x in union)
                Console.Write(x + " ");

            Console.WriteLine("\nIntersection:");
            foreach (int x in intersection)
                Console.Write(x + " ");
        }
    }
}
