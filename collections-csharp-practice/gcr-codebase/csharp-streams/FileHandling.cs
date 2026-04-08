using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class FileHandling
    {
        static void Main()
        {
            string sourcePath = "source.txt";
            string destinationPath = "destination.txt";

            FileStream sourceStream = null;
            FileStream destStream = null;

            try
            {
                // Create source file if it does not exist
                if (!File.Exists(sourcePath))
                {
                    sourceStream = new FileStream(sourcePath, FileMode.Create, FileAccess.Write);
                    byte[] data = Encoding.UTF8.GetBytes("This is a sample text file.");
                    sourceStream.Write(data, 0, data.Length);
                    sourceStream.Close();
                }

                // Open source file for reading
                sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);
                destStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[sourceStream.Length];
                sourceStream.Read(buffer, 0, buffer.Length);
                destStream.Write(buffer, 0, buffer.Length);

                Console.WriteLine("File read and written successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            finally
            {
                if (sourceStream != null)
                    sourceStream.Close();

                if (destStream != null)
                    destStream.Close();
            }
        }
    }
}
