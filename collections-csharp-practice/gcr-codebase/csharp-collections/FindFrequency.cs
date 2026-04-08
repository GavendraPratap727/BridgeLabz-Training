using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class FindFrequency
    {
        static void Main()
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter strings:");
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                if (freq.ContainsKey(word))
                {
                    freq[word] = freq[word] + 1;
                }
                else
                {
                    freq.Add(word, 1);
                }
            }

            Console.WriteLine("\nFrequency of elements:");
            foreach (var item in freq)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
