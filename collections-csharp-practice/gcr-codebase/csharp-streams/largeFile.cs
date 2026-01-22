using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class LargeFile
    {
        static void Main()
        {
            string filePath = "largefile.txt";

            StreamReader reader = null;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                reader = new StreamReader(filePath);

                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    // case-insensitive check
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

    }
}
