using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Collections.Streams
{
    internal class BufferdStream
    {
        static void Main()
        {
            string bigFile = "bigfile.dat";
            string normalCopy = "normal_copy.dat";
            string bufferedCopy = "buffered_copy.dat";

            // Create large file if not present (approx 100MB)
            if (!File.Exists(bigFile))
            {
                CreateLargeFile(bigFile);
            }

            Console.WriteLine("Starting normal FileStream copy...");
            long normalTime = CopyWithFileStream(bigFile, normalCopy);
            Console.WriteLine("Normal FileStream Time: " + normalTime + " ms");

            Console.WriteLine();

            Console.WriteLine("Starting BufferedStream copy...");
            long bufferedTime = CopyWithBufferedStream(bigFile, bufferedCopy);
            Console.WriteLine("BufferedStream Time: " + bufferedTime + " ms");
        }

        static void CreateLargeFile(string path)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                byte[] block = new byte[1024 * 1024]; // 1 MB block

                for (int i = 0; i < 100; i++) // 100 MB total
                {
                    fs.Write(block, 0, block.Length);
                }

                Console.WriteLine("Large file created successfully.");
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }

        static long CopyWithFileStream(string source, string destination)
        {
            Stopwatch watch = new Stopwatch();
            FileStream readFs = null;
            FileStream writeFs = null;

            try
            {
                readFs = new FileStream(source, FileMode.Open, FileAccess.Read);
                writeFs = new FileStream(destination, FileMode.Create, FileAccess.Write);

                byte[] buffer = new byte[4096]; // 4 KB chunk
                int bytesRead;

                watch.Start();
                while ((bytesRead = readFs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writeFs.Write(buffer, 0, bytesRead);
                }
                watch.Stop();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (readFs != null)
                    readFs.Close();

                if (writeFs != null)
                    writeFs.Close();
            }

            return watch.ElapsedMilliseconds;
        }

        static long CopyWithBufferedStream(string source, string destination)
        {
            Stopwatch watch = new Stopwatch();
            FileStream baseRead = null;
            FileStream baseWrite = null;
            BufferedStream bufferedRead = null;
            BufferedStream bufferedWrite = null;

            try
            {
                baseRead = new FileStream(source, FileMode.Open, FileAccess.Read);
                baseWrite = new FileStream(destination, FileMode.Create, FileAccess.Write);

                bufferedRead = new BufferedStream(baseRead, 4096);
                bufferedWrite = new BufferedStream(baseWrite, 4096);

                byte[] buffer = new byte[4096]; // 4 KB chunk
                int bytesRead;

                watch.Start();
                while ((bytesRead = bufferedRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedWrite.Write(buffer, 0, bytesRead);
                }
                watch.Stop();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (bufferedRead != null)
                    bufferedRead.Close();

                if (bufferedWrite != null)
                    bufferedWrite.Close();

                if (baseRead != null)
                    baseRead.Close();

                if (baseWrite != null)
                    baseWrite.Close();
            }

            return watch.ElapsedMilliseconds;
        }
    }
}
