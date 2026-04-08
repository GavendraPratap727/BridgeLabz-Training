using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Collection
{
    internal class WordFrequencyCounter
    {
        static void Main()
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();

            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            // convert to lowercase
            text = text.ToLower();

            // remove punctuation
            char[] symbols = { ',', '.', '!', '?', ';', ':' };
            foreach (char c in symbols)
            {
                text = text.Replace(c.ToString(), "");
            }

            // split into words
            string[] words = text.Split(' ');

            // count frequency
            foreach (string word in words)
            {
                if (word == "")
                    continue;

                if (freq.ContainsKey(word))
                    freq[word]++;
                else
                    freq.Add(word, 1);
            }

            Console.WriteLine("\nWord Frequency:");
            foreach (var item in freq)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
