using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class RotateElements
    {
        static void Main()
        {
            List<int> list = new List<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter rotation count: ");
            int k = int.Parse(Console.ReadLine());

            RotateLeft(list, k);

            Console.WriteLine("Rotated List:");
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }
        }

        static void RotateLeft(List<int> list, int k)
        {
            int n = list.Count;
            k = k % n;   // handle large rotations

            for (int i = 0; i < k; i++)
            {
                int first = list[0];
                list.RemoveAt(0);
                list.Add(first);
            }
        }
    }
}
