using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class InvertMap
    {
        static void Main()
        {
            // Original Dictionary
            Dictionary<string, int> original = new Dictionary<string, int>();
            original.Add("A", 1);
            original.Add("B", 2);
            original.Add("C", 1);

            // Inverted Dictionary
            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            foreach (var pair in original)
            {
                int value = pair.Value;
                string key = pair.Key;

                if (!inverted.ContainsKey(value))
                {
                    inverted[value] = new List<string>();
                }

                inverted[value].Add(key);
            }

            // Print result
            Console.WriteLine("Inverted Map:");
            foreach (var pair in inverted)
            {
                Console.Write(pair.Key + " = [ ");
                foreach (string k in pair.Value)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
