using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class TwoSetEqual
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

            bool isEqual = AreSetsEqual(set1, set2);

            Console.WriteLine("Are both sets equal? " + isEqual);
        }

        static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            if (set1.Count != set2.Count)
                return false;

            foreach (int x in set1)
            {
                if (!set2.Contains(x))
                    return false;
            }

            return true;
        }
    }
}
