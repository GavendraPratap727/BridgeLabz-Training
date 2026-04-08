using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class ByteArrayStream
    {
        static void Main()
        {
            string sourceImage = "original.jpg";
            string newImage = "copied.jpg";

            FileStream fileRead = null;
            FileStream fileWrite = null;

            try
            {
                if (!File.Exists(sourceImage))
                {
                    Console.WriteLine("Source image not found.");
                    return;
                }

                // Read image into byte array
                fileRead = new FileStream(sourceImage, FileMode.Open, FileAccess.Read);
                byte[] imageBytes = new byte[fileRead.Length];
                fileRead.Read(imageBytes, 0, imageBytes.Length);
                fileRead.Close();

                // Use MemoryStream to write byte array back to image
                MemoryStream memory = new MemoryStream(imageBytes);

                fileWrite = new FileStream(newImage, FileMode.Create, FileAccess.Write);
                memory.WriteTo(fileWrite);

                Console.WriteLine("Image converted to byte array and written successfully.");

                memory.Close();
                fileWrite.Close();

                // Verify size
                FileInfo original = new FileInfo(sourceImage);
                FileInfo copied = new FileInfo(newImage);

                if (original.Length == copied.Length)
                    Console.WriteLine("Verification successful: Files are identical.");
                else
                    Console.WriteLine("Verification failed: Files are different.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Error: " + ex.Message);
            }
            finally
            {
                if (fileRead != null)
                    fileRead.Close();

                if (fileWrite != null)
                    fileWrite.Close();
            }
        }
    }
}
