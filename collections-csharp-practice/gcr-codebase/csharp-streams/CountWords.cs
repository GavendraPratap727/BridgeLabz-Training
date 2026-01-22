using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class CountWords
    {

        static void Main()
        {
            string filePath = "input.txt";

            try
            {
                // STEP 1: Create file with content if not exists
                if (!File.Exists(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine("This is a test file");
                        writer.WriteLine("This file is used to test word count");
                        writer.WriteLine("This test file contains test words");
                    } // writer closes & flushes here
                }

                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                // STEP 2: Read file line by line
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(
                            new char[] { ' ', ',', '.', ';', ':', '!', '?', '\t' },
                            StringSplitOptions.RemoveEmptyEntries
                        );

                        foreach (string w in words)
                        {
                            string word = w.ToLower();

                            if (wordCount.ContainsKey(word))
                                wordCount[word]++;
                            else
                                wordCount[word] = 1;
                        }
                    }
                }

                // STEP 3: Display result
                if (wordCount.Count == 0)
                {
                    Console.WriteLine("No words found in file.");
                    return;
                }

                Console.WriteLine("Top frequent words:");
                Console.WriteLine("-------------------");

                foreach (var item in wordCount
                         .OrderByDescending(x => x.Value)
                         .Take(5))
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
        }
    }
}