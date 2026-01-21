using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class FindSubset
    {
        static void Main()
        {
            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();

            Console.Write("Enter number of elements in Set A: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements of Set A:");
            for (int i = 0; i < n1; i++)
            {
                setA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter number of elements in Set B: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements of Set B:");
            for (int i = 0; i < n2; i++)
            {
                setB.Add(int.Parse(Console.ReadLine()));
            }

            bool isSubset = IsSubset(setA, setB);

            Console.WriteLine("Is Set A a subset of Set B? " + isSubset);
        }

        static bool IsSubset(HashSet<int> a, HashSet<int> b)
        {
            foreach (int x in a)
            {
                if (!b.Contains(x))
                    return false;
            }
            return true;
        }
    }
}
