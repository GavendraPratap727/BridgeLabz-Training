using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.RunTime
{
    internal class FileRead
    {
        static void Main()
        {
            string path = "largefile.txt";

            if (!File.Exists(path))
            {
                CreateLargeFile(path, 50); // size in MB
                Console.WriteLine("File created");
            }

            Stopwatch watch = new Stopwatch();

            watch.Start();
            ReadByStreamReader(path);
            watch.Stop();
            Console.WriteLine("StreamReader Time: " + watch.ElapsedMilliseconds + " ms");

            watch.Reset();

            watch.Start();
            ReadByFileStream(path);
            watch.Stop();
            Console.WriteLine("FileStream Time: " + watch.ElapsedMilliseconds + " ms");
        }

        static void CreateLargeFile(string path, int sizeMB)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                byte[] data = Encoding.UTF8.GetBytes(new string('A', 1024));
                for (int i = 0; i < sizeMB * 1024; i++)
                    fs.Write(data, 0, data.Length);
            }
        }

        static void ReadByStreamReader(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Read() != -1) { }
            }
        }

        static void ReadByFileStream(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] buffer = new byte[8192];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
        }
    }
}
