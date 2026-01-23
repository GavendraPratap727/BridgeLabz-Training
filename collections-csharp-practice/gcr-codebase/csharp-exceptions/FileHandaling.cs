using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Exceptions
{
    internal class FileHandaling
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine(firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}
